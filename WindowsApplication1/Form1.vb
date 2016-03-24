Imports Microsoft.Office.Interop.Excel
Imports System.IO

Public Class Monitoreo
#Region "Declaraciones"
    Private Estacionamentos(1, 20) As Integer                           'Información de estacionamientos: Estacionamiento -Duracion
    Private GPS(25, 2) As String                                    'Posición GPS
    Private CarpetaMes As String
    Private CarpetaAno As String
    Private ReporteTotal As Integer
    Private ReporteActual As Integer = 0
    Private GPS_NReg As Integer = 22                                'Número de datos GPS en la tabla
    Private Archivo As Microsoft.Office.Interop.Excel.Application   'Archivo de Excel a generar
    Private Libro As Microsoft.Office.Interop.Excel.Workbook        'Libro de Excel
    Private Hoja As Microsoft.Office.Interop.Excel.Worksheet        'Hoja de Excel
    Private Rango As Microsoft.Office.Interop.Excel.Range           'Celdas afectadas la hoja de Excel
    Private HoraInicio As String                    'Hora de inicio de reporte
    Private HoraActual As String                    'Hora actual del reporte
    Private HoraFinal As String                     'Hora del final del reporte
    Private HoraUltimoEstacionamiento As String     'Hora del ultimo estacionamiento
    Private FechaInicio As String                   'Fecha y hora del inicio del reporte
    Private FechaFinal As String                    'Fecha y hora del fin del reporte
    Private FechaIn As String                        'Fecha de inicio de reporte
    Private FechaFn As String                       'Fecha del final del reporte
    Private TotalMinutos As Integer                 'Total de los minutos involucrados en el reporte
    Private TotalMinutosReales As Integer           'Total de minutos reales ya sacando los estacionamientos
    Private NumeroEstacionamientos As Integer       'Número de estacionamientos en el reporte actual
    Private TotalMinutosEstacionamientos As Integer 'Total en minutos de los estacionamientos
    Private AreaEstacionamiento As Integer          'Espacio de minutos disponibles para cada estacionamiento
    Private Esp As Integer = 9                      'Espacio de encabezaro que se excluira en el rango. lineas
    Private Rdn As New Random()                     'Se utiliza para generar valores aleatorios
#End Region
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim i1 As Integer = 0
        Dim i2 As Integer
        Dim FechaA As String
        Dim Cont As Integer = 0

        'Validacion de datos
        If Not Validar() Then
            Exit Sub
        End If



        FechaA = txtFechaInicio.Text
        ReporteTotal = DateDiff(DateInterval.Day, CDate(txtFechaInicio.Text), CDate(txtFechaFin.Text))

        While CDate(FechaA) < CDate(txtFechaFin.Text)
            If CDate(FechaA).DayOfWeek = DayOfWeek.Sunday Then
                Cont += 1
            End If
            FechaA = CDate(FechaA).AddDays(1).ToString
        End While

        ReporteTotal -= Cont

        PB.Maximum = ReporteTotal

        txtProgreso.Text = "Progreso: " & "0 de " & ReporteTotal


        PB.Value = 0

        btnGenerar.Enabled = False
        '********************************************
        FechaIn = txtFechaInicio.Text
        i2 = ReporteTotal
        While CDate(FechaIn) < CDate(txtFechaFin.Text) Or i2 = 1
            i2 = 0
            If i1 = 0 Then
                FechaFn = txtFechaFin.Text
                i1 += 1
            Else
                FechaIn = CDate(FechaIn).AddDays(1)
                If CDate(FechaIn).DayOfWeek = DayOfWeek.Sunday Then
                    FechaIn = CDate(FechaIn).AddDays(1)
                End If
            End If

            NuevoDia()
            GenerarEncabezado()
            Inicializar()
            generar_registros()

            'Archivo.Visible = True
            Archivo.UserControl = True
            Try
                Libro.SaveAs(CarpetaMes & "\" & Format(CDate(FechaIn), "dd").ToString + " de " + StrConv(MonthName(Month(txtFechaInicio.Text)).ToString, 3).ToString + " del " + Year(txtFechaInicio.Text).ToString)
            Catch ex As Exception
                Archivo.Visible = True
                MsgBox("¡No se puede tener acceso a la ruta para guardar especificada!. ¡Por favor guarde manualmente este reporte!", vbOKOnly + vbExclamation, "Generador de reportes PCD")
            End Try

            ReporteActual += 1
            If ReporteActual <= PB.Maximum Then
                PB.Value = ReporteActual
            End If

            txtProgreso.Text = "Progreso: " & ReporteActual & " de " & ReporteTotal
            Archivo.Quit()
            Archivo = Nothing
        End While


        MsgBox("¡Se ha terminado de generar los reportes!", vbOK + vbInformation, "Generador de reportes PCD")

    End Sub
    Private Sub NuevoDia()
        'Fecha de Inicio y Fin

        If Not Directory.Exists(txtDireccion.Text & "\" & CDate(FechaIn).Year.ToString) Then
            Directory.CreateDirectory(txtDireccion.Text & "\" & CDate(FechaIn).Year.ToString)
            CarpetaAno = txtDireccion.Text & "\" & CDate(FechaIn).Year.ToString
        End If

        If Not Directory.Exists(CarpetaAno & "\" & StrConv(MonthName(Month(FechaIn)).ToString, 3).ToString) Then
            Directory.CreateDirectory(CarpetaAno & "\" & StrConv(MonthName(Month(FechaIn)).ToString, 3).ToString)
            CarpetaMes = CarpetaAno & "\" & StrConv(MonthName(Month(FechaIn)).ToString, 3).ToString
        End If


    End Sub
    Private Function Validar() As Boolean
        Dim ttt As String
        Dim fechafin As String

        'Limpieza de variables
        ReporteActual = 0



        '***********************************

        If txtDireccion.Text = "C:" Then
            MsgBox("¡Por favor seleccione un carpeta para guardar los reportes!", vbOKOnly + vbExclamation, "Generador de reportes PCD")
            Return False
        End If


        ttt = txtTTF1.Text
        If ttt = "a.m." Then
            fechafin = Format(CDate(txtFechaInicio.Text).AddDays(1), "dd/MM/yyyy").ToString
        Else
            fechafin = txtFechaInicio.Text
        End If


        TotalMinutos = DateDiff(DateInterval.Minute, CDate(txtFechaInicio.Text & " " & txtHI2.Text & ":" & txtMI2.Text & ":" & Rdn.Next(1, 60).ToString & " " & txtTTI2.Text), CDate(fechafin & " " & txtHF1.Text & ":" & txtMF1.Text & ":" & Rdn.Next(1, 60).ToString & " " & txtTTF1.Text))
        TotalMinutosEstacionamientos = Val(txtTotalHorasF.Text) * 60

        'Se comprueab que el total de minutos no sea menor al tiempo de estacionamiento
        If TotalMinutos < TotalMinutosEstacionamientos Then
            MsgBox("¡Por favor redusca la hora total maxima de estacionamiento!", vbOKOnly + vbExclamation, "Generador de reportes DPC")
            Return False
        Else
            TotalMinutos -= TotalMinutosEstacionamientos
            'Se comprueba que el tiempo de separacion * estacionamienots no sea mayor al total de minutos
            If (Val(txtTiempoSeparacion.Text) * (Val(txtNumeroEstacionamientoF.Text) + 1)) > TotalMinutos Then
                MsgBox("¡Por favor redusca la hora total maxima de estacionamiento ó redusca el tiempo de separación entre estacionamientos ó redusca el número de estacionamientos!", vbOKOnly + vbExclamation, "Generador de reportes DPC")
                Return False
            Else
                'Se comprueba que  el tiempo maximo de estacionamiento por el numero minimo de estacionamiento no sea menor a los minutos disponibles para estacionamiento
                If (Val(txtTiempoEstacionamientoF.Text) * Val(txtNumeroEstacionamientoI.Text)) < TotalMinutosEstacionamientos Then
                    MsgBox("¡Por favor aumente el tiempo máximo de estacionamiento ó aumente el número minimo de estacionamientos ó redusca la hora total maxima de estacionamiento!", vbOKOnly + vbExclamation, "Generador de reportes DPC")
                    Return False
                Else
                    Return True
                End If
            End If
        End If


    End Function
    Private Sub generar_registros()
        Dim TB(4, 1500) As String

        Dim i As Integer
        Dim i2 As Integer
        Dim i3 As Integer
        Dim i4 As Integer
        Dim aux As String
        Dim aux1 As String
        Dim aux2 As String

        'Rellenar campo movimiento
        i2 = 0

        For i = 0 To TotalMinutosReales - 1
            If i = 0 Then
                TB(0, i) = "Switche Enc ON"
            ElseIf i = TotalMinutosReales - 1 Then
                TB(0, i) = "Switche Enc OFF"
            Else
                TB(0, i) = "En Movimiento."
            End If

            TB(1, i) = Format(CDate(FechaInicio), "MM/dd/yyyy").ToString 'Formato para que excel lo reconosca bien

            TB(2, i) = Format(CDate(FechaInicio), "hh:mm:ss tt")

            aux = Format(CDate(FechaInicio), "tt").ToString
            aux1 = Format(CDate(FechaInicio), "dd/MM/yyyy hh:mm").ToString
            aux2 = Rdn.Next(1, 60).ToString

            If Estacionamentos(1, i2) = i + 1 Then
                FechaInicio = Format(CDate(aux1 & ":" & aux2 & " " & aux).AddMinutes(Estacionamentos(0, i2)), "dd/MM/yyyy hh:mm:ss tt").ToString
                i2 += 1
            Else
                FechaInicio = Format(CDate(aux1 & ":" & aux2 & " " & aux).AddMinutes(1), "dd/MM/yyyy hh:mm:ss tt").ToString
            End If

        Next

        For i = 0 To NumeroEstacionamientos - 1
            TB(0, Estacionamentos(1, i) - 1) = "Switche Enc OFF"
            TB(0, Estacionamentos(1, i)) = "Switche Enc ON"
        Next



        i2 = 1
        i3 = 0
        'Generar velocidades
        TB(3, 0) = "0 Km/h"
        TB(3, 1) = Rdn.Next(5, 18) & " Km/h"
        TB(3, 2) = Rdn.Next(15, 26) & " Km/h"



        For i = 3 To TotalMinutosReales - 1



            If TB(0, i - 3) = "Switche Enc ON" Then
                TB(3, i) = Rdn.Next(30, 48) & " Km/h"

            ElseIf TB(0, i - 2) = "Switche Enc ON" Then
                TB(3, i) = Rdn.Next(16, 25) & " Km/h"

            ElseIf TB(0, i - 1) = "Switche Enc ON" Then
                TB(3, i) = Rdn.Next(3, 12) & " Km/h"

            ElseIf TB(0, i + 3) = "Switche Enc OFF" Then
                TB(3, i) = Rdn.Next(30, 48) & " Km/h"

            ElseIf TB(0, i + 2) = "Switche Enc OFF" Then
                TB(3, i) = Rdn.Next(16, 25) & " Km/h"

            ElseIf TB(0, i + 1) = "Switche Enc OFF" Then
                TB(3, i) = Rdn.Next(3, 12) & " Km/h"

            ElseIf TB(0, i) = "Switche Enc ON" Or TB(0, i) = "Switche Enc OFF" Then
                TB(3, i) = "0 Km/h"

            Else
                TB(3, i) = Rdn.Next(53, 76) & " Km/h"
            End If



        Next






        For i = 10 To (TotalMinutosReales + 10)
            Hoja.Range("A" & i).Value = TB(0, i - 10)
            Hoja.Range("B" & i).Value = TB(1, i - 10)
            Hoja.Range("C" & i).Value = TB(2, i - 10)
            Hoja.Range("D" & i).Value = TB(3, i - 10)
        Next

        'For i = 0 To NumeroEstacionamientos - 1
        'Hoja.Range("A" & (Esp + Estacionamentos(1, i))).Value = "Switche Enc OFF"
        'Hoja.Range("A" & (Esp + Estacionamentos(1, i) + 1)).Value = "Switche Enc ON"
        'Next

    End Sub
    Private Sub Inicializar()
        Dim i As Integer
        Dim i2 As Integer
        Dim i3 As Integer
        Dim i4 As Integer
        Dim x As Integer
        Dim AnchoDeseado As Integer
        Dim ImagenX As Integer
        Dim ImagenY As Integer
        Dim EspacioEstacionamientos As Integer = 0          'Espacio minimo entre cada estacionamiento
        Dim Imagen3 As String = IO.Path.GetFullPath("Core\Firma.png")
        Dim Area2 As Integer
        Dim MinDisParaEstacionmiento As Integer
        Dim Porcentaje As Decimal = 0.6

        'Hora de inicio y fin
        HoraInicio = getHora(txtHI1.Text, txtMI1.Text, txtTTI1.Text, txtHI2.Text, txtMI2.Text, txtTTI2.Text)
        HoraFinal = getHora(txtHF1.Text, txtMF1.Text, txtTTF1.Text, txtHF2.Text, txtMF2.Text, txtTTF2.Text)
        'Hora actual se inicializa
        HoraActual = HoraInicio
        'Calcula número de estacionamientos
        NumeroEstacionamientos = Rdn.Next(Val(txtNumeroEstacionamientoI.Text), Val(txtNumeroEstacionamientoF.Text) + 1)
        'FechaFinal = CDate("14/05/2015 11:10:10 a.m.").AddMinutes(10)
        'Genera Fecha/Hora de inicio y fin
        FechaInicio = CDate(FechaIn & " " & HoraInicio)


        'MsgBox("Hora Final: " & HoraFinal)
        If Format(CDate(HoraFinal), "tt").ToString = "a.m." Then
            FechaFinal = Format(CDate(FechaIn).AddDays(1), "dd/MM/yyyy").ToString & " " & HoraFinal
        Else
            FechaFinal = FechaIn & " " & HoraFinal
        End If


        HoraUltimoEstacionamiento = FechaInicio
        TotalMinutos = DateDiff(DateInterval.Minute, CDate(FechaInicio), CDate(FechaFinal))

        '***********************************************************************************************


        MinDisParaEstacionmiento = (Rdn.Next(Val(txtTotalHorasI.Text), Val(txtTotalHorasF.Text) + 1) * 60)
        TotalMinutos -= MinDisParaEstacionmiento
        MinDisParaEstacionmiento = MinDisParaEstacionmiento + (NumeroEstacionamientos + 2)

        MinDisParaEstacionmiento -= (Val(txtTiempoEstacionamientoI.Text) * NumeroEstacionamientos)
        For i = 0 To NumeroEstacionamientos - 1
            Estacionamentos(0, i) = Val(txtTiempoEstacionamientoI.Text)
        Next


        'Se genera el tiempo de estacionamiento 
        TotalMinutosEstacionamientos = 0
        While MinDisParaEstacionmiento > 0
            For i = 0 To NumeroEstacionamientos - 1

                i2 = Estacionamentos(0, i)

                If i2 <= Val(txtTiempoEstacionamientoF.Text) Then
                    i4 = Val(txtTiempoEstacionamientoF.Text) - i2
                    If i4 <= MinDisParaEstacionmiento Then
                        i3 = Rdn.Next(0, i4 + 1)
                    Else
                        i3 = Rdn.Next(0, MinDisParaEstacionmiento + 1)
                    End If
                Else
                    i3 = 0
                End If

                Estacionamentos(0, i) += i3
                MinDisParaEstacionmiento -= i3
                If MinDisParaEstacionmiento < 1 Then
                    Exit For
                End If
            Next
        End While

        TotalMinutosReales = TotalMinutos
        'Calcula el rango de minutos en que se puede estacionar
        AreaEstacionamiento = (TotalMinutosReales - Val(txtTiempoSeparacion.Text)) / (NumeroEstacionamientos)



        EspacioEstacionamientos = Val(txtTiempoSeparacion.Text)
        Area2 = AreaEstacionamiento

        i3 = EspacioEstacionamientos
        i2 = Area2
        i4 = i3
        Area2 += i3


        'Los estacionamientos los manda muy pegados
        'Aqui genera las posiciones de cada estacionamiento
        For i = 0 To NumeroEstacionamientos - 1
            Estacionamentos(1, i) = Rdn.Next(i4, Area2 + 1)
            If (Estacionamentos(1, i) + i3) > Area2 Then
                i4 = Estacionamentos(1, i) + i3
            Else
                i4 = Area2
            End If

            Area2 += i2
        Next



        i = 0
        GPS(i, 0) = "18.255677"
        GPS(i, 1) = "-93.227248"
        '----------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.255238"
        GPS(i, 1) = "-93.226428"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.255267"
        GPS(i, 1) = "-93.227262"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.25566"
        GPS(i, 1) = "-93.226225"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.259435"
        GPS(i, 1) = "-93.224812"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.262978"
        GPS(i, 1) = "-93.226945"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.255652"
        GPS(i, 1) = "-93.22683"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.25566"
        GPS(i, 1) = "-93.226225"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.259435"
        GPS(i, 1) = "-93.224812"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.262978"
        GPS(i, 1) = "-93.226945"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.255652"
        GPS(i, 1) = "-93.22683"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.230945"
        GPS(i, 1) = "-93.324978"
        '---------------------------------------------
        '-*-*-*-*
        i = i + 1
        GPS(i, 0) = "18.237092"
        GPS(i, 1) = "-93.2916"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.244112"
        GPS(i, 1) = "-93.250797"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.254655"
        GPS(i, 1) = "-93.227323"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.255677"
        GPS(i, 1) = "-93.227248"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.255238"
        GPS(i, 1) = "-93.226428"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.255267"
        GPS(i, 1) = "-93.227262"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.25566"
        GPS(i, 1) = "-93.226225"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.259435"
        GPS(i, 1) = "-93.224812"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.262978"
        GPS(i, 1) = "-93.226945"
        '---------------------------------------------
        i = i + 1
        GPS(i, 0) = "18.255652"
        GPS(i, 1) = "-93.22683"
        '---------------------------------------------




        i2 = 0
        For i = 1 To TotalMinutosReales
            Hoja.Range("E" & (i + Esp)).Value = "863070000000000"
            Hoja.Range("F" & (i + Esp)).Value = GPS(i Mod GPS_NReg, 0)
            Hoja.Range("G" & (i + Esp)).Value = GPS(i Mod GPS_NReg, 1)
        Next

        Hoja.Range("A" & (i + 9) & ":G" & (i + 16)).Merge()
        Hoja.Range("A10:G" & TotalMinutosReales + 17).Borders(2).LineStyle = 1 'Todas las lineas verticales
        Hoja.Range("A10:G" & TotalMinutosReales + 17).Borders(1).LineStyle = 1 'Todas las lineas verticales
        Hoja.Range("A10:G" & TotalMinutosReales + 17).Borders(4).LineStyle = 1 'Todas las lineas horizontales
        Hoja.Range("C10:C" & TotalMinutosReales + 17).HorizontalAlignment = Constants.xlRight 'Alineación

        x = (TotalMinutosReales * 15) + 275

        AnchoDeseado = 460
        ImagenX = 619
        ImagenY = 104
        Hoja.Shapes.AddPicture(Imagen3, False, True, 13, x, AnchoDeseado, (AnchoDeseado * ImagenY) / ImagenX)


        'Verificacion de estacionamientos
        'For i = 0 To NumeroEstacionamientos - 1
        'Prueba.Text = Prueba.Text + Estacionamentos(0, i).ToString + "  ---  " + Estacionamentos(1, i).ToString + vbCrLf
        'Next


    End Sub
    Private Function getHora(ByVal H1 As Integer, ByVal M1 As Integer, ByVal TT1 As String, ByVal H2 As Integer, ByVal M2 As Integer, ByVal TT2 As String) As String
        Dim Hora As String = ""
        Dim MenorH As Integer
        Dim MayorH As Integer
        Dim MenorM As Integer
        Dim MayorM As Integer
        Dim Tiempo As String
        Dim TotalHoras As Integer
        Dim Aux1 As Integer
        Dim Hora1 As String
        Dim Min1 As String


        Tiempo = TT1
        If H1 < H2 Then
            MenorH = H1
            MayorH = H2
        Else
            MenorH = H2
            MayorH = H1
        End If

        If M1 < M2 Then
            MenorM = M1
            MayorM = M2
        Else
            MenorM = M2
            MayorM = M1
        End If

        If TT1 = "a.m." And TT2 = "a.m." Then
            Hora1 = Format(Rdn.Next(MenorH, MayorH + 1), "00")
            If Val(Hora1) = H1 Then
                If M1 <= 1 Then
                    Min1 = Format(Rdn.Next(1, 60), "00")
                Else
                    Min1 = Format(Rdn.Next(M1, 60), "00")
                End If
            ElseIf Val(Hora1) = H2 Then
                If M2 >= 1 Then
                    Min1 = Format(Rdn.Next(1, M2), "00")
                Else
                    Min1 = Format(0, "00")
                End If
            Else
                Min1 = Format(Rdn.Next(0, 60), "00")
            End If

            Hora = Hora1 & ":" & Min1 & ":" & Rdn.Next(0, 60).ToString & " a.m."

        ElseIf TT1 = "a.m." And TT2 = "p.m." Or TT1 = "p.m." And TT2 = "a.m." Then
            TotalHoras = (12 - H1) + H2
            Aux1 = Rdn.Next(0, TotalHoras + 1)
            If H1 + Aux1 >= 12 And Tiempo = "a.m." Then
                Tiempo = "p.m."
            ElseIf H1 + Aux1 >= 12 And Tiempo = "p.m." Then
                Tiempo = "a.m."
            End If
            Aux1 = (H1 + Aux1) Mod 12
            If Aux1 = 0 Then
                Aux1 = 12
            End If

            Hora1 = Format(Aux1, "00")
            If Val(Hora1) = H1 Then
                Min1 = Format(Rdn.Next(M1, 60), "00")
            ElseIf Val(Hora1) = H2 Then
                Min1 = Format(Rdn.Next(0, M2), "00")
            Else
                Min1 = Format(Rdn.Next(0, 60), "00")
            End If

            Hora = Hora1 & ":" & Min1 & ":" & Rdn.Next(0, 60).ToString & " " & Tiempo


        ElseIf TT1 = "p.m." And TT2 = "p.m." Then
            Hora1 = Format(Rdn.Next(MenorH, MayorH + 1), "00")
            If Val(Hora1) = H1 Then
                If M1 <= 1 Then
                    Min1 = Format(Rdn.Next(1, 60), "00")
                Else
                    Min1 = Format(Rdn.Next(M1, 60), "00")
                End If
            ElseIf Val(Hora1) = H2 Then
                If M2 >= 1 Then
                    Min1 = Format(Rdn.Next(1, M2), "00")
                Else
                    Min1 = Format(0, "00")
                End If
            Else
                Min1 = Format(Rdn.Next(0, 60), "00")
            End If

            Hora = Hora1 & ":" & Min1 & ":" & Rdn.Next(0, 60).ToString & " p.m."
        End If

        Return Hora
    End Function
    Private Sub GenerarEncabezado()
        Dim Imagen1 As String = IO.Path.GetFullPath("Core\PEMEX.png")
        Dim Imagen2 As String = IO.Path.GetFullPath("Core\UPCH.png")
        'Dim FechaIn As Date


        Dim AnchoDeseado As Integer
        Dim ImagenX As Integer
        Dim ImagenY As Integer

        'FechaIn = txtFechaInicio.Text
        ' My.Resources.Imagen.Save(ImageFileName)

        Archivo = CreateObject("Excel.Application")
        Libro = Archivo.Workbooks.Add
        Hoja = Libro.ActiveSheet

        Hoja.Range("A1").RowHeight = 96 '96 : 251.5 : 15 < celda normal
        Hoja.Range("A7").RowHeight = 41.5
        Hoja.Range("A8").RowHeight = 14
        Hoja.Range("A9").RowHeight = 26.3 '177.8

        Hoja.Range("A1").ColumnWidth = 25
        Hoja.Range("B1").ColumnWidth = 10
        Hoja.Range("C1").ColumnWidth = 15.2
        Hoja.Range("D1").ColumnWidth = 11
        Hoja.Range("E1").ColumnWidth = 8.7
        Hoja.Range("F1").ColumnWidth = 10.8
        Hoja.Range("G1").ColumnWidth = 16

        Hoja.Range("A1:G1").Merge()
        Hoja.Range("A2:G2").Merge()
        Hoja.Range("A3:G3").Merge()
        Hoja.Range("A4:D4").Merge()
        Hoja.Range("F4:G4").Merge()
        Hoja.Range("F5:G5").Merge()
        Hoja.Range("C6:D6").Merge()
        Hoja.Range("E6:F6").Merge()
        Hoja.Range("A7:D7").Merge()
        Hoja.Range("E7:G7").Merge()
        Hoja.Range("A8:G8").Merge()
        Hoja.Range("E9:G9").Merge()

        Hoja.Range("B5:D5").Merge()
        Hoja.Range("A6:C6").Merge()

        Hoja.Range("A1:G9").Borders(2).LineStyle = 1 'Todas las lineas verticales
        Hoja.Range("A1:A10").Borders(1).LineStyle = 1 'Todas las lineas verticales
        Hoja.Range("A1:G9").Borders(4).LineStyle = 1 'Todas las lineas horizontales
        Hoja.Range("A1:G9").Borders(3).LineStyle = 1 'Todas las lineas horizontales

        Hoja.Range("A9:G9").Interior.Color = RGB(255, 192, 0) 'Color de fondo de las celdas
        Hoja.Range("A1:E9").Font.Bold = True 'Negritas
        Hoja.Range("A7").Font.Bold = False  'Negritas
        Hoja.Range("A1:G9").Font.Name = "Arial"

        Hoja.Range("A1:G9").Font.Size = 10 'Tamaño de fuente
        Hoja.Range("F4:G6").Font.Size = 9 'Tamaño de fuente
        Hoja.Range("F5").Font.Size = 8 'Tamaño de fuente
        Hoja.Range("A7").Font.Size = 9 'Tamaño de fuente
        Hoja.Range("A4").Font.Size = 9 'Tamaño de fuente

        Hoja.Range("A2").Value = txtNombreProyecto.Text
        Hoja.Range("A3").Value = "REPORTE DIARIO DE MONITOREO DE VEHÍCULOS"
        Hoja.Range("A4").Value = txtVehiculo.Text
        Hoja.Range("E4").Value = "FECHA:"
        Hoja.Range("F4").Value = Format(CDate(FechaIn).AddDays(1), "dd").ToString + " de " + StrConv(MonthName(Month(txtFechaInicio.Text)).ToString, 3).ToString + " del " + Year(txtFechaInicio.Text).ToString
        Hoja.Range("A5").Value = "CONVENIO ESPECÍFICO No."
        Hoja.Range("B5").Value = txtConnvenio.Text
        Hoja.Range("E5").Value = "PERIODO:"
        Hoja.Range("F5").Value = "Del 1 al " + Date.DaysInMonth(Year(txtFechaInicio.Text), Month(txtFechaInicio.Text)).ToString + " de " + StrConv(MonthName(Month(txtFechaInicio.Text)).ToString, 3).ToString + " del " + Year(txtFechaInicio.Text).ToString
        Hoja.Range("A6").Value = "OBJETO DEL CONVENIO:"
        Hoja.Range("E6").Value = "ORDEN DE SERVICIO:"
        Hoja.Range("G6").Value = txtOrdenServicio.Text
        Hoja.Range("A7").Value = txtObjetoConvenio.Text
        Hoja.Range("A9").Value = "ESTADO DEL VEHÍCULO"
        Hoja.Range("B9").Value = "FECHA"
        Hoja.Range("C9").Value = "HORA"
        Hoja.Range("D9").Value = "VELOCIDAD"
        Hoja.Range("E9").Value = "COORDENADAS DE UBICACIÓN"

        Hoja.Range("A2").HorizontalAlignment = Constants.xlCenter 'Alineación
        Hoja.Range("A3").HorizontalAlignment = Constants.xlCenter 'Alineación
        Hoja.Range("A4").HorizontalAlignment = Constants.xlCenter 'Alineación
        Hoja.Range("E4").HorizontalAlignment = Constants.xlRight  'Alineación
        Hoja.Range("F4").HorizontalAlignment = Constants.xlLeft  'Alineación
        Hoja.Range("A5").HorizontalAlignment = Constants.xlLeft  'Alineación
        Hoja.Range("B5").HorizontalAlignment = Constants.xlCenter   'Alineación
        Hoja.Range("E5").HorizontalAlignment = Constants.xlLeft    'Alineación
        Hoja.Range("F5").HorizontalAlignment = Constants.xlLeft   'Alineación
        Hoja.Range("A7").HorizontalAlignment = Constants.xlLeft   'Alineación

        Hoja.Range("A6").HorizontalAlignment = Constants.xlLeft   'Alineación
        Hoja.Range("E6").HorizontalAlignment = Constants.xlLeft   'Alineación
        Hoja.Range("G6").HorizontalAlignment = Constants.xlLeft   'Alineación

        Hoja.Range("A9").HorizontalAlignment = Constants.xlCenter    'Alineación
        Hoja.Range("B9").HorizontalAlignment = Constants.xlCenter    'Alineación
        Hoja.Range("C9").HorizontalAlignment = Constants.xlCenter    'Alineación
        Hoja.Range("D9").HorizontalAlignment = Constants.xlCenter    'Alineación
        Hoja.Range("E9").HorizontalAlignment = Constants.xlCenter    'Alineación

        Hoja.Range("B5").HorizontalAlignment = Constants.xlCenter    'Alineación
        Hoja.Range("A6").HorizontalAlignment = Constants.xlCenter    'Alineación

        Hoja.Range("A2").VerticalAlignment = Constants.xlCenter 'Alineación
        Hoja.Range("A3").VerticalAlignment = Constants.xlCenter 'Alineación
        Hoja.Range("A4").VerticalAlignment = Constants.xlCenter 'Alineación
        Hoja.Range("E4").VerticalAlignment = Constants.xlCenter  'Alineación
        Hoja.Range("F4").VerticalAlignment = Constants.xlCenter  'Alineación
        Hoja.Range("A5").VerticalAlignment = Constants.xlCenter  'Alineación
        Hoja.Range("B5").VerticalAlignment = Constants.xlCenter   'Alineación
        Hoja.Range("E5").VerticalAlignment = Constants.xlCenter    'Alineación
        Hoja.Range("F5").VerticalAlignment = Constants.xlCenter  'Alineación
        Hoja.Range("A7").VerticalAlignment = Constants.xlCenter  'Alineación

        Hoja.Range("A6").VerticalAlignment = Constants.xlCenter   'Alineación
        Hoja.Range("E6").VerticalAlignment = Constants.xlCenter  'Alineación
        Hoja.Range("G6").VerticalAlignment = Constants.xlCenter   'Alineación

        Hoja.Range("A9").VerticalAlignment = Constants.xlCenter    'Alineación
        Hoja.Range("B9").VerticalAlignment = Constants.xlCenter    'Alineación
        Hoja.Range("C9").VerticalAlignment = Constants.xlCenter    'Alineación
        Hoja.Range("D9").VerticalAlignment = Constants.xlCenter    'Alineación
        Hoja.Range("E9").VerticalAlignment = Constants.xlCenter    'Alineación

        Hoja.Range("A7").WrapText = True

        AnchoDeseado = 151
        ImagenX = 196
        ImagenY = 81
        Hoja.Shapes.AddPicture(Imagen1, False, True, 20, 15, AnchoDeseado, (AnchoDeseado * ImagenY) / ImagenX)

        AnchoDeseado = 81
        ImagenX = 107
        ImagenY = 108
        Hoja.Shapes.AddPicture(Imagen2, False, True, 403, 8, AnchoDeseado, (AnchoDeseado * ImagenY) / ImagenX)

    End Sub
    Private Sub Monitoreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTTI1.SelectedIndex = 0
        txtTTI2.SelectedIndex = 0
        txtTTF1.SelectedIndex = 1
        txtTTF2.SelectedIndex = 1
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim i As Integer = 0
        Dim Cont As Integer = 0
        Dim FechaA As String

        FechaA = txtFechaInicio.Text
        ReporteTotal = DateDiff(DateInterval.Day, CDate(txtFechaInicio.Text), CDate(txtFechaFin.Text))

        While CDate(FechaA) < CDate(txtFechaFin.Text)
            If CDate(FechaA).DayOfWeek = DayOfWeek.Sunday Then
                Cont += 1
            End If
            FechaA = CDate(FechaA).AddDays(1).ToString
        End While

        ReporteTotal -= Cont

        PB.Maximum = ReporteTotal

        txtProgreso.Text = "Progreso: " & "0 de " & ReporteTotal
        PB.Value = 0
        btnGenerar.Enabled = True

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txtDireccion.Text = FolderBrowserDialog1.SelectedPath.ToString
        End If
    End Sub
    Private Sub txtFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles txtFechaInicio.ValueChanged
        Dim i As Integer = 0
        Dim Cont As Integer = 0
        Dim FechaA As String

        Try
            FechaA = txtFechaInicio.Text
            ReporteTotal = DateDiff(DateInterval.Day, CDate(txtFechaInicio.Text), CDate(txtFechaFin.Text))

            While CDate(FechaA) < CDate(txtFechaFin.Text)
                If CDate(FechaA).DayOfWeek = DayOfWeek.Sunday Then
                    Cont += 1
                End If
                FechaA = CDate(FechaA).AddDays(1).ToString
            End While

            ReporteTotal -= Cont

            PB.Maximum = ReporteTotal

            txtProgreso.Text = "Progreso: " & "0 de " & ReporteTotal
            PB.Value = 0
            btnGenerar.Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles txtFechaFin.ValueChanged
        Dim i As Integer = 0
        Dim Cont As Integer = -1
        Dim FechaA As String
        Try
            FechaA = txtFechaInicio.Text
            ReporteTotal = DateDiff(DateInterval.Day, CDate(txtFechaInicio.Text), CDate(txtFechaFin.Text))

            While CDate(FechaA) < CDate(txtFechaFin.Text)
                If CDate(FechaA).DayOfWeek = DayOfWeek.Sunday Then
                    Cont += 1
                End If
                FechaA = CDate(FechaA).AddDays(1).ToString
            End While

            ReporteTotal -= Cont

            PB.Maximum = ReporteTotal

            txtProgreso.Text = "Progreso: " & "0 de " & ReporteTotal
            PB.Value = 0
            btnGenerar.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
End Class
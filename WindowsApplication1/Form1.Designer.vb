<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monitoreo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtProgreso = New System.Windows.Forms.Label()
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.txtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObjetoConvenio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOrdenServicio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConnvenio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVehiculo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreProyecto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtTotalHorasF = New System.Windows.Forms.TextBox()
        Me.txtTotalHorasI = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTiempoSeparacion = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNumeroEstacionamientoI = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNumeroEstacionamientoF = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTiempoEstacionamientoI = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTiempoEstacionamientoF = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTTF2 = New System.Windows.Forms.ComboBox()
        Me.txtTTF1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMF2 = New System.Windows.Forms.TextBox()
        Me.txtHF2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMF1 = New System.Windows.Forms.TextBox()
        Me.txtHF1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTTI2 = New System.Windows.Forms.ComboBox()
        Me.txtTTI1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMI2 = New System.Windows.Forms.TextBox()
        Me.txtHI2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMI1 = New System.Windows.Forms.TextBox()
        Me.txtHI1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Prueba = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerar
        '
        Me.btnGenerar.Enabled = False
        Me.btnGenerar.Location = New System.Drawing.Point(625, 317)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(170, 47)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.txtProgreso)
        Me.GroupBox1.Controls.Add(Me.PB)
        Me.GroupBox1.Controls.Add(Me.txtFechaFin)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtFechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtObjetoConvenio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtOrdenServicio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtConnvenio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtVehiculo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombreProyecto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(871, 277)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del reporte"
        '
        'txtProgreso
        '
        Me.txtProgreso.BackColor = System.Drawing.Color.Transparent
        Me.txtProgreso.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProgreso.Location = New System.Drawing.Point(410, 210)
        Me.txtProgreso.Name = "txtProgreso"
        Me.txtProgreso.Size = New System.Drawing.Size(323, 19)
        Me.txtProgreso.TabIndex = 44
        Me.txtProgreso.Text = "Progreso: "
        Me.txtProgreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(286, 232)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(572, 37)
        Me.PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PB.TabIndex = 43
        '
        'txtFechaFin
        '
        Me.txtFechaFin.CustomFormat = ""
        Me.txtFechaFin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaFin.Location = New System.Drawing.Point(165, 239)
        Me.txtFechaFin.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.txtFechaFin.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(115, 26)
        Me.txtFechaFin.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(162, 218)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 19)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Fecha fin:"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.CustomFormat = ""
        Me.txtFechaInicio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaInicio.Location = New System.Drawing.Point(22, 239)
        Me.txtFechaInicio.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.txtFechaInicio.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(115, 26)
        Me.txtFechaInicio.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 218)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 19)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Fecha inicio:"
        '
        'txtObjetoConvenio
        '
        Me.txtObjetoConvenio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObjetoConvenio.Location = New System.Drawing.Point(271, 163)
        Me.txtObjetoConvenio.Multiline = True
        Me.txtObjetoConvenio.Name = "txtObjetoConvenio"
        Me.txtObjetoConvenio.Size = New System.Drawing.Size(588, 46)
        Me.txtObjetoConvenio.TabIndex = 38
        Me.txtObjetoConvenio.Text = """SERVICIOS TÉCNICOS ESPECIALIZADOS Y SEGUIMIENTO OPERATIVO A LOS POZOS DEL ACTIVO" & _
    " DE PRODUCCIÓN BELLOTA-JUJO"""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 166)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 18)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Objeto del convenio:"
        '
        'txtOrdenServicio
        '
        Me.txtOrdenServicio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenServicio.Location = New System.Drawing.Point(271, 131)
        Me.txtOrdenServicio.Name = "txtOrdenServicio"
        Me.txtOrdenServicio.Size = New System.Drawing.Size(399, 26)
        Me.txtOrdenServicio.TabIndex = 36
        Me.txtOrdenServicio.Text = "15-COIaP-SE-2015"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 134)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 18)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Orden de servicio:"
        '
        'txtConnvenio
        '
        Me.txtConnvenio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConnvenio.Location = New System.Drawing.Point(271, 99)
        Me.txtConnvenio.Name = "txtConnvenio"
        Me.txtConnvenio.Size = New System.Drawing.Size(399, 26)
        Me.txtConnvenio.TabIndex = 34
        Me.txtConnvenio.Text = "425103847"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 18)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Convenio Especifico No.:"
        '
        'txtVehiculo
        '
        Me.txtVehiculo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehiculo.Location = New System.Drawing.Point(271, 67)
        Me.txtVehiculo.Name = "txtVehiculo"
        Me.txtVehiculo.Size = New System.Drawing.Size(588, 26)
        Me.txtVehiculo.TabIndex = 32
        Me.txtVehiculo.Text = "VEHÍCULO: NISSAN NP300  PLACAS: VR-03-464  No. ECONÓMICO: I-14"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 18)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Vehiculo/Placas/No. Economico:"
        '
        'txtNombreProyecto
        '
        Me.txtNombreProyecto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProyecto.Location = New System.Drawing.Point(194, 34)
        Me.txtNombreProyecto.Name = "txtNombreProyecto"
        Me.txtNombreProyecto.Size = New System.Drawing.Size(665, 26)
        Me.txtNombreProyecto.TabIndex = 29
        Me.txtNombreProyecto.Text = "ESPECIALISTAS DE DISEÑO Y SUPERVISIÓN  DE MANTENIMIENTO DE POZOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nombre del proyecto:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtTotalHorasF)
        Me.GroupBox2.Controls.Add(Me.txtTotalHorasI)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txtTiempoSeparacion)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.txtNumeroEstacionamientoI)
        Me.GroupBox2.Controls.Add(Me.btnGenerar)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtNumeroEstacionamientoF)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtTiempoEstacionamientoI)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtTiempoEstacionamientoF)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtTTF2)
        Me.GroupBox2.Controls.Add(Me.txtTTF1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtMF2)
        Me.GroupBox2.Controls.Add(Me.txtHF2)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtMF1)
        Me.GroupBox2.Controls.Add(Me.txtHF1)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtTTI2)
        Me.GroupBox2.Controls.Add(Me.txtTTI1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtMI2)
        Me.GroupBox2.Controls.Add(Me.txtHI2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtMI1)
        Me.GroupBox2.Controls.Add(Me.txtHI1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 304)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(867, 376)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Configuración del programa"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(611, 260)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(18, 19)
        Me.Label23.TabIndex = 87
        Me.Label23.Text = "y"
        '
        'txtTotalHorasF
        '
        Me.txtTotalHorasF.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalHorasF.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHorasF.Location = New System.Drawing.Point(641, 257)
        Me.txtTotalHorasF.MaxLength = 2
        Me.txtTotalHorasF.Name = "txtTotalHorasF"
        Me.txtTotalHorasF.Size = New System.Drawing.Size(38, 26)
        Me.txtTotalHorasF.TabIndex = 86
        Me.txtTotalHorasF.Tag = ""
        Me.txtTotalHorasF.Text = "6"
        Me.txtTotalHorasF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalHorasI
        '
        Me.txtTotalHorasI.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalHorasI.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHorasI.Location = New System.Drawing.Point(564, 257)
        Me.txtTotalHorasI.MaxLength = 2
        Me.txtTotalHorasI.Name = "txtTotalHorasI"
        Me.txtTotalHorasI.Size = New System.Drawing.Size(38, 26)
        Me.txtTotalHorasI.TabIndex = 85
        Me.txtTotalHorasI.Tag = "5"
        Me.txtTotalHorasI.Text = "5"
        Me.txtTotalHorasI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(445, 200)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(347, 49)
        Me.Label22.TabIndex = 84
        Me.Label22.Text = "Total de horas de estacionamiento en el dia:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTiempoSeparacion
        '
        Me.txtTiempoSeparacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTiempoSeparacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTiempoSeparacion.Location = New System.Drawing.Point(192, 257)
        Me.txtTiempoSeparacion.MaxLength = 2
        Me.txtTiempoSeparacion.Name = "txtTiempoSeparacion"
        Me.txtTiempoSeparacion.Size = New System.Drawing.Size(38, 26)
        Me.txtTiempoSeparacion.TabIndex = 83
        Me.txtTiempoSeparacion.Tag = "15"
        Me.txtTiempoSeparacion.Text = "15"
        Me.txtTiempoSeparacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(36, 200)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(347, 49)
        Me.Label21.TabIndex = 82
        Me.Label21.Text = "Tiempo minimo de separación  entre cada estacionamiento (Minutos):"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(33, 327)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(33, 28)
        Me.btnBuscar.TabIndex = 81
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(29, 303)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(168, 19)
        Me.Label20.TabIndex = 80
        Me.Label20.Text = "Guargar reportes en:"
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(72, 329)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDireccion.Size = New System.Drawing.Size(487, 36)
        Me.txtDireccion.TabIndex = 79
        Me.txtDireccion.Text = "C:"
        '
        'txtNumeroEstacionamientoI
        '
        Me.txtNumeroEstacionamientoI.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNumeroEstacionamientoI.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroEstacionamientoI.Location = New System.Drawing.Point(541, 147)
        Me.txtNumeroEstacionamientoI.MaxLength = 2
        Me.txtNumeroEstacionamientoI.Name = "txtNumeroEstacionamientoI"
        Me.txtNumeroEstacionamientoI.Size = New System.Drawing.Size(38, 26)
        Me.txtNumeroEstacionamientoI.TabIndex = 5
        Me.txtNumeroEstacionamientoI.Tag = "9"
        Me.txtNumeroEstacionamientoI.Text = "5"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(600, 150)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 19)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "y"
        '
        'txtNumeroEstacionamientoF
        '
        Me.txtNumeroEstacionamientoF.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNumeroEstacionamientoF.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroEstacionamientoF.Location = New System.Drawing.Point(638, 147)
        Me.txtNumeroEstacionamientoF.MaxLength = 2
        Me.txtNumeroEstacionamientoF.Name = "txtNumeroEstacionamientoF"
        Me.txtNumeroEstacionamientoF.Size = New System.Drawing.Size(38, 26)
        Me.txtNumeroEstacionamientoF.TabIndex = 76
        Me.txtNumeroEstacionamientoF.Tag = "12"
        Me.txtNumeroEstacionamientoF.Text = "6"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(445, 123)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(350, 18)
        Me.Label19.TabIndex = 75
        Me.Label19.Text = "Número de estacionamientos"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTiempoEstacionamientoI
        '
        Me.txtTiempoEstacionamientoI.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTiempoEstacionamientoI.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTiempoEstacionamientoI.Location = New System.Drawing.Point(129, 147)
        Me.txtTiempoEstacionamientoI.MaxLength = 2
        Me.txtTiempoEstacionamientoI.Name = "txtTiempoEstacionamientoI"
        Me.txtTiempoEstacionamientoI.Size = New System.Drawing.Size(38, 26)
        Me.txtTiempoEstacionamientoI.TabIndex = 74
        Me.txtTiempoEstacionamientoI.Text = "15"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(188, 150)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 19)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "y"
        '
        'txtTiempoEstacionamientoF
        '
        Me.txtTiempoEstacionamientoF.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTiempoEstacionamientoF.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTiempoEstacionamientoF.Location = New System.Drawing.Point(226, 147)
        Me.txtTiempoEstacionamientoF.MaxLength = 2
        Me.txtTiempoEstacionamientoF.Name = "txtTiempoEstacionamientoF"
        Me.txtTiempoEstacionamientoF.Size = New System.Drawing.Size(38, 26)
        Me.txtTiempoEstacionamientoF.TabIndex = 68
        Me.txtTiempoEstacionamientoF.Tag = "300"
        Me.txtTiempoEstacionamientoF.Text = "240"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(33, 123)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(350, 18)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "Duración del estacionamiento (Minutos)"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTTF2
        '
        Me.txtTTF2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTTF2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTTF2.FormattingEnabled = True
        Me.txtTTF2.Items.AddRange(New Object() {"a.m.", "p.m."})
        Me.txtTTF2.Location = New System.Drawing.Point(739, 59)
        Me.txtTTF2.Name = "txtTTF2"
        Me.txtTTF2.Size = New System.Drawing.Size(56, 27)
        Me.txtTTF2.TabIndex = 65
        '
        'txtTTF1
        '
        Me.txtTTF1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTTF1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTTF1.FormattingEnabled = True
        Me.txtTTF1.Items.AddRange(New Object() {"a.m.", "p.m."})
        Me.txtTTF1.Location = New System.Drawing.Point(535, 59)
        Me.txtTTF1.Name = "txtTTF1"
        Me.txtTTF1.Size = New System.Drawing.Size(56, 27)
        Me.txtTTF1.TabIndex = 64
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(611, 62)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 19)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "y"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(682, 62)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 19)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = ":"
        '
        'txtMF2
        '
        Me.txtMF2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMF2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMF2.Location = New System.Drawing.Point(695, 59)
        Me.txtMF2.MaxLength = 2
        Me.txtMF2.Name = "txtMF2"
        Me.txtMF2.Size = New System.Drawing.Size(38, 26)
        Me.txtMF2.TabIndex = 61
        Me.txtMF2.Text = "15"
        '
        'txtHF2
        '
        Me.txtHF2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHF2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHF2.Location = New System.Drawing.Point(647, 59)
        Me.txtHF2.MaxLength = 2
        Me.txtHF2.Name = "txtHF2"
        Me.txtHF2.Size = New System.Drawing.Size(38, 26)
        Me.txtHF2.TabIndex = 60
        Me.txtHF2.Text = "07"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(480, 62)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 19)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = ":"
        '
        'txtMF1
        '
        Me.txtMF1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMF1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMF1.Location = New System.Drawing.Point(493, 59)
        Me.txtMF1.MaxLength = 2
        Me.txtMF1.Name = "txtMF1"
        Me.txtMF1.Size = New System.Drawing.Size(38, 26)
        Me.txtMF1.TabIndex = 58
        Me.txtMF1.Text = "00"
        '
        'txtHF1
        '
        Me.txtHF1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHF1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHF1.Location = New System.Drawing.Point(445, 59)
        Me.txtHF1.MaxLength = 2
        Me.txtHF1.Name = "txtHF1"
        Me.txtHF1.Size = New System.Drawing.Size(38, 26)
        Me.txtHF1.TabIndex = 57
        Me.txtHF1.Text = "06"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(445, 35)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(350, 18)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Hora fin hh:mm"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTTI2
        '
        Me.txtTTI2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTTI2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTTI2.FormattingEnabled = True
        Me.txtTTI2.Items.AddRange(New Object() {"a.m.", "p.m."})
        Me.txtTTI2.Location = New System.Drawing.Point(327, 59)
        Me.txtTTI2.Name = "txtTTI2"
        Me.txtTTI2.Size = New System.Drawing.Size(56, 27)
        Me.txtTTI2.TabIndex = 55
        '
        'txtTTI1
        '
        Me.txtTTI1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTTI1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTTI1.FormattingEnabled = True
        Me.txtTTI1.Items.AddRange(New Object() {"a.m.", "p.m."})
        Me.txtTTI1.Location = New System.Drawing.Point(123, 59)
        Me.txtTTI1.Name = "txtTTI1"
        Me.txtTTI1.Size = New System.Drawing.Size(56, 27)
        Me.txtTTI1.TabIndex = 54
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(199, 62)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 19)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "y"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(270, 62)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 19)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = ":"
        '
        'txtMI2
        '
        Me.txtMI2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMI2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMI2.Location = New System.Drawing.Point(283, 59)
        Me.txtMI2.MaxLength = 2
        Me.txtMI2.Name = "txtMI2"
        Me.txtMI2.Size = New System.Drawing.Size(38, 26)
        Me.txtMI2.TabIndex = 43
        Me.txtMI2.Text = "00"
        '
        'txtHI2
        '
        Me.txtHI2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHI2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHI2.Location = New System.Drawing.Point(235, 59)
        Me.txtHI2.MaxLength = 2
        Me.txtHI2.Name = "txtHI2"
        Me.txtHI2.Size = New System.Drawing.Size(38, 26)
        Me.txtHI2.TabIndex = 42
        Me.txtHI2.Text = "09"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(68, 62)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 19)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = ":"
        '
        'txtMI1
        '
        Me.txtMI1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMI1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMI1.Location = New System.Drawing.Point(81, 59)
        Me.txtMI1.MaxLength = 2
        Me.txtMI1.Name = "txtMI1"
        Me.txtMI1.Size = New System.Drawing.Size(38, 26)
        Me.txtMI1.TabIndex = 40
        Me.txtMI1.Text = "00"
        '
        'txtHI1
        '
        Me.txtHI1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHI1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHI1.Location = New System.Drawing.Point(33, 59)
        Me.txtHI1.MaxLength = 2
        Me.txtHI1.Name = "txtHI1"
        Me.txtHI1.Size = New System.Drawing.Size(38, 26)
        Me.txtHI1.TabIndex = 39
        Me.txtHI1.Text = "07"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Hora inicio hh:mm"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Prueba
        '
        Me.Prueba.Location = New System.Drawing.Point(911, 11)
        Me.Prueba.Multiline = True
        Me.Prueba.Name = "Prueba"
        Me.Prueba.Size = New System.Drawing.Size(128, 278)
        Me.Prueba.TabIndex = 17
        '
        'Monitoreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 681)
        Me.Controls.Add(Me.Prueba)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Monitoreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoreo "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtObjetoConvenio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtOrdenServicio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtConnvenio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombreProyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHI1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMI2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHI2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMI1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTTI2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtTTI1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtTTF2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtTTF1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMF2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHF2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMF1 As System.Windows.Forms.TextBox
    Friend WithEvents txtHF1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTiempoEstacionamientoI As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTiempoEstacionamientoF As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroEstacionamientoI As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroEstacionamientoF As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtTiempoSeparacion As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtTotalHorasI As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtTotalHorasF As System.Windows.Forms.TextBox
    Friend WithEvents Prueba As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtProgreso As System.Windows.Forms.Label
    Friend WithEvents PB As System.Windows.Forms.ProgressBar

End Class

//
//==========================================
// elGuille.js
// (c)Guillermo 'guille' Som, 1998-2006
// Última revisión:           (30/Mar/2006)
//==========================================
function validarGuille(valor){
	if(valor=="")
		return false;
    fBuscarGuille.B3.value=valor;
    fBuscarGuille.Op.value="150";
    return true;
}
function validarGuille2(valor){
	if(valor=="")
		return false;
    fBuscarGuille2.B3.value=valor;
    fBuscarGuille2.Op.value="150";
    return true;
}
// Solo si se debe poner la cabecera (valor por defecto) (26/Jun/07)
// ///////////////////////////
// isDefined (o para saber si está definida la variable)
// http://jehiah.cz/archive/javascript-isdefined-function
// El que funciona es lo que dice Marton
// ///////////////////////////
sinCabecera = window.sinCabecera ? window.sinCabecera : false;
	
if( sinCabecera == false )
{
    document.write("" +
    "<!-- #Inicio de la cabecera de elGuille.info (15/Dic/2012) -->" +
    "<center>" +
    "<div style='width:850px;'>" +
    "<div class='colorClaro' style='text-align:left'>" +
    "<div style='border: 1px solid gray; border-collapse:collapse;padding:.2em'>" +
    "" +
    "<!-- primera fila -->" +
    "<div style='float:left; width:155px; margin-top:2px; margin-left:2px'>" +
    "    <a href='"+gsPath+"' title='Ir al &iacute;ndice de elGuille' ><img src='" + gsPath + "imagenes/elGuille_luna300x200.jpg' alt='la luna del guille o el guille que est&aacute; en la luna' style='width:150px;height:100px;border-width:0px;' /></a>" +
    "</div>" +
    "<div style='float:left; width:685px; text-align:center; margin-top:2px;'>" +
    "    <div style='font-size:x-small; font-weight:500'>" +
    "            <div style='float:left; width:170px; height:32px; background-color:#fce803; /*amarillo*/'>" +
    "                <br /><a href='/lonuevo/2013/' title='Lo publicado en este mes' style='color:black'>Lo + nuevo</a>" +
    "            </div>" +
    "            <div style='float:left; width:170px; height:32px; background-color:#bbf5c7; /* verde */'>" +
    "                <br /><a href='/vb/' title='Secci&oacute;n de Visual Basic 6.0 y anterior' style='color:black'>Visual Basic 6</a>" +
    "            </div>" +
    "            <div style='float:left; width:170px; height:32px; background-color:#c666fc; /* violeta */'>" +
    "                <br /><a href='/net/winfx/' title='XAML y .NET aka WinFX' style='color:black'>&lt;Xaml /&gt;</a>" +
    "            </div>" +
    "            <div style='float:left; width:170px; height:32px; background-color:#1cb2fb; /* azul */'>" +
    "                <br /><a href='/HTMLscripts/HTML_Tip.aspx' title='Lenguajes script y HTML' style='color:black'>HTML / Scripts</a>" +
    "            </div>" +
    "            <div style='float:left; width:170px; height:32px; background-color:#03b4b4; /* verdoso */'>" +
    "                <br /><a href='/net/ASPNET/' title='P&aacute;ginas Web con .NET' style='color:black'>ASP.NET</a>" +
    "            </div>" +
    "            <div style='float:left; width:340px; height:32px; background-color:#b2d4fb; /*azul*/'>" +
    "                <br /><a href='/NET/comodotnet.aspx' title='Trucos de c&oacute;mo hacer las cosas en .NET' style='color:black'>C&oacute;mo en .NET</a>" +
    "            </div>" +
    "            <div style='float:left; width:170px; height:32px; background-color:#F09609; /* naranja */'>" +
    "                <br /><a href='/net/ADONET/' title='Acceso a datos con .NET' style='color:black'>ADO.NET</a>" +
    "            </div>" +
    "            <div style='float:left; width:170px; height:32px; background-color:#fab8b8; /* rosado */'>" +
    "                <br /><a href='/NET/' title='Todo lo relacionado con .NET' style='color:black'>Lenguajes .NET</a>" +
    "            </div>" +
    "            <div style='float:left; width:170px; height:32px; background-color:#fcbb70; /* naranja */'>" +
    "                <br /><a href='/foros_guille.aspx' title='Los foros del Guille' style='color:black'>Foros</a>" +
    "            </div>" +
    "            <div style='float:left; width:170px; height:32px; background-color:#fcf703; /* amarillo */'>" +
    "                <br /><a href='/Windows/' title='Secci&oacute;n sobre Windows 8 / Server 2012 / 8.1 Preview' style='color:black'>Windows</a>" +
    "            </div>" +
    "            <div style='float:left; width:170px; height:32px; background-color:#e25151; /* rojo */'>" +
    "                <br /><a href='/colabora/colabora.htm' title='Las colaboraciones' style='color:black'>Colaboraciones</a>" +
    "            </div>" +
    "    </div>" +
    "</div>" +
    "" +
    "<!-- Poner esto para que en el IE10 no se pongan el marco sólo en la segunda fila (en Chrome se ve bien de las dos formas) -->" +
    "<div style='clear: both; height: 0; font-size: 1px; line-height: 0px;'></div>" +
    "" +
    "<!-- segunda fila -->" +
    "<div style='float:left; width:20px; margin-top:5px'>&nbsp;</div>" +
    "<div style='float:left; width:820px; text-align:center; margin-top:5px; margin-bottom:5px'>" +
    "<span style='font-family:Comic Sans MS; color:navy; font-size:large; font-weight:bold; margin-left:4px'>" +
    "    <a title='¿Qui&eacute;n es el Guille?' href='" + gsPath + "el_guille.aspx' style='color:navy'>el Guille</a>, la Web del Visual Basic, C#, .NET y m&aacute;s...</span>" +
    "</div>" +
    "" +
    "<!-- para dejar de posicionar los divs con los anteriores -->" +
    "<div style='clear: both; height: 0; font-size: 1px; line-height: 0px;'></div>" +
    "" +
    "</div>" +
    "</div>" +
    "" +
    "</div>" +
    "</center>" +
    "<div style='clear: both; height: 0; font-size: 1px; line-height: 0px;'></div>" +
    "<!-- #Final de la cabecera de elGuille.info (15/Dic/2012) -->" +
    "");
}

// Por si se indica sin anuncios (05/Feb/11)
sinAnunciosJS = window.sinAnunciosJS ? window.sinAnunciosJS : false;

if (sinAnunciosJS == false) {

    // Mostrar alternando lo que había con lo del hosting (07/Mar/06)
    var hoyBanArriba = new Date();
    var mBanSegundos = hoyBanArriba.getSeconds(); // .getMinutes();
    
	// por si se indican los segundos externamente (17/Abr/13)
	// si está definido se usa ese valor, si no, se usa mBanSegundos
    mBanSegundos = window.nSegundosJS ? window.nSegundosJS : mBanSegundos;
    
    // var bannerMSjul = false;

    // Para probar el anuncio del sponsor
    //mBanSegundos = 11
    //mBanSegundos = 56 


    // El 15/Jun/2010 13.35 pongo 4 anuncios: Domitienda, SolidQ, Luarna y Microsoft
    // El de Microsoft no se ve... lo quito... 15/Jun/10 15.34

    // El 20/May/2010 23.20 pongo solo 3 anuncios (Domitienda, SolidQ y Luarna)
    // el 04/Ago/2010 08.11 pongo 4, para incluir el de Aula Vulcan de dotnetmania
    // el 09/Nov/2010 18.24 pongo nuevamente 3, quito Aula Vulcan

    if (mBanSegundos < 15) {
		document.write(""+
		"<div style='margin:4px'>"+
		"<center>"+
"<!-- BEGIN PUB-FIT 468x60 - elguille.info -->"+
"<IFRAME FRAMEBORDER=0 MARGINWIDTH=0 MARGINHEIGHT=0 SCROLLING=NO WIDTH=468 HEIGHT=60 SRC='http://u.pub-fit.com/1319.html?s=468x60'></IFRAME>"+
"<!-- END PUB-FIT 468x60 - elguille.info -->"+
		"</center>"+
		"</div>"+
		"");
    }
    else if (mBanSegundos < 30) {
        document.write("" +
        "<div style='border:0px; padding:0.5em 0em; text-align:center; margin:1em 3.0em'>" +
        "    <a href='http://university.solidq.com/' target='_blank'>" +
        "    <img alt='Masters SolidQ University' src='/sponsors/SolidQUniversity_masters.gif' /></a>" +
        "</div>" +
        "");
    }
    else if (mBanSegundos < 45) {
        document.write("" +
		"<div style='text-align:center'>"+
		"    <p><a href='http://www.domitienda.com/' target='_blank'>"+
		"    <img alt='Ofertas de alojamiento en DomiTienda' src='https://www.domitienda.com/promociones/Afiliados/300250.png' style='border:0px transparent none' /></a>&nbsp;</p>"+
		"</div>"+
        "");
    }
    else {
		document.write(""+
        "<div style='border:0px; padding:0.5em 0em; text-align:center; margin:1em 3.0em'>" +
        "    <a href='http://university.solidq.com/' target='_blank'>" +
        "    <img alt='Masters SolidQ University' src='/sponsors/SolidQUniversity_masters.gif' /></a>" +
        "</div>" +
		"");
    }
}
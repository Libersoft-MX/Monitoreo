(function(){var c=document,d="length",e=" con el Traductor de Google?",f=".",k="Con la tecnolog\u00eda de ",l="Desactivar para: ",m="Desactivar traducci\u00f3n del ",n="Google ha traducido esta p\u00e1gina autom\u00e1ticamente al ",p="Traducido al: ",q="Traducir todo al ",r="Traductor de Google",s="Ver esta p\u00e1gina en: ",t="var ",u="\u00bfQuieres traducir esta p\u00e1gina al ",v=this;
function w(a,z){var g=a.split(f),b=v;g[0]in b||!b.execScript||b.execScript(t+g[0]);for(var h;g[d]&&(h=g.shift());)g[d]||void 0===z?b=b[h]?b[h]:b[h]={}:b[h]=z}Math.random();var x={0:r,1:"Cancelar",2:"Cerrar",3:function(a){return n+(a+f)},4:function(a){return p+a},5:"Error: el servidor no ha podido completar la solicitud. Vuelve a intentarlo m\u00e1s tarde.",6:"M\u00e1s informaci\u00f3n",7:function(a){return k+a},8:r,9:"Traducci\u00f3n en curso",10:function(a){return u+(a+e)},11:function(a){return s+a},12:"Mostrar texto original",13:"El contenido de este archivo local se enviar\u00e1 a Google para traducirlo con una conexi\u00f3n segura.",14:"El contenido de esta p\u00e1gina segura se enviar\u00e1 a Google para traducirlo con una conexi\u00f3n segura.",
15:"El contenido de esta p\u00e1gina de intranet se enviar\u00e1 a Google para traducirlo con una conexi\u00f3n segura.",16:"Seleccionar idioma",17:function(a){return m+a},18:function(a){return l+a},19:"Siempre oculto",20:"Texto original:",21:"Sugiere una traducci\u00f3n mejor",22:"Enviar",23:"Traducir todo",24:"Restaurar todo",25:"Cancelar todo",26:"Traducir secciones a mi idioma",27:function(a){return q+a},28:"Mostrar idiomas originales",29:"Opciones",30:"Desactivar la traducci\u00f3n en este sitio",
31:null,32:"Mostrar traducciones alternativas",33:"Haz clic en las palabras anteriores para obtener traducciones alternativas.",34:"Utilizar",35:"Pulsa May\u00fas y arrastra las palabras para cambiar el orden.",36:"Haz clic para obtener traducciones alternativas.",37:"Mant\u00e9n pulsada la tecla May\u00fas y, a continuaci\u00f3n, haz clic en las palabras y arr\u00e1stralas para cambiar el orden.",38:"Gracias por proponer una traducci\u00f3n al Traductor de Google.",39:"Administrar la traducci\u00f3n de este sitio",
40:"Haz clic en una palabra para obtener traducciones alternativas o doble clic para editar las traducciones directamente.",41:"Texto original",42:r,43:"Traducir",44:"Se ha enviado tu correcci\u00f3n.",45:"Error: no se admite el idioma de la p\u00e1gina web."};var y=window.google&&google.translate&&google.translate._const;
if(y){var A;a:{for(var B=[],C=["18,0.01,20130823"],D=0;D<C[d];++D){var E=C[D].split(","),F=E[0];if(F){var G=Number(E[1]);if(G&&!(0.1<G||0>G)){var H=Number(E[2]),I=new Date,J=1E4*I.getFullYear()+100*(I.getMonth()+1)+I.getDate();!H||H<J||B.push({version:F,a:G,b:H})}}}for(var K=0,L=window.location.href.match(/google\.translate\.element\.random=([\d\.]+)/),M=Number(L&&L[1])||Math.random(),D=0;D<B[d];++D){var N=B[D],K=K+N.a;if(1<=K)break;if(M<K){A=N.version;break a}}A="17"}var O="/translate_static/js/element/%s/element_main.js".replace("%s",
A);if("0"==A){var P=" translate_static js element %s element_main.js".split(" ");P[P[d]-1]="main_es.js";O=P.join("/").replace("%s",A)}if(y._cjlc)y._cjlc(y._pas+y._pah+O);else{var Q=y._pas+y._pah+O,R=c.createElement("script");R.type="text/javascript";R.charset="UTF-8";R.src=Q;var S=c.getElementsByTagName("head")[0];S||(S=c.body.parentNode.appendChild(c.createElement("head")));S.appendChild(R)}w("google.translate.m",x);w("google.translate.v",A)};})()

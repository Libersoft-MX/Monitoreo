COMSCORE.SiteRecruit.Broker.config = {	version: "5.0.3",	cddsDomains: 'store.microsoft.com|xbox.com|www.microsoft.com|go.microsoft.com|windowsphone.com|microsoftstore.com|(templates|support).office.com',	cddsInProgress: 'cddsinprogress',	domainSwitch: 'tracking3p',	domainMatch: '([\\da-z\.-]+\.com)',	delay: 3000,		testMode: false,	cookie:{		name: 'msresearch',		path: '/',		domain:  '.microsoft.com' ,		duration: 90,		rapidDuration: 0,		expireDate: ''	},	thirdPartyOptOutCookieEnabled : false,	prefixUrl: "",	Events: {		beforeRecruit: function() {var _halt = true;			var _days = false;var _stC = readCookie("ST_GN_EN-US"); if(_stC){  var _s = _stC.split('.');  _t = _s[0].split('_');	_d = _t[1];  var mult = 86400000; 
if(_d && _d > 0){   var myDate = new Date().getTime();   var b = myDate - (_d * mult);   _days = (b/mult); }} if(_days && _days <= 90){	COMSCORE.SiteRecruit._halt = true;}
var screenWidth = self.screen.availWidth, screenHeight = self.screen.availHeight;
if(/iphone|ipad|ipod|android|opera mini|blackberry|bb10|mobile safari|windows (phone|ce)|iemobile|htc|nokia|mobile/i.test(navigator.userAgent) || screenWidth <= 450 ){	COMSCORE.SiteRecruit._halt = true;} if(typeof ms != 'undefined' && typeof ms.ssversion != 'undefined'){ if(ms.ssversion == '200'){		_halt = false;	}}
if(typeof document.getElementsByName('ms.ssversion')[0] != 'undefined' && typeof document.getElementsByName('ms.ssversion')[0].getAttribute('content') != 'undefined'){	_ssvervion = document.getElementsByName('ms.ssversion')[0].getAttribute('content');		if(_ssvervion == '200'){		_halt = false;	}} COMSCORE.SiteRecruit.Broker.config.mapping[0].halt = _halt;
if(/test=comscore/i.test(window.location.toString())){	COMSCORE.SiteRecruit._halt = false;}	}	},mapping:[
	{m: '/en-us', c: 'inv_c_p329970507.js', f: 0.5, p: 0 	}
	,{m: 'test=comscore', c: 'inv_c_p329970507.js', f: 100, p: 1 ,prereqs:{	content: [] ,cookie: [ {'name':'tstMode','value':'1'}] ,externalDomain: [] } }
]}; function readCookie(name){var ca = document.cookie.split(';');  var nameEQ = name + "=";  for(var i=0; i < ca.length; i++) {    var c = ca[i];    while (c.charAt(0)==' ') c = c.substring(1, c.length); if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);    }  return false;}var gIdelay = 0;if (readCookie("graceIncr") == 1) {	gIdelay = 5000;}
setTimeout(function(){_set_SessionCookie("graceIncr", 0)},gIdelay);
function _set_SessionCookie(_name, _val) {  if (_name == COMSCORE.SiteRecruit.Broker.config.domainSwitch) {		var r = new RegExp(COMSCORE.SiteRecruit.Broker.config.domainMatch,'i');		if (r.test(_val)) { _val = RegExp.$1 + RegExp.$2; var c = _name + '=' + _val + '; path=/' + '; domain=' + COMSCORE.SiteRecruit.Broker.config.cookie.domain; document.cookie = c; }	}else if(COMSCORE.isDDInProgress()){ 	if(_name == "captlinks"){	if(/^http(s)?\:/i.test(_val)){var _reg = new RegExp("http(s)?://"+document.domain+"/", "i");	var _val = _val.replace(_reg, '');}	if(_val && _val.length > 2){c_vals = readCookie("captlinks");if(c_vals){	if(c_vals.indexOf(_val) == -1){	var str = c_vals +"," + _val;	if(str.length <= 1240){	_val = str;	}else{ _val=false; }}else{ _val = false; }}}}	if(_val){  		var c = _name+'=' + _val + '; path=/' + '; domain=' + COMSCORE.SiteRecruit.Broker.config.cookie.domain; document.cookie = c; }}}
setTimeout('_set_SessionCookie("graceIncr","0")', 3000);
function SRappendEventListener(srElement, _name, _val){	if(srElement.addEventListener){	srElement.addEventListener('click',function(event){	_set_SessionCookie(_name, _val); },false);}else{			srElement.attachEvent('onclick',function(){	_set_SessionCookie(_name, _val); });}}
var allLinks = document.getElementsByTagName("a");
for (var i = 0, n = allLinks.length; i < n; i++){	var r = new RegExp(COMSCORE.SiteRecruit.Broker.config.cddsDomains,'i');	var _clickURL = allLinks[i].href;	if (r.test(_clickURL)) {		if (/store.microsoft.com/i.test(_clickURL)) { _clickURL = ".microsoftstore.com" }	if (/microsoft.com\/windowsphone/i.test(_clickURL)) { _clickURL = ".windowsphone.com" }	if (!(/microsoft.com/i.test(_clickURL))) {			SRappendEventListener(allLinks[i], COMSCORE.SiteRecruit.Broker.config.domainSwitch, _clickURL);		}	}try{	if(_clickURL && _clickURL != '' && !(/javascript\:void(0)/i.test(_clickURL)) ){		if(/login\.live|msacademicverify|(o15\.officeredir|office)\.microsoft\.com|login|LiveLogin|(office|office\.microsoft|live|skype|onedrive)\.com/i.test(_clickURL)){			SRappendEventListener(allLinks[i], "graceIncr", 1);}
if( /(contactus\/(technicalsupport|setupandinstallation)) || (my\/(account|devicesoftware|supportrequests) ) /i.test(_clickURL)){			if(/sign in/i.test(document.getElementById("idPPScarab").innerHTML)) { SRappendEventListener(allLinks[i], "graceIncr", 1);	}}}} catch(e){}}
var cs_inputs = document.getElementsByTagName('input');for(var c=0; c<cs_inputs.length; c++){  if(cs_inputs[c].getAttribute('ms.cmpnm')=='signin'){  	SRappendEventListener(cs_inputs[c], "graceIncr", 1);	}} 
var cs_divs = document.getElementsByTagName('div');for(var c=0; c<cs_divs.length; c++){	if(/msame_Header_name msame_TxtTrunc|msame_Header msame_unauth/i.test(cs_divs[c].getAttribute('class'))){ SRappendEventListener(cs_divs[c], "graceIncr", 1);  }}
function crossDomainCheck() {	if (intervalMax > 0) { intervalMax --;	var cookieName = COMSCORE.SiteRecruit.Broker.config.cddsInProgress;	if (COMSCORE.SiteRecruit.Utils.UserPersistence.getCookieValue(cookieName) != false ) {	COMSCORE.SiteRecruit.DDKeepAlive.setDDTrackerCookie();	COMSCORE.SiteRecruit._halt = true;				clearCrossDomainCheck();	}} else {	clearCrossDomainCheck(); }}
function clearCrossDomainCheck(){window.clearInterval(crossDomainInterval);} var intervalMax = 10;var crossDomainInterval = window.setInterval('crossDomainCheck()', '1000'); if (COMSCORE.SiteRecruit.Broker.delayConfig == true) {	COMSCORE.SiteRecruit.Broker.config.delay = 1000;} if(( !(/support.microsoft.com/i.test(document.referrer)) || document.referrer == '' ) && COMSCORE.SiteRecruit.Broker.isDDInProgress() == false) {	COMSCORE.SiteRecruit.Broker.config.delay = 10000;}
window.setTimeout('COMSCORE.SiteRecruit.Broker.run()', COMSCORE.SiteRecruit.Broker.config.delay);
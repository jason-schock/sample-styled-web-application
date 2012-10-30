//development account
var _gaq = _gaq || [];
_gaq.push(['_setAccount', 'UA-29573921-1']);
if (typeof _ga_company_code !== 'undefined')
    _gaq.push(['_setCustomVar', 1, 'c_cd', _ga_company_code, 3]); /* custom page variable */
if (typeof _ga_login_employeeType !== 'undefined')
    _gaq.push(['_setCustomVar', 2, 'ee_type', _ga_login_employeeType, 3]); /* custom page variable */
if (typeof _ga_netchex_login_code !== 'undefined')
    _gaq.push(['_setCustomVar', 3, 'nl_ind', _ga_netchex_login_code, 3]); /* custom page variable */
_gaq.push(['_setSiteSpeedSampleRate', 100]);
_gaq.push(['_trackPageview']);

(function () {
    var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
})();

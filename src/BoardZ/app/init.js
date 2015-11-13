!function ($, jQuery) {
    'use strict';

    window.app = window.app || {};
    window.app.module = angular.module('xplatform-sample', ['ui.router',
        'pascalprecht.translate',
        'ngSanitize',
        'ngNotify',
        'angular-loading-bar',
        'leaflet-directive',
        'ngCordova',
        'ngAnimate'
    ]);

    // insert the base URL here
    //app.module.constant('apiBaseUrl', 'https://boardzapi.azurewebsites.net/');
    //app.module.constant('apiBaseUrl', 'http://192.168.77.112:9090/');
    app.module.constant('apiBaseUrl', 'http://10.37.129.3:9090/');
    FastClick.attach(document.body);
}();

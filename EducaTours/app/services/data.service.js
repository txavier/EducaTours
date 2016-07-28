(function () {
    'use strict';

    angular
        .module('app')
        .factory('dataService', dataService);

    dataService.$inject = ['$http', '$q'];

    function dataService($http, $q) {
        var apiUrl = 'api/';

        var service = {
            sendMessage: sendMessage
        };

        return service;

        function sendMessage(emailInformation) {
            return $http.post(apiUrl + 'email/sendMessage', emailInformation).then(sendMessageComplete, sendMessageFailed);

            function sendMessageComplete(response) {
                return response.data;
            }

            function sendMessageFailed(error) {
                return $q.reject(error);
            }
        }
    }

})();
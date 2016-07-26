(function () {
    angular
        .module('app')
        .controller('contactController', contactController);

    contactController.$inject = ['$scope', '$routeParams'];

    function contactController($scope, $routeParams) {
        var vm = this;

        activate();

        function activate() {
        }

    }

})();
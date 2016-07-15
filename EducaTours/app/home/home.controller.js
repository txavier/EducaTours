(function () {
    angular
        .module('app')
        .controller('homeController', homeController);

    homeController.$inject = ['$scope', '$routeParams'];

    function homeController($scope, $routeParams) {
        var vm = this;

        activate();

        function activate() {
        }

    }

})();
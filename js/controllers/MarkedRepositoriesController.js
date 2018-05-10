app.controller("MarkedRepositoriesController", function ($scope, $http) {

    angular.element(document).ready(function () {
        $http.get("/Search/GetMarkedRepository").then(function (response) {
            $scope.markedRepositories = response.data;
        });
    });
});
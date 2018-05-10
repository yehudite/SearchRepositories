app.controller("SearchRepositoriesController", function ($scope,$http) {

    $scope.search = function () {
        var url = "https://api.github.com/search/repositories?q=" + $scope.repositoryName;
        $http.get(url).then(function (response) {
            $scope.repositories = response.data.items;
        });
    }; 

    $scope.markRepository = function (repository) {
        $http.post("/Search/MarkRepository", { "repositoryName" : repository.full_name, "avatar" : repository.owner.avatar_url })
            .then(function (response) { });
    }; 
});
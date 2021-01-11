(function () {

    var app = angular.module("githubViewer", ["ngRoute"]);

    app.config(function ($routeProvider) {
        $routeProvider
            .when("/main", {
                templateUrl: "./main.html",
                controller: "MainController as ctrl"
            })
            .when("/user/:username", {
                templateUrl: "./user.html",
                controller: "UserController as ctrl"
            })
            .when("/repo/:username/:reponame", {
                templateUrl: "./repo.html",
                controller: "RepoController as ctrl"
            })
        .otherwise({redirectTo:"/main"});

    });

}());
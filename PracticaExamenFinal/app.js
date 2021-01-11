(function () {

    var app = angular.module("surveyApp", ["ngRoute"]);

    app.config(function ($routeProvider){
        $routeProvider
                .when("/survey",{
                    templateUrl:"./survey-list/survey-list-template.html",
                    controller: "SurveyListController"
                })
                .when("/survey/:surveyid",{
                    templateUrl:"./survey-answer/survey-answer-template.html",
                    controller: "SurveyAnswerController"
                })
                .otherwise({redirectTo:"/survey"});
        });

}());

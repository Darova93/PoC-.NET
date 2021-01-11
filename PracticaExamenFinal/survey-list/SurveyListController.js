(function () {
   
    var module = angular.module("surveyApp");

    var SurveyListController = function($scope, surveyAPI) {
    
        surveyAPI.getSurveys().then(function (data){
            $scope.surveys = data;
        })
    };

    module.controller("SurveyListController", SurveyListController);
    
}());
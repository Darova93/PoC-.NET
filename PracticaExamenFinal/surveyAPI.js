(function () {

    var surveyAPI = function ($http) {

        var getSurveys = function () {
            return $http.get("http://localhost:3000/survey")
                .then(function (response) {
                    return response.data;
                });
        };

        var getQuestions = function (id) {
            return $http.get("http://localhost:3000/questions/")
                .then(function (response) {
                    return response.data;
                });
        };

        return {
            getSurveys: getSurveys,
            getQuestions: getQuestions
        };
    };

    var module = angular.module("surveyApp");
    module.factory("surveyAPI", surveyAPI);

}());
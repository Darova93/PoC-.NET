(function () {

    var module = angular.module("surveyApp");

    var SurveyAnswerController = function ($scope, surveyAPI, $routeParams) {

        var surveyForm = [];
        var surveyid = $routeParams.surveyid;

        surveyAPI.getQuestions(surveyid).then(function (data) {
            var questions = data;
            questions.forEach(question => {
                switch (question.questiontypeId) {
                    case 1:
                        question.input = "text";
                        question.options.push("Type your answer here");
                        break;
                    case 2:
                        question.input = "checkbox";
                        break;
                    case 3:
                        question.input = "radio";
                        break;
                }
        
            var answer = [{
                surveyid : $routeParams.surveyid,
                questionid : question.id.toString(),
                optionid : "",
                opentext : "",
                guest : ""
            }]

            surveyForm.push(answer);

            });

            console.log(surveyForm);
            $scope.questions = questions;
            
        })

    };

    module.controller("SurveyAnswerController", SurveyAnswerController);

}());


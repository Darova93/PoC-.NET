﻿using Softtek.Academy2018.SurveyApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softtek.Academy2018.SurveyApp.Business.Contracts
{
    public interface IQuestionOptionService
    {
        bool AddOptionToQuestion(int optionid, int questionid);

        bool RemoveOptionToQuestion(int optionid, int questionid);

        ICollection<Option> GetOptionByQuestion(int surveyid);
    }
}

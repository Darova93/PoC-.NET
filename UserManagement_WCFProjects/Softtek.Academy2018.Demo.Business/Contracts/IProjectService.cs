﻿using Softtek.Academy2018.Demo.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softtek.Academy2018.Demo.Business.Contracts
{
    public interface IProjectService
    {
        int Add(Project project);
        
        ICollection<Project> GetAll();
         

    }
}

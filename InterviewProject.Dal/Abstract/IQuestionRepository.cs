﻿using InterviewProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProject.Dal.Abstract
{
   public interface IQuestionRepository:IGenericRepository<Question>
    {
        List<Question> GetExam(long id);
    }
}
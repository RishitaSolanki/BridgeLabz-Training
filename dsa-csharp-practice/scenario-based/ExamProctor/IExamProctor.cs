using System;
using System.Collections.Generic;
using System.Text;

namespace ScenarioBased.ExamProctor
{
  
        public interface IExamProctor
        {
            void VisitQuestion(int qid);
            void AnswerQuestion(int qid, string answer);
            void ShowLastVisited();
            void SubmitExam();
        }
    }


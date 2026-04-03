using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.ExamProctor
{
    interface IExamProctor
    {
        void VisitQuestion(int qid);
        void AnswerQuestion(int qid, string answer);
        void ShowLastVisited();
        void SubmitExam();
    }

}

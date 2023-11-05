using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4Average
{
    class Program
    {
        static void Main(string[] args)
        {

            double score1,
                   score2,
                   score3,
                   score4,
                   score5;
            score1 = 30;
            score2 = 78;
            score3 = 45;
            score4 = 24;
            score5 = 89;
            double totalScore = score1 + score2 + score3 + score4 + score5;
            double averageScore = totalScore / 5;
            Console.WriteLine("Total Score Obtained {0}"
                             + "\n\nAverage Score Obtained {1}", totalScore, averageScore);
        }
    }
}

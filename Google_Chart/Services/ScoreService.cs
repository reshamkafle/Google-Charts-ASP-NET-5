using Google_Chart.Interfaces;
using Google_Chart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google_Chart.Services
{
    public class ScoreService : IScoreService
    {
        public IEnumerable<Student_Marks> GetScores()
        {
            return new List<Student_Marks>
            {
                new Student_Marks{Subject="Biology", Score= 80},
                new Student_Marks{Subject="Chemistry", Score=90},
                new Student_Marks{Subject="English", Score=100},
                new Student_Marks{Subject="Chinese", Score=88},
            };
        }
    }
}

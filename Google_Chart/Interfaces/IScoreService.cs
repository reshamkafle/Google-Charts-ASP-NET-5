using Google_Chart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google_Chart.Interfaces
{
    public interface IScoreService
    {
        public IEnumerable<Student_Marks> GetScores();
    }
}

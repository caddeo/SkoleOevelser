using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Excercise02
{
    class Soccer
    {

        public string HomeField { get; set; }

        public List<GoalScore> goalscore { get; set; }

        public Soccer(string HomeField) {
            this.HomeField = HomeField;

            goalscore = new List<GoalScore>();
        }

        public Soccer() : this("") {}
    }
}

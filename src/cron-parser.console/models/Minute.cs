using cron_parser.console.models.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cron_parser.console.models
{
    public class Minute : Field
    {
        public Minute(string input) : base(input)
        {
            AllowedValues = new List<int>();

            for (int i = 0; i <= 59; i++)
            {
                AllowedValues.Add(i);
            }
        }
    }
}

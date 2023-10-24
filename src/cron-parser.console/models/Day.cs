using cron_parser.console.models.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cron_parser.console.models
{
    public class Day : Field
    {
        public Day(string input) : base(input)
        {
            AllowedValues = new List<int>();

            for (int i = 1; i <=31; i++)
            {
                AllowedValues.Add(i);
            }
        }
    }
}

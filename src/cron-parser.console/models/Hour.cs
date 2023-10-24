using cron_parser.console.models.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cron_parser.console.models
{
    public class Hour : Field
    {
        public Hour(string input) : base(input)
        {
            AllowedValues = new List<int>();

            for (int i = 0; i <= 23; i++)
            {
                AllowedValues.Add(i);
            }
        }
    }
}

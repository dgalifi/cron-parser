using cron_parser.console.models.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cron_parser.console.models
{
    public class Month : Field
    {
        public Month(string input) : base(input)
        {
            AllowedValues = new List<int>();

            for (int i = 1; i <= 12; i++)
            {
                AllowedValues.Add(i);
            }
        }
    }
}

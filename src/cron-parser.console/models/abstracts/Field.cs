using cron_parser.console.models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cron_parser.console.models.abstracts
{
    public abstract class Field
    {
        public List<int>? AllowedValues { get; set; }

        public string Input { get; set; }

        public bool IsStepFunction { get; set; }

        public int Steps { get; set; }

        public Field(string input)
        {
            if (input.Contains('/'))
            {
                IsStepFunction = true;
                Input = input.Split('/').First();
                Steps = int.Parse(input.Split('/')[1]);
            }
            else
                Input = input;
        }

        public Format GetFormat()
        {
            if (int.TryParse(Input, out int val))
                return Format.SpecificValue;

            else if (Input.Trim() == "?")
                return Format.QuestionMark;

            else if (Input.Contains('*'))
                return Format.Asterisk;

            else if (Input.Contains(','))
                return Format.List;

            else if (Input.Contains('-'))
                return Format.Range;

            return Format.Error;
        }
    }
}

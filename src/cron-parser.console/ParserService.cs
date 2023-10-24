using cron_parser.console.models.abstracts;
using cron_parser.console.models.Enums;

namespace cron_parser.console
{
    public interface IParserService
    {
        string Parse(Field field);
    }

    public class ParserService : IParserService
    {
        public string Parse(Field field)
        {
            var format = field.GetFormat();

            IList<string> values = null;

            if (format == Format.SpecificValue)
                values = new List<string> { field.Input };

            else if (format == Format.QuestionMark)
                values = new List<string> { "?" };

            else if (format == Format.Asterisk)
                values = field.AllowedValues.Select(x => x.ToString()).ToList();


            // i.e. 1,5
            else if (format == Format.List)
            {
                values = field.Input.Split(',');
            }

            // i.e. 1-5
            else if (format == Format.Range)
            {
                var start = int.Parse(field.Input.Split('-').First());
                var end = int.Parse(field.Input.Split('-')[1]);

                values = field.AllowedValues.GetRange(field.AllowedValues.First() == 0 ? start : start - 1, end - start + 1).Select(x => x.ToString()).ToList();
            }

            // i.e. */15
            if (field.IsStepFunction)
            {
                values = GetStepValues(values, field.Steps);
            }

            return string.Join(' ', values ?? new string[0]);
        }

        private List<string> GetStepValues(IList<string> values, int steps)
        {
            var ret = new List<string>();
            for (int i = 0; i < values.Count; i++)
            {
                if (i % steps == 0)
                    ret.Add(values[i]);
            }

            return ret;
        }
    }
}

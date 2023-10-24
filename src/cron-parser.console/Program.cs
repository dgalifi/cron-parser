// See https://aka.ms/new-console-template for more information
using System.Text;
using cron_parser.console;
using cron_parser.console.models;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
            .AddSingleton<IParserService, ParserService>()            
            .BuildServiceProvider();

var parser = serviceProvider.GetService<IParserService>();

StringBuilder sb = new StringBuilder();

var fields = args[0].Split(' ');

sb.AppendLine($"minute        {parser.Parse(new Minute(fields[0]))}");
sb.AppendLine($"hour          {parser.Parse(new Hour(fields[1]))}");
sb.AppendLine($"day of month  {parser.Parse(new Day(fields[2]))}");
sb.AppendLine($"month         {parser.Parse(new Month(fields[3]))}");
sb.AppendLine($"day of week   {parser.Parse(new DayOfTheWeek(fields[4]))}");
sb.AppendLine($"command       {fields[5]}");

Console.WriteLine(sb.ToString());
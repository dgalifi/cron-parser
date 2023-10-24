using cron_parser.console;
using cron_parser.console.models;
using System;

namespace cron_parser.tests
{
    public class ParserTests
    {
        private ParserService _parser;

        [SetUp]
        public void Setup()
        {
            _parser = new ParserService();
        }

        [Test]
        public void ParseAllMinutes()
        {
            var field = new Minute("*");

            var res = _parser.Parse(field);

            var expected = "0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45 46 47 48 49 50 51 52 53 54 55 56 57 58 59";

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void ParseAllHours()
        {
            var field = new Hour("*");

            var res = _parser.Parse(field);

            var expected = "0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23";

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void ParseAllDays()
        {
            var field = new Day("*");

            var res = _parser.Parse(field);

            var expected = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31";

            Assert.AreEqual(expected, res);

        }

        [Test]
        public void ParseAllMonths()
        {
            var field = new Month("*");

            var res = _parser.Parse(field);

            var expected = "1 2 3 4 5 6 7 8 9 10 11 12";

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void ParseAllDaysOfWeek()
        {
            var field = new DayOfTheWeek("*");

            var res = _parser.Parse(field);

            var expected = "0 1 2 3 4 5 6";

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void ParseListMinutes()
        {
            var field = new Minute("1,5");

            var res = _parser.Parse(field);

            var expected = "1 5";

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void ParseRangeMinute()
        {
            var field = new Minute("1-5");

            var res = _parser.Parse(field);

            var expected = "1 2 3 4 5";

            Assert.AreEqual(expected, res);
        }


        [Test]
        public void ParseRangeMonth()
        {
            var field = new Month("1-5");

            var res = _parser.Parse(field);

            var expected = "1 2 3 4 5";

            Assert.AreEqual(expected, res);
        }


        [Test]
        public void ParseRangeMinuteWithSteps()
        {
            var field = new Minute("1-5/2");

            var res = _parser.Parse(field);

            var expected = "1 3 5";

            Assert.AreEqual(expected, res);
        }


        [Test]
        public void ParseValuesMinuteWithSteps()
        {
            var field = new Minute("1,5,7,8,9,10,15/3");

            var res = _parser.Parse(field);

            var expected = "1 8 15";

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void ParseAllMinuteWithSteps()
        {
            var field = new Minute("*/15");

            var res = _parser.Parse(field);

            var expected = "0 15 30 45";

            Assert.AreEqual(expected, res);
        }
    }
}

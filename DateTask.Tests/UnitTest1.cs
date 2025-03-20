using TestTask;
namespace DateTask.Tests
{
    [TestFixture]
    public class Tests
    {
        // Первый метод
        [Test]
        public void LocalConvertToUtcTest()
        {
            // arrange
            int year = 1999;
            int month = 12;
            int day = 31;
            int hour = 11;
            int minute = 59;
            int second = 59;
            DateTimeKind kind = DateTimeKind.Local;

            DateTime dateTime = new(year, month, day, hour, minute, second, kind);
            hour = kind != DateTimeKind.Utc ? hour - 3 : hour;
            DateTime expected = new(year, month, day, hour, minute, second);

            // act
            DateTime actual = Program.ConvertToUtc(dateTime);

            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void UnspecifiedConvertToUtcTest()
        {
            // arrange
            int year = 1999;
            int month = 12;
            int day = 31;
            int hour = 11;
            int minute = 59;
            int second = 59;
            DateTimeKind kind = DateTimeKind.Unspecified;

            DateTime dateTime = new(year, month, day, hour, minute, second, kind);
            hour = kind != DateTimeKind.Utc ? hour - 3 : hour;
            DateTime expected = new(year, month, day, hour, minute, second);

            // act
            DateTime actual = Program.ConvertToUtc(dateTime);

            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void UTCConvertToUtcTest()
        {
            // arrange
            int year = 1999;
            int month = 12;
            int day = 31;
            int hour = 11;
            int minute = 59;
            int second = 59;
            DateTimeKind kind = DateTimeKind.Utc;

            DateTime dateTime = new(year, month, day, hour, minute, second, kind);
            hour = kind != DateTimeKind.Utc ? hour - 3 : hour;
            DateTime expected = new(year, month, day, hour, minute, second);

            // act
            DateTime actual = Program.ConvertToUtc(dateTime);

            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Второй метод
        [Test]
        public void WithoutDtParamWithDefaultTest()
        {
            DateTimeKind kind = DateTimeKind.Local;
            DateTime defaultTime = new(1, 1, 1, 1, 1, 1, kind);

            DateTime actual = Program.ConvertToUtc(null, defaultTime);

            Assert.That(actual, Is.EqualTo(defaultTime));
        }

        [Test]
        public void LocalConvertToUtcParamWithDefaultTest()
        {
            // arrange
            DateTimeKind kind = DateTimeKind.Local;
            DateTime defaultTime = new(1, 1, 1, 1, 1, 1, kind);

            // act
            DateTime actual = Program.ConvertToUtc(null, defaultTime);

            // assert
            Assert.That(actual, Is.EqualTo(defaultTime));
        }

        [Test]
        public void UnspecifiedConvertToUtcParamWithDefaultTest()
        {
            // arrange
            DateTimeKind kind = DateTimeKind.Unspecified;
            DateTime defaultTime = new(1, 1, 1, 1, 1, 1, kind);

            // act
            DateTime actual = Program.ConvertToUtc(null, defaultTime);

            // assert
            Assert.That(actual, Is.EqualTo(defaultTime));
        }

        [Test]
        public void UTCConvertToUtcDefaultAndDTNullTest()
        {
            // arrange
            DateTimeKind kind = DateTimeKind.Utc;
            DateTime defaultTime = new(1, 1, 1, 1, 1, 1, kind);

            // act
            DateTime actual = Program.ConvertToUtc(null, defaultTime);

            // assert
            Assert.That(actual, Is.EqualTo(defaultTime));
        }

        // Третий метод
        [Test]
        public void LocalConvertToUtcDefaultTest()
        {
            // arrange
            int year = 1999;
            int month = 12;
            int day = 31;
            int hour = 11;
            int minute = 59;
            int second = 59;
            DateTimeKind kind = DateTimeKind.Local;

            DateTime defaultTime = new(0, 0, 0, 0, 0, 0, kind);
            DateTime dateTime = new(year, month, day, hour, minute, second, kind);

            hour = kind != DateTimeKind.Utc ? hour - 3 : hour;
            DateTime expected = new(year, month, day, hour, minute, second);

            // act
            DateTime actual = Program.ConvertToUtc(dateTime, defaultTime);

            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void UnspecifiedConvertToUtcDefaultTest()
        {
            // arrange
            int year = 1999;
            int month = 12;
            int day = 31;
            int hour = 11;
            int minute = 59;
            int second = 59;
            DateTimeKind kind = DateTimeKind.Unspecified;

            DateTime defaultTime = new(0, 0, 0, 0, 0, 0, kind);
            DateTime dateTime = new(year, month, day, hour, minute, second, kind);

            hour = kind != DateTimeKind.Utc ? hour - 3 : hour;
            DateTime expected = new(year, month, day, hour, minute, second);

            // act
            DateTime actual = Program.ConvertToUtc(dateTime, defaultTime);

            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void UTCConvertToUtcDefaultTest()
        {
            // arrange
            int year = 1999;
            int month = 12;
            int day = 31;
            int hour = 11;
            int minute = 59;
            int second = 59;
            DateTimeKind kind = DateTimeKind.Utc;

            DateTime defaultTime = new(0, 0, 0, 0, 0, 0, kind);
            DateTime dateTime = new(year, month, day, hour, minute, second, kind);

            hour = kind != DateTimeKind.Utc ? hour - 3 : hour;
            DateTime expected = new(year, month, day, hour, minute, second);

            // act
            DateTime actual = Program.ConvertToUtc(dateTime, defaultTime);

            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void NullConvertToUTCTest()
        {
            // arrange
            DateTime dateTime = new();
            DateTime expected = new();

            // act
            DateTime actual = Program.ConvertToUtc(dateTime);

            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
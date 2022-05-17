using Iprice.Implementation;
using Xunit;

namespace Iprice.Tests
{
    public class ProcessorTests
    {
        private const string arrangeInput = "hello world";

        [Fact]
        public void InputStringReturnIsValid()
        {
            var validateInput = ProcessorClass.ValidateInput(arrangeInput);
            Assert.True(validateInput);
        }

        [Fact]
        public void EmptyStringInputReturnIsInvalid()
        {
            var validateInput = ProcessorClass.ValidateInput(string.Empty);
            Assert.False(validateInput);
        }

        [Fact]
        public void ProcessedStringReturnIsValid()
        {
            var processString = ProcessorClass.ConvertStringIntoCsvReadyFormat(arrangeInput);
            Assert.Equal("h,E,l,L,o, ,W,o,R,l,D", processString);
        }

        [Fact]
        public void ProcessedStringReturnIsInvalid()
        {
            var processString = ProcessorClass.ConvertStringIntoCsvReadyFormat(arrangeInput);
            Assert.NotEqual("h,e,l,l,o, ,w,o,r,l,d", processString);
        }

        [Fact]
        public void GeneratedCsvFileIsValid()
        {
            var generateCsv = ProcessorClass.GenerateCSV(arrangeInput, false);
            var assertPath = @"C:\IpriceConsole\generated-data.csv";
            Assert.Equal(assertPath, generateCsv);
        }
    }
}

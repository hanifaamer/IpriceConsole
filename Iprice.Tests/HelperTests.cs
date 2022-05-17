using Iprice.Helper;
using Xunit;
using System.IO;
using System.Collections.Generic;

namespace Iprice.Tests
{
    public class HelperTests
    {
        private const string arrangeInput = "hello world";

        [Fact]
        public void UpperLetterStringReturnIsValid()
        {
            var convertString = StringHelper.ConvertStringIntoUpperLetter(arrangeInput);
            Assert.Equal("HELLO WORLD", convertString);
        }

        [Fact]
        public void UpperLetterStringReturnIsInValid()
        {
            var convertString = StringHelper.ConvertStringIntoUpperLetter(arrangeInput);
            Assert.NotEqual("Hello World", convertString);
        }

        [Fact]
        public void SmallLetterStringReturnIsValid()
        {
            var convertString = StringHelper.ConvertStringIntoSmallLetter(arrangeInput);
            Assert.Equal("hello world", convertString);
        }

        [Fact]
        public void SmallLetterStringReturnIsInValid()
        {
            var convertString = StringHelper.ConvertStringIntoSmallLetter(arrangeInput);
            Assert.NotEqual("Hello World", convertString);
        }

        [Fact]
        public void SplitStringReturnsIsValid()
        {
            var splitStringIntoListOfChar = StringHelper.SplitStringIntoListOfChar(arrangeInput);
            List<char> assertedList = new List<char> { 'h', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd' };
            Assert.Equal(assertedList, splitStringIntoListOfChar);
        }

        [Fact]
        public void AlternatedLowerAndUpperStringReturnIsValid()
        {
            var convertString = StringHelper.AlternateStringBetweenLowerUpper(arrangeInput);
            Assert.Equal("hElLo WoRlD", convertString);
        }

        [Fact]
        public void ConvertedCharListToCommaDelimitedStringReturnIsValid()
        {
            List<char> inputList = new List<char> { 'h', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd' };
            var convertString = StringHelper.ConvertListOfCharToDelimitedString(inputList);
            Assert.Equal("h,e,l,l,o, ,w,o,r,l,d", convertString);
        }

        [Fact]
        public void CheckedFolderReturnIsValid()
        {
            var folderPath = $"{Path.GetTempPath()}\\unit-test";
            var checkPath = FileHelper.CheckFolderExist(folderPath, true);

            Assert.True(checkPath);
        }

        [Fact]
        public void GeneratedPathReturnIsValid()
        {
            var folderPath = Path.GetTempPath() + @"\";
            var fileName = "data.csv";
            var assertedPath = $"{folderPath}{fileName}";

            var generatePath = FileHelper.GeneratePath(folderPath, fileName);
            Assert.Equal(assertedPath, generatePath);
        }

        [Fact]
        public void GeneratedFileNameReturnIsValid()
        {
            var fileName = "data";
            var fileExtension = "csv";

            var generateFileName = FileHelper.GenerateFileName(fileName, fileExtension, false);

            Assert.Equal("data.csv", generateFileName);
        }

        [Fact]
        public void GeneratedCsvFileWithEmptyInputReturnIsInvalid()
        {
            var filePath = @"C:\IpriceConsole\sample-data.csv";
            var generateCsv = FileHelper.GenerateFile(filePath);

            Assert.NotEqual(filePath, generateCsv);
        }

        [Fact]
        public void GeneratedCsvFileWithInputReturnIsValid()
        {
            var filePath = @"C:\IpriceConsole\sample-data.csv";
            var input = "hello";
            var generateCsv = FileHelper.GenerateFile(filePath, input);

            Assert.Equal(filePath, generateCsv);
        }

        [Fact]
        public void FileNotFoundExistReturnIsInvalid()
        {
            var filePath = @"C:\Iprice\random.csv";
            var executeProgram = FileHelper.OpenProgram(filePath);

            Assert.False(executeProgram);
        }
    }
}

using System;
using Iprice.Helper;

namespace Iprice.Implementation
{
    public class ProcessorClass
    {
        public static bool ValidateInput(string input)
        {
            try
            {
                if (input == string.Empty)
                    throw new Exception($"Empty string is not allowed. Program will be stopped.");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static string ConvertStringIntoCsvReadyFormat(string input)
        {
            var alternateInputBetweenLowerUpper = StringHelper.AlternateStringBetweenLowerUpper(input);
            var splitInputIntoCharacter = StringHelper.SplitStringIntoListOfChar(alternateInputBetweenLowerUpper);
            var convertListOfCharToDelimitedString = StringHelper.ConvertListOfCharToDelimitedString(splitInputIntoCharacter);

            return convertListOfCharToDelimitedString;
        }

        public static string GenerateCSV(string input, bool randomizeName = true)
        {
            var fileName = FileHelper.GenerateFileName("generated-data", "csv", randomizeName);
            var filePath = FileHelper.GeneratePath(Constant.CsvFolderPath, fileName);
            var csvData = ConvertStringIntoCsvReadyFormat(input);

            return FileHelper.GenerateFile(filePath, csvData);
        }
    }
}

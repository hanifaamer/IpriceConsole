using System;
using Iprice.Helper;
using Iprice.Implementation;

namespace Iprice
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your input: ");
            var getConsoleInput = Console.ReadLine();

            if (ProcessorClass.ValidateInput(getConsoleInput))
            {
                var capitalizedInput = StringHelper.ConvertStringIntoUpperLetter(getConsoleInput);
                var alternateLowerUpperInput = StringHelper.AlternateStringBetweenLowerUpper(getConsoleInput);
                var generateCsv = ProcessorClass.GenerateCSV(getConsoleInput);

                Console.WriteLine($"Convert string to upper letter: {capitalizedInput}");
                Console.WriteLine($"Convert string to alternated betweeb lower upper letter: {alternateLowerUpperInput}");

                if (generateCsv != string.Empty)
                {
                    Console.WriteLine($"CSV created!. The file path: {generateCsv}");
                    FileHelper.OpenProgram(generateCsv);
                }
            }
        }
    }
}

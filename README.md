## Generate a CSV file from an input string

This is a console application that accepts a string input.


### About the Console Application

The console application will display and generate the following output:

1 - Display the converted string input into an upper case letter.

2 - Display the converted string input into an alternate lower and upper case letter.

3 - Generate a CSV file that contains a converted delimited char from the string input.


### To publish the program, there are two methods:

1 - Publish as a self-contained release package

2 - Publish thru Microsoft Visual Studio


### Publish as a self-contained release package

1 - Open CMD

2 - Go to the project folder

```cmd

cd <Path to the Solution>
cd Iprice.ConsoleApplication
dotnet publish -r win10-x64 -c Release --self-contained

```


### Publish thru Microsoft Visual Studio

1 - Open Microsoft Visual Studio.

2 - Go to the menu and open the Solution.

3 - On the Solution Explorer, right-click on "Iprice.ConsoleApplication" project and click publish.

4 - Select publish details and click publish when ready.


using Basics;
using System.Drawing;

/*entry point for executable binaries is the main method. 
 * pulls parameters from an input source such as terminal or another file called variable "args"
 * args is an string array that can take n parameters
 * 
 * main method usually doesn't return any result except the situations where the return statement is important
 * for another program or maybe operation system.
 * 
 * if a method doesn't return anything, it is called void.
 * main methods are private by default. they can only be used in initialized class.
 * main methods are static by default. they don't require any initial object to define.
 * 
 * 
 */
Console.Beep();
Console.WriteLine("Hello World");

String fullName = "Zeynep Aladag";
/* var keyword initializes the data type as default according to the right hand side.
 * we can not define values with same names in same scope.*/

var age = 23; //int by default
short level 101;
byte redVaue = 210;
bool isOnline = true;
char flag = '0';

double pi = 3.14;
decimal productPrice = 999.45M;
float e = 2.22F;

Car McLaren = new Car(); // we can define our own personal types as class, struct, enum in addition to common type system
McLaren.Name = "Ayrton Senna";
McLaren.Year = 1990;
McLaren.Model = "MP45B";
McLaren.Color = Colors.White;

var printerAddress = new IpInfo
{
    Part1 = 192,
    Part2 = 168,
    Part3 = 1,
    Part4 = 1
};

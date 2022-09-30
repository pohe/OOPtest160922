// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using OOPtest160922;
using System.ComponentModel;

Human h1 = new Human("Jens", 75, 180);

//Console.WriteLine("Jens BMI " +   h1.BMI);
h1.PrintAllInfo();

Console.WriteLine( h1 );


//new student kalder en constructor - anvendes til at initialisere objektet
Student poul = new Student(100, "POUL HENRIKSEN", 1, "po@g.dk", "vej 123");//Objektet skabes
Console.WriteLine($"Pouls sid {poul.SId}");                                                
//Lægger værdien på højresiden ind i propertien
// og gemmer den i instance variablen
poul.Name = "POUL FREDERIK HENRIKSEN";
Console.WriteLine("NAvnet er " + poul.Name);
poul.Sno = 99;
//poul.Semester = 1;
Student anders=new Student(101, "ANDERS JENSEN", 1, "an@g.dk", "gade 1234");
Console.WriteLine($"Anders sid {anders.SId} address {anders.Address}");


Console.WriteLine($"Anders' email {anders.Email}");
anders.Email = "ab@gmail.com";

anders.Name = "ANDERS FIBIGER JENSEN";
//anders.Sno = 101;
//anders.Semester = 1;

//printe information om studenter
string aStudentName1 = poul.Name;
Console.WriteLine(aStudentName1);

//Console.WriteLine($"Info om student stundentno {poul.Sno } navn {poul.Name } semester {poul.Semester }  ");
//Console.WriteLine($"Info om student stundentno {anders.Sno} navn {anders.Name} semester {anders.Semester}  ");

poul.PrintAllStudentInfo();
anders.PrintAllStudentInfo();

Console.WriteLine(poul.NextSemester());

int kommendesemesterPoul = poul.NextSemester();


//Calculator myCalcuator = new Calculator();
//int myResult = myCalcuator.Add(10, 25);
//Console.WriteLine($"Adding 10 + 25 = {myResult}");
//int mySubResult = myCalcuator.Subtract(10, 25);
//Console.WriteLine($"Subtracting 10 - 25 = {mySubResult}");

int myResult = Calculator.Add(10, 15);
Console.WriteLine($"Adding 10 + 25 = {myResult}");
Console.WriteLine($"Subtracting 10 - 25 = {Calculator.Subtract(10,25)}");



Console.ReadLine();
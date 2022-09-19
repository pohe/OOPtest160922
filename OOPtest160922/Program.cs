// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using OOPtest160922;


//new student kalder en constructor - anvendes til at initialisere objektet
Student poul = new Student(100, "POUL HENRIKSEN", 1);//Objektet skabes 
//Lægger værdien på højresiden ind i propertien
// og gemmer den i instance variablen
//poul.Name = "POUL HENRIKSEN";
poul.Sno = 99;
//poul.Semester = 1;
Student anders=new Student(101, "ANDERS JENSEN", 1);
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
Console.ReadLine();
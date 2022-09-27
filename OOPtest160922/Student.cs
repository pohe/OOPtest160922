using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPtest160922
{
    public class Student
    {
        //Instance variabler gemmer værdier over lang tid
        //private betyder at det kun kan tilgåes inde fra klassen
        private string _name;
        private int _sno;
        private int _semester;

        private static int _counter = 0;
        private int _sId;

        public int SId
        {
            get { return _sId; }
            set { _sId = value; }
        }


        private const int tax = 25; 

        //Properties - bruger til at tilgå vores instance variabler
        public string Name
        {
            get { //Anvendes når der skal aflæses en værdi
                return _name; 
            }
            set
            { //ANvendes når der skal tildeles en værdi
                _name = value;
            }
        }

        public int Sno
        {
            get { 
                return _sno;
            }
            set {
                _sno = value; 
            }
        }

        public int Semester
        {
            get
            {
                return _semester;
            }
            set
            {
                _semester = value;
            }
        }

        //Constructor
        // en speciel metode til at initialisere et objekt
        public Student( int sno, string name, int semester  )
        {
            _counter = _counter + 1;
            _sId = _counter;
            _sno = sno;
            _name = name;
            _semester = semester;
        }

        //metoder
        public void PrintAllStudentInfo()
        {
            Console.WriteLine($"SNO {_sno}, name {_name }, går på {_semester}.semester");
        }

        public int  NextSemester() 
        {
            return Semester + 1; 
        }

        public override string ToString()
        {
            return $"SNO {_sno}, name {_name}, går på {_semester}.semester";
        }

    }
}

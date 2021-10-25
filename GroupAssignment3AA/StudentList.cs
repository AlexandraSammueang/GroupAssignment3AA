using System;

namespace GroupAssignment3
{

    class StudentList : IStudentList
    {
        const int MaxNrOfStudents = 50;
        string[] students;

        private int _NrOfStudents = 0;
        private int _NrOfGroups = 0; 
        private int _NrStudentsInGroup = 0;
        private int _NrStudentsNotInGroup = 0;
        public int NrOfStudents => _NrOfStudents;

        public int NrOfGroups 
        {
            get
            {
                return _NrOfGroups; 
            }
            set
            {
                _NrOfGroups = value; // groups of students get split and go in to value
                _NrStudentsInGroup = _NrOfStudents / _NrOfGroups; //split students / groups
                _NrStudentsNotInGroup = _NrOfStudents % _NrOfGroups; //students % groups count the "rest" the one not get in a group.
            }

        }
        public int NrStudentsInGroup
        {
            get
            {
                return _NrStudentsInGroup;
            }

        }

        public int NrStudentsNotInGroup
        {
            get
            {
                return _NrStudentsNotInGroup;
            }

        }

        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _NrOfStudents; i++)
            {
                sRet += $"{students[i],-15}";
                if ((i + 1) % 5 == 0)
                    sRet += "\n";
            }
            return sRet;
        }

        public void CreateOOP1dotNet5()
        {
            students = new string[MaxNrOfStudents];
            students[0] = "Sahar";
            students[1] = "Jennifer";
            students[2] = "Shohruh";
            students[3] = "Jonathan";
            students[4] = "Leo";
            students[5] = "Jenny";
            students[6] = "Mohamed";
            students[7] = "Ferri";
            students[8] = "Alexandra F";
            students[9] = "Vidar";
            students[10] = "Kamran";
            students[11] = "Pontus";
            students[12] = "Kaveh";
            students[13] = "Maria";
            students[14] = "Adam";
            students[15] = "Sophie";
            students[16] = "Louise";
            students[17] = "Fredric";
            students[18] = "Carl-Henrik";
            students[19] = "Frans";
            students[20] = "Sam";
            students[21] = "Alexandra S";
            students[22] = "Alperen";
            students[23] = "Josefine";
            students[24] = "Ghasem";
            students[25] = "Hanna";
            students[26] = "Finan";
            students[27] = "Niklas";
            students[28] = "Hector";
            students[29] = "Fredrik";
            students[30] = "Adrian";
            students[31] = "Teodor";

            _NrOfStudents = 30;
        }

        public void Sort() // created a sorting method behövde skapa en metod som sorterar
        {
            string temp;
            for (int a = 0; a < _NrOfStudents; a++)
            {
                for (int b = 0; b < _NrOfStudents; b++)
                {
                    if (students[a].CompareTo(students[b]) < 0) // compare to objects and swap until sorted
                    {
                        temp = students[a]; //comparing students name 
                        students[a] = students[b];
                        students[b] = temp;

                    }
                }

            }
        }
    }
}

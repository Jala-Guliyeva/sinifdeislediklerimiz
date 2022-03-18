using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    public class Student
    {
        private int Id;
        public string Name;
        public string SurName;
        private string _groupNo;

        public Student(string name,string surname,string groupNo)

        {
            Name = name;
            SurName = surname;
            _groupNo = groupNo;

        }
        
        public Student()
        {
            Id++;

        }

        public string groupNo { 
            get
            {
                return _groupNo;
            }
            set
            {
                if (value.Length>=5)
                {


                }


            
                
            }

        }




    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Interfaces;


namespace School
{
    public class Disciplines : IDiscipline , IComment
    {
        private string _name;

        private int _numberOfLectures;

        private int _numberOfExcercises;

        public int NumberOfLectures { get { return this._numberOfLectures; }  }

        public int NumberOfExcercises { get { return this._numberOfExcercises; } }

        public string Name { get { return _name; } }

        public Disciplines(string name,int lectures,int excercises)
        {
            this._name = name;
            this._numberOfLectures = lectures;
            this._numberOfExcercises = excercises;
        }

        public void Comment(string comment)
        {
            Console.WriteLine(comment);
        }
    }
}

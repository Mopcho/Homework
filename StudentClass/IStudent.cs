using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentClass.Enums;

namespace StudentClass
{
    public interface IStudent
    {
        string FirstName               {get;}
        string MiddleName              {get;}
        string LastName                {get;}
        string PermanentAddress        {get;}
        string MobilePhone             {get;}
        string Email                   {get;}
        string Course                  {get;}
        SpecialityType Speciality      {get;}
        UniversityType University      {get;}
        FacultyType Faculty            {get;}
    }
}

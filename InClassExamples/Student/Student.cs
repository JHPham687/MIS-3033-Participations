﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    public class Student
    {
        public Int64 ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set; }

        public Student()
        {
            ID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            FavoriteColor = string.Empty;
        }

        public Student(Int64 id, string first, string last, string color)
        {
            ID = id;
            FirstName = first;
            LastName = last;
            FavoriteColor = color;
        }
        
        public string CreateFullName()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}

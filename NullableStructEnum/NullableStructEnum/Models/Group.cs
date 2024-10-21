﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableStructEnum.Models
{
    internal class Group
    {
        public Student[] _students;
        public string Name { get; set; }

        public Student this[string index]
        {
            get
            {
                for (int i = 0; i < _students.Length; i++)
                {
                    if (_students[i].Fin == index)
                    {
                        return _students[i];
                    }
                }
                return null;
            }
        }

       
    }
}

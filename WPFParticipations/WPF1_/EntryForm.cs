﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPF1_
{
    class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }

        public EntryForm()
        {
            Name = string.Empty;
            Address = string.Empty;
            ZipCode = 0;
        }

        public EntryForm(string name, string address, int zipCode)
        {
            Name = name;
            Address = address;
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $"{Name}: {Address}, {ZipCode}";
        }
    }
}

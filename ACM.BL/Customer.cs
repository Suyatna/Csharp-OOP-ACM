﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int customerId { get; private set; }
        public string emailAddress { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName
        {
            get
            {
                string name = firstName;
                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        name += " ";
                    }
                    name += lastName;
                }

                return name;
            }
        }


    }
}

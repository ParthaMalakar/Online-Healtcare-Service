﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PatientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string phone { get; set; }
        public string Status { get; set; }
        public string User_Type { get; set; }
        public string password { get; set; }
        public string Email { get; set; }

    }
}

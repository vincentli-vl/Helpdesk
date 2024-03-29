﻿/*
\file:      Calls
\author:    Vincent Li
\purpose:   This is the calls class file that inherits from the entity 
*/

using System;
using System.Collections.Generic;

namespace HelpdeskDAL
{
    // inherit from help desk entity 
    public partial class Calls : HelpdeskEntity
    {
        //public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ProblemId { get; set; }
        public int TechId { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime? DateClosed { get; set; } // ? means it is optional
        public bool OpenStatus { get; set; }
        public string Notes { get; set; }
        //public byte[] Timer { get; set; }

        public virtual Employees Employee { get; set; }
        public virtual Problems Problem { get; set; }
        public virtual Employees Tech { get; set; }
    }
}

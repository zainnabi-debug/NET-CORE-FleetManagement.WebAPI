﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    public class PerformanceObjectiveAuditModel
    {
        [Dapper.Contrib.Extensions.Key]
        public  int Objectivesauditid { get; set; }
        public  int ObjectiveID { get; set; }
        public  string Columnchanged { get; set; }
        public  string Description { get; set; }
        public  string Beforevalue { get; set; }
        public  string Aftervalue { get; set; }
        public  int Createdby { get; set; }
        public  DateTime Createdon { get; set; }
    }
}

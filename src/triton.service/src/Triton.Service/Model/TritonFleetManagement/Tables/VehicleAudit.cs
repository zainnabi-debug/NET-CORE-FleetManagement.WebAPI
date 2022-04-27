﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Service.Model.TritonFleetManagement.Tables
{
    [Table("VehicleAudit")]
    public class VehicleAudit
    {
        [Key]
        public int VehicleAuditID { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string TableName { get; set; }
        [Required]
        public string PKColumnName { get; set; }
        [Required]
        public Int64 PK { get; set; }
        [Required]
        public string FieldName { get; set; }
        [Required]
        public string OldValue { get; set; }
        [Required]
        public string NewValue { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public int CreatedByUserID { get; set; }
    }
}

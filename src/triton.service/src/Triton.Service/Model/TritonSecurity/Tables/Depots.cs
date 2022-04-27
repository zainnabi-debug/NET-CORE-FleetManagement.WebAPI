﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("Depots")]
   public class Depots
    {
        [Key]
        public int DepotID { get; set; }


        public string DepotCode { get; set; }

        public string DepotName { get; set; }
        [Required]
        public string GPSCoordinates { get; set; }
        public string OrderBy { get; set; }
        public string DepotActive { get; set; }

    }
}

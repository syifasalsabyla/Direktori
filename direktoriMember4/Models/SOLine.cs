﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace direktoriMember4.Models
{
    public class SOLine
    {
        [Display(Name = "ID SOLine")]
        public int SOLineID { get; set; }

        //Lookup SOHeader
        [Display(Name = "ID SOHeader")]
        public int SOHeaderID { get; set; }
        public SOHeader SOHeader { get; set; }

        //Lookup Produk
        [Display(Name = "ID Produk")]
        public int ProdukID { get; set; }
        public Produk Produk { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Keterangan Produk")]
        public string Keterangan { get; set; }
    }
}

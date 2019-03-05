using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace direktoriMember4.Models
{
    public class Member
    {
        [Display(Name = "ID Member")]
        public int MemberID { get; set; }

        [Display(Name = "Nama Member")]
        public string NamaMember { get; set; }

        [Display(Name = "Alamat Member")]
        public string AlamatMember { get; set; }
    }
}

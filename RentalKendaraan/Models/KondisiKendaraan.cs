using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RentalKendaraan.Models
{
    public partial class KondisiKendaraan
    {
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdKondisi { get; set; }

        [MinLength(5, ErrorMessage = "Nama kondisi minimal 5 angka")]
        [MaxLength(30, ErrorMessage = "Nama kondisi maksimal 30 angka")]
        public string NamaKondisi { get; set; }
    }
}

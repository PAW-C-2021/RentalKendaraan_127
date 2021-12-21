using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RentalKendaraan.Models
{
    public partial class Jaminan
    {
        public Jaminan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public int IdJaminan { get; set; }

        [MinLength(6, ErrorMessage = "Nama Jaminan minimal 6 angka")]
        [MaxLength(40, ErrorMessage = "Nama Jaminan maksimal 40 angka")]
        public string NamaJaminan { get; set; }

        public virtual ICollection<Peminjaman> Peminjaman { get; set; }
    }
}

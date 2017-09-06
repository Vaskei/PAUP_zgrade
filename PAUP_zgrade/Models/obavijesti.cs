﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PAUP_zgrade.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema; 
 

    [Table("obavijesti")]

    public partial class obavijesti
    {
        [Display(Name = "ID obavijesti")]
        [Key]
        public int idobavijesti { get; set; }

        [Display(Name = "Tema obavijesti")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} je obavezan podatak")]
        public string temaObavijest { get; set; }

        [Display(Name = "Sadržaj obavijesti")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} je obavezan podatak")]
        [DataType(DataType.MultilineText)]
        public string tekstObavijest { get; set; }

        [Display(Name = "Datum obavijesti")]
        [Required(ErrorMessage = "Datum je obavezan podatak")]
        [DataType(DataType.Date)]
        // ako ne napisemo fiksno ovaj format Google Chrome ne�e dobro prikazati datumsko po
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy.}", ApplyFormatInEditMode = true)]
        // ako želimo zadati raspon datum
        // [Range(typeof(DateTime), "01.01.1900", "31.12.2005", ErrorMessage="{0} treba biti izme�u {1:d} i {2:d}")
        public System.DateTime datumObavijest { get; set; }
    }
}
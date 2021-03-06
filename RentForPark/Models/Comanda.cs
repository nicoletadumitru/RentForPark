﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentForPark.Models
{
    public class Comanda
    {
        [Key]
        public int IdComanda { get; set; }
        public int IdUser { get; set; }
        public int IdProdus { get; set; }
        public int Cantitate { get; set; }
        public string Adresa { get; set; }
        public double TotalPret { get; set; }
        public DateTime DataLivrare { get; set; }
        public DateTime DataReturnare { get; set; }
        public virtual User User { get; set; }
        public virtual Produs Produs { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansUygulaması.Models
{
    public enum IslemTuru
    {
        Gelir,
        Gider
    }
    public class Transaction
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public decimal Tutar { get; set; }
        public IslemTuru Tur { get; set; }
        public string Kategori { get; set; }
        public DateTime Tarih { get; set; }

        
        public Transaction()
        {
            Tarih = DateTime.Now;
        }
    }
}

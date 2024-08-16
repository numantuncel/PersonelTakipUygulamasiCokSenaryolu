using PersonelTakipUygulamsi1.EntitiesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipUygulamsi1.EntitiesLayer.Concrete
{
    public class Calisan : IBaseEntity
    {
        public int Id { get; set; }/*Id özelliği olan tüm tablolar BaseEntity i iplement ederek kullanabilir Esneklik sağlar*/
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string TcKimlik { get; set; }
        public string PersonelNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Departman { get; set; }
        public string Unvan { get; set; }
        public string Durumu { get; set; }


    }
}

using PersonelTakipUygulamsi1.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipUygulamsi1.DataAccessLayer.Abstract
{
    public interface ICalisanDal
    {
        List<Calisan> Listele(string kosulCümlesi);
        Calisan Getir(string kosulCümlesi);
        bool Kaydet(Calisan calisan);
        bool Güncelle(Calisan calisan);
        bool Sil(string kosulCümlesi);
        bool Sil(int id);
        
    }
}
/* Erişim belirteci kullanmaz*/
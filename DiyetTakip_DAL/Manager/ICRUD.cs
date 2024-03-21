using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetTakip_DAL.Manager
{
    public interface ICRUD<T> where T : class
    {
        List<T> Listele();
        T Ara(int id);
        void Ekle(T entity);
        void Sil(T entity);
        void Guncelle(T entity);
    }
}

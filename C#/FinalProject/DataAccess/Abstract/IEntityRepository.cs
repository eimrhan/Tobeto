using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

// "İş Classlarını oluştururken, önce onun Interface'ini oluştur. Bunu kural haline getir! (gerek görmesen bile)" 

namespace DataAccess.Abstract
{
    // Her entity için tek tek Dal oluşturmak yerine, ortak bir dinamik yapı oluşturabiliriz:
    // (interfaceleri yine oluşturacaksın fakat içlerini ayrı ayrı doldurman gerekmiyor, kalıtım vermen kafi.)
    public interface IEntityRepository<T> where T:class, IEntity, new() // Generic Constraint
    // :class referans tip olabilir demek (sadece class değil). Fakat her referansı istemiyoruz, bu yüzden ayrıca IEntity koşulunu da ekledik.
    // artık parametre olarak sadece IEntity veya IEntity implemente eden referans tipli nesneleri alabilir. (where T:IEntity yazsak da olur gibi)
    // IEntity almasın, sadece onu implemente eden nesneleri alsın diyorsan bir de koşul olarak new() ekleyebilirsin. (IEntity newlemez çünkü.)
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
                    // belirli bir datayı çekebilmek için
        T Get(Expression<Func<T, bool>> filter); // "filtre vermediyse tüm datayı çek"

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        // interface metodları default olarak public'dir, başına public vermene gerek yok.
    }
}
// Generic Repository Design Pattern - Generik yapı tasarım deseni
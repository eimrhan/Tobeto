using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OOP
{
    internal interface IStudentDal // Dal: Data access label
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerStudentDal : IStudentDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }
    class OracleStudentDal : IStudentDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }

    class StudentManager
    {
        public void Add(IStudentDal studentDal)
        {
            studentDal.Add();
            studentDal.Update();
            studentDal.Delete();
        }
        // burada yine interface yardımıyla esnek bir yapı oluşturmuş olduk. bağımlılıkları minimize ettik.
        // 2 çeşit veri tabanına da uygun şekilde yazılan kodlar sayesinde son aşamada hangisi istenirse o kullanılır.
    }
}

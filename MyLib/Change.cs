using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Change
    {
        public static UsersEntities _context = new UsersEntities();
        User _user = new User();

        public string ReadStatus(string info) //Проверка параметра
        {
            var inf = _context.User.Where(r => r.Status == info).FirstOrDefault();
            return inf.Status.ToString();
        }

        public string UpdateStatus(int id, string name, string password, string status) //Проверка изменения параметра
        {
            var search = _context.User.Where(r => r.ID == id).FirstOrDefault();
            search.Status = status;
            _context.SaveChanges();
            return search.Status.ToString();
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Buchies_Service
{
    public class BuchiesRepo
    {
        public List<Product> GetProducts()
        {
            using (BuchiesEntities context = new BuchiesEntities())
            {
                return context.Products.ToList();
            }
        }

        


        public List<User> GetUsers()
        {
            using (BuchiesEntities context = new BuchiesEntities())
            {
                return context.Users.ToList();
            }
        }


    }
}

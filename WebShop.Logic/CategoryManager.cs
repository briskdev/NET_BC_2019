using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebShop.Logic
{
    public class CategoryManager : BaseManager<Category>
    {
        public CategoryManager(WebShopDb db)
            :base(db)
        {
            
        }

        protected override DbSet<Category> Table
        {
            get
            {
                return _db.Categories;
            }
        }

        public void Seed()
        {
            
        }
    }
}

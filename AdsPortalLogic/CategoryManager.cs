using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AdsPortal.Logic
{
    public class CategoryManager : BaseManager<Category>
    {
        public CategoryManager(AdsPortalDb db)
            : base(db)
        {
            
        }

        protected override DbSet<Category> Table 
            => _db.Categories;

        public List<Category> GetAllWithAdCount()
        {
            var categories = Table.ToList();
            categories.ForEach(c =>
            {
                c.AdCount = _db.Ads.Count(a => a.CategoryId == c.Id);
            });

            return categories;
        }

        public void Seed()
        {
            
        }
    }
}

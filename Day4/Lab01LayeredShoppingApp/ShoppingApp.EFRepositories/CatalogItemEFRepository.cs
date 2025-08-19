using Microsoft.EntityFrameworkCore;
using ShoppingApp.Domain;
using ShoppingApp.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.EFRepositories
{
    public class CatalogItemEFRepository:EFGenericReposiotry<CatalogItem>,ICatalogItemRepository
    {
          private readonly AppDbContext _context;
        public CatalogItemEFRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<CatalogItem>> GetAll()
        {
            return await _context.CatalogItems
                    .Include(ci => ci.CatalogType)
                    .Include(ci => ci.CatalogBrand)
                    .ToListAsync();
        }



    }
}

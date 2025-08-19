using ShoppingApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.BusinessObjects
{
    public interface ICatalogItemBO
    {
        Task<CatalogItem> Add(CatalogItem item);
        Task Delete(int id);
        Task<CatalogItem> GetCatalogItemDetails(int id);
        Task<IEnumerable<CatalogItem>> GetCatalogItems();
        Task Update(CatalogItem item);
    }

}

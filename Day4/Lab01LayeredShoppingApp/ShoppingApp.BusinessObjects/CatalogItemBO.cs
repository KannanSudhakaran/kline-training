using ShoppingApp.Domain;
using ShoppingApp.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.BusinessObjects
{
    public class CatalogItemBO : ICatalogItemBO
    {
        private readonly ICatalogItemRepository _repository;
     

        public CatalogItemBO(ICatalogItemRepository catalogItemRespository)
        {
            _repository = catalogItemRespository;
        }

        public async Task<CatalogItem> Add(CatalogItem item)
        {
            await _repository.Add(item);
            //make notifications
            //send email, etc.
            //azure service bus, etc.
            return item;
        }
        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
        public async Task<CatalogItem> GetCatalogItemDetails(int id)
        {
            return await _repository.GetById(id);
        }
        public async Task<IEnumerable<CatalogItem>> GetCatalogItems()
        {
            return await _repository.GetAll();
            
        }
        public async Task Update(CatalogItem item)
        {
            await _repository.Update(item);
        }

    }

}

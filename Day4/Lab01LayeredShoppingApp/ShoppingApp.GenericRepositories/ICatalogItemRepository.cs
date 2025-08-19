using ShoppingApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.GenericRepositories
{
    public interface ICatalogItemRepository:IGenericRepository<CatalogItem>
    {
        //additional methods specific to CatalogItem can be added here if needed
    }
    public interface ICatalogBrandRepository : IGenericRepository<CatalogBrand>
    {

    }
    public interface ICatalogTypeRepository : IGenericRepository<CatalogType>
    {

    }
}

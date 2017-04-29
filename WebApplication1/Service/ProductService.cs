using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
namespace Service
{
    public interface IProductService
    {

    }
   public  class ProductService: IProductService
    {
        private IProductRepository _repodito;
        public ProductService(IProductRepository repositore)
        {
            _repodito = repositore;
        }
       
    }
}

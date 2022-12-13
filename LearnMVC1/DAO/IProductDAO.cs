using LearnMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO
{
    interface IProductDAO
    {
        List<ProductModel> findAll();
        List<ProductModel> loadInitNine(String orderBy);
        List<ProductModel> loadNextNine(String orderBy, int skipAmount);
        ProductModel find(int productId);
        List<ProductModel> findByCategory(int categoryId);
        List<ProductModel> findBySearch(String searchPhrase);

        void insertProduct(ProductModel product);
        void deleteProduct(int productId);
        void editProduct(ProductModel product);

        List<ProductModel> findAllBySellerId(int sellerId);
        int findProductId(ProductModel product);
    }
}

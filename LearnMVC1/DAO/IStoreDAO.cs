using LearnMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO
{
    interface IStoreDAO
    {
		List<StoreModel> findAll();
		List<ProductModel> findAllProduct(int storeId);
		StoreModel findStore(int storeId);
		List<StoreModel> findBySearch(string searchPhrase);
		void insertStore(string storeName, DateTime storeCreateDate);
		int findStoreId(string storeName);
	}
}

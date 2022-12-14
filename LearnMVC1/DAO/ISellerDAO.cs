using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO
{
    interface ISellerDAO
    {
        void insertSeller(string sellerName, int storeId);
        int findSellerId(string sellerName);
        int findStoreId(int sellerId);
    }
}

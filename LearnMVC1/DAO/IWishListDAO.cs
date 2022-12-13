using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO
{
    interface IWishListDAO
    {
        void insertToWishList(int productId, int accountId);
        void deleteFromWishList(int productId, int accountId);
        bool isInWishList(int productId, int accountId);
        List<int> findAllProductId(int accountId);
    }
}

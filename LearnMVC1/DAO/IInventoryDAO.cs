using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO
{
    interface IInventoryDAO
    {
        void insertInventory(int productId, int storeId, int amount);
        void deleteInventory(int productId, int storeId);
        //vì 1 productId chỉ ứng với 1 store nên ko cần thêm storeId
        void updateInventory(int productId, int amount);
        int findAmount(int productId);
    }
}

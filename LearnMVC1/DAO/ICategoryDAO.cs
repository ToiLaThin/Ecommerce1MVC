using LearnMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO
{
    interface ICategoryDAO
    {
        List<CategoryModel> findAll();
        CategoryModel find(int categoryId);
        void insertCategory(CategoryModel category);
        void deleteCategory(int categoryId);
        void editCategory(CategoryModel category);
    }
}

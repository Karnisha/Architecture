using LXP.Common.Entities;
using LXP.Common.ViewModels;
using LXP.Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LXP.Data.Repository;
using LXP.Data.IRepository;
namespace LXP.Core.Services
{
    public class CategoryServices:ICategoryServices
    {
        
        private readonly CategoryCreation categoryCreation;
        public CategoryServices(CategoryCreation categoryCreation) { 
            
            this.categoryCreation = categoryCreation;
        }
        public bool AddCategory(CourseCategoryViewModel categoryViewModel)
        {
            Coursecategory coursecategory = new Coursecategory()
            {
                CatagoryId = Guid.NewGuid(),
                Category = categoryViewModel.Category,
                CreatedAt = new DateTime(),
                CreatedBy= "Admin",
                ModifiedAt= new DateTime(),
                ModifiedBy= "Admin"
            };
            
            return categoryCreation.AddCategory(coursecategory);
        }
    }
}

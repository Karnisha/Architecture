using LXP.Common.ViewModels;
using LXP.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace LXP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryServices categoryServices;
        public CategoryController(CategoryServices categoryServices)
        { 
            this.categoryServices = categoryServices;
        }
        [HttpPost]
        public IActionResult CreateCategory(CourseCategoryViewModel courseCategoryViewModel)
        {
            try
            {
                if (categoryServices.AddCategory(courseCategoryViewModel))
                {
                    return Ok();

                }
                else
                {
                    return BadRequest();
                }


            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}

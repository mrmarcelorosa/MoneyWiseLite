using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Interfaces;

namespace MoneyWiseLite.API.Controllers;

[Microsoft.AspNetCore.Components.Route("api/[controller]")]
public class CategoryController(ICategoryService categoryService) : GenericController<Category>(categoryService)
{
    [HttpGet("user/{userId}")]
    public async Task<IActionResult> GetCategoriesByUserId(int userId)
    {
        var categories = await categoryService.GetCategoriesByUserIdAsync(userId);
        return Ok(categories);
    }

}

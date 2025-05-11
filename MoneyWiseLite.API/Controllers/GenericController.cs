using Microsoft.AspNetCore.Mvc;
using MoneyWiseLite.Domain.Entities;
using MoneyWiseLite.Domain.Interfaces;

namespace MoneyWiseLite.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class GenericController<T> : ControllerBase where T : BaseEntity
{
    private readonly IService<T> _service;

    protected GenericController(IService<T> service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<T>>> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<T>> GetById(int id)
    {
        var entity = await _service.GetByIdAsync(id);
        if (entity == null) return NotFound();
        return Ok(entity);
    }

    [HttpPost]
    public async Task<ActionResult<T>> Create(T entity)
    {
        var created = await _service.CreateAsync(entity);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, T entity)
    {
        if (id != entity.Id) return BadRequest("ID mismatch");
        await _service.UpdateAsync(entity);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return NoContent();
    }

    [HttpGet("deleted")]
    public async Task<ActionResult<IEnumerable<T>>> GetDeleted()
    {
        var deletedEntities = await _service.GetDeletedAsync();
        return Ok(deletedEntities);
    }

    [HttpGet("paged")]
    public async Task<ActionResult<IEnumerable<T>>> GetAllPaged(int pageNumber, int pageSize)
    {
        var pagedEntities = await _service.GetAllPagedAsync(pageNumber, pageSize);
        return Ok(pagedEntities);
    }

    [HttpGet("deleted/paged")]
    public async Task<ActionResult<IEnumerable<T>>> GetDeletedPaged(int pageNumber, int pageSize)
    {
        var pagedDeletedEntities = await _service.GetDeletedPagedAsync(pageNumber, pageSize);
        return Ok(pagedDeletedEntities);
    }

}
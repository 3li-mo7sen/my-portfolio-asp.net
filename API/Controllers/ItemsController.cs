using Core.Entities;
using Core.Interfaces;
using Infrastructure.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController(IPortfolioRepository portfolioRepository) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<PortfolioItem>>> GetAllItems()
        { 
            var items = await portfolioRepository.GetAllAsync();
            return Ok(items);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<PortfolioItem>> GetAllItems(int id)
        {
            var item = await portfolioRepository.GetByIdAsync(id);
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<PortfolioItem>> PostItem(PortfolioItem Item)
        {
            portfolioRepository.AddItem(Item);
            if(await portfolioRepository.SaveAllChangesAsync())
            {
                return CreatedAtAction("GetItem", new { id = Item.Id }, Item);
            }
            return BadRequest("Faild");
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult<PortfolioItem>> PutItem(int id, PortfolioItem Item)
        {
            portfolioRepository.UpdateItem(Item);
            if (await portfolioRepository.SaveAllChangesAsync())
            {
                return CreatedAtAction("GetItem", new { id = Item.Id }, Item);
            }
            return BadRequest("Faild");
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<PortfolioItem>> DeleteItem(int id)
        {
            var item = await portfolioRepository.GetByIdAsync(id);
            if(item == null) return NotFound("Item Not Found");
            portfolioRepository.DeleteItem(item);
            if (await portfolioRepository.SaveAllChangesAsync())
            {
                return Ok("Deleted ");
            }
            return BadRequest("Faild");
        }
    }
}

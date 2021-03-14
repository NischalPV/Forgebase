using System;
using System.Threading.Tasks;
using Forgebase.Masterdata.Core.Entities.Material;
using Forgebase.Masterdata.Core.Interfaces.Material;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Forgebase.Masterdata.Areas.Masterdata.Controllers
{
    [Area("Masterdata")]
    [Route("api/v1/[area]/[controller]")]
    [ApiController]
    [Authorize]
    public class ColorCodesController : ControllerBase
    {
        private readonly IColorCodeRepository _colorCodeRepository;
        private readonly ILogger<ColorCodesController> _logger;

        public ColorCodesController(IColorCodeRepository colorCodeRepository, ILogger<ColorCodesController> logger)
        {
            _colorCodeRepository = colorCodeRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetColorCodes()
        {
            return Ok(await _colorCodeRepository.ListAllAsync());
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetColorCode(int Id)
        {
            return Ok(await _colorCodeRepository.GetByIdAsync(id: Id));
        }

        [HttpPost]
        public async Task<IActionResult> PostColorCode(ColorCode colorCode)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _colorCodeRepository.AddAsync(colorCode);
                    return CreatedAtAction(nameof(GetColorCode), new { Id = colorCode.Id }, colorCode);

                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw;
                }

            }

            return BadRequest(ModelState);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> PutColorCode(int Id, ColorCode colorCode)
        {
            if (Id != colorCode.Id)
            {
                return BadRequest();
            }


            try
            {
                var updatedColorCode = new ColorCode(id: Id, code: colorCode.Code, createdDate: colorCode.CreatedDate, isActive: colorCode.IsActive, createdBy: colorCode.CreatedBy);
                await _colorCodeRepository.UpdateAsync(updatedColorCode);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await (ColorCodeExists(colorCode)))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Farms1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColorCode(int id)
        {
            var farm = await _colorCodeRepository.GetByIdAsync(id);
            if (farm == null)
            {
                return NotFound();
            }

            await _colorCodeRepository.DeleteAsync(farm);

            return NoContent();
        }

        private async Task<bool> ColorCodeExists(ColorCode colorCode)
        {
            return await _colorCodeRepository.IsExists(colorCode, x => x.IsActive);
        }
    }
}

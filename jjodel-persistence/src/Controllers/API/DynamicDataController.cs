using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace jjodel_persistence.Controllers.API {
    [Route("api/[controller]")]
    [ApiController]
    public class DynamicDataController : ControllerBase {

        private readonly ILogger<DynamicDataController> _logger;

        public DynamicDataController(
            ILogger<DynamicDataController> logger
            ) {
            this._logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            try {
                _logger.LogInformation("GetAll called");
                return Ok(new { message = "GetAll endpoint" });
            }
            catch (Exception ex) {
                _logger.LogError(ex, "Error in GetAll");
                return StatusCode(500, new { error = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) {
            try {
                _logger.LogInformation($"GetById called with id: {id}");
                return Ok(new { message = $"GetById endpoint for id: {id}" });
            }
            catch (Exception ex) {
                _logger.LogError(ex, "Error in GetById");
                return StatusCode(500, new { error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] object data) {
            try {
                _logger.LogInformation("Create called");
                return CreatedAtAction(nameof(GetById), new { id = 1 }, new { message = "Create endpoint" });
            }
            catch (Exception ex) {
                _logger.LogError(ex, "Error in Create");
                return StatusCode(500, new { error = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] object data) {
            try {
                _logger.LogInformation($"Update called with id: {id}");
                return Ok(new { message = $"Update endpoint for id: {id}" });
            }
            catch (Exception ex) {
                _logger.LogError(ex, "Error in Update");
                return StatusCode(500, new { error = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) {
            try {
                _logger.LogInformation($"Delete called with id: {id}");
                return Ok(new { message = $"Delete endpoint for id: {id}" });
            }
            catch (Exception ex) {
                _logger.LogError(ex, "Error in Delete");
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}

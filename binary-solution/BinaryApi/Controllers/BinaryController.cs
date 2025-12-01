using Microsoft.AspNetCore.Mvc;
using BinaryCore;

[ApiController]
[Route("convert")]
public class BinaryController : ControllerBase
{
    [HttpGet("binary-to-decimal")]
    public IActionResult BinaryToDecimal([FromQuery] string value)
    {
        try
        {
            var bits = BinaryParser.Parse(value);
            int result = BinaryConverter.BinaryToDecimal(bits);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
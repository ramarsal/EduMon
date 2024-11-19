using Microsoft.AspNetCore.Mvc;
using EduMon.Data;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    private readonly AppDbContext _context;

    public TestController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult TestDatabaseConnection()
    {
        try
        {
            var users = _context.Users.ToList();
            return Ok(users); // Returns the list of users
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Database connection failed: {ex.Message}");
        }
    }
}

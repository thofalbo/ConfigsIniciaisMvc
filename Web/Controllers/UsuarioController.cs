namespace Web.Controllers;

public class UsuarioController : Controller
{
    private readonly ApplicationDbContext _dbContext;
    public UsuarioController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IActionResult Index()
    {
        var ususarios = _dbContext.Usuarios.ToList();
        return View(ususarios);
    }
}

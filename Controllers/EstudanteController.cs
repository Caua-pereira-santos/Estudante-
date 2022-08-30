using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;
namespace MvcRazorViews.Controllers;


public class EstudanteController : Controller
{

   private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>{
       new EstudanteViewModel(1, "Madonna Ciccone", "Rua X , 1", true),
       new EstudanteViewModel(2, "Lady Gaga", "Rua L , 2", true),
       new EstudanteViewModel(3, "Alicia Keys", "Rua A , 3", false),
       new EstudanteViewModel(4, "Queen B", "Rua B , 4", true),
       new EstudanteViewModel(5, "Med", "Rua M, 5", false)
    };

public IActionResult Index()
{
    return View(estudantes);
}

public IActionResult Show(int id)
{
    return View(estudantes[id - 1]);
}

}
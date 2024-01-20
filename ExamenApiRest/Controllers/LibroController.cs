using ExamenApiRest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamenApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private static List<Libro> _libro = new List<Libro>
        {
            new Libro
            {
                Id = 1,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                
            },
            new Libro
            {
                Id = 2,
                Title = "Cien años de soledad",
                Author = "Gabriel García Márquez",
                
            },
            new Libro
            {
                Id = 3,
                Title = "1984",
                Author = "Geoge Orwell",
              
            }
        };

        [HttpGet]
        public IEnumerable<Libro> GetAllBooks()
        {
            return _libro;
        }
    }
}

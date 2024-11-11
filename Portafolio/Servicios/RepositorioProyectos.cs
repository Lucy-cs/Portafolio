using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }

    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>() {
                new ProyectoDTO
            {
             Titulo = "Tconsulting",
             Descripcion = "Sistema de gestión de nóminas en ASP.NET core",
             Link = "https://github.com/Lucy-cs/TConsultingFinal",
             ImagenURL="/imagenes/Tconsulting.png"
            },

                new ProyectoDTO
            {
             Titulo = "New York Times",
             Descripcion = "Página de noticias en React",
             Link = "https://nytimes.com",
             ImagenURL="/imagenes/nyt.png"
            },

                new ProyectoDTO
            {
             Titulo = "Página Web Sobre Ganado Bovino",
             Descripcion = "Página web estática con información relacionada al ganado bovino y equipos agrícolas.",
             Link = "https://lucy-cs.github.io/parcial2/index.html",
             ImagenURL="/imagenes/paginaWebVacasFelices.png"
            },

                new ProyectoDTO
            {
             Titulo = "Steam",
             Descripcion = "Tienda en línea para comprar video juegos",
             Link = "https://store.steampowered.com",
             ImagenURL="/imagenes/steam.png"
            },


            };
        }

    }
}

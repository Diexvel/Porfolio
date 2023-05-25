using Potafolio.Models;

namespace Potafolio.Servicios
{
	public interface IRepositorioProyectos
	{
		List<ProyectoViewModel> ObtenerProyectos();
	}

	public class RepositorioProyectos : IRepositorioProyectos
	{
		public List<ProyectoViewModel> ObtenerProyectos()
		{
			return new List<ProyectoViewModel>() {

				new ProyectoViewModel
			{
				Titulo = "Amazon",
				Descripcion = "E-Commerse realizado en ASP.NET Core",
				Link = "https://amazon.com",
				ImagenURL ="/imagenes/amazon.png"
			},

				new ProyectoViewModel
			{
				Titulo = "Reddit",
				Descripcion = "Red social para compartir",
				Link = "https://reddit.com",
				ImagenURL ="/imagenes/reddit.png"
			},

				new ProyectoViewModel
			{
				Titulo = "Steam",
				Descripcion = "Tienda en linea de Video Juegos",
				Link = "https://store.steampowered.com",
				ImagenURL ="/imagenes/steam.png"
			},

				new ProyectoViewModel
			{
				Titulo = "New York Time",
				Descripcion = "Página de noticias",
				Link = "https://nytimes.com",
				ImagenURL ="/imagenes/nyt.png"
			}

			};
		}
	}
}

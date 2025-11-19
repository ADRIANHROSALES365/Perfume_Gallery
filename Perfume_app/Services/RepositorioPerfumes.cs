using Perfume_app.Models;

namespace Perfume_app.Services
{
    public class RepositorioPerfumes
    {
        public List<PerfumeDto> ObtenerPerfumes()
        {
            return new List<PerfumeDto>
            {
                new PerfumeDto
                {
                    Nombre = "Euphoria",
                    Marca = "Calvin Klein",
                    Descripcion = "Una fragancia oriental floral que evoca misterio y sensualidad.",
                    Tipo_clima = "Frío",
                    edad_recomendada = 25,
                    Genero = "Femenino"

                },
                new PerfumeDto
                {
                    Nombre = "Light Blue",
                    Marca = "Dolce & Gabbana",
                    Descripcion = "Una fragancia fresca y afrutada perfecta para el verano.",
                    Tipo_clima = "Frío",
                    edad_recomendada = 25,
                    Genero = "Femenino"
                },
            };
        }
    }
}

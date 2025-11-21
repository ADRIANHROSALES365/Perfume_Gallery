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
                    edad_recomendada = "Joven",
                    Genero = "Femenino",
                    ImagenUrl= "https://example.com/euphoria.jpg"

                },
                new PerfumeDto
                {
                    Nombre = "Light Blue",
                    Marca = "Dolce & Gabbana",
                    Descripcion = "Una fragancia fresca y afrutada perfecta para el verano.",
                    Tipo_clima = "Frío",
                    edad_recomendada = "Joven",
                    Genero = "Femenino",
                    ImagenUrl= "https://example.com/euphoria.jpg"
                },
                new PerfumeDto
                {
                    Nombre = "Acqua di Gio",
                    Marca = "Giorgio Armani",
                    Descripcion = "Una fragancia acuática y fresca ideal para el clima cálido.",
                    Tipo_clima = "Cálido",
                    edad_recomendada = "Adulto",
                    Genero = "Masculino",
                    ImagenUrl= "https://example.com/euphoria.jpg"
                },
                new PerfumeDto
                {
                    Nombre = "Dior Sauvage",
                    Marca = "Christian Dior",
                    Descripcion = "Una fragancia intensa y amaderada que destaca en cualquier ocasión.",
                    Tipo_clima = "Cálido",
                    edad_recomendada = "Adulto Joven",
                    Genero = "Masculino",
                    ImagenUrl= "https://example.com/euphoria.jpg"
                },
                new PerfumeDto
                {
                    Nombre = "Chanel No. 5",
                    Marca = "Chanel",
                    Descripcion = "Un clásico atemporal con notas florales y aldehídicas.",
                    Tipo_clima = "Frío",
                    edad_recomendada = "Adulto",
                    Genero = "Femenino",
                    ImagenUrl= "https://example.com/euphoria.jpg"
                },
                new PerfumeDto
                {
                    Nombre = "Tom Ford Black Orchid",
                    Marca = "Tom Ford",
                    Descripcion = "Una fragancia lujosa y seductora con notas oscuras y ricas.",
                    Tipo_clima = "Frío",
                    edad_recomendada = "Adulto",
                    Genero = "Unisex",
                    ImagenUrl= "https://example.com/euphoria.jpg"
                }
            };
        }
    }
}

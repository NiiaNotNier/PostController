using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSanudo.Api.Blog.Models
{
    public class DbContext
    {
        public static List<Post> ListaPosts { get; set; }

        public static void Initiaload()
        {
            ListaPosts = new List<Post>();

            ListaPosts.Add(new Post { Id = 1, Title = "Yo, marmota", Body = "Es un animal que duerme mucho, como yo, si duerme menos, entonces no es una marmota, hay un límite marcado por Dios, si duerme más, es una marmota o un Javi" });
            ListaPosts.Add(new Post { Id = 2, Title = "Una croqueta", Body = "Crujiente, sabrosa, doradita por fuera y de colores por dentro, según el contenido. Si preguntan, las de mi mamá son las mejores" });
            ListaPosts.Add(new Post { Id = 3, Title = "La guerra", Body = "Puedes escuchar sonidos como ratatata, pium pium, bang bang, boooom, médicooooo, una MG42 en la segunda planta" });
            ListaPosts.Add(new Post { Id = 4, Title = "Vueling", Body = "Es una cosa que tiene aviones y puedes ir a sitios, pero con alas claro, que no son coches, como vas a volar con un coche, que bruto eres" });
        }
    }
}
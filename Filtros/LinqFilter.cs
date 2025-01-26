using ScreenSoundAPI.Modelos;

namespace ScreenSoundAPI.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

            foreach (var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

    }
}

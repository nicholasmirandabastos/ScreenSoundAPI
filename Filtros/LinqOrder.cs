using ScreenSoundAPI.Modelos;

namespace ScreenSoundAPI.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListadeArtistasOrdenados(List<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();

            Console.WriteLine("Lista de artistas ordenados");

            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine($"- {artista}");
            }
        }

    }
}

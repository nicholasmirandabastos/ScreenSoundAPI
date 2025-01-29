using ScreenSoundAPI.Modelos;
using System.Text.Json;
using ScreenSoundAPI.Filtros;

using (HttpClient cliente = new HttpClient())
{
    try
    {
        string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListadeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");

        var musicasPreferidas = new MusicasPreferidas("Nich");

        musicasPreferidas.AdicionarMusicasPreferidas(musicas[1]);
        musicasPreferidas.AdicionarMusicasPreferidas(musicas[377]);
        musicasPreferidas.AdicionarMusicasPreferidas(musicas[4]);
        musicasPreferidas.AdicionarMusicasPreferidas(musicas[6]);
        musicasPreferidas.AdicionarMusicasPreferidas(musicas[1467]);

        musicasPreferidas.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }



}
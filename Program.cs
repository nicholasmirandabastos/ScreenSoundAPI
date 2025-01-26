using ScreenSoundAPI.Modelos;
using System.Text.Json;

using (HttpClient cliente = new HttpClient())
{
    try
    {
        string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[1998].ExibirDetalhesDaMusica();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }



}
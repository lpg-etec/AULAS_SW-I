using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando algumas músicas
            Musica musica1 = new Musica("Bohemian Rhapsody", "Queen", "EMI");
            Musica musica2 = new Musica("Imagine", "John Lennon", "Capitol Records");
            Musica musica3 = new Musica("Hotel California", "Eagles", "Asylum Records");

            // Criando uma playlist e adicionando músicas
            Playlist minhaPlaylist = new Playlist("João");
            minhaPlaylist.AdicionarMusica(musica1);
            minhaPlaylist.AdicionarMusica(musica2);
            minhaPlaylist.AdicionarMusica(musica3);

            // Tocando uma música aleatória
            Console.WriteLine($"\nTocando uma música aleatória da playlist de {minhaPlaylist.Dono}:");
            minhaPlaylist.TocarMusicaAleatoria();
        }
    }
}

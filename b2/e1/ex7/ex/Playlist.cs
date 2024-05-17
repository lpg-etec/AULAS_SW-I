namespace ex
{
    class Playlist
    {
        private List<Musica> musicas;
        public string Dono { get; set; }

        public Playlist(string dono)
        {
            Dono = dono;
            musicas = new List<Musica>();
        }

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
            Console.WriteLine($"Música '{musica.Nome}' adicionada à playlist de {Dono}.");
        }

        public void TocarMusicaAleatoria()
        {
            if (musicas.Count == 0)
            {
                Console.WriteLine("Playlist vazia. Adicione músicas antes de tocar.");
                return;
            }

            Random random = new Random();
            int indiceAleatorio = random.Next(0, musicas.Count);
            Musica musicaAleatoria = musicas[indiceAleatorio];
            Console.WriteLine($"Tocando música: '{musicaAleatoria.Nome}'");
        }
    }
}

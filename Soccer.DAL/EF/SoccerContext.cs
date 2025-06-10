using Microsoft.EntityFrameworkCore;
using Soccer.DAL.Entities;

namespace Soccer.DAL.EF
{   
    public class SoccerContext : DbContext
    { 
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        public SoccerContext(DbContextOptions<SoccerContext> options)
                   : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "Liverpool", Coach = "Arne Slot" },
                new Team { Id = 2, Name = "Dynamo Kyiv", Coach = "Oleksandr Shovkovskyi" },
                new Team { Id = 3, Name = "Barcelona", Coach = "Hansi Flick" },
                new Team { Id = 4, Name = "Bayern Munich", Coach = "Vincent Kompany" },
                new Team { Id = 5, Name = "Paris Saint-Germain", Coach = "Luis Enrique" },
                new Team { Id = 6, Name = "Manchester City", Coach = "Pep Guardiola" },
                new Team { Id = 7, Name = "Everton", Coach = "Sean Dyche" }, // всё ещё он
                new Team { Id = 8, Name = "Real Madrid", Coach = "Carlo Ancelotti" },
                new Team { Id = 9, Name = "Napoli", Coach = "Francesco Calzona" }
            );

            modelBuilder.Entity<Player>().HasData(
                // Liverpool – TeamId = 1
                new Player { Id = 1, Name = "Mohamed Salah", Age = 31, Position = "Forward", TeamId = 1 },
                new Player { Id = 2, Name = "Alisson Becker", Age = 31, Position = "Goalkeeper", TeamId = 1 },
                new Player { Id = 3, Name = "Virgil van Dijk", Age = 32, Position = "Defender", TeamId = 1 },
                new Player { Id = 4, Name = "Trent Alexander-Arnold", Age = 25, Position = "Defender", TeamId = 1 },
                new Player { Id = 5, Name = "Andrew Robertson", Age = 29, Position = "Defender", TeamId = 1 },
                new Player { Id = 6, Name = "Alexis Mac Allister", Age = 25, Position = "Midfielder", TeamId = 1 },
                new Player { Id = 7, Name = "Curtis Jones", Age = 23, Position = "Midfielder", TeamId = 1 },
                new Player { Id = 8, Name = "Darwin Núñez", Age = 25, Position = "Forward", TeamId = 1 },
                new Player { Id = 9, Name = "Luis Díaz", Age = 27, Position = "Forward", TeamId = 1 },
                new Player { Id = 10, Name = "Ibrahima Konaté", Age = 25, Position = "Defender", TeamId = 1 },
                new Player { Id = 11, Name = "Dominik Szoboszlai", Age = 23, Position = "Midfielder", TeamId = 1 },

                // Dynamo Kyiv – TeamId = 2
                new Player { Id = 12, Name = "Heorhiy Bushchan", Age = 30, Position = "Goalkeeper", TeamId = 2 },
                new Player { Id = 13, Name = "Oleksandr Karavayev", Age = 31, Position = "Defender", TeamId = 2 },
                new Player { Id = 14, Name = "Vitalii Mykolenko", Age = 24, Position = "Defender", TeamId = 2 },
                new Player { Id = 15, Name = "Sydorchuk Serhiy", Age = 33, Position = "Midfielder", TeamId = 2 },
                new Player { Id = 16, Name = "Volodymyr Brazhko", Age = 21, Position = "Midfielder", TeamId = 2 },
                new Player { Id = 17, Name = "Vladyslav Vanat", Age = 22, Position = "Forward", TeamId = 2 },
                new Player { Id = 18, Name = "Oleksandr Tymchyk", Age = 27, Position = "Defender", TeamId = 2 },
                new Player { Id = 19, Name = "Illia Zabarnyi", Age = 21, Position = "Defender", TeamId = 2 },
                new Player { Id = 20, Name = "Vitaliy Buyalskyi", Age = 30, Position = "Midfielder", TeamId = 2 },
                new Player { Id = 21, Name = "Andriy Yarmolenko", Age = 34, Position = "Forward", TeamId = 2 },
                new Player { Id = 22, Name = "Mykola Shaparenko", Age = 25, Position = "Midfielder", TeamId = 2 },

                // Barcelona – TeamId = 3
                new Player { Id = 23, Name = "Marc-André ter Stegen", Age = 32, Position = "Goalkeeper", TeamId = 3 },
                new Player { Id = 24, Name = "Ronald Araújo", Age = 25, Position = "Defender", TeamId = 3 },
                new Player { Id = 25, Name = "João Cancelo", Age = 30, Position = "Defender", TeamId = 3 },
                new Player { Id = 26, Name = "Jules Koundé", Age = 26, Position = "Defender", TeamId = 3 },
                new Player { Id = 27, Name = "Pedri", Age = 22, Position = "Midfielder", TeamId = 3 },
                new Player { Id = 28, Name = "Gavi", Age = 20, Position = "Midfielder", TeamId = 3 },
                new Player { Id = 29, Name = "Frenkie de Jong", Age = 27, Position = "Midfielder", TeamId = 3 },
                new Player { Id = 30, Name = "Robert Lewandowski", Age = 36, Position = "Forward", TeamId = 3 },
                new Player { Id = 31, Name = "Lamine Yamal", Age = 17, Position = "Forward", TeamId = 3 },
                new Player { Id = 32, Name = "Ferran Torres", Age = 24, Position = "Forward", TeamId = 3 },
                new Player { Id = 33, Name = "Oriol Romeu", Age = 32, Position = "Midfielder", TeamId = 3 },

                // Bayern Munich – TeamId = 4
                new Player { Id = 34, Name = "Manuel Neuer", Age = 38, Position = "Goalkeeper", TeamId = 4 },
                new Player { Id = 35, Name = "Benjamin Pavard", Age = 28, Position = "Defender", TeamId = 4 },
                new Player { Id = 36, Name = "Matthijs de Ligt", Age = 25, Position = "Defender", TeamId = 4 },
                new Player { Id = 37, Name = "Alphonso Davies", Age = 24, Position = "Defender", TeamId = 4 },
                new Player { Id = 38, Name = "Joshua Kimmich", Age = 30, Position = "Midfielder", TeamId = 4 },
                new Player { Id = 39, Name = "Leon Goretzka", Age = 29, Position = "Midfielder", TeamId = 4 },
                new Player { Id = 40, Name = "Jamal Musiala", Age = 22, Position = "Midfielder", TeamId = 4 },
                new Player { Id = 41, Name = "Thomas Müller", Age = 35, Position = "Forward", TeamId = 4 },
                new Player { Id = 42, Name = "Harry Kane", Age = 31, Position = "Forward", TeamId = 4 },
                new Player { Id = 43, Name = "Leroy Sané", Age = 29, Position = "Forward", TeamId = 4 },
                new Player { Id = 44, Name = "Dayot Upamecano", Age = 26, Position = "Defender", TeamId = 4 },

                // PSG – TeamId = 5
                new Player { Id = 45, Name = "Gianluigi Donnarumma", Age = 26, Position = "Goalkeeper", TeamId = 5 },
                new Player { Id = 46, Name = "Achraf Hakimi", Age = 26, Position = "Defender", TeamId = 5 },
                new Player { Id = 47, Name = "Milan Škriniar", Age = 29, Position = "Defender", TeamId = 5 },
                new Player { Id = 48, Name = "Lucas Hernández", Age = 29, Position = "Defender", TeamId = 5 },
                new Player { Id = 49, Name = "Vitinha", Age = 25, Position = "Midfielder", TeamId = 5 },
                new Player { Id = 50, Name = "Fabián Ruiz", Age = 28, Position = "Midfielder", TeamId = 5 },
                new Player { Id = 51, Name = "Ousmane Dembélé", Age = 26, Position = "Forward", TeamId = 5 },
                new Player { Id = 52, Name = "Kylian Mbappé", Age = 25, Position = "Forward", TeamId = 5 },
                new Player { Id = 53, Name = "Randal Kolo Muani", Age = 25, Position = "Forward", TeamId = 5 },
                new Player { Id = 54, Name = "Neymar", Age = 32, Position = "Forward", TeamId = 5 },
                new Player { Id = 55, Name = "Bradley Barcola", Age = 22, Position = "Forward", TeamId = 5 },

                // Man City – TeamId = 6
                new Player { Id = 56, Name = "Ederson", Age = 31, Position = "Goalkeeper", TeamId = 6 },
                new Player { Id = 57, Name = "Rúben Dias", Age = 27, Position = "Defender", TeamId = 6 },
                new Player { Id = 58, Name = "Kyle Walker", Age = 34, Position = "Defender", TeamId = 6 },
                new Player { Id = 59, Name = "Nathan Aké", Age = 30, Position = "Defender", TeamId = 6 },
                new Player { Id = 60, Name = "Rodri", Age = 29, Position = "Midfielder", TeamId = 6 },
                new Player { Id = 61, Name = "Bernardo Silva", Age = 30, Position = "Midfielder", TeamId = 6 },
                new Player { Id = 62, Name = "Kevin De Bruyne", Age = 33, Position = "Midfielder", TeamId = 6 },
                new Player { Id = 63, Name = "Phil Foden", Age = 24, Position = "Forward", TeamId = 6 },
                new Player { Id = 64, Name = "Erling Haaland", Age = 25, Position = "Forward", TeamId = 6 },
                new Player { Id = 65, Name = "Jack Grealish", Age = 29, Position = "Forward", TeamId = 6 },
                new Player { Id = 66, Name = "Julián Álvarez", Age = 25, Position = "Forward", TeamId = 6 },

                // Everton – TeamId = 7
                new Player { Id = 67, Name = "Jordan Pickford", Age = 31, Position = "Goalkeeper", TeamId = 7 },
                new Player { Id = 68, Name = "James Tarkowski", Age = 32, Position = "Defender", TeamId = 7 },
                new Player { Id = 69, Name = "Ben Godfrey", Age = 27, Position = "Defender", TeamId = 7 },
                new Player { Id = 70, Name = "Vitalii Mykolenko", Age = 25, Position = "Defender", TeamId = 7 },
                new Player { Id = 71, Name = "Idrissa Gueye", Age = 34, Position = "Midfielder", TeamId = 7 },
                new Player { Id = 72, Name = "Abdoulaye Doucouré", Age = 31, Position = "Midfielder", TeamId = 7 },
                new Player { Id = 73, Name = "Amadou Onana", Age = 23, Position = "Midfielder", TeamId = 7 },
                new Player { Id = 74, Name = "Dwight McNeil", Age = 26, Position = "Forward", TeamId = 7 },
                new Player { Id = 75, Name = "Dominic Calvert-Lewin", Age = 28, Position = "Forward", TeamId = 7 },
                new Player { Id = 76, Name = "Arnaut Danjuma", Age = 28, Position = "Forward", TeamId = 7 },
                new Player { Id = 77, Name = "Beto", Age = 27, Position = "Forward", TeamId = 7 },

                // Real Madrid – TeamId = 8
                new Player { Id = 78, Name = "Thibaut Courtois", Age = 33, Position = "Goalkeeper", TeamId = 8 },
                new Player { Id = 79, Name = "Antonio Rüdiger", Age = 32, Position = "Defender", TeamId = 8 },
                new Player { Id = 80, Name = "Éder Militão", Age = 27, Position = "Defender", TeamId = 8 },
                new Player { Id = 81, Name = "David Alaba", Age = 32, Position = "Defender", TeamId = 8 },
                new Player { Id = 82, Name = "Aurélien Tchouaméni", Age = 25, Position = "Midfielder", TeamId = 8 },
                new Player { Id = 83, Name = "Federico Valverde", Age = 27, Position = "Midfielder", TeamId = 8 },
                new Player { Id = 84, Name = "Jude Bellingham", Age = 22, Position = "Midfielder", TeamId = 8 },
                new Player { Id = 85, Name = "Luka Modrić", Age = 39, Position = "Midfielder", TeamId = 8 },
                new Player { Id = 86, Name = "Vinícius Júnior", Age = 25, Position = "Forward", TeamId = 8 },
                new Player { Id = 87, Name = "Rodrygo", Age = 24, Position = "Forward", TeamId = 8 },
                new Player { Id = 88, Name = "Joselu", Age = 35, Position = "Forward", TeamId = 8 },

                // Napoli – TeamId = 9
                new Player { Id = 89, Name = "Alex Meret", Age = 28, Position = "Goalkeeper", TeamId = 9 },
                new Player { Id = 90, Name = "Giovanni Di Lorenzo", Age = 31, Position = "Defender", TeamId = 9 },
                new Player { Id = 91, Name = "Amir Rrahmani", Age = 30, Position = "Defender", TeamId = 9 },
                new Player { Id = 92, Name = "Mário Rui", Age = 33, Position = "Defender", TeamId = 9 },
                new Player { Id = 93, Name = "Stanislav Lobotka", Age = 29, Position = "Midfielder", TeamId = 9 },
                new Player { Id = 94, Name = "Piotr Zieliński", Age = 30, Position = "Midfielder", TeamId = 9 },
                new Player { Id = 95, Name = "Khvicha Kvaratskhelia", Age = 23, Position = "Forward", TeamId = 9 },
                new Player { Id = 96, Name = "Victor Osimhen", Age = 25, Position = "Forward", TeamId = 9 },
                new Player { Id = 97, Name = "Matteo Politano", Age = 31, Position = "Forward", TeamId = 9 },
                new Player { Id = 98, Name = "Jesper Lindstrøm", Age = 24, Position = "Forward", TeamId = 9 },
                new Player { Id = 99, Name = "Diego Demme", Age = 32, Position = "Midfielder", TeamId = 9 }
            );

        }
    }
}

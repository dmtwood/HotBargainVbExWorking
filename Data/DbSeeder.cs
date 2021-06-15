using HotBargainVbEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBargainVbEx.Data
{
    public static class DbSeeder
    {
        public static void Initialize(HotBargainsDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Personeelsleden.Any())
            {
                return;
            }

            var v1 = new Vestiging(){ Naam = "Turnhout" };
            var v2 = new Vestiging(){ Naam =  "Geel"};
            var v3 = new Vestiging(){ Naam =  "Mol"};
            var v4 = new Vestiging(){ Naam = "Herentals" };

            context.Vestigingen.AddRange(new Vestiging[] { v1, v2, v3, v4 });

            var pers1 = new Personeel() {
                Voornaam = "Wim",
                Achternaam = "Hambrouck",
                UserName = "wim.hambrouck@ehb.be",
                Wachtwoord = "123456",
                Vestiging = v1
            };


            var pers2 = new Personeel() { Voornaam = "P", Achternaam = "2", UserName = "P2", Wachtwoord = "123456", Vestiging = v2 };
            var pers3 = new Personeel() { Voornaam = "P", Achternaam = "3", UserName = "P3", Wachtwoord = "123456", Vestiging = v1 };

            context.Personeelsleden.AddRange(new Personeel[]
            {
                pers1, pers2, pers3
            });

            var p1 = new Project() { Status = Status.BEZIG, HuidigBudget = 1234.56M, ProjectNaam = "PROJ_1111", Personeelsleden = new List<Personeel> { pers1, pers2 } };
            var p2 = new Project() { Status = Status.BEVROREN, HuidigBudget = 1234, ProjectNaam = "PROJ_2222", Personeelsleden = new List<Personeel> { pers2, pers3 } };

            context.Projecten.AddRange(new Project[] { p1, p2 });




            context.SaveChanges();

        }

    }
}

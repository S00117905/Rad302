namespace Champions_League.Migrations
{
    using Champions_League.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Champions_League.DAL.LeagueContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Champions_League.DAL.LeagueContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var Teams = new List<Team>
            {
            new Team{TeamName = "Arsenal",Address = "England"},
            new Team{TeamName = "Shakhtar Donetsk",Address = "Ukraine"},
            new Team{TeamName = "Porto",Address = "Portugal"},
            new Team{TeamName = "Paris Saint-Germain",Address = "France"},
            new Team{TeamName = "Olympiacos",Address = "Greece"},
            new Team{TeamName = "Monaco",Address = "France"},
            new Team{TeamName = "Juventus",Address = "Italy"},
            new Team{TeamName = "Borussia Dortmund",Address = "Germany"},
            new Team{TeamName = "CSKA Moskva",Address = "Russia"},
            new Team{TeamName = "Chelsea",Address = "England"},
            new Team{TeamName = "Basel",Address = "Switzerland"},
            new Team{TeamName = "Bayern Munich",Address = "Germany"},
            new Team{TeamName = "Barcelona",Address = "Spain"},
            new Team{TeamName = "Athletico",Address = "Spain"},
            new Team{TeamName = "Galatasaray",Address = "Turkey"}
            };
            Teams.ForEach(s => context.Teams.Add(s));
            context.SaveChanges();
            var Leagues = new List<League>
            {
            new League{LeagueID=1,Title="Premier",Members=20,},
            new League{LeagueID=2,Title="League 1",Members=20,},
            new League{LeagueID=3,Title="Super Cup",Members=32,},
            new League{LeagueID=4,Title="Sunday Cup",Members=20,},
            new League{LeagueID=5,Title="Sunday League",Members=20,},
            new League{LeagueID=6,Title="League 2",Members=20,},
            new League{LeagueID=7,Title="League 3",Members=20,}
            };
            Leagues.ForEach(s => context.Leagues.Add(s));
            context.SaveChanges();
            var Registrations = new List<Registration>
            {
            new Registration{TeamID=1,LeagueID=1,Division=Division.A},
            new Registration{TeamID=1,LeagueID=7,Division=Division.C},
            new Registration{TeamID=1,LeagueID=2,Division=Division.B},
            new Registration{TeamID=2,LeagueID=2,Division=Division.B},
            new Registration{TeamID=2,LeagueID=2,Division=Division.B},
            new Registration{TeamID=2,LeagueID=7,Division=Division.C},
            new Registration{TeamID=3,LeagueID=6},
            new Registration{TeamID=4,LeagueID=5,},
            new Registration{TeamID=4,LeagueID=2,Division=Division.B},
            new Registration{TeamID=5,LeagueID=7,Division=Division.C},
            new Registration{TeamID=6,LeagueID=4},
            new Registration{TeamID=7,LeagueID=1,Division=Division.A},
            };
            Registrations.ForEach(s => context.Registrations.Add(s));
            context.SaveChanges();
        }
    }
}

﻿using Soccer.DAL.EF;
using Soccer.DAL.Interfaces;
using Soccer.DAL.Entities;

namespace Soccer.DAL.Repositories
{
    /*
        * The Unit of Work pattern simplifies working with multiple repositories
        * and ensures that all repositories share the same data context.
    */

    public class EFUnitOfWork : IUnitOfWork
    {
        private SoccerContext db;
        private PlayerRepository playerRepository;
        private TeamRepository teamRepository;

        public EFUnitOfWork(SoccerContext context)
        {
            db = context;
        }

        public IRepository<Team> Teams
        {
            get
            {
                if (teamRepository == null)
                    teamRepository = new TeamRepository(db);
                return teamRepository;
            }
        }

        public IRepository<Player> Players
        {
            get
            {
                if (playerRepository == null)
                    playerRepository = new PlayerRepository(db);
                return playerRepository;
            }
        }

        public async Task Save()
        {
            await db.SaveChangesAsync();
        }
       
    }
}
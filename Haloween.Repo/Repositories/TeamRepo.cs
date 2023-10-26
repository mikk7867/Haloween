using Haloween.Repo.DTO;
using Haloween.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haloween.Repo.Repositories
{
    public class TeamRepo : ITeamRepo
    {
        /*
        int tal;
        Dbcontext noget;
        string s;
        ITeamRepo noget2; */
        Dbcontext context; //database
        public TeamRepo(Dbcontext temp)
        {
            context = temp;
        }

        public Team Create(Team team)
        {
            //TODO: fix this method creating new heroes; not intended
            //TODO 2: make new method connecting heroes and teams
            context.Team.Add(team);
            context.SaveChanges();
            return team;
        }

        public void Delete(int id)
        {
            Team team = GetById(id);
            context.Team.Remove(team);
            context.SaveChanges();
        }

        public List<Team> GetAll()
        {
            //throw new NotImplementedException();
            //return context.GetAll<Team>();
            return context.Team.Include(x => x.SuperHeroes).ToList();
        }

        public Team GetById(int id)
        {
            return context.Team.Include(x => x.SuperHeroes).First(x => x.Id == id);
        }

        public Team Update(Team team)
        {
            throw new NotImplementedException();
        }
    }
}

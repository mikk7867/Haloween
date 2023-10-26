using Haloween.Repo.DTO;
using Haloween.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haloween.Repo.Repositories
{
    public class SuperHeroRepo: ISuperHeroRepo
    {
        /*
        int tal;
        Dbcontext noget;
        string s;
        ISuperHeroRepo noget2; */
        Dbcontext context; //database
        public SuperHeroRepo(Dbcontext temp)
        {
            context = temp;
        }

        public SuperHero Create(SuperHero hero)
        {
            context.SuperHero.Add(hero);
            context.SaveChanges();
            return hero;
        }

        public void Delete(int id)
        {
            SuperHero hero = GetById(id);
            context.SuperHero.Remove(hero);
            context.SaveChanges();
        }

        public List<SuperHero> GetAll()
        {
            //throw new NotImplementedException();
            //return context.GetAll<SuperHero>();
            return context.SuperHero.ToList();
        }

        public SuperHero GetById(int id)
        {
            return context.SuperHero.First(x => x.Id == id);
        }

        public SuperHero Update(SuperHero hero)
        {
            throw new NotImplementedException();
        }
    }
}

using Haloween.Repo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haloween.Repo.Interfaces
{
    public interface ISuperHeroRepo
    {
        //CRUD
        List<SuperHero> GetAll();
        SuperHero GetById(int id);
        //SuperHero GetByName(string name);
        SuperHero Create(SuperHero hero);
        SuperHero Update(SuperHero hero);
        void Delete(int id);
    }
}

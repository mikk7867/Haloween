using Haloween.Repo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haloween.Repo.Interfaces
{
    public interface ITeamRepo
    {
        //CRUD
        List<Team> GetAll();
        Team GetById(int id);
        //Team GetByName(string name);
        Team Create(Team team);
        Team Update(Team team);
        void Delete(int id);
    }
}

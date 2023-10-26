using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haloween.Repo.DTO
{
    public class Team
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<SuperHero>? SuperHeroes { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haloween.Repo.DTO
{
    //DTO = Data Transfer Object
    public class SuperHero
    {
        public int Id { get; set; }
        public string? HeroName { get; set; }
        public string? RealName { get; set; }
        public string? Place { get; set; }
        public DateTime Debut { get; set; }
        public string? Powers { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpgapi1.Models
{
    public class Personagem
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public int PontosVida {get; set;}
        public int Forca {get; set;}
        public int Defesa {get; set;}
        public int Inteligencia {get; set;}


        public ClasseEnum Classe{get; set;}
    }
}
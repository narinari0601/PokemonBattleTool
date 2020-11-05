using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDamageTool
{
    class Pokemon
    {
        private string name;

        private int attack;

        private int defense;

        //コンストラクタ
        public Pokemon(string name, int attack, int defense)
        {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
        }

        public string Name { get => name; set => name = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Defense { get => defense; set => defense = value; }
    }
}

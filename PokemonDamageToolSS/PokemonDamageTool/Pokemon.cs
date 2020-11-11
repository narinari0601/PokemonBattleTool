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

        private string type1;

        private string type2;

        private string ability1;

        private string ability2;

        private string hiddenAbility;

        private int hp;

        private int attack;

        private int defense;

        private int spAttack;

        private int spDefense;

        private int speed;

        //コンストラクタ
        public Pokemon()
        {

        }

        public string Name { get => name; set => name = value; }
        
        public string Type1 { get => type1; set => type1 = value; }
        public string Type2 { get => type2; set => type2 = value; }
        public string Ability1 { get => ability1; set => ability1 = value; }
        public string Ability2 { get => ability2; set => ability2 = value; }
        public string HiddenAbility { get => hiddenAbility; set => hiddenAbility = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Defense { get => defense; set => defense = value; }
        public int SpAttack { get => spAttack; set => spAttack = value; }
        public int SpDefense { get => spDefense; set => spDefense = value; }
        public int Speed { get => speed; set => speed = value; }


        public void Initialize(string[] data)
        {
            name = data[1];
            type1 = data[2];
            type2 = data[3];
            ability1 = data[4];
            ability2 = data[5];
            hiddenAbility = data[6];
            hp = int.Parse(data[7]);
            attack = int.Parse(data[8]);
            defense = int.Parse(data[9]);
            spAttack = int.Parse(data[10]);
            spDefense = int.Parse(data[11]);
            speed = int.Parse(data[12]);
        }
    }
}

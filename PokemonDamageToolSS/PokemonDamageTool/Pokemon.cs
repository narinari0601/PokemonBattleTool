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

        private int[] baseStatus;

        //個体値
        private int individualValue;

        //努力値
        private int effortValue;

        private int level;

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
        public int IndividualValue { get => individualValue; set => individualValue = value; }
        public int EffortValue { get => effortValue; set => effortValue = value; }

        public void Initialize(string[] data)
        {
            individualValue = 31;
            effortValue = 0;
            level = 50;

            

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

            baseStatus = new int[6];
            baseStatus[0] = int.Parse(data[7]);
            baseStatus[1] = int.Parse(data[8]);
            baseStatus[2] = int.Parse(data[9]);
            baseStatus[3] = int.Parse(data[10]);
            baseStatus[4] = int.Parse(data[11]);
            baseStatus[5] = int.Parse(data[12]);
        }
        
        //実数値計算
        public int RealNumberCalculation(int index)
        {
            //HP
            if (index == 0)
            {
                return (baseStatus[index] * 2 + individualValue + effortValue / 4) * level / 100 + level + 10;
            }

            //HP以外
            if (index > 0 && index < 6)
            {
                return ((baseStatus[index] * 2 + individualValue + effortValue / 4) * level / 100 + 5);
            }

            return 0;
        }
    }
}

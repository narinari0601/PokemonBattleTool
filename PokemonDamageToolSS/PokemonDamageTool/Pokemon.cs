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

        private string nickName;

        private string type1;

        private string type2;

        private string ability1;

        private string ability2;

        private string hiddenAbility;

        private string currentAbility;

        private float weight;

        //種族値
        private int[] baseStatus;

        //個体値
        private int[] individualValues;

        //努力値
        private int[] effortValues;

        //実数値
        private int[] realValues;

        private int[] statusLanks;

        private List<int[]> statuses;

        private int level;

        //コンストラクタ
        public Pokemon()
        {
            
        }

        public string Name { get => name; set => name = value; }
        public string NickName { get => nickName; set => nickName = value; }
        public string Type1 { get => type1; set => type1 = value; }
        public string Type2 { get => type2; set => type2 = value; }
        public string Ability1 { get => ability1; set => ability1 = value; }
        public string Ability2 { get => ability2; set => ability2 = value; }
        public string HiddenAbility { get => hiddenAbility; set => hiddenAbility = value; }
        public float Weight { get => weight; set => weight = value; }
        public int[] IndividualValues { get => individualValues; set => individualValues = value; }
        public int[] EffortValues { get => effortValues; set => effortValues = value; }
        public string CurrentAbility { get => currentAbility; set => currentAbility = value; }
        public int[] BaseStatus { get => baseStatus; set => baseStatus = value; }
        public int[] RealValues { get => realValues; set => realValues = value; }
        public List<int[]> Statuses { get => statuses; set => statuses = value; }
        public int[] StatusLanks { get => statusLanks; set => statusLanks = value; }
        

        public void Initialize(string[] data)
        {
            level = 50;

            name = data[1];
            type1 = data[2];
            type2 = data[3];
            ability1 = data[4];
            ability2 = data[5];
            hiddenAbility = data[6];
            currentAbility = "";


            baseStatus = new int[6];
            baseStatus[0] = int.Parse(data[7]);
            baseStatus[1] = int.Parse(data[8]);
            baseStatus[2] = int.Parse(data[9]);
            baseStatus[3] = int.Parse(data[10]);
            baseStatus[4] = int.Parse(data[11]);
            baseStatus[5] = int.Parse(data[12]);

            individualValues =  new int[6] 
                { 31, 31, 31, 31, 31, 31 };

            effortValues = new int[6] 
                { 0, 0, 0, 0, 0, 0 };

            realValues = new int[6];
            for (int i = 0; i < realValues.Length; i++)
            {
                realValues[i] = RealNumberCalculation(i);
            }

            statusLanks = new int[5]
                {0,0,0,0,0 };

            statuses = new List<int[]>();
            statuses.Add(baseStatus);
            statuses.Add(individualValues);
            statuses.Add(effortValues);
            statuses.Add(realValues);
        }
        
        //実数値計算
        public int RealNumberCalculation(int index)
        {
            //HP
            if (index == 0)
            {
                return (baseStatus[index] * 2 + individualValues[index] + effortValues[index] / 4) * level / 100 + level + 10;
            }

            //HP以外
            if (index > 0 && index < 6)
            {
                return ((baseStatus[index] * 2 + individualValues[index] + effortValues[index] / 4) * level / 100 + 5);
            }

            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status">3値配列</param>
        /// <param name="index">HABCDS</param>
        /// <param name="value">変更</param>
        public void StatusUpdate(int status, int index, int value)
        {
            statuses[status][index] = value;

            realValues[index] = RealNumberCalculation(index);
        }
    }
}

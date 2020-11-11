using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonDamageTool
{
    public partial class Form1 : Form
    {
        private float attackNum;

        private float defenseNum;

        private float powerNum;

        private int minDamage;

        private int maxDamage;

        private Pokemon attackPoke;

        private Pokemon defensePoke;

        private Pokemon[] myPokeArray;

        private Pokemon[] yourPokeArray;

        //データ用
        private List<Pokemon> pokemonList;

        private CSVReader cSVReader;

        public Form1()
        {
            InitializeComponent();

            Initialize();

            attackNum = 0;

            defenseNum = 0;

            powerNum = 0;

            minDamage = 0;

            maxDamage = 0;
        }

        private void Initialize()
        {
            myPokeArray = new Pokemon[6];
            yourPokeArray = new Pokemon[6];

            cSVReader = new CSVReader();
            cSVReader.Read("Resources/csv/PokemonData.csv");

            var data = cSVReader.GetDate();

            pokemonList = new List<Pokemon>();

            for (int i = 1; i < 100; i++)
            {
                Pokemon pokemon = new Pokemon();
                pokemon.Initialize(data[i]);

                pokemonList.Add(pokemon);
            }

            int a= pokemonList[0].RealNumberCalculation(1);

            //pokemon1 = new Pokemon("ミミッキュ", 142, 100);
            //pokemon2 = new Pokemon("ガブリアス", 182, 115);

            //pokemonList.Add(pokemon1);
            //pokemonList.Add(pokemon2);
            
            //attackPowerLabel.Text = pokemon1.Attack.ToString();
            //defensePowerLabel.Text = pokemon2.Defense.ToString();
        }


        //五捨五超入
        private int RoundedOver(float num)
        {
            double d = (double)num;
            d = d % 1 * 10;

            if (d <= 5)
            {
                return (int)num;
            }
            
            return (int)(num + 1);
        }

        private Pokemon SearchPokemonName(string name)
        {
            foreach (var poke in pokemonList)
            {
                if (poke.Name == name)
                {
                    return poke;
                }
            }

            return null;
        }

        //ダメージ計算
        private void DamageCalculation(int attack, int defense)
        {
            attackNum = attack;
            defenseNum = defense;

            int damageNum;

            //レベル計算
            float level = 50 * 2 / 5 + 2;
            damageNum = (int)level;

            //技威力
            float pow = damageNum * powerNum * attackNum / defenseNum;
            damageNum = (int)pow;

            //保障ダメージ
            float security = damageNum / 50 + 2;
            damageNum = (int)security;

            //乱数
            maxDamage = damageNum;
            minDamage = (int)(damageNum * 0.85f);

            //タイプ一致
            if (sameTypeCB.Checked)
            {
                maxDamage = RoundedOver((maxDamage * 1.5f));
                minDamage = RoundedOver((minDamage * 1.5f));
            }

            //タイプ相性
            //2倍
            if (supperEffectiveCB.Checked)
            {
                maxDamage *= 2;
                minDamage *= 2;
            }

            //1/2倍
            if (notVeryEffectiveCB.Checked)
            {
                maxDamage = (int)(maxDamage * 0.5f);
                minDamage = (int)(minDamage * 0.5f);
            }


            //1より小さくなった場合
            if (maxDamage < 1)
                maxDamage = 1;

            if (minDamage < 1)
                minDamage = 1;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            float num = (float)numericUpDown3.Value;

            powerNum = num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DamageCalculation(attackPoke.Attack, defensePoke.Defense);

            damageLabel.Text = minDamage.ToString() + "～" + maxDamage.ToString();

        }

        private void damageLabel_Click(object sender, EventArgs e)
        {
            
        }
        

        private void sameTypeCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void supperEffectiveCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void notVeryEffectiveCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void attackPoke_Click(object sender, EventArgs e)
        {

        }

        private void defensePokeLabel_Click(object sender, EventArgs e)
        {

        }

        private void attackPowerLabel_Click(object sender, EventArgs e)
        {

        }

        private void defensePowerLabel_Click(object sender, EventArgs e)
        {

        }

        private void myPartyGB_Enter(object sender, EventArgs e)
        {

        }

        private void yourPartyGB_Enter(object sender, EventArgs e)
        {

        }
        #region myPokeTBs
        private void myPokeTB1_TextChanged(object sender, EventArgs e)
        {
            var pokeName = myPokeTB1.Text;

            myPokeArray[0] = SearchPokemonName(pokeName);
        }

        private void myPokeTB2_TextChanged(object sender, EventArgs e)
        {
            var pokeName = myPokeTB2.Text;

            myPokeArray[1] = SearchPokemonName(pokeName);
        }

        private void myPokeTB3_TextChanged(object sender, EventArgs e)
        {
            var pokeName = myPokeTB3.Text;

            myPokeArray[2] = SearchPokemonName(pokeName);
        }

        private void myPokeTB4_TextChanged(object sender, EventArgs e)
        {
            var pokeName = myPokeTB4.Text;

            myPokeArray[3] = SearchPokemonName(pokeName);
        }

        private void myPokeTB5_TextChanged(object sender, EventArgs e)
        {
            var pokeName = myPokeTB5.Text;

            myPokeArray[4] = SearchPokemonName(pokeName);
        }

        private void myPokeTB6_TextChanged(object sender, EventArgs e)
        {
            var pokeName = myPokeTB6.Text;

            myPokeArray[5] = SearchPokemonName(pokeName);
        }
        #endregion

        #region myPokeRBs
        private void myPokeRB1_CheckedChanged(object sender, EventArgs e)
        {
            if (myPokeRB1.Checked)
            {
                attackPoke = myPokeArray[0];

                if (attackPoke == null)
                    return;

                attackPokeLabel.Text = attackPoke.Name;
                attackPowerLabel.Text = attackPoke.Attack.ToString();
            }
        }

        private void myPokeRB2_CheckedChanged(object sender, EventArgs e)
        {
            if (myPokeRB2.Checked)
            {
                attackPoke = myPokeArray[1];

                if (attackPoke == null)
                    return;

                attackPokeLabel.Text = attackPoke.Name;
                attackPowerLabel.Text = attackPoke.Attack.ToString();
            }
        }

        private void myPokeRB3_CheckedChanged(object sender, EventArgs e)
        {
            if (myPokeRB3.Checked)
            {
                attackPoke = myPokeArray[2];

                if (attackPoke == null)
                    return;

                attackPokeLabel.Text = attackPoke.Name;
                attackPowerLabel.Text = attackPoke.Attack.ToString();
            }
        }

        private void myPokeRB4_CheckedChanged(object sender, EventArgs e)
        {
            if (myPokeRB4.Checked)
            {
                attackPoke = myPokeArray[3];

                if (attackPoke == null)
                    return;

                attackPokeLabel.Text = attackPoke.Name;
                attackPowerLabel.Text = attackPoke.Attack.ToString();
            }
        }

        private void myPokeRB5_CheckedChanged(object sender, EventArgs e)
        {
            if (myPokeRB5.Checked)
            {
                attackPoke = myPokeArray[4];

                if (attackPoke == null)
                    return;

                attackPokeLabel.Text = attackPoke.Name;
                attackPowerLabel.Text = attackPoke.Attack.ToString();
            }
        }

        private void myPokeRB6_CheckedChanged(object sender, EventArgs e)
        {
            if (myPokeRB6.Checked)
            {
                attackPoke = myPokeArray[5];

                if (attackPoke == null)
                    return;

                attackPokeLabel.Text = attackPoke.Name;
                attackPowerLabel.Text = attackPoke.Attack.ToString();
            }
        }
        #endregion

        #region yourPokeTBs
        private void yourPokeTB1_TextChanged(object sender, EventArgs e)
        {
            var pokeName = yourPokeTB1.Text;

            yourPokeArray[0] = SearchPokemonName(pokeName);
        }

        private void yourPokeTB2_TextChanged(object sender, EventArgs e)
        {
            var pokeName = yourPokeTB2.Text;

            yourPokeArray[1] = SearchPokemonName(pokeName);
        }

        private void yourPokeTB3_TextChanged(object sender, EventArgs e)
        {
            var pokeName = yourPokeTB3.Text;

            yourPokeArray[2] = SearchPokemonName(pokeName);
        }

        private void yourPokeTB4_TextChanged(object sender, EventArgs e)
        {
            var pokeName = yourPokeTB4.Text;

            yourPokeArray[3] = SearchPokemonName(pokeName);
        }

        private void yourPokeTB5_TextChanged(object sender, EventArgs e)
        {
            var pokeName = yourPokeTB5.Text;

            yourPokeArray[4] = SearchPokemonName(pokeName);
        }

        private void yourPokeTB6_TextChanged(object sender, EventArgs e)
        {
            var pokeName = yourPokeTB6.Text;

            yourPokeArray[5] = SearchPokemonName(pokeName);
        }
        #endregion

        #region yourPokeRBs
        private void yourPokeRB1_CheckedChanged(object sender, EventArgs e)
        {
            if (yourPokeRB1.Checked)
            {
                defensePoke = yourPokeArray[0];

                if (defensePoke == null)
                    return;

                defensePokeLabel.Text = defensePoke.Name;
                defensePowerLabel.Text = defensePoke.Defense.ToString();
            }
        }

        private void yourPokeRB2_CheckedChanged(object sender, EventArgs e)
        {
            if (yourPokeRB2.Checked)
            {
                defensePoke = yourPokeArray[1];

                if (defensePoke == null)
                    return;

                defensePokeLabel.Text = defensePoke.Name;
                defensePowerLabel.Text = defensePoke.Defense.ToString();
            }
        }

        private void yourPokeRB3_CheckedChanged(object sender, EventArgs e)
        {
            if (yourPokeRB3.Checked)
            {
                defensePoke = yourPokeArray[2];

                if (defensePoke == null)
                    return;

                defensePokeLabel.Text = defensePoke.Name;
                defensePowerLabel.Text = defensePoke.Defense.ToString();
            }
        }

        private void yourPokeRB4_CheckedChanged(object sender, EventArgs e)
        {
            if (yourPokeRB4.Checked)
            {
                defensePoke = yourPokeArray[3];

                if (defensePoke == null)
                    return;

                defensePokeLabel.Text = defensePoke.Name;
                defensePowerLabel.Text = defensePoke.Defense.ToString();
            }
        }

        private void yourPokeRB5_CheckedChanged(object sender, EventArgs e)
        {
            if (yourPokeRB5.Checked)
            {
                defensePoke = yourPokeArray[4];

                if (defensePoke == null)
                    return;

                defensePokeLabel.Text = defensePoke.Name;
                defensePowerLabel.Text = defensePoke.Defense.ToString();
            }
        }

        private void yourPokeRB6_CheckedChanged(object sender, EventArgs e)
        {
            if (yourPokeRB6.Checked)
            {
                defensePoke = yourPokeArray[5];

                if (defensePoke == null)
                    return;

                defensePokeLabel.Text = defensePoke.Name;
                defensePowerLabel.Text = defensePoke.Defense.ToString();
            }
        }
        #endregion

        private void attackPokeLabel_Click(object sender, EventArgs e)
        {

        }

        private void defensePokeLabel_Click_1(object sender, EventArgs e)
        {

        }
        
    }
}

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

        private Pokemon pokemon1;

        private Pokemon pokemon2;

        private Pokemon attackPoke;

        private Pokemon defensePoke;

        private List<Pokemon> pokemonList;



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
            pokemonList = new List<Pokemon>();

            pokemon1 = new Pokemon("ミミッキュ", 142, 100);
            pokemon2 = new Pokemon("ガブリアス", 182, 115);

            pokemonList.Add(pokemon1);
            pokemonList.Add(pokemon2);
            
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

        private void attackPokeTB_TextChanged(object sender, EventArgs e)
        {
            string pokeName = attackPokeTB.Text;

            foreach (var poke in pokemonList)
            {
                if (poke.Name == pokeName)
                {
                    attackPowerLabel.Text = poke.Attack.ToString();
                    attackPoke = poke;
                }
            }
        }

        private void defensePokeTB_TextChanged(object sender, EventArgs e)
        {
            string pokeName = defensePokeTB.Text;

            foreach (var poke in pokemonList)
            {
                if (poke.Name == pokeName)
                {
                    defensePowerLabel.Text = poke.Defense.ToString();
                    defensePoke = poke;
                }
            }
        }
    }
}

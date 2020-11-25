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

        private Button[] myPokeButtons;

        private Button[] myPokeElectButtons;

        private bool[] myPokeElects;

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

            //myPokeTB1.PreviewKeyDown += myPokeTB1_PreviewKeyDown;
            //myPokeTB2.PreviewKeyDown += myPokeTB2_PreviewKeyDown;
            //myPokeTB3.PreviewKeyDown += myPokeTB3_PreviewKeyDown;
            //myPokeTB4.PreviewKeyDown += myPokeTB4_PreviewKeyDown;
            //myPokeTB5.PreviewKeyDown += myPokeTB5_PreviewKeyDown;
            //myPokeTB6.PreviewKeyDown += myPokeTB6_PreviewKeyDown;

            //yourPokeTB1.PreviewKeyDown += yourPokeTB1_PreviewKeyDown;
            //yourPokeTB2.PreviewKeyDown += yourPokeTB2_PreviewKeyDown;
            //yourPokeTB3.PreviewKeyDown += yourPokeTB3_PreviewKeyDown;
            //yourPokeTB4.PreviewKeyDown += yourPokeTB4_PreviewKeyDown;
            //yourPokeTB5.PreviewKeyDown += yourPokeTB5_PreviewKeyDown;
            //yourPokeTB6.PreviewKeyDown += yourPokeTB6_PreviewKeyDown;

            myPokeTB.PreviewKeyDown += myPokeTB_PreviewKeyDown;

            myPokeButtons = new Button[6];
            myPokeButtons[0] = myPoke1Button;
            myPokeButtons[1] = myPoke2Button;
            myPokeButtons[2] = myPoke3Button;
            myPokeButtons[3] = myPoke4Button;
            myPokeButtons[4] = myPoke5Button;
            myPokeButtons[5] = myPoke6Button;

            for (int i = 0; i < myPokeButtons.Length; i++)
            {
                myPokeButtons[i].Click += new EventHandler(MyPokeButton_Click);
            }

            myPokeElectButtons = new Button[6];
            myPokeElectButtons[0] = myPokeElectButton1;
            myPokeElectButtons[1] = myPokeElectButton2;
            myPokeElectButtons[2] = myPokeElectButton3;
            myPokeElectButtons[3] = myPokeElectButton4;
            myPokeElectButtons[4] = myPokeElectButton5;
            myPokeElectButtons[5] = myPokeElectButton6;

            for (int i = 0; i < myPokeElectButtons.Length; i++)
            {
                myPokeElectButtons[i].Click += new EventHandler(MyPokeElectButton_Click);
            }

            myPokeElects = new bool[3];
            for (int i = 0; i < myPokeElects.Length; i++)
            {
                myPokeElects[i] = false;
            }

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

        private Pokemon SearchPokemonName(string name, TextBox textBox)
        {
            foreach (var poke in pokemonList)
            {
                if (poke.Name == name)
                {
                    textBox.ResetText();
                    return poke;
                }
            }

            return null;
        }

        //ダメージ計算
        private void DamageCalculation()
        {
            if (attackPoke == null || defensePoke == null)
                return;

            attackNum = attackPoke.RealNumberCalculation(1);
            defenseNum = defensePoke.RealNumberCalculation(2);

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

        private void PartyInput(Pokemon pokemon, Pokemon[] party)
        {
            
            int i = 0;

            foreach (var poke in party)
            {
                if (poke == null)
                {
                    party[i] = pokemon;
                    return;
                }
                i++;
            }
        }

        //選出
        private int PokemonElection()
        {
            int index = 0;

            foreach (var num in myPokeElects)
            {
                if (num == false)
                {
                    myPokeElects[index] = true;
                    return index + 1;
                }
                index++;
            }

            return 0;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            float num = (float)numericUpDown3.Value;

            powerNum = num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DamageCalculation();

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
        private void myPokeTB_TextChanged(object sender, EventArgs e)
        {

        }
        


        private void attackPokeLabel_Click(object sender, EventArgs e)
        {

        }

        private void defensePokeLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void attackEVNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (attackPoke == null)
                return;

            attackPoke.EffortValues[1] = (int)attackEVNumUD.Value;
            DamageCalculation();
        }

        private void defenseEVNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (defensePoke == null)
                return;

            defensePoke.EffortValues[2] = (int)defenseEVNumUD.Value;
            DamageCalculation();
        }

        private void MyPokeButton_Click(object sender, EventArgs e)
        {
            //クリックされたボタンのインデックス番号を取得する
            int index = -1;
            for (int i = 0; i < myPokeElectButtons.Length; i++)
            {
                if (myPokeButtons[i].Equals(sender))
                {
                    index = i;
                    break;
                }
            }

            if (index > -1)
            {
                attackPoke = myPokeArray[index];

                if (attackPoke == null)
                    return;

                string[] abilities = new string[3];
                abilities[0] = attackPoke.Ability1;
                abilities[1] = attackPoke.Ability2;
                abilities[2] = attackPoke.HiddenAbility;

                myPokeAbilityCB.Items.Clear();


                for (int i = 0; i < abilities.Length; i++)
                {
                    if (abilities[i] != "")
                    {
                        myPokeAbilityCB.Items.Add(abilities[i]);

                        if (attackPoke.CurrentAbility == abilities[i])
                        {
                            myPokeAbilityCB.SelectedIndex = i;
                        }
                    }

                }


                attackPokeLabel.Text = attackPoke.Name;
                attackPowerLabel.Text = attackPoke.RealNumberCalculation(1).ToString();

            }
        }

        private void myPoke1Button_Click(object sender, EventArgs e)
        {
            //attackPoke = myPokeArray[0];

            //if (attackPoke == null)
            //    return;

            //attackPokeLabel.Text = attackPoke.Name;
            //attackPowerLabel.Text = attackPoke.RealNumberCalculation(1).ToString();
        }

        private void myPoke2Button_Click(object sender, EventArgs e)
        {
            //attackPoke = myPokeArray[1];

            //if (attackPoke == null)
            //    return;

            //attackPokeLabel.Text = attackPoke.Name;
            //attackPowerLabel.Text = attackPoke.RealNumberCalculation(1).ToString();
        }

        private void myPoke3Button_Click(object sender, EventArgs e)
        {
            //attackPoke = myPokeArray[2];

            //if (attackPoke == null)
            //    return;

            //attackPokeLabel.Text = attackPoke.Name;
            //attackPowerLabel.Text = attackPoke.RealNumberCalculation(1).ToString();
        }

        private void myPoke4Button_Click(object sender, EventArgs e)
        {
            //attackPoke = myPokeArray[3];

            //if (attackPoke == null)
            //    return;

            //attackPokeLabel.Text = attackPoke.Name;
            //attackPowerLabel.Text = attackPoke.RealNumberCalculation(1).ToString();
        }

        private void myPoke5Button_Click(object sender, EventArgs e)
        {
            //attackPoke = myPokeArray[4];

            //if (attackPoke == null)
            //    return;

            //attackPokeLabel.Text = attackPoke.Name;
            //attackPowerLabel.Text = attackPoke.RealNumberCalculation(1).ToString();
        }

        private void myPoke6Button_Click(object sender, EventArgs e)
        {
            //attackPoke = myPokeArray[5];

            //if (attackPoke == null)
            //    return;

            //attackPokeLabel.Text = attackPoke.Name;
            //attackPowerLabel.Text = attackPoke.RealNumberCalculation(1).ToString();
        }

        private void MyPokeElectButton_Click(object sender, EventArgs e)
        {
            //クリックされたボタンのインデックス番号を取得する
            int index = -1;
            for (int i = 0; i < myPokeElectButtons.Length; i++)
            {
                if (myPokeElectButtons[i].Equals(sender))
                {
                    index = i;
                    break;
                }
            }

            
            if (index > -1)
            {
                if (myPokeElectButtons[index].Text == "")
                {
                    var num = PokemonElection();
                    if (num == 0)
                        return;
                    myPokeElectButtons[index].Text = num.ToString();
                }

                else
                {
                    int num = int.Parse(myPokeElectButtons[index].Text);
                    myPokeElects[num - 1] = false;
                    myPokeElectButtons[index].ResetText();
                }
            }
        }

        private void myPokeElectButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void myPokeElectButton2_Click(object sender, EventArgs e)
        {

        }

        private void myPokeElectButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void myPokeElectButton4_Click(object sender, EventArgs e)
        {

        }

        private void myPokeElectButton5_Click(object sender, EventArgs e)
        {

        }

        private void myPokeElectButton6_Click(object sender, EventArgs e)
        {

        }

        private void myPokeAbility_SelectedIndexChanged(object sender, EventArgs e)
        {
            attackPoke.CurrentAbility = myPokeAbilityCB.Text;
        }

        private void myPokeTB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    var pokeName = myPokeTB.Text;
                    var poke = SearchPokemonName(pokeName, myPokeTB);
                    PartyInput(poke, myPokeArray);
                    break;
                    
            }
        }

        private void yourPokeTB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    var pokeName = myPokeTB.Text;
                    //var poke = SearchPokemonName(pokeName, yourPokeTB);
                    //PartyInput(poke, myPokeArray);
                    break;

            }
        }
        
    }
}

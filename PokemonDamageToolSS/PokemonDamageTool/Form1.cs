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

        private Pokemon[] currentPokes;

        private TextBox[] pokeTextBoxes;

        private Pokemon attackPoke;

        private Pokemon defensePoke;

        private List<Pokemon[]> partyList;

        private List<Button[]> pokeButtons;

        private List<Button[]> pokeElectButtonList;

        private List<bool[]> pokeElectList;

        private ComboBox[] abilityCBs;

        //-1=null 0=自分 1=相手
        private int currentGroupBoxNum;

        string[] states = new string[4];

        //データ用
        private List<Pokemon> pokemonList;

        private CSVReader cSVReader;


        PokemonStatusDGV statusDGV;

        public Form1()
        {
            InitializeComponent();

            Initialize();

            PokeDataInitialize();

            statusDGV = new PokemonStatusDGV(myPokeStatusDGV, yourPokeStatusDGV);
            statusDGV.Initialize();
            
        }

        private void Initialize()
        {
            attackNum = 0;

            defenseNum = 0;

            powerNum = 0;

            minDamage = 0;

            maxDamage = 0;

            currentGroupBoxNum = -1;

            partyList = new List<Pokemon[]>();
            partyList.Add(new Pokemon[6]);
            partyList.Add(new Pokemon[6]);

            currentPokes = new Pokemon[2];

            states = new string[4]
                {"種族","個体","努力","実数"};
            

            myPokeTB.PreviewKeyDown += PokeTB_PreviewKeyDown;
            yourPokeTB.PreviewKeyDown += PokeTB_PreviewKeyDown;

            pokeTextBoxes = new TextBox[2]
                {myPokeTB,yourPokeTB };

            pokeButtons = new List<Button[]>();
            pokeButtons.Add(
                new Button[6]
                {
                    myPokeButton1,
                    myPokeButton2,
                    myPokeButton3,
                    myPokeButton4,
                    myPokeButton5,
                    myPokeButton6
                });

            pokeButtons.Add(
                new Button[6]
                {
                    yourPokeButton1,
                    yourPokeButton2,
                    yourPokeButton3,
                    yourPokeButton4,
                    yourPokeButton5,
                    yourPokeButton6
                });

            for (int i = 0; i < pokeButtons.Count; i++)
            {
                for (int j = 0; j < pokeButtons[i].Length; j++)
                {
                    pokeButtons[i][j].Click += new EventHandler(PokeButton_Click);
                }
            }

            pokeElectButtonList = new List<Button[]>();
            pokeElectButtonList.Add(
                new Button[6]
                {   myPokeElectButton1,
                    myPokeElectButton2,
                    myPokeElectButton3,
                    myPokeElectButton4,
                    myPokeElectButton5,
                    myPokeElectButton6
                });

            pokeElectButtonList.Add(
                new Button[6]
                {   yourPokeElectButton1,
                    yourPokeElectButton2,
                    yourPokeElectButton3,
                    yourPokeElectButton4,
                    yourPokeElectButton5,
                    yourPokeElectButton6
                });

            for (int i = 0; i < pokeElectButtonList.Count; i++)
            {
                for (int j = 0; j < pokeElectButtonList[i].Length; j++)
                {
                    pokeElectButtonList[i][j].Click += new EventHandler(MyPokeElectButton_Click);
                }
            }


            pokeElectList = new List<bool[]>();

            for (int i = 0; i < 2; i++)
            {
                pokeElectList.Add(
                new bool[3]
                {
                    false,
                    false,
                    false
                });
            }
            


            abilityCBs = new ComboBox[2]
                {myPokeAbilityCB,yourPokeAbilityCB };

        }

        private void PokeDataInitialize()
        {
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
                    break;
                }
                i++;
            }
        }

        //選出
        private int PokemonElection()
        {
            int index = 0;

            foreach (var num in pokeElectList[currentGroupBoxNum])
            {
                if (num == false)
                {
                    pokeElectList[currentGroupBoxNum][index] = true;
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
        
        
        
        private void myPokeTB_TextChanged(object sender, EventArgs e)
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

        private void PokeButton_Click(object sender, EventArgs e)
        {
            //クリックされたボタンのインデックス番号を取得する
            int index = -1;
            for (int i = 0; i < 6; i++)
            {
                if (pokeButtons[currentGroupBoxNum][i].Equals(sender))
                {
                    index = i;
                    break;
                }
            }

            if (index > -1)
            {
                attackPoke = partyList[currentGroupBoxNum][index];

                var poke= partyList[currentGroupBoxNum][index];
                currentPokes[currentGroupBoxNum] = poke;
                

                if (poke == null)
                    return;

                string[] abilities = new string[3];
                abilities[0] = poke.Ability1;
                abilities[1] = poke.Ability2;
                abilities[2] = poke.HiddenAbility;

                abilityCBs[currentGroupBoxNum].Items.Clear();


                for (int i = 0; i < abilities.Length; i++)
                {
                    if (abilities[i] != "")
                    {
                        abilityCBs[currentGroupBoxNum].Items.Add(abilities[i]);

                        if (poke.CurrentAbility == abilities[i])
                        {
                            abilityCBs[currentGroupBoxNum].SelectedIndex = i;
                        }
                    }

                }
                
                statusDGV.SetPokemonStatusDGV(currentPokes[currentGroupBoxNum],currentGroupBoxNum);


                //attackPokeLabel.Text = attackPoke.Name;
                //attackPowerLabel.Text = attackPoke.RealNumberCalculation(1).ToString();

            }
        }
        
        

        private void MyPokeElectButton_Click(object sender, EventArgs e)
        {
            //クリックされたボタンのインデックス番号を取得する
            int index = -1;
            for (int i = 0; i < pokeElectButtonList[currentGroupBoxNum].Length; i++)
            {
                if (pokeElectButtonList[currentGroupBoxNum][i].Equals(sender))
                {
                    index = i;
                    break;
                }
            }


            if (index > -1)
            {
                if (pokeElectButtonList[currentGroupBoxNum][index].Text == "")
                {
                    var num = PokemonElection();
                    if (num == 0)
                        return;
                    pokeElectButtonList[currentGroupBoxNum][index].Text = num.ToString();
                }

                //数字を消すパターン
                else
                {
                    int num = int.Parse(pokeElectButtonList[currentGroupBoxNum][index].Text);
                    pokeElectList[currentGroupBoxNum][num - 1] = false;
                    pokeElectButtonList[currentGroupBoxNum][index].ResetText();
                }
            }
        }
        

        private void myPokeAbility_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPokes[currentGroupBoxNum].CurrentAbility = abilityCBs[currentGroupBoxNum].Text;
        }

        private void PokeTB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    var currentTB = pokeTextBoxes[currentGroupBoxNum];
                    var pokeName = currentTB.Text;
                    var poke = SearchPokemonName(pokeName, currentTB);
                    PartyInput(poke, partyList[currentGroupBoxNum]);
                    break;

            }
        }

        private void myPokeStatusDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        

        private void myALankNUD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void myPartyGB_Enter(object sender, EventArgs e)
        {
            currentGroupBoxNum = 0;
            statusDGV.CurrentGroupBoxNum = currentGroupBoxNum;
            statusDGV.CurrentPokes[currentGroupBoxNum] = currentPokes[currentGroupBoxNum];
        }

        private void yourPartyGB_Enter(object sender, EventArgs e)
        {
            currentGroupBoxNum = 1;
            statusDGV.CurrentGroupBoxNum = currentGroupBoxNum;
            statusDGV.CurrentPokes[currentGroupBoxNum] = currentPokes[currentGroupBoxNum];
        }
    }
}

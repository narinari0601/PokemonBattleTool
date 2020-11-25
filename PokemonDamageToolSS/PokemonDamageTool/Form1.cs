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

        private Pokemon SearchPokemonName(string name)
        {
            foreach (var poke in pokemonList)
            {
                if (poke.Name == name)
                {
                    myPokeTB.ResetText();
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
                defensePowerLabel.Text = defensePoke.RealNumberCalculation(2).ToString();
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
                defensePowerLabel.Text = defensePoke.RealNumberCalculation(2).ToString();
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
                defensePowerLabel.Text = defensePoke.RealNumberCalculation(2).ToString();
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
                defensePowerLabel.Text = defensePoke.RealNumberCalculation(2).ToString();
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
                defensePowerLabel.Text = defensePoke.RealNumberCalculation(2).ToString();
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
                defensePowerLabel.Text = defensePoke.RealNumberCalculation(2).ToString();
            }
        }
        #endregion

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

            attackPoke.EffortValue = (int)attackEVNumUD.Value;
            DamageCalculation();
        }

        private void defenseEVNumUD_ValueChanged(object sender, EventArgs e)
        {
            if (defensePoke == null)
                return;

            defensePoke.EffortValue = (int)defenseEVNumUD.Value;
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

                myPokeAbilityCB.Items.Clear();

                myPokeAbilityCB.Items.Add(attackPoke.Ability1);
                myPokeAbilityCB.Items.Add(attackPoke.Ability2);
                myPokeAbilityCB.Items.Add(attackPoke.HiddenAbility);

            }
        }

        private void myPoke1Button_Click(object sender, EventArgs e)
        {
            attackPoke = myPokeArray[0];

            if (attackPoke == null)
                return;

            attackPokeLabel.Text = attackPoke.Name;
            attackPowerLabel.Text = attackPoke.RealNumberCalculation(1).ToString();
        }

        private void myPoke2Button_Click(object sender, EventArgs e)
        {
            attackPoke = myPokeArray[1];

            if (attackPoke == null)
                return;

            attackPokeLabel.Text = attackPoke.Name;
            attackPowerLabel.Text = attackPoke.RealNumberCalculation(1).ToString();
        }

        private void myPoke3Button_Click(object sender, EventArgs e)
        {
            attackPoke = myPokeArray[2];

            if (attackPoke == null)
                return;

            attackPokeLabel.Text = attackPoke.Name;
            attackPowerLabel.Text = attackPoke.RealNumberCalculation(1).ToString();
        }

        private void myPoke4Button_Click(object sender, EventArgs e)
        {
            attackPoke = myPokeArray[3];

            if (attackPoke == null)
                return;

            attackPokeLabel.Text = attackPoke.Name;
            attackPowerLabel.Text = attackPoke.RealNumberCalculation(1).ToString();
        }

        private void myPoke5Button_Click(object sender, EventArgs e)
        {
            attackPoke = myPokeArray[4];

            if (attackPoke == null)
                return;

            attackPokeLabel.Text = attackPoke.Name;
            attackPowerLabel.Text = attackPoke.RealNumberCalculation(1).ToString();
        }

        private void myPoke6Button_Click(object sender, EventArgs e)
        {
            attackPoke = myPokeArray[5];

            if (attackPoke == null)
                return;

            attackPokeLabel.Text = attackPoke.Name;
            attackPowerLabel.Text = attackPoke.RealNumberCalculation(1).ToString();
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
            
        }

        private void myPokeTB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    var pokeName = myPokeTB.Text;

                    //myPokeArray[0] = SearchPokemonName(pokeName);
                    var poke = SearchPokemonName(pokeName);
                    PartyInput(poke, myPokeArray);
                    break;
                    
            }
        }

        //#region myPokeTB_PreviewKeyDownメソッド
        //private void myPokeTB1_PreviewKeyDown(object sender,PreviewKeyDownEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Return:
        //            myPokeTB2.Focus();
        //            break;

        //        //Tabキーが押されてもフォーカスが移動しないようにする
        //        case Keys.Tab:
        //            e.IsInputKey = true;
        //            break;
        //    }
        //}

        //private void myPokeTB2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Return:
        //            myPokeTB3.Focus();
        //            break;

        //        //Tabキーが押されてもフォーカスが移動しないようにする
        //        case Keys.Tab:
        //            e.IsInputKey = true;
        //            break;
        //    }
        //}
        //private void myPokeTB3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Return:
        //            myPokeTB4.Focus();
        //            break;

        //        //Tabキーが押されてもフォーカスが移動しないようにする
        //        case Keys.Tab:
        //            e.IsInputKey = true;
        //            break;
        //    }
        //}

        //private void myPokeTB4_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Return:
        //            myPokeTB5.Focus();
        //            break;

        //        //Tabキーが押されてもフォーカスが移動しないようにする
        //        case Keys.Tab:
        //            e.IsInputKey = true;
        //            break;
        //    }
        //}

        //private void myPokeTB5_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Return:
        //            myPokeTB6.Focus();
        //            break;

        //        //Tabキーが押されてもフォーカスが移動しないようにする
        //        case Keys.Tab:
        //            e.IsInputKey = true;
        //            break;
        //    }
        //}

        //private void myPokeTB6_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Return:
        //            yourPokeTB1.Focus();
        //            break;

        //        //Tabキーが押されてもフォーカスが移動しないようにする
        //        case Keys.Tab:
        //            e.IsInputKey = true;
        //            break;
        //    }
        //}
        //#endregion

        //#region yourPokeTB_PreviewKeyDownメソッド
        //private void yourPokeTB1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Return:
        //            yourPokeTB2.Focus();
        //            break;

        //        //Tabキーが押されてもフォーカスが移動しないようにする
        //        case Keys.Tab:
        //            e.IsInputKey = true;
        //            break;
        //    }
        //}

        //private void yourPokeTB2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Return:
        //            yourPokeTB3.Focus();
        //            break;

        //        //Tabキーが押されてもフォーカスが移動しないようにする
        //        case Keys.Tab:
        //            e.IsInputKey = true;
        //            break;
        //    }
        //}

        //private void yourPokeTB3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Return:
        //            yourPokeTB4.Focus();
        //            break;

        //        //Tabキーが押されてもフォーカスが移動しないようにする
        //        case Keys.Tab:
        //            e.IsInputKey = true;
        //            break;
        //    }
        //}

        //private void yourPokeTB4_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Return:
        //            yourPokeTB5.Focus();
        //            break;

        //        //Tabキーが押されてもフォーカスが移動しないようにする
        //        case Keys.Tab:
        //            e.IsInputKey = true;
        //            break;
        //    }
        //}

        //private void yourPokeTB5_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Return:
        //            yourPokeTB6.Focus();
        //            break;

        //        //Tabキーが押されてもフォーカスが移動しないようにする
        //        case Keys.Tab:
        //            e.IsInputKey = true;
        //            break;
        //    }
        //}

        //private void yourPokeTB6_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        //case Keys.Return:
        //        //    break;

        //        //Tabキーが押されてもフォーカスが移動しないようにする
        //        case Keys.Tab:
        //            e.IsInputKey = true;
        //            break;
        //    }
        //}
        //#endregion
    }
}

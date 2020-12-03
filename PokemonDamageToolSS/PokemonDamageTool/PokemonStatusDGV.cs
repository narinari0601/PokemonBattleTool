using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonDamageTool
{
    class PokemonStatusDGV
    {

        //private Button[] myPokeButtons;

        //private Button[] yourPokeButtons;

        //private Button[] myPokeElectButtons;

        //private Button[] yourPokeElectButtons;

        //private bool[] myPokeElects;

        //private bool[] yourPokeElects;

        private DataGridView myPokeStatusDGV;

        private DataGridView yourPokeStatusDGV;

        private DataGridView[] pokeStatusDGVArray;

        private Pokemon[] currentPokes;

        //-1=null 0=自分 1=相手
        private int currentGroupBoxNum;

        string[] states = new string[4];
        
        public int CurrentGroupBoxNum { get => currentGroupBoxNum; set => currentGroupBoxNum = value; }
        internal Pokemon[] CurrentPokes { get => currentPokes; set => currentPokes = value; }

        public PokemonStatusDGV(DataGridView myDGV,DataGridView yourDGV)
        {
            myPokeStatusDGV = myDGV;
            yourPokeStatusDGV = yourDGV;
        }

        public void Initialize()
        {
            currentGroupBoxNum = -1;

            currentPokes = new Pokemon[2];

            states = new string[4]
                {"種族","個体","努力","実数"};

            //中央揃え
            for (int i = 0; i < 7; i++)
            {
                myPokeStatusDGV.Columns[i].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
                myPokeStatusDGV.Columns[i].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

                yourPokeStatusDGV.Columns[i].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
                yourPokeStatusDGV.Columns[i].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            }


            for (int i = 0; i < 4; i++)
            {
                myPokeStatusDGV.Rows.Add(states[i]);
                myPokeStatusDGV.Rows[i].Height = 28;
                yourPokeStatusDGV.Rows.Add(states[i]);
                yourPokeStatusDGV.Rows[i].Height = 28;
            }

            myPokeStatusDGV.Rows[0].ReadOnly = true;
            myPokeStatusDGV.Rows[3].ReadOnly = true;
            yourPokeStatusDGV.Rows[0].ReadOnly = true;
            yourPokeStatusDGV.Rows[3].ReadOnly = true;

            myPokeStatusDGV.CellValueChanged += new DataGridViewCellEventHandler(PokeStatusDGV_CellValueChanged);

            myPokeStatusDGV.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(PokeStatusDGV_EditingControlShowing);

            myPokeStatusDGV.ImeMode = ImeMode.Disable;

            pokeStatusDGVArray = new DataGridView[2]
                {myPokeStatusDGV,yourPokeStatusDGV};
        }

        public void SetPokemonStatusDGV(Pokemon poke, int index)
        {
            currentPokes[currentGroupBoxNum] = poke;

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    var value = poke.Statuses[i - 1][j - 1].ToString();

                    pokeStatusDGVArray[index][j, i - 1].Value = value;
                }
            }

        }
        

        private void PokeStatusDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (currentGroupBoxNum==-1)
                return;

            if (currentPokes[currentGroupBoxNum] == null)
                return;



            int status = e.ColumnIndex;
            int index = e.RowIndex;
            string sValue = pokeStatusDGVArray[currentGroupBoxNum][status, index].Value.ToString();
            int value = int.Parse(sValue);

            if (value < 0)
                value = 0;

            if (value > 252)
                value = 252;

            if (pokeStatusDGVArray[currentGroupBoxNum][status, index].Selected)
            {
                currentPokes[currentGroupBoxNum].StatusUpdate(index, status - 1, value);
                ChangePokemonStatusDGV(status, index, value);
            }

        }

        private void ChangePokemonStatusDGV(int status, int index, int value)
        {
            pokeStatusDGVArray[currentGroupBoxNum][status, index].Value = value;
            pokeStatusDGVArray[currentGroupBoxNum][status, 3].Value = currentPokes[currentGroupBoxNum].RealValues[status - 1];
        }

        private void PokeStatusDGV_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //表示されているコントロールがDataGridViewTextBoxEditingControlか調べる
            if (e.Control is DataGridViewTextBoxEditingControl)
            {
                DataGridView dgv = (DataGridView)sender;

                //編集のために表示されているコントロールを取得
                DataGridViewTextBoxEditingControl tb =
                    (DataGridViewTextBoxEditingControl)e.Control;

                //イベントハンドラを削除
                tb.KeyPress -=
                    new KeyPressEventHandler(PokeStatusDGVTextBox_KeyPress);

                //該当する列か調べる
                //if (dgv.CurrentCell.OwningColumn.Name == "Column1")
                //{
                //KeyPressイベントハンドラを追加
                tb.KeyPress +=
                    new KeyPressEventHandler(PokeStatusDGVTextBox_KeyPress);
                //}
            }
        }

        private void PokeStatusDGVTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0-9の文字orバックスペースのみ
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        
    }
}

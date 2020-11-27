namespace PokemonDamageTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.powerLabel = new System.Windows.Forms.Label();
            this.damageLabel = new System.Windows.Forms.Label();
            this.sameTypeCB = new System.Windows.Forms.CheckBox();
            this.supperEffectiveCB = new System.Windows.Forms.CheckBox();
            this.notVeryEffectiveCB = new System.Windows.Forms.CheckBox();
            this.attackLabel = new System.Windows.Forms.Label();
            this.defenseLabel = new System.Windows.Forms.Label();
            this.attackPowerLabel = new System.Windows.Forms.Label();
            this.defensePowerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myPokeElectButton6 = new System.Windows.Forms.Button();
            this.myPokeElectButton5 = new System.Windows.Forms.Button();
            this.myPokeElectButton4 = new System.Windows.Forms.Button();
            this.myPokeElectButton3 = new System.Windows.Forms.Button();
            this.myPokeElectButton2 = new System.Windows.Forms.Button();
            this.myPokeElectButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.myPokeAbilityCB = new System.Windows.Forms.ComboBox();
            this.myPoke6Button = new System.Windows.Forms.Button();
            this.myPoke5Button = new System.Windows.Forms.Button();
            this.myPoke4Button = new System.Windows.Forms.Button();
            this.myPoke3Button = new System.Windows.Forms.Button();
            this.myPoke2Button = new System.Windows.Forms.Button();
            this.myPoke1Button = new System.Windows.Forms.Button();
            this.myPokeTB = new System.Windows.Forms.TextBox();
            this.attackPokeLabel = new System.Windows.Forms.Label();
            this.defensePokeLabel = new System.Windows.Forms.Label();
            this.attackPokeEVLabel = new System.Windows.Forms.Label();
            this.attackEVNumUD = new System.Windows.Forms.NumericUpDown();
            this.defenseEVNumUD = new System.Windows.Forms.NumericUpDown();
            this.myPartyGB = new System.Windows.Forms.GroupBox();
            this.myPokeStatusDGV = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackEVNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenseEVNumUD)).BeginInit();
            this.myPartyGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPokeStatusDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1073, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numericUpDown3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(1092, 194);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Location = new System.Drawing.Point(1118, 150);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(52, 15);
            this.powerLabel.TabIndex = 7;
            this.powerLabel.Text = "技威力";
            // 
            // damageLabel
            // 
            this.damageLabel.AutoSize = true;
            this.damageLabel.Location = new System.Drawing.Point(1087, 463);
            this.damageLabel.Name = "damageLabel";
            this.damageLabel.Size = new System.Drawing.Size(52, 15);
            this.damageLabel.TabIndex = 8;
            this.damageLabel.Text = "ダメージ";
            this.damageLabel.Click += new System.EventHandler(this.damageLabel_Click);
            // 
            // sameTypeCB
            // 
            this.sameTypeCB.AutoSize = true;
            this.sameTypeCB.Location = new System.Drawing.Point(973, 344);
            this.sameTypeCB.Name = "sameTypeCB";
            this.sameTypeCB.Size = new System.Drawing.Size(91, 19);
            this.sameTypeCB.TabIndex = 12;
            this.sameTypeCB.Text = "タイプ一致";
            this.sameTypeCB.UseVisualStyleBackColor = true;
            this.sameTypeCB.CheckedChanged += new System.EventHandler(this.sameTypeCB_CheckedChanged);
            // 
            // supperEffectiveCB
            // 
            this.supperEffectiveCB.AutoSize = true;
            this.supperEffectiveCB.Location = new System.Drawing.Point(1087, 344);
            this.supperEffectiveCB.Name = "supperEffectiveCB";
            this.supperEffectiveCB.Size = new System.Drawing.Size(52, 19);
            this.supperEffectiveCB.TabIndex = 13;
            this.supperEffectiveCB.Text = "2倍";
            this.supperEffectiveCB.UseVisualStyleBackColor = true;
            this.supperEffectiveCB.CheckedChanged += new System.EventHandler(this.supperEffectiveCB_CheckedChanged);
            // 
            // notVeryEffectiveCB
            // 
            this.notVeryEffectiveCB.AutoSize = true;
            this.notVeryEffectiveCB.Location = new System.Drawing.Point(1162, 344);
            this.notVeryEffectiveCB.Name = "notVeryEffectiveCB";
            this.notVeryEffectiveCB.Size = new System.Drawing.Size(68, 19);
            this.notVeryEffectiveCB.TabIndex = 14;
            this.notVeryEffectiveCB.Text = "1/2倍";
            this.notVeryEffectiveCB.UseVisualStyleBackColor = true;
            this.notVeryEffectiveCB.CheckedChanged += new System.EventHandler(this.notVeryEffectiveCB_CheckedChanged);
            // 
            // attackLabel
            // 
            this.attackLabel.AutoSize = true;
            this.attackLabel.Location = new System.Drawing.Point(723, 64);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(52, 15);
            this.attackLabel.TabIndex = 15;
            this.attackLabel.Text = "攻撃側";
            this.attackLabel.Click += new System.EventHandler(this.attackPoke_Click);
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Location = new System.Drawing.Point(960, 64);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(52, 15);
            this.defenseLabel.TabIndex = 16;
            this.defenseLabel.Text = "防御側";
            this.defenseLabel.Click += new System.EventHandler(this.defensePokeLabel_Click);
            // 
            // attackPowerLabel
            // 
            this.attackPowerLabel.AutoSize = true;
            this.attackPowerLabel.Location = new System.Drawing.Point(634, 150);
            this.attackPowerLabel.Name = "attackPowerLabel";
            this.attackPowerLabel.Size = new System.Drawing.Size(52, 15);
            this.attackPowerLabel.TabIndex = 17;
            this.attackPowerLabel.Text = "攻撃力";
            this.attackPowerLabel.Click += new System.EventHandler(this.attackPowerLabel_Click);
            // 
            // defensePowerLabel
            // 
            this.defensePowerLabel.AutoSize = true;
            this.defensePowerLabel.Location = new System.Drawing.Point(884, 157);
            this.defensePowerLabel.Name = "defensePowerLabel";
            this.defensePowerLabel.Size = new System.Drawing.Size(52, 15);
            this.defensePowerLabel.TabIndex = 18;
            this.defensePowerLabel.Text = "防御力";
            this.defensePowerLabel.Click += new System.EventHandler(this.defensePowerLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "特性";
            // 
            // myPokeElectButton6
            // 
            this.myPokeElectButton6.Location = new System.Drawing.Point(219, 104);
            this.myPokeElectButton6.Margin = new System.Windows.Forms.Padding(0);
            this.myPokeElectButton6.Name = "myPokeElectButton6";
            this.myPokeElectButton6.Size = new System.Drawing.Size(24, 24);
            this.myPokeElectButton6.TabIndex = 52;
            this.myPokeElectButton6.UseVisualStyleBackColor = true;
            this.myPokeElectButton6.Click += new System.EventHandler(this.myPokeElectButton6_Click);
            // 
            // myPokeElectButton5
            // 
            this.myPokeElectButton5.Location = new System.Drawing.Point(185, 104);
            this.myPokeElectButton5.Margin = new System.Windows.Forms.Padding(0);
            this.myPokeElectButton5.Name = "myPokeElectButton5";
            this.myPokeElectButton5.Size = new System.Drawing.Size(24, 24);
            this.myPokeElectButton5.TabIndex = 51;
            this.myPokeElectButton5.UseVisualStyleBackColor = true;
            this.myPokeElectButton5.Click += new System.EventHandler(this.myPokeElectButton5_Click);
            // 
            // myPokeElectButton4
            // 
            this.myPokeElectButton4.Location = new System.Drawing.Point(151, 104);
            this.myPokeElectButton4.Margin = new System.Windows.Forms.Padding(0);
            this.myPokeElectButton4.Name = "myPokeElectButton4";
            this.myPokeElectButton4.Size = new System.Drawing.Size(24, 24);
            this.myPokeElectButton4.TabIndex = 50;
            this.myPokeElectButton4.UseVisualStyleBackColor = true;
            this.myPokeElectButton4.Click += new System.EventHandler(this.myPokeElectButton4_Click);
            // 
            // myPokeElectButton3
            // 
            this.myPokeElectButton3.Location = new System.Drawing.Point(117, 104);
            this.myPokeElectButton3.Margin = new System.Windows.Forms.Padding(0);
            this.myPokeElectButton3.Name = "myPokeElectButton3";
            this.myPokeElectButton3.Size = new System.Drawing.Size(24, 24);
            this.myPokeElectButton3.TabIndex = 49;
            this.myPokeElectButton3.UseVisualStyleBackColor = true;
            this.myPokeElectButton3.Click += new System.EventHandler(this.myPokeElectButton3_Click);
            // 
            // myPokeElectButton2
            // 
            this.myPokeElectButton2.Location = new System.Drawing.Point(87, 104);
            this.myPokeElectButton2.Margin = new System.Windows.Forms.Padding(0);
            this.myPokeElectButton2.Name = "myPokeElectButton2";
            this.myPokeElectButton2.Size = new System.Drawing.Size(24, 24);
            this.myPokeElectButton2.TabIndex = 48;
            this.myPokeElectButton2.UseVisualStyleBackColor = true;
            this.myPokeElectButton2.Click += new System.EventHandler(this.myPokeElectButton2_Click);
            // 
            // myPokeElectButton1
            // 
            this.myPokeElectButton1.Location = new System.Drawing.Point(54, 104);
            this.myPokeElectButton1.Margin = new System.Windows.Forms.Padding(0);
            this.myPokeElectButton1.Name = "myPokeElectButton1";
            this.myPokeElectButton1.Size = new System.Drawing.Size(24, 24);
            this.myPokeElectButton1.TabIndex = 47;
            this.myPokeElectButton1.UseVisualStyleBackColor = true;
            this.myPokeElectButton1.Click += new System.EventHandler(this.myPokeElectButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "選出";
            // 
            // myPokeAbilityCB
            // 
            this.myPokeAbilityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myPokeAbilityCB.FormattingEnabled = true;
            this.myPokeAbilityCB.Location = new System.Drawing.Point(78, 160);
            this.myPokeAbilityCB.Name = "myPokeAbilityCB";
            this.myPokeAbilityCB.Size = new System.Drawing.Size(131, 23);
            this.myPokeAbilityCB.TabIndex = 45;
            this.myPokeAbilityCB.SelectedIndexChanged += new System.EventHandler(this.myPokeAbility_SelectedIndexChanged);
            // 
            // myPoke6Button
            // 
            this.myPoke6Button.Location = new System.Drawing.Point(219, 64);
            this.myPoke6Button.Margin = new System.Windows.Forms.Padding(1);
            this.myPoke6Button.Name = "myPoke6Button";
            this.myPoke6Button.Size = new System.Drawing.Size(32, 32);
            this.myPoke6Button.TabIndex = 44;
            this.myPoke6Button.UseVisualStyleBackColor = true;
            this.myPoke6Button.Click += new System.EventHandler(this.myPoke6Button_Click);
            // 
            // myPoke5Button
            // 
            this.myPoke5Button.Location = new System.Drawing.Point(185, 64);
            this.myPoke5Button.Margin = new System.Windows.Forms.Padding(1);
            this.myPoke5Button.Name = "myPoke5Button";
            this.myPoke5Button.Size = new System.Drawing.Size(32, 32);
            this.myPoke5Button.TabIndex = 43;
            this.myPoke5Button.UseVisualStyleBackColor = true;
            this.myPoke5Button.Click += new System.EventHandler(this.myPoke5Button_Click);
            // 
            // myPoke4Button
            // 
            this.myPoke4Button.Location = new System.Drawing.Point(151, 64);
            this.myPoke4Button.Margin = new System.Windows.Forms.Padding(1);
            this.myPoke4Button.Name = "myPoke4Button";
            this.myPoke4Button.Size = new System.Drawing.Size(32, 32);
            this.myPoke4Button.TabIndex = 42;
            this.myPoke4Button.UseVisualStyleBackColor = true;
            this.myPoke4Button.Click += new System.EventHandler(this.myPoke4Button_Click);
            // 
            // myPoke3Button
            // 
            this.myPoke3Button.Location = new System.Drawing.Point(117, 64);
            this.myPoke3Button.Margin = new System.Windows.Forms.Padding(1);
            this.myPoke3Button.Name = "myPoke3Button";
            this.myPoke3Button.Size = new System.Drawing.Size(32, 32);
            this.myPoke3Button.TabIndex = 41;
            this.myPoke3Button.UseVisualStyleBackColor = true;
            this.myPoke3Button.Click += new System.EventHandler(this.myPoke3Button_Click);
            // 
            // myPoke2Button
            // 
            this.myPoke2Button.Location = new System.Drawing.Point(83, 64);
            this.myPoke2Button.Margin = new System.Windows.Forms.Padding(1);
            this.myPoke2Button.Name = "myPoke2Button";
            this.myPoke2Button.Size = new System.Drawing.Size(32, 32);
            this.myPoke2Button.TabIndex = 40;
            this.myPoke2Button.UseVisualStyleBackColor = true;
            this.myPoke2Button.Click += new System.EventHandler(this.myPoke2Button_Click);
            // 
            // myPoke1Button
            // 
            this.myPoke1Button.Location = new System.Drawing.Point(49, 64);
            this.myPoke1Button.Margin = new System.Windows.Forms.Padding(1);
            this.myPoke1Button.Name = "myPoke1Button";
            this.myPoke1Button.Size = new System.Drawing.Size(32, 32);
            this.myPoke1Button.TabIndex = 39;
            this.myPoke1Button.UseVisualStyleBackColor = true;
            this.myPoke1Button.Click += new System.EventHandler(this.myPoke1Button_Click);
            // 
            // myPokeTB
            // 
            this.myPokeTB.Location = new System.Drawing.Point(87, 25);
            this.myPokeTB.Name = "myPokeTB";
            this.myPokeTB.Size = new System.Drawing.Size(100, 22);
            this.myPokeTB.TabIndex = 22;
            this.myPokeTB.TextChanged += new System.EventHandler(this.myPokeTB_TextChanged);
            // 
            // attackPokeLabel
            // 
            this.attackPokeLabel.AutoSize = true;
            this.attackPokeLabel.Location = new System.Drawing.Point(719, 108);
            this.attackPokeLabel.Name = "attackPokeLabel";
            this.attackPokeLabel.Size = new System.Drawing.Size(68, 15);
            this.attackPokeLabel.TabIndex = 24;
            this.attackPokeLabel.Text = "ポケモン名";
            this.attackPokeLabel.Click += new System.EventHandler(this.attackPokeLabel_Click);
            // 
            // defensePokeLabel
            // 
            this.defensePokeLabel.AutoSize = true;
            this.defensePokeLabel.Location = new System.Drawing.Point(952, 108);
            this.defensePokeLabel.Name = "defensePokeLabel";
            this.defensePokeLabel.Size = new System.Drawing.Size(68, 15);
            this.defensePokeLabel.TabIndex = 25;
            this.defensePokeLabel.Text = "ポケモン名";
            this.defensePokeLabel.Click += new System.EventHandler(this.defensePokeLabel_Click_1);
            // 
            // attackPokeEVLabel
            // 
            this.attackPokeEVLabel.AutoSize = true;
            this.attackPokeEVLabel.Location = new System.Drawing.Point(634, 194);
            this.attackPokeEVLabel.Name = "attackPokeEVLabel";
            this.attackPokeEVLabel.Size = new System.Drawing.Size(52, 15);
            this.attackPokeEVLabel.TabIndex = 26;
            this.attackPokeEVLabel.Text = "努力値";
            // 
            // attackEVNumUD
            // 
            this.attackEVNumUD.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.attackEVNumUD.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.attackEVNumUD.Location = new System.Drawing.Point(714, 192);
            this.attackEVNumUD.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.attackEVNumUD.Name = "attackEVNumUD";
            this.attackEVNumUD.Size = new System.Drawing.Size(73, 22);
            this.attackEVNumUD.TabIndex = 27;
            this.attackEVNumUD.ValueChanged += new System.EventHandler(this.attackEVNumUD_ValueChanged);
            // 
            // defenseEVNumUD
            // 
            this.defenseEVNumUD.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.defenseEVNumUD.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.defenseEVNumUD.Location = new System.Drawing.Point(947, 192);
            this.defenseEVNumUD.Maximum = new decimal(new int[] {
            252,
            0,
            0,
            0});
            this.defenseEVNumUD.Name = "defenseEVNumUD";
            this.defenseEVNumUD.Size = new System.Drawing.Size(73, 22);
            this.defenseEVNumUD.TabIndex = 28;
            this.defenseEVNumUD.ValueChanged += new System.EventHandler(this.defenseEVNumUD_ValueChanged);
            // 
            // myPartyGB
            // 
            this.myPartyGB.Controls.Add(this.label2);
            this.myPartyGB.Controls.Add(this.myPokeStatusDGV);
            this.myPartyGB.Controls.Add(this.myPokeElectButton6);
            this.myPartyGB.Controls.Add(this.myPokeElectButton5);
            this.myPartyGB.Controls.Add(this.myPokeElectButton4);
            this.myPartyGB.Controls.Add(this.myPokeElectButton3);
            this.myPartyGB.Controls.Add(this.myPokeElectButton2);
            this.myPartyGB.Controls.Add(this.myPokeElectButton1);
            this.myPartyGB.Controls.Add(this.label1);
            this.myPartyGB.Controls.Add(this.myPokeAbilityCB);
            this.myPartyGB.Controls.Add(this.myPoke6Button);
            this.myPartyGB.Controls.Add(this.myPoke5Button);
            this.myPartyGB.Controls.Add(this.myPoke4Button);
            this.myPartyGB.Controls.Add(this.myPoke3Button);
            this.myPartyGB.Controls.Add(this.myPoke2Button);
            this.myPartyGB.Controls.Add(this.myPoke1Button);
            this.myPartyGB.Controls.Add(this.myPokeTB);
            this.myPartyGB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myPartyGB.Location = new System.Drawing.Point(27, 76);
            this.myPartyGB.Name = "myPartyGB";
            this.myPartyGB.Size = new System.Drawing.Size(333, 565);
            this.myPartyGB.TabIndex = 22;
            this.myPartyGB.TabStop = false;
            this.myPartyGB.Text = "自分パーティ";
            this.myPartyGB.Enter += new System.EventHandler(this.myPartyGB_Enter);
            // 
            // myPokeStatusDGV
            // 
            this.myPokeStatusDGV.AllowUserToAddRows = false;
            this.myPokeStatusDGV.AllowUserToResizeColumns = false;
            this.myPokeStatusDGV.AllowUserToResizeRows = false;
            this.myPokeStatusDGV.ColumnHeadersHeight = 30;
            this.myPokeStatusDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.myH,
            this.myA,
            this.myB,
            this.myC,
            this.myD,
            this.myS});
            this.myPokeStatusDGV.Location = new System.Drawing.Point(9, 258);
            this.myPokeStatusDGV.Name = "myPokeStatusDGV";
            this.myPokeStatusDGV.RowHeadersVisible = false;
            this.myPokeStatusDGV.RowTemplate.Height = 24;
            this.myPokeStatusDGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.myPokeStatusDGV.Size = new System.Drawing.Size(310, 144);
            this.myPokeStatusDGV.TabIndex = 70;
            this.myPokeStatusDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column0
            // 
            this.Column0.Frozen = true;
            this.Column0.HeaderText = "";
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            this.Column0.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column0.Width = 44;
            // 
            // myH
            // 
            this.myH.HeaderText = "H";
            this.myH.Name = "myH";
            this.myH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.myH.Width = 44;
            // 
            // myA
            // 
            this.myA.HeaderText = "A";
            this.myA.Name = "myA";
            this.myA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.myA.Width = 44;
            // 
            // myB
            // 
            this.myB.HeaderText = "B";
            this.myB.Name = "myB";
            this.myB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.myB.Width = 44;
            // 
            // myC
            // 
            this.myC.HeaderText = "C";
            this.myC.Name = "myC";
            this.myC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.myC.Width = 44;
            // 
            // myD
            // 
            this.myD.HeaderText = "D";
            this.myD.Name = "myD";
            this.myD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.myD.Width = 44;
            // 
            // myS
            // 
            this.myS.HeaderText = "S";
            this.myS.Name = "myS";
            this.myS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.myS.Width = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.defenseEVNumUD);
            this.Controls.Add(this.attackEVNumUD);
            this.Controls.Add(this.attackPokeEVLabel);
            this.Controls.Add(this.defensePokeLabel);
            this.Controls.Add(this.attackPokeLabel);
            this.Controls.Add(this.myPartyGB);
            this.Controls.Add(this.defensePowerLabel);
            this.Controls.Add(this.attackPowerLabel);
            this.Controls.Add(this.defenseLabel);
            this.Controls.Add(this.attackLabel);
            this.Controls.Add(this.notVeryEffectiveCB);
            this.Controls.Add(this.supperEffectiveCB);
            this.Controls.Add(this.sameTypeCB);
            this.Controls.Add(this.damageLabel);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackEVNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenseEVNumUD)).EndInit();
            this.myPartyGB.ResumeLayout(false);
            this.myPartyGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPokeStatusDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label damageLabel;
        private System.Windows.Forms.CheckBox sameTypeCB;
        private System.Windows.Forms.CheckBox supperEffectiveCB;
        private System.Windows.Forms.CheckBox notVeryEffectiveCB;
        private System.Windows.Forms.Label attackLabel;
        private System.Windows.Forms.Label defenseLabel;
        private System.Windows.Forms.Label attackPowerLabel;
        private System.Windows.Forms.Label defensePowerLabel;
        private System.Windows.Forms.TextBox myPokeTB;
        private System.Windows.Forms.Label attackPokeLabel;
        private System.Windows.Forms.Label defensePokeLabel;
        private System.Windows.Forms.Label attackPokeEVLabel;
        private System.Windows.Forms.NumericUpDown attackEVNumUD;
        private System.Windows.Forms.NumericUpDown defenseEVNumUD;
        private System.Windows.Forms.Button myPoke1Button;
        private System.Windows.Forms.Button myPoke6Button;
        private System.Windows.Forms.Button myPoke5Button;
        private System.Windows.Forms.Button myPoke4Button;
        private System.Windows.Forms.Button myPoke3Button;
        private System.Windows.Forms.Button myPoke2Button;
        private System.Windows.Forms.Button myPokeElectButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox myPokeAbilityCB;
        private System.Windows.Forms.Button myPokeElectButton6;
        private System.Windows.Forms.Button myPokeElectButton5;
        private System.Windows.Forms.Button myPokeElectButton4;
        private System.Windows.Forms.Button myPokeElectButton3;
        private System.Windows.Forms.Button myPokeElectButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox myPartyGB;
        private System.Windows.Forms.DataGridView myPokeStatusDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn myH;
        private System.Windows.Forms.DataGridViewTextBoxColumn myA;
        private System.Windows.Forms.DataGridViewTextBoxColumn myB;
        private System.Windows.Forms.DataGridViewTextBoxColumn myC;
        private System.Windows.Forms.DataGridViewTextBoxColumn myD;
        private System.Windows.Forms.DataGridViewTextBoxColumn myS;
    }
}


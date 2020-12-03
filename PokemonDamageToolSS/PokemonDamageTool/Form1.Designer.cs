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
            this.myPokeButton6 = new System.Windows.Forms.Button();
            this.myPokeButton5 = new System.Windows.Forms.Button();
            this.myPokeButton4 = new System.Windows.Forms.Button();
            this.myPokeButton3 = new System.Windows.Forms.Button();
            this.myPokeButton2 = new System.Windows.Forms.Button();
            this.myPokeButton1 = new System.Windows.Forms.Button();
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
            this.yourPartyGB = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yourPokeStatusDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yourPokeElectButton6 = new System.Windows.Forms.Button();
            this.yourPokeElectButton5 = new System.Windows.Forms.Button();
            this.yourPokeElectButton4 = new System.Windows.Forms.Button();
            this.yourPokeElectButton3 = new System.Windows.Forms.Button();
            this.yourPokeElectButton2 = new System.Windows.Forms.Button();
            this.yourPokeElectButton1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.yourPokeAbilityCB = new System.Windows.Forms.ComboBox();
            this.yourPokeButton6 = new System.Windows.Forms.Button();
            this.yourPokeButton5 = new System.Windows.Forms.Button();
            this.yourPokeButton4 = new System.Windows.Forms.Button();
            this.yourPokeButton3 = new System.Windows.Forms.Button();
            this.yourPokeButton2 = new System.Windows.Forms.Button();
            this.yourPokeButton1 = new System.Windows.Forms.Button();
            this.yourPokeTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackEVNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenseEVNumUD)).BeginInit();
            this.myPartyGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPokeStatusDGV)).BeginInit();
            this.yourPartyGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yourPokeStatusDGV)).BeginInit();
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
            this.numericUpDown3.Location = new System.Drawing.Point(839, 494);
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
            this.powerLabel.Location = new System.Drawing.Point(865, 450);
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
            // 
            // attackLabel
            // 
            this.attackLabel.AutoSize = true;
            this.attackLabel.Location = new System.Drawing.Point(907, 76);
            this.attackLabel.Name = "attackLabel";
            this.attackLabel.Size = new System.Drawing.Size(52, 15);
            this.attackLabel.TabIndex = 15;
            this.attackLabel.Text = "攻撃側";
            // 
            // defenseLabel
            // 
            this.defenseLabel.AutoSize = true;
            this.defenseLabel.Location = new System.Drawing.Point(1144, 76);
            this.defenseLabel.Name = "defenseLabel";
            this.defenseLabel.Size = new System.Drawing.Size(52, 15);
            this.defenseLabel.TabIndex = 16;
            this.defenseLabel.Text = "防御側";
            // 
            // attackPowerLabel
            // 
            this.attackPowerLabel.AutoSize = true;
            this.attackPowerLabel.Location = new System.Drawing.Point(818, 162);
            this.attackPowerLabel.Name = "attackPowerLabel";
            this.attackPowerLabel.Size = new System.Drawing.Size(52, 15);
            this.attackPowerLabel.TabIndex = 17;
            this.attackPowerLabel.Text = "攻撃力";
            // 
            // defensePowerLabel
            // 
            this.defensePowerLabel.AutoSize = true;
            this.defensePowerLabel.Location = new System.Drawing.Point(1068, 169);
            this.defensePowerLabel.Name = "defensePowerLabel";
            this.defensePowerLabel.Size = new System.Drawing.Size(52, 15);
            this.defensePowerLabel.TabIndex = 18;
            this.defensePowerLabel.Text = "防御力";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 184);
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
            // 
            // myPokeElectButton5
            // 
            this.myPokeElectButton5.Location = new System.Drawing.Point(185, 104);
            this.myPokeElectButton5.Margin = new System.Windows.Forms.Padding(0);
            this.myPokeElectButton5.Name = "myPokeElectButton5";
            this.myPokeElectButton5.Size = new System.Drawing.Size(24, 24);
            this.myPokeElectButton5.TabIndex = 51;
            this.myPokeElectButton5.UseVisualStyleBackColor = true;
            // 
            // myPokeElectButton4
            // 
            this.myPokeElectButton4.Location = new System.Drawing.Point(151, 104);
            this.myPokeElectButton4.Margin = new System.Windows.Forms.Padding(0);
            this.myPokeElectButton4.Name = "myPokeElectButton4";
            this.myPokeElectButton4.Size = new System.Drawing.Size(24, 24);
            this.myPokeElectButton4.TabIndex = 50;
            this.myPokeElectButton4.UseVisualStyleBackColor = true;
            // 
            // myPokeElectButton3
            // 
            this.myPokeElectButton3.Location = new System.Drawing.Point(117, 104);
            this.myPokeElectButton3.Margin = new System.Windows.Forms.Padding(0);
            this.myPokeElectButton3.Name = "myPokeElectButton3";
            this.myPokeElectButton3.Size = new System.Drawing.Size(24, 24);
            this.myPokeElectButton3.TabIndex = 49;
            this.myPokeElectButton3.UseVisualStyleBackColor = true;
            // 
            // myPokeElectButton2
            // 
            this.myPokeElectButton2.Location = new System.Drawing.Point(87, 104);
            this.myPokeElectButton2.Margin = new System.Windows.Forms.Padding(0);
            this.myPokeElectButton2.Name = "myPokeElectButton2";
            this.myPokeElectButton2.Size = new System.Drawing.Size(24, 24);
            this.myPokeElectButton2.TabIndex = 48;
            this.myPokeElectButton2.UseVisualStyleBackColor = true;
            // 
            // myPokeElectButton1
            // 
            this.myPokeElectButton1.Location = new System.Drawing.Point(54, 104);
            this.myPokeElectButton1.Margin = new System.Windows.Forms.Padding(0);
            this.myPokeElectButton1.Name = "myPokeElectButton1";
            this.myPokeElectButton1.Size = new System.Drawing.Size(24, 24);
            this.myPokeElectButton1.TabIndex = 47;
            this.myPokeElectButton1.UseVisualStyleBackColor = true;
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
            this.myPokeAbilityCB.Location = new System.Drawing.Point(87, 181);
            this.myPokeAbilityCB.Name = "myPokeAbilityCB";
            this.myPokeAbilityCB.Size = new System.Drawing.Size(131, 23);
            this.myPokeAbilityCB.TabIndex = 45;
            this.myPokeAbilityCB.SelectedIndexChanged += new System.EventHandler(this.myPokeAbility_SelectedIndexChanged);
            // 
            // myPokeButton6
            // 
            this.myPokeButton6.Location = new System.Drawing.Point(219, 64);
            this.myPokeButton6.Margin = new System.Windows.Forms.Padding(1);
            this.myPokeButton6.Name = "myPokeButton6";
            this.myPokeButton6.Size = new System.Drawing.Size(32, 32);
            this.myPokeButton6.TabIndex = 44;
            this.myPokeButton6.UseVisualStyleBackColor = true;
            // 
            // myPokeButton5
            // 
            this.myPokeButton5.Location = new System.Drawing.Point(185, 64);
            this.myPokeButton5.Margin = new System.Windows.Forms.Padding(1);
            this.myPokeButton5.Name = "myPokeButton5";
            this.myPokeButton5.Size = new System.Drawing.Size(32, 32);
            this.myPokeButton5.TabIndex = 43;
            this.myPokeButton5.UseVisualStyleBackColor = true;
            // 
            // myPokeButton4
            // 
            this.myPokeButton4.Location = new System.Drawing.Point(151, 64);
            this.myPokeButton4.Margin = new System.Windows.Forms.Padding(1);
            this.myPokeButton4.Name = "myPokeButton4";
            this.myPokeButton4.Size = new System.Drawing.Size(32, 32);
            this.myPokeButton4.TabIndex = 42;
            this.myPokeButton4.UseVisualStyleBackColor = true;
            // 
            // myPokeButton3
            // 
            this.myPokeButton3.Location = new System.Drawing.Point(117, 64);
            this.myPokeButton3.Margin = new System.Windows.Forms.Padding(1);
            this.myPokeButton3.Name = "myPokeButton3";
            this.myPokeButton3.Size = new System.Drawing.Size(32, 32);
            this.myPokeButton3.TabIndex = 41;
            this.myPokeButton3.UseVisualStyleBackColor = true;
            // 
            // myPokeButton2
            // 
            this.myPokeButton2.Location = new System.Drawing.Point(83, 64);
            this.myPokeButton2.Margin = new System.Windows.Forms.Padding(1);
            this.myPokeButton2.Name = "myPokeButton2";
            this.myPokeButton2.Size = new System.Drawing.Size(32, 32);
            this.myPokeButton2.TabIndex = 40;
            this.myPokeButton2.UseVisualStyleBackColor = true;
            // 
            // myPokeButton1
            // 
            this.myPokeButton1.Location = new System.Drawing.Point(49, 64);
            this.myPokeButton1.Margin = new System.Windows.Forms.Padding(1);
            this.myPokeButton1.Name = "myPokeButton1";
            this.myPokeButton1.Size = new System.Drawing.Size(32, 32);
            this.myPokeButton1.TabIndex = 39;
            this.myPokeButton1.UseVisualStyleBackColor = true;
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
            this.attackPokeLabel.Location = new System.Drawing.Point(903, 120);
            this.attackPokeLabel.Name = "attackPokeLabel";
            this.attackPokeLabel.Size = new System.Drawing.Size(68, 15);
            this.attackPokeLabel.TabIndex = 24;
            this.attackPokeLabel.Text = "ポケモン名";
            // 
            // defensePokeLabel
            // 
            this.defensePokeLabel.AutoSize = true;
            this.defensePokeLabel.Location = new System.Drawing.Point(1136, 120);
            this.defensePokeLabel.Name = "defensePokeLabel";
            this.defensePokeLabel.Size = new System.Drawing.Size(68, 15);
            this.defensePokeLabel.TabIndex = 25;
            this.defensePokeLabel.Text = "ポケモン名";
            // 
            // attackPokeEVLabel
            // 
            this.attackPokeEVLabel.AutoSize = true;
            this.attackPokeEVLabel.Location = new System.Drawing.Point(818, 206);
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
            this.attackEVNumUD.Location = new System.Drawing.Point(898, 204);
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
            this.defenseEVNumUD.Location = new System.Drawing.Point(1131, 204);
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
            this.myPartyGB.Controls.Add(this.myPokeButton6);
            this.myPartyGB.Controls.Add(this.myPokeButton5);
            this.myPartyGB.Controls.Add(this.myPokeButton4);
            this.myPartyGB.Controls.Add(this.myPokeButton3);
            this.myPartyGB.Controls.Add(this.myPokeButton2);
            this.myPartyGB.Controls.Add(this.myPokeButton1);
            this.myPartyGB.Controls.Add(this.myPokeTB);
            this.myPartyGB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myPartyGB.Location = new System.Drawing.Point(42, 95);
            this.myPartyGB.Name = "myPartyGB";
            this.myPartyGB.Size = new System.Drawing.Size(333, 498);
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
            this.myPokeStatusDGV.Location = new System.Drawing.Point(6, 324);
            this.myPokeStatusDGV.Name = "myPokeStatusDGV";
            this.myPokeStatusDGV.RowHeadersVisible = false;
            this.myPokeStatusDGV.RowTemplate.Height = 24;
            this.myPokeStatusDGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.myPokeStatusDGV.Size = new System.Drawing.Size(310, 144);
            this.myPokeStatusDGV.TabIndex = 70;
            this.myPokeStatusDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myPokeStatusDGV_CellContentClick);
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
            // yourPartyGB
            // 
            this.yourPartyGB.Controls.Add(this.label3);
            this.yourPartyGB.Controls.Add(this.yourPokeStatusDGV);
            this.yourPartyGB.Controls.Add(this.yourPokeElectButton6);
            this.yourPartyGB.Controls.Add(this.yourPokeElectButton5);
            this.yourPartyGB.Controls.Add(this.yourPokeElectButton4);
            this.yourPartyGB.Controls.Add(this.yourPokeElectButton3);
            this.yourPartyGB.Controls.Add(this.yourPokeElectButton2);
            this.yourPartyGB.Controls.Add(this.yourPokeElectButton1);
            this.yourPartyGB.Controls.Add(this.label4);
            this.yourPartyGB.Controls.Add(this.yourPokeAbilityCB);
            this.yourPartyGB.Controls.Add(this.yourPokeButton6);
            this.yourPartyGB.Controls.Add(this.yourPokeButton5);
            this.yourPartyGB.Controls.Add(this.yourPokeButton4);
            this.yourPartyGB.Controls.Add(this.yourPokeButton3);
            this.yourPartyGB.Controls.Add(this.yourPokeButton2);
            this.yourPartyGB.Controls.Add(this.yourPokeButton1);
            this.yourPartyGB.Controls.Add(this.yourPokeTB);
            this.yourPartyGB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yourPartyGB.Location = new System.Drawing.Point(418, 95);
            this.yourPartyGB.Name = "yourPartyGB";
            this.yourPartyGB.Size = new System.Drawing.Size(333, 498);
            this.yourPartyGB.TabIndex = 29;
            this.yourPartyGB.TabStop = false;
            this.yourPartyGB.Text = "相手パーティ";
            this.yourPartyGB.Enter += new System.EventHandler(this.yourPartyGB_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "特性";
            // 
            // yourPokeStatusDGV
            // 
            this.yourPokeStatusDGV.AllowUserToAddRows = false;
            this.yourPokeStatusDGV.AllowUserToResizeColumns = false;
            this.yourPokeStatusDGV.AllowUserToResizeRows = false;
            this.yourPokeStatusDGV.ColumnHeadersHeight = 30;
            this.yourPokeStatusDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.yourPokeStatusDGV.Location = new System.Drawing.Point(6, 324);
            this.yourPokeStatusDGV.Name = "yourPokeStatusDGV";
            this.yourPokeStatusDGV.RowHeadersVisible = false;
            this.yourPokeStatusDGV.RowTemplate.Height = 24;
            this.yourPokeStatusDGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.yourPokeStatusDGV.Size = new System.Drawing.Size(310, 144);
            this.yourPokeStatusDGV.TabIndex = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 44;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "H";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 44;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "A";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 44;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "B";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 44;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "C";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 44;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "D";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 44;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "S";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 44;
            // 
            // yourPokeElectButton6
            // 
            this.yourPokeElectButton6.Location = new System.Drawing.Point(219, 104);
            this.yourPokeElectButton6.Margin = new System.Windows.Forms.Padding(0);
            this.yourPokeElectButton6.Name = "yourPokeElectButton6";
            this.yourPokeElectButton6.Size = new System.Drawing.Size(24, 24);
            this.yourPokeElectButton6.TabIndex = 52;
            this.yourPokeElectButton6.UseVisualStyleBackColor = true;
            // 
            // yourPokeElectButton5
            // 
            this.yourPokeElectButton5.Location = new System.Drawing.Point(185, 104);
            this.yourPokeElectButton5.Margin = new System.Windows.Forms.Padding(0);
            this.yourPokeElectButton5.Name = "yourPokeElectButton5";
            this.yourPokeElectButton5.Size = new System.Drawing.Size(24, 24);
            this.yourPokeElectButton5.TabIndex = 51;
            this.yourPokeElectButton5.UseVisualStyleBackColor = true;
            // 
            // yourPokeElectButton4
            // 
            this.yourPokeElectButton4.Location = new System.Drawing.Point(151, 104);
            this.yourPokeElectButton4.Margin = new System.Windows.Forms.Padding(0);
            this.yourPokeElectButton4.Name = "yourPokeElectButton4";
            this.yourPokeElectButton4.Size = new System.Drawing.Size(24, 24);
            this.yourPokeElectButton4.TabIndex = 50;
            this.yourPokeElectButton4.UseVisualStyleBackColor = true;
            // 
            // yourPokeElectButton3
            // 
            this.yourPokeElectButton3.Location = new System.Drawing.Point(117, 104);
            this.yourPokeElectButton3.Margin = new System.Windows.Forms.Padding(0);
            this.yourPokeElectButton3.Name = "yourPokeElectButton3";
            this.yourPokeElectButton3.Size = new System.Drawing.Size(24, 24);
            this.yourPokeElectButton3.TabIndex = 49;
            this.yourPokeElectButton3.UseVisualStyleBackColor = true;
            // 
            // yourPokeElectButton2
            // 
            this.yourPokeElectButton2.Location = new System.Drawing.Point(87, 104);
            this.yourPokeElectButton2.Margin = new System.Windows.Forms.Padding(0);
            this.yourPokeElectButton2.Name = "yourPokeElectButton2";
            this.yourPokeElectButton2.Size = new System.Drawing.Size(24, 24);
            this.yourPokeElectButton2.TabIndex = 48;
            this.yourPokeElectButton2.UseVisualStyleBackColor = true;
            // 
            // yourPokeElectButton1
            // 
            this.yourPokeElectButton1.Location = new System.Drawing.Point(54, 104);
            this.yourPokeElectButton1.Margin = new System.Windows.Forms.Padding(0);
            this.yourPokeElectButton1.Name = "yourPokeElectButton1";
            this.yourPokeElectButton1.Size = new System.Drawing.Size(24, 24);
            this.yourPokeElectButton1.TabIndex = 47;
            this.yourPokeElectButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "選出";
            // 
            // yourPokeAbilityCB
            // 
            this.yourPokeAbilityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yourPokeAbilityCB.FormattingEnabled = true;
            this.yourPokeAbilityCB.Location = new System.Drawing.Point(87, 181);
            this.yourPokeAbilityCB.Name = "yourPokeAbilityCB";
            this.yourPokeAbilityCB.Size = new System.Drawing.Size(131, 23);
            this.yourPokeAbilityCB.TabIndex = 45;
            // 
            // yourPokeButton6
            // 
            this.yourPokeButton6.Location = new System.Drawing.Point(219, 64);
            this.yourPokeButton6.Margin = new System.Windows.Forms.Padding(1);
            this.yourPokeButton6.Name = "yourPokeButton6";
            this.yourPokeButton6.Size = new System.Drawing.Size(32, 32);
            this.yourPokeButton6.TabIndex = 44;
            this.yourPokeButton6.UseVisualStyleBackColor = true;
            // 
            // yourPokeButton5
            // 
            this.yourPokeButton5.Location = new System.Drawing.Point(185, 64);
            this.yourPokeButton5.Margin = new System.Windows.Forms.Padding(1);
            this.yourPokeButton5.Name = "yourPokeButton5";
            this.yourPokeButton5.Size = new System.Drawing.Size(32, 32);
            this.yourPokeButton5.TabIndex = 43;
            this.yourPokeButton5.UseVisualStyleBackColor = true;
            // 
            // yourPokeButton4
            // 
            this.yourPokeButton4.Location = new System.Drawing.Point(151, 64);
            this.yourPokeButton4.Margin = new System.Windows.Forms.Padding(1);
            this.yourPokeButton4.Name = "yourPokeButton4";
            this.yourPokeButton4.Size = new System.Drawing.Size(32, 32);
            this.yourPokeButton4.TabIndex = 42;
            this.yourPokeButton4.UseVisualStyleBackColor = true;
            // 
            // yourPokeButton3
            // 
            this.yourPokeButton3.Location = new System.Drawing.Point(117, 64);
            this.yourPokeButton3.Margin = new System.Windows.Forms.Padding(1);
            this.yourPokeButton3.Name = "yourPokeButton3";
            this.yourPokeButton3.Size = new System.Drawing.Size(32, 32);
            this.yourPokeButton3.TabIndex = 41;
            this.yourPokeButton3.UseVisualStyleBackColor = true;
            // 
            // yourPokeButton2
            // 
            this.yourPokeButton2.Location = new System.Drawing.Point(83, 64);
            this.yourPokeButton2.Margin = new System.Windows.Forms.Padding(1);
            this.yourPokeButton2.Name = "yourPokeButton2";
            this.yourPokeButton2.Size = new System.Drawing.Size(32, 32);
            this.yourPokeButton2.TabIndex = 40;
            this.yourPokeButton2.UseVisualStyleBackColor = true;
            // 
            // yourPokeButton1
            // 
            this.yourPokeButton1.Location = new System.Drawing.Point(49, 64);
            this.yourPokeButton1.Margin = new System.Windows.Forms.Padding(1);
            this.yourPokeButton1.Name = "yourPokeButton1";
            this.yourPokeButton1.Size = new System.Drawing.Size(32, 32);
            this.yourPokeButton1.TabIndex = 39;
            this.yourPokeButton1.UseVisualStyleBackColor = true;
            // 
            // yourPokeTB
            // 
            this.yourPokeTB.Location = new System.Drawing.Point(87, 25);
            this.yourPokeTB.Name = "yourPokeTB";
            this.yourPokeTB.Size = new System.Drawing.Size(100, 22);
            this.yourPokeTB.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.yourPartyGB);
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
            this.yourPartyGB.ResumeLayout(false);
            this.yourPartyGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yourPokeStatusDGV)).EndInit();
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
        private System.Windows.Forms.Button myPokeButton1;
        private System.Windows.Forms.Button myPokeButton6;
        private System.Windows.Forms.Button myPokeButton5;
        private System.Windows.Forms.Button myPokeButton4;
        private System.Windows.Forms.Button myPokeButton3;
        private System.Windows.Forms.Button myPokeButton2;
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
        private System.Windows.Forms.GroupBox yourPartyGB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView yourPokeStatusDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button yourPokeElectButton6;
        private System.Windows.Forms.Button yourPokeElectButton5;
        private System.Windows.Forms.Button yourPokeElectButton4;
        private System.Windows.Forms.Button yourPokeElectButton3;
        private System.Windows.Forms.Button yourPokeElectButton2;
        private System.Windows.Forms.Button yourPokeElectButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox yourPokeAbilityCB;
        private System.Windows.Forms.Button yourPokeButton6;
        private System.Windows.Forms.Button yourPokeButton5;
        private System.Windows.Forms.Button yourPokeButton4;
        private System.Windows.Forms.Button yourPokeButton3;
        private System.Windows.Forms.Button yourPokeButton2;
        private System.Windows.Forms.Button yourPokeButton1;
        private System.Windows.Forms.TextBox yourPokeTB;
    }
}


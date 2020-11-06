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
            this.attackPokeLabel = new System.Windows.Forms.Label();
            this.defensePokeLabel = new System.Windows.Forms.Label();
            this.attackPowerLabel = new System.Windows.Forms.Label();
            this.defensePowerLabel = new System.Windows.Forms.Label();
            this.attackPokeTB = new System.Windows.Forms.TextBox();
            this.defensePokeTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(977, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(266, 144);
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
            this.powerLabel.Location = new System.Drawing.Point(302, 67);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(52, 15);
            this.powerLabel.TabIndex = 7;
            this.powerLabel.Text = "技威力";
            // 
            // damageLabel
            // 
            this.damageLabel.AutoSize = true;
            this.damageLabel.Location = new System.Drawing.Point(989, 189);
            this.damageLabel.Name = "damageLabel";
            this.damageLabel.Size = new System.Drawing.Size(52, 15);
            this.damageLabel.TabIndex = 8;
            this.damageLabel.Text = "ダメージ";
            this.damageLabel.Click += new System.EventHandler(this.damageLabel_Click);
            // 
            // sameTypeCB
            // 
            this.sameTypeCB.AutoSize = true;
            this.sameTypeCB.Location = new System.Drawing.Point(128, 260);
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
            this.supperEffectiveCB.Location = new System.Drawing.Point(305, 260);
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
            this.notVeryEffectiveCB.Location = new System.Drawing.Point(499, 260);
            this.notVeryEffectiveCB.Name = "notVeryEffectiveCB";
            this.notVeryEffectiveCB.Size = new System.Drawing.Size(68, 19);
            this.notVeryEffectiveCB.TabIndex = 14;
            this.notVeryEffectiveCB.Text = "1/2倍";
            this.notVeryEffectiveCB.UseVisualStyleBackColor = true;
            this.notVeryEffectiveCB.CheckedChanged += new System.EventHandler(this.notVeryEffectiveCB_CheckedChanged);
            // 
            // attackPokeLabel
            // 
            this.attackPokeLabel.AutoSize = true;
            this.attackPokeLabel.Location = new System.Drawing.Point(97, 48);
            this.attackPokeLabel.Name = "attackPokeLabel";
            this.attackPokeLabel.Size = new System.Drawing.Size(83, 15);
            this.attackPokeLabel.TabIndex = 15;
            this.attackPokeLabel.Text = "攻撃ポケモン";
            this.attackPokeLabel.Click += new System.EventHandler(this.attackPoke_Click);
            // 
            // defensePokeLabel
            // 
            this.defensePokeLabel.AutoSize = true;
            this.defensePokeLabel.Location = new System.Drawing.Point(514, 48);
            this.defensePokeLabel.Name = "defensePokeLabel";
            this.defensePokeLabel.Size = new System.Drawing.Size(83, 15);
            this.defensePokeLabel.TabIndex = 16;
            this.defensePokeLabel.Text = "防御ポケモン";
            this.defensePokeLabel.Click += new System.EventHandler(this.defensePokeLabel_Click);
            // 
            // attackPowerLabel
            // 
            this.attackPowerLabel.AutoSize = true;
            this.attackPowerLabel.Location = new System.Drawing.Point(113, 144);
            this.attackPowerLabel.Name = "attackPowerLabel";
            this.attackPowerLabel.Size = new System.Drawing.Size(52, 15);
            this.attackPowerLabel.TabIndex = 17;
            this.attackPowerLabel.Text = "攻撃力";
            this.attackPowerLabel.Click += new System.EventHandler(this.attackPowerLabel_Click);
            // 
            // defensePowerLabel
            // 
            this.defensePowerLabel.AutoSize = true;
            this.defensePowerLabel.Location = new System.Drawing.Point(529, 146);
            this.defensePowerLabel.Name = "defensePowerLabel";
            this.defensePowerLabel.Size = new System.Drawing.Size(52, 15);
            this.defensePowerLabel.TabIndex = 18;
            this.defensePowerLabel.Text = "防御力";
            this.defensePowerLabel.Click += new System.EventHandler(this.defensePowerLabel_Click);
            // 
            // attackPokeTB
            // 
            this.attackPokeTB.Location = new System.Drawing.Point(89, 76);
            this.attackPokeTB.Name = "attackPokeTB";
            this.attackPokeTB.Size = new System.Drawing.Size(100, 22);
            this.attackPokeTB.TabIndex = 19;
            this.attackPokeTB.TextChanged += new System.EventHandler(this.attackPokeTB_TextChanged);
            // 
            // defensePokeTB
            // 
            this.defensePokeTB.Location = new System.Drawing.Point(508, 76);
            this.defensePokeTB.Name = "defensePokeTB";
            this.defensePokeTB.Size = new System.Drawing.Size(100, 22);
            this.defensePokeTB.TabIndex = 20;
            this.defensePokeTB.TextChanged += new System.EventHandler(this.defensePokeTB_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.defensePokeTB);
            this.Controls.Add(this.attackPokeTB);
            this.Controls.Add(this.defensePowerLabel);
            this.Controls.Add(this.attackPowerLabel);
            this.Controls.Add(this.defensePokeLabel);
            this.Controls.Add(this.attackPokeLabel);
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
        private System.Windows.Forms.Label attackPokeLabel;
        private System.Windows.Forms.Label defensePokeLabel;
        private System.Windows.Forms.Label attackPowerLabel;
        private System.Windows.Forms.Label defensePowerLabel;
        private System.Windows.Forms.TextBox attackPokeTB;
        private System.Windows.Forms.TextBox defensePokeTB;
    }
}


namespace Attack_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_attack = new System.Windows.Forms.Button();
            this.lbl_dmg = new System.Windows.Forms.Label();
            this.txt_lvl = new System.Windows.Forms.TextBox();
            this.txt_pwr = new System.Windows.Forms.TextBox();
            this.txt_atk = new System.Windows.Forms.TextBox();
            this.lbl_lvl = new System.Windows.Forms.Label();
            this.lbl_power = new System.Windows.Forms.Label();
            this.lbl_atk = new System.Windows.Forms.Label();
            this.lbl_def = new System.Windows.Forms.Label();
            this.txt_def = new System.Windows.Forms.TextBox();
            this.chkbox_list = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn_attack
            // 
            this.btn_attack.Location = new System.Drawing.Point(12, 204);
            this.btn_attack.Name = "btn_attack";
            this.btn_attack.Size = new System.Drawing.Size(259, 23);
            this.btn_attack.TabIndex = 0;
            this.btn_attack.Text = "Attack!";
            this.btn_attack.UseVisualStyleBackColor = true;
            this.btn_attack.Click += new System.EventHandler(this.btn_attack_Click);
            // 
            // lbl_dmg
            // 
            this.lbl_dmg.AutoSize = true;
            this.lbl_dmg.Location = new System.Drawing.Point(12, 239);
            this.lbl_dmg.Name = "lbl_dmg";
            this.lbl_dmg.Size = new System.Drawing.Size(53, 13);
            this.lbl_dmg.TabIndex = 1;
            this.lbl_dmg.Text = "Damage: ";
            // 
            // txt_lvl
            // 
            this.txt_lvl.Location = new System.Drawing.Point(69, 12);
            this.txt_lvl.Name = "txt_lvl";
            this.txt_lvl.Size = new System.Drawing.Size(100, 20);
            this.txt_lvl.TabIndex = 2;
            // 
            // txt_pwr
            // 
            this.txt_pwr.Location = new System.Drawing.Point(69, 39);
            this.txt_pwr.Name = "txt_pwr";
            this.txt_pwr.Size = new System.Drawing.Size(100, 20);
            this.txt_pwr.TabIndex = 3;
            // 
            // txt_atk
            // 
            this.txt_atk.Location = new System.Drawing.Point(69, 66);
            this.txt_atk.Name = "txt_atk";
            this.txt_atk.Size = new System.Drawing.Size(100, 20);
            this.txt_atk.TabIndex = 4;
            // 
            // lbl_lvl
            // 
            this.lbl_lvl.AutoSize = true;
            this.lbl_lvl.Location = new System.Drawing.Point(12, 12);
            this.lbl_lvl.Name = "lbl_lvl";
            this.lbl_lvl.Size = new System.Drawing.Size(36, 13);
            this.lbl_lvl.TabIndex = 5;
            this.lbl_lvl.Text = "Level:";
            // 
            // lbl_power
            // 
            this.lbl_power.AutoSize = true;
            this.lbl_power.Location = new System.Drawing.Point(12, 39);
            this.lbl_power.Name = "lbl_power";
            this.lbl_power.Size = new System.Drawing.Size(40, 13);
            this.lbl_power.TabIndex = 6;
            this.lbl_power.Text = "Power:";
            // 
            // lbl_atk
            // 
            this.lbl_atk.AutoSize = true;
            this.lbl_atk.Location = new System.Drawing.Point(12, 66);
            this.lbl_atk.Name = "lbl_atk";
            this.lbl_atk.Size = new System.Drawing.Size(41, 13);
            this.lbl_atk.TabIndex = 7;
            this.lbl_atk.Text = "Attack:";
            // 
            // lbl_def
            // 
            this.lbl_def.AutoSize = true;
            this.lbl_def.Location = new System.Drawing.Point(12, 93);
            this.lbl_def.Name = "lbl_def";
            this.lbl_def.Size = new System.Drawing.Size(53, 13);
            this.lbl_def.TabIndex = 8;
            this.lbl_def.Text = "Defense: ";
            // 
            // txt_def
            // 
            this.txt_def.Location = new System.Drawing.Point(69, 93);
            this.txt_def.Name = "txt_def";
            this.txt_def.Size = new System.Drawing.Size(100, 20);
            this.txt_def.TabIndex = 9;
            // 
            // chkbox_list
            // 
            this.chkbox_list.FormattingEnabled = true;
            this.chkbox_list.Items.AddRange(new object[] {
            "Multiple Targets",
            "Weather Effects",
            "Critical Hit",
            "STAB"});
            this.chkbox_list.Location = new System.Drawing.Point(12, 125);
            this.chkbox_list.Name = "chkbox_list";
            this.chkbox_list.Size = new System.Drawing.Size(105, 64);
            this.chkbox_list.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.chkbox_list);
            this.Controls.Add(this.txt_def);
            this.Controls.Add(this.lbl_def);
            this.Controls.Add(this.lbl_atk);
            this.Controls.Add(this.lbl_power);
            this.Controls.Add(this.lbl_lvl);
            this.Controls.Add(this.txt_atk);
            this.Controls.Add(this.txt_pwr);
            this.Controls.Add(this.txt_lvl);
            this.Controls.Add(this.lbl_dmg);
            this.Controls.Add(this.btn_attack);
            this.Name = "Form1";
            this.Text = "Attack Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_attack;
        private System.Windows.Forms.Label lbl_dmg;
        private System.Windows.Forms.TextBox txt_lvl;
        private System.Windows.Forms.TextBox txt_pwr;
        private System.Windows.Forms.TextBox txt_atk;
        private System.Windows.Forms.Label lbl_lvl;
        private System.Windows.Forms.Label lbl_power;
        private System.Windows.Forms.Label lbl_atk;
        private System.Windows.Forms.Label lbl_def;
        private System.Windows.Forms.TextBox txt_def;
        private System.Windows.Forms.CheckedListBox chkbox_list;
    }
}


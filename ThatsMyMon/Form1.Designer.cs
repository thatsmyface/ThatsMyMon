namespace ThatsMyMon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mon = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Species = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.Label();
            this.items = new System.Windows.Forms.TextBox();
            this.nick = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.TextBox();
            this.abiltiylab = new System.Windows.Forms.Label();
            this.abilitybox = new System.Windows.Forms.TextBox();
            this.move1 = new System.Windows.Forms.TextBox();
            this.move2 = new System.Windows.Forms.TextBox();
            this.move3 = new System.Windows.Forms.TextBox();
            this.move4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aIV = new System.Windows.Forms.TextBox();
            this.saIV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dIV = new System.Windows.Forms.TextBox();
            this.sdIV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spIV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.spEV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.aEV = new System.Windows.Forms.TextBox();
            this.saEV = new System.Windows.Forms.TextBox();
            this.dEV = new System.Windows.Forms.TextBox();
            this.sdEV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.totalEV = new System.Windows.Forms.TextBox();
            this.natureBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sprite = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprite)).BeginInit();
            this.SuspendLayout();
            // 
            // mon
            // 
            this.mon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.mon.Location = new System.Drawing.Point(70, 57);
            this.mon.Name = "mon";
            this.mon.Size = new System.Drawing.Size(104, 20);
            this.mon.TabIndex = 2;
            this.mon.WordWrap = false;
            this.mon.TextChanged += new System.EventHandler(this.mon_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Species
            // 
            this.Species.AutoSize = true;
            this.Species.Location = new System.Drawing.Point(19, 60);
            this.Species.Margin = new System.Windows.Forms.Padding(10);
            this.Species.Name = "Species";
            this.Species.Size = new System.Drawing.Size(31, 13);
            this.Species.TabIndex = 2;
            this.Species.Text = "Mon:";
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Location = new System.Drawing.Point(19, 86);
            this.Item.Margin = new System.Windows.Forms.Padding(10);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(30, 13);
            this.Item.TabIndex = 4;
            this.Item.Text = "Item:";
            // 
            // items
            // 
            this.items.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.items.Location = new System.Drawing.Point(70, 83);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(104, 20);
            this.items.TabIndex = 3;
            this.items.WordWrap = false;
            // 
            // nick
            // 
            this.nick.AutoSize = true;
            this.nick.Location = new System.Drawing.Point(19, 34);
            this.nick.Margin = new System.Windows.Forms.Padding(10);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(38, 13);
            this.nick.TabIndex = 6;
            this.nick.Text = "Name:";
            // 
            // nickname
            // 
            this.nickname.Location = new System.Drawing.Point(70, 31);
            this.nickname.MaxLength = 12;
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(104, 20);
            this.nickname.TabIndex = 1;
            this.nickname.WordWrap = false;
            // 
            // abiltiylab
            // 
            this.abiltiylab.AutoSize = true;
            this.abiltiylab.Location = new System.Drawing.Point(19, 112);
            this.abiltiylab.Margin = new System.Windows.Forms.Padding(10);
            this.abiltiylab.Name = "abiltiylab";
            this.abiltiylab.Size = new System.Drawing.Size(37, 13);
            this.abiltiylab.TabIndex = 8;
            this.abiltiylab.Text = "Ability:";
            // 
            // abilitybox
            // 
            this.abilitybox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.abilitybox.Location = new System.Drawing.Point(70, 109);
            this.abilitybox.Name = "abilitybox";
            this.abilitybox.Size = new System.Drawing.Size(104, 20);
            this.abilitybox.TabIndex = 4;
            this.abilitybox.WordWrap = false;
            // 
            // move1
            // 
            this.move1.Location = new System.Drawing.Point(70, 163);
            this.move1.Name = "move1";
            this.move1.Size = new System.Drawing.Size(104, 20);
            this.move1.TabIndex = 5;
            this.move1.WordWrap = false;
            // 
            // move2
            // 
            this.move2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.move2.Location = new System.Drawing.Point(70, 189);
            this.move2.Name = "move2";
            this.move2.Size = new System.Drawing.Size(104, 20);
            this.move2.TabIndex = 6;
            this.move2.WordWrap = false;
            // 
            // move3
            // 
            this.move3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.move3.Location = new System.Drawing.Point(70, 215);
            this.move3.Name = "move3";
            this.move3.Size = new System.Drawing.Size(104, 20);
            this.move3.TabIndex = 7;
            this.move3.WordWrap = false;
            // 
            // move4
            // 
            this.move4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.move4.Location = new System.Drawing.Point(70, 241);
            this.move4.Name = "move4";
            this.move4.Size = new System.Drawing.Size(104, 20);
            this.move4.TabIndex = 8;
            this.move4.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Moves";
            // 
            // aIV
            // 
            this.aIV.Location = new System.Drawing.Point(265, 50);
            this.aIV.MaxLength = 2;
            this.aIV.Name = "aIV";
            this.aIV.Size = new System.Drawing.Size(22, 20);
            this.aIV.TabIndex = 16;
            this.aIV.Text = "31";
            this.aIV.WordWrap = false;
            // 
            // saIV
            // 
            this.saIV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.saIV.Location = new System.Drawing.Point(265, 76);
            this.saIV.MaxLength = 2;
            this.saIV.Name = "saIV";
            this.saIV.Size = new System.Drawing.Size(22, 20);
            this.saIV.TabIndex = 17;
            this.saIV.Text = "31";
            this.saIV.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Def";
            // 
            // dIV
            // 
            this.dIV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dIV.Location = new System.Drawing.Point(265, 102);
            this.dIV.MaxLength = 2;
            this.dIV.Name = "dIV";
            this.dIV.Size = new System.Drawing.Size(22, 20);
            this.dIV.TabIndex = 19;
            this.dIV.Text = "31";
            this.dIV.WordWrap = false;
            // 
            // sdIV
            // 
            this.sdIV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sdIV.Location = new System.Drawing.Point(265, 128);
            this.sdIV.MaxLength = 2;
            this.sdIV.Name = "sdIV";
            this.sdIV.Size = new System.Drawing.Size(22, 20);
            this.sdIV.TabIndex = 21;
            this.sdIV.Text = "31";
            this.sdIV.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "SpAtk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Atk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "SpDef";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "IVs";
            // 
            // spIV
            // 
            this.spIV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.spIV.Location = new System.Drawing.Point(265, 153);
            this.spIV.MaxLength = 2;
            this.spIV.Name = "spIV";
            this.spIV.Size = new System.Drawing.Size(22, 20);
            this.spIV.TabIndex = 25;
            this.spIV.Text = "31";
            this.spIV.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Speed";
            // 
            // spEV
            // 
            this.spEV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.spEV.Location = new System.Drawing.Point(296, 153);
            this.spEV.MaxLength = 3;
            this.spEV.Name = "spEV";
            this.spEV.Size = new System.Drawing.Size(43, 20);
            this.spEV.TabIndex = 13;
            this.spEV.Text = "0";
            this.spEV.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(293, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "EVs";
            // 
            // aEV
            // 
            this.aEV.Location = new System.Drawing.Point(296, 50);
            this.aEV.MaxLength = 3;
            this.aEV.Name = "aEV";
            this.aEV.Size = new System.Drawing.Size(43, 20);
            this.aEV.TabIndex = 9;
            this.aEV.Text = "0";
            this.aEV.WordWrap = false;
            // 
            // saEV
            // 
            this.saEV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.saEV.Location = new System.Drawing.Point(296, 76);
            this.saEV.MaxLength = 3;
            this.saEV.Name = "saEV";
            this.saEV.Size = new System.Drawing.Size(43, 20);
            this.saEV.TabIndex = 10;
            this.saEV.Text = "0";
            this.saEV.WordWrap = false;
            // 
            // dEV
            // 
            this.dEV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dEV.Location = new System.Drawing.Point(296, 102);
            this.dEV.MaxLength = 3;
            this.dEV.Name = "dEV";
            this.dEV.Size = new System.Drawing.Size(43, 20);
            this.dEV.TabIndex = 11;
            this.dEV.Text = "0";
            this.dEV.WordWrap = false;
            // 
            // sdEV
            // 
            this.sdEV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sdEV.Location = new System.Drawing.Point(296, 128);
            this.sdEV.MaxLength = 3;
            this.sdEV.Name = "sdEV";
            this.sdEV.Size = new System.Drawing.Size(43, 20);
            this.sdEV.TabIndex = 12;
            this.sdEV.Text = "0";
            this.sdEV.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(251, 182);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Total";
            // 
            // totalEV
            // 
            this.totalEV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.totalEV.Enabled = false;
            this.totalEV.Location = new System.Drawing.Point(296, 179);
            this.totalEV.MaxLength = 3;
            this.totalEV.Name = "totalEV";
            this.totalEV.Size = new System.Drawing.Size(43, 20);
            this.totalEV.TabIndex = 14;
            this.totalEV.Text = "0";
            this.totalEV.WordWrap = false;
            // 
            // natureBox
            // 
            this.natureBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.natureBox.Location = new System.Drawing.Point(265, 219);
            this.natureBox.Name = "natureBox";
            this.natureBox.Size = new System.Drawing.Size(74, 20);
            this.natureBox.TabIndex = 15;
            this.natureBox.WordWrap = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 222);
            this.label10.Margin = new System.Windows.Forms.Padding(10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Nature:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sprite
            // 
            this.sprite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sprite.ErrorImage = null;
            this.sprite.ImageLocation = "";
            this.sprite.InitialImage = null;
            this.sprite.Location = new System.Drawing.Point(400, 60);
            this.sprite.Name = "sprite";
            this.sprite.Size = new System.Drawing.Size(140, 140);
            this.sprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sprite.TabIndex = 35;
            this.sprite.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 271);
            this.Controls.Add(this.sprite);
            this.Controls.Add(this.natureBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalEV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.spEV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.aEV);
            this.Controls.Add(this.saEV);
            this.Controls.Add(this.dEV);
            this.Controls.Add(this.sdEV);
            this.Controls.Add(this.spIV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aIV);
            this.Controls.Add(this.saIV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dIV);
            this.Controls.Add(this.sdIV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.move1);
            this.Controls.Add(this.move2);
            this.Controls.Add(this.move3);
            this.Controls.Add(this.move4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.mon);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.items);
            this.Controls.Add(this.abilitybox);
            this.Controls.Add(this.Species);
            this.Controls.Add(this.nick);
            this.Controls.Add(this.abiltiylab);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ThatsMyMon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label Species;
        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.TextBox items;
        private System.Windows.Forms.Label nick;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.Label abiltiylab;
        private System.Windows.Forms.TextBox abilitybox;
        private System.Windows.Forms.TextBox move1;
        private System.Windows.Forms.TextBox move2;
        private System.Windows.Forms.TextBox move3;
        private System.Windows.Forms.TextBox move4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aIV;
        private System.Windows.Forms.TextBox saIV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dIV;
        private System.Windows.Forms.TextBox sdIV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox spIV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox spEV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox aEV;
        private System.Windows.Forms.TextBox saEV;
        private System.Windows.Forms.TextBox dEV;
        private System.Windows.Forms.TextBox sdEV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalEV;
        private System.Windows.Forms.TextBox natureBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox sprite;
    }
}


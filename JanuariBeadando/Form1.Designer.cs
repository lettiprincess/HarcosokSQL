namespace JanuariBeadando
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
            this.label2 = new System.Windows.Forms.Label();
            this.harcosNeveTextBox = new System.Windows.Forms.TextBox();
            this.letrehozas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kepessegNeveListBox = new System.Windows.Forms.ListBox();
            this.hozzaad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kepessegekListBox = new System.Windows.Forms.ListBox();
            this.torles = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.kepessegekLeirasaTextBox = new System.Windows.Forms.TextBox();
            this.modosit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // harcosNeveTextBox
            // 
            this.harcosNeveTextBox.Location = new System.Drawing.Point(43, 24);
            this.harcosNeveTextBox.Name = "harcosNeveTextBox";
            this.harcosNeveTextBox.Size = new System.Drawing.Size(149, 20);
            this.harcosNeveTextBox.TabIndex = 2;
            // 
            // letrehozas
            // 
            this.letrehozas.Location = new System.Drawing.Point(207, 22);
            this.letrehozas.Name = "letrehozas";
            this.letrehozas.Size = new System.Drawing.Size(125, 23);
            this.letrehozas.TabIndex = 3;
            this.letrehozas.Text = "Létrehozás";
            this.letrehozas.UseVisualStyleBackColor = true;
            this.letrehozas.Click += new System.EventHandler(this.letrehozas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.harcosNeveTextBox);
            this.groupBox1.Controls.Add(this.letrehozas);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Harcos létrehozása";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.leirasTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.hozzaad);
            this.groupBox2.Controls.Add(this.kepessegNeveListBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.hasznaloComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 136);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Képesség hozzáadása";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Használó:";
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(91, 35);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(190, 21);
            this.hasznaloComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Név:";
            // 
            // kepessegNeveListBox
            // 
            this.kepessegNeveListBox.FormattingEnabled = true;
            this.kepessegNeveListBox.Location = new System.Drawing.Point(91, 78);
            this.kepessegNeveListBox.Name = "kepessegNeveListBox";
            this.kepessegNeveListBox.Size = new System.Drawing.Size(190, 17);
            this.kepessegNeveListBox.TabIndex = 3;
            // 
            // hozzaad
            // 
            this.hozzaad.Location = new System.Drawing.Point(9, 107);
            this.hozzaad.Name = "hozzaad";
            this.hozzaad.Size = new System.Drawing.Size(92, 23);
            this.hozzaad.TabIndex = 4;
            this.hozzaad.Text = "Hozzáad";
            this.hozzaad.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(295, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Leírás:";
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(298, 35);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(262, 61);
            this.leirasTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Harcosok:";
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.Location = new System.Drawing.Point(15, 242);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(130, 238);
            this.harcosokListBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(173, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Képességek:";
            // 
            // kepessegekListBox
            // 
            this.kepessegekListBox.FormattingEnabled = true;
            this.kepessegekListBox.Location = new System.Drawing.Point(176, 242);
            this.kepessegekListBox.Name = "kepessegekListBox";
            this.kepessegekListBox.Size = new System.Drawing.Size(136, 238);
            this.kepessegekListBox.TabIndex = 9;
            // 
            // torles
            // 
            this.torles.Location = new System.Drawing.Point(176, 490);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(95, 23);
            this.torles.TabIndex = 10;
            this.torles.Text = "Törlés";
            this.torles.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(332, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Képességek leírása:";
            // 
            // kepessegekLeirasaTextBox
            // 
            this.kepessegekLeirasaTextBox.Location = new System.Drawing.Point(335, 242);
            this.kepessegekLeirasaTextBox.Multiline = true;
            this.kepessegekLeirasaTextBox.Name = "kepessegekLeirasaTextBox";
            this.kepessegekLeirasaTextBox.Size = new System.Drawing.Size(256, 107);
            this.kepessegekLeirasaTextBox.TabIndex = 12;
            // 
            // modosit
            // 
            this.modosit.Location = new System.Drawing.Point(483, 356);
            this.modosit.Name = "modosit";
            this.modosit.Size = new System.Drawing.Size(108, 23);
            this.modosit.TabIndex = 13;
            this.modosit.Text = "Módosít";
            this.modosit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 525);
            this.Controls.Add(this.modosit);
            this.Controls.Add(this.kepessegekLeirasaTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.torles);
            this.Controls.Add(this.kepessegekListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.harcosokListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox harcosNeveTextBox;
        private System.Windows.Forms.Button letrehozas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hozzaad;
        private System.Windows.Forms.ListBox kepessegNeveListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox harcosokListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox kepessegekListBox;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kepessegekLeirasaTextBox;
        private System.Windows.Forms.Button modosit;
    }
}


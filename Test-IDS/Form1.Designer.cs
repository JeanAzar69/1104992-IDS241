namespace Test_IDS
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.lbl_nced = new System.Windows.Forms.Label();
            this.lbl_lnac = new System.Windows.Forms.Label();
            this.txt_lnac = new System.Windows.Forms.TextBox();
            this.lbl_fnac = new System.Windows.Forms.Label();
            this.txt_fnac = new System.Windows.Forms.TextBox();
            this.lbl_nac = new System.Windows.Forms.Label();
            this.txt_nac = new System.Windows.Forms.TextBox();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_sangre = new System.Windows.Forms.Label();
            this.lbl_eciv = new System.Windows.Forms.Label();
            this.lbl_ocu = new System.Windows.Forms.Label();
            this.txt_ocu = new System.Windows.Forms.TextBox();
            this.lbl_femi = new System.Windows.Forms.Label();
            this.txt_fde = new System.Windows.Forms.TextBox();
            this.Datashow = new System.Windows.Forms.DataGridView();
            this.numID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ldn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gndr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnS = new System.Windows.Forms.Button();
            this.txt_sex = new System.Windows.Forms.TextBox();
            this.txt_sangre = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.lst_sx = new System.Windows.Forms.ComboBox();
            this.lst_s = new System.Windows.Forms.ComboBox();
            this.lst_ec = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Datashow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(20, 137);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(263, 26);
            this.txtID.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Apercu Pro", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(236)))));
            this.Titulo.Location = new System.Drawing.Point(12, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(193, 48);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Identifier";
            // 
            // lbl_nced
            // 
            this.lbl_nced.AutoSize = true;
            this.lbl_nced.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nced.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(236)))));
            this.lbl_nced.Location = new System.Drawing.Point(15, 105);
            this.lbl_nced.Name = "lbl_nced";
            this.lbl_nced.Size = new System.Drawing.Size(216, 29);
            this.lbl_nced.TabIndex = 2;
            this.lbl_nced.Text = "Numero de Cedula";
            // 
            // lbl_lnac
            // 
            this.lbl_lnac.AutoSize = true;
            this.lbl_lnac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lnac.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lnac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(236)))));
            this.lbl_lnac.Location = new System.Drawing.Point(15, 166);
            this.lbl_lnac.Name = "lbl_lnac";
            this.lbl_lnac.Size = new System.Drawing.Size(238, 29);
            this.lbl_lnac.TabIndex = 3;
            this.lbl_lnac.Text = "Lugar de Nacimiento";
            // 
            // txt_lnac
            // 
            this.txt_lnac.Location = new System.Drawing.Point(20, 198);
            this.txt_lnac.Name = "txt_lnac";
            this.txt_lnac.Size = new System.Drawing.Size(263, 26);
            this.txt_lnac.TabIndex = 4;
            // 
            // lbl_fnac
            // 
            this.lbl_fnac.AutoSize = true;
            this.lbl_fnac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fnac.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fnac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(236)))));
            this.lbl_fnac.Location = new System.Drawing.Point(15, 227);
            this.lbl_fnac.Name = "lbl_fnac";
            this.lbl_fnac.Size = new System.Drawing.Size(242, 29);
            this.lbl_fnac.TabIndex = 5;
            this.lbl_fnac.Text = "Fecha de Nacimiento";
            // 
            // txt_fnac
            // 
            this.txt_fnac.Location = new System.Drawing.Point(20, 259);
            this.txt_fnac.Name = "txt_fnac";
            this.txt_fnac.Size = new System.Drawing.Size(263, 26);
            this.txt_fnac.TabIndex = 6;
            // 
            // lbl_nac
            // 
            this.lbl_nac.AutoSize = true;
            this.lbl_nac.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nac.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(236)))));
            this.lbl_nac.Location = new System.Drawing.Point(15, 288);
            this.lbl_nac.Name = "lbl_nac";
            this.lbl_nac.Size = new System.Drawing.Size(154, 29);
            this.lbl_nac.TabIndex = 7;
            this.lbl_nac.Text = "Nacionalidad";
            // 
            // txt_nac
            // 
            this.txt_nac.Location = new System.Drawing.Point(20, 320);
            this.txt_nac.Name = "txt_nac";
            this.txt_nac.Size = new System.Drawing.Size(263, 26);
            this.txt_nac.TabIndex = 8;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sex.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(236)))));
            this.lbl_sex.Location = new System.Drawing.Point(15, 349);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(64, 29);
            this.lbl_sex.TabIndex = 9;
            this.lbl_sex.Text = "Sexo";
            // 
            // lbl_sangre
            // 
            this.lbl_sangre.AutoSize = true;
            this.lbl_sangre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sangre.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sangre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(236)))));
            this.lbl_sangre.Location = new System.Drawing.Point(85, 349);
            this.lbl_sangre.Name = "lbl_sangre";
            this.lbl_sangre.Size = new System.Drawing.Size(87, 29);
            this.lbl_sangre.TabIndex = 10;
            this.lbl_sangre.Text = "Sangre";
            // 
            // lbl_eciv
            // 
            this.lbl_eciv.AutoSize = true;
            this.lbl_eciv.BackColor = System.Drawing.Color.Transparent;
            this.lbl_eciv.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eciv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(236)))));
            this.lbl_eciv.Location = new System.Drawing.Point(178, 349);
            this.lbl_eciv.Name = "lbl_eciv";
            this.lbl_eciv.Size = new System.Drawing.Size(140, 29);
            this.lbl_eciv.TabIndex = 11;
            this.lbl_eciv.Text = "Estado Civil";
            // 
            // lbl_ocu
            // 
            this.lbl_ocu.AutoSize = true;
            this.lbl_ocu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ocu.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ocu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(236)))));
            this.lbl_ocu.Location = new System.Drawing.Point(18, 410);
            this.lbl_ocu.Name = "lbl_ocu";
            this.lbl_ocu.Size = new System.Drawing.Size(130, 29);
            this.lbl_ocu.TabIndex = 12;
            this.lbl_ocu.Text = "Ocupacion";
            // 
            // txt_ocu
            // 
            this.txt_ocu.Location = new System.Drawing.Point(23, 442);
            this.txt_ocu.Name = "txt_ocu";
            this.txt_ocu.Size = new System.Drawing.Size(263, 26);
            this.txt_ocu.TabIndex = 13;
            // 
            // lbl_femi
            // 
            this.lbl_femi.AutoSize = true;
            this.lbl_femi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_femi.Font = new System.Drawing.Font("Apercu Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_femi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(147)))), ((int)(((byte)(236)))));
            this.lbl_femi.Location = new System.Drawing.Point(18, 471);
            this.lbl_femi.Name = "lbl_femi";
            this.lbl_femi.Size = new System.Drawing.Size(203, 29);
            this.lbl_femi.TabIndex = 14;
            this.lbl_femi.Text = "Fecha de Emision";
            // 
            // txt_fde
            // 
            this.txt_fde.Location = new System.Drawing.Point(23, 503);
            this.txt_fde.Name = "txt_fde";
            this.txt_fde.Size = new System.Drawing.Size(263, 26);
            this.txt_fde.TabIndex = 15;
            // 
            // Datashow
            // 
            this.Datashow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datashow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numID,
            this.ldn,
            this.fdn,
            this.nac,
            this.gndr,
            this.tsan,
            this.status,
            this.ocup,
            this.fde});
            this.Datashow.Location = new System.Drawing.Point(347, 105);
            this.Datashow.Name = "Datashow";
            this.Datashow.RowHeadersWidth = 62;
            this.Datashow.RowTemplate.Height = 28;
            this.Datashow.Size = new System.Drawing.Size(1051, 505);
            this.Datashow.TabIndex = 16;
            // 
            // numID
            // 
            this.numID.HeaderText = "Numero de Cedula";
            this.numID.MinimumWidth = 8;
            this.numID.Name = "numID";
            this.numID.Width = 150;
            // 
            // ldn
            // 
            this.ldn.HeaderText = "Lugar de Nacimiento";
            this.ldn.MinimumWidth = 8;
            this.ldn.Name = "ldn";
            this.ldn.Width = 150;
            // 
            // fdn
            // 
            this.fdn.HeaderText = "Fecha de Nacimiento";
            this.fdn.MinimumWidth = 8;
            this.fdn.Name = "fdn";
            this.fdn.Width = 150;
            // 
            // nac
            // 
            this.nac.HeaderText = "Nacionalidad";
            this.nac.MinimumWidth = 8;
            this.nac.Name = "nac";
            this.nac.Width = 150;
            // 
            // gndr
            // 
            this.gndr.HeaderText = "Sexo";
            this.gndr.MinimumWidth = 8;
            this.gndr.Name = "gndr";
            this.gndr.Width = 150;
            // 
            // tsan
            // 
            this.tsan.HeaderText = "Sangre";
            this.tsan.MinimumWidth = 8;
            this.tsan.Name = "tsan";
            this.tsan.Width = 150;
            // 
            // status
            // 
            this.status.HeaderText = "Estado Civil";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.Width = 150;
            // 
            // ocup
            // 
            this.ocup.HeaderText = "Ocupacion";
            this.ocup.MinimumWidth = 8;
            this.ocup.Name = "ocup";
            this.ocup.Width = 150;
            // 
            // fde
            // 
            this.fde.HeaderText = "Fecha de Emision";
            this.fde.MinimumWidth = 8;
            this.fde.Name = "fde";
            this.fde.Width = 150;
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(23, 560);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(128, 50);
            this.btnS.TabIndex = 17;
            this.btnS.Text = "Guardar";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // txt_sex
            // 
            this.txt_sex.Location = new System.Drawing.Point(227, 663);
            this.txt_sex.Name = "txt_sex";
            this.txt_sex.Size = new System.Drawing.Size(56, 26);
            this.txt_sex.TabIndex = 18;
            // 
            // txt_sangre
            // 
            this.txt_sangre.Location = new System.Drawing.Point(306, 663);
            this.txt_sangre.Name = "txt_sangre";
            this.txt_sangre.Size = new System.Drawing.Size(56, 26);
            this.txt_sangre.TabIndex = 19;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(431, 663);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(135, 26);
            this.txt_status.TabIndex = 20;
            // 
            // lst_sx
            // 
            this.lst_sx.FormattingEnabled = true;
            this.lst_sx.Items.AddRange(new object[] {
            "M",
            "F"});
            this.lst_sx.Location = new System.Drawing.Point(23, 381);
            this.lst_sx.Name = "lst_sx";
            this.lst_sx.Size = new System.Drawing.Size(56, 28);
            this.lst_sx.TabIndex = 21;
            // 
            // lst_s
            // 
            this.lst_s.FormattingEnabled = true;
            this.lst_s.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.lst_s.Location = new System.Drawing.Point(90, 381);
            this.lst_s.Name = "lst_s";
            this.lst_s.Size = new System.Drawing.Size(79, 28);
            this.lst_s.TabIndex = 22;
            // 
            // lst_ec
            // 
            this.lst_ec.FormattingEnabled = true;
            this.lst_ec.Items.AddRange(new object[] {
            "Soltero",
            "Casado"});
            this.lst_ec.Location = new System.Drawing.Point(183, 381);
            this.lst_ec.Name = "lst_ec";
            this.lst_ec.Size = new System.Drawing.Size(135, 28);
            this.lst_ec.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1410, 794);
            this.Controls.Add(this.lst_ec);
            this.Controls.Add(this.lst_s);
            this.Controls.Add(this.lst_sx);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_sangre);
            this.Controls.Add(this.txt_sex);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.Datashow);
            this.Controls.Add(this.txt_fde);
            this.Controls.Add(this.lbl_femi);
            this.Controls.Add(this.txt_ocu);
            this.Controls.Add(this.lbl_ocu);
            this.Controls.Add(this.lbl_eciv);
            this.Controls.Add(this.lbl_sangre);
            this.Controls.Add(this.lbl_sex);
            this.Controls.Add(this.txt_nac);
            this.Controls.Add(this.lbl_nac);
            this.Controls.Add(this.txt_fnac);
            this.Controls.Add(this.lbl_fnac);
            this.Controls.Add(this.txt_lnac);
            this.Controls.Add(this.lbl_lnac);
            this.Controls.Add(this.lbl_nced);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datashow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label lbl_nced;
        private System.Windows.Forms.Label lbl_lnac;
        private System.Windows.Forms.TextBox txt_lnac;
        private System.Windows.Forms.Label lbl_fnac;
        private System.Windows.Forms.TextBox txt_fnac;
        private System.Windows.Forms.Label lbl_nac;
        private System.Windows.Forms.TextBox txt_nac;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_sangre;
        private System.Windows.Forms.Label lbl_eciv;
        private System.Windows.Forms.Label lbl_ocu;
        private System.Windows.Forms.TextBox txt_ocu;
        private System.Windows.Forms.Label lbl_femi;
        private System.Windows.Forms.TextBox txt_fde;
        private System.Windows.Forms.DataGridView Datashow;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.DataGridViewTextBoxColumn numID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ldn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn gndr;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsan;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocup;
        private System.Windows.Forms.DataGridViewTextBoxColumn fde;
        private System.Windows.Forms.TextBox txt_sex;
        private System.Windows.Forms.TextBox txt_sangre;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.ComboBox lst_sx;
        private System.Windows.Forms.ComboBox lst_s;
        private System.Windows.Forms.ComboBox lst_ec;
    }
}


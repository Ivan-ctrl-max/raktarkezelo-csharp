namespace Raktarkezelo
{
    partial class Main
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
            this.dgvRaktar = new System.Windows.Forms.DataGridView();
            this.Nev = new System.Windows.Forms.TextBox();
            this.Ar = new System.Windows.Forms.TextBox();
            this.numDb = new System.Windows.Forms.NumericUpDown();
            this.btnHozaad = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Név = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mennyiség = new System.Windows.Forms.Label();
            this.btnTorles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDb)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRaktar
            // 
            this.dgvRaktar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRaktar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaktar.Location = new System.Drawing.Point(404, 12);
            this.dgvRaktar.Name = "dgvRaktar";
            this.dgvRaktar.Size = new System.Drawing.Size(384, 295);
            this.dgvRaktar.TabIndex = 0;
            // 
            // Nev
            // 
            this.Nev.Location = new System.Drawing.Point(180, 55);
            this.Nev.Name = "Nev";
            this.Nev.Size = new System.Drawing.Size(100, 20);
            this.Nev.TabIndex = 1;
            // 
            // Ar
            // 
            this.Ar.Location = new System.Drawing.Point(180, 142);
            this.Ar.Name = "Ar";
            this.Ar.Size = new System.Drawing.Size(100, 20);
            this.Ar.TabIndex = 2;
            // 
            // numDb
            // 
            this.numDb.Location = new System.Drawing.Point(180, 217);
            this.numDb.Name = "numDb";
            this.numDb.Size = new System.Drawing.Size(120, 20);
            this.numDb.TabIndex = 3;
            // 
            // btnHozaad
            // 
            this.btnHozaad.Location = new System.Drawing.Point(67, 284);
            this.btnHozaad.Name = "btnHozaad";
            this.btnHozaad.Size = new System.Drawing.Size(75, 23);
            this.btnHozaad.TabIndex = 4;
            this.btnHozaad.Text = "Hozaad";
            this.btnHozaad.UseVisualStyleBackColor = true;
            this.btnHozaad.Click += new System.EventHandler(this.btnHozaad_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(467, 313);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 5;
            this.btnMentes.Text = "Exportalas";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Név
            // 
            this.Név.AutoSize = true;
            this.Név.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Név.Location = new System.Drawing.Point(92, 55);
            this.Név.Name = "Név";
            this.Név.Size = new System.Drawing.Size(36, 20);
            this.Név.TabIndex = 7;
            this.Név.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ár";
            // 
            // Mennyiség
            // 
            this.Mennyiség.AutoSize = true;
            this.Mennyiség.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mennyiség.Location = new System.Drawing.Point(63, 217);
            this.Mennyiség.Name = "Mennyiség";
            this.Mennyiség.Size = new System.Drawing.Size(85, 20);
            this.Mennyiség.TabIndex = 9;
            this.Mennyiség.Text = "Mennyiség";
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(205, 284);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(75, 23);
            this.btnTorles.TabIndex = 10;
            this.btnTorles.Text = "Törles";
            this.btnTorles.UseCompatibleTextRendering = true;
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.Mennyiség);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Név);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnHozaad);
            this.Controls.Add(this.numDb);
            this.Controls.Add(this.Ar);
            this.Controls.Add(this.Nev);
            this.Controls.Add(this.dgvRaktar);
            this.Name = "Main";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRaktar;
        private System.Windows.Forms.TextBox Nev;
        private System.Windows.Forms.TextBox Ar;
        private System.Windows.Forms.NumericUpDown numDb;
        private System.Windows.Forms.Button btnHozaad;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Név;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Mennyiség;
        private System.Windows.Forms.Button btnTorles;
    }
}
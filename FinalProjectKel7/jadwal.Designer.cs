namespace FinalProjectKel7
{
    partial class jadwal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nh = new System.Windows.Forms.TextBox();
            this.ij = new System.Windows.Forms.TextBox();
            this.cbxMhs = new System.Windows.Forms.ComboBox();
            this.cbxD = new System.Windows.Forms.ComboBox();
            this.cbxMatkul = new System.Windows.Forms.ComboBox();
            this.cbxJ = new System.Windows.Forms.ComboBox();
            this.cbxG = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnsv = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(660, 69);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(666, 367);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Jadwal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Hari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Mahasiswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Dosen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID Matkul";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID Gesung";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "ID Jurusan";
            // 
            // nh
            // 
            this.nh.Location = new System.Drawing.Point(120, 217);
            this.nh.Name = "nh";
            this.nh.Size = new System.Drawing.Size(121, 20);
            this.nh.TabIndex = 10;
            // 
            // ij
            // 
            this.ij.Location = new System.Drawing.Point(120, 188);
            this.ij.Name = "ij";
            this.ij.Size = new System.Drawing.Size(121, 20);
            this.ij.TabIndex = 11;
            this.ij.TextChanged += new System.EventHandler(this.ij_TextChanged);
            // 
            // cbxMhs
            // 
            this.cbxMhs.FormattingEnabled = true;
            this.cbxMhs.Location = new System.Drawing.Point(120, 243);
            this.cbxMhs.Name = "cbxMhs";
            this.cbxMhs.Size = new System.Drawing.Size(121, 21);
            this.cbxMhs.TabIndex = 12;
            // 
            // cbxD
            // 
            this.cbxD.FormattingEnabled = true;
            this.cbxD.Location = new System.Drawing.Point(120, 270);
            this.cbxD.Name = "cbxD";
            this.cbxD.Size = new System.Drawing.Size(121, 21);
            this.cbxD.TabIndex = 13;
            // 
            // cbxMatkul
            // 
            this.cbxMatkul.FormattingEnabled = true;
            this.cbxMatkul.Location = new System.Drawing.Point(120, 297);
            this.cbxMatkul.Name = "cbxMatkul";
            this.cbxMatkul.Size = new System.Drawing.Size(121, 21);
            this.cbxMatkul.TabIndex = 14;
            // 
            // cbxJ
            // 
            this.cbxJ.FormattingEnabled = true;
            this.cbxJ.Location = new System.Drawing.Point(120, 324);
            this.cbxJ.Name = "cbxJ";
            this.cbxJ.Size = new System.Drawing.Size(121, 21);
            this.cbxJ.TabIndex = 15;
            // 
            // cbxG
            // 
            this.cbxG.FormattingEnabled = true;
            this.cbxG.Location = new System.Drawing.Point(120, 351);
            this.cbxG.Name = "cbxG";
            this.cbxG.Size = new System.Drawing.Size(121, 21);
            this.cbxG.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(329, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnsv
            // 
            this.btnsv.Location = new System.Drawing.Point(329, 231);
            this.btnsv.Name = "btnsv";
            this.btnsv.Size = new System.Drawing.Size(75, 23);
            this.btnsv.TabIndex = 18;
            this.btnsv.Text = "Save";
            this.btnsv.UseVisualStyleBackColor = true;
            this.btnsv.Click += new System.EventHandler(this.btnsv_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(329, 273);
            this.btnc.Name = "btnc";
            this.btnc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnc.Size = new System.Drawing.Size(75, 23);
            this.btnc.TabIndex = 19;
            this.btnc.Text = "Clear";
            this.btnc.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(442, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // jadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnsv);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxG);
            this.Controls.Add(this.cbxJ);
            this.Controls.Add(this.cbxMatkul);
            this.Controls.Add(this.cbxD);
            this.Controls.Add(this.cbxMhs);
            this.Controls.Add(this.ij);
            this.Controls.Add(this.nh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridView1);
            this.Name = "jadwal";
            this.Text = "jadwal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nh;
        private System.Windows.Forms.TextBox ij;
        private System.Windows.Forms.ComboBox cbxMhs;
        private System.Windows.Forms.ComboBox cbxD;
        private System.Windows.Forms.ComboBox cbxMatkul;
        private System.Windows.Forms.ComboBox cbxJ;
        private System.Windows.Forms.ComboBox cbxG;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnsv;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnDelete;
    }
}
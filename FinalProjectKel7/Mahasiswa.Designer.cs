namespace FinalProjectKel7
{
    partial class Mahasiswa
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
            this.add = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.imhs = new System.Windows.Forms.TextBox();
            this.nmhs = new System.Windows.Forms.TextBox();
            this.am = new System.Windows.Forms.TextBox();
            this.nt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jk = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(538, 182);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(538, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(538, 276);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(656, 45);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // imhs
            // 
            this.imhs.Location = new System.Drawing.Point(315, 168);
            this.imhs.Name = "imhs";
            this.imhs.Size = new System.Drawing.Size(100, 20);
            this.imhs.TabIndex = 5;
            this.imhs.TextChanged += new System.EventHandler(this.imhs_TextChanged);
            // 
            // nmhs
            // 
            this.nmhs.Location = new System.Drawing.Point(315, 194);
            this.nmhs.Name = "nmhs";
            this.nmhs.Size = new System.Drawing.Size(100, 20);
            this.nmhs.TabIndex = 6;
            this.nmhs.TextChanged += new System.EventHandler(this.nmhs_TextChanged);
            // 
            // am
            // 
            this.am.Location = new System.Drawing.Point(315, 293);
            this.am.Name = "am";
            this.am.Size = new System.Drawing.Size(100, 20);
            this.am.TabIndex = 8;
            this.am.TextChanged += new System.EventHandler(this.am_TextChanged);
            // 
            // nt
            // 
            this.nt.Location = new System.Drawing.Point(315, 267);
            this.nt.Name = "nt";
            this.nt.Size = new System.Drawing.Size(100, 20);
            this.nt.TabIndex = 9;
            this.nt.TextChanged += new System.EventHandler(this.nt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "No Telp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alamat";
            // 
            // jk
            // 
            this.jk.FormattingEnabled = true;
            this.jk.Items.AddRange(new object[] {
            "L",
            "P"});
            this.jk.Location = new System.Drawing.Point(315, 227);
            this.jk.Name = "jk";
            this.jk.Size = new System.Drawing.Size(121, 21);
            this.jk.TabIndex = 15;
            this.jk.SelectedIndexChanged += new System.EventHandler(this.jk_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nt);
            this.Controls.Add(this.am);
            this.Controls.Add(this.nmhs);
            this.Controls.Add(this.imhs);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Mahasiswa";
            this.Text = "Mahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox imhs;
        private System.Windows.Forms.TextBox nmhs;
        private System.Windows.Forms.TextBox am;
        private System.Windows.Forms.TextBox nt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox jk;
        private System.Windows.Forms.Button button1;
    }
}
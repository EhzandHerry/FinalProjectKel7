namespace FinalProjectKel7
{
    partial class Form3
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
            this.nj = new System.Windows.Forms.TextBox();
            this.ij = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDlt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nj
            // 
            this.nj.Location = new System.Drawing.Point(255, 301);
            this.nj.Margin = new System.Windows.Forms.Padding(2);
            this.nj.Name = "nj";
            this.nj.Size = new System.Drawing.Size(180, 20);
            this.nj.TabIndex = 0;
            this.nj.TextChanged += new System.EventHandler(this.nj_TextChanged);
            // 
            // ij
            // 
            this.ij.Location = new System.Drawing.Point(255, 261);
            this.ij.Margin = new System.Windows.Forms.Padding(2);
            this.ij.Name = "ij";
            this.ij.Size = new System.Drawing.Size(180, 20);
            this.ij.TabIndex = 1;
            this.ij.TextChanged += new System.EventHandler(this.ij_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id_Jurusan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama_Jurusan";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(255, 373);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(63, 23);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 373);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(414, 373);
            this.btnc.Margin = new System.Windows.Forms.Padding(2);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(63, 23);
            this.btnc.TabIndex = 6;
            this.btnc.Text = "Clear";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(495, 259);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(63, 23);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(619, 39);
            this.btnview.Margin = new System.Windows.Forms.Padding(2);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(63, 23);
            this.btnview.TabIndex = 8;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(142, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(438, 211);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnDlt
            // 
            this.btnDlt.Location = new System.Drawing.Point(495, 303);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(75, 23);
            this.btnDlt.TabIndex = 10;
            this.btnDlt.Text = "Delete";
            this.btnDlt.UseVisualStyleBackColor = true;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(722, 437);
            this.Controls.Add(this.btnDlt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ij);
            this.Controls.Add(this.nj);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nj;
        private System.Windows.Forms.TextBox ij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDlt;
    }
}
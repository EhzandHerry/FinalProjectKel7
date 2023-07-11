namespace FinalProjectKel7
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.nt = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.nd = new System.Windows.Forms.TextBox();
            this.btnsv = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Dosen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama_Dosen";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No_Telp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(246, 246);
            this.id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(189, 20);
            this.id.TabIndex = 4;
            this.id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nt
            // 
            this.nt.Location = new System.Drawing.Point(246, 294);
            this.nt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nt.Name = "nt";
            this.nt.Size = new System.Drawing.Size(189, 20);
            this.nt.TabIndex = 5;
            this.nt.TextChanged += new System.EventHandler(this.nt_TextChanged);
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(246, 318);
            this.ad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(189, 20);
            this.ad.TabIndex = 6;
            this.ad.TextChanged += new System.EventHandler(this.ad_TextChanged);
            // 
            // nd
            // 
            this.nd.Location = new System.Drawing.Point(246, 270);
            this.nd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nd.Name = "nd";
            this.nd.Size = new System.Drawing.Size(189, 20);
            this.nd.TabIndex = 7;
            this.nd.TextChanged += new System.EventHandler(this.nd_TextChanged);
            // 
            // btnsv
            // 
            this.btnsv.Location = new System.Drawing.Point(506, 241);
            this.btnsv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsv.Name = "btnsv";
            this.btnsv.Size = new System.Drawing.Size(58, 23);
            this.btnsv.TabIndex = 8;
            this.btnsv.Text = "Save";
            this.btnsv.UseVisualStyleBackColor = true;
            this.btnsv.Click += new System.EventHandler(this.btnsv_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(506, 281);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(58, 23);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(506, 331);
            this.btnc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(58, 23);
            this.btnc.TabIndex = 10;
            this.btnc.Text = "Clear";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(662, 381);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(181, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(383, 196);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(594, 45);
            this.btnview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(58, 23);
            this.btnview.TabIndex = 13;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 429);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnsv);
            this.Controls.Add(this.nd);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.nt);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox nt;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox nd;
        private System.Windows.Forms.Button btnsv;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnview;
    }
}
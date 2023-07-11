namespace FinalProjectKel7
{
    partial class matakuliah
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
            this.btnview = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsv = new System.Windows.Forms.Button();
            this.nm = new System.Windows.Forms.TextBox();
            this.im = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sks = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(645, 77);
            this.btnview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(58, 23);
            this.btnview.TabIndex = 27;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(439, 167);
            this.dataGridView1.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(636, 362);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(461, 222);
            this.btnc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(58, 23);
            this.btnc.TabIndex = 24;
            this.btnc.Text = "Clear";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(461, 266);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(58, 23);
            this.btnadd.TabIndex = 23;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnsv
            // 
            this.btnsv.Location = new System.Drawing.Point(461, 308);
            this.btnsv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsv.Name = "btnsv";
            this.btnsv.Size = new System.Drawing.Size(58, 23);
            this.btnsv.TabIndex = 22;
            this.btnsv.Text = "Save";
            this.btnsv.UseVisualStyleBackColor = true;
            this.btnsv.Click += new System.EventHandler(this.btnsv_Click);
            // 
            // nm
            // 
            this.nm.Location = new System.Drawing.Point(217, 266);
            this.nm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(144, 20);
            this.nm.TabIndex = 21;
            this.nm.TextChanged += new System.EventHandler(this.nm_TextChanged);
            // 
            // im
            // 
            this.im.Location = new System.Drawing.Point(217, 222);
            this.im.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.im.Name = "im";
            this.im.Size = new System.Drawing.Size(144, 20);
            this.im.TabIndex = 18;
            this.im.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 316);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nama_Matkul";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id_Matkul";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sks
            // 
            this.sks.FormattingEnabled = true;
            this.sks.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.sks.Location = new System.Drawing.Point(217, 308);
            this.sks.Name = "sks";
            this.sks.Size = new System.Drawing.Size(142, 21);
            this.sks.TabIndex = 28;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(538, 219);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 29;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // matakuliah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 434);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.sks);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnsv);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.im);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "matakuliah";
            this.Text = "matakuliah";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsv;
        private System.Windows.Forms.TextBox nm;
        private System.Windows.Forms.TextBox im;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sks;
        private System.Windows.Forms.Button Delete;
    }
}
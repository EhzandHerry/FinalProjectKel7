namespace FinalProjectKel7
{
    partial class ruangan
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
            this.rg = new System.Windows.Forms.TextBox();
            this.btnview = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsv = new System.Windows.Forms.Button();
            this.ng = new System.Windows.Forms.TextBox();
            this.ig = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rg
            // 
            this.rg.Location = new System.Drawing.Point(328, 360);
            this.rg.Margin = new System.Windows.Forms.Padding(2);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(144, 20);
            this.rg.TabIndex = 52;
            this.rg.TextChanged += new System.EventHandler(this.rg_TextChanged);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(684, 50);
            this.btnview.Margin = new System.Windows.Forms.Padding(2);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(58, 23);
            this.btnview.TabIndex = 51;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(459, 179);
            this.dataGridView1.TabIndex = 50;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(684, 421);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(58, 23);
            this.back.TabIndex = 49;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(532, 270);
            this.btnc.Margin = new System.Windows.Forms.Padding(2);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(58, 23);
            this.btnc.TabIndex = 48;
            this.btnc.Text = "Clear";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(532, 312);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(58, 23);
            this.btnadd.TabIndex = 47;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnsv
            // 
            this.btnsv.Location = new System.Drawing.Point(532, 357);
            this.btnsv.Margin = new System.Windows.Forms.Padding(2);
            this.btnsv.Name = "btnsv";
            this.btnsv.Size = new System.Drawing.Size(58, 23);
            this.btnsv.TabIndex = 46;
            this.btnsv.Text = "Save";
            this.btnsv.UseVisualStyleBackColor = true;
            this.btnsv.Click += new System.EventHandler(this.btnsv_Click);
            // 
            // ng
            // 
            this.ng.Location = new System.Drawing.Point(328, 315);
            this.ng.Margin = new System.Windows.Forms.Padding(2);
            this.ng.Name = "ng";
            this.ng.Size = new System.Drawing.Size(144, 20);
            this.ng.TabIndex = 45;
            this.ng.TextChanged += new System.EventHandler(this.ng_TextChanged);
            // 
            // ig
            // 
            this.ig.Location = new System.Drawing.Point(328, 273);
            this.ig.Margin = new System.Windows.Forms.Padding(2);
            this.ig.Name = "ig";
            this.ig.Size = new System.Drawing.Size(144, 20);
            this.ig.TabIndex = 44;
            this.ig.TextChanged += new System.EventHandler(this.ig_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ruangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nama_Gedung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Id_Gedung";
            // 
            // ruangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 484);
            this.Controls.Add(this.rg);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnsv);
            this.Controls.Add(this.ng);
            this.Controls.Add(this.ig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ruangan";
            this.Text = "ruangan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rg;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsv;
        private System.Windows.Forms.TextBox ng;
        private System.Windows.Forms.TextBox ig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
﻿namespace FinalProjectKel7
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
            this.button4 = new System.Windows.Forms.Button();
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
            this.rg.Location = new System.Drawing.Point(253, 347);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(214, 26);
            this.rg.TabIndex = 52;
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(492, 77);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(87, 35);
            this.btnview.TabIndex = 51;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 50;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(509, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 35);
            this.button4.TabIndex = 49;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(617, 254);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(87, 35);
            this.btnc.TabIndex = 48;
            this.btnc.Text = "Clear";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(617, 301);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(87, 35);
            this.btnadd.TabIndex = 47;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnsv
            // 
            this.btnsv.Location = new System.Drawing.Point(509, 301);
            this.btnsv.Name = "btnsv";
            this.btnsv.Size = new System.Drawing.Size(87, 35);
            this.btnsv.TabIndex = 46;
            this.btnsv.Text = "Save";
            this.btnsv.UseVisualStyleBackColor = true;
            this.btnsv.Click += new System.EventHandler(this.btnsv_Click);
            // 
            // ng
            // 
            this.ng.Location = new System.Drawing.Point(253, 301);
            this.ng.Name = "ng";
            this.ng.Size = new System.Drawing.Size(214, 26);
            this.ng.TabIndex = 45;
            // 
            // ig
            // 
            this.ig.Location = new System.Drawing.Point(253, 263);
            this.ig.Name = "ig";
            this.ig.Size = new System.Drawing.Size(214, 26);
            this.ig.TabIndex = 44;
            this.ig.TextChanged += new System.EventHandler(this.ig_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ruangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nama_Gedung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Id_Gedung";
            // 
            // ruangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rg);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnsv);
            this.Controls.Add(this.ng);
            this.Controls.Add(this.ig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button button4;
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
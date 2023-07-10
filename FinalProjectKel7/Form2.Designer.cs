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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_Dosen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama_Dosen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "No_Telp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(298, 210);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(214, 26);
            this.id.TabIndex = 4;
            this.id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nt
            // 
            this.nt.Location = new System.Drawing.Point(298, 294);
            this.nt.Name = "nt";
            this.nt.Size = new System.Drawing.Size(214, 26);
            this.nt.TabIndex = 5;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(298, 336);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(214, 26);
            this.ad.TabIndex = 6;
            // 
            // nd
            // 
            this.nd.Location = new System.Drawing.Point(298, 248);
            this.nd.Name = "nd";
            this.nd.Size = new System.Drawing.Size(214, 26);
            this.nd.TabIndex = 7;
            // 
            // btnsv
            // 
            this.btnsv.Location = new System.Drawing.Point(554, 248);
            this.btnsv.Name = "btnsv";
            this.btnsv.Size = new System.Drawing.Size(87, 35);
            this.btnsv.TabIndex = 8;
            this.btnsv.Text = "Save";
            this.btnsv.UseVisualStyleBackColor = true;
            this.btnsv.Click += new System.EventHandler(this.btnsv_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(554, 294);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(87, 35);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(554, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(554, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(272, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(537, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 35);
            this.button5.TabIndex = 13;
            this.button5.Text = "View";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
    }
}
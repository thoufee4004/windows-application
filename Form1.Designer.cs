namespace Student_Detail
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Lb_st_id = new System.Windows.Forms.Label();
            this.Lb_st_name = new System.Windows.Forms.Label();
            this.Lb_age = new System.Windows.Forms.Label();
            this.Bt_insert = new System.Windows.Forms.Button();
            this.Bt_update = new System.Windows.Forms.Button();
            this.Bt_delete = new System.Windows.Forms.Button();
            this.Bt_clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbGender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.Rd_Btn_Male = new System.Windows.Forms.RadioButton();
            this.Rd_Btn_female = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Btn_dlt_all = new System.Windows.Forms.Button();
            this.btn_sh_rec = new System.Windows.Forms.Button();
            this.btn_sh_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(101, 37);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 0;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(101, 115);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 20);
            this.txtage.TabIndex = 2;
            this.txtage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(101, 77);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 3;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // Lb_st_id
            // 
            this.Lb_st_id.AutoSize = true;
            this.Lb_st_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_st_id.Location = new System.Drawing.Point(33, 43);
            this.Lb_st_id.Name = "Lb_st_id";
            this.Lb_st_id.Size = new System.Drawing.Size(32, 16);
            this.Lb_st_id.TabIndex = 4;
            this.Lb_st_id.Text = "No:";
            // 
            // Lb_st_name
            // 
            this.Lb_st_name.AutoSize = true;
            this.Lb_st_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_st_name.Location = new System.Drawing.Point(33, 80);
            this.Lb_st_name.Name = "Lb_st_name";
            this.Lb_st_name.Size = new System.Drawing.Size(53, 16);
            this.Lb_st_name.TabIndex = 5;
            this.Lb_st_name.Text = "Name:";
            // 
            // Lb_age
            // 
            this.Lb_age.AutoSize = true;
            this.Lb_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_age.Location = new System.Drawing.Point(33, 116);
            this.Lb_age.Name = "Lb_age";
            this.Lb_age.Size = new System.Drawing.Size(40, 16);
            this.Lb_age.TabIndex = 6;
            this.Lb_age.Text = "Age:";
            // 
            // Bt_insert
            // 
            this.Bt_insert.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_insert.Location = new System.Drawing.Point(36, 181);
            this.Bt_insert.Name = "Bt_insert";
            this.Bt_insert.Size = new System.Drawing.Size(75, 32);
            this.Bt_insert.TabIndex = 7;
            this.Bt_insert.Text = "Insert";
            this.Bt_insert.UseVisualStyleBackColor = true;
            this.Bt_insert.Click += new System.EventHandler(this.Bt_insert_Click);
            // 
            // Bt_update
            // 
            this.Bt_update.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_update.Location = new System.Drawing.Point(126, 181);
            this.Bt_update.Name = "Bt_update";
            this.Bt_update.Size = new System.Drawing.Size(75, 30);
            this.Bt_update.TabIndex = 8;
            this.Bt_update.Text = "Update";
            this.Bt_update.UseVisualStyleBackColor = true;
            this.Bt_update.Click += new System.EventHandler(this.Bt_update_Click);
            // 
            // Bt_delete
            // 
            this.Bt_delete.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_delete.Location = new System.Drawing.Point(126, 234);
            this.Bt_delete.Name = "Bt_delete";
            this.Bt_delete.Size = new System.Drawing.Size(75, 31);
            this.Bt_delete.TabIndex = 9;
            this.Bt_delete.Text = "Delete";
            this.Bt_delete.UseVisualStyleBackColor = true;
            this.Bt_delete.Click += new System.EventHandler(this.Bt_delete_Click);
            // 
            // Bt_clear
            // 
            this.Bt_clear.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_clear.Location = new System.Drawing.Point(83, 333);
            this.Bt_clear.Name = "Bt_clear";
            this.Bt_clear.Size = new System.Drawing.Size(75, 30);
            this.Bt_clear.TabIndex = 10;
            this.Bt_clear.Text = "Reset";
            this.Bt_clear.UseVisualStyleBackColor = true;
            this.Bt_clear.Click += new System.EventHandler(this.Bt_clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(221, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 283);
            this.dataGridView1.TabIndex = 11;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(36, 149);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(59, 16);
            this.lbGender.TabIndex = 12;
            this.lbGender.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter the below details";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(110, 135);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(74, 13);
            this.warning.TabIndex = 15;
            this.warning.Text = "*Age limit 7-99";
            this.warning.Visible = false;
            // 
            // Rd_Btn_Male
            // 
            this.Rd_Btn_Male.AutoSize = true;
            this.Rd_Btn_Male.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Btn_Male.Location = new System.Drawing.Point(102, 149);
            this.Rd_Btn_Male.Name = "Rd_Btn_Male";
            this.Rd_Btn_Male.Size = new System.Drawing.Size(52, 21);
            this.Rd_Btn_Male.TabIndex = 16;
            this.Rd_Btn_Male.TabStop = true;
            this.Rd_Btn_Male.Text = "Male";
            this.Rd_Btn_Male.UseVisualStyleBackColor = true;
            // 
            // Rd_Btn_female
            // 
            this.Rd_Btn_female.AutoSize = true;
            this.Rd_Btn_female.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Rd_Btn_female.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Btn_female.Location = new System.Drawing.Point(151, 149);
            this.Rd_Btn_female.Name = "Rd_Btn_female";
            this.Rd_Btn_female.Size = new System.Drawing.Size(64, 21);
            this.Rd_Btn_female.TabIndex = 17;
            this.Rd_Btn_female.TabStop = true;
            this.Rd_Btn_female.Text = "Female";
            this.Rd_Btn_female.UseVisualStyleBackColor = false;
            // 
            // Btn_dlt_all
            // 
            this.Btn_dlt_all.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_dlt_all.Location = new System.Drawing.Point(36, 234);
            this.Btn_dlt_all.Name = "Btn_dlt_all";
            this.Btn_dlt_all.Size = new System.Drawing.Size(75, 30);
            this.Btn_dlt_all.TabIndex = 18;
            this.Btn_dlt_all.Text = "Dlt all";
            this.Btn_dlt_all.UseVisualStyleBackColor = true;
            this.Btn_dlt_all.Click += new System.EventHandler(this.Btn_dlt_all_Click);
            // 
            // btn_sh_rec
            // 
            this.btn_sh_rec.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sh_rec.Location = new System.Drawing.Point(36, 290);
            this.btn_sh_rec.Name = "btn_sh_rec";
            this.btn_sh_rec.Size = new System.Drawing.Size(75, 30);
            this.btn_sh_rec.TabIndex = 19;
            this.btn_sh_rec.Text = "show record";
            this.btn_sh_rec.UseVisualStyleBackColor = true;
            this.btn_sh_rec.Click += new System.EventHandler(this.btn_sh_rec_Click);
            // 
            // btn_sh_all
            // 
            this.btn_sh_all.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sh_all.Location = new System.Drawing.Point(126, 290);
            this.btn_sh_all.Name = "btn_sh_all";
            this.btn_sh_all.Size = new System.Drawing.Size(75, 30);
            this.btn_sh_all.TabIndex = 21;
            this.btn_sh_all.Text = "show All ";
            this.btn_sh_all.UseVisualStyleBackColor = true;
            this.btn_sh_all.Click += new System.EventHandler(this.btn_sh_all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(691, 383);
            this.Controls.Add(this.btn_sh_all);
            this.Controls.Add(this.btn_sh_rec);
            this.Controls.Add(this.Btn_dlt_all);
            this.Controls.Add(this.Rd_Btn_female);
            this.Controls.Add(this.Rd_Btn_Male);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Bt_clear);
            this.Controls.Add(this.Bt_delete);
            this.Controls.Add(this.Bt_update);
            this.Controls.Add(this.Bt_insert);
            this.Controls.Add(this.Lb_age);
            this.Controls.Add(this.Lb_st_name);
            this.Controls.Add(this.Lb_st_id);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtid);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Entry form";
            this.TransparencyKey = System.Drawing.Color.DarkSlateGray;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label Lb_st_id;
        private System.Windows.Forms.Label Lb_st_name;
        private System.Windows.Forms.Label Lb_age;
        private System.Windows.Forms.Button Bt_insert;
        private System.Windows.Forms.Button Bt_update;
        private System.Windows.Forms.Button Bt_delete;
        private System.Windows.Forms.Button Bt_clear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.RadioButton Rd_Btn_Male;
        private System.Windows.Forms.RadioButton Rd_Btn_female;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Btn_dlt_all;
        private System.Windows.Forms.Button btn_sh_rec;
        private System.Windows.Forms.Button btn_sh_all;
    }
}


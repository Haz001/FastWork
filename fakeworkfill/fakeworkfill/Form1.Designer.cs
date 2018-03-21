namespace fakeworkfill
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Folder_path_tb = new System.Windows.Forms.TextBox();
            this.browse_btn = new System.Windows.Forms.Button();
            this.gn_f_btn = new System.Windows.Forms.Button();
            this.gn_t_btn = new System.Windows.Forms.Button();
            this.genfiles_btn = new System.Windows.Forms.Button();
            this.nb_fs_tb = new System.Windows.Forms.TextBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Folder_path_tb
            // 
            this.Folder_path_tb.Location = new System.Drawing.Point(0, 0);
            this.Folder_path_tb.Name = "Folder_path_tb";
            this.Folder_path_tb.Size = new System.Drawing.Size(150, 20);
            this.Folder_path_tb.TabIndex = 0;
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(150, 0);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(50, 20);
            this.browse_btn.TabIndex = 1;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // gn_f_btn
            // 
            this.gn_f_btn.BackColor = System.Drawing.Color.Red;
            this.gn_f_btn.FlatAppearance.BorderSize = 0;
            this.gn_f_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.gn_f_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gn_f_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gn_f_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gn_f_btn.ForeColor = System.Drawing.Color.White;
            this.gn_f_btn.Location = new System.Drawing.Point(0, 20);
            this.gn_f_btn.Name = "gn_f_btn";
            this.gn_f_btn.Size = new System.Drawing.Size(75, 50);
            this.gn_f_btn.TabIndex = 1;
            this.gn_f_btn.Text = "Random names";
            this.gn_f_btn.UseVisualStyleBackColor = false;
            this.gn_f_btn.Click += new System.EventHandler(this.gn_f_btn_Click);
            // 
            // gn_t_btn
            // 
            this.gn_t_btn.BackColor = System.Drawing.Color.Lime;
            this.gn_t_btn.FlatAppearance.BorderSize = 0;
            this.gn_t_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.gn_t_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gn_t_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gn_t_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gn_t_btn.ForeColor = System.Drawing.Color.White;
            this.gn_t_btn.Location = new System.Drawing.Point(75, 20);
            this.gn_t_btn.Name = "gn_t_btn";
            this.gn_t_btn.Size = new System.Drawing.Size(75, 50);
            this.gn_t_btn.TabIndex = 1;
            this.gn_t_btn.Text = "Realistic names";
            this.gn_t_btn.UseVisualStyleBackColor = false;
            this.gn_t_btn.Click += new System.EventHandler(this.gn_t_btn_Click);
            // 
            // genfiles_btn
            // 
            this.genfiles_btn.BackColor = System.Drawing.Color.Lime;
            this.genfiles_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.genfiles_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.genfiles_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genfiles_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genfiles_btn.ForeColor = System.Drawing.Color.White;
            this.genfiles_btn.Location = new System.Drawing.Point(0, 130);
            this.genfiles_btn.Name = "genfiles_btn";
            this.genfiles_btn.Size = new System.Drawing.Size(250, 75);
            this.genfiles_btn.TabIndex = 1;
            this.genfiles_btn.Text = "Create";
            this.genfiles_btn.UseVisualStyleBackColor = false;
            this.genfiles_btn.Click += new System.EventHandler(this.genfiles_btn_Click);
            // 
            // nb_fs_tb
            // 
            this.nb_fs_tb.Location = new System.Drawing.Point(0, 110);
            this.nb_fs_tb.Name = "nb_fs_tb";
            this.nb_fs_tb.Size = new System.Drawing.Size(150, 20);
            this.nb_fs_tb.TabIndex = 0;
            this.nb_fs_tb.Text = "1";
            // 
            // close_btn
            // 
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Location = new System.Drawing.Point(230, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(20, 20);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(250, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gn_t_btn);
            this.Controls.Add(this.gn_f_btn);
            this.Controls.Add(this.genfiles_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.nb_fs_tb);
            this.Controls.Add(this.Folder_path_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox Folder_path_tb;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Button gn_f_btn;
        private System.Windows.Forms.Button gn_t_btn;
        private System.Windows.Forms.Button genfiles_btn;
        private System.Windows.Forms.TextBox nb_fs_tb;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label1;
    }
}


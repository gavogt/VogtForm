namespace Vogt_Form
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
            this.listbox = new System.Windows.Forms.ListBox();
            this.textbox_f_name = new System.Windows.Forms.TextBox();
            this.textbox_l_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_first_name = new System.Windows.Forms.Label();
            this.lbl_last_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(12, 12);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(159, 186);
            this.listbox.TabIndex = 0;
            // 
            // textbox_f_name
            // 
            this.textbox_f_name.Location = new System.Drawing.Point(180, 42);
            this.textbox_f_name.Name = "textbox_f_name";
            this.textbox_f_name.Size = new System.Drawing.Size(115, 20);
            this.textbox_f_name.TabIndex = 1;
            this.textbox_f_name.Text = "Enter your first name";
            // 
            // textbox_l_name
            // 
            this.textbox_l_name.Location = new System.Drawing.Point(180, 81);
            this.textbox_l_name.Name = "textbox_l_name";
            this.textbox_l_name.Size = new System.Drawing.Size(115, 20);
            this.textbox_l_name.TabIndex = 2;
            this.textbox_l_name.Text = "Enter your last name";
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Location = new System.Drawing.Point(205, 119);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.AutoSize = true;
            this.lbl_first_name.Location = new System.Drawing.Point(178, 26);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(55, 13);
            this.lbl_first_name.TabIndex = 4;
            this.lbl_first_name.Text = "First name";
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.AutoSize = true;
            this.lbl_last_name.Location = new System.Drawing.Point(177, 65);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(56, 13);
            this.lbl_last_name.TabIndex = 5;
            this.lbl_last_name.Text = "Last name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 215);
            this.Controls.Add(this.lbl_last_name);
            this.Controls.Add(this.lbl_first_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.textbox_l_name);
            this.Controls.Add(this.textbox_f_name);
            this.Controls.Add(this.listbox);
            this.Name = "Form1";
            this.Text = "Names To Remember. No delete!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.TextBox textbox_f_name;
        private System.Windows.Forms.TextBox textbox_l_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_first_name;
        private System.Windows.Forms.Label lbl_last_name;
    }
}


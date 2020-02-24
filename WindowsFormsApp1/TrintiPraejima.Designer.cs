namespace PCMSystem
{
    partial class TrintiPraejima
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
            this.gdelete_button_delete = new System.Windows.Forms.Button();
            this.gdelete_textbox_output = new System.Windows.Forms.ListBox();
            this.gdelete_button_back = new System.Windows.Forms.Button();
            this.gdelete_lable_title = new System.Windows.Forms.Label();
            this.gdelete_dropbox_idList = new System.Windows.Forms.ComboBox();
            this.gdelete_button_find = new System.Windows.Forms.Button();
            this.gdelete_label_paieska = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gdelete_button_delete
            // 
            this.gdelete_button_delete.Enabled = false;
            this.gdelete_button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gdelete_button_delete.Location = new System.Drawing.Point(167, 275);
            this.gdelete_button_delete.Name = "gdelete_button_delete";
            this.gdelete_button_delete.Size = new System.Drawing.Size(80, 25);
            this.gdelete_button_delete.TabIndex = 20;
            this.gdelete_button_delete.Text = "Trinti";
            this.gdelete_button_delete.UseVisualStyleBackColor = true;
            this.gdelete_button_delete.Click += new System.EventHandler(this.gdelete_button_delete_Click);
            // 
            // gdelete_textbox_output
            // 
            this.gdelete_textbox_output.FormattingEnabled = true;
            this.gdelete_textbox_output.IntegralHeight = false;
            this.gdelete_textbox_output.Location = new System.Drawing.Point(12, 141);
            this.gdelete_textbox_output.Name = "gdelete_textbox_output";
            this.gdelete_textbox_output.Size = new System.Drawing.Size(394, 120);
            this.gdelete_textbox_output.TabIndex = 19;
            // 
            // gdelete_button_back
            // 
            this.gdelete_button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gdelete_button_back.Location = new System.Drawing.Point(326, 275);
            this.gdelete_button_back.Name = "gdelete_button_back";
            this.gdelete_button_back.Size = new System.Drawing.Size(80, 25);
            this.gdelete_button_back.TabIndex = 18;
            this.gdelete_button_back.Text = "Grįžti";
            this.gdelete_button_back.UseVisualStyleBackColor = true;
            this.gdelete_button_back.Click += new System.EventHandler(this.gdelete_button_back_Click);
            // 
            // gdelete_lable_title
            // 
            this.gdelete_lable_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gdelete_lable_title.Location = new System.Drawing.Point(36, 27);
            this.gdelete_lable_title.Name = "gdelete_lable_title";
            this.gdelete_lable_title.Size = new System.Drawing.Size(340, 40);
            this.gdelete_lable_title.TabIndex = 17;
            this.gdelete_lable_title.Text = "Ištrinti praėjimą";
            this.gdelete_lable_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gdelete_dropbox_idList
            // 
            this.gdelete_dropbox_idList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gdelete_dropbox_idList.FormattingEnabled = true;
            this.gdelete_dropbox_idList.Location = new System.Drawing.Point(12, 96);
            this.gdelete_dropbox_idList.Name = "gdelete_dropbox_idList";
            this.gdelete_dropbox_idList.Size = new System.Drawing.Size(121, 21);
            this.gdelete_dropbox_idList.TabIndex = 16;
            this.gdelete_dropbox_idList.SelectedIndexChanged += new System.EventHandler(this.gdelete_dropbox_idList_SelectedIndexChanged_1);
            // 
            // gdelete_button_find
            // 
            this.gdelete_button_find.Location = new System.Drawing.Point(250, 93);
            this.gdelete_button_find.Name = "gdelete_button_find";
            this.gdelete_button_find.Size = new System.Drawing.Size(80, 25);
            this.gdelete_button_find.TabIndex = 15;
            this.gdelete_button_find.Text = "Ieškoti";
            this.gdelete_button_find.UseVisualStyleBackColor = true;
            this.gdelete_button_find.Click += new System.EventHandler(this.gdelete_button_find_Click);
            // 
            // gdelete_label_paieska
            // 
            this.gdelete_label_paieska.Location = new System.Drawing.Point(12, 73);
            this.gdelete_label_paieska.Name = "gdelete_label_paieska";
            this.gdelete_label_paieska.Size = new System.Drawing.Size(160, 15);
            this.gdelete_label_paieska.TabIndex = 14;
            this.gdelete_label_paieska.Text = "Pasirinkite praėjimą pagal ID";
            this.gdelete_label_paieska.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TrintiPraejima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.gdelete_button_delete);
            this.Controls.Add(this.gdelete_textbox_output);
            this.Controls.Add(this.gdelete_button_back);
            this.Controls.Add(this.gdelete_lable_title);
            this.Controls.Add(this.gdelete_dropbox_idList);
            this.Controls.Add(this.gdelete_button_find);
            this.Controls.Add(this.gdelete_label_paieska);
            this.Name = "TrintiPraejima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pašalinti Praėjimą";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gdelete_button_delete;
        private System.Windows.Forms.ListBox gdelete_textbox_output;
        private System.Windows.Forms.Button gdelete_button_back;
        private System.Windows.Forms.Label gdelete_lable_title;
        private System.Windows.Forms.ComboBox gdelete_dropbox_idList;
        private System.Windows.Forms.Button gdelete_button_find;
        private System.Windows.Forms.Label gdelete_label_paieska;
    }
}
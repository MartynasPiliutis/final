namespace PCMSystem
{
    partial class TrintiDarbuotoja
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
            this.delete_textbox_output = new System.Windows.Forms.ListBox();
            this.delete_button_back = new System.Windows.Forms.Button();
            this.ddelete_lable_title = new System.Windows.Forms.Label();
            this.delete_dropbox_idList = new System.Windows.Forms.ComboBox();
            this.delete_button_find = new System.Windows.Forms.Button();
            this.delete_label_paieska = new System.Windows.Forms.Label();
            this.delete_button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete_textbox_output
            // 
            this.delete_textbox_output.FormattingEnabled = true;
            this.delete_textbox_output.IntegralHeight = false;
            this.delete_textbox_output.Location = new System.Drawing.Point(12, 141);
            this.delete_textbox_output.Name = "delete_textbox_output";
            this.delete_textbox_output.Size = new System.Drawing.Size(394, 120);
            this.delete_textbox_output.TabIndex = 12;
            // 
            // delete_button_back
            // 
            this.delete_button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.delete_button_back.Location = new System.Drawing.Point(326, 275);
            this.delete_button_back.Name = "delete_button_back";
            this.delete_button_back.Size = new System.Drawing.Size(80, 25);
            this.delete_button_back.TabIndex = 11;
            this.delete_button_back.Text = "Grįžti";
            this.delete_button_back.UseVisualStyleBackColor = true;
            this.delete_button_back.Click += new System.EventHandler(this.delete_button_back_Click);
            // 
            // ddelete_lable_title
            // 
            this.ddelete_lable_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ddelete_lable_title.Location = new System.Drawing.Point(36, 27);
            this.ddelete_lable_title.Name = "ddelete_lable_title";
            this.ddelete_lable_title.Size = new System.Drawing.Size(340, 40);
            this.ddelete_lable_title.TabIndex = 10;
            this.ddelete_lable_title.Text = "Ištrinti darbuotoją";
            this.ddelete_lable_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delete_dropbox_idList
            // 
            this.delete_dropbox_idList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delete_dropbox_idList.FormattingEnabled = true;
            this.delete_dropbox_idList.Location = new System.Drawing.Point(12, 96);
            this.delete_dropbox_idList.Name = "delete_dropbox_idList";
            this.delete_dropbox_idList.Size = new System.Drawing.Size(121, 21);
            this.delete_dropbox_idList.TabIndex = 9;
            this.delete_dropbox_idList.SelectedIndexChanged += new System.EventHandler(this.delete_dropbox_idList_SelectedIndexChanged);
            // 
            // delete_button_find
            // 
            this.delete_button_find.Location = new System.Drawing.Point(250, 93);
            this.delete_button_find.Name = "delete_button_find";
            this.delete_button_find.Size = new System.Drawing.Size(80, 25);
            this.delete_button_find.TabIndex = 8;
            this.delete_button_find.Text = "Ieškoti";
            this.delete_button_find.UseVisualStyleBackColor = true;
            this.delete_button_find.Click += new System.EventHandler(this.delete_button_find_Click);
            // 
            // delete_label_paieska
            // 
            this.delete_label_paieska.Location = new System.Drawing.Point(12, 73);
            this.delete_label_paieska.Name = "delete_label_paieska";
            this.delete_label_paieska.Size = new System.Drawing.Size(160, 15);
            this.delete_label_paieska.TabIndex = 7;
            this.delete_label_paieska.Text = "Pasirinkite darbuotoją pagal ID";
            this.delete_label_paieska.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // delete_button_delete
            // 
            this.delete_button_delete.Enabled = false;
            this.delete_button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.delete_button_delete.Location = new System.Drawing.Point(167, 275);
            this.delete_button_delete.Name = "delete_button_delete";
            this.delete_button_delete.Size = new System.Drawing.Size(80, 25);
            this.delete_button_delete.TabIndex = 13;
            this.delete_button_delete.Text = "Trinti";
            this.delete_button_delete.UseVisualStyleBackColor = true;
            this.delete_button_delete.Click += new System.EventHandler(this.delete_button_delete_Click);
            // 
            // TrintiDarbuotoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.delete_button_delete);
            this.Controls.Add(this.delete_textbox_output);
            this.Controls.Add(this.delete_button_back);
            this.Controls.Add(this.ddelete_lable_title);
            this.Controls.Add(this.delete_dropbox_idList);
            this.Controls.Add(this.delete_button_find);
            this.Controls.Add(this.delete_label_paieska);
            this.Name = "TrintiDarbuotoja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ištrinti darbuotoją";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox delete_textbox_output;
        private System.Windows.Forms.Button delete_button_back;
        private System.Windows.Forms.Label ddelete_lable_title;
        private System.Windows.Forms.ComboBox delete_dropbox_idList;
        private System.Windows.Forms.Button delete_button_find;
        private System.Windows.Forms.Label delete_label_paieska;
        private System.Windows.Forms.Button delete_button_delete;
    }
}
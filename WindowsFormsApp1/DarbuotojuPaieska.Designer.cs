namespace PCMSystem
{
    partial class DarbuotojuPaieska
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
            this.dfind_label_paieska = new System.Windows.Forms.Label();
            this.dfind_button_find = new System.Windows.Forms.Button();
            this.dfind_dropbox_idList = new System.Windows.Forms.ComboBox();
            this.dfind_textbox_output = new System.Windows.Forms.TextBox();
            this.dfind_lable_title = new System.Windows.Forms.Label();
            this.dfind_button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dfind_label_paieska
            // 
            this.dfind_label_paieska.Location = new System.Drawing.Point(12, 88);
            this.dfind_label_paieska.Name = "dfind_label_paieska";
            this.dfind_label_paieska.Size = new System.Drawing.Size(160, 15);
            this.dfind_label_paieska.TabIndex = 0;
            this.dfind_label_paieska.Text = "Pasirinkite darbuotoją pagal ID";
            this.dfind_label_paieska.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dfind_button_find
            // 
            this.dfind_button_find.Location = new System.Drawing.Point(250, 108);
            this.dfind_button_find.Name = "dfind_button_find";
            this.dfind_button_find.Size = new System.Drawing.Size(80, 25);
            this.dfind_button_find.TabIndex = 1;
            this.dfind_button_find.Text = "Ieškoti";
            this.dfind_button_find.UseVisualStyleBackColor = true;
            // 
            // dfind_dropbox_idList
            // 
            this.dfind_dropbox_idList.FormattingEnabled = true;
            this.dfind_dropbox_idList.Location = new System.Drawing.Point(12, 111);
            this.dfind_dropbox_idList.Name = "dfind_dropbox_idList";
            this.dfind_dropbox_idList.Size = new System.Drawing.Size(121, 21);
            this.dfind_dropbox_idList.TabIndex = 2;
            this.dfind_dropbox_idList.SelectedIndexChanged += new System.EventHandler(this.dfind_dropbox_idList_SelectedIndexChanged);
            // 
            // dfind_textbox_output
            // 
            this.dfind_textbox_output.Location = new System.Drawing.Point(12, 156);
            this.dfind_textbox_output.Multiline = true;
            this.dfind_textbox_output.Name = "dfind_textbox_output";
            this.dfind_textbox_output.ReadOnly = true;
            this.dfind_textbox_output.Size = new System.Drawing.Size(394, 120);
            this.dfind_textbox_output.TabIndex = 3;
            // 
            // dfind_lable_title
            // 
            this.dfind_lable_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.dfind_lable_title.Location = new System.Drawing.Point(36, 42);
            this.dfind_lable_title.Name = "dfind_lable_title";
            this.dfind_lable_title.Size = new System.Drawing.Size(340, 40);
            this.dfind_lable_title.TabIndex = 4;
            this.dfind_lable_title.Text = "Darbuotojų paieška";
            this.dfind_lable_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dfind_button_back
            // 
            this.dfind_button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.dfind_button_back.Location = new System.Drawing.Point(167, 290);
            this.dfind_button_back.Name = "dfind_button_back";
            this.dfind_button_back.Size = new System.Drawing.Size(80, 25);
            this.dfind_button_back.TabIndex = 5;
            this.dfind_button_back.Text = "Grįžti";
            this.dfind_button_back.UseVisualStyleBackColor = true;
            this.dfind_button_back.Click += new System.EventHandler(this.dfind_button_back_Click);
            // 
            // DarbuotojuPaieska
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.dfind_button_back);
            this.Controls.Add(this.dfind_lable_title);
            this.Controls.Add(this.dfind_textbox_output);
            this.Controls.Add(this.dfind_dropbox_idList);
            this.Controls.Add(this.dfind_button_find);
            this.Controls.Add(this.dfind_label_paieska);
            this.Name = "DarbuotojuPaieska";
            this.Text = "Darbuotojų paieška";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dfind_label_paieska;
        private System.Windows.Forms.Button dfind_button_find;
        private System.Windows.Forms.ComboBox dfind_dropbox_idList;
        private System.Windows.Forms.TextBox dfind_textbox_output;
        private System.Windows.Forms.Label dfind_lable_title;
        private System.Windows.Forms.Button dfind_button_back;
    }
}
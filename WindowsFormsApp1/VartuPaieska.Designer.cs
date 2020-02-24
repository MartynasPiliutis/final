namespace PCMSystem
{
    partial class VartuPaieska
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
            this.vfind_textbox_output = new System.Windows.Forms.ListBox();
            this.vfind_button_back = new System.Windows.Forms.Button();
            this.dfind_lable_title = new System.Windows.Forms.Label();
            this.vfind_dropbox_idList = new System.Windows.Forms.ComboBox();
            this.vfind_button_find = new System.Windows.Forms.Button();
            this.vfind_label_paieska = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vfind_textbox_output
            // 
            this.vfind_textbox_output.FormattingEnabled = true;
            this.vfind_textbox_output.IntegralHeight = false;
            this.vfind_textbox_output.Location = new System.Drawing.Point(12, 141);
            this.vfind_textbox_output.Name = "vfind_textbox_output";
            this.vfind_textbox_output.Size = new System.Drawing.Size(394, 120);
            this.vfind_textbox_output.TabIndex = 12;
            // 
            // vfind_button_back
            // 
            this.vfind_button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.vfind_button_back.Location = new System.Drawing.Point(167, 275);
            this.vfind_button_back.Name = "vfind_button_back";
            this.vfind_button_back.Size = new System.Drawing.Size(80, 25);
            this.vfind_button_back.TabIndex = 11;
            this.vfind_button_back.Text = "Grįžti";
            this.vfind_button_back.UseVisualStyleBackColor = true;
            this.vfind_button_back.Click += new System.EventHandler(this.vfind_button_back_Click);
            // 
            // dfind_lable_title
            // 
            this.dfind_lable_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.dfind_lable_title.Location = new System.Drawing.Point(38, 27);
            this.dfind_lable_title.Name = "dfind_lable_title";
            this.dfind_lable_title.Size = new System.Drawing.Size(340, 40);
            this.dfind_lable_title.TabIndex = 10;
            this.dfind_lable_title.Text = "Vartų paieška";
            this.dfind_lable_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vfind_dropbox_idList
            // 
            this.vfind_dropbox_idList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vfind_dropbox_idList.FormattingEnabled = true;
            this.vfind_dropbox_idList.Location = new System.Drawing.Point(38, 96);
            this.vfind_dropbox_idList.Name = "vfind_dropbox_idList";
            this.vfind_dropbox_idList.Size = new System.Drawing.Size(121, 21);
            this.vfind_dropbox_idList.TabIndex = 9;
            // 
            // vfind_button_find
            // 
            this.vfind_button_find.Location = new System.Drawing.Point(260, 93);
            this.vfind_button_find.Name = "vfind_button_find";
            this.vfind_button_find.Size = new System.Drawing.Size(80, 25);
            this.vfind_button_find.TabIndex = 8;
            this.vfind_button_find.Text = "Ieškoti";
            this.vfind_button_find.UseVisualStyleBackColor = true;
            this.vfind_button_find.Click += new System.EventHandler(this.vfind_button_find_Click);
            // 
            // vfind_label_paieska
            // 
            this.vfind_label_paieska.Location = new System.Drawing.Point(38, 73);
            this.vfind_label_paieska.Name = "vfind_label_paieska";
            this.vfind_label_paieska.Size = new System.Drawing.Size(160, 15);
            this.vfind_label_paieska.TabIndex = 7;
            this.vfind_label_paieska.Text = "Pasirinkite vartus pagal ID";
            this.vfind_label_paieska.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VartuPaieska
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.vfind_textbox_output);
            this.Controls.Add(this.vfind_button_back);
            this.Controls.Add(this.dfind_lable_title);
            this.Controls.Add(this.vfind_dropbox_idList);
            this.Controls.Add(this.vfind_button_find);
            this.Controls.Add(this.vfind_label_paieska);
            this.Name = "VartuPaieska";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vartų Paieška";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox vfind_textbox_output;
        private System.Windows.Forms.Button vfind_button_back;
        private System.Windows.Forms.Label dfind_lable_title;
        private System.Windows.Forms.ComboBox vfind_dropbox_idList;
        private System.Windows.Forms.Button vfind_button_find;
        private System.Windows.Forms.Label vfind_label_paieska;
    }
}
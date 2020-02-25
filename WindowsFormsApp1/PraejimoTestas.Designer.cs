namespace PCMSystem
{
    partial class PraejimasTestas
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
            this.gatetest_label = new System.Windows.Forms.Label();
            this.test_dropbox_employeeidList = new System.Windows.Forms.ComboBox();
            this.test_button_test = new System.Windows.Forms.Button();
            this.test_label_employeeId = new System.Windows.Forms.Label();
            this.test_dropbox_gateidList = new System.Windows.Forms.ComboBox();
            this.test_label_gateId = new System.Windows.Forms.Label();
            this.test_button_back = new System.Windows.Forms.Button();
            this.test_light_green = new System.Windows.Forms.TextBox();
            this.test_light_red = new System.Windows.Forms.TextBox();
            this.test_button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gatetest_label
            // 
            this.gatetest_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gatetest_label.Location = new System.Drawing.Point(38, 9);
            this.gatetest_label.Name = "gatetest_label";
            this.gatetest_label.Size = new System.Drawing.Size(340, 40);
            this.gatetest_label.TabIndex = 1;
            this.gatetest_label.Text = "Praėjimo Testas";
            this.gatetest_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test_dropbox_employeeidList
            // 
            this.test_dropbox_employeeidList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.test_dropbox_employeeidList.FormattingEnabled = true;
            this.test_dropbox_employeeidList.Location = new System.Drawing.Point(27, 86);
            this.test_dropbox_employeeidList.Name = "test_dropbox_employeeidList";
            this.test_dropbox_employeeidList.Size = new System.Drawing.Size(121, 21);
            this.test_dropbox_employeeidList.TabIndex = 5;
            // 
            // test_button_test
            // 
            this.test_button_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.test_button_test.Location = new System.Drawing.Point(108, 150);
            this.test_button_test.Name = "test_button_test";
            this.test_button_test.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.test_button_test.Size = new System.Drawing.Size(200, 30);
            this.test_button_test.TabIndex = 4;
            this.test_button_test.Text = "Tikrinti";
            this.test_button_test.UseVisualStyleBackColor = true;
            this.test_button_test.Click += new System.EventHandler(this.test_button_test_Click);
            // 
            // test_label_employeeId
            // 
            this.test_label_employeeId.Location = new System.Drawing.Point(27, 63);
            this.test_label_employeeId.Name = "test_label_employeeId";
            this.test_label_employeeId.Size = new System.Drawing.Size(160, 15);
            this.test_label_employeeId.TabIndex = 3;
            this.test_label_employeeId.Text = "Pasirinkite darbuotoją pagal ID";
            this.test_label_employeeId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // test_dropbox_gateidList
            // 
            this.test_dropbox_gateidList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.test_dropbox_gateidList.FormattingEnabled = true;
            this.test_dropbox_gateidList.Location = new System.Drawing.Point(267, 86);
            this.test_dropbox_gateidList.Name = "test_dropbox_gateidList";
            this.test_dropbox_gateidList.Size = new System.Drawing.Size(121, 21);
            this.test_dropbox_gateidList.TabIndex = 7;
            // 
            // test_label_gateId
            // 
            this.test_label_gateId.Location = new System.Drawing.Point(228, 63);
            this.test_label_gateId.Name = "test_label_gateId";
            this.test_label_gateId.Size = new System.Drawing.Size(160, 15);
            this.test_label_gateId.TabIndex = 6;
            this.test_label_gateId.Text = "Pasirinkite praėjimą pagal ID";
            this.test_label_gateId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // test_button_back
            // 
            this.test_button_back.Location = new System.Drawing.Point(158, 284);
            this.test_button_back.Name = "test_button_back";
            this.test_button_back.Size = new System.Drawing.Size(100, 30);
            this.test_button_back.TabIndex = 8;
            this.test_button_back.Text = "Grįžti";
            this.test_button_back.UseVisualStyleBackColor = true;
            this.test_button_back.Click += new System.EventHandler(this.test_button_back_Click);
            // 
            // test_light_green
            // 
            this.test_light_green.BackColor = System.Drawing.Color.Green;
            this.test_light_green.Enabled = false;
            this.test_light_green.Location = new System.Drawing.Point(27, 219);
            this.test_light_green.Name = "test_light_green";
            this.test_light_green.ReadOnly = true;
            this.test_light_green.Size = new System.Drawing.Size(100, 20);
            this.test_light_green.TabIndex = 9;
            // 
            // test_light_red
            // 
            this.test_light_red.BackColor = System.Drawing.Color.Red;
            this.test_light_red.Enabled = false;
            this.test_light_red.Location = new System.Drawing.Point(288, 219);
            this.test_light_red.Name = "test_light_red";
            this.test_light_red.ReadOnly = true;
            this.test_light_red.Size = new System.Drawing.Size(100, 20);
            this.test_light_red.TabIndex = 10;
            // 
            // test_button_ok
            // 
            this.test_button_ok.Enabled = false;
            this.test_button_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.test_button_ok.Location = new System.Drawing.Point(108, 150);
            this.test_button_ok.Name = "test_button_ok";
            this.test_button_ok.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.test_button_ok.Size = new System.Drawing.Size(200, 30);
            this.test_button_ok.TabIndex = 11;
            this.test_button_ok.Text = "OK";
            this.test_button_ok.UseVisualStyleBackColor = true;
            this.test_button_ok.Click += new System.EventHandler(this.test_button_ok_Click);
            // 
            // PraejimasTestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.test_button_ok);
            this.Controls.Add(this.test_light_red);
            this.Controls.Add(this.test_light_green);
            this.Controls.Add(this.test_button_back);
            this.Controls.Add(this.test_dropbox_gateidList);
            this.Controls.Add(this.test_label_gateId);
            this.Controls.Add(this.test_dropbox_employeeidList);
            this.Controls.Add(this.test_button_test);
            this.Controls.Add(this.test_label_employeeId);
            this.Controls.Add(this.gatetest_label);
            this.Name = "PraejimasTestas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Praėjimo Testas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gatetest_label;
        private System.Windows.Forms.ComboBox test_dropbox_employeeidList;
        private System.Windows.Forms.Button test_button_test;
        private System.Windows.Forms.Label test_label_employeeId;
        private System.Windows.Forms.ComboBox test_dropbox_gateidList;
        private System.Windows.Forms.Label test_label_gateId;
        private System.Windows.Forms.Button test_button_back;
        private System.Windows.Forms.TextBox test_light_green;
        private System.Windows.Forms.TextBox test_light_red;
        private System.Windows.Forms.Button test_button_ok;
    }
}
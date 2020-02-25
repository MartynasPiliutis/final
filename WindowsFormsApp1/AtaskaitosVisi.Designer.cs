namespace PCMSystem
{
    partial class AtaskaitosVisi
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
            this.reportAll_label = new System.Windows.Forms.Label();
            this.reportAll_button_back = new System.Windows.Forms.Button();
            this.check_filter_All = new System.Windows.Forms.RadioButton();
            this.check_filter_true = new System.Windows.Forms.RadioButton();
            this.check_filter_false = new System.Windows.Forms.RadioButton();
            this.FiltrasAll = new System.Windows.Forms.GroupBox();
            this.reportAll_button_filtruoti = new System.Windows.Forms.Button();
            this.FiltrasAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportAll_label
            // 
            this.reportAll_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportAll_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.reportAll_label.Location = new System.Drawing.Point(38, 22);
            this.reportAll_label.Name = "reportAll_label";
            this.reportAll_label.Size = new System.Drawing.Size(340, 40);
            this.reportAll_label.TabIndex = 7;
            this.reportAll_label.Text = "Ataskaitos -Visi Įvykiai";
            this.reportAll_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportAll_button_back
            // 
            this.reportAll_button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.reportAll_button_back.Location = new System.Drawing.Point(160, 272);
            this.reportAll_button_back.Name = "reportAll_button_back";
            this.reportAll_button_back.Size = new System.Drawing.Size(88, 25);
            this.reportAll_button_back.TabIndex = 10;
            this.reportAll_button_back.Text = "Grįžti";
            this.reportAll_button_back.UseVisualStyleBackColor = true;
            this.reportAll_button_back.Click += new System.EventHandler(this.reportAll_button_back_Click);
            // 
            // check_filter_All
            // 
            this.check_filter_All.AutoSize = true;
            this.check_filter_All.Location = new System.Drawing.Point(126, 19);
            this.check_filter_All.Name = "check_filter_All";
            this.check_filter_All.Size = new System.Drawing.Size(73, 17);
            this.check_filter_All.TabIndex = 11;
            this.check_filter_All.TabStop = true;
            this.check_filter_All.Text = "Visi įvykiai";
            this.check_filter_All.UseVisualStyleBackColor = true;
            this.check_filter_All.CheckedChanged += new System.EventHandler(this.check_filter_All_CheckedChanged);
            // 
            // check_filter_true
            // 
            this.check_filter_true.AutoSize = true;
            this.check_filter_true.Location = new System.Drawing.Point(126, 42);
            this.check_filter_true.Name = "check_filter_true";
            this.check_filter_true.Size = new System.Drawing.Size(95, 17);
            this.check_filter_true.TabIndex = 12;
            this.check_filter_true.TabStop = true;
            this.check_filter_true.Text = "\"TRUE\" įvykai";
            this.check_filter_true.UseVisualStyleBackColor = true;
            this.check_filter_true.CheckedChanged += new System.EventHandler(this.check_filter_true_CheckedChanged);
            // 
            // check_filter_false
            // 
            this.check_filter_false.AutoSize = true;
            this.check_filter_false.Location = new System.Drawing.Point(126, 65);
            this.check_filter_false.Name = "check_filter_false";
            this.check_filter_false.Size = new System.Drawing.Size(100, 17);
            this.check_filter_false.TabIndex = 13;
            this.check_filter_false.TabStop = true;
            this.check_filter_false.Text = "\"FALSE\" įvykiai";
            this.check_filter_false.UseVisualStyleBackColor = true;
            this.check_filter_false.CheckedChanged += new System.EventHandler(this.check_filter_false_CheckedChanged);
            // 
            // FiltrasAll
            // 
            this.FiltrasAll.Controls.Add(this.check_filter_All);
            this.FiltrasAll.Controls.Add(this.check_filter_false);
            this.FiltrasAll.Controls.Add(this.check_filter_true);
            this.FiltrasAll.Location = new System.Drawing.Point(42, 85);
            this.FiltrasAll.Name = "FiltrasAll";
            this.FiltrasAll.Size = new System.Drawing.Size(336, 100);
            this.FiltrasAll.TabIndex = 14;
            this.FiltrasAll.TabStop = false;
            this.FiltrasAll.Text = "Pasirinkite ataskiatos filtrą";
            this.FiltrasAll.Enter += new System.EventHandler(this.FiltrasAll_Enter);
            // 
            // reportAll_button_filtruoti
            // 
            this.reportAll_button_filtruoti.Enabled = false;
            this.reportAll_button_filtruoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.reportAll_button_filtruoti.Location = new System.Drawing.Point(160, 241);
            this.reportAll_button_filtruoti.Name = "reportAll_button_filtruoti";
            this.reportAll_button_filtruoti.Size = new System.Drawing.Size(88, 25);
            this.reportAll_button_filtruoti.TabIndex = 15;
            this.reportAll_button_filtruoti.Text = "Peržiūrėti";
            this.reportAll_button_filtruoti.UseVisualStyleBackColor = true;
            this.reportAll_button_filtruoti.Click += new System.EventHandler(this.reportAll_button_filtruoti_Click);
            // 
            // AtaskaitosVisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.reportAll_button_filtruoti);
            this.Controls.Add(this.FiltrasAll);
            this.Controls.Add(this.reportAll_button_back);
            this.Controls.Add(this.reportAll_label);
            this.Name = "AtaskaitosVisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ataskaitos - visi įvykiai";
            this.FiltrasAll.ResumeLayout(false);
            this.FiltrasAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label reportAll_label;
        private System.Windows.Forms.Button reportAll_button_back;
        private System.Windows.Forms.RadioButton check_filter_All;
        private System.Windows.Forms.RadioButton check_filter_true;
        private System.Windows.Forms.RadioButton check_filter_false;
        private System.Windows.Forms.GroupBox FiltrasAll;
        private System.Windows.Forms.Button reportAll_button_filtruoti;
    }
}
namespace PCMSystem
{
    partial class Ataskaitos
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
            this.main_button_exit = new System.Windows.Forms.Button();
            this.report_button_data = new System.Windows.Forms.Button();
            this.report_button_vartai = new System.Windows.Forms.Button();
            this.report_button_darbuotojai = new System.Windows.Forms.Button();
            this.report_button_all = new System.Windows.Forms.Button();
            this.report_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // main_button_exit
            // 
            this.main_button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.main_button_exit.Location = new System.Drawing.Point(168, 272);
            this.main_button_exit.Name = "main_button_exit";
            this.main_button_exit.Size = new System.Drawing.Size(80, 25);
            this.main_button_exit.TabIndex = 11;
            this.main_button_exit.Text = "Baigti";
            this.main_button_exit.UseVisualStyleBackColor = true;
            this.main_button_exit.Click += new System.EventHandler(this.main_button_exit_Click);
            // 
            // report_button_data
            // 
            this.report_button_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report_button_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.report_button_data.Location = new System.Drawing.Point(38, 226);
            this.report_button_data.Name = "report_button_data";
            this.report_button_data.Size = new System.Drawing.Size(340, 40);
            this.report_button_data.TabIndex = 10;
            this.report_button_data.Text = "Pagal datą";
            this.report_button_data.UseVisualStyleBackColor = true;
            // 
            // report_button_vartai
            // 
            this.report_button_vartai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report_button_vartai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.report_button_vartai.Location = new System.Drawing.Point(38, 180);
            this.report_button_vartai.Name = "report_button_vartai";
            this.report_button_vartai.Size = new System.Drawing.Size(340, 40);
            this.report_button_vartai.TabIndex = 9;
            this.report_button_vartai.Text = "Praėjimai";
            this.report_button_vartai.UseVisualStyleBackColor = true;
            this.report_button_vartai.Click += new System.EventHandler(this.report_button_vartai_Click);
            // 
            // report_button_darbuotojai
            // 
            this.report_button_darbuotojai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report_button_darbuotojai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.report_button_darbuotojai.Location = new System.Drawing.Point(38, 134);
            this.report_button_darbuotojai.Name = "report_button_darbuotojai";
            this.report_button_darbuotojai.Size = new System.Drawing.Size(340, 40);
            this.report_button_darbuotojai.TabIndex = 8;
            this.report_button_darbuotojai.Text = "Darbuotojai";
            this.report_button_darbuotojai.UseVisualStyleBackColor = true;
            this.report_button_darbuotojai.Click += new System.EventHandler(this.main_button_vartai_Click);
            // 
            // report_button_all
            // 
            this.report_button_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.report_button_all.Location = new System.Drawing.Point(38, 88);
            this.report_button_all.Name = "report_button_all";
            this.report_button_all.Size = new System.Drawing.Size(340, 40);
            this.report_button_all.TabIndex = 7;
            this.report_button_all.Text = "Visi ivykiai";
            this.report_button_all.UseVisualStyleBackColor = true;
            this.report_button_all.Click += new System.EventHandler(this.report_button_all_Click);
            // 
            // report_label
            // 
            this.report_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.report_label.Location = new System.Drawing.Point(38, 42);
            this.report_label.Name = "report_label";
            this.report_label.Size = new System.Drawing.Size(340, 40);
            this.report_label.TabIndex = 6;
            this.report_label.Text = "Ataskaitos";
            this.report_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ataskaitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.main_button_exit);
            this.Controls.Add(this.report_button_data);
            this.Controls.Add(this.report_button_vartai);
            this.Controls.Add(this.report_button_darbuotojai);
            this.Controls.Add(this.report_button_all);
            this.Controls.Add(this.report_label);
            this.Name = "Ataskaitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ataskaitos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button main_button_exit;
        private System.Windows.Forms.Button report_button_data;
        private System.Windows.Forms.Button report_button_vartai;
        private System.Windows.Forms.Button report_button_darbuotojai;
        private System.Windows.Forms.Button report_button_all;
        private System.Windows.Forms.Label report_label;
    }
}
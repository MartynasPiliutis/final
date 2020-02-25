namespace PCMSystem
{
    partial class Ivykiai
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
            this.ivykiai_button_back = new System.Windows.Forms.Button();
            this.ivykiai_button_remove = new System.Windows.Forms.Button();
            this.ivykiai_button_add = new System.Windows.Forms.Button();
            this.ivykiai_button_rasti = new System.Windows.Forms.Button();
            this.ivykiai_label_ivykiai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ivykiai_button_back
            // 
            this.ivykiai_button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ivykiai_button_back.Location = new System.Drawing.Point(168, 266);
            this.ivykiai_button_back.Name = "ivykiai_button_back";
            this.ivykiai_button_back.Size = new System.Drawing.Size(80, 25);
            this.ivykiai_button_back.TabIndex = 9;
            this.ivykiai_button_back.Text = "Grįžti";
            this.ivykiai_button_back.UseVisualStyleBackColor = true;
            this.ivykiai_button_back.Click += new System.EventHandler(this.ivykiai_button_back_Click);
            // 
            // ivykiai_button_remove
            // 
            this.ivykiai_button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ivykiai_button_remove.Location = new System.Drawing.Point(39, 174);
            this.ivykiai_button_remove.Name = "darbuotojai_button_remove";
            this.ivykiai_button_remove.Size = new System.Drawing.Size(340, 40);
            this.ivykiai_button_remove.TabIndex = 8;
            this.ivykiai_button_remove.Text = "Pašalinti";
            this.ivykiai_button_remove.UseVisualStyleBackColor = true;
            this.ivykiai_button_remove.Click += new System.EventHandler(this.ivykiai_button_remove_Click);
            // 
            // ivykiai_button_add
            // 
            this.ivykiai_button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ivykiai_button_add.Location = new System.Drawing.Point(39, 128);
            this.ivykiai_button_add.Name = "darbuotojai_button_add";
            this.ivykiai_button_add.Size = new System.Drawing.Size(340, 40);
            this.ivykiai_button_add.TabIndex = 7;
            this.ivykiai_button_add.Text = "Pridėti naują";
            this.ivykiai_button_add.UseVisualStyleBackColor = true;
            this.ivykiai_button_add.Click += new System.EventHandler(this.ivykiai_button_add_Click);
            // 
            // ivykiai_button_rasti
            // 
            this.ivykiai_button_rasti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ivykiai_button_rasti.Location = new System.Drawing.Point(39, 82);
            this.ivykiai_button_rasti.Name = "ivykiai_button_rasti";
            this.ivykiai_button_rasti.Size = new System.Drawing.Size(340, 40);
            this.ivykiai_button_rasti.TabIndex = 6;
            this.ivykiai_button_rasti.Text = "Rasti";
            this.ivykiai_button_rasti.UseVisualStyleBackColor = true;
            this.ivykiai_button_rasti.Click += new System.EventHandler(this.ivykiai_button_rasti_Click);
            // 
            // ivykiai_label_ivykiai
            // 
            this.ivykiai_label_ivykiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ivykiai_label_ivykiai.Location = new System.Drawing.Point(39, 36);
            this.ivykiai_label_ivykiai.Name = "ivykiai_label_ivykiai";
            this.ivykiai_label_ivykiai.Size = new System.Drawing.Size(340, 40);
            this.ivykiai_label_ivykiai.TabIndex = 5;
            this.ivykiai_label_ivykiai.Text = "Įvykiai";
            this.ivykiai_label_ivykiai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ivykiai_label_ivykiai.Click += new System.EventHandler(this.ivykiai_label_ivykiai_Click);
            // 
            // Ivykiai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.ivykiai_button_back);
            this.Controls.Add(this.ivykiai_button_remove);
            this.Controls.Add(this.ivykiai_button_add);
            this.Controls.Add(this.ivykiai_button_rasti);
            this.Controls.Add(this.ivykiai_label_ivykiai);
            this.Name = "Ivykiai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Įvykiai";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ivykiai_button_back;
        private System.Windows.Forms.Button ivykiai_button_remove;
        private System.Windows.Forms.Button ivykiai_button_add;
        private System.Windows.Forms.Button ivykiai_button_rasti;
        private System.Windows.Forms.Label ivykiai_label_ivykiai;
    }
}
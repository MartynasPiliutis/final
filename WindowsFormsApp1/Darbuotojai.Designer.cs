namespace PCMSystem
{
    partial class Darbuotojai
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
            this.darbuotojai_label_darbuotojai = new System.Windows.Forms.Label();
            this.darbuotojai_button_rasti = new System.Windows.Forms.Button();
            this.darbuotojai_button_add = new System.Windows.Forms.Button();
            this.darbuotojai_button_remove = new System.Windows.Forms.Button();
            this.darbuotojai_button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // darbuotojai_label_darbuotojai
            // 
            this.darbuotojai_label_darbuotojai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.darbuotojai_label_darbuotojai.Location = new System.Drawing.Point(38, 42);
            this.darbuotojai_label_darbuotojai.Name = "darbuotojai_label_darbuotojai";
            this.darbuotojai_label_darbuotojai.Size = new System.Drawing.Size(340, 40);
            this.darbuotojai_label_darbuotojai.TabIndex = 0;
            this.darbuotojai_label_darbuotojai.Text = "Darbuotojai";
            this.darbuotojai_label_darbuotojai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darbuotojai_button_rasti
            // 
            this.darbuotojai_button_rasti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.darbuotojai_button_rasti.Location = new System.Drawing.Point(38, 88);
            this.darbuotojai_button_rasti.Name = "darbuotojai_button_rasti";
            this.darbuotojai_button_rasti.Size = new System.Drawing.Size(340, 40);
            this.darbuotojai_button_rasti.TabIndex = 1;
            this.darbuotojai_button_rasti.Text = "Rasti";
            this.darbuotojai_button_rasti.UseVisualStyleBackColor = true;
            this.darbuotojai_button_rasti.Click += new System.EventHandler(this.darbuotojai_button_rasti_Click);
            // 
            // darbuotojai_button_add
            // 
            this.darbuotojai_button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.darbuotojai_button_add.Location = new System.Drawing.Point(38, 134);
            this.darbuotojai_button_add.Name = "darbuotojai_button_add";
            this.darbuotojai_button_add.Size = new System.Drawing.Size(340, 40);
            this.darbuotojai_button_add.TabIndex = 2;
            this.darbuotojai_button_add.Text = "Pridėti naują";
            this.darbuotojai_button_add.UseVisualStyleBackColor = true;
            // 
            // darbuotojai_button_remove
            // 
            this.darbuotojai_button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.darbuotojai_button_remove.Location = new System.Drawing.Point(38, 180);
            this.darbuotojai_button_remove.Name = "darbuotojai_button_remove";
            this.darbuotojai_button_remove.Size = new System.Drawing.Size(340, 40);
            this.darbuotojai_button_remove.TabIndex = 3;
            this.darbuotojai_button_remove.Text = "Pašalinti";
            this.darbuotojai_button_remove.UseVisualStyleBackColor = true;
            this.darbuotojai_button_remove.Click += new System.EventHandler(this.darbuotojai_button_remove_Click);
            // 
            // darbuotojai_button_back
            // 
            this.darbuotojai_button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.darbuotojai_button_back.Location = new System.Drawing.Point(167, 272);
            this.darbuotojai_button_back.Name = "darbuotojai_button_back";
            this.darbuotojai_button_back.Size = new System.Drawing.Size(80, 25);
            this.darbuotojai_button_back.TabIndex = 4;
            this.darbuotojai_button_back.Text = "Grįžti";
            this.darbuotojai_button_back.UseVisualStyleBackColor = true;
            this.darbuotojai_button_back.Click += new System.EventHandler(this.darbuotojai_button_back_Click);
            // 
            // Darbuotojai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.darbuotojai_button_back);
            this.Controls.Add(this.darbuotojai_button_remove);
            this.Controls.Add(this.darbuotojai_button_add);
            this.Controls.Add(this.darbuotojai_button_rasti);
            this.Controls.Add(this.darbuotojai_label_darbuotojai);
            this.Name = "Darbuotojai";
            this.Text = "Darbuotojai";
            this.Load += new System.EventHandler(this.Darbuotojai_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label darbuotojai_label_darbuotojai;
        private System.Windows.Forms.Button darbuotojai_button_rasti;
        private System.Windows.Forms.Button darbuotojai_button_add;
        private System.Windows.Forms.Button darbuotojai_button_remove;
        private System.Windows.Forms.Button darbuotojai_button_back;
    }
}
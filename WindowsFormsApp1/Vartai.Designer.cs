namespace PCMSystem
{
    partial class Vartai
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
            this.gates_button_back = new System.Windows.Forms.Button();
            this.gates_button_test = new System.Windows.Forms.Button();
            this.gates_button_add = new System.Windows.Forms.Button();
            this.gates_button_rasti = new System.Windows.Forms.Button();
            this.darbuotojai_label_darbuotojai = new System.Windows.Forms.Label();
            this.gates_button_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gates_button_back
            // 
            this.gates_button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gates_button_back.Location = new System.Drawing.Point(168, 272);
            this.gates_button_back.Name = "gates_button_back";
            this.gates_button_back.Size = new System.Drawing.Size(80, 25);
            this.gates_button_back.TabIndex = 9;
            this.gates_button_back.Text = "Grįžti";
            this.gates_button_back.UseVisualStyleBackColor = true;
            this.gates_button_back.Click += new System.EventHandler(this.gates_button_back_Click);
            // 
            // gates_button_test
            // 
            this.gates_button_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gates_button_test.Location = new System.Drawing.Point(38, 180);
            this.gates_button_test.Name = "gates_button_test";
            this.gates_button_test.Size = new System.Drawing.Size(340, 40);
            this.gates_button_test.TabIndex = 8;
            this.gates_button_test.Text = "Testuoti";
            this.gates_button_test.UseVisualStyleBackColor = true;
            // 
            // gates_button_add
            // 
            this.gates_button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gates_button_add.Location = new System.Drawing.Point(38, 134);
            this.gates_button_add.Name = "gates_button_add";
            this.gates_button_add.Size = new System.Drawing.Size(340, 40);
            this.gates_button_add.TabIndex = 7;
            this.gates_button_add.Text = "Pridėti naują";
            this.gates_button_add.UseVisualStyleBackColor = true;
            this.gates_button_add.Click += new System.EventHandler(this.gates_button_add_Click);
            // 
            // gates_button_rasti
            // 
            this.gates_button_rasti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gates_button_rasti.Location = new System.Drawing.Point(38, 88);
            this.gates_button_rasti.Name = "gates_button_rasti";
            this.gates_button_rasti.Size = new System.Drawing.Size(340, 40);
            this.gates_button_rasti.TabIndex = 6;
            this.gates_button_rasti.Text = "Rasti";
            this.gates_button_rasti.UseVisualStyleBackColor = true;
            this.gates_button_rasti.Click += new System.EventHandler(this.gates_button_rasti_Click);
            // 
            // darbuotojai_label_darbuotojai
            // 
            this.darbuotojai_label_darbuotojai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.darbuotojai_label_darbuotojai.Location = new System.Drawing.Point(38, 42);
            this.darbuotojai_label_darbuotojai.Name = "darbuotojai_label_darbuotojai";
            this.darbuotojai_label_darbuotojai.Size = new System.Drawing.Size(340, 40);
            this.darbuotojai_label_darbuotojai.TabIndex = 5;
            this.darbuotojai_label_darbuotojai.Text = "Vartai";
            this.darbuotojai_label_darbuotojai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gates_button_remove
            // 
            this.gates_button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gates_button_remove.Location = new System.Drawing.Point(38, 226);
            this.gates_button_remove.Name = "gates_button_remove";
            this.gates_button_remove.Size = new System.Drawing.Size(340, 40);
            this.gates_button_remove.TabIndex = 10;
            this.gates_button_remove.Text = "Pašalinti";
            this.gates_button_remove.UseVisualStyleBackColor = true;
            this.gates_button_remove.Click += new System.EventHandler(this.gates_button_remove_Click);
            // 
            // Vartai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.gates_button_remove);
            this.Controls.Add(this.gates_button_back);
            this.Controls.Add(this.gates_button_test);
            this.Controls.Add(this.gates_button_add);
            this.Controls.Add(this.gates_button_rasti);
            this.Controls.Add(this.darbuotojai_label_darbuotojai);
            this.Name = "Vartai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vartai";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gates_button_back;
        private System.Windows.Forms.Button gates_button_test;
        private System.Windows.Forms.Button gates_button_add;
        private System.Windows.Forms.Button gates_button_rasti;
        private System.Windows.Forms.Label darbuotojai_label_darbuotojai;
        private System.Windows.Forms.Button gates_button_remove;
    }
}
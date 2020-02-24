namespace PCMSystem
{
    partial class NaujiVartai
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
            this.components = new System.ComponentModel.Container();
            this.addgate_button_back = new System.Windows.Forms.Button();
            this.addgate_button_clear = new System.Windows.Forms.Button();
            this.addgate_button_add = new System.Windows.Forms.Button();
            this.addgate_texboxt_input_name = new System.Windows.Forms.TextBox();
            this.add_label_name = new System.Windows.Forms.Label();
            this.addgate_textbox_autoId = new System.Windows.Forms.TextBox();
            this.addgate_label_id = new System.Windows.Forms.Label();
            this.vartai_label_add = new System.Windows.Forms.Label();
            this.gateRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gateRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addgate_button_back
            // 
            this.addgate_button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.addgate_button_back.Location = new System.Drawing.Point(305, 277);
            this.addgate_button_back.Name = "addgate_button_back";
            this.addgate_button_back.Size = new System.Drawing.Size(60, 30);
            this.addgate_button_back.TabIndex = 27;
            this.addgate_button_back.Text = "Grįžti";
            this.addgate_button_back.UseVisualStyleBackColor = true;
            this.addgate_button_back.Click += new System.EventHandler(this.addgate_button_back_Click);
            // 
            // addgate_button_clear
            // 
            this.addgate_button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.addgate_button_clear.Location = new System.Drawing.Point(163, 277);
            this.addgate_button_clear.Name = "addgate_button_clear";
            this.addgate_button_clear.Size = new System.Drawing.Size(100, 30);
            this.addgate_button_clear.TabIndex = 26;
            this.addgate_button_clear.Text = "Valyti";
            this.addgate_button_clear.UseVisualStyleBackColor = true;
            this.addgate_button_clear.Click += new System.EventHandler(this.addgate_button_clear_Click);
            // 
            // addgate_button_add
            // 
            this.addgate_button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.addgate_button_add.Location = new System.Drawing.Point(43, 277);
            this.addgate_button_add.Name = "addgate_button_add";
            this.addgate_button_add.Size = new System.Drawing.Size(100, 30);
            this.addgate_button_add.TabIndex = 25;
            this.addgate_button_add.Text = "Pridėti";
            this.addgate_button_add.UseVisualStyleBackColor = true;
            // 
            // addgate_texboxt_input_name
            // 
            this.addgate_texboxt_input_name.Location = new System.Drawing.Point(163, 107);
            this.addgate_texboxt_input_name.Name = "addgate_texboxt_input_name";
            this.addgate_texboxt_input_name.Size = new System.Drawing.Size(200, 20);
            this.addgate_texboxt_input_name.TabIndex = 19;
            this.addgate_texboxt_input_name.UseWaitCursor = true;
            // 
            // add_label_name
            // 
            this.add_label_name.Location = new System.Drawing.Point(43, 107);
            this.add_label_name.Name = "add_label_name";
            this.add_label_name.Size = new System.Drawing.Size(120, 20);
            this.add_label_name.TabIndex = 18;
            this.add_label_name.Text = "Praėjimo Pavadinimas";
            this.add_label_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_label_name.UseMnemonic = false;
            // 
            // addgate_textbox_autoId
            // 
            this.addgate_textbox_autoId.Enabled = false;
            this.addgate_textbox_autoId.Location = new System.Drawing.Point(263, 77);
            this.addgate_textbox_autoId.Name = "addgate_textbox_autoId";
            this.addgate_textbox_autoId.Size = new System.Drawing.Size(100, 20);
            this.addgate_textbox_autoId.TabIndex = 17;
            this.addgate_textbox_autoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addgate_label_id
            // 
            this.addgate_label_id.Location = new System.Drawing.Point(43, 77);
            this.addgate_label_id.Name = "addgate_label_id";
            this.addgate_label_id.Size = new System.Drawing.Size(100, 20);
            this.addgate_label_id.TabIndex = 15;
            this.addgate_label_id.Text = "Praėjimo ID";
            this.addgate_label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vartai_label_add
            // 
            this.vartai_label_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.vartai_label_add.Location = new System.Drawing.Point(38, 20);
            this.vartai_label_add.Name = "vartai_label_add";
            this.vartai_label_add.Size = new System.Drawing.Size(340, 40);
            this.vartai_label_add.TabIndex = 14;
            this.vartai_label_add.Text = "Naujas Praėjimas";
            this.vartai_label_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gateRepositoryBindingSource
            // 
            this.gateRepositoryBindingSource.DataSource = typeof(PCMLibrary.GateRepository);
            // 
            // NaujiVartai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.addgate_button_back);
            this.Controls.Add(this.addgate_button_clear);
            this.Controls.Add(this.addgate_button_add);
            this.Controls.Add(this.addgate_texboxt_input_name);
            this.Controls.Add(this.add_label_name);
            this.Controls.Add(this.addgate_textbox_autoId);
            this.Controls.Add(this.addgate_label_id);
            this.Controls.Add(this.vartai_label_add);
            this.Name = "NaujiVartai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naujas Praėjimas";
            ((System.ComponentModel.ISupportInitialize)(this.gateRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addgate_button_back;
        private System.Windows.Forms.Button addgate_button_clear;
        private System.Windows.Forms.Button addgate_button_add;
        private System.Windows.Forms.TextBox addgate_texboxt_input_name;
        private System.Windows.Forms.Label add_label_name;
        private System.Windows.Forms.TextBox addgate_textbox_autoId;
        private System.Windows.Forms.Label addgate_label_id;
        private System.Windows.Forms.Label vartai_label_add;
        private System.Windows.Forms.BindingSource gateRepositoryBindingSource;
    }
}
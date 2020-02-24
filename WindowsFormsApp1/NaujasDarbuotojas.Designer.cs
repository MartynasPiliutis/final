namespace PCMSystem
{
    partial class NaujasDarbuotojas
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
            this.Darbuotojai_label_add = new System.Windows.Forms.Label();
            this.add_label_id = new System.Windows.Forms.Label();
            this.add_gates_dropbox = new System.Windows.Forms.ComboBox();
            this.add_textbox_autoId = new System.Windows.Forms.TextBox();
            this.add_label_name = new System.Windows.Forms.Label();
            this.add_texboxt_input_name = new System.Windows.Forms.TextBox();
            this.add_label_gates = new System.Windows.Forms.Label();
            this.add_gate_add = new System.Windows.Forms.Button();
            this.add_gate_remove = new System.Windows.Forms.Button();
            this.add_label_selectGate = new System.Windows.Forms.Label();
            this.add_button_add = new System.Windows.Forms.Button();
            this.add_button_clear = new System.Windows.Forms.Button();
            this.add_button_back = new System.Windows.Forms.Button();
            this.gateRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_listbox_selectGate = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gateRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Darbuotojai_label_add
            // 
            this.Darbuotojai_label_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Darbuotojai_label_add.Location = new System.Drawing.Point(34, 31);
            this.Darbuotojai_label_add.Name = "Darbuotojai_label_add";
            this.Darbuotojai_label_add.Size = new System.Drawing.Size(340, 40);
            this.Darbuotojai_label_add.TabIndex = 0;
            this.Darbuotojai_label_add.Text = "Naujas Darbuotojas";
            this.Darbuotojai_label_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_label_id
            // 
            this.add_label_id.Location = new System.Drawing.Point(38, 88);
            this.add_label_id.Name = "add_label_id";
            this.add_label_id.Size = new System.Drawing.Size(100, 20);
            this.add_label_id.TabIndex = 1;
            this.add_label_id.Text = "Darbuotojo ID";
            this.add_label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // add_gates_dropbox
            // 
            this.add_gates_dropbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_gates_dropbox.IntegralHeight = false;
            this.add_gates_dropbox.Location = new System.Drawing.Point(158, 148);
            this.add_gates_dropbox.Name = "add_gates_dropbox";
            this.add_gates_dropbox.Size = new System.Drawing.Size(100, 21);
            this.add_gates_dropbox.TabIndex = 2;
            this.add_gates_dropbox.SelectedIndexChanged += new System.EventHandler(this.add_gates_dropbox_SelectedIndexChanged);
            // 
            // add_textbox_autoId
            // 
            this.add_textbox_autoId.Enabled = false;
            this.add_textbox_autoId.Location = new System.Drawing.Point(258, 88);
            this.add_textbox_autoId.Name = "add_textbox_autoId";
            this.add_textbox_autoId.Size = new System.Drawing.Size(100, 20);
            this.add_textbox_autoId.TabIndex = 3;
            this.add_textbox_autoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.add_textbox_autoId.TextChanged += new System.EventHandler(this.add_textbox_autoId_TextChanged);
            // 
            // add_label_name
            // 
            this.add_label_name.Location = new System.Drawing.Point(38, 118);
            this.add_label_name.Name = "add_label_name";
            this.add_label_name.Size = new System.Drawing.Size(100, 20);
            this.add_label_name.TabIndex = 4;
            this.add_label_name.Text = "Vardas ir Pavarde";
            this.add_label_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // add_texboxt_input_name
            // 
            this.add_texboxt_input_name.Location = new System.Drawing.Point(158, 118);
            this.add_texboxt_input_name.Name = "add_texboxt_input_name";
            this.add_texboxt_input_name.Size = new System.Drawing.Size(200, 20);
            this.add_texboxt_input_name.TabIndex = 5;
            this.add_texboxt_input_name.UseWaitCursor = true;
            // 
            // add_label_gates
            // 
            this.add_label_gates.Location = new System.Drawing.Point(38, 148);
            this.add_label_gates.Name = "add_label_gates";
            this.add_label_gates.Size = new System.Drawing.Size(100, 20);
            this.add_label_gates.TabIndex = 6;
            this.add_label_gates.Text = "Pridėti vartus";
            this.add_label_gates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // add_gate_add
            // 
            this.add_gate_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.add_gate_add.Location = new System.Drawing.Point(278, 148);
            this.add_gate_add.Name = "add_gate_add";
            this.add_gate_add.Size = new System.Drawing.Size(30, 20);
            this.add_gate_add.TabIndex = 7;
            this.add_gate_add.Text = "+";
            this.add_gate_add.UseVisualStyleBackColor = true;
            this.add_gate_add.Click += new System.EventHandler(this.add_gate_add_Click);
            // 
            // add_gate_remove
            // 
            this.add_gate_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.add_gate_remove.Location = new System.Drawing.Point(328, 148);
            this.add_gate_remove.Name = "add_gate_remove";
            this.add_gate_remove.Size = new System.Drawing.Size(30, 20);
            this.add_gate_remove.TabIndex = 8;
            this.add_gate_remove.Text = "-";
            this.add_gate_remove.UseVisualStyleBackColor = true;
            this.add_gate_remove.Click += new System.EventHandler(this.add_gate_remove_Click);
            // 
            // add_label_selectGate
            // 
            this.add_label_selectGate.Location = new System.Drawing.Point(38, 178);
            this.add_label_selectGate.Name = "add_label_selectGate";
            this.add_label_selectGate.Size = new System.Drawing.Size(100, 20);
            this.add_label_selectGate.TabIndex = 9;
            this.add_label_selectGate.Text = "Pasirinkti vartai";
            // 
            // add_button_add
            // 
            this.add_button_add.Enabled = false;
            this.add_button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.add_button_add.Location = new System.Drawing.Point(38, 288);
            this.add_button_add.Name = "add_button_add";
            this.add_button_add.Size = new System.Drawing.Size(100, 30);
            this.add_button_add.TabIndex = 11;
            this.add_button_add.Text = "Pridėti";
            this.add_button_add.UseVisualStyleBackColor = true;
            // 
            // add_button_clear
            // 
            this.add_button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.add_button_clear.Location = new System.Drawing.Point(158, 288);
            this.add_button_clear.Name = "add_button_clear";
            this.add_button_clear.Size = new System.Drawing.Size(100, 30);
            this.add_button_clear.TabIndex = 12;
            this.add_button_clear.Text = "Valyti";
            this.add_button_clear.UseVisualStyleBackColor = true;
            this.add_button_clear.Click += new System.EventHandler(this.add_button_clear_Click);
            // 
            // add_button_back
            // 
            this.add_button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.add_button_back.Location = new System.Drawing.Point(300, 288);
            this.add_button_back.Name = "add_button_back";
            this.add_button_back.Size = new System.Drawing.Size(60, 30);
            this.add_button_back.TabIndex = 13;
            this.add_button_back.Text = "Grįžti";
            this.add_button_back.UseVisualStyleBackColor = true;
            this.add_button_back.Click += new System.EventHandler(this.add_button_back_Click);
            // 
            // gateRepositoryBindingSource
            // 
            this.gateRepositoryBindingSource.DataSource = typeof(PCMLibrary.GateRepository);
            // 
            // add_listbox_selectGate
            // 
            this.add_listbox_selectGate.FormattingEnabled = true;
            this.add_listbox_selectGate.IntegralHeight = false;
            this.add_listbox_selectGate.Location = new System.Drawing.Point(158, 178);
            this.add_listbox_selectGate.Name = "add_listbox_selectGate";
            this.add_listbox_selectGate.Size = new System.Drawing.Size(100, 80);
            this.add_listbox_selectGate.TabIndex = 10;
            // 
            // NaujasDarbuotojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.add_button_back);
            this.Controls.Add(this.add_button_clear);
            this.Controls.Add(this.add_button_add);
            this.Controls.Add(this.add_listbox_selectGate);
            this.Controls.Add(this.add_label_selectGate);
            this.Controls.Add(this.add_gate_remove);
            this.Controls.Add(this.add_gate_add);
            this.Controls.Add(this.add_label_gates);
            this.Controls.Add(this.add_texboxt_input_name);
            this.Controls.Add(this.add_label_name);
            this.Controls.Add(this.add_textbox_autoId);
            this.Controls.Add(this.add_gates_dropbox);
            this.Controls.Add(this.add_label_id);
            this.Controls.Add(this.Darbuotojai_label_add);
            this.Name = "NaujasDarbuotojas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naujas Darbuotojas";
            ((System.ComponentModel.ISupportInitialize)(this.gateRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Darbuotojai_label_add;
        private System.Windows.Forms.Label add_label_id;
        private System.Windows.Forms.ComboBox add_gates_dropbox;
        private System.Windows.Forms.TextBox add_textbox_autoId;
        private System.Windows.Forms.Label add_label_name;
        private System.Windows.Forms.TextBox add_texboxt_input_name;
        private System.Windows.Forms.Label add_label_gates;
        private System.Windows.Forms.Button add_gate_add;
        private System.Windows.Forms.Button add_gate_remove;
        private System.Windows.Forms.Label add_label_selectGate;
        private System.Windows.Forms.Button add_button_add;
        private System.Windows.Forms.Button add_button_clear;
        private System.Windows.Forms.Button add_button_back;
        private System.Windows.Forms.BindingSource gateRepositoryBindingSource;
        private System.Windows.Forms.ListBox add_listbox_selectGate;
    }
}
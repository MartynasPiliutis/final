namespace PCMSystem
{
    partial class AtaskaitaPraejimai
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
            this.dfind_dropbox_idList = new System.Windows.Forms.ComboBox();
            this.dfind_button_find = new System.Windows.Forms.Button();
            this.button_filtruoti = new System.Windows.Forms.Button();
            this.FiltrasAll = new System.Windows.Forms.GroupBox();
            this.check_filter_All = new System.Windows.Forms.RadioButton();
            this.check_filter_false = new System.Windows.Forms.RadioButton();
            this.check_filter_true = new System.Windows.Forms.RadioButton();
            this.button_back = new System.Windows.Forms.Button();
            this.employee_report_groupbox_id = new System.Windows.Forms.GroupBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.Ataskaita_dataGridView = new System.Windows.Forms.DataGridView();
            this.eiles_nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gate_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gate_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laikas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raktas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiltrasAll.SuspendLayout();
            this.employee_report_groupbox_id.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ataskaita_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dfind_dropbox_idList
            // 
            this.dfind_dropbox_idList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dfind_dropbox_idList.FormattingEnabled = true;
            this.dfind_dropbox_idList.Location = new System.Drawing.Point(16, 39);
            this.dfind_dropbox_idList.Name = "dfind_dropbox_idList";
            this.dfind_dropbox_idList.Size = new System.Drawing.Size(121, 21);
            this.dfind_dropbox_idList.TabIndex = 5;
            this.dfind_dropbox_idList.SelectedIndexChanged += new System.EventHandler(this.dfind_dropbox_idList_SelectedIndexChanged);
            // 
            // dfind_button_find
            // 
            this.dfind_button_find.Enabled = false;
            this.dfind_button_find.Location = new System.Drawing.Point(143, 36);
            this.dfind_button_find.Name = "dfind_button_find";
            this.dfind_button_find.Size = new System.Drawing.Size(80, 25);
            this.dfind_button_find.TabIndex = 4;
            this.dfind_button_find.Text = "Ieškoti";
            this.dfind_button_find.UseVisualStyleBackColor = true;
            this.dfind_button_find.Click += new System.EventHandler(this.dfind_button_find_Click);
            // 
            // button_filtruoti
            // 
            this.button_filtruoti.Enabled = false;
            this.button_filtruoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button_filtruoti.Location = new System.Drawing.Point(658, 27);
            this.button_filtruoti.Name = "button_filtruoti";
            this.button_filtruoti.Size = new System.Drawing.Size(88, 25);
            this.button_filtruoti.TabIndex = 18;
            this.button_filtruoti.Text = "Peržiūrėti";
            this.button_filtruoti.UseVisualStyleBackColor = true;
            this.button_filtruoti.Click += new System.EventHandler(this.button_filtruoti_Click);
            // 
            // FiltrasAll
            // 
            this.FiltrasAll.Controls.Add(this.check_filter_All);
            this.FiltrasAll.Controls.Add(this.check_filter_false);
            this.FiltrasAll.Controls.Add(this.check_filter_true);
            this.FiltrasAll.Enabled = false;
            this.FiltrasAll.Location = new System.Drawing.Point(271, 12);
            this.FiltrasAll.Name = "FiltrasAll";
            this.FiltrasAll.Size = new System.Drawing.Size(336, 100);
            this.FiltrasAll.TabIndex = 17;
            this.FiltrasAll.TabStop = false;
            this.FiltrasAll.Text = "Pasirinkite ataskaitos filtrą";
            this.FiltrasAll.Enter += new System.EventHandler(this.FiltrasAll_Enter);
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
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button_back.Location = new System.Drawing.Point(803, 50);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(88, 25);
            this.button_back.TabIndex = 16;
            this.button_back.Text = "Grįžti";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // employee_report_groupbox_id
            // 
            this.employee_report_groupbox_id.Controls.Add(this.dfind_dropbox_idList);
            this.employee_report_groupbox_id.Controls.Add(this.dfind_button_find);
            this.employee_report_groupbox_id.Location = new System.Drawing.Point(13, 12);
            this.employee_report_groupbox_id.Name = "employee_report_groupbox_id";
            this.employee_report_groupbox_id.Size = new System.Drawing.Size(236, 100);
            this.employee_report_groupbox_id.TabIndex = 19;
            this.employee_report_groupbox_id.TabStop = false;
            this.employee_report_groupbox_id.Text = "Pasirinkite vartus pagal ID";
            this.employee_report_groupbox_id.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button_clear.Location = new System.Drawing.Point(658, 73);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(88, 25);
            this.button_clear.TabIndex = 20;
            this.button_clear.Text = "Valyti";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Ataskaita_dataGridView
            // 
            this.Ataskaita_dataGridView.AllowUserToAddRows = false;
            this.Ataskaita_dataGridView.AllowUserToDeleteRows = false;
            this.Ataskaita_dataGridView.AllowUserToResizeRows = false;
            this.Ataskaita_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ataskaita_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eiles_nr,
            this.gate_id,
            this.gate_name,
            this.employee_name,
            this.data,
            this.laikas,
            this.raktas});
            this.Ataskaita_dataGridView.Location = new System.Drawing.Point(12, 118);
            this.Ataskaita_dataGridView.Name = "Ataskaita_dataGridView";
            this.Ataskaita_dataGridView.ReadOnly = true;
            this.Ataskaita_dataGridView.RowHeadersVisible = false;
            this.Ataskaita_dataGridView.Size = new System.Drawing.Size(960, 531);
            this.Ataskaita_dataGridView.TabIndex = 21;
            // 
            // eiles_nr
            // 
            this.eiles_nr.HeaderText = "Eilės Nr.";
            this.eiles_nr.MaxInputLength = 6;
            this.eiles_nr.Name = "eiles_nr";
            this.eiles_nr.ReadOnly = true;
            // 
            // gate_id
            // 
            this.gate_id.HeaderText = "Praėjimo ID";
            this.gate_id.MaxInputLength = 5;
            this.gate_id.Name = "gate_id";
            this.gate_id.ReadOnly = true;
            // 
            // gate_name
            // 
            this.gate_name.HeaderText = "Praėjimas";
            this.gate_name.MaxInputLength = 50;
            this.gate_name.Name = "gate_name";
            this.gate_name.ReadOnly = true;
            this.gate_name.Width = 150;
            // 
            // employee_name
            // 
            this.employee_name.HeaderText = "Vardas Pavardė";
            this.employee_name.MaxInputLength = 50;
            this.employee_name.Name = "employee_name";
            this.employee_name.ReadOnly = true;
            this.employee_name.Width = 200;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.MaxInputLength = 12;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 150;
            // 
            // laikas
            // 
            this.laikas.HeaderText = "Laikas";
            this.laikas.MaxInputLength = 7;
            this.laikas.Name = "laikas";
            this.laikas.ReadOnly = true;
            this.laikas.Width = 150;
            // 
            // raktas
            // 
            this.raktas.HeaderText = "Raktas";
            this.raktas.MaxInputLength = 7;
            this.raktas.Name = "raktas";
            this.raktas.ReadOnly = true;
            // 
            // AtaskaitaPraejimai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.Ataskaita_dataGridView);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.employee_report_groupbox_id);
            this.Controls.Add(this.button_filtruoti);
            this.Controls.Add(this.FiltrasAll);
            this.Controls.Add(this.button_back);
            this.Name = "AtaskaitaPraejimai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ataskaita - Praėjimai";
            this.FiltrasAll.ResumeLayout(false);
            this.FiltrasAll.PerformLayout();
            this.employee_report_groupbox_id.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ataskaita_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox dfind_dropbox_idList;
        private System.Windows.Forms.Button dfind_button_find;
        private System.Windows.Forms.Button button_filtruoti;
        private System.Windows.Forms.GroupBox FiltrasAll;
        private System.Windows.Forms.RadioButton check_filter_All;
        private System.Windows.Forms.RadioButton check_filter_false;
        private System.Windows.Forms.RadioButton check_filter_true;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.GroupBox employee_report_groupbox_id;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.DataGridView Ataskaita_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn eiles_nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn gate_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gate_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn laikas;
        private System.Windows.Forms.DataGridViewTextBoxColumn raktas;
    }
}
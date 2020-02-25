namespace PCMSystem
{
    partial class Ataskaita_True
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ataskaita_True));
            this.report_button_close = new System.Windows.Forms.Button();
            this.Ataskaita_dataGridView = new System.Windows.Forms.DataGridView();
            this.nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.darbuotojoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Ataskaita_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // report_button_close
            // 
            resources.ApplyResources(this.report_button_close, "report_button_close");
            this.report_button_close.Name = "report_button_close";
            this.report_button_close.UseVisualStyleBackColor = true;
            this.report_button_close.Click += new System.EventHandler(this.report_button_close_Click);
            // 
            // Ataskaita_dataGridView
            // 
            this.Ataskaita_dataGridView.AllowUserToAddRows = false;
            this.Ataskaita_dataGridView.AllowUserToDeleteRows = false;
            this.Ataskaita_dataGridView.AllowUserToResizeRows = false;
            this.Ataskaita_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ataskaita_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nr,
            this.darbuotojoId,
            this.name,
            this.gate,
            this.date,
            this.time,
            this.pass});
            resources.ApplyResources(this.Ataskaita_dataGridView, "Ataskaita_dataGridView");
            this.Ataskaita_dataGridView.Name = "Ataskaita_dataGridView";
            this.Ataskaita_dataGridView.RowHeadersVisible = false;
            // 
            // nr
            // 
            resources.ApplyResources(this.nr, "nr");
            this.nr.MaxInputLength = 6;
            this.nr.Name = "nr";
            this.nr.ReadOnly = true;
            this.nr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // darbuotojoId
            // 
            resources.ApplyResources(this.darbuotojoId, "darbuotojoId");
            this.darbuotojoId.MaxInputLength = 6;
            this.darbuotojoId.Name = "darbuotojoId";
            this.darbuotojoId.ReadOnly = true;
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.MaxInputLength = 50;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // gate
            // 
            resources.ApplyResources(this.gate, "gate");
            this.gate.MaxInputLength = 50;
            this.gate.Name = "gate";
            this.gate.ReadOnly = true;
            // 
            // date
            // 
            resources.ApplyResources(this.date, "date");
            this.date.MaxInputLength = 12;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            resources.ApplyResources(this.time, "time");
            this.time.MaxInputLength = 7;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // pass
            // 
            resources.ApplyResources(this.pass, "pass");
            this.pass.MaxInputLength = 7;
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            // 
            // Ataskaita_True
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Ataskaita_dataGridView);
            this.Controls.Add(this.report_button_close);
            this.Name = "Ataskaita_True";
            this.Load += new System.EventHandler(this.Ataskaita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ataskaita_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button report_button_close;
        private System.Windows.Forms.DataGridView Ataskaita_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn darbuotojoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gate;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
    }
}
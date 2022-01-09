
namespace Clinica
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePazienti = new System.Windows.Forms.TabPage();
            this.dataGridViewPazienti = new System.Windows.Forms.DataGridView();
            this.tabPageMedici = new System.Windows.Forms.TabPage();
            this.dataGridViewMedici = new System.Windows.Forms.DataGridView();
            this.tabPagePatologie = new System.Windows.Forms.TabPage();
            this.dataGridViewPatologie = new System.Windows.Forms.DataGridView();
            this.tabPageSpecializzazioni = new System.Windows.Forms.TabPage();
            this.dataGridViewSpecializzazioni = new System.Windows.Forms.DataGridView();
            this.tabPageAppuntamenti = new System.Windows.Forms.TabPage();
            this.comboBoxMedici = new System.Windows.Forms.ComboBox();
            this.comboBoxPazienti = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonFiltra = new System.Windows.Forms.Button();
            this.checkBoxMedici = new System.Windows.Forms.CheckBox();
            this.checkBoxPaziente = new System.Windows.Forms.CheckBox();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewAppuntamenti = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPagePazienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPazienti)).BeginInit();
            this.tabPageMedici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedici)).BeginInit();
            this.tabPagePatologie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatologie)).BeginInit();
            this.tabPageSpecializzazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecializzazioni)).BeginInit();
            this.tabPageAppuntamenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppuntamenti)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePazienti);
            this.tabControl.Controls.Add(this.tabPageMedici);
            this.tabControl.Controls.Add(this.tabPagePatologie);
            this.tabControl.Controls.Add(this.tabPageSpecializzazioni);
            this.tabControl.Controls.Add(this.tabPageAppuntamenti);
            this.tabControl.Location = new System.Drawing.Point(12, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 443);
            this.tabControl.TabIndex = 2;
            // 
            // tabPagePazienti
            // 
            this.tabPagePazienti.Controls.Add(this.dataGridViewPazienti);
            this.tabPagePazienti.Location = new System.Drawing.Point(4, 22);
            this.tabPagePazienti.Name = "tabPagePazienti";
            this.tabPagePazienti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePazienti.Size = new System.Drawing.Size(768, 417);
            this.tabPagePazienti.TabIndex = 0;
            this.tabPagePazienti.Text = "Pazienti";
            this.tabPagePazienti.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPazienti
            // 
            this.dataGridViewPazienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPazienti.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewPazienti.Name = "dataGridViewPazienti";
            this.dataGridViewPazienti.Size = new System.Drawing.Size(756, 405);
            this.dataGridViewPazienti.TabIndex = 0;
            // 
            // tabPageMedici
            // 
            this.tabPageMedici.Controls.Add(this.dataGridViewMedici);
            this.tabPageMedici.Location = new System.Drawing.Point(4, 22);
            this.tabPageMedici.Name = "tabPageMedici";
            this.tabPageMedici.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedici.Size = new System.Drawing.Size(768, 417);
            this.tabPageMedici.TabIndex = 1;
            this.tabPageMedici.Text = "Medici";
            this.tabPageMedici.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMedici
            // 
            this.dataGridViewMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedici.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewMedici.Name = "dataGridViewMedici";
            this.dataGridViewMedici.Size = new System.Drawing.Size(756, 405);
            this.dataGridViewMedici.TabIndex = 1;
            // 
            // tabPagePatologie
            // 
            this.tabPagePatologie.Controls.Add(this.dataGridViewPatologie);
            this.tabPagePatologie.Location = new System.Drawing.Point(4, 22);
            this.tabPagePatologie.Name = "tabPagePatologie";
            this.tabPagePatologie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatologie.Size = new System.Drawing.Size(768, 417);
            this.tabPagePatologie.TabIndex = 2;
            this.tabPagePatologie.Text = "Patologie";
            this.tabPagePatologie.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPatologie
            // 
            this.dataGridViewPatologie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatologie.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewPatologie.Name = "dataGridViewPatologie";
            this.dataGridViewPatologie.Size = new System.Drawing.Size(756, 405);
            this.dataGridViewPatologie.TabIndex = 1;
            // 
            // tabPageSpecializzazioni
            // 
            this.tabPageSpecializzazioni.Controls.Add(this.dataGridViewSpecializzazioni);
            this.tabPageSpecializzazioni.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpecializzazioni.Name = "tabPageSpecializzazioni";
            this.tabPageSpecializzazioni.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpecializzazioni.Size = new System.Drawing.Size(768, 417);
            this.tabPageSpecializzazioni.TabIndex = 3;
            this.tabPageSpecializzazioni.Text = "Specializzazioni";
            this.tabPageSpecializzazioni.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSpecializzazioni
            // 
            this.dataGridViewSpecializzazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecializzazioni.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewSpecializzazioni.Name = "dataGridViewSpecializzazioni";
            this.dataGridViewSpecializzazioni.Size = new System.Drawing.Size(756, 405);
            this.dataGridViewSpecializzazioni.TabIndex = 1;
            // 
            // tabPageAppuntamenti
            // 
            this.tabPageAppuntamenti.Controls.Add(this.comboBoxMedici);
            this.tabPageAppuntamenti.Controls.Add(this.comboBoxPazienti);
            this.tabPageAppuntamenti.Controls.Add(this.buttonReset);
            this.tabPageAppuntamenti.Controls.Add(this.buttonFiltra);
            this.tabPageAppuntamenti.Controls.Add(this.checkBoxMedici);
            this.tabPageAppuntamenti.Controls.Add(this.checkBoxPaziente);
            this.tabPageAppuntamenti.Controls.Add(this.checkBoxData);
            this.tabPageAppuntamenti.Controls.Add(this.label3);
            this.tabPageAppuntamenti.Controls.Add(this.label2);
            this.tabPageAppuntamenti.Controls.Add(this.label1);
            this.tabPageAppuntamenti.Controls.Add(this.dateTimePicker);
            this.tabPageAppuntamenti.Controls.Add(this.dataGridViewAppuntamenti);
            this.tabPageAppuntamenti.Location = new System.Drawing.Point(4, 22);
            this.tabPageAppuntamenti.Name = "tabPageAppuntamenti";
            this.tabPageAppuntamenti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppuntamenti.Size = new System.Drawing.Size(768, 417);
            this.tabPageAppuntamenti.TabIndex = 4;
            this.tabPageAppuntamenti.Text = "Appuntamenti";
            this.tabPageAppuntamenti.UseVisualStyleBackColor = true;
            // 
            // comboBoxMedici
            // 
            this.comboBoxMedici.Enabled = false;
            this.comboBoxMedici.FormattingEnabled = true;
            this.comboBoxMedici.Location = new System.Drawing.Point(67, 77);
            this.comboBoxMedici.Name = "comboBoxMedici";
            this.comboBoxMedici.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMedici.TabIndex = 14;
            // 
            // comboBoxPazienti
            // 
            this.comboBoxPazienti.Enabled = false;
            this.comboBoxPazienti.FormattingEnabled = true;
            this.comboBoxPazienti.Location = new System.Drawing.Point(67, 46);
            this.comboBoxPazienti.Name = "comboBoxPazienti";
            this.comboBoxPazienti.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPazienti.TabIndex = 13;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(479, 27);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 66);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonFiltra
            // 
            this.buttonFiltra.Location = new System.Drawing.Point(398, 27);
            this.buttonFiltra.Name = "buttonFiltra";
            this.buttonFiltra.Size = new System.Drawing.Size(75, 66);
            this.buttonFiltra.TabIndex = 11;
            this.buttonFiltra.Text = "Filtra";
            this.buttonFiltra.UseVisualStyleBackColor = true;
            this.buttonFiltra.Click += new System.EventHandler(this.buttonFiltra_Click);
            // 
            // checkBoxMedici
            // 
            this.checkBoxMedici.AutoSize = true;
            this.checkBoxMedici.Location = new System.Drawing.Point(288, 75);
            this.checkBoxMedici.Name = "checkBoxMedici";
            this.checkBoxMedici.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMedici.TabIndex = 10;
            this.checkBoxMedici.UseVisualStyleBackColor = true;
            this.checkBoxMedici.CheckedChanged += new System.EventHandler(this.checkBoxMedici_CheckedChanged);
            // 
            // checkBoxPaziente
            // 
            this.checkBoxPaziente.AutoSize = true;
            this.checkBoxPaziente.Location = new System.Drawing.Point(288, 49);
            this.checkBoxPaziente.Name = "checkBoxPaziente";
            this.checkBoxPaziente.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPaziente.TabIndex = 9;
            this.checkBoxPaziente.UseVisualStyleBackColor = true;
            this.checkBoxPaziente.CheckedChanged += new System.EventHandler(this.checkBoxPaziente_CheckedChanged);
            // 
            // checkBoxData
            // 
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.Location = new System.Drawing.Point(288, 26);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(15, 14);
            this.checkBoxData.TabIndex = 8;
            this.checkBoxData.UseVisualStyleBackColor = true;
            this.checkBoxData.CheckedChanged += new System.EventHandler(this.checkBoxData_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medici";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Paziente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(67, 20);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // dataGridViewAppuntamenti
            // 
            this.dataGridViewAppuntamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppuntamenti.Location = new System.Drawing.Point(-31, 112);
            this.dataGridViewAppuntamenti.Name = "dataGridViewAppuntamenti";
            this.dataGridViewAppuntamenti.Size = new System.Drawing.Size(756, 261);
            this.dataGridViewAppuntamenti.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPagePazienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPazienti)).EndInit();
            this.tabPageMedici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedici)).EndInit();
            this.tabPagePatologie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatologie)).EndInit();
            this.tabPageSpecializzazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecializzazioni)).EndInit();
            this.tabPageAppuntamenti.ResumeLayout(false);
            this.tabPageAppuntamenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppuntamenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePazienti;
        private System.Windows.Forms.DataGridView dataGridViewPazienti;
        private System.Windows.Forms.TabPage tabPageMedici;
        private System.Windows.Forms.DataGridView dataGridViewMedici;
        private System.Windows.Forms.TabPage tabPagePatologie;
        private System.Windows.Forms.DataGridView dataGridViewPatologie;
        private System.Windows.Forms.TabPage tabPageSpecializzazioni;
        private System.Windows.Forms.DataGridView dataGridViewSpecializzazioni;
        private System.Windows.Forms.TabPage tabPageAppuntamenti;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonFiltra;
        private System.Windows.Forms.CheckBox checkBoxMedici;
        private System.Windows.Forms.CheckBox checkBoxPaziente;
        private System.Windows.Forms.CheckBox checkBoxData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView dataGridViewAppuntamenti;
        private System.Windows.Forms.ComboBox comboBoxMedici;
        private System.Windows.Forms.ComboBox comboBoxPazienti;
    }
}


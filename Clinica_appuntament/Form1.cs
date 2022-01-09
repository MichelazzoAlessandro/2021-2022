using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] arrpatologie = new string[19];
        string[] arrspecializzazioni = new string[23];
        List<medico> medici = new List<medico>();
        List<paziente> pazienti = new List<paziente>();
        private void BindDataP(string filePath)
        {
            DataTable dtPazienti = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {

                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(';');



                dtPazienti.Columns.Add(headerLabels[0]);
                dtPazienti.Columns.Add(headerLabels[1]);
                dtPazienti.Columns.Add(headerLabels[5]);
                dtPazienti.Columns.Add(headerLabels[6]);


                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(';');
                    DataRow dr = dtPazienti.NewRow();



                    dr[0] = dataWords[0];
                    dr[1] = dataWords[1];
                    dr[2] = arrpatologie[Convert.ToInt32(dataWords[5]) - 1];
                    dr[3] = dataWords[6];
                    paziente p1 = new paziente(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Convert.ToInt32(dr[3]));
                    pazienti.Add(p1);
                    dtPazienti.Rows.Add(dr);
                }
            }
            if (dtPazienti.Rows.Count > 0)
            {
                dataGridViewPazienti.DataSource = dtPazienti;
            }

        }
        private void BindDataM(string filePath)
        {
            DataTable dtMedici = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {

                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(';');



                dtMedici.Columns.Add(headerLabels[0]);
                dtMedici.Columns.Add(headerLabels[1]);
                dtMedici.Columns.Add(headerLabels[3]);
                dtMedici.Columns.Add(headerLabels[4]);


                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(';');
                    DataRow dr = dtMedici.NewRow();



                    dr[0] = dataWords[0];
                    dr[1] = dataWords[1];
                    dr[2] = dataWords[3];
                    dr[3] = arrspecializzazioni[Convert.ToInt32(dataWords[4]) - 1];
                    medico m1 = new medico(dr[0].ToString(), dr[1].ToString(), dr[3].ToString(), Convert.ToInt32(dr[2]));
                    medici.Add(m1);
                    dtMedici.Rows.Add(dr);
                }
            }
            if (dtMedici.Rows.Count > 0)
            {
                dataGridViewMedici.DataSource = dtMedici;
            }

        }
        private void BindDataPatologie(string filePath)
        {
            DataTable dtPatologie = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {

                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(';');



                dtPatologie.Columns.Add(headerLabels[0]);
                dtPatologie.Columns.Add(headerLabels[1]);
                int cont = 0;



                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(';');
                    DataRow dr = dtPatologie.NewRow();



                    dr[0] = dataWords[0];
                    dr[1] = dataWords[1];
                    arrpatologie[cont] = dataWords[1];

                    dtPatologie.Rows.Add(dr);
                    cont++;
                }

            }
            if (dtPatologie.Rows.Count > 0)
            {
                dataGridViewPatologie.DataSource = dtPatologie;
            }

        }
        private void BindDataSpecializzazioni(string filePath)
        {
            DataTable dtSpecializzazioni = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {

                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(';');



                dtSpecializzazioni.Columns.Add(headerLabels[0]);
                dtSpecializzazioni.Columns.Add(headerLabels[1]);
                int cont = 0;



                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(';');
                    DataRow dr = dtSpecializzazioni.NewRow();



                    dr[0] = dataWords[0];
                    dr[1] = dataWords[1];
                    arrspecializzazioni[cont] = dataWords[1];

                    dtSpecializzazioni.Rows.Add(dr);
                    cont++;
                }

            }
            if (dtSpecializzazioni.Rows.Count > 0)
            {
                dataGridViewSpecializzazioni.DataSource = dtSpecializzazioni;
            }

        }
        private DataTable BindDataAppuntamenti()
        {
            DataTable dtAppuntamenti = new DataTable();
            using (StreamReader sr = new StreamReader("appuntamenti.csv"))
            {
                string[] headers = sr.ReadLine().Split(';');
                dtAppuntamenti.Columns.Add(headers[0]);
                dtAppuntamenti.Columns.Add(headers[1]);
                dtAppuntamenti.Columns.Add(headers[2]);
                dtAppuntamenti.Columns[0].DataType = System.Type.GetType("System.DateTime");


                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(';');
                    DataRow dr = dtAppuntamenti.NewRow();

                    dr[0] = rows[0];
                   
                    dr[1] = pazienti[Convert.ToInt32(rows[1]) - 1].GetName();
                    dr[2] = medici[Convert.ToInt32(rows[2]) - 501].GetName();

                    dtAppuntamenti.Rows.Add(dr);
                }


            }


            return dtAppuntamenti;

        }
        public void BindDataComboBox()
        {
            foreach(medico m in medici)
            {
                comboBoxMedici.Items.Add(m.Nome + " " + m.Cognome);
            }
            foreach(paziente p in pazienti)
            {
                comboBoxPazienti.Items.Add(p.Nome + " " + p.Cognome);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            BindDataPatologie("patologie.csv");
            BindDataSpecializzazioni("specializzazioni.csv");
            
            BindDataP("pazienti.csv");
            BindDataM("medici.csv");
            dataGridViewAppuntamenti.DataSource = BindDataAppuntamenti();
            BindDataComboBox();
           

        }

        private void buttonFiltra_Click(object sender, EventArgs e)
        {
            dataGridViewAppuntamenti.DataSource = null;
            dataGridViewAppuntamenti.DataSource = BindDataAppuntamenti();
            if (checkBoxData.Checked== true)
            {
                for (int i = dataGridViewAppuntamenti.Rows.Count - 2; i >= 0; i--)
                {
                    var row = dataGridViewAppuntamenti.Rows[i];
                    if (row.Cells[0].Value != null && ((DateTime)row.Cells[0].Value).Date != dateTimePicker.Value.Date)
                    {
                        dataGridViewAppuntamenti.Rows.RemoveAt(row.Index);
                    }
                }
            }

            if (checkBoxPaziente.Checked == true)
            {
                for (int i = dataGridViewAppuntamenti.Rows.Count - 2; i >= 0; i--)
                {
                    var riga = dataGridViewAppuntamenti.Rows[i];
                    if (riga.Cells[1] != null && (string)riga.Cells[1].Value != comboBoxPazienti.Text)
                    {
                        dataGridViewAppuntamenti.Rows.RemoveAt(riga.Index);
                    }
                    
                }
            }

            if (checkBoxMedici.Checked == true)
            {
                for (int i = dataGridViewAppuntamenti.Rows.Count - 2; i >= 0; i--)
                {
                    var riga = dataGridViewAppuntamenti.Rows[i];
                    if (riga.Cells[1] != null && (string)riga.Cells[2].Value != comboBoxMedici.Text)
                    {
                        dataGridViewAppuntamenti.Rows.RemoveAt(riga.Index);
                    }
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridViewAppuntamenti.DataSource = null;
            dataGridViewAppuntamenti.DataSource = BindDataAppuntamenti();
            dateTimePicker.ResetText();
            comboBoxMedici.Text = "";
            comboBoxPazienti.Text = "";
            checkBoxData.Checked = false;
            checkBoxMedici.Checked = false;
            checkBoxPaziente.Checked = false;
        }

        private void checkBoxData_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = checkBoxData.Checked;
        }

        private void checkBoxPaziente_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPazienti.Enabled = checkBoxPaziente.Checked;
        }

        private void checkBoxMedici_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxMedici.Enabled = checkBoxMedici.Checked;
        }
    }
}
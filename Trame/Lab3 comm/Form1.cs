using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Lab3_comm
{

    public partial class frmLab2 : Form
    {
        string m_chaine;
        public frmLab2()
        {
            InitializeComponent();
            cboVitesse.SelectedIndex = 1;
            spPortSerie.BaudRate = 150;
            spPortSerie.PortName = "COM4";
            spPortSerie.ReadTimeout = 5000;
            spPortSerie.WriteTimeout = 5000;
            m_chaine = "";
        }
        private void rb2Bit_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Name == rb2Bit.Name)
                spPortSerie.StopBits = System.IO.Ports.StopBits.Two;
            else
                spPortSerie.StopBits = System.IO.Ports.StopBits.One;
        }
        private void rb8Bit_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Name == rb7Bit.Name)
                spPortSerie.DataBits = 7;
            else
                spPortSerie.DataBits = 8;
        }
        private void rbPair_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Name == rbPair.Name)
                spPortSerie.Parity = System.IO.Ports.Parity.Even;
            else
                spPortSerie.Parity = System.IO.Ports.Parity.Odd;
        }
        private void rbActif_CheckedChanged(object sender, EventArgs e)
        {
             if (rbActif.Checked == true)
                try
                {
                    spPortSerie.Open();
                }
                catch (Exception)
                {
                    return;
                }
             else
                 spPortSerie.Close();
        }
        private void cboVitesse_SelectedValueChanged(object sender, EventArgs e)
        {
            spPortSerie.BaudRate = Convert.ToInt32(cboVitesse.Text);
        }
        private void btnLire_Click(object sender, EventArgs e)
        {
            Thread.Sleep(950);
            char carac;
            if (rbActif.Checked == false)
                return;
            while (spPortSerie.BytesToRead > 0)
            {
                carac = (char)spPortSerie.ReadByte();

                if (carac != 08)
                {
                    m_chaine += carac;
                }
            }
            m_chaine = "\u0002?B0101030912339876          01,3412                                    ,D4\u0003";
            if (m_chaine != string.Empty)
            {
                CTrame Trame = new CTrame(m_chaine);
                if (Trame.Verif == false)
                {
                    MessageBox.Show("Erreur de Traitement");
                    File.AppendAllText("ArchiveErreur.txt", Trame + Environment.NewLine);
                }
                else
                {
                    txtNomArticle.Text = Trame.NomArticle;
                    txtQuantiteRestante.Text = Trame.QuantiteRestante.ToString();
                    txPrixArticle.Text = Trame.Prix.ToString("C");
                    txtTaxe.Text = (Trame.Prix * Trame.Taxe).ToString("C");
                    txtTotal.Text = ((Trame.Prix * Trame.Taxe) + Trame.Prix).ToString("C");
                    txtDate.Text = Trame.Date.ToString();
                    txtChckSum.Text = Trame.Checksum;
                }
            }

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            spPortSerie.Close();
            Application.Exit();
        }

    }
}

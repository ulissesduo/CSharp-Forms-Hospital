using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        double consulta = 0;
        double internacao = 0;
        double exames = 0;
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ckbConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbConsulta.Checked) {
                consulta = 75.00;
                lblConsulta.Visible = true;
                lblConsulta.Text = "R$ " + consulta ;
                total = consulta + internacao + exames;
                lblTotalServ.Text = "R$ " + total;
                
                lblTotalPagar.Text = "R$ " + total;

                if (rdbAVista.Checked == true)
                {
                    lblTotalFormaPG.Visible = true;
                    lblTotalFormaPG.Text = "R$ " + (total - (total * 0.15));
                    lblTotalServ.Text = "R$ " + total;
                }
                if (rdbAPrazo.Checked == true)
                {
                    lblTotalFormaPG.Visible = true;
                    lblTotalFormaPG.Text = "R$ " + (total + (total * 0.15));
                    lblTotalServ.Text = "R$ " + total;
                }
            }
            if (ckbConsulta.Checked == false)
            {
                lblConsulta.Visible = false;
                consulta = 0;
                total = consulta + internacao + exames;
                lblTotalServ.Text = "R$ " + total;
                
                lblTotalPagar.Text = "R$ " + total;

                if (rdbAVista.Checked == true)
                {
                    consulta = 0;
                    lblTotalFormaPG.Visible = true;
                    lblTotalFormaPG.Text = "R$ " + (total - (total * 0.15));
                    lblTotalServ.Text = "R$ " + total;
                }
                if (rdbAPrazo.Checked == true)
                {
                    consulta = 0;
                    lblTotalFormaPG.Visible = true;
                    lblTotalFormaPG.Text = "R$ " + (total + (total * 0.15));
                    lblTotalServ.Text = "R$ " + total;
                }
            }


        }

        private void ckbInternacao_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbInternacao.Checked)
            {
                internacao = 510.00;
                lblInternacao.Visible = true;
                lblInternacao.Text = "R$ " + internacao;
                total = consulta + internacao + exames;
                lblTotalServ.Text = "R$ " + total;

                lblTotalPagar.Text = "R$ " + total;
                
                if (rdbAVista.Checked == true)
                {
                    lblTotalFormaPG.Visible = true;
                    lblTotalFormaPG.Text = "R$ " + (total - (total * 0.15));
                    lblTotalServ.Text = "R$ " + total;
                }
                if (rdbAPrazo.Checked == true)
                {
                    lblTotalFormaPG.Visible = true;
                    lblTotalFormaPG.Text = "R$ " + (total + (total * 0.15));
                    lblTotalServ.Text = "R$ " + total;
                }
            }
            if (ckbInternacao.Checked == false) 
            {
                lblInternacao.Visible = false;
                internacao = 0;
                total = consulta + internacao + exames;
                lblTotalServ.Text = "R$ " + total;

                lblTotalPagar.Text = "R$ " + total;
                
                if (rdbAVista.Checked == true)
                {
                    internacao = 0;
                    lblTotalFormaPG.Visible = true;
                    lblTotalFormaPG.Text = "R$ " + (total - (total * 0.15));
                    lblTotalServ.Text = "R$ " + total;
                }
                if (rdbAPrazo.Checked == true)
                {
                    internacao = 0;
                    lblTotalFormaPG.Visible = true;
                    lblTotalFormaPG.Text = "R$ " + (total + (total * 0.15));
                    lblTotalServ.Text = "R$ " + total;
                }
            }
        }

        private void ckbexames_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbexames.Checked)
            {
                exames = 150.00;
                lblExames.Visible = true;
                lblExames.Text = "R$ "+exames;
                total = consulta + internacao + exames;
                lblTotalServ.Text = "R$ " + total;

                lblTotalPagar.Text = "R$ " + total;
                
                if (rdbAVista.Checked == true)
                {
                    lblTotalFormaPG.Visible = true;
                    lblTotalFormaPG.Text = "R$ " + (total - (total * 0.15));
                    lblTotalServ.Text = "R$ " + total;
                }
                if (rdbAPrazo.Checked == true)
                {
                    lblTotalFormaPG.Visible = true;
                    lblTotalFormaPG.Text = "R$ " + (total + (total * 0.15));
                    lblTotalServ.Text = "R$ " + total;
                }
            }
            if (ckbexames.Checked == false)
            {
                lblExames.Visible = false;
                exames = 0;
                total = consulta + internacao + exames;
                lblTotalServ.Text = "R$ " + total;

                lblTotalPagar.Text = "R$ " + total;
                
                if (rdbAVista.Checked == true)
                {
                    exames = 0;
                    lblTotalFormaPG.Visible = true;
                    lblTotalFormaPG.Text = "R$ " + (total - (total * 0.15));
                    lblTotalServ.Text = "R$ " + total;
                }
                if (rdbAPrazo.Checked == true)
                {
                    exames = 0;
                    lblTotalFormaPG.Visible = true;
                    lblTotalFormaPG.Text = "R$ " + (total + (total * 0.15));
                    lblTotalServ.Text = "R$ " + total;
                }
            }
        }

        private void rdbSus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSus.Checked)
            {   
                lblTotalServ.Visible = true;
                lblTotalServ.Text = "R$ "+ total;
                rdbAPrazo.Enabled = false;
                rdbAVista.Enabled = false;
                
                lblTotalFormaPG.Visible = false;

                rdbAVista.Checked = false;
                rdbAPrazo.Checked = false;
                lblTotalPagar.Visible = true;
                lblTotalPagar.Text = "R$ " + total;

            }
        }

        private void rdbParticular_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbParticular.Checked)
            {
                lblTotalServ.Visible = true;
                lblTotalServ.Text = "R$ " + total;
                rdbAPrazo.Enabled = true;
                rdbAVista.Enabled = true;
                lblTotalPagar.Visible = true;
                lblTotalPagar.Text = "R$ " + total;
                lblTotalPlanoConvenio.Visible = false;
            }
        }

        private void rdbPrivado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPrivado.Checked) 
            {
                lblTotalServ.Visible = true;
                lblTotalServ.Text = "R$ " + total;
                rdbAPrazo.Enabled = false;
                rdbAVista.Enabled = false;

                lblTotalFormaPG.Visible = false;

                rdbAVista.Checked = false;
                rdbAPrazo.Checked = false;
                lblTotalPagar.Visible = true;
                lblTotalPagar.Text = "R$ " + total;
                
            }
        }

        private void rdbAVista_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdbAVista.Checked)
            {
                lblTotalFormaPG.Visible = true;
                lblTotalFormaPG.Text = "R$ " + (total - (total * 0.15));
                lblTotalServ.Text = "R$ " + total;
            }
            if (rdbAVista.Checked == false  && rdbParticular.Checked)
            {
                lblTotalFormaPG.Visible = true;
                total = consulta + internacao + exames;
                lblTotalFormaPG.Text = "R$ " + total;
            }
        }

        private void rdbAPazo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAPrazo.Checked)
            {
                lblTotalFormaPG.Visible = true;
                lblTotalFormaPG.Text = "R$ " + (total + (total * 0.15));
                lblTotalServ.Text = "R$ " + total;
            }
            if (rdbAPrazo.Checked == false && rdbParticular.Checked)
            {
                lblTotalFormaPG.Visible = true;
                total = consulta + internacao + exames;
                lblTotalFormaPG.Text = "R$ " + total;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (rdbPrivado.Checked)
            {
                lblTotalPagar.Visible = true;
                lblTotalPagar.Text = "R$ " +total; 
                lblTotalPlanoConvenio.Text = "R$ " + (total + (total * 0.375));


            }
            if (rdbSus.Checked == true)
            {
                lblTotalPlanoConvenio.Visible = true;
                lblTotalPlanoConvenio.Text = "R$ " + (total + (total* 0.075));
    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paciente.Text = "";
            telefone.Text = "";
            
            rdbSus.Checked = false;
            rdbParticular.Checked = false;
            rdbPrivado.Checked = false;
            
            ckbConsulta.Checked = false;
            ckbInternacao.Checked = false;
            ckbexames.Checked = false;
            
            rdbAVista.Checked = false;
            rdbAPrazo.Checked = false;
            
            lblTotalServ.Text = "";
            lblTotalFormaPG.Text = "";
            lblTotalPagar.Text = "";
            lblTotalPlanoConvenio.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

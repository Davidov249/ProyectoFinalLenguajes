using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinasTuring
{
    public partial class Form1 : Form
    {
        public List<String> cinta = new List<string>();
        public MultiplicacionUnaria mult = new MultiplicacionUnaria();
        public Palindromos pal = new Palindromos();
        public Patrones pat = new Patrones();
        public SumaUnaria sum = new SumaUnaria();
        public RestaUnaria res = new RestaUnaria();
        public int pos = 0;
        public List<String> cabezal = new List<string>();
        public bool resultado = false;
        public bool ejecutar = false;

        public void llenarCabezal()
        {
            for (int i = 0; i < cinta.Count; i++)
            {
                if (i == pos)
                {
                    cabezal.Add("^");
                }
                else
                {
                    cabezal.Add(i.ToString());
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            //Actualizador.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cbPal_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbCP_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbR_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Actualizador_Tick(object sender, EventArgs e)
        {
            //if (ejecutar)
            //{
            //    if (radioButton1.Checked)
            //    {
            //        cinta = pal.Cinta;
            //        pos = pal.posCabezal;
            //        Display.Add(cinta);
            //        Display.Add(cabezal);
            //        dgvCinta.DataSource = Display;
            //        resultado = pal.aceptar;
            //        Display.Clear();
            //    }
            //    else if (radioButton2.Checked)
            //    {
            //        cinta = pat.Cinta;
            //        pos = pat.posCabezal;
            //        Display.Add(cinta);
            //        Display.Add(cabezal);
            //        dgvCinta.DataSource = Display;
            //        resultado = pat.aceptar;
            //        Display.Clear();
            //    }
            //    else if (radioButton3.Checked)
            //    {
            //        cinta = sum.Cinta;
            //        pos = sum.posCabezal;
            //        Display.Add(cinta);
            //        Display.Add(cabezal);
            //        dgvCinta.DataSource = Display;
            //        resultado = sum.aceptar;
            //        Display.Clear();
            //    }
            //    else if (radioButton4.Checked)
            //    {
            //        cinta = res.Cinta;
            //        pos = res.posCabezal;
            //        Display.Add(cinta);
            //        Display.Add(cabezal);
            //        dgvCinta.DataSource = Display;
            //        resultado = res.aceptar;
            //        Display.Clear();
            //    }
            //    else if (radioButton5.Checked)
            //    {
            //        cinta = mult.Cinta;
            //        pos = mult.posCabezal;
            //        Display.Add(cinta);
            //        Display.Add(cabezal);
            //        dgvCinta.DataSource = Display;
            //        resultado = mult.aceptar;
            //        Display.Clear();
            //    }
            //}
            txtCabezal.Clear();
            txtCinta.Clear();
            rtxtCinta.Clear();
            if (radioButton1.Checked)
            {
                cinta = pal.Cinta;
                pos = pal.posCabezal;
                llenarCabezal();
                txtCinta.Text = string.Join("-", cinta);
                txtCabezal.Text = string.Join(",", cabezal);
                rtxtCinta.Text = string.Join("", cinta);
                rtxtCinta.Select(pos, 1);
                rtxtCinta.SelectionColor = Color.Red;
                //txtCinta.Text = String.Join(Environment.NewLine, cinta);
                //txtCabezal.Text = String.Join(Environment.NewLine, cabezal);
                resultado = pal.aceptar;
                ejecutar = pal.final;
            }
            else if (radioButton2.Checked)
            {
                cinta = pat.Cinta;
                pos = pat.posCabezal;
                llenarCabezal();
                txtCinta.Text = string.Join("-", cinta);
                txtCabezal.Text = string.Join(",", cabezal);
                rtxtCinta.Text = string.Join("", cinta);
                rtxtCinta.Select(pos, 1);
                rtxtCinta.SelectionColor = Color.Red;
                resultado = pat.aceptar;
                ejecutar = pat.final;
            }
            else if (radioButton3.Checked)
            {
                cinta = sum.Cinta;
                pos = sum.posCabezal;
                llenarCabezal();
                txtCinta.Text = string.Join("-", cinta);
                txtCabezal.Text = string.Join(",", cabezal);
                rtxtCinta.Text = string.Join("", cinta);
                rtxtCinta.Select(pos, 1);
                rtxtCinta.SelectionColor = Color.Red;
                resultado = sum.aceptar;
                ejecutar = sum.final;
            }
            else if (radioButton4.Checked)
            {
                cinta = res.Cinta;
                pos = res.posCabezal;
                llenarCabezal();
                txtCinta.Text = string.Join("-", cinta);
                txtCabezal.Text = string.Join(",", cabezal);
                rtxtCinta.Text = string.Join("", cinta);
                rtxtCinta.Select(pos, 1);
                rtxtCinta.SelectionColor = Color.Red;
                resultado = res.aceptar;
                ejecutar = res.final;
            }
            else if (radioButton5.Checked)
            {
                cinta = mult.Cinta;
                pos = mult.posCabezal;
                llenarCabezal();
                txtCinta.Text = string.Join("-", cinta);
                txtCabezal.Text = string.Join(",", cabezal);
                rtxtCinta.Text = string.Join("", cinta);
                rtxtCinta.Select(pos, 1);
                rtxtCinta.SelectionColor = Color.Red;
                resultado = mult.aceptar;
                ejecutar = mult.final;
            }
            cabezal.Clear();
            if (ejecutar)
            {
                Actualizador.Stop();
                Actualizador.Dispose();
                MensajeResultado();
                txtCadena.ReadOnly = false;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
                btnEjecutar.Enabled = true;
            }
        }

        private void Actualizador_Elapsed(object sender, ElapsedEventArgs e)
        {
            
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            txtCadena.ReadOnly = true;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            btnEjecutar.Enabled = false;
            //rtxtCinta.Clear();
            //txtCabezal.Clear();
            Actualizador.Start();
            if (radioButton1.Checked)
            {
                //ejecutar = true;
                //if (comboBox1.SelectedIndex == 0)
                //{
                //    pal.vel = 1000;
                //}
                //else if (comboBox1.SelectedIndex == 1)
                //{
                //    pal.vel = 1500;
                //}
                //else
                //{
                //    pal.vel = 2000;
                //}
                pal.resetear();
                pal.ArmarCinta(txtCadena.Text);
                pal.Ejecutar();
                //cinta = pal.Cinta;
                //var source = new BindingSource(cinta, null);
                //dgvCinta.DataSource = source;
            }
            else if (radioButton2.Checked)
            {
                //ejecutar = true;
                pat.resetear();
                pat.ArmarCinta(txtCadena.Text);
                pat.Ejecutar();
            }
            else if (radioButton3.Checked)
            {
                //ejecutar = true;
                sum.resetear();
                sum.ArmarCinta(txtCadena.Text);
                sum.Ejecutar();
            }
            else if (radioButton4.Checked)
            {
                //ejecutar = true;
                res.resetear();
                res.ArmarCinta(txtCadena.Text);
                res.Ejecutar();
            }
            else if (radioButton5.Checked)
            {
                //ejecutar = true;
                mult.resetear();
                mult.ArmarCinta(txtCadena.Text);
                mult.Ejecutar();
            }
            //Actualizador.Stop();
            //Actualizador.Dispose();
            //ejecutar = false;
            //MensajeResultado();
        }

        private void MensajeResultado()
        {
            if (resultado)
            {
                MessageBox.Show("¡La cadena a sido aceptada con exito!", "¡Resultado!");
            }
            else
            {
                MessageBox.Show("La cadena no es reconocida por la Maquina de Turing seleccionada", "¡Resultado!");
            }
        }

        private void dgvCinta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_de_Obras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ObraChaveDominio dominio = new ObraChaveDominio();

        private void Form1_Load(object sender, EventArgs e)
        {

            var list = dominio.ListarRegional(string.Empty, string.Empty, string.Empty);

            comboBox1.Items.AddRange(list.ToArray());

        }
    }
}

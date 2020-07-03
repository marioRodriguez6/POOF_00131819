using System;
using System.Windows.Forms;

namespace Parcial_03
{
    public partial class WFEmpleado : Form
    {
        private readonly string usuarioAct = "";
        public WFEmpleado(string usuarioAct)
        {
            this.usuarioAct = usuarioAct;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var nextWFs = new Form1();
            nextWFs.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            var Query = "select * from REGISTRO where " +
                        $"carnetUs = '{usuarioAct}'";

            var dt = ConnectionDbp3.ExecuteQuery(Query);
            try
            {
                dataGridView3.DataSource = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
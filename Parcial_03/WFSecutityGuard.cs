using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial_03
{
    public partial class WFSecutityGuard : Form
    {
        public WFSecutityGuard()
        {
            InitializeComponent();
        }

        //Crear registro
        private void button3_Click(object sender, EventArgs e)
        {
            if (TB_FYH.Text.Equals("") || TB_Temperatura.Text.Equals(""))
                MessageBox.Show("Por favor inserta los datos necesarios");
            else
                try
                {
                    var Query = "";

                    Query = "INSERT " +
                            "INTO " +
                            "REGISTRO(entrada,fecha_y_hora,temperatura,carnetUs) " +
                            $"VALUES(true,'{TB_FYH.Text}','{TB_Temperatura.Text}','{comboBox1.SelectedItem}')";


                    ConnectionDbp3.ExecuteNonQuery(Query);

                    MessageBox.Show("Registro creado con exito");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Registro no creado");
                }
        }

        private void WFSecutityGuard_Load_1(object sender, EventArgs e)
        {
            var users = ConnectionDbp3.ExecuteQuery("SELECT carnetUs FROM USUARIO");
            var usersCombo = new List<string>();

            foreach (DataRow row in users.Rows) usersCombo.Add(row[0].ToString());
            comboBox1.DataSource = usersCombo;
            comboBox2.DataSource = usersCombo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TB_FYH.Text.Equals("") || TB_Temperatura.Text.Equals(""))
                MessageBox.Show("Por favor inserta los datos necesarios");
            else
                try
                {
                    var Query = "";

                    Query = "INSERT " +
                            "INTO " +
                            "REGISTRO(entrada,fecha_y_hora,temperatura,carnetUs) " +
                            $"VALUES(false,'{TB_FYH.Text}','{TB_Temperatura.Text}','{comboBox2.SelectedItem}')";


                    ConnectionDbp3.ExecuteNonQuery(Query);

                    MessageBox.Show("Registro creado con exito");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Registro no creado");
                }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Hide();
            var nextWFs = new Form1();
            nextWFs.Show();
        }
    }
}
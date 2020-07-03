using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial_03
{
    public partial class Form1 : Form
    {
        private Form dr = new WFAdministrador();
        private Form ds = new WFSecutityGuard();
        private delegate void Mydelegate(Form NextWFs);
        private static Mydelegate _accountmanagment;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        IData Cambio = new ChangeWFAdmin()

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                var password = ConnectionDbp3.ExecuteQuery("SELECT contraseña From usuario " +
                                                           $"WHERE carnetUs = '{comboBox1.SelectedItem}'");
                var password2 = password.Rows[0];
                var contraF = password2[0].ToString();


                if (textBox1.Text.Equals(contraF))
                {
                    //id del Departamento
                    var dep = ConnectionDbp3.ExecuteQuery("SELECT idDepartamento FROM usuario " +
                                                          $"WHERE carnetUs = '{comboBox1.SelectedItem}'");
                    var depa = dep.Rows[0];
                    var depart = Convert.ToInt32(depa[0].ToString());

                    //nombre del departamento
                    var na = ConnectionDbp3.ExecuteQuery("select nombre from DEPARTAMENTO " +
                                                         $"where idDepartamento = {depart}");
                    var nam = na.Rows[0];
                    var name = nam[0].ToString();

                    if (name == "Administrativo")
                    {
                        Hide();
                        Cambio = new ChangeWFAdmin();

                        _accountmanagment = Cambio.Clases;
                        _accountmanagment.Invoke(dr);
                        
                        dr.Show();
                    }
                    else if (name == "Vigilancia")
                    {
                        Hide();
                        _accountmanagment = Cambio.Clases; 
                        _accountmanagment.Invoke(ds);
                        
                        ds.Show();
                    }
                    else if (name == "General")
                    {
                        Hide();
                        var nextWF = new WFEmpleado(comboBox1.SelectedItem.ToString());
                        nextWF.Show();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("error en contra");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var users = ConnectionDbp3.ExecuteQuery("SELECT carnetUs FROM USUARIO");
            var usersCombo = new List<string>();

            foreach (DataRow row in users.Rows) usersCombo.Add(row[0].ToString());
            comboBox1.DataSource = usersCombo;
        }
    }
}
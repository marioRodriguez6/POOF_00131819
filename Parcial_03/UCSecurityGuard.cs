using System;
using System.Windows.Forms;

namespace Parcial_03
{
    public partial class UCSecurityGuard : UserControl
    {
        public UCSecurityGuard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var password = ConnectionDbp3.ExecuteQuery("SELECT contraseña From usuario " +
                                                         $"WHERE username = '{comboBox1.SelectedItem}'");
                var password2 = password.Rows[0];
                var password3 = password2[0].ToString();


                if (textBox1.Text.Equals(password3))
                {
                    var ad = ConnectionDbp3.ExecuteQuery("SELECT tipoUser FROM usuario " +
                                                       $"WHERE username = '{comboBox1.SelectedItem}'");
                    var adm = ad.Rows[0];
                    var admin = Convert.ToBoolean(adm[0].ToString());

                    if (admin)
                    {
                        Hide();
                        var nextWF = new WFAdministrador();
                        nextWF.Show();
                    }
                    else
                    {
                        Hide();
                        var nextWF = new WFEmpleado();
                        nextWF.Show();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    }
}
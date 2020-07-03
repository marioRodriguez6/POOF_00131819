using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial_03
{
    public partial class WFAdministrador : Form
    {
        public WFAdministrador()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TB_Name.Text.Equals("") || TB_Apellido.Text.Equals("") || TB_Carnet.Text.Equals("") || 
                TB_Password.Text.Equals("") || TB_FN.Text.Equals(""))
                MessageBox.Show("Por favor inserta los datos necesarios");
            else
                try
                {
                    var dep = ConnectionDbp3.ExecuteQuery("SELECT idDepartamento FROM DEPARTAMENTO " +
                                                          $"WHERE nombre = '{CB_Depa.SelectedItem}'");
                    var depa = dep.Rows[0];
                    var depart = Convert.ToInt32(depa[0].ToString());
                
                
                    var Query = "INSERT INTO " +
                    " USUARIO(carnetUs,contraseña,nombre,apellido,dui,fechaNacimiento,idDepartamento)" +
                    $" VALUES ('{TB_Carnet.Text}','{TB_Password.Text}','{TB_Name.Text}','{TB_Apellido.Text}','{TB_dui.Text}','{TB_FN.Text}','{depart}')"; 
               

                    ConnectionDbp3.ExecuteNonQuery(Query);

                    MessageBox.Show("Usuario insertado con exito");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Usuario no ingresado");
                }
        }

        private void Btn_DeleteUser_Click(object sender, EventArgs e)
        {
            var query2 = ConnectionDbp3.ExecuteQuery("select dui from USUARIO " +
                                                   $"WHERE carnetUs ='{comboBox3.Text}'");
            var query3 = query2.Rows[0];
            var query4 = Convert.ToInt32(query3[0].ToString());

            var NonQuery = $"DELETE FROM USUARIO WHERE dui = '{query4}'";
            try
            {
                ConnectionDbp3.ExecuteNonQuery(NonQuery);
                MessageBox.Show("Usuario eliminado");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Usuario no eliminado");
             
            }
        }
       

        private void WFAdministrador_Load(object sender, EventArgs e)
        {
           var users = ConnectionDbp3.ExecuteQuery("SELECT nombre FROM Departamento");
           var usersCombo = new List<string>();
        
           foreach (DataRow row in users.Rows) usersCombo.Add((row[0].ToString()));
           CB_Depa.DataSource = usersCombo;
           
           var dui = ConnectionDbp3.ExecuteQuery("SELECT carnetUs FROM USUARIO");
           var duidel = new List<string>();
           
           foreach (DataRow row in dui.Rows) duidel.Add((row[0].ToString()));
           comboBox3.DataSource = duidel;
        }
    }
}
using System;
using System.Windows.Forms;

namespace Parcial_03
{
    public class ChangeWFAdmin: IData
    {
        public void Clases(Form NextWFs)
        {
            NextWFs = new WFAdministrador();
        }
    }
}
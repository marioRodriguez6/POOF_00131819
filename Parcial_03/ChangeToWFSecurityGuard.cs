using System.Windows.Forms;

namespace Parcial_03
{
    public class ChangeToWFSecurityGuard: IData
    {
        public void Clases(Form NextWFs)
        {
            NextWFs = new WFSecutityGuard();
        }
    }
}
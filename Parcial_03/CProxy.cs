using System.Windows.Forms;

namespace Parcial_03
{
    public class CProxy
    {
        public interface IUsuario
       {
           void Acceso(string password);
       }
       
       public class ProxySecurity: IUsuario
       {
           private UCSecurityGuard _security;
           public void Acceso(string password)
           {
               
           }
       }
    }
}
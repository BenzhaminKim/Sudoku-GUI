using System.Windows.Forms;
using System.Drawing;
namespace sudokuGUI
{
    class Tools
    {
       static public string GetText(object sender)
        {
            Button btn = sender as Button;
            return btn.Text;
           
        }
    }
}

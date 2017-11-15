using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace How_become_milioner
{
    public class Dilog:ILog
    {
        public void Write(string s)
        {
            MessageBox.Show(s, "Окно сообщения", MessageBoxButtons.OK);
        }
        public void Print_Question(string s)
        {
            MessageBox.Show(s, "Окно сообщения", MessageBoxButtons.OK);
        }
    }
}

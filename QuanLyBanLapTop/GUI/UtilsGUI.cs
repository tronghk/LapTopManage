using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class UtilsGUI
    {

        public static void autoSizetb(DataGridView tb)
        {
            tb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tb.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

    }
}

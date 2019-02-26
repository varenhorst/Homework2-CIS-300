using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    public partial class SetCapacityDialog : Form
    {
        public SetCapacityDialog()
        {
            InitializeComponent();
        }

        //public property to get or set the capcity displayed in the dialog.
        public int Capacity { get; set; }

        //Event Handler for clicking the OK button
        //Sets the Capacity property to the value in the Numeric Up Down component
        private void UxOk_Click(object sender, EventArgs e)
        {
            Capacity = (int)uxCapacity.Value;
        }
    }
}

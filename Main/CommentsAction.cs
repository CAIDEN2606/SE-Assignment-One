using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class CommentsAction : Form
    {
        public CommentsAction()
        {
            InitializeComponent();
        }

        private void btn_takePic_Click(object sender, EventArgs e)
        {
            /*take user to camera to take a picture*/
        }

        private void btn_confirmInspection_Click(object sender, EventArgs e)
        {
            /*save inspection awaiting download */

        }

        private void btn_backSubHead_Click(object sender, EventArgs e)
        {
            /*return from sub-heading page to inspection page with no save*/
            /*display popup message to check ok to exit without saving*/
            DialogResult result = MessageBox.Show("This will exit without saving, are you sure?","confirm",MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;
            else
                this.Close();
                

             
        }

        private void btn_deletePic_Click(object sender, EventArgs e)
        {
            /*delete selected picture*/

        }
    }
}

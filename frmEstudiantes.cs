using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaExam
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }


        private void btnEp_Click_1(object sender, EventArgs e)
        {
            frmPregrado frmPregrado = new frmPregrado();
            frmPregrado.ShowDialog();

        }

        private void btnEr_Click(object sender, EventArgs e)
        {
            frmRegular frmRegular = new frmRegular();   
            frmRegular.ShowDialog();
        }
    }
}

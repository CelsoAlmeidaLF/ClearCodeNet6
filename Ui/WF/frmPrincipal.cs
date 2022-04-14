#define Beta

using Systekna;
using System;
using System.Windows.Forms;

namespace WF
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Versionamento();
        }

        private void Versionamento()
        {
            Framework.StringConection = "";
#if DEBUG
            this.Text += " [DEV]";
#elif Beta
            this.Text += " [BETA]";
#else
            this.Text += " [PRO]";
#endif

        }
    }
}

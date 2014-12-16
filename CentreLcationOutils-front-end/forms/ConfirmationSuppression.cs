using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CentreLocationOutils_front_end.forms
{
    public partial class ConfirmationSuppression : Form
    {
        public ConfirmationSuppression()
        {
            InitializeComponent();
            btnOk.DialogResult = DialogResult.OK;
            btnAnnuler.DialogResult = DialogResult.Cancel;
        }

        public string Message {
            get { return this.lblMessage.Text; }
            set { this.lblMessage.Text = value; }
        }
    }
}

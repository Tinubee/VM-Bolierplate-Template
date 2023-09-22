using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionMaster.UI.Form;

namespace VisionMaster.UI.Control
{
    public partial class SetInspection : UserControl
    {
        public SetInspection()
        {
            InitializeComponent();
        }

        public void Init()
        {
            this.bVMSetting.Click += bVMSetting_Click;
        }
        private void bVMSetting_Click(object sender, EventArgs e)
        {
            Teaching form = new Teaching();
            form.Show(Global.MainForm);
        }
    }
}

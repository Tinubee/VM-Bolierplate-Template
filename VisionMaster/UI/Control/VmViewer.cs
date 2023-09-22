using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionMaster.Schemas;

namespace VisionMaster.UI.Control
{
    public partial class VmViewer : UserControl
    {
        public VmViewer()
        {
            InitializeComponent();
        }

        public void Init()
        {
            this.vmRenderControl1.ModuleSource = Global.VMControl.GetItem(FlowCheck.Flow1).graphicsSetModuleTool;
            this.vmRenderControl2.ModuleSource = Global.VMControl.GetItem(FlowCheck.Flow2).graphicsSetModuleTool;
            this.vmRenderControl3.ModuleSource = Global.VMControl.GetItem(FlowCheck.Flow3).graphicsSetModuleTool;
            this.vmRenderControl4.ModuleSource = Global.VMControl.GetItem(FlowCheck.Flow4).graphicsSetModuleTool;
        }
    }
}

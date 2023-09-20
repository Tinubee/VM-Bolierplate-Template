using DevExpress.Utils;
using GraphicsSetModuleCs;
using ImageSourceModuleCs;
using IMVSAffineTransformModuCs;
using OpenCvSharp;
using ShellModuleCs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VM.Core;
using VM.PlatformSDKCS;

namespace VisionMaster.Schemas
{
    public enum FlowCheck
    {
        //Add Use Flow
        Flow1 = 1,
        Flow2 = 2,
        Flow3 = 3,
        Flow4 = 4,
    }
    public class VMControl : List<VMFlow>
    {

        private String SolutionFile { get => Path.Combine(Global.Setting.DefaultPath, "Test.sol"); }
        public VMGlobals GlobalVariable = new VMGlobals();
        public Boolean Init() => Load();

        public Boolean Load()
        {
            try
            {
                base.Clear();
                if (File.Exists(SolutionFile))
                {
                    VmSolution.Load(SolutionFile, null);
                    GlobalVariable.Init();
                }
                VmSolution.Instance.DisableModulesCallback();
                foreach (FlowCheck Flow in typeof(FlowCheck).GetValues()) base.Add(new VMFlow(Flow));
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message, "VM Solution Load Error");
                return false;
            }
        }

        public VMFlow GetItem(FlowCheck Flow)
        {
            foreach (VMFlow flow in this)
                if (flow.Flow == Flow) return flow;
            return null;
        }
    }

    public class VMFlow
    {
        public FlowCheck Flow;
        public VmProcedure Procedure;
        public ImageSourceModuleTool imageSourceModuleTool;
        public GraphicsSetModuleTool graphicsSetModuleTool;
        public ShellModuleTool shellModuleTool;
        public IMVSAffineTransformModuTool affineTransformModuleTool;

        public VMFlow(FlowCheck Flow)
        {
            this.Flow = Flow;
            this.Init();
            if (this.graphicsSetModuleTool != null)
            {
                this.graphicsSetModuleTool.EnableResultCallback();
                if (this.affineTransformModuleTool != null) this.affineTransformModuleTool.EnableResultCallback();
                this.shellModuleTool.EnableResultCallback();
                this.shellModuleTool.ModuleResultCallBackArrived += ShellModuleTool_ModuleResultCallBackArrived;
            }
        }
        private void ShellModuleTool_ModuleResultCallBackArrived(object sender, EventArgs e) { }

        public void Init()
        {
            this.Procedure = VmSolution.Instance[this.Flow.ToString()] as VmProcedure;
            if (Procedure != null)
            {
                this.imageSourceModuleTool = this.Procedure["InputImage"] as ImageSourceModuleTool;
                this.graphicsSetModuleTool = this.Procedure["OutputImage"] as GraphicsSetModuleTool;
                this.shellModuleTool = this.Procedure["resulte"] as ShellModuleTool;
                this.imageSourceModuleTool.ModuParams.ImageSourceType = ImageSourceParam.ImageSourceTypeEnum.SDK;
            }
        }

        private void SetResult(FlowCheck Flow)
        {
            ShellModuleTool shell = Global.VMControl.GetItem(Flow).shellModuleTool;
            for (int i = 6; i < shell.Outputs.Count; i++)
            {
                List<VmIO> t = shell.Outputs[i].GetAllIO();
                String name = t[0].UniqueName.Split('%')[1];
                if (t[0].Value != null)
                {
                    String str = ((ImvsSdkDefine.IMVS_MODULE_STRING_VALUE_EX[])t[0].Value)[0].strValue;
                    try
                    {
                        String[] vals = str.Split(';');
                        Boolean ok = false;
                        Single val = Single.NaN;
                        if (!String.IsNullOrEmpty(vals[0])) val = Convert.ToSingle(vals[0]);
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e.Message, name);
                    }
                }
            }
        }

        public Boolean Run(Mat mat, ImageBaseData imageBaseData)
        {
            if (this.imageSourceModuleTool == null)
            {
                return false;
            }
            try
            {
                imageBaseData = mat == null ? imageBaseData : MatToImageBaseData(mat);
                this.imageSourceModuleTool.SetImageData(imageBaseData);
                this.Procedure.Run();
                this.SetResult(Flow);

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "VisionMaster Run Error");
                return false;
            }
        }

        private ImageBaseData MatToImageBaseData(Mat mat)
        {
            if (mat.Channels() != 1) return null;
            ImageBaseData imageBaseData;
            uint dataLen = (uint)(mat.Width * mat.Height * mat.Channels());
            byte[] buffer = new byte[dataLen];
            Marshal.Copy(mat.Ptr(0), buffer, 0, buffer.Length);
            imageBaseData = new ImageBaseData(buffer, dataLen, mat.Width, mat.Height, (int)VMPixelFormat.VM_PIXEL_MONO_08);
            return imageBaseData;
        }
    }
}

﻿using GlobalVariableModuleCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VM.Core;

namespace VisionMaster.Schemas
{
    public class VMGlobals : List<VmVariable>
    {
        private GlobalVariableModuleTool Variables;

        public void Init()
        {
            this.Variables = VmSolution.Instance["Global Variable1"] as GlobalVariableModuleTool;
            List<GlobalVarInfo> lists = Variables.GetAllGlobalVar();
            foreach (GlobalVarInfo info in lists)
            {
                if (info.strValueType.ToLower() == typeof(String).Name.ToLower()) continue;
                this.Add(new VmVariable(info));
            }
        }

        public void Set()
        {
            foreach (VmVariable v in this)
                this.Variables.SetGlobalVar(v.Name, v.StringValue);
        }
    }

    public class VmVariable
    {
        public String Name { get; private set; } = String.Empty;
        public String Description { get; private set; } = String.Empty;
        public Type Type { get; private set; } = null;
        public Object Value { get; set; } = null;
        public String StringValue
        {
            get { return this.Value == null ? String.Empty : Value.ToString(); }
            set { this.Set(value); }
        }

        public VmVariable() { }
        public VmVariable(GlobalVarInfo info)
        {
            this.Name = info.strValueName;
            this.Description = info.strRemark;
            if (info.strValueType == "float") this.Type = typeof(Single);
            else if (info.strValueType == "int") this.Type = typeof(Int32);
            else this.Type = typeof(String);
            this.Value = info.strValue;
            //Debug.WriteLine($"{this.Type} => {this.Value}", this.Name);
        }

        public void Set(String value)
        {
            if (this.Type == typeof(Single)) this.Value = Convert.ToSingle(value);
            else if (this.Type == typeof(Int32)) this.Value = Convert.ToInt32(value);
            else this.Value = value;
        }
    }
}

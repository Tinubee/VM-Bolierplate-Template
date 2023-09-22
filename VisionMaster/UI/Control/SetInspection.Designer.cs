namespace VisionMaster.UI.Control
{
    partial class SetInspection
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetInspection));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bVMSetting = new DevExpress.XtraEditors.SimpleButton();
            this.bSettingSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Controls.Add(this.bVMSetting);
            this.panelControl1.Controls.Add(this.bSettingSave);
            this.panelControl1.Name = "panelControl1";
            // 
            // bVMSetting
            // 
            resources.ApplyResources(this.bVMSetting, "bVMSetting");
            this.bVMSetting.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("b도구설정.Appearance.Font")));
            this.bVMSetting.Appearance.Options.UseFont = true;
            this.bVMSetting.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("b도구설정.ImageOptions.SvgImage")));
            this.bVMSetting.Name = "bVMSetting";
            // 
            // bSettingSave
            // 
            resources.ApplyResources(this.bSettingSave, "bSettingSave");
            this.bSettingSave.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("b설정저장.Appearance.Font")));
            this.bSettingSave.Appearance.Options.UseFont = true;
            this.bSettingSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("b설정저장.ImageOptions.SvgImage")));
            this.bSettingSave.Name = "bSettingSave";
            // 
            // SetInspection
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.panelControl1);
            this.Name = "SetInspection";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton bVMSetting;
        private DevExpress.XtraEditors.SimpleButton bSettingSave;
    }
}

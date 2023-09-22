namespace VisionMaster.UI.Control
{
    partial class VmViewer
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
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.vmRenderControl1 = new VMControls.Winform.Release.VmRenderControl();
            this.vmRenderControl2 = new VMControls.Winform.Release.VmRenderControl();
            this.vmRenderControl3 = new VMControls.Winform.Release.VmRenderControl();
            this.vmRenderControl4 = new VMControls.Winform.Release.VmRenderControl();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel2.Controls.Add(this.vmRenderControl4);
            this.tablePanel2.Controls.Add(this.vmRenderControl3);
            this.tablePanel2.Controls.Add(this.vmRenderControl2);
            this.tablePanel2.Controls.Add(this.vmRenderControl1);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 500F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 500F)});
            this.tablePanel2.Size = new System.Drawing.Size(1257, 839);
            this.tablePanel2.TabIndex = 1;
            this.tablePanel2.UseSkinIndents = true;
            // 
            // vmRenderControl1
            // 
            this.vmRenderControl1.BackColor = System.Drawing.Color.Black;
            this.vmRenderControl1.CoordinateInfoVisible = true;
            this.vmRenderControl1.ImageSource = null;
            this.vmRenderControl1.Location = new System.Drawing.Point(5, 6);
            this.vmRenderControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vmRenderControl1.ModuleSource = null;
            this.vmRenderControl1.Name = "vmRenderControl1";
            this.vmRenderControl1.Size = new System.Drawing.Size(620, 410);
            this.vmRenderControl1.TabIndex = 1;
            // 
            // vmRenderControl2
            // 
            this.vmRenderControl2.BackColor = System.Drawing.Color.Black;
            this.vmRenderControl2.CoordinateInfoVisible = true;
            this.vmRenderControl2.ImageSource = null;
            this.vmRenderControl2.Location = new System.Drawing.Point(633, 7);
            this.vmRenderControl2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.vmRenderControl2.ModuleSource = null;
            this.vmRenderControl2.Name = "vmRenderControl2";
            this.vmRenderControl2.Size = new System.Drawing.Size(620, 407);
            this.vmRenderControl2.TabIndex = 2;
            // 
            // vmRenderControl3
            // 
            this.vmRenderControl3.BackColor = System.Drawing.Color.Black;
            this.vmRenderControl3.CoordinateInfoVisible = true;
            this.vmRenderControl3.ImageSource = null;
            this.vmRenderControl3.Location = new System.Drawing.Point(5, 426);
            this.vmRenderControl3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.vmRenderControl3.ModuleSource = null;
            this.vmRenderControl3.Name = "vmRenderControl3";
            this.vmRenderControl3.Size = new System.Drawing.Size(620, 406);
            this.vmRenderControl3.TabIndex = 3;
            // 
            // vmRenderControl4
            // 
            this.vmRenderControl4.BackColor = System.Drawing.Color.Black;
            this.tablePanel2.SetColumn(this.vmRenderControl4, 1);
            this.vmRenderControl4.CoordinateInfoVisible = true;
            this.vmRenderControl4.ImageSource = null;
            this.vmRenderControl4.Location = new System.Drawing.Point(633, 427);
            this.vmRenderControl4.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.vmRenderControl4.ModuleSource = null;
            this.vmRenderControl4.Name = "vmRenderControl4";
            this.tablePanel2.SetRow(this.vmRenderControl4, 1);
            this.vmRenderControl4.Size = new System.Drawing.Size(620, 404);
            this.vmRenderControl4.TabIndex = 4;
            // 
            // VmViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel2);
            this.Name = "VmViewer";
            this.Size = new System.Drawing.Size(1257, 839);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private VMControls.Winform.Release.VmRenderControl vmRenderControl4;
        private VMControls.Winform.Release.VmRenderControl vmRenderControl3;
        private VMControls.Winform.Release.VmRenderControl vmRenderControl2;
        private VMControls.Winform.Release.VmRenderControl vmRenderControl1;
    }
}

namespace BabyPainter
{
    partial class LineSelectBox
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.lineButtonThick = new BabyPainter.LineButton();
            this.lineButtonThin = new BabyPainter.LineButton();
            this.SuspendLayout();
            // 
            // lineButtonThick
            // 
            this.lineButtonThick.LineColor = System.Drawing.Color.Blue;
            this.lineButtonThick.LineWidth = 10F;
            this.lineButtonThick.Location = new System.Drawing.Point(3, 40);
            this.lineButtonThick.Name = "lineButtonThick";
            this.lineButtonThick.Selected = false;
            this.lineButtonThick.Size = new System.Drawing.Size(72, 28);
            this.lineButtonThick.TabIndex = 5;
            this.lineButtonThick.Click += new System.EventHandler(this.OnLineButtonClick);
            this.lineButtonThick.MouseEnter += new System.EventHandler(this.OnLineButtonMouseEnter);
            // 
            // lineButtonThin
            // 
            this.lineButtonThin.LineColor = System.Drawing.Color.Blue;
            this.lineButtonThin.LineWidth = 3F;
            this.lineButtonThin.Location = new System.Drawing.Point(3, 3);
            this.lineButtonThin.Name = "lineButtonThin";
            this.lineButtonThin.Selected = false;
            this.lineButtonThin.Size = new System.Drawing.Size(72, 28);
            this.lineButtonThin.TabIndex = 4;
            this.lineButtonThin.Click += new System.EventHandler(this.OnLineButtonClick);
            this.lineButtonThin.MouseEnter += new System.EventHandler(this.OnLineButtonMouseEnter);
            // 
            // LineSelectBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lineButtonThick);
            this.Controls.Add(this.lineButtonThin);
            this.Name = "LineSelectBox";
            this.Size = new System.Drawing.Size(80, 78);
            this.ResumeLayout(false);

        }

        #endregion

        private LineButton lineButtonThick;
        private LineButton lineButtonThin;
    }
}

namespace BabyPainter
{
    partial class FormMain
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.paletteSelectBox1 = new BabyPainter.PaletteSelectBox();
            this.lineSelectBox1 = new BabyPainter.LineSelectBox();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonNew.Location = new System.Drawing.Point(12, 12);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(100, 50);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonExit.Location = new System.Drawing.Point(118, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 50);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // paletteSelectBox1
            // 
            this.paletteSelectBox1.Location = new System.Drawing.Point(224, 12);
            this.paletteSelectBox1.Name = "paletteSelectBox1";
            this.paletteSelectBox1.SelectedColor = System.Drawing.Color.Empty;
            this.paletteSelectBox1.Size = new System.Drawing.Size(705, 71);
            this.paletteSelectBox1.TabIndex = 4;
            this.paletteSelectBox1.ColorChanged += new BabyPainter.ColorChangedEventHandler(this.paletteSelectBox1_ColorChanged);
            // 
            // lineSelectBox1
            // 
            this.lineSelectBox1.LineColor = System.Drawing.Color.Empty;
            this.lineSelectBox1.Location = new System.Drawing.Point(12, 68);
            this.lineSelectBox1.Name = "lineSelectBox1";
            this.lineSelectBox1.SelectedLineWidth = 0F;
            this.lineSelectBox1.Size = new System.Drawing.Size(80, 78);
            this.lineSelectBox1.TabIndex = 5;
            this.lineSelectBox1.LineWidthChanged += new BabyPainter.LineWidthChangedEventHandler(this.lineSelectBox1_LineWidthChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 310);
            this.Controls.Add(this.lineSelectBox1);
            this.Controls.Add(this.paletteSelectBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Baby Painter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonExit;
        private PaletteSelectBox paletteSelectBox1;
        private LineSelectBox lineSelectBox1;
    }
}


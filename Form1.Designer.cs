
namespace windowCar
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.engineOnBtn = new System.Windows.Forms.Button();
            this.engineOffBtn = new System.Windows.Forms.Button();
            this.carStopBtn = new System.Windows.Forms.Button();
            this.accelerationBtn = new System.Windows.Forms.Button();
            this.releasingBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.velocityLbl = new System.Windows.Forms.Label();
            this.petrolLbl = new System.Windows.Forms.Label();
            this.carStatusLbl = new System.Windows.Forms.Label();
            this.engineDMGLbl = new System.Windows.Forms.Label();
            this.drivingDistanceLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.constSpeedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // engineOnBtn
            // 
            this.engineOnBtn.Location = new System.Drawing.Point(12, 190);
            this.engineOnBtn.Name = "engineOnBtn";
            this.engineOnBtn.Size = new System.Drawing.Size(100, 75);
            this.engineOnBtn.TabIndex = 0;
            this.engineOnBtn.Text = "Engine On";
            this.engineOnBtn.UseVisualStyleBackColor = true;
            this.engineOnBtn.Click += new System.EventHandler(this.engineOnBtn_Click);
            // 
            // engineOffBtn
            // 
            this.engineOffBtn.Location = new System.Drawing.Point(118, 190);
            this.engineOffBtn.Name = "engineOffBtn";
            this.engineOffBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.engineOffBtn.Size = new System.Drawing.Size(100, 75);
            this.engineOffBtn.TabIndex = 1;
            this.engineOffBtn.Text = "Engine Off";
            this.engineOffBtn.UseVisualStyleBackColor = true;
            this.engineOffBtn.Click += new System.EventHandler(this.engineOffBtn_Click);
            // 
            // carStopBtn
            // 
            this.carStopBtn.Location = new System.Drawing.Point(224, 190);
            this.carStopBtn.Name = "carStopBtn";
            this.carStopBtn.Size = new System.Drawing.Size(100, 75);
            this.carStopBtn.TabIndex = 2;
            this.carStopBtn.Text = "Stop Car";
            this.carStopBtn.UseVisualStyleBackColor = true;
            this.carStopBtn.Click += new System.EventHandler(this.carStopBtn_Click);
            // 
            // accelerationBtn
            // 
            this.accelerationBtn.Location = new System.Drawing.Point(330, 190);
            this.accelerationBtn.Name = "accelerationBtn";
            this.accelerationBtn.Size = new System.Drawing.Size(100, 75);
            this.accelerationBtn.TabIndex = 3;
            this.accelerationBtn.Text = "Acceleration";
            this.accelerationBtn.UseVisualStyleBackColor = true;
            this.accelerationBtn.Click += new System.EventHandler(this.accelerationBtn_Click);
            // 
            // releasingBtn
            // 
            this.releasingBtn.Location = new System.Drawing.Point(436, 190);
            this.releasingBtn.Name = "releasingBtn";
            this.releasingBtn.Size = new System.Drawing.Size(100, 75);
            this.releasingBtn.TabIndex = 4;
            this.releasingBtn.Text = "Releasing";
            this.releasingBtn.UseVisualStyleBackColor = true;
            this.releasingBtn.Click += new System.EventHandler(this.releasingBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(12, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(35, 13);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "label1";
            // 
            // velocityLbl
            // 
            this.velocityLbl.AutoSize = true;
            this.velocityLbl.Location = new System.Drawing.Point(11, 39);
            this.velocityLbl.Name = "velocityLbl";
            this.velocityLbl.Size = new System.Drawing.Size(35, 13);
            this.velocityLbl.TabIndex = 6;
            this.velocityLbl.Text = "label2";
            // 
            // petrolLbl
            // 
            this.petrolLbl.AutoSize = true;
            this.petrolLbl.Location = new System.Drawing.Point(12, 66);
            this.petrolLbl.Name = "petrolLbl";
            this.petrolLbl.Size = new System.Drawing.Size(35, 13);
            this.petrolLbl.TabIndex = 7;
            this.petrolLbl.Text = "label3";
            // 
            // carStatusLbl
            // 
            this.carStatusLbl.AutoSize = true;
            this.carStatusLbl.Location = new System.Drawing.Point(11, 96);
            this.carStatusLbl.Name = "carStatusLbl";
            this.carStatusLbl.Size = new System.Drawing.Size(35, 13);
            this.carStatusLbl.TabIndex = 8;
            this.carStatusLbl.Text = "label4";
            // 
            // engineDMGLbl
            // 
            this.engineDMGLbl.AutoSize = true;
            this.engineDMGLbl.Location = new System.Drawing.Point(11, 124);
            this.engineDMGLbl.Name = "engineDMGLbl";
            this.engineDMGLbl.Size = new System.Drawing.Size(35, 13);
            this.engineDMGLbl.TabIndex = 9;
            this.engineDMGLbl.Text = "label5";
            // 
            // drivingDistanceLbl
            // 
            this.drivingDistanceLbl.AutoSize = true;
            this.drivingDistanceLbl.Location = new System.Drawing.Point(11, 152);
            this.drivingDistanceLbl.Name = "drivingDistanceLbl";
            this.drivingDistanceLbl.Size = new System.Drawing.Size(35, 13);
            this.drivingDistanceLbl.TabIndex = 10;
            this.drivingDistanceLbl.Text = "label5";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // constSpeedBtn
            // 
            this.constSpeedBtn.Location = new System.Drawing.Point(542, 190);
            this.constSpeedBtn.Name = "constSpeedBtn";
            this.constSpeedBtn.Size = new System.Drawing.Size(100, 75);
            this.constSpeedBtn.TabIndex = 11;
            this.constSpeedBtn.Text = "Constant Speed";
            this.constSpeedBtn.UseVisualStyleBackColor = true;
            this.constSpeedBtn.Click += new System.EventHandler(this.constSpeedBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 300);
            this.Controls.Add(this.constSpeedBtn);
            this.Controls.Add(this.drivingDistanceLbl);
            this.Controls.Add(this.engineDMGLbl);
            this.Controls.Add(this.carStatusLbl);
            this.Controls.Add(this.petrolLbl);
            this.Controls.Add(this.velocityLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.releasingBtn);
            this.Controls.Add(this.accelerationBtn);
            this.Controls.Add(this.carStopBtn);
            this.Controls.Add(this.engineOffBtn);
            this.Controls.Add(this.engineOnBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Samochód";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button engineOnBtn;
        private System.Windows.Forms.Button engineOffBtn;
        private System.Windows.Forms.Button carStopBtn;
        private System.Windows.Forms.Button accelerationBtn;
        private System.Windows.Forms.Button releasingBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label velocityLbl;
        private System.Windows.Forms.Label petrolLbl;
        private System.Windows.Forms.Label carStatusLbl;
        private System.Windows.Forms.Label engineDMGLbl;
        private System.Windows.Forms.Label drivingDistanceLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button constSpeedBtn;
    }
}


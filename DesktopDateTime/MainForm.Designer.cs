namespace DesktopDateTime
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTime = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.colorDialogForm = new System.Windows.Forms.ColorDialog();
            this.btnFormColor = new System.Windows.Forms.Button();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.lblDay = new System.Windows.Forms.Label();
            this.chbOnTop = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTime.Location = new System.Drawing.Point(2, 2);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(300, 30);
            this.lblTime.TabIndex = 0;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Tick += new System.EventHandler(this.TimerDateTime_Tick);
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDate.Location = new System.Drawing.Point(2, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(300, 30);
            this.lblDate.TabIndex = 1;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorDialogForm
            // 
            this.colorDialogForm.Color = System.Drawing.Color.White;
            // 
            // btnFormColor
            // 
            this.btnFormColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormColor.Location = new System.Drawing.Point(2, 99);
            this.btnFormColor.Name = "btnFormColor";
            this.btnFormColor.Size = new System.Drawing.Size(94, 23);
            this.btnFormColor.TabIndex = 2;
            this.btnFormColor.Text = "Цвет фона";
            this.btnFormColor.UseVisualStyleBackColor = true;
            this.btnFormColor.Click += new System.EventHandler(this.BtnFormColor_Click);
            // 
            // btnFontColor
            // 
            this.btnFontColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFontColor.Location = new System.Drawing.Point(208, 99);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(94, 23);
            this.btnFontColor.TabIndex = 3;
            this.btnFontColor.Text = "Цвет шрифта";
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.BtnFontColor_Click);
            // 
            // lblDay
            // 
            this.lblDay.BackColor = System.Drawing.SystemColors.Control;
            this.lblDay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDay.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDay.Location = new System.Drawing.Point(2, 66);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(300, 30);
            this.lblDay.TabIndex = 4;
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbOnTop
            // 
            this.chbOnTop.AutoSize = true;
            this.chbOnTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbOnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbOnTop.Location = new System.Drawing.Point(102, 103);
            this.chbOnTop.Name = "chbOnTop";
            this.chbOnTop.Size = new System.Drawing.Size(103, 17);
            this.chbOnTop.TabIndex = 5;
            this.chbOnTop.Text = "OnTop ON/OFF";
            this.chbOnTop.UseVisualStyleBackColor = true;
            this.chbOnTop.CheckStateChanged += new System.EventHandler(this.ChangeOnTop);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 125);
            this.Controls.Add(this.chbOnTop);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.btnFontColor);
            this.Controls.Add(this.btnFormColor);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ColorDialog colorDialogForm;
        private System.Windows.Forms.Button btnFormColor;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.CheckBox chbOnTop;
    }
}


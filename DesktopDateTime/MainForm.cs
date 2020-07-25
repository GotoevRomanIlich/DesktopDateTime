using System;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace DesktopDateTime
{
    public partial class MainForm : Form
    {
        private readonly string VERSION = "ver. 1.2.3";        

        DateTime dateTime = new DateTime();

        public MainForm()
        {            
            InitializeComponent();
      
            this.BackColor = Color.WhiteSmoke;            
            this.Text = "Дата и время ОС   " + VERSION;
            
            timerDateTime.Enabled = true;
            
            lblTime.BackColor = Color.Transparent;            
            lblDate.BackColor = Color.Transparent;
            lblDay.BackColor = Color.Transparent;
            chbOnTop.BackColor = Color.Transparent;            
            FocusOnLabel();

            colorDialogForm.FullOpen = true;
            colorDialogForm.Color = this.BackColor;            
        }

        private void TimerDateTime_Tick(object sender, EventArgs e)
        {            
            dateTime = DateTime.Now;
            lblTime.Text = dateTime.ToString("HH : mm : ss");
            lblDate.Text = dateTime.ToString("d MMMM | месяц: M | yyyyг.");
            lblDay.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dateTime.ToString("dddd"));
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerDateTime.Enabled = false;
            GC.Collect();
        }

        public void FocusOnLabel()
        {
            lblDate.Select();
        }

        public void SetColor()
        {
            if (colorDialogForm.ShowDialog() == DialogResult.Cancel) return;
            FocusOnLabel();
        }

        private void BtnFormColor_Click(object sender, EventArgs e)
        {
            SetColor();
            this.BackColor = colorDialogForm.Color;            
        }

        private void BtnFontColor_Click(object sender, EventArgs e)
        {
            SetColor();
            lblDate.ForeColor = colorDialogForm.Color;
            lblTime.ForeColor = colorDialogForm.Color;
            lblDay.ForeColor = colorDialogForm.Color;
            btnFontColor.ForeColor = colorDialogForm.Color;
            btnFormColor.ForeColor = colorDialogForm.Color;
            chbOnTop.ForeColor = colorDialogForm.Color;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDate.Font = new Font(familyName: "Arial", 12, FontStyle.Bold);
            PrivateFontCollection pfc = new PrivateFontCollection();
            try
            {
                pfc.AddFontFile(@"font_for_time.ttf");
                lblTime.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
            }
            catch (Exception)
            {
                lblTime.Font = new Font(familyName: "Arial Rounded MT Bold", 18, FontStyle.Regular);                
            }            
            pfc.Dispose();
        }

        private void ChangeOnTop(object sender, EventArgs e)
        {
            if (chbOnTop.Checked == true) this.TopMost = true;
                else this.TopMost = false;            
        }
    }
}

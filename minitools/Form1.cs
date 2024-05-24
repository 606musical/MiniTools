using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace Minitools
{
    public partial class Form1 : Form
    {
        Point mousePoint;
        int[]? ccr;
        string fix4 = "";
        int fbpc, vu, fml, fmt, fmw, fmh, d2l, fmm, w11f, sss, ts05f, nResult;
        Color fcC = Color.FromArgb(200, 200, 200);
        Color bcC = Color.FromArgb(90, 90, 90);
        Color fcD = Color.FromArgb(30, 30, 30);
        Color bcD = Color.FromArgb(240, 240, 240);
        Bitmap mBm = new Bitmap(1, 1);
        DWM_WINDOW_CORNER_PREFERENCE DWMWCP_DONOTROUND;
        DWM_WINDOW_CORNER_PREFERENCE DWMWCP_ROUND;

        public Form1()
        {
            InitializeComponent();
            try
            {
                var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
                var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
                DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));
            }
            catch
            {
                w11f = 1;
                ts043.Visible = false;
            }
            this.TransparencyKey = Color.Magenta;
        }
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            const int WM_NCRBUTTONDOWN = 0xa4;
            const int WM_NCLBUTTONDBLCLK = 0xA3;
            if (m.Msg == WM_NCRBUTTONDOWN)
            {
                var pos = new Point(m.LParam.ToInt32());
                contextMenuStrip1.Show(pos);
                return;
            }
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                fml = this.Left;
                fmt = this.Top;
                fmw = this.Width;
                fmh = this.Height;
                this.WindowState = FormWindowState.Minimized;
                return;
            }
            base.WndProc(ref m);
        }
        const int WM_USER = 0x400;
        const int PBM_SETSTATE = WM_USER + 16;
        const int PBM_GETSTATE = WM_USER + 17;
        [DllImport("user32.dll", SetLastError = false)]
        public static extern bool SystemParametersInfo(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);
        const uint SPI_SETACTIVEWNDTRKTIMEOUT = 0x2003;
        const uint SPI_SETACTIVEWINDOWTRACKING = 0x1001;
        const uint SPI_SETACTIVEWNDTRKZORDER = 0x100D;
        const uint SPIF_UPDATEINIFILE = 1;
        const uint SPIF_SENDCHANGE = 2;
        public enum DWM_WINDOW_CORNER_PREFERENCE
        {
            DWMWCP_DEFAULT = 0, DWMWCP_DONOTROUND = 1, DWMWCP_ROUND = 2, DWMWCP_ROUNDSMALL = 3
        }
        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        internal static extern void DwmSetWindowAttribute(IntPtr hwnd,
        DWMWINDOWATTRIBUTE attribute, ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute, uint cbAttribute);
        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string sKeyName = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            string sSubkeyName = "SystemUsesLightTheme";
            RegistryKey? r2Key = Registry.CurrentUser.OpenSubKey(sKeyName);
            if (r2Key != null)
            {
                var testX = (int?)r2Key.GetValue(sSubkeyName);
                if (testX != null) { nResult = (int)testX; }
                r2Key.Close();
            }
            string rKN = @"Control Panel\Desktop";
            string rGVN = "ActiveWndTrkTimeout";
            string rGVN2 = "UserPreferencesMask";
            RegistryKey? rKey = Registry.CurrentUser.OpenSubKey(rKN);
            RegistryKey? rKe2 = Registry.CurrentUser.OpenSubKey(rKN);
            if (rKey != null)
            {
                object? locatio1 = rKey.GetValue(rGVN);
                if (locatio1 != null) { ts51.Text = locatio1.ToString(); }
                rKey.Close();
            }
            if (rKe2 != null)
            {
                System.Byte[] locatio2 = (byte[])rKe2.GetValue(rGVN2, "Bytes");
                string tkg = BitConverter.ToString(locatio2).Substring(0, 2);
                if (tkg == "DF" || tkg == "DE" || tkg == "D9" || tkg == "D1")
                {
                    ts53.Enabled = false;
                    ts54.Enabled = true;
                    ts53.Text = "ONになっています";
                    ts54.Text = "OFF";
                }
                if (tkg == "9F" || tkg == "9E" || tkg == "98" || tkg == "90")
                {
                    ts54.Enabled = false;
                    ts53.Enabled = true;
                    ts53.Text = "ON";
                    ts54.Text = "OFFになっています";
                }
                rKe2.Close();
            }
            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
            progressBar2.Value = (int)subR.Volume.GetMasterVolume();
            label17.Text = subR.Volume.GetMasterVolume().ToString();
            SLD();
            Resetvisual();
            var menu = (ToolStripDropDownMenu)ts4.DropDown;
            menu.ShowImageMargin = false; menu.ShowCheckMargin = false;
            menu = (ToolStripDropDownMenu)ts5.DropDown;
            menu.ShowImageMargin = false; menu.ShowCheckMargin = false;
            menu = (ToolStripDropDownMenu)ts0.DropDown;
            menu.ShowImageMargin = false; menu.ShowCheckMargin = false;
            menu = (ToolStripDropDownMenu)ts03.DropDown;
            menu.ShowImageMargin = false; menu.ShowCheckMargin = false;
            menu = (ToolStripDropDownMenu)ts04.DropDown;
            menu.ShowImageMargin = false; menu.ShowCheckMargin = false;
        }
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                mousePoint = new Point(e.X, e.Y);
            }
        }
        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            if (ts05f == 1)
            {
                this.TransparencyKey = this.BackColor;
            }
        }
        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            label17.Text = vu.ToString();

            if (ts05f == 1)
            {
                this.TransparencyKey = Color.Magenta;
            }
            if (fmm == 0)
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    this.Left += e.X - mousePoint.X;
                    this.Top += e.Y - mousePoint.Y;
                }
            }
        }
        private void Form1_MouseWheel(object? sender, MouseEventArgs e)
        {
            progressBar2.Visible = true;
            label17.Text = vu.ToString();
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.Delta == 120)
            {
                if (vu < 100) { vu = vu + 1; }
                if (vu > 100) { vu = 100; }
            }
            else
            {
                if (e.Delta == 120)
                {
                    if (vu < 100) { vu = vu + 10; }
                    if (vu > 100) { vu = 100; }
                }
            }
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.Delta == -120)
            {
                if (vu > 0) { vu = vu - 1; }
                if (vu < 0) { vu = 0; }
            }
            else
            {
                if (e.Delta == -120)
                {
                    if (vu > 0) { vu = vu - 10; }
                    if (vu < 0) { vu = 0; }
                }
            }
            try
            {
                subR.Volume.SetMasterVolume((float)vu);
            }
            catch { }

            Vuc();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            progressBar2.Visible = true;
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            progressBar2.Visible = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //sclock.Properties.Settings.Default.Save();
        }
        private void Label1_DoubleClick(object sender, EventArgs e)
        {
            fbpc ^= 1;
            if (fbpc == 1)
            {
                this.Height = 57;
                timer5.Enabled = true;
            }
            if (fbpc == 0)
            {
                this.Height = 28;
                timer5.Enabled = false;
            }
        }
        private void mtsmic(object sender, EventArgs e)
        {
            fml = this.Left;
            fmt = this.Top;
            fmw = this.Width;
            fmh = this.Height;
            this.WindowState = FormWindowState.Minimized;
        }
        private void ts14_Click(object sender, EventArgs e)
        {
            this.TransparencyKey = this.BackColor;
        }
        private void ts70_Click(object sender, EventArgs e)
        {
            timer4.Interval = 60000;
            timer4.Enabled = true;
        }
        private void ts71_Click(object sender, EventArgs e)
        {
            timer4.Interval = 180000;
            timer4.Enabled = true;
        }
        private void ts90_Click(object sender, EventArgs e)
        {
            if (w11f == 0)
            {
                DwmSetWindowAttribute(this.Handle, DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE, ref DWMWCP_DONOTROUND, sizeof(int));
            }
            sss = 0;
        }
        private void ts91_Click(object sender, EventArgs e)
        {
            if (w11f == 0)
            {
                DwmSetWindowAttribute(this.Handle, DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE, ref DWMWCP_DONOTROUND, sizeof(int));
            }
            label17.Parent = this;
            label18.Parent = this;
            sss = 1;
        }
        private void ts92_Click(object sender, EventArgs e)
        {
            DWMWCP_ROUND = (DWM_WINDOW_CORNER_PREFERENCE)2;
            DwmSetWindowAttribute(this.Handle, DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE, ref DWMWCP_ROUND, sizeof(int));
            label9.Parent = this;
            label17.Parent = this;
            label18.Parent = this;
            sss = 1;
        }
        private void tsmic6(object sender, EventArgs e)
        {
            //Process.Start("shell:ControlPanelFolder");
            var start = new ProcessStartInfo("shell:ControlPanelFolder");
            start.UseShellExecute = true;
            Process.Start(start);
        }
        private void tsmic7(object sender, EventArgs e)
        {
            Process.Start("explorer");
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fmm ^= 1;
            if (fmm == 0)
            {
                ts6.Text = "位置固定を開始";
            }
            else
            {
                ts6.Text = "位置固定中です";
            }
        }
        private void ts62_Click(object sender, EventArgs e)
        {
            Font fd = new Font("MS UI Gothic", 12, FontStyle.Bold);
            label9.Font = fd;
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.Font = fd;
            label11.ForeColor = Color.Black;
            label17.ForeColor = Color.Black;
        }
        private void otsmic(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETACTIVEWINDOWTRACKING, 0, (IntPtr)1, SPIF_SENDCHANGE | SPIF_UPDATEINIFILE);
            SystemParametersInfo(SPI_SETACTIVEWNDTRKZORDER, 0, (IntPtr)1, SPIF_SENDCHANGE | SPIF_UPDATEINIFILE);
            ts53.Enabled = false;
            ts54.Enabled = true;
            ts53.Text = "現在 ON";
            ts54.Text = "OFF";
        }
        private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            fbpc++;
            if (fbpc == 1)
            {
                this.Height = 230;
            }
            else
            {
                this.Height = 28;
            }
            if (fbpc >= 2) { fbpc = 0; }
        }
        private void ToolStripMenuItem11_Click_1(object sender, EventArgs e)
        {
            fml = this.Left;
            fmt = this.Top;
            fmw = this.Width;
            fmh = this.Height;
            this.WindowState = FormWindowState.Minimized;
        }
        private void ToolStripMenuItem7_MouseLeave(object sender, EventArgs e)
        {
            string? hbg2 = ((ToolStripMenuItem)sender).Name;
            if (nResult == 0)
            {
                if (hbg2 != null) { ((ToolStripMenuItem)sender).ForeColor = fcC; }
            }
            else
            {
                if (hbg2 != null) { ((ToolStripMenuItem)sender).ForeColor = fcD; }
            }
        }
        private void ToolStripMenuItem7_MouseEnter_1(object sender, EventArgs e)
        {
            string? hbg2 = ((ToolStripMenuItem)sender).Name;
            if (nResult == 0)
            {
                if (hbg2 != null) { ((ToolStripMenuItem)sender).ForeColor = Color.Black; }
            }
            else
            {
                if (hbg2 != null) { ((ToolStripMenuItem)sender).ForeColor = fcD; }
            }
        }
        private void oftsmic(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETACTIVEWINDOWTRACKING, 0, IntPtr.Zero, SPIF_SENDCHANGE | SPIF_UPDATEINIFILE);
            SystemParametersInfo(SPI_SETACTIVEWNDTRKZORDER, 0, IntPtr.Zero, SPIF_SENDCHANGE | SPIF_UPDATEINIFILE);
            ts54.Enabled = false;
            ts53.Enabled = true;
            ts53.Text = "ON";
            ts54.Text = "現在 OFF";
        }
        private void ToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETACTIVEWNDTRKTIMEOUT, 0, (IntPtr)int.Parse(ts51.Text), SPIF_SENDCHANGE | SPIF_UPDATEINIFILE);
        }
        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Hide();
        }
        private void ctsmic(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.CustomColors = ccr;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                Color color = cd.Color;
                label9.ForeColor = color;
                label10.ForeColor = color;
                label11.ForeColor = color;
                label17.ForeColor = color;
                ccr = cd.CustomColors;
            }
        }
        private void ts52_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETACTIVEWINDOWTRACKING, 0, (IntPtr)1, SPIF_SENDCHANGE | SPIF_UPDATEINIFILE);
            SystemParametersInfo(SPI_SETACTIVEWNDTRKZORDER, 0, (IntPtr)1, SPIF_SENDCHANGE | SPIF_UPDATEINIFILE);
            ts53.Enabled = false;
            ts54.Enabled = true;
            ts53.Text = "ONの状態です";
            ts54.Text = "OFF";
        }
        private void ts53_Click(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETACTIVEWINDOWTRACKING, 0, IntPtr.Zero, SPIF_SENDCHANGE | SPIF_UPDATEINIFILE);
            SystemParametersInfo(SPI_SETACTIVEWNDTRKZORDER, 0, IntPtr.Zero, SPIF_SENDCHANGE | SPIF_UPDATEINIFILE);
            ts54.Enabled = false;
            ts53.Enabled = true;
            ts53.Text = "ON";
            ts54.Text = "OFFの状態です";
        }
        private void ts17A_Click(object sender, EventArgs e)
        {
            fmm ^= 1;
            if (fmm == 0)
            {
                ts6.Text = "位置固定を開始";
            }
            else
            {
                ts6.Text = "位置固定中です";
            }
        }
        private void ts901_Click(object sender, EventArgs e)
        {
            if (w11f == 0)
            {
                DwmSetWindowAttribute(this.Handle, DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE, ref DWMWCP_DONOTROUND, sizeof(int));
            }
            sss = 0;
        }
        private void ts912_Click(object sender, EventArgs e)
        {
            if (w11f == 0)
            {
                DwmSetWindowAttribute(this.Handle, DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE, ref DWMWCP_DONOTROUND, sizeof(int));
            }
            label17.Parent = this;
            label18.Parent = this;
            sss = 1;
        }
        private void ts922_Click(object sender, EventArgs e)
        {
            DWMWCP_ROUND = (DWM_WINDOW_CORNER_PREFERENCE)2;
            DwmSetWindowAttribute(this.Handle, DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE, ref DWMWCP_ROUND, sizeof(int));
            label9.Parent = this;
            label17.Parent = this;
            label18.Parent = this;
            sss = 1;
        }
        private void ts932_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowApply = true;
            fd.ShowColor = true;
            fd.Apply += new EventHandler(ApplyFont);
            if (fd.ShowDialog() != DialogResult.Cancel) { ChangeFont(fd); }
        }
        private void ts933_Click(object? sender, EventArgs e)
        {
            Font fd = new Font("MS UI Gothic", 12, FontStyle.Bold);
            label9.Font = fd;
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.Font = fd;
            label11.ForeColor = Color.Black;
            label17.ForeColor = Color.Black;
        }
        private void ts02_Click(object sender, EventArgs e)
        {
            nResult = 1;
            SLD();
        }
        private void ts05_Click(object sender, EventArgs e)
        {
            this.TransparencyKey = this.BackColor;
            ts05f = 1;
        }
        private void ts06_Click(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Magenta;
            ts05f = 0;
        }
        private void tsmicC(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsmicH(object sender, EventArgs e)
        {
            Font fd = new Font("MS UI Gothic", 12, FontStyle.Bold);
            label9.Font = fd;
            label9.ForeColor = Color.Black;
            label10.Font = new Font("MS UI Gothic", 9, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label11.Font = fd;
            label11.ForeColor = Color.Black;
        }
        private void ts18_Click(object sender, EventArgs e)
        {
            nResult = 0;
            SLD();
        }
        private void ts19_Click(object sender, EventArgs e)
        {
            nResult = 1;
            SLD();
        }
        private void ts15_Click(object sender, EventArgs e)
        {
            clearstop();
            d2l = 0;
            SLD();
            Resetvisual();
        }
        private void Vuc()
        {
            //label17.Text = "";
            if (vu == 100)
            {
                label17.Location = new Point(149, 8);
            }
            else if (vu < 10)
            {
                label17.Location = new Point(163, 8);
            }
            else if (label17.Left != 157)
            {
                label17.Location = new Point(157, 8);
            }
            progressBar2.Value = vu;
        }
        private void Resetvisual()
        {
            this.Width = 188; this.Height = 28;
            this.TransparencyKey = Color.Magenta;
            if (sss == 0)
            {

            }
            else
            {

                label9.Parent = this;
                label17.Parent = this;
            }
            label9.Location = new Point(6, 5);
            label9.Font = new Font("MS UI Gothic", 12, FontStyle.Bold);
            label10.Location = new Point(61, 8);
            label10.Font = new Font("MS UI Gothic", 9);
            label11.Location = new Point(82, 5);
            label11.Font = new Font("MS UI Gothic", 12, FontStyle.Bold);
            ts05.Enabled = true;
            ts3.Enabled = true;
        }
        private void ApplyFont(object? fd, EventArgs e)
        {
            if (fd != null) { ChangeFont((FontDialog)fd); }
        }
        private void ChangeFont(FontDialog fd)
        {
            label9.Font = fd.Font;
            label9.ForeColor = fd.Color;
            label10.ForeColor = fd.Color;
            label11.Font = fd.Font;
            label11.ForeColor = fd.Color;
            label17.ForeColor = fd.Color;
        }
        private void clearstop()
        {
            this.label9.Font = new Font("MS UI Gothic", 12, FontStyle.Bold);
            label10.Location = new Point(115, 8);
            label10.Font = new Font("MS UI Gothic", 9);
            label11.Location = new Point(146, 3);
            label11.Font = new Font("MS UI Gothic", 12, FontStyle.Bold);
        }
        private void SLD()
        {
            if (w11f == 1)
            {
                label9.Parent = this;
                label17.Parent = this;
            }
            if (nResult == 0)
            {
                fcC = Color.FromArgb(200, 200, 200);
                bcC = Color.FromArgb(90, 90, 90);
                this.ForeColor = fcC;
                label9.ForeColor = fcC;
                label10.ForeColor = fcC;
                label11.ForeColor = fcC;
                label17.ForeColor = fcC;
                ts1.ForeColor = fcC;
                ts2.ForeColor = fcC;
                ts3.ForeColor = fcC;
                ts4.ForeColor = fcC;
                ts5.ForeColor = fcC;
                ts6.ForeColor = fcC;
                ts7.ForeColor = fcC;
                ts8.ForeColor = fcC;
                ts9.ForeColor = fcC;
                ts0.ForeColor = fcC;
                ts01.ForeColor = fcC;
                ts02.ForeColor = fcC;
                ts03.ForeColor = fcC;
                ts04.ForeColor = fcC;
                ts05.ForeColor = fcC;
                ts06.ForeColor = fcC;
                ts41.ForeColor = fcC;
                ts42.ForeColor = fcC;
                ts51.ForeColor = fcC;
                ts52.ForeColor = fcC;
                ts53.ForeColor = fcC;
                ts54.ForeColor = fcC;
                ts031.ForeColor = fcC;
                ts032.ForeColor = fcC;
                ts033.ForeColor = fcC;
                ts041.ForeColor = fcC;
                ts042.ForeColor = fcC;
                ts043.ForeColor = fcC;
                ts4.DropDown.ForeColor = fcC;
                ts5.DropDown.ForeColor = fcC;
                ts0.DropDown.ForeColor = fcC;
                ts03.DropDown.ForeColor = fcC;
                ts04.DropDown.ForeColor = fcC;

                this.BackColor = bcC;
                if (d2l == 1)
                {
                    this.TransparencyKey = this.BackColor;
                }
                label9.BackColor = bcC;
                label10.BackColor = bcC;
                label11.BackColor = bcC;
                label17.BackColor = bcC;
                contextMenuStrip1.BackColor = bcC;
                ts0.DropDown.BackColor = bcC;
                ts4.DropDown.BackColor = bcC;
                ts5.DropDown.BackColor = bcC;
                ts0.DropDown.BackColor = bcC;
                ts03.DropDown.BackColor = bcC;
                ts04.DropDown.BackColor = bcC;

                ts1.BackColor = bcC;
                ts2.BackColor = bcC;
                ts3.BackColor = bcC;
                ts4.BackColor = bcC;
                ts5.BackColor = bcC;
                ts6.BackColor = bcC;
                ts7.BackColor = bcC;
                ts8.BackColor = bcC;
                ts9.BackColor = bcC;
                ts0.BackColor = bcC;
                ts01.BackColor = bcC;
                ts02.BackColor = bcC;
                ts03.BackColor = bcC;
                ts04.BackColor = bcC;
                ts05.BackColor = bcC;
                ts06.BackColor = bcC;
                ts41.BackColor = bcC;
                ts42.BackColor = bcC;
                ts51.BackColor = bcC;
                ts52.BackColor = bcC;
                ts53.BackColor = bcC;
                ts54.BackColor = bcC;
                ts031.BackColor = bcC;
                ts032.BackColor = bcC;
                ts033.BackColor = bcC;
                ts041.BackColor = bcC;
                ts042.BackColor = bcC;
                ts043.BackColor = bcC;
                bcC = Color.FromArgb(100, 100, 100);
            }
            else
            {
                fcD = Color.FromArgb(30, 30, 30);
                bcD = Color.FromArgb(240, 240, 240);
                this.ForeColor = fcD;
                this.Refresh();
                label9.ForeColor = fcD;
                label10.ForeColor = fcD;
                label11.ForeColor = fcD;
                label17.ForeColor = fcD;
                ts1.ForeColor = fcD;
                ts2.ForeColor = fcD;
                ts3.ForeColor = fcD;
                ts4.ForeColor = fcD;
                ts5.ForeColor = fcD;
                ts6.ForeColor = fcD;
                ts7.ForeColor = fcD;
                ts8.ForeColor = fcD;
                ts9.ForeColor = fcD;
                ts0.ForeColor = fcD;
                ts01.ForeColor = fcD;
                ts02.ForeColor = fcD;
                ts03.ForeColor = fcD;
                ts04.ForeColor = fcD;
                ts05.ForeColor = fcD;
                ts06.ForeColor = fcD;
                ts41.ForeColor = fcD;
                ts42.ForeColor = fcD;
                ts51.ForeColor = fcD;
                ts52.ForeColor = fcD;
                ts53.ForeColor = fcD;
                ts54.ForeColor = fcD;
                ts031.ForeColor = fcD;
                ts032.ForeColor = fcD;
                ts033.ForeColor = fcD;
                ts041.ForeColor = fcD;
                ts042.ForeColor = fcD;
                ts043.ForeColor = fcD;
                ts4.DropDown.ForeColor = fcD;
                ts5.DropDown.ForeColor = fcD;
                ts0.DropDown.ForeColor = fcD;
                ts03.DropDown.ForeColor = fcD;
                ts04.DropDown.ForeColor = fcD;
                if (d2l == 1)
                {
                    this.TransparencyKey = this.BackColor;
                }
                label9.BackColor = bcD;
                label10.BackColor = bcD;
                label11.BackColor = bcD;
                label17.BackColor = bcD;
                ts1.BackColor = bcD;
                ts2.BackColor = bcD;
                ts3.BackColor = bcD;
                ts4.BackColor = bcD;
                ts5.BackColor = bcD;
                ts6.BackColor = bcD;
                ts7.BackColor = bcD;
                ts8.BackColor = bcD;
                ts9.BackColor = bcD;
                ts0.BackColor = bcD;
                ts01.BackColor = bcD;
                ts02.BackColor = bcD;
                ts03.BackColor = bcD;
                ts04.BackColor = bcD;
                ts05.BackColor = bcD;
                ts06.BackColor = bcD;
                ts41.BackColor = bcD;
                ts42.BackColor = bcD;
                ts51.BackColor = bcD;
                ts52.BackColor = bcD;
                ts53.BackColor = bcD;
                ts54.BackColor = bcD;
                ts031.BackColor = bcD;
                ts032.BackColor = bcD;
                ts033.BackColor = bcD;
                ts041.BackColor = bcD;
                ts042.BackColor = bcD;
                ts043.BackColor = bcD;
                this.BackColor = bcD;
                contextMenuStrip1.BackColor = bcD;
                ts0.DropDown.BackColor = bcD;
                ts4.DropDown.BackColor = bcD;
                ts5.DropDown.BackColor = bcD;
                ts0.DropDown.BackColor = bcD;
                ts03.DropDown.BackColor = bcD;
                ts04.DropDown.BackColor = bcD;
                bcD = Color.FromArgb(250, 250, 250);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            vu = (int)subR.Volume.GetMasterVolume();
            Vuc();
            DateTime now = DateTime.Now;
            if (fix4 != null)
            {
                this.Text = "test";
            }
            label9.Text = now.ToString("MM/dd");
            label10.Text = now.ToString("ddd");
            label11.Text = now.ToString("HH:mm:ss");

        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            try
            {
                int XI = System.Windows.Forms.Cursor.Position.X;
                int YI = System.Windows.Forms.Cursor.Position.Y;
                Graphics gI = Graphics.FromImage(mBm);
                gI.CopyFromScreen(new Point(XI, YI), new Point(0, 0), new Size(1, 1));
                Color cr = mBm.GetPixel(0, 0);
                byte r = cr.R;
                byte g = cr.G;
                byte b = cr.B;

                label18.Text = "r" + " " + $"{r.ToString(),3:d}" + " " +
                               "g" + " " + $"{g.ToString(),3:d}" + " " +
                               "b" + " " + $"{b.ToString(),3:d}" + " " +
                               "h" + " " + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
                pictureBox1.BackColor = cr;
                gI.Dispose();
            }
            catch
            {

            }

        }
        private void Timer4_Tick(object sender, EventArgs e)
        {
            timer4.Enabled = false;
            subR.Monitor.PowerOff();
            contextMenuStrip1.Show();
        }

    }
}


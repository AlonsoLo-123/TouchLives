using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchLives.BarraSup
{
    class BarSup
    {
        int MX, MY;
        bool MD = false;
        public void MinForm(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }
        public void MaxForm(Form form)
        {
            if (form.WindowState == FormWindowState.Maximized)
                form.WindowState = FormWindowState.Normal;
            else
                form.WindowState = FormWindowState.Maximized;
        }
        public void CloseForm()
        {
            Application.Exit();
        }
        public void MDown(int x, int y)
        {
            MD = true;
            MX = x;
            MY = y;
        }
        public void MMove(Form form, int x, int y)
        {
            if (MD)
                form.SetDesktopLocation(x - MX, y - MY);
        }
        public void MUp()
        {
            MD = false;
        }
    }
}

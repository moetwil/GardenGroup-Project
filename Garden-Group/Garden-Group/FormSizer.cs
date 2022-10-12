using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Group
{
    static public class FormSizer
    {
        static public void SetSizeToDesktop(this Form form)
        {
            int left = SystemInformation.WorkingArea.Left;
            int top = SystemInformation.WorkingArea.Top;
            int width = SystemInformation.WorkingArea.Width;
            int height = SystemInformation.WorkingArea.Height;
            form.Location = new Point(left, top);
            form.Size = new Size(width, height);
        }
    }
}

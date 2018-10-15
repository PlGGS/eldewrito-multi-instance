using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halo_Online_Multi_Instance
{
    public class HOMIButton : Label
    {
        SectionsManager sectionsManager;
        public SectionsManager SectionsManager { get => sectionsManager; set => sectionsManager = value; }

        public HOMIButton(SectionsManager pSectionsManager)
        {
            sectionsManager = pSectionsManager;

            MouseEnter += new EventHandler(HOMIButton_MouseEnter);
            MouseLeave += new EventHandler(HOMIButton_MouseLeave);
            MouseHover += new EventHandler(HOMIButton_MouseHover);
            MouseClick += new MouseEventHandler(HOMIButton_Click);

            BackColor = HOMIColors.DefaultBackground;
            TextAlign = ContentAlignment.MiddleCenter;
        }

        private void HOMIButton_MouseEnter(object sender, EventArgs e)
        {
            BackColor = HOMIColors.EnterBackground;
        }

        private void HOMIButton_MouseLeave(object sender, EventArgs e)
        {
            BackColor = HOMIColors.DefaultBackground;
        }

        private void HOMIButton_MouseHover(object sender, EventArgs e)
        {
            //TODO tooltips
        }

        private void HOMIButton_Click(object sender, MouseEventArgs e)
        {

        }
    }
}

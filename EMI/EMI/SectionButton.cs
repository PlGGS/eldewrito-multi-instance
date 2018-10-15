using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halo_Online_Multi_Instance
{
    public class SectionButton : HOMIButton
    {
        bool active = false;
        public bool Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;

                if (value == true)
                {
                    if (SectionsManager.ActiveSectionButton != this)
                    {
                        if (subSectionButtons.Count > 0)
                        {
                            subSectionButtons[0].Active = true;

                            foreach (SubSection sub in subSectionButtons[0].SubSections)
                            {
                                sub.Width = sub.PnlContent.Width;
                                sub.Pair.Label.Width = sub.Width - 5;
                                sub.Pair.Panel.Width = sub.Width - 5;
                            }
                        }
                    }

                    if (SectionsManager.ActiveSectionButton != null)
                    {
                        SectionsManager.ActiveSectionButton.Active = false;
                    }
                    SectionsManager.ActiveSectionButton = this;

                    foreach (SubSectionButton subButt in SectionsManager.SubSectionButtons.Values)
                    {
                        if (subButt.ParentSectionButton != null)
                        {
                            subButt.Visible = false;
                        }
                        else
                        {
                            subButt.Location = new Point(subButt.Location.X, subSectionButtons.Count * SectionsManager.SubSectionButtons.Values.ToArray()[0].Height);
                        }
                    }

                    foreach (SubSectionButton subButt in subSectionButtons)
                    {
                        subButt.Visible = true;
                    }
                }
            }
        }

        Panel pnlSections;
        public Panel PnlSections { get => pnlSections; set => pnlSections = value; }

        List<SubSectionButton> subSectionButtons = new List<SubSectionButton>();
        public List<SubSectionButton> SubSectionButtons { get => subSectionButtons; set => subSectionButtons = value; }

        public SectionButton(SectionsManager pSectionsManager, Panel pPnlSections)
            : base(pSectionsManager)
        {
            pnlSections = pPnlSections;

            Size = new Size(143, 57);
            Location = new Point(SectionsManager.SectionButtons.Count * Size.Width, 0);
            MouseClick += new MouseEventHandler(SectionButton_Click);
        }

        private void SectionButton_Click(object sender, MouseEventArgs e)
        {
            Active = true;
            SectionsManager.TranslateVisibleButtons(SectionsManager.BtnExtendSubSections, SectionsManager);
        }
    }
}

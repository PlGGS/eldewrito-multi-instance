using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halo_Online_Multi_Instance
{
    public class SubSectionButton : HOMIButton
    {
        bool active;
        public bool Active { get => active; set
            {
                active = value;

                if (value == true)
                {
                    if (SectionsManager.ActiveSubSectionButton != null)
                    {
                        SectionsManager.ActiveSubSectionButton.Active = false;
                    }
                    SectionsManager.ActiveSubSectionButton = this;
                }
                
                foreach (SubSection sub in subSections)
                {
                    sub.Visible = value;
                }
            }
        }

        SectionButton parentSectionButton;
        public SectionButton ParentSectionButton { get => parentSectionButton; set => parentSectionButton = value; }

        Panel pnlSubSections;
        public Panel PnlSubSections { get => pnlSubSections; set => pnlSubSections = value; }

        List<SubSection> subSections = new List<SubSection>();
        public List<SubSection> SubSections { get => subSections; set => subSections = value; }

        public SubSectionButton(SectionsManager pSectionsManager, Panel pPnlSubSections, string pName, SectionButton pParentSectionButton = null, bool pActive = false)
            : base(pSectionsManager)
        {
            pnlSubSections = pPnlSubSections;
            Name = pName;
            parentSectionButton = pParentSectionButton;
            Active = pActive;
            Size = new Size(56, 52);
            if (ParentSectionButton != null)
            {
                Location = new Point(0, ParentSectionButton.SubSectionButtons.Count * Size.Height);
                Visible = ParentSectionButton.Active;
                Text = Name.Substring(3);
                ParentSectionButton.SubSectionButtons.Add(this);
            }
            else
            {
                Location = new Point(0, 208);
                Text = ">";
                SectionsManager.BtnExtendSubSections = this;
            }
            SectionsManager.SubSectionButtons.Add(Name, this);
            PnlSubSections.Controls.Add(this);
            Click += new EventHandler(SubSectionButton_Click);
        }

        private void SubSectionButton_Click(object sender, EventArgs e)
        {
            if (parentSectionButton != null)
            {
                if (SectionsManager.ActiveSubSectionButton != this)
                {
                    Active = true;
                }
                foreach (SubSection sub in SubSections)
                {
                    Console.WriteLine($"{sub.Name}: - Loc: {sub.Location}, Size: {sub.Size}, Visible: {sub.Visible}");
                }
            }
            else
            {
                //TODO add btnExtendSubSectionButtons handling
            }
        }
    }
}

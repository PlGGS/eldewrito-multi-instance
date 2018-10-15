using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halo_Online_Multi_Instance
{
    public class SubSection : Control
    {
        static int seperations = 5;

        (Label label, Panel panel) pair;
        public (Label Label, Panel Panel) Pair { get => pair; set => pair = value; }

        /// <summary>
        /// Gets or sets location of the subsection option's Label (Lbl)
        /// </summary>
        public Point LabelLocation
        {
            get => pair.label.Location;
            set
            {
                Location = new Point(seperations, Location.Y);
                for (int i = 0; i < parentSubSectionButton.SubSections.Count; i++)
                {
                    Location = new Point(seperations, Location.Y + parentSubSectionButton.SubSections[i].Height + seperations);
                }
                pair.label.Location = value;
                PanelLocation = new Point(value.X, value.Y + pair.label.Height);
            }
        }

        /// <summary>
        /// Gets or sets location of the subsection option's Control (Ctrl) relative to its label (Lbl)
        /// </summary>
        public Point PanelLocation { get => pair.panel.Location; set => pair.panel.Location = value; }

        public Size AllSizes
        {
            get => Size;
            set
            {
                LabelSize = new Size(value.Width - seperations * 4, 20);
                if (SubSectionOptions.Count > 0)
                {
                    PanelSize = new Size(value.Width - seperations * 4, seperations * 4);
                    foreach (SubSectionOption option in SubSectionOptions)
                    {
                        PanelSize += new Size(0, option.Height);
                    }
                }
                else
                {
                    PanelSize = new Size(value.Width - seperations * 4, seperations * 4);
                }
                Size = LabelSize + PanelSize;
            }
        }

        public Size LabelSize { get => pair.label.Size; set => pair.label.Size = value; }

        public Size PanelSize { get => pair.panel.Size; set => pair.panel.Size = value; }

        Panel pnlContent;
        public Panel PnlContent { get => pnlContent; set => pnlContent = value; }

        SectionsManager sectionsManager;
        public SectionsManager SectionsManager { get => sectionsManager; set => sectionsManager = value; }

        SubSectionButton parentSubSectionButton;
        public SubSectionButton ParentSubSectionButton { get => parentSubSectionButton; set => parentSubSectionButton = value; }

        List<SubSectionOption> subSectionOptions = new List<SubSectionOption>();
        public List<SubSectionOption> SubSectionOptions { get => subSectionOptions; set => subSectionOptions = value; }

        public SubSection(SectionsManager pSectionsManager, SubSectionButton pSubSectionButton, Panel pPnlContent, string pName, (Label lbl, Panel pnl) pPair)
        {
            sectionsManager = pSectionsManager;
            parentSubSectionButton = pSubSectionButton;
            pnlContent = pPnlContent;
            Name = pName;
            pair = pPair;
            AllSizes = new Size(pnlContent.Width, pnlContent.Height);
            LabelLocation = new Point(0, 0);
            Location = new Point(Location.X, Location.Y + 5); //TODO figure out why this is necessary
            pair.label.BackColor = HOMIColors.SubSectionTitleBackground;
            pair.label.TextAlign = ContentAlignment.MiddleLeft;
            pair.panel.AutoScroll = true;
            pair.panel.BackColor = HOMIColors.SubSectionBackground;
            Visible = parentSubSectionButton.Active;
            this.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            this.Controls.Add(pair.label);
            this.Controls.Add(pair.panel);
            pnlContent.Controls.Add(this);
            parentSubSectionButton.SubSections.Add(this);
            SectionsManager.SubSections.Add(Name, this);
            SizeChanged += new EventHandler(subSection_SizeChanged);
        }

        private void subSection_SizeChanged(object sender, EventArgs e)
        {
            if (pnlContent.VerticalScroll.Visible)
            {
                Width = pnlContent.Width - seperations * 5;
            }
            else
            {
                Width = pnlContent.Width - seperations;
            }

            PnlContent.HorizontalScroll.Visible = false;
        }
    }
}

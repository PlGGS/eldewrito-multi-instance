using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halo_Online_Multi_Instance
{
    public class SubSectionOption : Control
    {
        static int seperations = 5;

        string fileOptionString;
        public string FileOptionString { get => fileOptionString; set => fileOptionString = value; }

        (Label label, Control control) pair;
        public (Label Label, Control Control) Pair { get => pair; set => pair = value; }
        
        /// <summary>
        /// Gets or sets location of the subsection option's Label (Lbl)
        /// </summary>
        public Point LabelLocation
        {
            get => pair.label.Location;
            set
            {
                Location = new Point(value.X, value.Y + Size.Height * ParentSubSection.SubSectionOptions.Count);
                pair.label.Location = value;
                ControlLocation = new Point(Size.Width - pair.control.Width - seperations*2, value.Y);
            }
        }

        /// <summary>
        /// Gets or sets location of the subsection option's Control (Ctrl) relative to its label (Lbl)
        /// </summary>
        public Point ControlLocation { get => pair.control.Location; set => pair.control.Location = value; }

        public Size ControlAndAllSizes
        {
            get => Size;
            set
            {
                Size = new Size(ParentSubSection.Pair.Panel.Size.Width - (seperations * 4), value.Height + (seperations * 4));
                ControlSize = value;
                LabelSize = new Size(ParentSubSection.Pair.Panel.Size.Width - pair.control.Size.Width - (seperations * 4), value.Height + (seperations * 4));
                //TODO support multiline
            }
        }

        public Size LabelSize { get => pair.label.Size; set => pair.label.Size = value; }

        public Size ControlSize { get => pair.control.Size; set => pair.control.Size = value; }

        SectionsManager sectionsManager;
        public SectionsManager SectionsManager { get => sectionsManager; set => sectionsManager = value; }

        SubSection parentSubSection;
        public SubSection ParentSubSection { get => parentSubSection; set => parentSubSection = value; }

        public SubSectionOption(SectionsManager pSectionsManager, SubSection pParentSubSection, (Label lbl, Control ctrl) pPair, int pControlWidth = 20, string pFileOptionString = "", int pControlHeight = 20)
        {
            sectionsManager = pSectionsManager;
            parentSubSection = pParentSubSection;
            fileOptionString = pFileOptionString;
            pair = pPair;
            ControlAndAllSizes = new Size(pControlWidth, pControlHeight);
            LabelLocation = new Point(seperations*2, seperations*2);
            pair.label.TextAlign = ContentAlignment.MiddleLeft;
            pair.label.AutoSize = true;
            pair.control.Anchor = AnchorStyles.Right;
            this.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.Controls.Add(pair.label);
            this.Controls.Add(pair.control);
            ParentSubSection.Pair.Panel.Controls.Add(this);
            ParentSubSection.SubSectionOptions.Add(this);
            if (parentSubSection.SubSectionOptions.Count % 2 == 0)
            {
                BackColor = HOMIColors.SubSectionOptionBackground;
            }
            else
            {
                BackColor = HOMIColors.SubSectionOptionBackgroundOdd;
            }
            ParentSubSection.AllSizes = parentSubSection.PnlContent.Size;
        }
    }
}
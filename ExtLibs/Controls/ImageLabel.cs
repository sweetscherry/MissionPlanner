﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    [DefaultEvent("Click")]
    public partial class ImageLabel : MyUserControl //ContainerControl
    {
        private string _label;

        public new event EventHandler Click;

        //[System.ComponentModel.Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        //public Label Label { get { return label1; } set { label1 = value; } }
        //[System.ComponentModel.Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        //public PictureBox PictureBox { get { return pictureBox1; } set { pictureBox1 = value; } }

        public ImageLabel()
        {
            InitializeComponent();

            PictureBox.Image = PictureBox.InitialImage;
            PictureBox.WaitOnLoad = true;
        }

        public void setImageandText(Image image, string text)
        {
            PictureBox.Image = image;
            Label.Text = text;
        }

        [System.ComponentModel.Browsable(true)]
        public Image Image {
            get { return PictureBox.Image; }
            set { try { PictureBox.Image = value; } catch { try { PictureBox.Image = value; } catch { } } }
        }

        [System.ComponentModel.Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { /*if (DesignMode) return _label;*/ if (Label == null) return "";  return Label.Text; }
            set { /*if (DesignMode) { _label = value; return; }*/  Label.Text = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Click != null)
            {
                Click(this, EventArgs.Empty);
            }
        }
    }
}

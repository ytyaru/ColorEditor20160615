/**
 * ColorEditor20160615
 *
 * These codes are licensed under CC0.
 * http://creativecommons.org/publicdomain/zero/1.0/deed.ja
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorEditor20160615
{
    public partial class ColorEditorForm : Form
    {
        EventHandler numericUpDown1ValueChanged;
        EventHandler numericUpDown2ValueChanged;
        EventHandler numericUpDown3ValueChanged;
        EventHandler trackBar1ValueChanged;
        EventHandler trackBar2ValueChanged;
        EventHandler trackBar3ValueChanged;

        Color selectedColor;

        public ColorEditorForm()
        {
            InitializeComponent();

            this.numericUpDown1ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown2ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            this.numericUpDown3ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);

            this.trackBar1ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.trackBar2ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            this.trackBar3ValueChanged += new System.EventHandler(this.trackBar3_ValueChanged);

            this.numericUpDown1.ValueChanged += this.numericUpDown1ValueChanged;
            this.numericUpDown2.ValueChanged += this.numericUpDown2ValueChanged;
            this.numericUpDown3.ValueChanged += this.numericUpDown3ValueChanged;

            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            this.trackBar3.ValueChanged += new System.EventHandler(this.trackBar3_ValueChanged);

            this.trackBar1.ValueChanged += this.trackBar1ValueChanged;
            this.trackBar2.ValueChanged += this.trackBar2ValueChanged;
            this.trackBar3.ValueChanged += this.trackBar3ValueChanged;

            this.selectedColor = Color.FromArgb(0, 0, 0);
            this.SetUIColor();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar1.ValueChanged -= this.trackBar1ValueChanged;
            this.trackBar1.Value = (int)this.numericUpDown1.Value;
            this.trackBar1.ValueChanged += this.trackBar1ValueChanged;

            this.SetUIColor();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar2.ValueChanged -= this.trackBar2ValueChanged;
            this.trackBar2.Value = (int)this.numericUpDown2.Value;
            this.trackBar2.ValueChanged += this.trackBar2ValueChanged;

            this.SetUIColor();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.trackBar3.ValueChanged -= this.trackBar3ValueChanged;
            this.trackBar3.Value = (int)this.numericUpDown3.Value;
            this.trackBar3.ValueChanged += this.trackBar3ValueChanged;

            this.SetUIColor();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown1.ValueChanged -= this.numericUpDown1ValueChanged;
            this.numericUpDown1.Value = this.trackBar1.Value;
            this.numericUpDown1.ValueChanged += this.numericUpDown1ValueChanged;

            this.SetUIColor();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown2.ValueChanged -= this.numericUpDown2ValueChanged;
            this.numericUpDown2.Value = this.trackBar2.Value;
            this.numericUpDown2.ValueChanged += this.numericUpDown2ValueChanged;

            this.SetUIColor();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            this.numericUpDown3.ValueChanged -= this.numericUpDown3ValueChanged;
            this.numericUpDown3.Value = this.trackBar3.Value;
            this.numericUpDown3.ValueChanged += this.numericUpDown3ValueChanged;

            this.SetUIColor();
        }

        private void SetUIColor()
        {
            this.selectedColor = Color.FromArgb(
                (int)this.numericUpDown1.Value,
                (int)this.numericUpDown2.Value,
                (int)this.numericUpDown3.Value);

            this.pictureBox1.BackColor = this.selectedColor;
        }
    }
}

using _06_exercise;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
            public partial class Configuration : Form
            {
                        private List<Color> colors = new List<Color>() { Color.Black, Color.Red, Color.Blue, Color.Green, Color.Yellow };

                        public Config config;

                        public Configuration(Config config)
                        {
                                    InitializeComponent();
                                    this.config = config;

                                    rbColumns.Tag = eBarChartType.COLUMNS;
                                    rbLine.Tag = eBarChartType.LINE;

                                    if (config.ViewType == eBarChartType.COLUMNS)
                                    {
                                                rbColumns.Checked = true;
                                                lblLineColorInfo.Visible = false;
                                                lstColors.Visible = false;


                                    }
                                    else
                                    {
                                                lblLineColorInfo.Visible = true;
                                                lstColors.Visible = true;
                                                rbLine.Checked = true;
                                    }

                                    for (int i = 1; i <= 5; i++)
                                    {
                                                cboColumns.Items.Add(i);
                                    }
                                    cboColumns.SelectedItem = config.Columns;

                                    ListViewItem item;

                                    colors.ForEach(x => lstColors.Items.Add(x));

                                    lstColors.SelectedItem = config.LineColor;
                        }

                        private void btnSave_Click(object sender, EventArgs e)
                        {
                                    DialogResult = DialogResult.Yes;
                                    this.Close();
                        }

                        private void rbTypes_CheckedChanged(object sender, EventArgs e)
                        {
                                    Debug.WriteLine((eBarChartType)(sender as RadioButton).Tag);
                                    config.ViewType = (eBarChartType)(sender as RadioButton).Tag;
                                    lblLineColorInfo.Visible = rbLine.Checked;
                                    lstColors.Visible = rbLine.Checked;
                        }

                        private void cboColumns_SelectedIndexChanged(object sender, EventArgs e)
                        {
                                    config.Columns = (int)(sender as ComboBox).SelectedItem;
                        }

                        private void lstColors_SelectedIndexChanged(object sender, EventArgs e)
                        {
                                    config.LineColor = (Color)(sender as ListBox).SelectedItems[0];
                        }
            }
}

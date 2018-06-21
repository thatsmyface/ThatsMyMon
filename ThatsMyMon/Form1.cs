using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThatsMyMon
{
    public partial class Form1 : Form
    {
        AutoCompleteStringCollection monsource = new AutoCompleteStringCollection();
        AutoCompleteStringCollection itemsource = new AutoCompleteStringCollection();
        AutoCompleteStringCollection abilitysource = new AutoCompleteStringCollection();
        AutoCompleteStringCollection naturesource = new AutoCompleteStringCollection();
        AutoCompleteStringCollection movesource = new AutoCompleteStringCollection();

        public Form1()
        {
            InitializeComponent();

            //Populate Species Box
            string[] mons = System.IO.File.ReadAllLines("mons.txt");
            monsource.AddRange(mons);
            mon.AutoCompleteCustomSource = monsource;
            mon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            mon.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //Populate Items Box
            string[] items = System.IO.File.ReadAllLines("items.txt");
            itemsource.AddRange(items);
            this.items.AutoCompleteCustomSource = itemsource;
            this.items.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.items.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //Populate Ability Box
            string[] abilities = System.IO.File.ReadAllLines("abilities.txt");
            abilitysource.AddRange(abilities);
            this.abilitybox.AutoCompleteCustomSource = abilitysource;
            this.abilitybox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.abilitybox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //Populate Nature Box
            string[] natures = System.IO.File.ReadAllLines("natures.txt");
            naturesource.AddRange(natures);
            this.natureBox.AutoCompleteCustomSource = naturesource;
            this.natureBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.natureBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //Populate Move Boxes
            string[] moves = System.IO.File.ReadAllLines("moves.txt");
            movesource.AddRange(moves);
            this.move1.AutoCompleteCustomSource = movesource;
            this.move1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.move1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.move2.AutoCompleteCustomSource = movesource;
            this.move2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.move2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.move3.AutoCompleteCustomSource = movesource;
            this.move3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.move3.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.move4.AutoCompleteCustomSource = movesource;
            this.move4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.move4.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a, sa, d, sd, sp = 0;
            if (Int32.TryParse(aEV.Text, out a) && Int32.TryParse(saEV.Text, out sa) && Int32.TryParse(dEV.Text, out d) && Int32.TryParse(sdEV.Text, out sd) && Int32.TryParse(spEV.Text, out sp))
            {
                totalEV.Text = (a + sa + d + sd + sp).ToString();
            }
        }

        private void mon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sprite.ImageLocation = "sprites/" + mon.Text + ".gif";
            }
            catch
            {

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure that you want to reset? This will clear all fields, even if you haven't saved.";
            string caption = "Reset?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                // Closes the parent form.

                reset();

            }
        }

        private void reset()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);

            aIV.Text = "31";
            saIV.Text = "31";
            dIV.Text = "31";
            sdIV.Text = "31";
            spIV.Text = "31";
            aEV.Text = "0";
            saEV.Text = "0";
            dEV.Text = "0";
            sdEV.Text = "0";
            spEV.Text = "0";

            try
            {
                sprite.ImageLocation = "";
            }
            catch
            {

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    addLine(((TextBox)x).Text);
                }
            }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Ethan's Pokemon Format (*.epf)|*.epf";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllLines(saveFileDialog1.FileName, lines);
                }

                //System.IO.File.WriteAllLines("savedMon.epk", lines);

            void addLine(string pass)
            {
                lines.Add(pass);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Opening a saved 'mon will replace all fields. Are you sure you'd like to continute?";
            string caption = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string[] readText = { };

                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Filter = "Ethan's Pokemon Format (*.epf)|*.epf";
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        readText = File.ReadAllLines(openFileDialog1.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }

                int i = 0;
                foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        ((TextBox)x).Text = readText[i];
                        i++;
                    }
                }
            }
        }
    }
}

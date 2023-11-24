using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_ModuleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_ModuleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet.tb_ModuleType' table. You can move, or remove it, as needed.
            this.tb_ModuleTypeTableAdapter.Fill(this.universityDataSet.tb_ModuleType);
            // TODO: This line of code loads data into the 'universityDataSet.tb_Module' table. You can move, or remove it, as needed.
            this.tb_ModuleTableAdapter.Fill(this.universityDataSet.tb_Module);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.MoveFirst(); // Move to first
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.MovePrevious(); // Move to prev
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.MoveNext(); // Move to next
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.MoveLast(); // Move to last
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var selectedType = ((DataRowView) comboBox2.SelectedItem).Row;
            universityDataSet.tb_Module.Addtb_ModuleRow(tbxCode.Text,
                tbxName.Text,
                Convert.ToInt32(tbxYear.Text),
                (UniversityDataSet.tb_ModuleTypeRow) selectedType); // If error, check the bulb icon
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (validationSave()) // Check for Null input
            {
                // Copy paste from above
                this.Validate();
                this.tb_ModuleBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.universityDataSet);
            }
        }

        private bool validationSave()
        {
            string[] tbxInputs = {moduleNameTextBox.Text, moduleCodeTextBox.Text, moduleYearTextBox.Text}; // Store tbx within array
            foreach(string tbxInput in tbxInputs) // Go through them
            {
                if (string.IsNullOrEmpty(tbxInput)) // Check whether empty
                {
                    MessageBox.Show("WTF");
                    return false;
                }
            }
            return true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tb_ModuleBindingSource.Count > 0)
            {
                try
                {
                    var userResponse = MessageBox.Show("Sure?", "Delete", MessageBoxButtons.YesNo); // Three params (Text, Headline, Choice)
                    if (userResponse == DialogResult.Yes)
                    {
                        tb_ModuleBindingSource.RemoveCurrent(); // Delete current data point
                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); // Catch any unexpected exceptions
                }
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            tb_ModuleBindingSource.Filter = $"moduleName LIKE '{tbxFilter.Text}%'"; // Filters based on moduleName (SQL like)
        }

        // Create a helper function for saving data
        private void saveData()
        {
            if (this.validationSave())
            {
                try
                {
                    this.tb_ModuleBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.universityDataSet);
                    MessageBox.Show("Saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.validationSave())
            {
                this.tb_ModuleBindingSource.EndEdit(); // Ends editing mode
                if (universityDataSet.HasChanges()) // Detect any changes
                {
                    if (MessageBox.Show("Save?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        saveData(); // Call saveData
                    }
                }
            }
            else
            {
                e.Cancel = true; // Cancel closing window
            }
        }
    }
}

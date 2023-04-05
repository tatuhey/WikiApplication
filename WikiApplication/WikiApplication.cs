using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace WikiApplication
{
    public partial class wikiApplication : Form
    {
        public wikiApplication()
        {
            InitializeComponent();
            fillComboBox();

        }

        int selectedlvcount = -1;

        // 6.2 Create a global List<T> of type Information called Wiki.
        List<Information> Wiki = new List<Information>();

        #region Buttons
        // 6.3 Create a button method to ADD a new item to the list. Use a TextBox for the Name input, ComboBox for 
        // the Category, Radio group for the Structure and Multiline TextBox for the Definition.
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool valid = validName(textName.Text);
            if (valid)
            {
                Information newInformation = new Information();

                newInformation.setName(textName.Text);

                newInformation.setCategory(cbCategory.SelectedItem.ToString());

                string structureValue = radioButtonString(gbStructure);
                newInformation.setStructure(structureValue);

                newInformation.setDefinition(textDefinition.Text);

                Wiki.Add(newInformation);
            }
            else
            {
                MessageBox.Show("repeat");
            }
            clearEntries();
            displayInformation();
            textName.Focus();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedlvcount > -1)
            {
                DialogResult result = MessageBox.Show("Do you want to delete the selected entry?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    delete(selectedlvcount);
                    clearEntries();
                }
                else
                {
                    clearEntries();
                    selectedlvcount = -1;
                }

            }
        }

        #endregion

        #region Methods
        private void clearEntries()
        {
            textName.Clear();
            cbCategory.Text = string.Empty;
            gbStructure.DataBindings.Clear();
            textDefinition.Clear();
        }

        private void displayInformation()
        {
            dataListView.Items.Clear();
            foreach (var item in Wiki)
            {
                dataListView.Items.Add(new ListViewItem(new[] { item.getName(), item.getCategory(), item.getStructure(), item.getDefinition() }));
            }
        }

        // 6.4 Create a custom method to populate the ComboBox when the Form Load method is called. The six categories must be read from a simple text file.
        private void fillComboBox()
        {
            cbCategory.Items.Clear();
            string[] category = File.ReadAllLines("category.txt");

            foreach (string categoryItem in category)
            {
                cbCategory.Items.Add(categoryItem);
            }
        }

        // 6.5 Create a custom ValidName method which will take a parameter string value from the Textbox Name 
        // and returns a Boolean after checking for duplicates. Use the built in List<T> method “Exists” to answer this requirement.
        private bool validName(string name)
        {
            if (Wiki.Exists(dup => dup.getName() == name))
                return false;
            else
                return true;
        }

        // 6.6 Create two methods to highlight and return the values from the Radio button GroupBox.
        // The first method must return a string value from the selected radio button (Linear or Non-Linear).
        // The second method must send an integer index which will highlight an appropriate radio button.

        // still needs fixing
        private string radioButtonString(GroupBox groupBox)
        {
            foreach (RadioButton radio in groupBox.Controls.OfType<RadioButton>())
            {
                if (radio.Checked)
                {
                    return radio.Text;
                }
            }

            return null;
        }
        private bool radioButtonHighlight(GroupBox groupBox, string value)
        {
            foreach (RadioButton radio in groupBox.Controls.OfType<RadioButton>())
            {
                if (radio.Text == value)
                {
                    radio.Checked = true;
                    return true;
                }
            }

            return false;
        }

        //private bool radioButtonHighlight(GroupBox groupBox, int index)
        //{
        //    if (index < 0 || index >= groupBox.Controls.Count)
        //    {
        //        return false;
        //    }

        //    RadioButton radioButton = groupBox.Controls.OfType<RadioButton>().ElementAt(index);
        //    radioButton.Checked = true;

        //    return true;
        //}


        // 6.7 Create a button method that will delete the currently selected record in the ListView. Ensure the user 
        // has the option to backout of this action by using a dialog box. Display an updated version of the sorted list at the end of this process.
        private void delete(int row)
        {
            Wiki.RemoveAt(row);
            dataListView.Items.RemoveAt(row);
        }

        // prevent keypress in combobox
        private void cbCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        #endregion












        // 6.8 Create a button method that will save the edited record of the currently selected item in the ListView.
        // All the changes in the input controls will be written back to the list.
        // Display an updated version of the sorted list at the end of this process.


        // 6.9 Create a single custom method that will sort and then display the Name and Category from the wiki information in the list.


        // 6.10 Create a button method that will use the builtin binary search to find a Data Structure name. 
        // If the record is found the associated details will populate the appropriate input controls and highlight the name in the ListView.
        // At the end of the search process the search input TextBox must be cleared.


        // 6.11 Create a ListView event so a user can select a Data Structure Name from the list of Names and the 
        // associated information will be displayed in the related text boxes combo box and radio button.

        private void dataListView_MouseClick(object sender, MouseEventArgs e)
        {
            selectedlvcount = dataListView.SelectedIndices[0];
            if (selectedlvcount > -1)
            {
                Information item = Wiki[selectedlvcount];
                string namewhenselect = item.getName();
                string definitionwhenselect = item.getDefinition();
                textName.Text = namewhenselect;
                textDefinition.Text = definitionwhenselect;

                string categorywhenselect = item.getCategory();
                cbCategory.Text = categorywhenselect;

                string structurewhenselect = item.getStructure();
                radioButtonHighlight(gbStructure, structurewhenselect);
                
            }
            else
            {
                MessageBox.Show("Error when selecting data from the listview");
            }
        }





        // 6.12 Create a custom method that will clear and reset the TextBoxes, ComboBox and Radio button.


        // 6.13 Create a double click event on the Name TextBox to clear the TextBboxes, ComboBox and Radio button.


        // 6.14 Create two buttons for the manual open and save option; this must use a dialog box to select a file or 
        // rename a saved file. All Wiki data is stored/retrieved using a binary reader/writer file format.


        // 6.15 The Wiki application will save data when the form closes. 


        // 6.16 All code is required to be adequately commented. Map the programming criteria and features to your 
        // code/methods by adding comments above the method signatures. Ensure your code is compliant with the 
        // CITEMS coding standards (refer http://www.citems.com.au/).

    }
}

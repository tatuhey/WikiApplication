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

// Raihan Khalil Abdillah - 30065695
// Wiki Application | 22 March 2023 - 07 April 2023
// Further development for data structures wiki

namespace WikiApplication
{
    public partial class wikiApplication : Form
    {
        public wikiApplication()
        {
            InitializeComponent();
            fillComboBox();
            ststReset();
        }

        // 6.2 Create a global List<T> of type Information called Wiki.
        List<Information> Wiki = new List<Information>();

        #region Methods
        // 6.3 Create a button method to ADD a new item to the list. Use a TextBox for the Name input, ComboBox for 
        // the Category, Radio group for the Structure and Multiline TextBox for the Definition.
        private void add()
        {
            try
            {
                Information newInformation = new Information();
                newInformation.setName(textName.Text);
                newInformation.setCategory(cbCategory.SelectedItem.ToString());
                string structureValue = radioButtonString(gbStructure);
                newInformation.setStructure(structureValue);
                newInformation.setDefinition(textDefinition.Text);
                Wiki.Add(newInformation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when adding data to the listview.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // if name is empty, then not valid
            if (!string.IsNullOrEmpty(name))
            {
                // if name is duplicate, then not valid as well
                if (Wiki.Exists(dup => dup.getName().ToLower() == name.ToLower()))
                    return false;
                else
                    return true;
            }
            else
                return false;

        }

        // 6.6 Create two methods to highlight and return the values from the Radio button GroupBox.
        // The first method must return a string value from the selected radio button (Linear or Non-Linear).
        // The second method must send an integer index which will highlight an appropriate radio button.
        private string radioButtonString(GroupBox groupBox)
        {
            foreach (RadioButton radio in groupBox.Controls.OfType<RadioButton>())
            {
                // if a radio button is checked, the string on the radio button is returned
                if (radio.Checked)
                {
                    return radio.Text;
                }
            }
            return null;
        }

        // Be advised that this function utilises text of the radiobutton instead of index value
        private bool radioButtonHighlight(GroupBox groupBox, string value)
        {
            foreach (RadioButton radio in groupBox.Controls.OfType<RadioButton>())
            {
                // if string in the listview match the either of the text on the radio button, highlight the button
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
        //    else
        //    {
        //        RadioButton radioButton = groupBox.Controls.OfType<RadioButton>().ElementAt(index);
        //        radioButton.Checked = true;
        //        return true;
        //    }
        //}

        // 6.7 Create a button method that will delete the currently selected record in the ListView. Ensure the user 
        // has the option to backout of this action by using a dialog box. Display an updated version of the sorted list at the end of this process.
        private void delete(int row)
        {
            Wiki.RemoveAt(row);
            dataListView.Items.RemoveAt(row);
        }

        // 6.8 Create a button method that will save the edited record of the currently selected item in the ListView.
        // All the changes in the input controls will be written back to the list.
        // Display an updated version of the sorted list at the end of this process.
        private void edit(int index)
        {
            if (!string.IsNullOrEmpty(textName.Text))
            {
                bool valid = validComboBox();
                if (valid)
                {
                    Information editItem = Wiki[index];
                    editItem.setName(textName.Text);
                    editItem.setDefinition(textDefinition.Text);
                    editItem.setCategory(cbCategory.Text);
                    string editStructure = radioButtonString(gbStructure);
                    editItem.setStructure(editStructure);
                    displayInformation();
                    ststEdit();
                }
                else
                    ststInvalid();
            }
            else
                ststInvalid();
            
        }

        // 6.9 Create a single custom method that will sort and then display the Name and Category from the wiki information in the list.
        private void displayInformation()
        {
            Wiki.Sort();
            dataListView.Items.Clear();
            foreach (var item in Wiki)
            {
                dataListView.Items.Add(new ListViewItem(new[] { item.getName(), item.getCategory(), item.getStructure(), item.getDefinition() }));
            }
        }

        // 6.10 Create a button method that will use the builtin binary search to find a Data Structure name. 
        // If the record is found the associated details will populate the appropriate input controls and highlight the name in the ListView.
        // At the end of the search process the search input TextBox must be cleared.
        private void search(int index)
        {
            Information search = Wiki[index];
            dataListView.Items[index].Selected = true;
            dataListView.Select();
            textName.Text = search.getName();
            cbCategory.Text = search.getCategory();
            textDefinition.Text = search.getDefinition();
            radioButtonHighlight(gbStructure, search.getStructure());
        }

        // 6.11 Create a ListView event so a user can select a Data Structure Name from the list of Names and the 
        // associated information will be displayed in the related text boxes combo box and radio button.
        private void displayOnComponents(int index)
        {
            Information item = Wiki[index];
            textName.Text = item.getName();
            textDefinition.Text = item.getDefinition();
            cbCategory.Text = item.getCategory();
            // Use this if passing string
            radioButtonHighlight(gbStructure, item.getStructure());
            // Use this if passing int
                //int structureInt;
                //int.TryParse(structurewhenselect, out structureInt);
                //radioButtonHighlight(gbStructure, structureInt);
        }

        // 6.12 Create a custom method that will clear and reset the TextBoxes, ComboBox and Radio button.
        private void clearEntries()
        {
            textName.Clear();
            cbCategory.Text = string.Empty;
            textDefinition.Clear();
            //dataListView.SelectedItems.Clear();
            foreach (Control control in gbStructure.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }

        private void save()
        {
            string defaultDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            saveFD.InitialDirectory = defaultDirectory;
            saveFD.FileName = "definitions.dat";
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                BinaryWriter bw;
                try
                {
                    bw = new BinaryWriter(new FileStream("definitions.dat", FileMode.Create));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nCannot save to file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    foreach (var save in Wiki)
                    {
                        bw.Write(save.getName());
                        bw.Write(save.getCategory());
                        bw.Write(save.getStructure());
                        bw.Write(save.getDefinition());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nCannot write to file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bw.Close();
            }
        }

        private void load()
        {
            string defaultDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            openFD.InitialDirectory = defaultDirectory;
            openFD.FileName = "definitions.dat";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                BinaryReader br;
                int index = 0;
                dataListView.Items.Clear();
                try
                {
                    br = new BinaryReader(new FileStream(openFD.FileName, FileMode.Open));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nCannot open file for reading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    string name = br.ReadString();
                    string category = br.ReadString();
                    string structure = br.ReadString();
                    string definition = br.ReadString();
                    Information open = new Information(name, category, structure, definition);
                    Wiki.Add(open);
                    index++;
                }
                br.Close();
                displayInformation();
            }
        }

        //if
        private bool validComboBox()
        {
            if (cbCategory.SelectedIndex != -1)
                return true;
            else
                return false;
        }
        #endregion

        #region Buttons

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ststReset();
            try
            {
                bool valid = validName(textName.Text);
                if (valid)
                {
                    bool validcb = validComboBox();
                    if (validcb)
                        add();
                    else
                        ststInvalid();
                }
                else
                    ststInvalid();
                clearEntries();
                displayInformation();
                textName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when adding data to the listview.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ststReset();
            try
            {
                int index = dataListView.SelectedIndices[0];
                DialogResult result = MessageBox.Show("Do you want to delete the selected entry?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    delete(index);
                    ststDelete();
                }
                clearEntries();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when deleting data from the listview.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ststReset();
            try
            {
                int index = dataListView.SelectedIndices[0];
                edit(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when editting data from the listview.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ststReset();
            try
            {
                string searchName = textSearch.Text;
                searchName = new System.Globalization.CultureInfo("en-US").TextInfo.ToTitleCase(searchName);
                int index = Wiki.BinarySearch(new Information(searchName, "", "", ""));
                if (index >= 0)
                {
                    search(index);
                    ststFound();
                }
                else
                    ststNotFound();
                textSearch.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when searching data from the listview.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 6.14 Create two buttons for the manual open and save option; this must use a dialog box to select a file or 
        // rename a saved file. All Wiki data is stored/retrieved using a binary reader/writer file format.
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                Wiki.Clear();
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when loading data to the listview.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                save();
            }
            catch (Exception ex )
            {
                MessageBox.Show($"Error when saving data from the listview.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Mouseclicks
        // prevent keypress in combobox
        private void cbCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataListView_MouseClick(object sender, MouseEventArgs e)
        {
            int index = dataListView.SelectedIndices[0];
            clearEntries();
            try
            {
                displayOnComponents(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when selecting data from the listview. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textSearch_MouseClick(object sender, MouseEventArgs e)
        {
            textSearch.Clear();
            textSearch.ForeColor = Color.Black;
        }

        // 6.13 Create a double click event on the Name TextBox to clear the TextBoxes, ComboBox and Radio button.
        private void textName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clearEntries();
        }

        // 6.15 The Wiki application will save data when the form closes. 
        private void wikiApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            save();
        }

        private void wikiApplication_MouseClick(object sender, MouseEventArgs e)
        {
            dataListView.SelectedItems.Clear();
            ststReset();
        }

        #endregion

        #region Status strips
        private void ststFound()
        {
            stStripLabel.Text = "Entry is found";
            stStripLabel.BackColor = Color.LightGreen;
        }

        private void ststNotFound()
        {
            stStripLabel.Text = "Entry is not found";
            stStripLabel.BackColor = Color.Yellow;
        }

        private void ststDelete()
        {
            stStripLabel.Text = "Entry was successfully deleted";
            stStripLabel.BackColor = Color.Tomato;
        }

        private void ststEdit()
        {
            stStripLabel.Text = "Entry was successfully edited";
            stStripLabel.BackColor = Color.YellowGreen;
        }

        private void ststInvalid()
        {
            stStripLabel.Text = "Entry is invalid";
            stStripLabel.BackColor = Color.Red;
        }

        private void ststReset()
        {
            stStripLabel.Text = string.Empty;
            stStripLabel.BackColor = Color.Empty;
        }

        #endregion

        // 6.16 All code is required to be adequately commented. Map the programming criteria and features to your 
        // code/methods by adding comments above the method signatures. Ensure your code is compliant with the 
        // CITEMS coding standards (refer http://www.citems.com.au/).

    }
}

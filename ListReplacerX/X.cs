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
using System.Text.RegularExpressions;

/* Pre: 
 * blank or whitespace are not valid input in any required textboxes
 * 
 */
namespace ListReplacerX
{
    public partial class X : Form
    {
        string dir;
        int mode;
        int format;
        string[] input;
        List<string> output;
        string delim;
        List<string[]> searchData;

        public X()
        {
            InitializeComponent();
            dir = "";
            mode = -1;
            format = 0;
            comboBox_format.SelectedIndex = 0;
            EnableFields();
        }

        private void Btn_ChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text file | *.txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dir = openFileDialog1.FileName;
                Console.WriteLine("found file: " + dir);
                txt_Directory.Text = dir;
                input = File.ReadAllLines(dir);
            }
        }

        private void Button_GO_Click(object sender, EventArgs e)
        {
            if (EnabledFieldsAreNotFilled())
            {
                MessageBox.Show("Please fill in all applicable fields.", "Error");
                return;
            }
            if (format == 1)
            {
                List<string> prefixesToCheck = new List<string>();
                prefixesToCheck.Add(textBox_modifyCIndex.Text);
                foreach (string[] data in searchData)
                    prefixesToCheck.Add(data[0]);
                foreach(string prefix in prefixesToCheck)
                    if(!Regex.IsMatch(prefix, @"^[C]\d{2}$"))
                    {
                        MessageBox.Show("\"" + prefix + "\" is not a valid search prefix for this format.", "Error");
                        return;
                    }
            }
            output = input.ToList();
            delim = textBox_delim.Text;
            switch (format)
            {
                case 1:
                case 2:
                    delim = "#";
                    break;
            }
            string matchLogDir;
            string writeToDir;
            if (mode > 0 && checkBox_override.Checked)
            {
                /*MessageBox.Show("This feature is no longer availble.", "Error");
                return;*/
                if (MessageBox.Show("Are you sure you want to override original file?", "?", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
                writeToDir = dir;
            }
            else
            {
                writeToDir = dir.Substring(0, dir.LastIndexOf("\\") + 1) + "ListReplacerX.txt";
                if (mode > 0 && File.Exists(writeToDir))
                {
                    DialogResult r = MessageBox.Show(writeToDir + " already exists. Do you wish to replace it?", "", MessageBoxButtons.YesNoCancel);
                    if (r == DialogResult.Cancel)
                        return;
                    if (r == DialogResult.No)
                    {//Find a directory that hasn't been taken yet.
                        writeToDir = dir.Substring(0, dir.LastIndexOf("\\") + 1) + "ListReplacerX(1).txt";
                        for (int i = 2; File.Exists(writeToDir); i++)
                        {
                            writeToDir = dir.Substring(0, dir.LastIndexOf("\\") + 1) + "ListReplacerX("+i+").txt";
                        }
                    }

                }
            }
            matchLogDir = dir.Substring(0, dir.LastIndexOf("\\")+1) + "matchLog.txt";
            if (checkBox_matchLog.Checked)
                File.AppendAllText(matchLogDir, Environment.NewLine + "Generated on " + DateTime.Now.ToLongTimeString() + " on " + DateTime.Now.ToShortDateString() + "." + Environment.NewLine);
  
            //Starting Search
            button_GO.Enabled = false;
            int ioOffset = 0;
            bool addLinesAllowed = checkBox_addLine.Checked && checkBox_addLine.Visible;
            //FIXME: There could be an issue if two or more lines of same item match all search conditions in a Read or Find-Replace, each recieves treatment as many times as its lines match search.
            for (int i = 0; i < input.Length; i++)
            {
                bool allConditionsMet = false;
                int start = -1;
                int end = -1;
                if (input[i].StartsWith(searchData[0][0]) && input[i].Contains(searchData[0][1])) //found match of first search condition
                {
                    allConditionsMet = true;
                    for (start = i; start >= 0 && !input[start].StartsWith(delim); start--) ; //searches upward for starting delim
                    if (searchData.Count != 1)
                    {
                        bool[] eachConditionMet = new bool[searchData.Count];
                        eachConditionMet[0] = true;
                        int j;
                        for (j = start + 1; j < input.Length && !input[j].StartsWith(delim); j++) //loop until ending delim
                            for (int searchIndex = 1; searchIndex < searchData.Count; searchIndex++) //foreach in searchData
                                if (input[j].StartsWith(searchData[searchIndex][0]) && input[j].Contains(searchData[searchIndex][1])) //current line matches search
                                    eachConditionMet[searchIndex] = true;
                        end = j;
                        foreach (bool b in eachConditionMet) //check if each condition was met
                            allConditionsMet = allConditionsMet && b;
                    }
                }
//                Console.WriteLine("Finished Search.");
                if (allConditionsMet)
                {
                    bool lineAdded;
                    bool addLineNeeded = addLinesAllowed;
                    List<string> matchLogEntry = new List<string>();
                    Console.WriteLine("item start:" + start);
                    Console.WriteLine("item end:" + end);
                    for (int j = start + 1; j < end; j++) //loop until ending delim
                    {
                        Console.WriteLine("Line llooked at");
                        lineAdded = false;
                        if (input[j].StartsWith(textBox_modifyCIndex.Text))
                        {
                            switch (mode)
                            {
                                case 1:
                                    output[j + ioOffset] = textBox_modifyCIndex.Text + textBox_modifyOverwrite.Text;
                                    break;
                                case 2:
                                    if (input[j].Contains(textBox_modifyIfContains.Text))
                                    {
                                        output[j + ioOffset] = textBox_modifyCIndex.Text + textBox_modifyOverwrite.Text;
                                    }
                                    break;
                                case 3:
                                    if (input[j + 1].StartsWith(textBox_modifyCIndex.Text))
                                    {
                                        output[j + ioOffset] = textBox_modifyCIndex.Text + textBox_modifyOverwrite.Text;
                                        output[j + 1 + ioOffset] = textBox_modifyCIndex.Text + textBox_modifyOverwrite2.Text;
                                    }
                                    else if (addLinesAllowed)
                                    {
                                        output[j + ioOffset] = textBox_modifyCIndex.Text + textBox_modifyOverwrite.Text;
                                        output.Insert(j + 1 + ioOffset, textBox_modifyCIndex.Text + textBox_modifyOverwrite2.Text);
                                        ioOffset++;
                                        lineAdded = true;
                                    }
                                    break;
                                case 4:
                                    output[j + ioOffset] = input[j].Replace(textBox_modifyFind.Text, textBox_modifyReplace.Text);
                                    break;
                            }
                            addLineNeeded = false;
                        }
                        if (checkBox_matchLog.Checked)
                        {
                            if (lineAdded)
                                matchLogEntry.Add(output[j + ioOffset - 1]);
                            matchLogEntry.Add(output[j + ioOffset]);
                            Console.WriteLine("Line written to mle");
                        }
                    }
                    if (addLineNeeded && mode <= 3 && mode >= 1) //line(s) needs to be added, insertion sort needed, prefix given is OK.
                    {
                        MessageBox.Show("\"You made it too complicated. It was already working\". It seems you are trying to use the feature you told me you don't need.");
                        return;
                        #region depricated
                        Console.WriteLine("attempting to add line via insertion...");
                        if (format == 1)
                        {
                            int CIndex;
                            if (!Int32.TryParse(textBox_modifyCIndex.Text.Substring(1, 2), out CIndex))
                            {
                                MessageBox.Show("An error occured while parsing modify prefix. The program will now terminate.");
                                Close();
                            }
                            Console.WriteLine("inserting CIndex of " + CIndex);
                            int insertIndex = start + 1;
                            for (int j = start + 1; j < end; j++) //loop until ending delim
                            {

                            }
                        }
                        //TODO: add new line with insert sort given format allows comparison, assuming prefix is valid.
                        #endregion
                    }
                    if (checkBox_matchLog.Checked)
                    {
                        matchLogEntry.Add("#");
                        File.AppendAllLines(matchLogDir, matchLogEntry);
                    }
                }
            }
            Console.WriteLine("Starting writeToDir...");
            if (mode > 0)
            {
                if (File.Exists(writeToDir))
                    File.Delete(writeToDir);
                using (StreamWriter sr = new StreamWriter(writeToDir))
                {
                    foreach(string line in output)
                        sr.Write(line + "\n");
                }
            }
            Console.WriteLine("Done.");
            button_GO.Enabled = true;
            MessageBox.Show("Completed!");
        }

        private void ComboBox_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = comboBox_mode.SelectedIndex;
            Console.WriteLine("mode changed to: " + mode);
            EnableFields();
        }
        private void comboBox_format_SelectedIndexChanged(object sender, EventArgs e)
        {
            format = comboBox_format.SelectedIndex;
            Console.WriteLine("format changed to: " + format);
            EnableFields();
        }

        private void EnableFields()
        {
            #region DefaultEnablesAndVisibilites
            textBox_modifyCIndex.Enabled = false;
            textBox_modifyOverwrite.Enabled = false;

            textBox_modifyFind.Visible = false;
            textBox_modifyReplace.Visible = false;
            textBox_modifyIfContains.Visible = false;
            textBox_modifyOverwrite2.Visible = false;
            textBox_modifyOverwrite.Visible = true; //yes, this one's backwards

            label_modifyFind.Visible = false;
            label_modifyReplace.Visible = false;
            label_modifyIfContains.Visible = false;
            label_modifyOverwrite2.Visible = false;
            label_modifyOverwrite.Visible = true; //backwards

            checkBox_addLine.Enabled = false;
            checkBox_override.Enabled = false;
            #endregion
            //modify of any kind
            if (mode > 0)
            {
                textBox_modifyCIndex.Enabled = true;
                checkBox_override.Enabled = true;
                //any overwrite
                if (mode < 4)
                {
                    textBox_modifyOverwrite.Enabled = true;
                    textBox_modifyOverwrite.Visible = true;
                    checkBox_addLine.Enabled = true;
                }
            }
            //overwrite-if
            if (mode == 2)
            {
                textBox_modifyIfContains.Visible = true;
                label_modifyIfContains.Visible = true;
            }
            //overwrite x2
            if (mode == 3)
            {
                textBox_modifyOverwrite2.Visible = true;
                label_modifyOverwrite2.Visible = true;
            }
            //replace
            if (mode == 4)
            {
                textBox_modifyFind.Visible = true;
                textBox_modifyReplace.Visible = true;
                label_modifyFind.Visible = true;
                label_modifyReplace.Visible = true;
                textBox_modifyOverwrite.Visible = false; //backwards
                label_modifyOverwrite.Visible = false; //backwards
            }
            switch (format)
            {
                case -1:
                case 0:
                    checkBox_addLine.Enabled = false;
                    textBox_delim.Enabled = true;
                    label_delim.Enabled = true;
                    break;
                case 1:
                    textBox_delim.Enabled = false;
                    label_delim.Enabled = false;
                    break;
                case 2:
                    checkBox_addLine.Enabled = false;
                    textBox_delim.Enabled = false;
                    label_delim.Enabled = false;
                    break;
            }
        }

        private bool EnabledFieldsAreNotFilled()
        {
            EnableFields(); //just in case

            //Check gridView for different variations of emptiness
            if (gridViewSearch.RowCount <= 1) return true; //one because blank field for next entry counts.
            searchData = new List<string[]>();
            Console.WriteLine("Created searchData...." + gridViewSearch.RowCount);
            try
            {
                for (int i = 0; i < gridViewSearch.RowCount - 1; i++)
                    searchData.Add(new string[] { gridViewSearch.Rows[i].Cells[0].Value.ToString(), gridViewSearch.Rows[i].Cells[1].Value.ToString() });
            }
            catch //Catch null cell values
            { return true; }

            //Check all enabled, visible textboxes to see if they are filled out
            List<string> requiredStrings = new List<string>();
            List<TextBox> textboxes = new List<TextBox>();
            #region Add All TextBoxes to list
            textboxes.Add(textBox_delim);
            textboxes.Add(textBox_modifyCIndex);
            textboxes.Add(textBox_modifyFind);
            textboxes.Add(textBox_modifyIfContains);
            textboxes.Add(textBox_modifyOverwrite);
            textboxes.Add(textBox_modifyOverwrite2);
            textboxes.Add(textBox_modifyReplace);
            #endregion
            foreach (TextBox textbox in textboxes)
                if (textbox.Enabled && textbox.Visible)
                    requiredStrings.Add(textbox.Text);
            requiredStrings.Add(dir);
            foreach (string field in requiredStrings)
                if (String.IsNullOrEmpty(field) || String.IsNullOrWhiteSpace(field)) return true;

            //Various other checks in this one-liner.
            return !File.Exists(dir) || mode < 0 || format < 0;
        }

        private void button_test_Click(object sender, EventArgs e)
        {
        }
    }
}
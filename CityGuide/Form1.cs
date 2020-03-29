using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityGuide
{
    public partial class Form1 : Form
    {

        const int NAME = 0, IMAGENAME = 1, AREA = 2, POPULATION = 3, MEDIANHOMEPRICE = 4; //defining ints for array system.



        //Setting up array for team names.
        string[] Team_Names =
        {
            "49ers", "Bears","Bengals","Bills","Broncos","Browns","Buckaneers","Cardinals","Chargers","Chiefs",
            "Colts","Cowboys","Dolphins","Eagles","Falcons","Giants","Jaguars","Jets","Lions","Packers","Panthers",
            "Patriots","Rams","Ravens","Raiders","Redskins","Saints","Seahawks","Steelers","Texans","Titans","Vikings"
        };


        const string urlString = "https://www.msn.com/en-us/weather/fullscreenmaps/today/Atlanta/we-city?iso=US&maptype=satellite&q=Atlanta";

        //Enumerate "type" definition
      
        private enum RADIOBUTTONCHECKED { NO=0,YES=10,MAYBE=200};

        //Define "variable" of enumerated type
        RADIOBUTTONCHECKED RadioButtonCheckedState = RADIOBUTTONCHECKED.MAYBE;

        //array for City_Weather drop down.
        string[] City_Weather =
        {
            "Seattle", "New York","Los Angeles","Chicago","San Francisco","Atlanta"
        };


       //Setting up arrays for city's.

        string[] SEATTLE = { "Seattle", "Seattle", "142.5", "730400", "725700" };
        string[] NEWYORK = { "New York", "NewYork", "468.484", "8623000", "681500" };
        string[] LOSANGELES = { " Los Angeles", "Los Angeles", "502.76", "3999759", "687200" };
        string[] CHICAGO = { "Chicago", "Chicago", "234.14", "2716450", "228400" };
        string[] SANFRANCISCO = { "San Francisco", "San_Francisco", "231.89", "884363", "1374800" };
        string[] ATLANTA = { "Atlanta", "Atlanta", "134.0", "486290", "257200" };

        //array to put city array in.
        string[] City = default(string[]);
        double housingMarketSize = default(double);
        //double carsOnRoad = default(double);
        void CityHandler(object sender, EventArgs e, string[] SelectedCity)// method to load city array data
        {

            if (sender is RadioButton rb)
            {
                //when a radio button is unchecked, the code makes label and picture box not show
                if (rb.Checked == false)
                {
                    label_HelloCity.Visible = false;
                    pictureBox_City.Visible = false;

                    return;
                }
            }
            //when radio button is checked.
            label_HelloCity.Text = "Hello " + SelectedCity[NAME] + "!"; //loading name array element as Hello city name.
            label_HelloCity.Visible = true; //changine label to visible.

            pictureBox_City.Image = (Image)CityGuide.Properties.Resources.ResourceManager.GetObject(SelectedCity[IMAGENAME]); //loading image of city.
            pictureBox_City.Visible = true; //making pictureBox visible.

            double area = double.Parse(SelectedCity[AREA]); //convert array data to double.
            label_Area.Text = area.ToString("N1"); //adds , and one decimal .0
            checkBox_Area_CheckedChanged(sender, e); //rerun checkChanged.

            int population = int.Parse(SelectedCity[POPULATION]); // convert to integer.
            label_Population.Text = population.ToString("N0"); //format adds comma no decimal. ie. 1,054
            checkBox_Population_CheckedChanged(sender, e); //rerun checkChanged

            double populationDensity = population / area; //divide population by area
            label_PopDensity.Text = populationDensity.ToString("N0"); //format populationDensity
            checkBox_PopDensity_CheckedChanged(sender, e); // rerun checkChanged

            int medianHomePrice = int.Parse(SelectedCity[MEDIANHOMEPRICE]); //takes input from label text and converts to int. 
            label_MedianHomePrice.Text = medianHomePrice.ToString("c0"); //load median home price from City array and output to label text.//Adds $ and .00
            checkBox_MedianHomePrice_CheckedChanged(sender, e);

            textBox_AverageHouseholdSize_TextChanged(sender, e);
            
           
            //decimal averageCarsPerHoushold = numericUpDown_AverageCarsPerHousehold.Value; //taking input from numericUpDown and put into averageCarsPerHousehold.

            //carsOnRoad = housingMarketSize * Convert.ToInt32(averageCarsPerHoushold); //multiplies numberOfHouseholds * averageCarsPerHousehold and put it in carsOnRoad.
            //label_CarsOnRoad.Text = carsOnRoad.ToString("N0"); //convert carsOnRoad to string and put in label_CarsOnRoad.

           // numericUpDown_AverageCarsPerHousehold.Visible = true;//make numericUpDown visible.

            
        }

        private void ClearForm(Control parent) // clears the form.
        {

            foreach (Control cntrl in parent.Controls)
            {
                if (cntrl.Controls.Count > 0)
                {
                    ClearForm(cntrl);
                }
                if (cntrl is CheckBox c)
                {
                    c.Checked = false;
                }
                else if (cntrl is ComboBox cb)
                {
                    cb.ResetText();
                    cb.Items.Clear();
                }
                else if (cntrl is WebBrowser wb)
                {
                    wb.Visible = false;
                }
                else if (cntrl is NumericUpDown n)
                {
                    n.Value = n.Minimum;
                }
                else if (cntrl is TextBox t)
                {
                    t.Text = string.Empty;
                }
                else if (cntrl is ListBox l)
                {
                    if (l.SelectedItem != null)
                    {
                        l.ClearSelected();
                    }
                }
                else if (cntrl is RadioButton r)
                {
                    r.Checked = false;
                }

                
                //else if (cntrl is GroupBox g)
                //{
                //    foreach(Control control in g.Controls)
                //    {
                //        if (control is RadioButton rb)
                //        {
                //            rb.Checked = false;
                //        }
                //    }
                //}
            }


            //radio_Seattle.Checked = false;
            //radio_LA.Checked = false;
            //radio_NewYork.Checked = false;
            //radio_Chicago.Checked = false;
            //radioButton_SanFrancisco.Checked = false;
            //radioButton_Atlanta.Checked = false;
            //checkBox_Area.Checked = false;
            //checkBox_Population.Checked = false;
            //checkBox_PopDensity.Checked = false;
            //checkBox_MedianHomePrice.Checked = false;
            //checkBox_housingMarket.Checked = false;
            //checkBox_CarsOnRoad.Checked = false;
            //textBox_AverageHouseholdSize.Text = ("");
            //textBox_TeamName.Text = ("");
            //numericUpDown_AverageCarsPerHousehold.Value = numericUpDown_AverageCarsPerHousehold.Minimum;
           
            //comboBox_CityName.ResetText();//reset text box
            //comboBox_CityName.Items.Clear();//clears items in drop list
            
            //webBrowser_Weather.Visible = false;
        }

        public Form1() //method that runs when form is loading.
        {
            InitializeComponent();//loads all of components for interface.

            
            //adding team names to listbox.
            foreach (string name in Team_Names)
            {
                listBox_TeamNames.Items.Add(name);
            }

            //comboBox_CityName.Items.AddRange(City_Weather);//adding city weather names to combobox.

        }

        private void label_Title_Click(object sender, EventArgs e)
        {

        }

        //Radio buttons.
        private void radio_Seattle_CheckedChanged(object sender, EventArgs e) //event handler
        {
            City = SEATTLE; //loading Seattle array data.
            CityHandler(sender, e, City); // calling CityHandler method.
            

        }


        private void radio_NewYork_CheckedChanged(object sender, EventArgs e)
        {
            City = NEWYORK; //loading New York array data.
            CityHandler(sender, e, City); //call to CityHandler method.


        }

        private void radio_LA_CheckedChanged(object sender, EventArgs e)
        {
            City = LOSANGELES; //loading LA array data.
            CityHandler(sender, e, City); //call to CityHandler method.


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            City = CHICAGO; //loading Chicago array data.
            CityHandler(sender, e, City); //call to CityHandler method.


        }


        private void radioButton_SanFrancisco_CheckedChanged(object sender, EventArgs e)
        {
            City = SANFRANCISCO; //loading San Francisco array data.
            CityHandler(sender, e, City); //call to CityHandler method.


        }

        private void radioButton_Atlanta_CheckedChanged(object sender, EventArgs e)
        {
            City = ATLANTA; //loading Atlanta array data.
            CityHandler(sender, e, City); //call to CityHandler method.


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_AverageHouseholdSize_TextChanged(object sender, EventArgs e)
        {


            try
            {

                int population = int.Parse(City[POPULATION]); // selected city POPULATION into population. Parse into int.
                int medianHomePrice = int.Parse(City[MEDIANHOMEPRICE]); //selected city MEDIANHOMEPRICE into medianHomePrice. Parse into int.

                double averageHouseholdSize = double.Parse(textBox_AverageHouseholdSize.Text); //take input from textBox, parse as double, into averageHousholdSize.

                if (averageHouseholdSize < 1 )
                {
                    housingMarketSize = 0;
                }
                
                else if (averageHouseholdSize > population)
                {
                    housingMarketSize = medianHomePrice;
                }
                else
                {
                    housingMarketSize = (population / averageHouseholdSize * medianHomePrice) / 1000000000; // divide housingMarketSize
                }


                label_housingMarketSize.Text = housingMarketSize.ToString("C0"); //Adds $ and .00
                checkBox_housingMarket_CheckedChanged(sender, e);//calling event handler.
                checkBox_CarsOnRoad_CheckedChanged(sender, e);
            }
            catch
            {
                label_housingMarketSize.Text = "";// clears housingMarketSize label.
                checkBox_housingMarket_CheckedChanged(sender, e);//calling event handler.
                
                
            }
            

        }


        bool IsRadioButtonChecked() //method to check if radio button is checked. 
        {

            if (RadioButtonCheckedState == RADIOBUTTONCHECKED.YES) //if true can skip foreach loop.
                return (true);
            
            foreach(Control ctrl in groupBox_RadioButtons.Controls)
            {
                if (ctrl is RadioButton)
                {
                    if (((RadioButton)ctrl).Checked == true)
                    {
                        RadioButtonCheckedState = RADIOBUTTONCHECKED.YES;
                        return  (true);
                    }
                }
            }

            return (false);
        }

        private void checkBox_housingMarket_CheckedChanged(object sender, EventArgs e)
        {
            label_housingMarketSize.Visible = checkBox_housingMarket.Checked && IsRadioButtonChecked(); //housingMarketSize is visible when housingMarket is checked and radiobutton is checked.
                                                                                                        //&& (housingMarketSize > 0);
        }

        private void checkBox_MedianHomePrice_CheckedChanged(object sender, EventArgs e)
        {
            label_MedianHomePrice.Visible = checkBox_MedianHomePrice.Checked && IsRadioButtonChecked();

        }



        private void checkBox_Area_CheckedChanged(object sender, EventArgs e)
        {
            label_Area.Visible = checkBox_Area.Checked && IsRadioButtonChecked();


        }

        private void checkBox_Population_CheckedChanged(object sender, EventArgs e)
        {
            label_Population.Visible = checkBox_Population.Checked && IsRadioButtonChecked();

        }

        private void checkBox_PopDensity_CheckedChanged(object sender, EventArgs e)
        {
            label_PopDensity.Visible = checkBox_PopDensity.Checked && IsRadioButtonChecked();//make label visible if checkbox is checked and radiobutton is checked.

        }


        private void textBox_TeamName_TextChanged(object sender, EventArgs e)
        {

            string teamName = textBox_TeamName.Text.ToLower(); //converts text to lower case and assigns to teamName.
            bool match = false; //initializing match to false.

            try
            {
               listBox_TeamNames.ClearSelected(); //clears selection of listbox.
            }
            catch 
            {
            
            }
            
    
            

            for (int i = 0; i < Team_Names.Length; ++i) // loop as long as team name. has his flipped i++??
            {
                if (Team_Names[i].ToLower() == teamName) //if Team_Name is a match to input team name.
                {
                    match = true; //make match equal true.
                    label_GoTeam.Text = "Go " + Team_Names[i] +"!"; //We use the loop i as the team index call. Put that into labelbox text.

                    listBox_TeamNames.SelectedIndex = i;//We use the loop i as the team index call select correct team into listbox.
                    label_GoTeam.Visible = textBox_TeamName.Text.Length > 0; //set visibitity to true if there is text in textbox.

                    break;
                }
            }

            if (!match) //if no match
            {
                label_GoTeam.Visible = false;//make the GoTeam label invisible.
            }
               

            
       
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox_TeamNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_TeamName.Text=listBox_TeamNames.SelectedItem.ToString();//takes SelectedItem, converts to string, and puts into textbox.

            
        }

        private void button_Clear_Click(object sender, EventArgs e) 
        {
            
            ClearForm(this);
        }

        private void checkBox_CarsOnRoad_CheckedChanged(object sender, EventArgs e)
        {
            
           // label_CarsOnRoad.Visible = checkBox_CarsOnRoad.Checked && IsRadioButtonChecked();
            //numericUpDown_AverageCarsPerHousehold_ValueChanged( sender,  e);
            if (checkBox_CarsOnRoad.Checked == false)
               {
                label_CarsOnRoad.Visible = false;
               }
            else
            {
                label_CarsOnRoad.Visible = true;
            }

            try 
            {
                int population = int.Parse(City[POPULATION]);
                double avgFamilySize = double.Parse(textBox_AverageHouseholdSize.Text);

                int avgCarsPerFamily = (int)numericUpDown_AverageCarsPerHousehold.Value;
                double totalCarsOnRoad = (population / avgFamilySize) * avgCarsPerFamily;

                label_CarsOnRoad.Text = totalCarsOnRoad.ToString("N0");
                //label_CarsOnRoad.Visible = true;

                
            }
            catch
            {
                label_CarsOnRoad.Visible = false;
                

            }

            
        }

        private void numericUpDown_AverageCarsPerHousehold_ValueChanged(object sender, EventArgs e)
        {

            //CityHandler(sender, e, City); //call to CityHandler method.
            checkBox_CarsOnRoad_CheckedChanged( sender,  e);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Weather_Click(object sender, EventArgs e)
        {
            string cityName = comboBox_CityName.Text.Trim();//removes spaces.
            bool found = false;

           

            foreach (object item in comboBox_CityName.Items)
            {
                if (item.ToString().ToLower()==cityName.ToLower())//if they type upper or lower it doesn't matter.
                {
                    found = true;
                                        
                    //webBrowser_Weather.Navigate( "https://www.msn.com/en-us/weather/fullscreenmaps/today/Atlanta/we-city?iso=US&maptype=satellite&q=" + cityName);


                    break;//come out of loop.
                }

            }
            if (!found)
            {
                comboBox_CityName.Items.Add(cityName);
                
                
            }

            string mapURL = urlString.Replace("Atlanta", cityName);
            webBrowser_Weather.Navigate(mapURL);
            webBrowser_Weather.Visible = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label_GoTeam_Click(object sender, EventArgs e)
        {

        }

        private void label_CarsOnRoad_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm(this);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_PopDensity_Click(object sender, EventArgs e)
        {

        }

        private void weatherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cityName = comboBox_CityName.Text.Trim();//removes spaces.
            bool found = false;



            foreach (object item in comboBox_CityName.Items)
            {
                if (item.ToString().ToLower() == cityName.ToLower())//if they type upper or lower it doesn't matter.
                {
                    found = true;

                    //webBrowser_Weather.Navigate( "https://www.msn.com/en-us/weather/fullscreenmaps/today/Atlanta/we-city?iso=US&maptype=satellite&q=" + cityName);


                    break;//come out of loop.
                }

            }
            if (!found)
            {
                comboBox_CityName.Items.Add(cityName);


            }

            string mapURL = urlString.Replace("Atlanta", cityName);
            webBrowser_Weather.Navigate(mapURL);
            webBrowser_Weather.Visible = true;
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileComboBox.InitialDirectory = "."; //empty directory, sets directory
                openFileComboBox.FileName=string.Empty;//set as empty string
                
                
                openFileComboBox.ShowDialog();//open open menu dialog
                string filePath = openFileComboBox.FileName;//gets the name of the save file and puts it in fileSave
                StreamReader reader = File.OpenText(filePath);//opens the file and reads contents

                string cityName = default(string);
                string[] cities = default(string[]);
                char[] separators = { ',' };

                comboBox_CityName.ResetText();//reset text box
                comboBox_CityName.Items.Clear();//clears items in drop list

                while (!reader.EndOfStream)//keep going until we get to the bottom of the file
                {
                    cityName = reader.ReadLine();//reads a line and puts it into cityName
                    //listBox_TeamNames.Items.Add(reader);
                    //comboBox_CityName.Items.Add(cityName);//adding item name to comboBox, one at a time.
                    cities = cityName.Split(separators);

                    foreach (string city in cities) //loop the re-adds formatted text
                    {
                        comboBox_CityName.Items.Add(city.Trim());//trim city name spaces from name and add to combobox.
                    }
                }


                reader.Close();//close reader

                comboBox_CityName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;//set autocomplete mode
            }
            catch
            {
                MessageBox.Show("Failed to open ComboBox list into file.");
                
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                saveComboBox.InitialDirectory = "."; //empty directory, sets directory
                saveComboBox.FileName = default(string); //convert to string.
                saveComboBox.ShowDialog(); //builds dialog
                string fileName = saveComboBox.FileName; //get filename from combobox

                StreamWriter writer = File.CreateText(fileName);

                foreach (object item in comboBox_CityName.Items)
                {
                    writer.WriteLine(item.ToString());
                }

                writer.Close();//closes file

                MessageBox.Show("File save succeeded.");
            }
            catch
            {
                MessageBox.Show("Failed to write ComboBox list into file.");
            }
      
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label_Area_Click(object sender, EventArgs e)
        {

        }

        private void label_Population_Click(object sender, EventArgs e)
        {

        }

        private void label_MedianHomePrice_Click(object sender, EventArgs e)
        {

        }

        private void label_housingMarketSize_Click(object sender, EventArgs e)
        {

        }
    }
}

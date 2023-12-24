using IMSLocal.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IMSLocal
{
    public partial class AddPart : Form
    {

        int x;
        string user;

        public AddPart(string user)
        {
            InitializeComponent();
            
            Random randomID = new Random();
            int partID = randomID.Next(999);
            IDtextbox.Text = partID.ToString();
           this.user = user;
        }
        private void InHouseRB_CheckedChanged(object sender, EventArgs e)
        {
            InOutLabel.Text = "Machine ID";
            InOutTextbox.ResetText();
        }
        private void IDLabel_Click(object sender, EventArgs e)
        {
            this.Text = "ID";
        }
        public void IDtextbox_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form2_Load(object sender, EventArgs e)
        { 
        }
        private void MinLabel_Click(object sender, EventArgs e)
        {
        }
        private void TitleLabel_Click(object sender, EventArgs e)
        {
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
            

         
           
        }
        private async void SaveButton_Click(object sender, EventArgs e)
        {
          

            #region Exceptions and Validation
            if (NameTextbox.Text == string.Empty & PriceTextbox.Text == string.Empty & InvTextbox.Text == string.Empty & MaxTextbox.Text == string.Empty &
                 MinTextbox.Text == string.Empty & InOutTextbox.Text == string.Empty)
            {
                MessageBox.Show("Missing Fields.", "", MessageBoxButtons.OK);
                return;
            }
            if (NameTextbox.BackColor == Color.Red || NameTextbox.Text == string.Empty)
            {
                MessageBox.Show("Name Field Must Be Entered.", "", MessageBoxButtons.OK);
                return;
            }
            if (PriceTextbox.BackColor == Color.Red || PriceTextbox.Text == string.Empty) {
                MessageBox.Show("Price Field Must Have A Number.", "", MessageBoxButtons.OK);
                return;
            }
            if  (InvTextbox.BackColor == Color.Red || InvTextbox.Text == string.Empty)
            {
                MessageBox.Show("Inventory Must Have A Number", "", MessageBoxButtons.OK);
                return;
            }
            if (MaxTextbox.BackColor == Color.Red || MaxTextbox.Text == string.Empty) {
                MessageBox.Show("Max Must Have A Number", "", MessageBoxButtons.OK);
                return;
            }
           if (MinTextbox.BackColor == Color.Red || MinTextbox.Text == string.Empty) {
                MessageBox.Show("Min Must Have A Number", "", MessageBoxButtons.OK);
                return;
            }
            if (InOutTextbox.BackColor == Color.Red || InOutTextbox.Text == string.Empty)
            {
                if (InOutLabel.Text == "Company Name")
                {
                    MessageBox.Show("Company Name Must Be Entered", "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Machine ID Must Have A Number", "", MessageBoxButtons.OK);
                }
                return;
            }
            else
            {
                int machineId;
                string companyName;
                int partID = int.Parse(IDtextbox.Text);
                string name = NameTextbox.Text;
                decimal price = decimal.Parse(PriceTextbox.Text);
                int inStock = int.Parse(InvTextbox.Text);
                int max = int.Parse(MaxTextbox.Text);
                int min = int.Parse(MinTextbox.Text);

                if (min > max)
                {
                    MinTextbox.BackColor = Color.Red;
                    MaxTextbox.BackColor = Color.Red;
                    MessageBox.Show("Min cannot be greater than Max", "", MessageBoxButtons.OK);
                    MinTextbox.BackColor = Color.Yellow;
                    MaxTextbox.BackColor = Color.Yellow;
                    return;
                }

                if (inStock > max)
                {
                    MaxTextbox.BackColor = Color.Red;
                    InvTextbox.BackColor = Color.Red;
                    MessageBox.Show("Inventory cannot be greater than Max", "", MessageBoxButtons.OK);
                    MaxTextbox.BackColor = Color.Yellow;
                    InvTextbox.BackColor = Color.Yellow;

                    return;

                }

                if (inStock < min)
                {
                    MinTextbox.BackColor = Color.Red;
                    InvTextbox.BackColor = Color.Red;
                    MessageBox.Show("Inventory cannot be less than Min", "", MessageBoxButtons.OK);
                    MinTextbox.BackColor = Color.Yellow;
                    InvTextbox.BackColor = Color.Yellow;
                    return;
                }

                #endregion


                else if (InOutLabel.Text == "Machine ID")
                {


                    machineId = int.Parse(InOutTextbox.Text);
                    string type = "Inhouse";
                    await Parts.addPart(partID, name, price, inStock, max, min, type, null, machineId, user);

                }
                else if (InOutLabel.Text == "Company Name")
                {
                    string type = "Outsourced";
                    companyName = InOutTextbox.Text;
                    await Parts.addPart(partID, name, price, inStock, max, min,type, companyName, null, user);
                }
            }


            MainScreen update = (MainScreen)Application.OpenForms["MainScreen"];
            update.loadData();
            this.Close();

        }
        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextbox.Text) || NameTextbox.Text == string.Empty)
            {
                NameTextbox.BackColor = Color.Red;
            }
            else
            {
                NameTextbox.BackColor = Color.White;
            }
        }
        private void InvTexbox_TextChanged(object sender, EventArgs e)
        {
            {
                if (!int.TryParse(InvTextbox.Text, out x) || InvTextbox.Text == string.Empty)
                {
                    InvTextbox.BackColor = Color.Red;
                }
                else
                {
                    InvTextbox.BackColor = Color.White;
                }
            }
        }
        private void PriceTextbox_TextChanged(object sender, EventArgs e)
        {
            decimal y;
            if (!decimal.TryParse(PriceTextbox.Text, out y) || PriceTextbox.Text == string.Empty    )
            {
                PriceTextbox.BackColor = Color.Red;
            }
            else
            {
                PriceTextbox.BackColor = Color.White;
            }
        }
        private void MaxTextbox_TextChanged(object sender, EventArgs e)
        {    
            if (!int.TryParse(MaxTextbox.Text, out x) || MaxTextbox.Text == string.Empty)
            {
                MaxTextbox.BackColor = Color.Red;
            }
            else
            {
                MaxTextbox.BackColor = Color.White;
            }
        }
        private void MinTextbox_TextChanged(object sender, EventArgs e)
        {  
            if (!int.TryParse(MinTextbox.Text, out x) || MinTextbox.Text == string.Empty)
            {
                MinTextbox.BackColor = Color.Red;
            }
            else
            {
                MinTextbox.BackColor = Color.White;
            }
        }
        private void InOutTextbox_TextChanged(object sender, EventArgs e)
        {
            if (OutSourcedRB.Checked == true)
            {
                if (string.IsNullOrWhiteSpace(InOutTextbox.Text) || InOutTextbox.Text == string.Empty)
                {
                    InOutTextbox.BackColor = Color.Red;
                }
                else
                {
                    InOutTextbox.BackColor = Color.White;
                }
            }

            if (InHouseRB.Checked == true)
            {
                if (!int.TryParse(InOutTextbox.Text, out x) ||InOutTextbox.Text == string.Empty )
                {

                    InOutTextbox.BackColor = Color.Red;
                }
            
            else
            {
                InOutTextbox.BackColor = Color.White;
            }
        }
    }
        private void OutSourcedRB_CheckedChanged(object sender, EventArgs e)
        {
            InOutLabel.Text = "Company Name";
        }
        private void InOutLabel_Click(object sender, EventArgs e)
        {  
        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {
        }
        private void NameLabel_Click(object sender, EventArgs e)
        { 
        }
        private void InvLabel_Click(object sender, EventArgs e)
        { 
        }
        private void MaxLabel_Click(object sender, EventArgs e)
        {
        }
    }
}

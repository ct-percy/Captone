using IMSLocal.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IMSLocal
{
    public partial class ModifyPart : Form
    {
        int x;
        
        private readonly int modpartID;

        string user;

        
     public ModifyPart(Outsource outsourced, string userName)
        {
            InitializeComponent();
           
           user = userName;

            IDtextbox.Text = outsourced.PartID.ToString();
            NameTextbox.Text = outsourced.Name.ToString();
            PriceTextbox.Text = outsourced.Price.ToString();
            InvTextbox.Text = outsourced.Stock.ToString();
            MaxTextbox.Text = outsourced.Max.ToString();
            MinTextbox.Text = outsourced.Min.ToString();
            InOutTextbox.Text = outsourced.companyName.ToString();

            InOutLabel.Text = "Company Name";
            OutsourcedRB.Checked = true;

        }



        public ModifyPart(Inhouses inhouse, string userName)
        {


            InitializeComponent();

           user += userName;

                IDtextbox.Text = inhouse.PartID.ToString();
                NameTextbox.Text = inhouse.Name.ToString();
                PriceTextbox.Text = inhouse.Price.ToString();
                InvTextbox.Text = inhouse.Stock.ToString();
                MaxTextbox.Text = inhouse.Max.ToString();
                MinTextbox.Text = inhouse.Min.ToString();
                InOutTextbox.Text = inhouse.machineID.ToString();
            InhouseRB.Checked = true;
            
        }
        private void PriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Cancel Modification?", "", MessageBoxButtons.YesNo);

            if (cancel == DialogResult.Yes)
            {
                this.Close();
            }

            if (cancel == DialogResult.No)
            {

                return;
            }
        }

        private void IDtextbox_TextChanged(object sender, EventArgs e)
        {

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

            if (PriceTextbox.BackColor == Color.Red || PriceTextbox.Text == string.Empty)
            {
                MessageBox.Show("Price Field Must Have A Number.", "", MessageBoxButtons.OK);
                return;
            }

            if (InvTextbox.BackColor == Color.Red || InvTextbox.Text == string.Empty)
            {
                MessageBox.Show("Inventory Must Have A Number", "", MessageBoxButtons.OK);
                return;
            }
            if (MaxTextbox.BackColor == Color.Red || MaxTextbox.Text == string.Empty)
            {
                MessageBox.Show("Max Must Have A Number", "", MessageBoxButtons.OK);
                return;
            }
            if (MinTextbox.BackColor == Color.Red || MinTextbox.Text == string.Empty)
            {
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
                int pID = int.Parse(IDtextbox.Text);
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

                //UPDATE METHODS

                if (InhouseRB.Checked == true)
                {

                    machineId = int.Parse(InOutTextbox.Text);
                    try
                    {
                        await Inhouses.updateInhouse(pID, name, price, inStock, max, min, machineId, user);
                    }
                    catch
                    { 
                     await Outsource.deleteOutsource(pID);

                        await Inhouses.addInhouse(pID, name, price, inStock, max, min, machineId, user);
                    }

                    await Parts.updatePart(pID, name, price, inStock, max, min, "Inhouse", user);

                }
                else if (OutsourcedRB.Checked == true)
                {

                    companyName = InOutTextbox.Text;
                    try
                    {
                        await Outsource.updateOutsource(pID, name, price, inStock, max, min, companyName, user);
                    }
                    catch
                    {
                        await Inhouses.deleteInhouse(pID);
                        await Outsource.addOutsource(pID, name, price, inStock, max, min, companyName, user);
                    }
                    await Parts.updatePart(pID, name, price, inStock, max, min, "Outsourced", user);

                }
                try
                {
                    await AssociatedParts.updateAssociatedParts(pID, name, price, inStock, max, min);
                }
                catch { }

                MainScreen update = (MainScreen)Application.OpenForms["MainScreen"];
                update.loadData();

                this.Close();
            }
        }

        private void InOutLabel_Click(object sender, EventArgs e)
        {

        }

        private void OutsourcedRB_CheckedChanged(object sender, EventArgs e)
        {
            InOutLabel.Text = "Company Name";

            if (string.IsNullOrWhiteSpace(InOutTextbox.Text))
            {

                InOutTextbox.BackColor = Color.Red;
            }
            else
            {
                InOutTextbox.BackColor = Color.White;
            }
        }

        private void InhouseRB_CheckedChanged(object sender, EventArgs e)
        {
            
            InOutLabel.Text = "Machine ID";

            if (!int.TryParse(InOutTextbox.Text, out x))
            {

                InOutTextbox.BackColor = Color.Red;
            }
            else
            {
                InOutTextbox.BackColor = Color.White;
            }


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
        private void InvTextbox_TextChanged(object sender, EventArgs e)
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

        private void PriceTextbox_TextChanged(object sender, EventArgs e)
        {

            decimal y;
            if (!decimal.TryParse(PriceTextbox.Text, out y) || PriceTextbox.Text == string.Empty)
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

           

            if (OutsourcedRB.Checked == true)
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

            if (InhouseRB.Checked == true)
            {
                if (!int.TryParse(InOutTextbox.Text, out x) || InOutTextbox.Text == string.Empty )
                {
                    
                    InOutTextbox.BackColor = Color.Red;
                }

                else
                {
                    InOutTextbox.BackColor = Color.White;
                }
            }
        }

        private void IDLabel_Click(object sender, EventArgs e)
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

        private void MinLabel_Click(object sender, EventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

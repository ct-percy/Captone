using IMSLocal.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMSLocal
{
    
    public partial class AddProduct : Form
    {
        int x;
        BindingList<Parts> partList;
        BindingList<Parts> associatedPartList = new BindingList<Parts>();
        string user;

        private async void loadData()
        {
            partList = new BindingList<Parts>(await Parts.getAllParts());
            
            AllPartsDGV.DataSource = partList;
            AllPartsDGV.Columns["createdBy"].Visible = false;
            AllPartsDGV.Columns["createdOn"].Visible = false;
            AllPartsDGV.Columns["updatedBy"].Visible = false;
            AllPartsDGV.Columns["updatedOn"].Visible = false;

            AssociatedPartsDGV.DataSource = associatedPartList;
            AssociatedPartsDGV.Columns["createdBy"].Visible = false;
            AssociatedPartsDGV.Columns["createdOn"].Visible = false;
            AssociatedPartsDGV.Columns["updatedBy"].Visible = false;
            AssociatedPartsDGV.Columns["updatedOn"].Visible = false;


        }
        public AddProduct(string user)
        {
            InitializeComponent();
            Random randomID = new Random();
            int productID = randomID.Next(500);
            string newID = productID.ToString();
            IDTextbox.Text = newID;
            this.user = user;
           loadData();



        }

        private void AddProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {




        }

        private void IDTextbox_TextChanged(object sender, EventArgs e)
        {
       

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

        private void AllPartsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllPartsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void AssociatedPartsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private async void AddProductButton_Click(object sender, EventArgs e)
        {

            

            #region Exceptions and Validations

            if (NameTextbox.Text == string.Empty & PriceTextbox.Text == string.Empty & InvTextbox.Text == string.Empty & MaxTextbox.Text == string.Empty &
               MinTextbox.Text == string.Empty)
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

            int productID = int.Parse(IDTextbox.Text);
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

            await Products.addProduct(productID,name,price,inStock,max,min, user);

            if (associatedPartList.Count > 0)
            {
                for (int i = 0; i < associatedPartList.Count; i++)
                {
                    int partId = associatedPartList[i].PartID;
                    string partName = associatedPartList[i].Name;
                    decimal partPrice = associatedPartList[i].Price;
                    int partStock = associatedPartList[i].Stock;
                    int partMax = associatedPartList[i].Max;
                    int partMin = associatedPartList[i].Min;


                    await AssociatedParts.addAssociatedPart(productID, partId, partName, partPrice, partStock, partMax, partMin);

                }



            }


            MainScreen update = (MainScreen)Application.OpenForms["MainScreen"];
            update.loadData();

            this.Close();
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            if (AllPartsDGV.CurrentRow == null)
            {
                DialogResult selectPart = MessageBox.Show("No Part Selected", "", MessageBoxButtons.OK);
                if (selectPart == DialogResult.OK) { return; }
            }
            if (AllPartsDGV.CurrentRow.Selected == true)
            {

                var part = AllPartsDGV.CurrentRow.DataBoundItem;

                associatedPartList.Add(part as Parts);
            }


     
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (AssociatedPartsDGV.CurrentRow == null)
            {
                DialogResult selectPart = MessageBox.Show("No Part Selected", "", MessageBoxButtons.OK);
                if (selectPart == DialogResult.OK) { return; }
            }


            DialogResult remove = MessageBox.Show("Remove Part?", "", MessageBoxButtons.YesNo);

            if (remove == DialogResult.Yes)
            {
                Parts part = AssociatedPartsDGV.CurrentRow.DataBoundItem as Parts;
                associatedPartList.Remove(part);
            }
            else if (remove == DialogResult.No)
            {
                return;
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            AllPartsDGV.ClearSelection();
            AllPartsDGV.DefaultCellStyle.SelectionBackColor = Color.Blue;
            bool found = false;
            if (SearchTextbox.Text != "")
            {
                for (int i = 0; i < partList.Count; i++)
                {
                    if (partList[i].Name.Contains(SearchTextbox.Text))
                    {
                        AllPartsDGV.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            else
            {
                return;
            }


            if (!found) { MessageBox.Show("Part Not Found"); return; }
        }
    }
}

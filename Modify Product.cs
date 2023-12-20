using C968_PA.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C968_PA
{
    public partial class ModifyProduct : Form

    {
        int x;

        string user;


        public  int modprodID;
        Products product;
       
       

        BindingList<Parts> partList;
        BindingList<AssociatedParts> associatedPartList;

        private async void loadData()
        {

           

            partList = new BindingList<Parts>(await Query.getAllParts());

            associatedPartList = new BindingList<AssociatedParts>(await Query.getAssociatedParts(product.ProductID));

            AllPartsDGV.DataSource = partList;
            AllPartsDGV.Columns["createdBy"].Visible = false;
            AllPartsDGV.Columns["createdOn"].Visible = false;
            AllPartsDGV.Columns["updatedBy"].Visible = false;
            AllPartsDGV.Columns["updatedOn"].Visible = false;

            AssociatedPartsDGV.DataSource = associatedPartList;
            AssociatedPartsDGV.Columns["ProductID"].Visible = false;

        }
      
  


        public ModifyProduct(int prodID, Products product, string user)
        {
            InitializeComponent();
           
          
           this.user = user;
            modprodID = prodID;
            this.product = product;
            IDTextbox.Text = product.ProductID.ToString();
            NameTextbox.Text = product.Name.ToString();
            PriceTextbox.Text = product.Price.ToString();
            InvTextbox.Text = product.Stock.ToString();
            MaxTextbox.Text=product.Max.ToString();
            MinTextbox.Text =product.Min.ToString();


            AssociatedPartsDGV.AllowUserToAddRows=false;
           

            loadData();



        }
        private void AssociatedPartsLabel_Click(object sender, EventArgs e)
        {

        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void AllPartsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {


            if (AllPartsDGV.CurrentRow == null)
            {
                DialogResult selectPart = MessageBox.Show("No Part Selected", "", MessageBoxButtons.OK);
                if (selectPart == DialogResult.OK) { return; }
            }



            AssociatedParts p = new AssociatedParts()
            {
                PartID = int.Parse(AllPartsDGV.CurrentRow.Cells[0].Value.ToString()),
                Name = AllPartsDGV.CurrentRow.Cells[1].Value.ToString(),
                Price = decimal.Parse(AllPartsDGV.CurrentRow.Cells[2].Value.ToString()),
                Stock = int.Parse(AllPartsDGV.CurrentRow.Cells[3].Value.ToString()),
                Max = int.Parse(AllPartsDGV.CurrentRow.Cells[4].Value.ToString()),
                Min = int.Parse(AllPartsDGV.CurrentRow.Cells[5].Value.ToString()),
                ProductID = product.ProductID,
            };
                
            



            associatedPartList.Add(p);

             


        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
         
           

        }

        private void AssociatedPartsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Cancel Modifications?", "", MessageBoxButtons.YesNo);
                if (cancel == DialogResult.Yes)
            { 
                this.Close();
            }

            if (cancel == DialogResult.No)
            {
                return;

            };
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (AssociatedPartsDGV.CurrentRow == null)
            {
                DialogResult selectPart = MessageBox.Show("No Part Selected", "", MessageBoxButtons.OK);
                if (selectPart == DialogResult.OK) { return; }
            }

            else
            {
                DialogResult remove = MessageBox.Show("Remove Part?", "", MessageBoxButtons.YesNo);

                if (remove == DialogResult.Yes)
                {

                    int x = AssociatedPartsDGV.CurrentRow.Index;

                    AssociatedPartsDGV.Rows.RemoveAt(x);

                   
                }
                else if (remove == DialogResult.No)
                {
                    return;
                }
            }

        }

        private void IDTextbox_TextChanged(object sender, EventArgs e)
        {

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

        private async void SaveButton_Click(object sender, EventArgs e)
        {

            int productID = int.Parse(IDTextbox.Text);
            string name = NameTextbox.Text;
            decimal price = decimal.Parse(PriceTextbox.Text);
            int inStock = int.Parse(InvTextbox.Text);
            int max = int.Parse(MaxTextbox.Text);
            int min = int.Parse(MinTextbox.Text);



            #region Exceptions and Validation

            if (NameTextbox.BackColor == Color.Red || PriceTextbox.BackColor == Color.Red || InvTextbox.BackColor == Color.Red ||
                MaxTextbox.BackColor == Color.Red || MinTextbox.BackColor == Color.Red)
            {
                MessageBox.Show("Entries Not Valid.", "", MessageBoxButtons.OK); return;

            }
        

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


            await Query.updateProduct(productID, name, price, inStock, max, min, user);
            try
            {
                await Query.deleteAssociatedParts(productID);
            }
            catch { }

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


                    await Query.addAssociatedPart(productID, partId, partName, partPrice, partStock, partMax, partMin);

                }



            }

            MainScreen update = (MainScreen)Application.OpenForms["MainScreen"];
            update.loadData();
            this.Close();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void InvLabel_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void MaxLabel_Click(object sender, EventArgs e)
        {

        }

        private void MinLabel_Click(object sender, EventArgs e)
        {

        }

        private void AllPartsLabel_Click(object sender, EventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

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

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


using IMSLocal.Database;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;


namespace IMSLocal
{
    public partial class MainScreen : Form
    {

        private int modpartID;
        private int modprodID;
        BindingList<Parts> partList;
        BindingList<Products> productList;
        string userName;


        
        public async void loadData()
        {

           
            productList = new BindingList<Products>(await Products.getAllProducts());


            partList = new BindingList<Parts>(await Parts.getAllParts());


          

            PartsDGV.DataSource = partList;
            PartsDGV.Columns["createdBy"].Visible = false;
            PartsDGV.Columns["createdOn"].Visible = false;
            PartsDGV.Columns["updatedBy"].Visible = false;
            PartsDGV.Columns["updatedOn"].Visible = false;

            ProductsDGV.DataSource = productList;
            ProductsDGV.Columns["createdBy"].Visible = false;
            ProductsDGV.Columns["createdOn"].Visible = false;
            ProductsDGV.Columns["updatedBy"].Visible = false;
            ProductsDGV.Columns["updatedOn"].Visible = false;

            


        }
        public MainScreen(string userName)
        {

            InitializeComponent();


            loadData();
           
            this.userName = userName;
          

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
      
        }

        private void ProductsTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartsTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PartSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductsSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartsLabel_Click(object sender, EventArgs e)
        {

        }

        private void IMSLabel_Click(object sender, EventArgs e)
        {

        }

        private async void DeletePartButton_Click(object sender, EventArgs e)
        {
/*
            await Connection._db.DropTableAsync<Parts>();
            await Connection._db.DropTableAsync<Inhouses>();
            await Connection._db.DropTableAsync<Outsource>();
            await Connection._db.DropTableAsync<Products>();
            await Connection._db.DropTableAsync<AssociatedParts>();
*/



            if (PartsDGV.CurrentRow == null)
            {
                DialogResult selectPart = MessageBox.Show("No Part Selected", "", MessageBoxButtons.OK);
                if (selectPart == DialogResult.OK) { return; }
            }

           

            string type = PartsDGV.SelectedCells[6].Value.ToString();
            int partID = int.Parse(PartsDGV.SelectedCells[0].Value.ToString());

            BindingList<AssociatedParts> associatedProduct = new BindingList<AssociatedParts>(await AssociatedParts.getAssociatedProduct(partID));


            if (associatedProduct.Count() > 0 )
            {
                DialogResult error = MessageBox.Show("Can not delete Part that is associated to a Product", "", MessageBoxButtons.OK);
                if (error == DialogResult.OK) { return; }
            }


            if (PartsDGV.CurrentRow.Selected)
            {
                DialogResult deletePart = MessageBox.Show("Delete Part?", "", MessageBoxButtons.YesNo);
                if (deletePart == DialogResult.Yes) { 
                    if (type == "Inhouse")
                    {
                        await Inhouses.deleteInhouse(partID);
                       
                    }
                    else if (type == "Outsourced")
                    {
                        await Outsource.deleteOutsource(partID);
                    }

                    await Parts.deletePart(partID);
                }
            }
            loadData();
        }

        private async void ModifyPartButton_Click(object sender, EventArgs e)
        {
           if (PartsDGV.CurrentRow == null)
            {
                DialogResult selectPart = MessageBox.Show("No Part Selected", "", MessageBoxButtons.OK);
                if (selectPart == DialogResult.OK) { return; }
            }


            var partType = PartsDGV.CurrentRow.Cells[6].Value.ToString();


            modpartID = (int)PartsDGV.CurrentRow.Cells[0].Value;


            if (partType == "Inhouse")
            {
                var part = await Inhouses.getInhouse(modpartID);

             ModifyPart modifypart = new ModifyPart(part.First() as Inhouses, userName);
                modifypart.Show();
            }

         else if (partType == "Outsourced")
            {
                var part = await Outsource.getOutsource(modpartID);

                ModifyPart modifypart = new ModifyPart(part.First() as Outsource, userName);
                modifypart.Show();
            }
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {

            AddPart addpart = new AddPart(userName);

            addpart.Show();
            
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
           
          
            
            AddProduct addproduct = new AddProduct(userName);
            addproduct.Show();

        }

        private async void DeleteProductButton_Click(object sender, EventArgs e)
        {

            if (ProductsDGV.CurrentRow == null)
            {
                DialogResult selectProd = MessageBox.Show("No Product Selected", "", MessageBoxButtons.OK);
                if (selectProd == DialogResult.OK) { return; }
            }

            Products p = ProductsDGV.CurrentRow.DataBoundItem as Products;

            BindingList<AssociatedParts> associatedParts = new BindingList<AssociatedParts>(await AssociatedParts.getAssociatedParts(p.ProductID));

            
             if (ProductsDGV.CurrentRow.Selected)
            {
                DialogResult dialogResult = MessageBox.Show("Delete Product?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) { await Products.deleteProduct(p.ProductID); await AssociatedParts.deleteAssociatedParts(p.ProductID); loadData(); }
            }
        }


        private void PartsDGV_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex >= 0)
            {

                modpartID = (int)PartsDGV.Rows[e.RowIndex].Cells[0].Value;
            }
        }

        private async void ModifyProductButton_Click(object sender, EventArgs e)
        {

            if (ProductsDGV.CurrentRow == null)
            {
                DialogResult selectProd = MessageBox.Show("No Product Selected", "", MessageBoxButtons.OK);
                if (selectProd == DialogResult.OK) { return; }
            }

            modprodID = (int)ProductsDGV.CurrentRow.Cells[0].Value;
            var product = await Products.getProduct(modprodID);
            ModifyProduct modifyProduct = new ModifyProduct(modprodID, product as Products, userName);
            modifyProduct.Show();
        }

        private void SearchPartsButton_Click(object sender, EventArgs e)
        {

            PartsDGV.ClearSelection();
            
            bool found = false;
            if (PartSearchBox.Text != "")
            {
                for (int i = 0; i < partList.Count; i++)
                {
                    if (partList[i].Name.Contains(PartSearchBox.Text))
                    {
                        PartsDGV.Rows[i].Selected = true;
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

        private void SearchProductsButton_Click(object sender, EventArgs e)
        {
            ProductsDGV.ClearSelection();
            ProductsDGV.DefaultCellStyle.SelectionBackColor = Color.Blue;
            bool found = false;
            if (ProductsSearchBox.Text != "")
            {
              
                for (int i = 0; i < productList.Count; i++)
                {
                    if (productList[i].Name.Contains(ProductsSearchBox.Text))
                    {
                        ProductsDGV.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            else
            {
                return;
            }
            if (!found) { MessageBox.Show("Product Not Found"); return; }
        }

        private async void generateButton_Click(object sender, EventArgs e)
        {
            string allPartsFile = "AllParts.txt";
            string inhouseFile = "InhouseFile.txt";
            string outsourcedFile = "OutsourcedFile.txt";
            string allProductsFile = "AllProducts.txt";
            string associatedPartsFile = "AllAssociatedParts.txt";
          

            #region Generate All Parts
            if (reportsComboBox.SelectedIndex == 0)
            {
                FileStream allPartsRecords = new FileStream(allPartsFile, FileMode.OpenOrCreate, FileAccess.Write);
                allPartsRecords.Close();

                using (StreamWriter writer = new StreamWriter(allPartsFile, false))
                {
                    writer.WriteLine("All Parts: " + partList.Count() + "   Generated On: " + DateTime.Now.ToUniversalTime().ToLocalTime());
                    writer.WriteLine("Part ID | Part Name | Inventory | Price | Max | Min | Type | Created By | Created Date | Updated By | Updated Date");
                  

                }
                for (int i = 0; i < partList.Count(); i++)
                {
                    var partId = partList[i].PartID.ToString();
                    var partName = partList[i].Name.ToString();
                    var partStock = partList[i].Stock.ToString();
                    var partPrice = partList[i].Price.ToString();
                    var partMax = partList[i].Max.ToString();
                    var partMin = partList[i].Min.ToString();
                    var partType = partList[i].Type.ToString();
                    var createdBy = partList[i].createdBy.ToString();
                    var createdDate = partList[i].createdOn.ToString();
                    var updateBy = partList[i].updatedBy.ToString();
                    var updateDate = partList[i].updatedOn.ToString();

                    using (StreamWriter writer = new StreamWriter(allPartsFile, true))
                    {
                        writer.WriteLine(partId + " | " + partName + " | " + partStock + " | " + partPrice + " | " + partMax + " | " + partMin + " | " + partType + " | " + createdBy + " | " + createdDate + " | " + updateBy + " | " + updateDate);
                    }
                }
                Process.Start("notepad.exe", allPartsFile);
            }
            #endregion

            #region Generate All Inhouse Parts
            BindingList<Inhouses> inhouseList = new BindingList<Inhouses>(await Inhouses.getAllInhouse());

            if (reportsComboBox.SelectedIndex == 1)
            {
                FileStream allInhouseRecords = new FileStream(inhouseFile, FileMode.OpenOrCreate, FileAccess.Write);
                allInhouseRecords.Close();

                using (StreamWriter writer = new StreamWriter(inhouseFile, false))
                {
                    writer.WriteLine("All Inhouse Parts: " + inhouseList.Count() + "   Generated On: " + DateTime.Now.ToUniversalTime().ToLocalTime());
                    writer.WriteLine("Part ID | Part Name | Inventory | Price | Max | Min | Machine ID | Created By | Created Date | Updated By | Updated Date\"");
                   
                }
                for (int i = 0; i < inhouseList.Count(); i++)
                {
                    var partId = inhouseList[i].PartID.ToString();
                    var partName = inhouseList[i].Name.ToString();
                    var partStock = inhouseList[i].Stock.ToString();
                    var partPrice = inhouseList[i].Price.ToString();
                    var partMax = inhouseList[i].Max.ToString();
                    var partMin = inhouseList[i].Min.ToString();
                    var machineId = inhouseList[i].machineID.ToString();
                    var createdBy = inhouseList[i].createdBy.ToString();
                    var createdDate = inhouseList[i].createdOn.ToString();
                    var updateBy = inhouseList[i].updatedBy.ToString();
                    var updateDate = inhouseList[i].updatedOn.ToString();

                    using (StreamWriter writer = new StreamWriter(inhouseFile, true))
                    {
                        writer.WriteLine(partId + " | " + partName + " | " + partStock + " | " + partPrice + " | " + partMax + " | " + partMin + " | " + machineId + " | " + createdBy + " | " + createdDate + " | " + updateBy + " | " + updateDate);
                    }
                }
                Process.Start("notepad.exe", inhouseFile);
            }
            #endregion

            #region Generate All Outsourced Parts
            BindingList<Outsource> outsourceList = new BindingList<Outsource>(await Outsource.getAllOutsource());

            if (reportsComboBox.SelectedIndex == 2)
            {
                FileStream allOutsourcedRecords = new FileStream(outsourcedFile, FileMode.OpenOrCreate, FileAccess.Write);
                allOutsourcedRecords.Close();

                using (StreamWriter writer = new StreamWriter(outsourcedFile, false))
                {
                    writer.WriteLine("All Outsourced Parts: " + outsourceList.Count() + "   Generated On: " + DateTime.Now.ToUniversalTime().ToLocalTime());
                    writer.WriteLine("Part ID | Part Name | Inventory | Price | Max | Min | Company Name | Created By | Created Date | Updated By | Updated Date\"");

                }
                for (int i = 0; i < outsourceList.Count(); i++)
                {
                    var partId = outsourceList[i].PartID.ToString();
                    var partName = outsourceList[i].Name.ToString();
                    var partStock = outsourceList[i].Stock.ToString();
                    var partPrice = outsourceList[i].Price.ToString();
                    var partMax = outsourceList[i].Max.ToString();
                    var partMin = outsourceList[i].Min.ToString();
                    var machineId = outsourceList[i].companyName.ToString();
                    var createdBy = outsourceList[i].createdBy.ToString();
                    var createdDate = outsourceList[i].createdOn.ToString();
                    var updateBy = outsourceList[i].updatedBy.ToString();
                    var updateDate = outsourceList[i].updatedOn.ToString();

                    using (StreamWriter writer = new StreamWriter(outsourcedFile, true))
                    {
                        writer.WriteLine(partId + " | " + partName + " | " + partStock + " | " + partPrice + " | " + partMax + " | " + partMin + " | " + machineId + " | " + createdBy + " | " + createdDate + " | " + updateBy + " | " + updateDate);
                    }
                }
                Process.Start("notepad.exe", outsourcedFile);
            }
            #endregion

            #region Generate All Products
           

            if (reportsComboBox.SelectedIndex == 3)
            {
                FileStream allProductsRecords = new FileStream(allProductsFile, FileMode.OpenOrCreate, FileAccess.Write);
                allProductsRecords.Close();

                using (StreamWriter writer = new StreamWriter(allProductsFile, false))
                {
                    writer.WriteLine("All Products: " + productList.Count() + "   Generated On: " + DateTime.Now.ToUniversalTime().ToLocalTime());
                    writer.WriteLine("Product ID | Product Name | Inventory | Price | Max | Min | Created By | Created Date | Updated By | Updated Date\"");

                }
                for (int i = 0; i < productList.Count(); i++)
                {
                    var productId = productList[i].ProductID.ToString();
                    var productName = productList[i].Name.ToString();
                    var productStock = productList[i].Stock.ToString();
                    var productPrice = productList[i].Price.ToString();
                    var productMax = productList[i].Max.ToString();
                    var productMin = productList[i].Min.ToString();
                    var createdBy = productList[i].createdBy.ToString();
                    var createdDate = productList[i].createdOn.ToString();
                    var updateBy = productList[i].updatedBy.ToString();
                    var updateDate = productList[i].updatedOn.ToString();


                    using (StreamWriter writer = new StreamWriter(allProductsFile, true))
                    {
                        writer.WriteLine(productId + " | " + productName + " | " + productStock + " | " + productPrice + " | " + productMax + " | " + productMin + " | " + createdBy + " | " + createdDate + " | " + updateBy + " | " + updateDate);
                    }
                }
                Process.Start("notepad.exe", allProductsFile);
            }
            #endregion

            #region Generate All Associated Parts

            BindingList<AssociatedParts> associatedPartsList = new BindingList<AssociatedParts>(await AssociatedParts.getAllAssociatedParts()); 

            if (reportsComboBox.SelectedIndex == 4)
            {
                FileStream allAssociatedPartsRecords = new FileStream(associatedPartsFile, FileMode.OpenOrCreate, FileAccess.Write);
                allAssociatedPartsRecords.Close();

                using (StreamWriter writer = new StreamWriter(associatedPartsFile, false))
                {
                    writer.WriteLine("All Parts Associated to Products: " + associatedPartsList.Count() + "   Generated On: " + DateTime.Now.ToUniversalTime().ToLocalTime());
                    writer.WriteLine("Part ID | Product Name | Inventory | Price | Max | Min | Product ID");

                }
                for (int i = 0; i < associatedPartsList.Count(); i++)
                {
                    var partId = associatedPartsList[i].PartID.ToString();
                    var Name = associatedPartsList[i].Name.ToString();
                    var Stock = associatedPartsList[i].Stock.ToString();
                    var Price = associatedPartsList[i].Price.ToString();
                    var Max = associatedPartsList[i].Max.ToString();
                    var Min = associatedPartsList[i].Min.ToString();
                    var productID = associatedPartsList[i].ProductID.ToString();


                    using (StreamWriter writer = new StreamWriter(associatedPartsFile, true))
                    {
                        writer.WriteLine(partId + " | " + Name + " | " + Stock + " | " + Price + " | " + Max + " | " + Min + " | " + productID);
                    }
                }
                Process.Start("notepad.exe", associatedPartsFile);
            }
            #endregion

        }
    }
}
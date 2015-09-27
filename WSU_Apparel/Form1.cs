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

namespace WSU_Apparel
{
    public partial class WSU_Apparel_Form : Form
    {
        private Wardrobe inventory = new Wardrobe();
        private Clothes shoppingCart = new Clothes();
        private string discountType = "";
        private double discount = 0.0;
        SignIn prompt = new SignIn();
        float tax = 0.10f;
        Bitmap Ico;
        double discountStudent = 0.20;
        double discountFaculty = 0.10;
        double discountStaff = 0.10;
        double discountBulk = 0.10;
        private bool loggedIn = false;
        private bool discountsLoaded = false;




     /***************************************************************
     * Author: Anthony Simmons                                      *
     * Assignment: Homework #4 WSU Apparel      	 				*
     * Course: CptS 422 - Software Testing							*
     * Date: October 7, 2013								        *
     * Function Name: WSU_Apparel_Form()		    			    *
     * Description: Constructs the Main Form UI                     *
     * Preconditions: None											*
     * Postconditions: None			        						*
     ****************************************************************/
        public WSU_Apparel_Form()
        {
            InitializeComponent();
            
            loadComboBoxes();
            //loadClothes();
            
            treeViewInventory.CheckBoxes = true;
            dgvInventory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvShoppingCart.EditMode = DataGridViewEditMode.EditProgrammatically;
            
            //inventory.saveInventory("../../Inventory.xml");
            dgvInventory.ForeColor = Color.Maroon;
            dgvShoppingCart.ForeColor = Color.Maroon;

            dgvInventory.BackColor = Color.Gray;
            dgvShoppingCart.BackColor = Color.Gray;

            treeViewInventory.BackColor = Color.Gray;
            treeViewInventory.ForeColor = Color.Maroon;

            inventory.loadInventory("../../Inventory.xml");
            loadDGVInventory();
            loadTreeInventory();
            timer1.Interval = 500;
            timer1.Start();
            Ico = new Bitmap("../../wsu.coug.big.gif");
            //Ico = new Bitmap("../../ofallon.jpg");
            this.Icon = Icon.FromHandle(Ico.GetHicon());

            loadDGVDiscount();
        }

 /***************************************************************
 * Author: Anthony Simmons                                      *
 * Assignment: Homework #4 WSU Apparel      	 				*
 * Course: CptS 422 - Software Testing							*
 * Date: October 7, 2013								        *
 * Function Name: loadDGVInventory()		    			    *
 * Description: Loads the Inventory list into Data Grid View    *
 * Preconditions: Main Form Instantiated						*
 * Postconditions: Allows User to see Inventory					*
 ****************************************************************/
        private void loadDGVInventory()
        {
            loadDGVfromClothesList(inventory.apparel, dgvInventory, false);
        }

        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: loadDGVDiscount() 		    			    *
         * Description: Loads the discounts into data grid view         *
         * Preconditions: Main Form is instantiated						*
         * Postconditions: None			        						*
         ****************************************************************/
        private void loadDGVDiscount()
        {
            dgvDiscounts.ForeColor = Color.Maroon;
            dgvDiscounts.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgvDiscounts.Rows.Add("Student");
            dgvDiscounts.Rows.Add("Faculty");
            dgvDiscounts.Rows.Add("Staff");
            dgvDiscounts.Rows.Add("Bulk");

            dgvDiscounts.Rows[0].Cells[1].Value = (discountStudent * 100).ToString() + "%";
            dgvDiscounts.Rows[1].Cells[1].Value = (discountFaculty * 100).ToString() + "%";
            dgvDiscounts.Rows[2].Cells[1].Value = (discountStaff * 100).ToString() + "%";
            dgvDiscounts.Rows[3].Cells[1].Value = (discountBulk * 100).ToString() + "%";

        }


        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: loadClothes()     		    			    *
         * Description: Creates Inventory From Scratch (No longer needed)*
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void loadClothes()
        {
            string[] shirts = {"Polo", "Tshirt"};
            string[] pants = { "Jeans", "Kakhi" };
            string[] shorts = { "Athletic", "Cargo" };
            string[] coats = { "Sweat_Shirt", "Rain_Coat" };

            loadClothingType("Shirts", shirts, 14.99);
            loadClothingType("Pants", pants, 19.99);
            loadClothingType("Shorts", shorts, 19.99);
            loadClothingType("Coats", coats, 29.99);

        }


        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: loadClothingType()		    			    *
         * Description: Helper Function to loadCothes() creates inventory from scratch      *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void loadClothingType(string category, string[] names, double price)
        {
            Clothes clothes = new Clothes();
            clothes.categoryName = category;
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    for (int k = 1; k < 3; k++)
                    {
                        ClothingType clothingType = new ClothingType();
                        clothingType.productID = "N" + i.ToString() + "-S" + j.ToString() + "-G" + k.ToString();
                        clothingType.Description = names[i] + " " + category;
                        clothingType.category = category;
                        clothingType.Gender = cboBoxGender.Items[k].ToString();
                        clothingType.quantity = 20;
                        clothingType.size = cboBoxSize.Items[j].ToString();
                        clothingType.Title = names[i];
                        clothingType.price = price;
                        clothes.clothesList.Add(clothingType);
                    }
                }
            }
            
            inventory.apparel = clothes;
            
        }


        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: loadTreeInventory()		    			    *
         * Description: Loads the Tree View from the inventory list     *
         * Preconditions: Inventory should be loaded					*
         * Postconditions: None			        						*
         ****************************************************************/
        private void loadTreeInventory()
        {
            treeViewInventory.Nodes.Clear();
            Clothes clothes = inventory.apparel;
            TreeNode clotheNode = new TreeNode(clothes.categoryName);
            clotheNode.Name = clothes.categoryName;
            clotheNode.Text = clothes.categoryName;
            List<string> categories = new List<string>();

            for (int i = 0; i < clothes.clothesList.Count; i++)
            {
                if (!categories.Contains(clothes.clothesList[i].category))
                {
                    categories.Add(clothes.clothesList[i].category);
                }
            }
            for (int i = 0; i < categories.Count; i++)
            {
                TreeNode node = new TreeNode(categories[i]);
                node.Name = categories[i];
                node.Text = categories[i];
                treeViewInventory.Nodes.Add(node);
            }
            
            for (int i = 0; i < clothes.clothesList.Count; i++)
            {
                ClothingType type = clothes.clothesList[i];
                TreeNode tn = new TreeNode(type.Title);

                tn.Name = type.Title;
                tn.Text = type.Title + " - $" + type.price.ToString();
                //clotheNode.Nodes.Add(tn);
                if (treeViewInventory.Nodes[clothes.clothesList[i].category].Nodes[tn.Name] == null)
                {
                    treeViewInventory.Nodes[clothes.clothesList[i].category].Nodes.Add(tn);
                }
            }
        }



         /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: loadDGVfromClothesList()	    			    *
         * Description: loads a given data grid from the given list     *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void loadDGVfromClothesList(Clothes list, DataGridView dgv, bool shopping)
        {
            int i;
            double total = 0.0;
            dgv.Rows.Clear();
            for (i = 0; i < list.clothesList.Count; i++ )
            {
                list.clothesList[i].productID = list.clothesList[i].buildProductID();
                dgv.Rows.Add(list.clothesList[i].Title);
                dgv.Rows[i].Cells[1].Value = list.clothesList[i].subcategory;
                dgv.Rows[i].Cells[2].Value = list.clothesList[i].category;
                dgv.Rows[i].Cells[3].Value = list.clothesList[i].Gender;
                dgv.Rows[i].Cells[4].Value = list.clothesList[i].size;
                dgv.Rows[i].Cells[5].Value = list.clothesList[i].productID;
                dgv.Rows[i].Cells[6].Value = list.clothesList[i].price;
                
                if (shopping)
                {
                    dgv.Rows[i].Cells[7].Value = list.clothesList[i].numSelected;
                    dgv.Rows[i].Cells[8].Value = (double)(list.clothesList[i].price * list.clothesList[i].numSelected);
                    dgv.Rows[i].Cells[9].Value = list.clothesList[i].Description;
                }
                else
                {
                    dgv.Rows[i].Cells[7].Value = list.clothesList[i].quantity;
                    dgv.Rows[i].Cells[8].Value = list.clothesList[i].Description;
                }
                
                total += (double)(list.clothesList[i].price * list.clothesList[i].numSelected);
            }

            if (shopping)
            {
                if (total > 200.0 && !discountType.Contains("Bulk"))
                {
                    discount += discountBulk;
                    discountType += " + Bulk " + (discountBulk*100).ToString() + "%";
                }

                dgv.Rows.Add("Discount: ");
                if (discountType.Contains("Select Discount:"))
                {
                    discountType = "None";
                }
                dgv.Rows[i].Cells[5].Value = discountType;
                dgv.Rows[i].Cells[6].Value = (discount * 100).ToString("#.##") + "%";
                dgv.Rows[i].Cells[8].Value = "Savings: $" + ((double)(total - (total * (1 - discount)))).ToString("#.##");


                i++;
                total *= (1 - discount);
                dgv.Rows.Add("Sub Total: ");
                dgv.Rows[i].Cells[8].Value = "$" + total.ToString("#.##");
                i++;

                dgv.Rows.Add("Sales Tax: ");
                dgv.Rows[i].Cells[1].Value = ((int)(tax*100f)).ToString() + "%";
                float salesTax = (float)total * tax;
                dgv.Rows[i].Cells[8].Value = "$" + (salesTax).ToString("#.##");
                
                i++;
                dgv.Rows.Add("Total: ");
                dgv.Rows[i].Cells[8].Value = "$" + (total + salesTax).ToString("#.##");

            }
        }



        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: btnAddItems_Click()		    			    *
         * Description: Event handler, adds each selected item from     *
         *  tree view to shopping cart list
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void btnAddItems_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in treeViewInventory.Nodes)
            {
                foreach (TreeNode cl in tn.Nodes)
                {
                    if (cl.Checked)
                    {
                        ClothingType clothe = new ClothingType();
                        string []strArr = cl.Text.Split('-', '$');
                        clothe.Title = strArr[0];
                        clothe.category = tn.Text;
                        if (cboBoxSize.SelectedItem.ToString().Contains("Select"))
                        {
                            MessageBox.Show("Please Select a Size");
                            return;
                        }
                        if (cboBoxGender.SelectedItem.ToString().Contains("Select"))
                        {
                            MessageBox.Show("Please Select a Gender");
                            return;
                        }
                        clothe.size = cboBoxSize.SelectedItem.ToString();
                        clothe.Gender = cboBoxGender.SelectedItem.ToString();
                        clothe.Title = strArr[0];
                        clothe.category = tn.Text;
                        clothe.subcategory = clothe.Title.Substring(4);
                        clothe.numSelected++;
                        clothe.Description = clothe.buildDescription();
                        //clothe.productID = "N" + + "-S" + j.ToString() + "-G" + k.ToString();

                        clothe.price = Convert.ToDouble(strArr[2]);

                        bool add = true;
                        for (int i = 0; i < shoppingCart.clothesList.Count; i++)
                        {
                            if (shoppingCart.clothesList[i].compareClothes(clothe))
                            {
                                shoppingCart.clothesList[i].numSelected++;
                                add = false;
                            }
                        }
                        if (add)
                        {
                            shoppingCart.clothesList.Add(clothe);
                        }
                         
                    }
                }
            }
            loadDGVfromClothesList(shoppingCart, dgvShoppingCart, true);
        }



         /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: updateInventoryFromCart()	    			    *
         * Description: Updates inventory from shopping cart items      *
         *  Updates quantities in inventory based on return or checkout * 
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void updateInventoryFromCart(bool returnItems)
        {
            if (this.loggedIn == false)
            {
                MessageBox.Show("Must Be Logged In!");
                return;
            }
            for (int i = 0; i < shoppingCart.clothesList.Count; i++)
            {
                shoppingCart.clothesList[i].cleanClothes();
                for (int j = 0; j < inventory.apparel.clothesList.Count; j++)
                {
                    inventory.apparel.clothesList[j].cleanClothes();
                    if (shoppingCart.clothesList[i].compareClothes(inventory.apparel.clothesList[j]))
                    {
                        if (inventory.apparel.clothesList[j].quantity < shoppingCart.clothesList[i].numSelected && !returnItems)
                        {
                            MessageBox.Show("Currently Out of Stock!");
                            return;
                        }
                        if (returnItems)
                        {
                            inventory.apparel.clothesList[j].quantity += shoppingCart.clothesList[i].numSelected;
                        }
                        else
                        {
                            inventory.apparel.clothesList[j].quantity -= shoppingCart.clothesList[i].numSelected;
                        }
                    }
                }
            }
            loadDGVInventory();
            string date = DateTime.Now.ToShortDateString() + "_" + DateTime.Now.ToShortTimeString();
            date = date.Replace(':', '-');
            date = date.Replace(' ', '_');
            date = date.Replace('/', '-');
            using (System.IO.StreamWriter sw = new StreamWriter("../../"+ date +"_Receipt.txt"))
            {

                string str = "***** WSU Apparel *****\n\n";
                str += "Transaction ID: #T-" + date + "\n\n";

                if (returnItems)
                {
                    str += "Returned Items: \n";
                }
                else
                {
                    str += "Purchased Items: \n";
                }

                for (int i = 0; i < dgvShoppingCart.Rows.Count; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (dgvShoppingCart.Rows[i].Cells[j].Value != null)
                        {
                            str += dgvShoppingCart.Rows[i].Cells[j].Value.ToString() + "\t";
                        }
                    }
                    str += "\n\n";
                }
                MessageBox.Show(str);
                sw.Write(str);
            }
            this.dgvShoppingCart.Rows.Clear();
            this.shoppingCart.clothesList.Clear();
            inventory.saveInventory("../../Inventory.xml");
        }


        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: btnCheckout_Click()		    			    *
         * Description: updates inventory based on checkout             *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            updateInventoryFromCart(false);
        }

        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: loadComboBoxes()  		    			    *
         * Description: loads combo boxes for Gender, Size, and Discounts *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void loadComboBoxes()
        {
            discountsLoaded = false;

            cboBoxDiscount.Items.Clear();
            cboBoxGender.Items.Clear();
            cboBoxSize.Items.Clear();


            cboBoxGender.Items.Add("Select Gender:");
            cboBoxGender.Items.Add("Mens");
            cboBoxGender.Items.Add("Womens");

            cboBoxSize.Items.Add("Select Size:");
            cboBoxSize.Items.Add("Small");
            cboBoxSize.Items.Add("Medium");
            cboBoxSize.Items.Add("Large");
            cboBoxSize.Items.Add("Extra Large");

            cboBoxDiscount.Items.Add("Select Discount:");
            cboBoxDiscount.Items.Add("Student - "+ (discountStudent * 100).ToString() + "%");
            cboBoxDiscount.Items.Add("Faculty - " + (discountFaculty * 100).ToString() + "%");
            cboBoxDiscount.Items.Add("Staff - " + (discountStaff * 100).ToString() + "%");

            cboBoxGender.SelectedItem = cboBoxGender.Items[0];
            cboBoxSize.SelectedItem = cboBoxSize.Items[0];
            cboBoxDiscount.SelectedItem = cboBoxDiscount.Items[0];

            discountsLoaded = true;
        }


         /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: setDiscount()     		    			    *
         * Description: Sets the current discount based on selected discount  *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void setDiscount()
        {
            string dis = cboBoxDiscount.SelectedItem.ToString();
            if (!dis.Contains("Select"))
            {
                int len = dis.Length;
                discount = Convert.ToDouble(dis.Substring(len - 3, 2)) / 100.0;
            }
        }

         /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: cboBoxDiscount_SelectedIndexChanged()		    *
         * Description: Sets the current discount, based on login       *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void cboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.loggedIn)
            {
                discountType = cboBoxDiscount.SelectedItem.ToString();
                setDiscount();
            }
            else if(discountsLoaded == true && !cboBoxDiscount.SelectedItem.ToString().Contains("Select"))
            {
                cboBoxDiscount.SelectedItem = cboBoxDiscount.Items[0];
                MessageBox.Show("Must Be Logged In to Apply Discount!");
            }
        }


         /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: btnRemove_Click() 		    			    *
         * Description: Removes selected items from shopping cart       *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void btnRemove_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dgvShoppingCart.SelectedCells.Count-1; i++)
            {
                string item = dgvShoppingCart.SelectedCells[i].Value.ToString();
                for (int j = 0; j < shoppingCart.clothesList.Count; j++)
                {
                    if (item == shoppingCart.clothesList[j].Title)
                    {
                        shoppingCart.clothesList.RemoveAt(j);
                    }
                }
            }
            loadDGVfromClothesList(shoppingCart, dgvShoppingCart, true);
        }


         /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: btnSignIn_Click() 		    			    *
         * Description: Shows sign in prompt, also handles sign out     *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (btnSignIn.Text == "Sign In")
            {
                prompt = new SignIn();
                prompt.Show();
            }
            else
            {
                prompt.loggedIn = false;
            }
        }


        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: timer1_Tick()		    			            *
         * Description: Poll and Check if user logged in, sets edit mode *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prompt.loggedIn)
            {
                this.loggedIn = true;
                if (prompt.userLoggedIn == false)
                {
                    dgvInventory.EditMode = DataGridViewEditMode.EditOnEnter;
                    dgvDiscounts.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                else
                {
                    
                    dgvInventory.EditMode = DataGridViewEditMode.EditProgrammatically;
                    dgvDiscounts.EditMode = DataGridViewEditMode.EditProgrammatically;
                }
                if (btnSignIn.Text != "Sign Out")
                {
                    btnSignIn.Text = "Sign Out";
                }
            }
            else
            {
                if (btnSignIn.Text != "Sign In")
                {
                    dgvInventory.EditMode = DataGridViewEditMode.EditProgrammatically;
                    btnSignIn.Text = "Sign In";
                    this.loggedIn = false;
                }
            }
        }

        private bool isDigitOrPeriod(char c)
        {
            return Char.IsDigit(c) || c == '.';
        }

         /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: btnUpdateInventory_Click()    			    *
         * Description: Updates inventory based on manager's changes    *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            Clothes list = new Clothes();
            for (int i = 0; i < dgvInventory.Rows.Count - 1; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (dgvInventory.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show("Invalid Input!");
                        return;
                    }
                }

                ClothingType cloth = new ClothingType();
                cloth.Title = dgvInventory.Rows[i].Cells[0].Value.ToString();
                cloth.subcategory = dgvInventory.Rows[i].Cells[1].Value.ToString();
                cloth.category = dgvInventory.Rows[i].Cells[2].Value.ToString();
                cloth.Gender = dgvInventory.Rows[i].Cells[3].Value.ToString();
                cloth.size = dgvInventory.Rows[i].Cells[4].Value.ToString();
                cloth.productID = dgvInventory.Rows[i].Cells[5].Value.ToString();
                
                if (!dgvInventory.Rows[i].Cells[7].Value.ToString().All(Char.IsDigit) 
                 || !dgvInventory.Rows[i].Cells[6].Value.ToString().All(isDigitOrPeriod))
                {
                    MessageBox.Show("Invalid Input!");
                    return;                    
                }
                cloth.price = Convert.ToDouble(dgvInventory.Rows[i].Cells[6].Value);
                cloth.quantity = Convert.ToInt32(dgvInventory.Rows[i].Cells[7].Value);
                cloth.Description = dgvInventory.Rows[i].Cells[8].Value.ToString();

                cloth.price = Math.Abs(cloth.price);
                cloth.quantity = (int)Math.Abs(cloth.quantity);

                list.clothesList.Add(cloth);

            }
            inventory.apparel.clothesList.Clear();
            inventory.apparel = list;
            loadDGVInventory();
            inventory.saveInventory("../../Inventory.xml");
            loadTreeInventory();
        }


        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: btnReturn_Click()		        			    *
         * Description: Updates inventory based on return items         *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void btnReturn_Click(object sender, EventArgs e)
        {
            updateInventoryFromCart(true);
        }


        private bool isDigitOrPercent(char c)
        {
            return Char.IsDigit(c) || c == '%';
        }

         /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: btnUpdateDiscount_Click()	    			    *
         * Description: Updates discount from managers changes          *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        private void btnUpdateDiscount_Click(object sender, EventArgs e)
        {
            string value = "";
            for (int i = 0; i < dgvDiscounts.Rows.Count-1; i++)
            {
                if (dgvDiscounts.Rows[i].Cells[0].Value == null
                    || dgvDiscounts.Rows[i].Cells[1].Value == null
                    || !dgvDiscounts.Rows[i].Cells[1].Value.ToString().All(isDigitOrPercent))
                {
                    MessageBox.Show("Invalid Input!");
                    return;
                }
                
            }

            value = dgvDiscounts.Rows[0].Cells[1].Value.ToString();
            value = value.Remove(value.Length - 1);
            if (value.Length == 1)
            {
                value = "0" + value;
            }
            discountStudent = Convert.ToInt32(value.Substring(0, 2)) / 100.0;

            value = dgvDiscounts.Rows[1].Cells[1].Value.ToString();
            discountFaculty = Convert.ToInt32(value.Substring(0, 2)) / 100.0;

            value = dgvDiscounts.Rows[2].Cells[1].Value.ToString();
            discountStaff = Convert.ToInt32(value.Substring(0, 2)) / 100.0;

            value = dgvDiscounts.Rows[3].Cells[1].Value.ToString();
            discountBulk = Convert.ToInt32(value.Substring(0, 2)) / 100.0;

            discountStudent = Math.Abs(discountStudent);
            discountFaculty = Math.Abs(discountFaculty);
            discountStaff = Math.Abs(discountStaff);
            discountBulk = Math.Abs(discountBulk);

            loadComboBoxes();

        }



    }
}

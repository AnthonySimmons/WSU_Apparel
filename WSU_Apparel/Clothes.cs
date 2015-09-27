using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Data;

namespace WSU_Apparel
{
    
        public class ClothingType
        {
            public double price = 0;
            public string Gender = "";
            public string size = "";
            public string category = "";
            public int quantity = 0;
            public string Title = "";
            public string Description = "";
            public string productID = "";
            public int numSelected = 0;
            public string subcategory = "";

            /***************************************************************
             * Author: Anthony Simmons                                      *
             * Assignment: Homework #4 WSU Apparel      	 				*
             * Course: CptS 422 - Software Testing							*
             * Date: October 7, 2013								        *
             * Function Name: cleanClothes()    		    			    *
             * Description: Clean string properties                         *
             * Preconditions: None											*
             * Postconditions: None			        						*
             ****************************************************************/
            public void cleanClothes()
            {
                Gender.Replace(' ', '\0');
                size.Replace(' ', '\0');
                category.Replace(' ', '\0');
                Title.Replace(' ', '\0');
                productID.Replace(' ', '\0');
            }


            /***************************************************************
             * Author: Anthony Simmons                                      *
             * Assignment: Homework #4 WSU Apparel      	 				*
             * Course: CptS 422 - Software Testing							*
             * Date: October 7, 2013								        *
             * Function Name: buildDescription()		    			    *
             * Description: Creates description based on string properties  *
             * Preconditions: None											*
             * Postconditions: None			        						*
             ****************************************************************/
            public string buildDescription()
            {
                return this.category + "_" + this.subcategory + "_" + this.Title + "_" + this.Gender + "_" + this.size;
            }


            /***************************************************************
             * Author: Anthony Simmons                                      *
             * Assignment: Homework #4 WSU Apparel      	 				*
             * Course: CptS 422 - Software Testing							*
             * Date: October 7, 2013								        *
             * Function Name: compareClothes()  		    			    *
             * Description: Compare cloth properties                        *
             * Preconditions: None											*
             * Postconditions: None			        						*
             ****************************************************************/
            public bool compareClothes(ClothingType source)
            { 
                return (this.price == source.price && this.Gender.Contains(source.Gender) && this.size.Contains(source.size)
                    && this.category.Contains(source.category) && this.Title.Contains(source.Title));
            }

            /***************************************************************
             * Author: Anthony Simmons                                      *
             * Assignment: Homework #4 WSU Apparel      	 				*
             * Course: CptS 422 - Software Testing							*
             * Date: October 7, 2013								        *
             * Function Name: buildProductID()  		    			    *
             * Description: Create product id based on properties           *
             * Preconditions: None											*
             * Postconditions: None			        						*
             ****************************************************************/
            public string buildProductID()
            {
                string str = "";
                if (Title != "" && category != "" && Gender != "" && size != "" && subcategory != "")
                {
                    str = this.subcategory[0].ToString() + this.category[0].ToString() + "-" + this.Gender[0].ToString() + this.size[0].ToString();
                }
                return str;
            }
        }

    public class Clothes
    {
        public string categoryName = "";
        public List<ClothingType> clothesList = new List<ClothingType>();


    }
    public class Wardrobe
    {
        public Clothes apparel = new Clothes();


        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: loadInventory()   		    			    *
         * Description: loads inventory list from saved XML file        *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        public void loadInventory(string fileName)
        {
            apparel.clothesList.Clear();
            using (DataSet data = new DataSet())
            {
                //if(Environment.CurrentDirectory.Contains(fileName))
                {
                    data.ReadXml(fileName);
                    Clothes list = new Clothes();
                    foreach (DataRow dataRow in data.Tables["Clothing"].Rows)
                    {
                        ClothingType type = new ClothingType();
                        type.subcategory = dataRow["Subcategory"].ToString();
                        type.Title = dataRow["Title"].ToString();
                        type.category = dataRow["Category"].ToString();
                        type.Description = dataRow["Description"].ToString();
                        type.price = Convert.ToDouble(dataRow["Price"]);
                        type.quantity = Convert.ToInt32(dataRow["Quantity"]);
                        type.size = dataRow["Size"].ToString();
                        type.Gender = dataRow["Gender"].ToString();
                        type.productID = type.buildProductID();
                        list.categoryName = type.category;

                        if (type.Description == "")
                        {
                            type.Description = type.buildDescription();
                        }

                        list.clothesList.Add(type);
                        
                    }
                    apparel = list;
                }
            }
        }


        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: saveInventory()   		    			    *
         * Description: Saves inventory list to XML File                *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        public void saveInventory(string fileName)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.IndentChars = "\t";
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(fileName, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Inventory");

                Clothes item = this.apparel;
                foreach (ClothingType type in item.clothesList)
                {
                    if (type.Description == "")
                    {
                        type.Description = type.buildDescription();
                    }

                    writer.WriteStartElement("Clothing");
                    writer.WriteElementString("ID", type.productID);

                    writer.WriteElementString("Title", type.Title);
                    writer.WriteElementString("Subcategory", type.subcategory);
                    writer.WriteElementString("Category", type.category);
                    writer.WriteElementString("Description", type.Description);

                    writer.WriteElementString("Gender", type.Gender);
                    writer.WriteElementString("Size", type.size);
                    writer.WriteElementString("Quantity", type.quantity.ToString());
                    writer.WriteElementString("Price", type.price.ToString());

                    writer.WriteEndElement();
                }
                
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }


        /***************************************************************
         * Author: Anthony Simmons                                      *
         * Assignment: Homework #4 WSU Apparel      	 				*
         * Course: CptS 422 - Software Testing							*
         * Date: October 7, 2013								        *
         * Function Name: FindClothingInInventory()	    			    *
         * Description: Find the given clothingtype in inventory list   *
         * Preconditions: None											*
         * Postconditions: None			        						*
         ****************************************************************/
        public ClothingType FindClothingInInventory(ClothingType clothe)
        {
            ClothingType found = new ClothingType();

            foreach (ClothingType type in apparel.clothesList)
            {
                if (clothe.Title == type.Title && clothe.size == type.size
                    && clothe.price == type.price && clothe.Gender == type.Gender)
                {
                    found = type;
                    break;
                }
            }
            
            return found;
        }
    }
}

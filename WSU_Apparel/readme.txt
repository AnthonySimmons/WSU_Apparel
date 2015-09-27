Author: Anthony Simmons
Email: Anthony.Simmons@email.wsu.edu
Washington State University
CS 422 - Software Testing
Assignment #4 - WSU Apparel

This project was designed and implemented in Visual Studio 2012
C# using a Windows Form. The User Interface includes Three Data Grids
for Shopping Cart, Inventory and Discounts. Also includes a tree view
to display clothing category as well as each clothing item. Gender, Size,
and Discounts are selected from three combo boxes. 

Login:
	Some key functionalities require a user to be logged in. To log in,
please select the "Sign In" button, then enter a user name and password.
(Note: Basic User: User Name = "user" Password = "password"
	Manager: User Name = "Butch" Password = "goCougs")

Inventory is saved as an xml file "Inventory.xml" (should be in this folder).
Inventory is displayed in the bottom right Data grid marked "Inventory". To 
edit inventory, please sign in as manager then select any cell to edit. Selecting
the "Update Inventory" button save and reload the inventory as displayed in the 
data grid. When Buttons "Checkout" and "Return Items" are selected, the inventory is 
updated based on the list of items in the shopping cart.

To add items to the shopping cart, select terminal nodes in the tree view that 
represent Clothing items, then select the desired Gender and Size from combo boxes
and select "Add to Shopping Cart". The checkout and return items buttons will 
complete a transaction, update the inventory, and create/display a reciept
 (Reciepts are saved in the project folder).

Notes: This project should include the following files: 
 - Clothes.cs
 - Form1.cs
 - Form1Designer.cs
 - SignIn.cs
 - SignInDesigner.cs
 - Inventory.xml
 - wsu.coug.big.gif (Used as App Icon)
 - Multiple Reciept Files Marked with time stamp
As well as appropriate Visual Studio Project Solution Files

Important:
	I recently upgraded from Visual Studio 2010 to 2012, as such I have
experienced some problems in the passed with opening the Visual Studio Project Solution.
You will notice there are two project solution files both named "WSU_Apparel"

This problem should be resolved but if for any reason you have trouble opening
the solution please try using each solution. If you have any questions, please
feel free to contact me by email (listed above).




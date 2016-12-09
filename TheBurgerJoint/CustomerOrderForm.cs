using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheBurgerJoint
{
    public partial class CustomerOrderForm : Form
    {
        #region Properties - Variables
        int logoutTimer = 0;
        int orderNumber = 0;
        public List<Item> order = new List<Item>();
        string NL = Environment.NewLine;
        const string add = " + ";
        string[] SIZENAMES = new string[3]{ "Small", "Medium", "Large" };
        double[] SIZEPRICE = { 0, .25, .40 };

        string[] BURGERNAMES = { "Junior", "Single", "Double", "Triple" };
        double[] BURGERPRICE = { 2.50, 3.50, 4.25, 5.00 };
        
        string[] SIDENAMES = { "Fries", "Onion Rings" };
        double[] SIDEPRICE = { 1.75, 2.00 };
        
        string[] DRINKNAMES = { "Soda", "Milkshake" };
        double[] DRINKPRICE = { 1, 2.75 };

        bool combo = false;
        #endregion

        public CustomerOrderForm(int x)
        {
            orderNumber = x;
            InitializeComponent();
        }

        private void displayPrice()
        {
            if (combo)
            {
                double COMBOPRICE = SIDEPRICE[0] + DRINKPRICE[0] - .25;
                // Burgers Text Display
                Junior.Text = String.Format("Junior {0}{1:C} ", NL, BURGERPRICE[0] + COMBOPRICE);
                Single.Text = String.Format("Single {0}{1:C} ", NL, BURGERPRICE[1] + COMBOPRICE);
                Double.Text = String.Format("Double {0}{1:C} ", NL, BURGERPRICE[2] + COMBOPRICE);
                Triple.Text = String.Format("Triple {0}{1:C} ", NL, BURGERPRICE[3] + COMBOPRICE);

                // Sides Text Display
                smFry.Text = String.Format("Small Fry {0}{1:C} ", NL, SIZEPRICE[0]);
                lgFry.Text = String.Format("Large Fry {0}{1:C} ", NL, SIZEPRICE[2]);

                smOnion.Text = String.Format("Small Onion Rings {0}{1:C} ", NL, SIDEPRICE[1] - SIDEPRICE[0] + SIZEPRICE[0]);
                lgOnion.Text = String.Format("Large Onion Rings {0}{1:C} ", NL, SIDEPRICE[1] - SIDEPRICE[0] + SIZEPRICE[2]);

                // Drinks Text Display
                smSoda.Text = String.Format("Small Soda {0}{1:C} ", NL, SIZEPRICE[0]);
                lgSoda.Text = String.Format("Large Soda {0}{1:C} ", NL, SIZEPRICE[2]);
                smShake.Text = String.Format("Small Shake {0}{1:C} ", NL, DRINKPRICE[1] - DRINKPRICE[0] + SIZEPRICE[0]);
                lgShake.Text = String.Format("Large Shake {0}{1:C} ", NL, DRINKPRICE[1] - DRINKPRICE[0] + SIZEPRICE[2]);
            }
            else
            {
                // Burgers Text Display
                Junior.Text = String.Format("Junior {0}{1:C} ", NL, BURGERPRICE[0]);
                Single.Text = String.Format("Single {0}{1:C} ", NL, BURGERPRICE[1]);
                Double.Text = String.Format("Double {0}{1:C} ", NL, BURGERPRICE[2]);
                Triple.Text = String.Format("Triple {0}{1:C} ", NL, BURGERPRICE[3]);

                // Sides Text Display
                smFry.Text = String.Format("Small Fry {0}{1:C} ", NL, SIDEPRICE[0]);
                lgFry.Text = String.Format("Large Fry {0}{1:C} ", NL, SIDEPRICE[0] + SIZEPRICE[2]);
                smOnion.Text = String.Format("Small Onion Rings {0}{1:C} ", NL, SIDEPRICE[1]);
                lgOnion.Text = String.Format("Large Onion Rings {0}{1:C} ", NL, SIDEPRICE[1] + SIZEPRICE[2]);

                // Drinks Text Display
                smSoda.Text = String.Format("Small Soda {0}{1:C} ", NL, DRINKPRICE[0]);
                lgSoda.Text = String.Format("Large Soda {0}{1:C} ", NL, DRINKPRICE[0] + SIZEPRICE[2]);
                smShake.Text = String.Format("Small Shake {0}{1:C} ", NL, DRINKPRICE[1]);
                lgShake.Text = String.Format("Large Shake {0}{1:C} ", NL, DRINKPRICE[1] + SIZEPRICE[2]);
            }
        }

        #region Main Menu

        private void menuCombo_Btn_Click(object sender, EventArgs e)
        {
            combo = true;
            clearPanels(BurgerMenu_Pnl);
        }

        private void menuBurgers_Btn_Click(object sender, EventArgs e)
        {
            combo = false;
            clearPanels(BurgerMenu_Pnl);
        }

        private void menuSides_Btn_Click(object sender, EventArgs e)
        {
            combo = false;
            clearPanels(SidesMenu_Pnl);
        }

        private void menuDrinks_Btn_Click(object sender, EventArgs e)
        {
            combo = false;
            clearPanels(DrinksMenu_Pnl);
        }
        #endregion

        #region Burger Menu

        private void BurgerJunior_Btn_Click(object sender, EventArgs e)
        {
            if(combo)
            {
                addItem(BURGERNAMES[0] + " Combo", BURGERPRICE[0] + SIDEPRICE[0] + DRINKPRICE[0] - .25);
                clearPanels(SidesMenu_Pnl);
            }
                
            else
            {
                addItem(BURGERNAMES[0] + " Burger", BURGERPRICE[0]);
                //clearPanels(BurgerOptions_Pnl);
                showOrder();
            }
        }

        private void burgerSingle_Btn_Click(object sender, EventArgs e)
        {
            if (combo)
            {
                addItem(BURGERNAMES[1] + " Combo", BURGERPRICE[1] + SIDEPRICE[0] + DRINKPRICE[0] - .25);
                clearPanels(SidesMenu_Pnl);
            }
            else
            {
                addItem(BURGERNAMES[1] + " Burger", BURGERPRICE[1]);
                showOrder();
            }
        }

        private void burgerDouble__Btn_Click(object sender, EventArgs e)
        {
            if (combo)
            {
                addItem(BURGERNAMES[2] + " Combo", BURGERPRICE[2] + SIDEPRICE[0] + DRINKPRICE[0] - .25);
                clearPanels(SidesMenu_Pnl);
            }
            else
            {
                addItem(BURGERNAMES[2] + " Burger", BURGERPRICE[2]);
                showOrder();
            }
        }

        private void burgerTriple_Btn_Click(object sender, EventArgs e)
        {
            if (combo)
            {
                addItem(BURGERNAMES[3] + "Combo", BURGERPRICE[3] + SIDEPRICE[0] + DRINKPRICE[0] - .25);
                clearPanels(SidesMenu_Pnl);
            }
            else
            {
                addItem(BURGERNAMES[3] + "Burger", BURGERPRICE[3]);
                showOrder();
            }   
        }
        #endregion

        #region Side Menu

        private void sideSmFry_Btn_Click(object sender, EventArgs e)
        {
            if(combo)
            {
                addItem(add + SIDENAMES[0], (SIZEPRICE[0]));
                clearPanels(DrinksMenu_Pnl);
            }
            else
            {
                addItem(SIDENAMES[0], (SIDEPRICE[0] + SIZEPRICE[0]));
                showOrder();
            }
        }

        private void sideLgFry_Btn_Click(object sender, EventArgs e)
        {
            if (combo)
            {
                addItem(add + SIDENAMES[0], (SIZEPRICE[2]));
                clearPanels(DrinksMenu_Pnl);
            }
            else
            {
                addItem(SIDENAMES[0], (SIDEPRICE[0] + SIZEPRICE[2]));
                showOrder();
            }
        }

        private void sideSmOnionRing__Btn_Click(object sender, EventArgs e)
        {
            if (combo)
            {
                addItem(add + SIDENAMES[1], (SIDEPRICE[1] - SIDEPRICE[0] + SIZEPRICE[0]));
                clearPanels(DrinksMenu_Pnl);
            }
            else
            {
                addItem(SIDENAMES[1], (SIDEPRICE[1] + SIZEPRICE[0]));
                showOrder();
            }
        }

        private void sideLgOnionRing_Btn_Click(object sender, EventArgs e)
        {
            if (combo)
            {
                addItem(add + SIDENAMES[1], (SIDEPRICE[1] - SIDEPRICE[0]) + SIZEPRICE[2]);
                clearPanels(DrinksMenu_Pnl);
            }
            else
            {
                addItem(SIDENAMES[1], (SIDEPRICE[1] + SIZEPRICE[2]));
                showOrder();
            }             
        }
        #endregion

        #region Drink Menu
        private void drinkSmSoda_Btn_Click(object sender, EventArgs e)
        {
            if (combo)
            {
                addItem(add + DRINKNAMES[0], SIZEPRICE[0]);
            }
            else
            {
                addItem(DRINKNAMES[0], (DRINKPRICE[0] + SIZEPRICE[0]));
            }
            showOrder();
        }

        private void drinkLgSoda_Btn_Click(object sender, EventArgs e)
        {
            if(combo)
            {
                addItem(add + DRINKNAMES[0], (SIZEPRICE[2]));
            }
            else
            {
                addItem(DRINKNAMES[0], (DRINKPRICE[0] + SIZEPRICE[2]));
            }
            showOrder();
        }

        private void drinkSmShake__Btn_Click(object sender, EventArgs e)
        {
            if (combo)
            {
                addItem(add + DRINKNAMES[1], (DRINKPRICE[1] - DRINKPRICE[0] + SIZEPRICE[0]));
            }
            else
            {
                addItem(DRINKNAMES[1], (DRINKPRICE[1] + SIZEPRICE[0]));
            }
            showOrder();
        }

        private void drinkLgShake_Btn_Click(object sender, EventArgs e)
        {
            if (combo)
            {
                addItem(add + DRINKNAMES[1], (DRINKPRICE[1] - DRINKPRICE[0] + SIZEPRICE[2]));
            }
            else
            {
                addItem(DRINKNAMES[1], (DRINKPRICE[1] + SIZEPRICE[2]));
            }
            
            showOrder();
        }
        #endregion

        #region Order Functionality

        private void showOrder()
        {
            clearPanels(Order_Pnl);
            Order_ListBox.Items.Clear();

            int x = 0;
            double totalPrice = 0;
            const string BLANK = ". ";

            Order_ListBox.Items.Add( orderLine("   Name", "Price") );

            foreach (Item item in order)
            {
                x++;
                Order_ListBox.Items.Add(
                    orderLine( x + BLANK + item.name, item.price.ToString("c")) );
                totalPrice += item.price;
            }

            totalPrice_lbl.Text = orderLine("Total", totalPrice.ToString("c"));
        }

        private string orderLine(string name, string price) {
            StringBuilder sb = new StringBuilder();
            int spaces = 40 - (name.Length + price.Length);
            while (sb.Length < spaces) sb.Append(" ");
            return ("  " + name + sb + price);
        }

        private void OrderRemove_Btn_Click(object sender, EventArgs e)
        {
            int index = Order_ListBox.SelectedIndex;

            if (index > 0)
            {
                if(order.ElementAt(index-1).name.Contains("Combo") ){
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(
                        order.ElementAt(index - 1).name,
                        "Remove Items",
                        MessageBoxButtons.OKCancel
                        );

                    if (result == DialogResult.OK)
                    {
                        order.RemoveAt(index + 1);
                        order.RemoveAt(index);
                        order.RemoveAt(index - 1);
                        showOrder();
                    }
                }
                else if (order.ElementAt(index-1).name.Contains("+"))
                {
                    if (order.ElementAt(index - 2).name.Contains("+"))
                    {
                        DialogResult result = new DialogResult();
                        result = MessageBox.Show(
                            order.ElementAt(index - 3).name,
                            "Remove Items",
                            MessageBoxButtons.OKCancel
                            );

                        if (result == DialogResult.OK)
                        {
                            order.RemoveAt(index - 1);
                            order.RemoveAt(index - 2);
                            order.RemoveAt(index - 3);
                            showOrder();
                        }
                    }
                    else
                    {
                        DialogResult result = new DialogResult();
                        result = MessageBox.Show(
                            order.ElementAt(index - 2).name,
                            "Remove Items",
                            MessageBoxButtons.OKCancel
                            );

                        if (result == DialogResult.OK)
                        {
                            order.RemoveAt(index);
                            order.RemoveAt(index - 1);
                            order.RemoveAt(index - 2);
                            showOrder();
                        }
                    }
                }
                else
                {
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show(
                        order.ElementAt(index - 1).name,
                        "Remove Item",
                        MessageBoxButtons.OKCancel
                        );

                    if (result == DialogResult.OK)
                    {
                        order.RemoveAt(index - 1);
                        showOrder();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select an Item from the List of Items, and then click the Remove Item button", "Remove Item Help");
            }
                
        }

        private void OrderAdd_Btn_Click(object sender, EventArgs e)
        {
            clearPanels(MainMenu_Pnl);
        }

        private void OrderCancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to exit?\nThis will remove your order from the system.", "Exit", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) { this.Close(); }
        }

        private void OrderPayment_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order #" + orderNumber.ToString(), "Thank you for choosing us at The Burger Joint!");
            this.Close();
        }
        #endregion

        private void StoreNameLbl_Btn_Click(object sender, EventArgs e)
        {
            clearPanels(MainMenu_Pnl);
        }

        private void clearPanels(Panel panel)
        {
            logoutTimer = 0;
            MainMenu_Pnl.Visible = false;
            BurgerMenu_Pnl.Visible = false;
            SidesMenu_Pnl.Visible = false;
            DrinksMenu_Pnl.Visible = false;
            Order_Pnl.Visible = false;
            displayPrice();
            panel.Visible = true;
        }

        private void addItem(string _name, double _price)
        {
            Item item = new Item();
            item.name = _name;
            item.price = _price;
            order.Add(item);
        }

        #region Bun Selection

        private void sesameBun_Btn_Click(object sender, EventArgs e)
        {
            selectBun(sender as Button);
        }

        private void wheatBun_Btn_Click(object sender, EventArgs e)
        {
            selectBun(sender as Button);
        }

        private void glutenBun_Btn_Click(object sender, EventArgs e)
        {
            selectBun(sender as Button);
        }

        private void selectBun(Button button)
        {
            SesameBun.BackColor = Color.White;
            WheatBun.BackColor = Color.White;
            GlutenBun.BackColor = Color.White;
            button.BackColor = Color.Gray;
        }
        #endregion

        #region Sauce Selection
        private void ketchupSauce_Btn_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Button);
        }

        private void mustardSauce_Btn_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Button);
        }

        private void mayoSauce_Btn_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Button);
        }
        #endregion

        #region Vegetable Selection

        private void lettuceVeg_Btn_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Button);
        }

        private void tomatoVeg_Btn_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Button);
        }

        private void onionVeg_Btn_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Button);
        }
        #endregion

        #region Extra Selection

        private void cheeseExtra_Btn_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Button);
        }

        private void baconExtra_Btn_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Button);
        }

        private void peppersExtra_Btn_Click(object sender, EventArgs e)
        {
            toggleButton(sender as Button);
        }
        #endregion

        private void toggleButton(Button button)
        {
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Gray;
            }
            else
            {
                button.BackColor = Color.White;
            }
        }

        private void autoLogOut(object sender, EventArgs e)
        {
            logoutTimer++;
            if (logoutTimer > 4 && logoutTimer < 6)
            {
                MessageBox.Show("Inactive Account", "The system has been idle for 60 seconds and will exit in 15 seconds.");
            }
            else if (logoutTimer > 5)
            {
                this.Close();
            }
        }

    }
}
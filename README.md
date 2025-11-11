## 🍝 Pasta Paradiso Diner GUI

**Pasta Paradiso** is a Windows Forms desktop application developed in C\#, designed to function as a complete, front-end ordering system for a contemporary diner specializing in Italian cuisine, salads, and desserts.

The application utilizes a rich Graphical User Interface (GUI) to provide a smooth, interactive experience for staff or customers to build an order from start to finish. It is a full-featured simulation that demonstrates a command of C\# object-oriented programming, data structure usage (Dictionaries and Lists), and UI event-driven logic.

### 🍴 Key Features & Menu Breakdown

The application is structured to handle various categories of a diner's menu, with all items and prices managed internally:

| Category | Item Name | Price |
|:---|:---|:---|
| **Pasta Menu** (Main) | Creamy Truffle Pasta | $25.00 |
| | Pesto Penne | $20.00 |
| | Vegetable Primavera | $17.50 |
| | Mushroom and Spinach Ravioli | $15.50 |
| | Shrimp Alfredo3 (Note: *as per code*) | $15.00 |
| | Linguine Aglio e Olio | $12.50 |
| | Spaghetti Bolognese | $10.00 |
| | Butternut Squash Ravioli | $10.50 |
| **Salad & Dessert** | Cheesecake with Berry Compote | $12.50 |
| | Mediterranean Quinoa Salad | $10.00 |
| | Tiramisu | $8.50 |
| | Chicken Avocado Salad | $8.50 |
| | Chocolate Lava Cake | $7.50 |
| | Caprese Salad | $7.50 |
| | Classic Caesar Salad | $5.00 |
| | Fruit Tart | $4.50 |

### 📋 Ordering and Logic

*   **Order Building:** Items from the main menu and salad/dessert sections are selected via separate ListBoxes and added to an internal order list using dedicated **"Add Order"** buttons.
*   **Total Calculation:** The **"Display Order"** function iterates through the selected items, looks up the price from the `itemValues` dictionary, and calculates a final, itemized total that is presented to the user via a message box.
*   **Order Control:** A **"Clear Order"** function resets the internal order list and all selection controls on the form.
*   **Menu Strip:** The application includes a menu bar with **File** (Place Order, Clear Order, Display Order, Exit), **Edit**, and **Help** options.

### 🍔 Customization Options

*   **Bread Special Request:** A dropdown menu allows selecting a special bread, including Garlic Bread, Italian Breadsticks, Bread Rolls, Whole Grain or Multi-Grain Bread, and Olive Bread.
*   **Drink Selection:** A GroupBox provides radio button options for Milk, Juice, Soda, Lemonade, Tea, and Coffee, plus a separate checkbox option for Water.
*   **Service Type:** A dropdown allows the selection of **"Dine in"** or **"Takeout"**.
*   **Visual Item Preview:** A PictureBox is dynamically updated to show a corresponding image of the currently selected menu item (if available) from the Main Menu or Salad/Dessert list.

## 🤝 Contribution

If you find ways to improve the dashboard's design, model, or analysis (e.g., adding new metrics or improving performance), feel free to fork this repository and submit a pull request!

## 📄 License

This project is released under the **MIT License**. See the `LICENSE` file for details.

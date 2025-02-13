# Cafe
In this task I've done a parody of how would quote on quote work having a full system working as following:
* Firstly would be the loading of the **Cooks**, **Ingredients** and of course **Dishes**.
* Secondly would be the **Menu** clients are prompted with the list with the respective **Prices**, **Ingredients** and **Names**
* After which they are asked to **Insert** what would they want to order
* After they have decided a **valid Menu Item** The **Manager** gets their order and **delegates** to which **Cook** the order will go to.
* After the order **was given** to a **Cook** the **client** can continuously enter **dishes** from the menu until the **cooks** are **full** with the **orders**
* When the **Cooks** are full the **Manager** will apologize saying how much time it will be until the **Cooks** can receive a new order.

## Assumptions made
* The **Cooks** are making the **dishes** in **parallel** thus increasing efficiency.
* The **Dishes** have connection with **Ingredients** although not mentioned in the initial requirements
* The **system** works **continuously** as a one big **component**
`
## Recommendations
* Using a **database** for the saving of **ingredients, dishes and cooks** 
* Making of a **config file** for global variables maybe different number of cooks or different multipliers of efficiency for workers.
* For myself more **ask** more questions in order **to understand** the **full extent of what the client wants**

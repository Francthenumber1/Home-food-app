using HomeFood._588286;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFood
{
    public partial class New_mainpage : Form
    {
        public string username;
        public New_mainpage(string loginuser)

        {
            InitializeComponent();
            username = loginuser;

        }
        private void New_mainpage_Load(object sender, EventArgs e)
        {
            userlabel.Text = username;
        }


        BackForm backForm = new BackForm();

        public string Description;
        public string Ingredients;
        public string Cuisine;
        public string Notes;
        public string Instructions;
        public string Nutrition;
        public New_mainpage()
        {
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            the_displaypa.Controls.Clear();
            Rezeptsuchen_und_filtern rezeptsuchen_Und_Filtern = new Rezeptsuchen_und_filtern();
           
            rezeptsuchen_Und_Filtern.TopLevel = false;

            // Dock the form inside the panel
            rezeptsuchen_Und_Filtern.Dock = DockStyle.Fill; // Make it fill the entire panel


            // Add the form to the panel's controls
            the_displaypa.Controls.Add(rezeptsuchen_Und_Filtern);

            // Show the form (as a control inside the panel)
            rezeptsuchen_Und_Filtern.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            the_displaypa.Controls.Clear();
            Rezepte_hinzufügen rezepte_Hinzufügen = new Rezepte_hinzufügen();
            rezepte_Hinzufügen.TopLevel = false;
            
            rezepte_Hinzufügen.Dock = DockStyle.Fill;
            the_displaypa.Controls.Add(rezepte_Hinzufügen);
            rezepte_Hinzufügen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            the_displaypa.Controls.Clear();
            communication communication2 = new communication();
            communication2.TopLevel = false;
            communication2.StartPosition = FormStartPosition.Manual; // Allow manual positioning
            int xPos = (the_displaypa.Width - communication2.Width) / 2;
            int yPos = (the_displaypa.Height - communication2.Height) / 2;
            communication2.Location = new Point(xPos, yPos); // Set location to the center

            // Add the form to the panel's controls
            the_displaypa.Controls.Add(communication2);

            // Show the form (as a control inside the panel)
            communication2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                // Define the About Us message
                string aboutUsMessage = "Welcome to HomeFood, your go-to platform for discovering, sharing, and connecting through the love of cooking!\n\n" +
                                        "With Home Food, you can:\n" +
                                        "- Share Your Own Recipes: Upload your favorite recipes and inspire others to cook something new.\n" +
                                        "- Follow Your Favorite Chefs: Stay updated with your favorite recipes by following other users.\n" +
                                        "- Comment & Connect: Share your thoughts, tips, and ideas on recipes and connect with a community of food lovers.\n\n" +
                                        "Join us, share your creativity, and let's make the kitchen a more social place together!";

                // Show the About Us message in a MessageBox
                MessageBox.Show(aboutUsMessage, "About Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loginReal loginreal2 = new loginReal();
            loginreal2.Show();
            this.Hide();
        }

        private void label_welcome_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            the_displaypa.Controls.Clear();
            string recipeText = @"Ingredients:
- 2 cups dried split fava beans
- 1 red onion, quartered
- ½ cup fresh parsley
- ½ cup fresh cilantro
- ½ cup fresh dill
- 3 cloves garlic
- 1 ½ teaspoons ground coriander
- 1 ½ teaspoons salt
- 1 teaspoon ground cumin
- 1 cup sesame seeds (Optional)
- 1 quart vegetable oil for frying, or as needed

Directions:
1. Place fava beans into a large bowl and cover with several inches of water. Let soak, 8 hours to overnight. Drain.
2. Combine soaked fava beans, red onion, parsley, cilantro, dill, garlic, coriander, salt, and cumin in a food processor; process to a dough-like consistency.
3. Heat a skillet over medium heat. Add sesame seeds; cook, stirring occasionally, until toasted, about 5 minutes. Transfer to a large plate.
4. Shape fava bean mixture into about 50 balls. Roll balls in sesame seeds to coat.
5. Fill a large saucepan 1/4 full with oil; heat over medium heat. Fry fava bean balls in batches until golden brown, 3 to 5 minutes per batch. Drain on paper towels.";
            Image selectedImage = Egyptian_falafel.Image;
            backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Falafel from Egypt");
            backForm.SetRecipeImage(selectedImage);

            
            // Make backForm a non-top-level form (so it can be added to the panel)
            backForm.TopLevel = false;

            // Dock the form inside the panel
            backForm.Dock = DockStyle.Fill; // Make it fill the entire panel


            // Add the form to the panel's controls
            the_displaypa.Controls.Add(backForm);

            // Show the form (as a control inside the panel)
            backForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            the_displaypa.Controls.Clear();
            Image selectedImage = Avocado_smoothie.Image;

            string recipeText = @"How to Make Avocado Smoothie
Enjoy a refreshing and nutritious Avocado Smoothie with this simple recipe. Here's how to make it:

1. Gather Your Ingredients
   - 1 ripe avocado, peeled and pitted
   - 1 ripe banana, peeled
   - 1 cup spinach leaves, washed
   - 1 cup milk (dairy or plant-based)
   - 1 tablespoon honey or maple syrup (optional, for sweetness)
   - Ice cubes (optional, for a colder smoothie)

2. Blend the Ingredients
   - In a blender, combine the ripe avocado, banana, spinach leaves, milk, and sweetener (if using).
   - Blend on high speed until the mixture is smooth and creamy. If the smoothie is too thick, you can add more milk to reach your desired consistency.
   - If you prefer a colder smoothie, you can add a handful of ice cubes to the blender and blend until smooth.

3. Serve and Enjoy
   - Pour the avocado smoothie into glasses.
   - Optionally, garnish with a slice of avocado or a sprinkle of cinnamon.
   - Serve immediately and enjoy the refreshing taste of this nutritious avocado smoothie!

This smoothie is packed with vitamins, minerals, and healthy fats from the avocado, making it a great choice for a quick and delicious breakfast or snack.";

            backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Avocado Smoothie");

            backForm.SetRecipeImage(selectedImage);
            // Make backForm a non-top-level form (so it can be added to the panel)
            backForm.TopLevel = false;

            // Dock the form inside the panel
            backForm.Dock = DockStyle.Fill; // Make it fill the entire panel
            

            // Add the form to the panel's controls
            the_displaypa.Controls.Add(backForm);

            // Show the form (as a control inside the panel)
            backForm.Show();


        }

        private void Beethroothsmoothie_Click(object sender, EventArgs e)
        {
            the_displaypa.Controls.Clear();
            Image selectedImage = Beethroothsmoothie.Image;
            string recipeText = @"How to Make Beetroot Smoothie
Treat yourself to a vibrant and nutritious Beetroot Smoothie! Here's a simple recipe to whip up this delicious and healthy beverage:

1. Gather Your Ingredients
   - 1 medium-sized beetroot, peeled and chopped
   - 1 ripe banana, peeled and sliced
   - 1 cup plain yogurt
   - 1/2 cup frozen mixed berries (such as strawberries, blueberries, raspberries)
   - 1 tablespoon honey or maple syrup (optional, for sweetness)
   - 1/2 cup milk (dairy or plant-based)
   - Ice cubes (optional, for extra chill)

2. Blend the Ingredients
   - In a blender, combine the chopped beetroot, sliced banana, plain yogurt, frozen mixed berries, honey or maple syrup (if using), and milk.
   - If desired, add a handful of ice cubes for extra chill.
   - Blend the ingredients until smooth and creamy. If the smoothie is too thick, you can add more milk to reach your desired consistency.

3. Serve and Enjoy
   - Once blended to perfection, pour the Beetroot Smoothie into glasses.
   - Garnish with a few additional berries or a slice of beetroot, if desired.
   - Serve immediately and enjoy the refreshing taste and vibrant color of this nutritious smoothie!

This Beetroot Smoothie is not only delicious but also packed with vitamins, minerals, and antioxidants, making it a fantastic way to start your day or refuel after a workout.";

            backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Beetroot Smoothie");


            backForm.SetRecipeImage(selectedImage);
            // Make backForm a non-top-level form (so it can be added to the panel)
            backForm.TopLevel = false;

            // Dock the form inside the panel
            backForm.Dock = DockStyle.Fill; // Make it fill the entire panel


            // Add the form to the panel's controls
            the_displaypa.Controls.Add(backForm);

            // Show the form (as a control inside the panel)
            backForm.Show();
        }

        private void caesar_salad_Click(object sender, EventArgs e)
        {
            the_displaypa.Controls.Clear();
            Image selectedImage = caesar_salad.Image;
            string recipeText = @"How to Make Caesar Salad
Indulge in the classic flavors of a Caesar Salad with this simple recipe! Follow these steps to create a delicious salad that's perfect as a side dish or a light meal:

1. Prepare the Dressing
   - In a small bowl, combine 1/2 cup mayonnaise, 2 tablespoons grated Parmesan cheese, 1 tablespoon lemon juice, 1 teaspoon Dijon mustard, 1 clove minced garlic, 1/2 teaspoon Worcestershire sauce, and a pinch of salt and pepper.
   - Whisk the ingredients together until well combined and smooth. Taste and adjust the seasoning as needed. Set the dressing aside.

2. Prepare the Croutons
   - Preheat your oven to 375°F (190°C). 
   - Cut 2 slices of bread into cubes and toss them with 2 tablespoons of olive oil, 1/2 teaspoon garlic powder, 1/2 teaspoon dried Italian seasoning, and a pinch of salt and pepper.
   - Spread the seasoned bread cubes in a single layer on a baking sheet and bake for 10-15 minutes, or until golden and crispy. Remove from the oven and set aside to cool.

3. Assemble the Salad
   - In a large salad bowl, combine torn Romaine lettuce leaves, the prepared croutons, and additional grated Parmesan cheese (if desired).
   - Pour the prepared Caesar dressing over the salad ingredients, using as much or as little as you prefer.
   - Toss the salad gently until the lettuce leaves are evenly coated with the dressing and the croutons are distributed throughout.

4. Garnish and Serve
   - Optionally, garnish the Caesar Salad with additional Parmesan cheese shavings and freshly ground black pepper.
   - Serve the salad immediately as a side dish or add grilled chicken or shrimp to turn it into a satisfying main course.

Enjoy the classic combination of crisp lettuce, crunchy croutons, savory dressing, and tangy Parmesan cheese in every bite of this delicious Caesar Salad!";

            backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Cesar Salad");

            backForm.SetRecipeImage(selectedImage);

           
            // Make backForm a non-top-level form (so it can be added to the panel)
            backForm.TopLevel = false;

            // Dock the form inside the panel
            backForm.Dock = DockStyle.Fill; // Make it fill the entire panel


            // Add the form to the panel's controls
            the_displaypa.Controls.Add(backForm);

            // Show the form (as a control inside the panel)
            backForm.Show();
        }

        private void eIced_coffee_Click(object sender, EventArgs e)
        {
            the_displaypa.Controls.Clear();
            Image selectedImage = eIced_coffee.Image;
            string recipeText = @"How to Make Caramel Iced Coffee
Indulge in the rich and creamy goodness of Caramel Iced Coffee with this easy recipe. Here's how to make it:

Brew the Coffee
1. Start by brewing your favorite coffee. You can use a coffee maker, French press, or any other preferred method. Brew a strong batch of coffee and let it cool to room temperature.

Prepare the Caramel Sauce
2. In a small saucepan, combine 1/2 cup of granulated sugar and 2 tablespoons of water. Heat over medium-high heat, stirring constantly, until the sugar dissolves.

3. Once the sugar has dissolved, stop stirring and allow the mixture to come to a boil. Let it boil undisturbed until it turns a deep amber color, about 5-7 minutes.

4. Remove the saucepan from the heat and carefully add 1/2 cup of heavy cream. Be cautious as the mixture will bubble up vigorously.

5. Stir the caramel sauce until smooth and well combined. Set aside to cool.

Assemble the Caramel Iced Coffee
6. Fill a glass with ice cubes. Pour the brewed coffee over the ice until the glass is about 3/4 full.

7. Add 2-3 tablespoons of the prepared caramel sauce to the coffee, depending on your desired sweetness level. Stir well to combine.

8. Top the caramel iced coffee with a splash of milk or cream, if desired.

9. Garnish with whipped cream and an additional drizzle of caramel sauce for extra indulgence.

10. Insert a straw, give it a final stir, and enjoy your refreshing Caramel Iced Coffee!

This delightful beverage is perfect for satisfying your coffee cravings on a hot summer day.";

            backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Caramel Iced Coffee");

            backForm.SetRecipeImage(selectedImage);
            // Make backForm a non-top-level form (so it can be added to the panel)
            backForm.TopLevel = false;

            // Dock the form inside the panel
            backForm.Dock = DockStyle.Fill; // Make it fill the entire panel


            // Add the form to the panel's controls
            the_displaypa.Controls.Add(backForm);

            // Show the form (as a control inside the panel)
            backForm.Show();
        }

        private void toffu_and_veggie_filling_Click(object sender, EventArgs e)
        {
            the_displaypa.Controls.Clear();
            Image selectedImage = toffu_and_veggie_filling.Image;

            string recipeText = @"How to Make Japanese Gyoza
Gyoza, also known as Japanese potstickers, are delicious dumplings filled with a savory mixture of pork and vegetables. Here's how to make them:

Prepare the Filling
1. In a large mixing bowl, combine 1 pound ground pork, 2 cups finely shredded cabbage, 2 cloves minced garlic, 1 tablespoon minced ginger, 2 green onions (finely chopped), 1 tablespoon soy sauce, 1 tablespoon sesame oil, 1 teaspoon sugar, and 1/4 teaspoon black pepper. Mix until well combined.

Assemble the Gyoza
2. Take a gyoza wrapper and place a spoonful of the filling mixture in the center.
3. Moisten the edges of the wrapper with water.
4. Fold the wrapper in half and pinch the edges together to seal, creating a half-moon shape. Pleat the edges if desired for a decorative touch.

Cook the Gyoza
5. Heat a non-stick skillet over medium-high heat and add 1 tablespoon of vegetable oil.
6. Once the oil is hot, add the gyoza to the skillet in a single layer, flat side down.
7. Cook until the bottoms are golden brown, about 2-3 minutes.
8. Carefully add 1/4 cup of water to the skillet and immediately cover with a lid.
9. Steam the gyoza for 5-6 minutes, or until the filling is cooked through and the wrappers are translucent.

Serve and Enjoy
10. Remove the lid and let the remaining water evaporate.
11. Use a spatula to transfer the gyoza to a serving plate, crispy side up.
12. Serve hot with dipping sauce (soy sauce mixed with rice vinegar and a dash of sesame oil), and enjoy your homemade Japanese gyoza!

These gyoza make a perfect appetizer or snack for any occasion.";

            backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Gyoza from Japan");

            backForm.SetRecipeImage(selectedImage);
            // Dock the form inside the panel
            backForm.Dock = DockStyle.Fill; // Make it fill the entire panel


            // Add the form to the panel's controls
            the_displaypa.Controls.Add(backForm);

            // Show the form (as a control inside the panel)
            backForm.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            
            New_mainpage new_Mainpage = new New_mainpage();
            new_Mainpage.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void the_displaypa_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using HomeFood._588286;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFood
{
    public partial class MainRezeptForm : Form
    {
        BackForm backForm = new BackForm();

        public string Description;
        public string Ingredients;
        public string Cuisine;
        public string Notes;
        public string Instructions;
        public string Nutrition;
        public MainRezeptForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal; // Ensure the form starts in the normal state
        }

        private void MainRezeptForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void MainRezeptForm_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

            Image selectedImage = picBoxKoshary.Image;
            backForm.SetRecipeName("Koshary from Egypt");

            string recipeText = @"Ingredients:
- Yellow Onions
- All-Purpose Flour
- Vegetable Oil
- Basmati Rice
- Lentils
- Baharat Spice Blend
- Elbow Macaroni
- Tomato Passata
- Chickpeas
- Garlic
- Red Wine Vinegar
- Fresh Parsley
- Shatta Sauce
- Garlic Sauce (Toum)

   1.Make the Crispy Onions. Place a large, deep-sided skillet over medium-high heat and add your vegetable oil. Toss the thinly sliced onions with flour in a large bowl, then fry the onions until they become dark golden brown. Work in batches for best results and allow them to drain on a paper towel-lined plate.
 

  2. Make the Rice. After rinsing the rice, bring a saucepan of salted water to a boil. Add the rice and 1 tablespoon of baharat spice blend, stir, and cover. Lower the heat and allow the rice to cook for 18 minutes, then set aside.

  3. Cook the Lentils. In a separate saucepan, bring salted water to boil with a teaspoon of baharat spice blend. Pour in the lentils and cook uncovered for 20 minutes. Drain and set aside.

  4.  Make the Macaroni. Boil the elbow pasta in salted water for 10 minutes, then drain and set aside.

  5. Prepare the Sauce. Place a saucepan over medium heat and add the oil. Sauté the garlic for 1 minute, then pour in the tomato passata, salt, remaining baharat spice blend, and cooked chickpeas. Lower the heat and allow the sauce to simmer for 10 minutes (partially covered). Stir in the red wine vinegar and parsley and set aside.

  6.  Assemble. To layer your koshari as pictured, place half of the crispy onions on the bottom of the bowl. Then, add the tomato and chickpea mixture, cooked macaroni, lentils, and rice — in that order. Gently press down with a spatula to ensure that the layers remain intact when flipped.

  7. Flip the Bowl. Place a large plate or platter on top of the bowl and carefully (and confidently!) flip the bowl away from you so that the platter is on the bottom and the bowl is upside down. Your koshari should release itself on its own. Top with more crispy onions and chopped parsley, then serve with shatta and toum sauces.";

            backForm.DisplayRecipe(recipeText);
            
            backForm.SetRecipeImage(selectedImage); 
            this.Hide();
            backForm.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Image selectedImage = picBoxMusaka.Image;
            string recipeText = @"How to Make Egyptian Moussaka
The first step is to get the eggplant salted, which forces out its water and gives it a better flavor and texture. From there, get your veggies prepped, get the eggplant softening, sauce going, layer, and bake. Here are the steps:

Soften the Eggplant
1. Position a rack in the middle of the oven and heat to 400°F. Lightly oil a sheet pan.
2. Trim off the tops of 3 eggplants and slice each eggplant into ¼-inch rounds. Season the slices generously with salt and spread them in one single layer on a clean surface (like a baking tray or wire rack). Set aside for a few minutes while you prepare the remaining ingredients.
3. Coarsely chop 1 onion. Core, seed, and coarsely chop 2 green bell peppers. Mince 3 to 4 garlic cloves.
4. Bake the eggplant. Use a paper towel to dry the eggplant well on both sides, removing any excess salt, then brush each slice generously with extra virgin olive oil. Arrange them without overlapping on the prepared sheet pan. Bake on the center rack of your heated oven for about 20 minutes, or until they begin to soften (they should not be fully cooked yet).

Make the Sauce
5. In a large skillet over medium-high heat, heat about 2 tablespoons olive oil until shimmering. Add the onions, bell peppers, and garlic and season with a big pinch of salt. Cook the vegetables, tossing regularly, until they soften a bit, about 5 minutes.
6. Add 1 pound lean ground beef and use a wooden spoon to break the meat up. Cook until fully browned, about 7 to 10 minutes.
7. Add 1 teaspoon coriander, ½ teaspoon paprika, ½ teaspoon red pepper flakes or Aleppo pepper, and a big pinch of pepper and stir to combine.
8. Add one (28-ounce) can whole San Marzano tomatoes and their juices and ⅓ cup of water. Bring the sauce to a boil, then lower the heat and let it simmer while the eggplant finishes baking. Remove from the heat, taste, and add more salt to your liking.

Layer and Bake
9. Prepare a 9 x 13 baking dish and lightly oil the bottom. Arrange half of the partially baked eggplant on the bottom and top with half of the sauce. Layer the remaining eggplant on top and cover it with the sauce. Drizzle with a little olive oil.
10. Transfer the baking dish to the heated oven and bake for about 20 minutes. Then transfer to the broiler for just a few minutes until it gains some color.

Garnish and Serve
11. Remove from heat and finish with ¼ cup nuts (or sliced almonds) and ½ cup chopped fresh parsley. Serve hot or warm, with pita bread or rice if you’d like.";

            backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Musaka from Egypt");

            backForm.SetRecipeImage(selectedImage);
            this.Hide();
            backForm.ShowDialog();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Veg_Click(object sender, EventArgs e)
        {

        }

        private void MeatMain_Click(object sender, EventArgs e)
        {

        }

        private void Drinks_Click(object sender, EventArgs e)
        {

        }

        private void Salad_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Salad_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

            //// Maximize the form
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            // Minimize the form
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

            Image selectedImage = picBoxMushroomSalad.Image;


            string recipeText = @"Mushroom Salad Recipe

Ingredients:
- 8 oz (225g) mushrooms, thinly sliced
- 2 tablespoons olive oil
- 2 cloves garlic, minced
- 1 tablespoon balsamic vinegar
- Salt and pepper to taste
- 4 cups mixed salad greens (lettuce, spinach, arugula, etc.)
- 1/4 cup cherry tomatoes, halved
- 1/4 cup red onion, thinly sliced
- 1/4 cup crumbled goat cheese
- 2 tablespoons chopped fresh parsley

Instructions:
1. Heat the olive oil in a skillet over medium heat. Add the sliced mushrooms and minced garlic. Cook, stirring occasionally, until the mushrooms are golden brown and tender, about 5-7 minutes.
2. Remove the skillet from heat and stir in the balsamic vinegar. Season with salt and pepper to taste. Allow the mushrooms to cool slightly.
3. In a large salad bowl, combine the mixed greens, cherry tomatoes, red onion, and crumbled goat cheese.
4. Add the cooked mushrooms to the salad and toss gently to combine.
5. Sprinkle the chopped parsley over the salad.
6. Serve immediately as a side dish or light meal, or chill in the refrigerator for a few hours before serving for a cool summer salad.

Enjoy this flavorful Mushroom Salad as a delicious addition to your meal!";

    backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Mushroom Salad"); // Set the recipe name on the label
            backForm.SetRecipeImage(selectedImage); // Pass the selected image to BackFor
            this.Hide();
            backForm.ShowDialog();
            



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
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
            Image selectedImage = picBoxFalafel.Image;
            backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Falafel from Egypt");
            backForm.SetRecipeImage(selectedImage);
            this.Hide();
            backForm.ShowDialog();
        }

        private void picBoxGyoza_Click(object sender, EventArgs e)
        {
            Image selectedImage = picBoxGyoza.Image;

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
            this.Hide();
            backForm.ShowDialog();
        }

        private void picBoxChickenCurry_Click(object sender, EventArgs e)
        {
            Image selectedImage = picBoxChickenCurry.Image;
            string recipeText = @"How to Make Chicken Curry
Chicken curry is a flavorful dish made with tender chicken pieces cooked in a rich and aromatic sauce. Here's how to prepare it:

Marinate the Chicken
1. In a bowl, combine 1 pound of chicken pieces with 1/2 cup of plain yogurt, 1 tablespoon of lemon juice, 1 teaspoon of ground turmeric, 1 teaspoon of ground cumin, 1 teaspoon of ground coriander, 1/2 teaspoon of chili powder, 1/2 teaspoon of paprika, 1/2 teaspoon of ground cinnamon, 1/2 teaspoon of ground cardamom, 1/2 teaspoon of ground cloves, 1/2 teaspoon of ground nutmeg, 1 tablespoon of grated fresh ginger, and 3 cloves of minced garlic. Mix well to coat the chicken evenly. Cover and refrigerate for at least 1 hour, or overnight for best results.

Cook the Curry
2. Heat 2 tablespoons of vegetable oil in a large skillet or saucepan over medium heat. Add 1 diced onion and cook until softened, about 5 minutes.
3. Add the marinated chicken pieces to the skillet, along with any remaining marinade. Cook until the chicken is browned on all sides, about 5-7 minutes.
4. Stir in 1 cup of tomato puree and 1/2 cup of coconut milk. Bring to a simmer.
5. Reduce the heat to low, cover, and let the curry simmer gently for 20-25 minutes, or until the chicken is cooked through and tender.

Serve and Enjoy
6. Garnish the chicken curry with fresh cilantro leaves and serve hot with steamed rice or naan bread. Enjoy your delicious homemade chicken curry!

This aromatic and flavorful chicken curry is sure to become a favorite in your household.";

            backForm.DisplayRecipe(recipeText);
            
            backForm.SetRecipeName("Chicken Curry");

            backForm.SetRecipeImage(selectedImage);
            this.Hide();
            backForm.ShowDialog();
        }

        private void picBoxCaramelIcedCoffee_Click(object sender, EventArgs e)
        {
            Image selectedImage = picBoxCaramelIcedCoffee.Image;
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
            this.Hide();
            backForm.ShowDialog();
        }

        private void picBoxAvocadoSmoothie_Click(object sender, EventArgs e)
        {
            Image selectedImage = picBoxAvocadoSmoothie.Image;

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
            this.Hide();
            backForm.ShowDialog();
        }

        private void picBoxHibiscusIceTea_Click(object sender, EventArgs e)
        {
            Image selectedImage = picBoxHibiscusIceTea.Image;
            string recipeText = @"How to Make Hibiscus Ice Tea
Cool down with a refreshing Hibiscus Ice Tea, a delightful beverage originating from Cameroon. Here's how to make it:

1. Gather Your Ingredients
   - 1 cup dried hibiscus flowers (also known as sorrel or hibiscus sabdariffa)
   - 4 cups water
   - Sugar or honey (optional, for sweetening)
   - Fresh mint leaves (optional, for garnish)
   - Lemon slices (optional, for garnish)
   - Ice cubes

2. Steep the Hibiscus Flowers
   - In a saucepan, bring 4 cups of water to a boil.
   - Add the dried hibiscus flowers to the boiling water and remove the saucepan from the heat.
   - Let the flowers steep in the hot water for about 15-20 minutes to infuse the water with flavor.

3. Strain and Sweeten
   - After steeping, strain the hibiscus tea into a pitcher or container to remove the flowers.
   - If desired, sweeten the tea with sugar or honey to taste while it's still warm. Stir until the sweetener is fully dissolved.

4. Chill and Serve
   - Allow the hibiscus tea to cool to room temperature, then refrigerate it until thoroughly chilled.
   - Once chilled, pour the tea over ice cubes in glasses.
   - Garnish each glass with a sprig of fresh mint and a slice of lemon, if desired.
   - Serve your refreshing Hibiscus Ice Tea cold and enjoy its vibrant color and tangy flavor!

This Hibiscus Ice Tea is not only delicious but also packed with antioxidants and nutrients, making it a healthy and refreshing beverage choice.";

            backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Hibiscus Ice Tea");

            backForm.SetRecipeImage(selectedImage);
            this.Hide();
            backForm.ShowDialog();
        }

        private void picBoxBeetrootSmoothie_Click(object sender, EventArgs e)
        {
            Image selectedImage = picBoxBeetrootSmoothie.Image;
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
            this.Hide();
            backForm.ShowDialog();
        }

        private void picBoxCesarSalad_Click(object sender, EventArgs e)
        {
            Image selectedImage = picBoxCesarSalad.Image;
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
            this.Hide();
            backForm.ShowDialog();
        }

        private void picBoxGrilledGoatCheese_Click(object sender, EventArgs e)
        {
            Image selectedImage = picBoxGrilledGoatCheese.Image;
            string recipeText = @"How to Make Grilled Goat Cheese
Impress your guests with this delightful Grilled Goat Cheese recipe. Follow these simple steps to create a delicious appetizer or snack:

1. Prepare the Goat Cheese
   - Cut a goat cheese log into slices, about 1/2 inch thick. You can adjust the thickness based on your preference.
   - Place the slices on a plate and let them come to room temperature for about 15 minutes.

2. Prepare the Grill
   - Preheat your grill to medium-high heat (around 400°F / 200°C). Make sure the grates are clean and lightly oiled to prevent sticking.

3. Grill the Goat Cheese
   - Carefully place the slices of goat cheese directly onto the grill grates.
   - Grill for 1-2 minutes per side, or until grill marks form and the cheese softens slightly. Be gentle when flipping to prevent the cheese from falling apart.
   - Remove the grilled goat cheese slices from the grill and transfer them to a serving platter.

4. Serve and Enjoy
   - Serve the grilled goat cheese slices immediately while they're still warm and soft.
   - You can garnish them with a drizzle of honey, a sprinkle of chopped herbs like thyme or rosemary, or a handful of toasted nuts for extra flavor.
   - Enjoy the creamy, tangy goodness of grilled goat cheese as a standalone appetizer or pair it with your favorite crackers, bread, or fresh fruit.

Whether you're hosting a gathering or simply craving a tasty snack, grilled goat cheese is sure to be a hit. Enjoy the irresistible combination of warm, gooey cheese and smoky grill flavor in every bite!";

            backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Grilled Goat Cheese");

            backForm.SetRecipeImage(selectedImage);
            this.Hide();
            backForm.ShowDialog();
        }

        private void picBoxSalmonAvocadoSalad_Click(object sender, EventArgs e)
        {
            Image selectedImage = picBoxSalmonAvocadoSalad.Image;
            string recipeText = @"Salmon Avocado Salad Recipe

Ingredients:
- 8 oz (225g) salmon fillet
- 2 avocados, sliced
- 4 cups mixed salad greens (lettuce, spinach, arugula, etc.)
- 1 cucumber, sliced
- 1/4 cup cherry tomatoes, halved
- 1/4 cup red onion, thinly sliced
- 1/4 cup feta cheese, crumbled
- 2 tablespoons olive oil
- 1 tablespoon lemon juice
- Salt and pepper to taste

Instructions:
1. Preheat your grill or skillet over medium-high heat. Season the salmon fillet with salt and pepper.
2. Cook the salmon for 4-5 minutes on each side, or until cooked through and flaky. Remove from heat and let it cool slightly.
3. In a large salad bowl, combine the mixed greens, sliced avocado, cucumber, cherry tomatoes, red onion, and crumbled feta cheese.
4. Break the cooked salmon into bite-sized pieces and add it to the salad.
5. In a small bowl, whisk together the olive oil, lemon juice, salt, and pepper to make the dressing.
6. Drizzle the dressing over the salad and toss gently to combine.
7. Serve immediately as a light and refreshing meal, or chill in the refrigerator for a few hours before serving for a cool summer salad.

Enjoy this delicious and nutritious Salmon Avocado Salad as a healthy lunch or dinner option!";

    backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Salmon Avocado Salad");
            

            backForm.SetRecipeImage(selectedImage);
            this.Hide();
            backForm.ShowDialog();
        }

        private void picBoxKalmiKebab_Click(object sender, EventArgs e)
        {
            Image selectedImage = picBoxKalmiKebab.Image;
            string recipeText = @"How to Make Kalmi Kebab
Kalmi Kebab is a popular Indian dish made with marinated chicken drumsticks roasted or grilled to perfection. Here's how to prepare it:

Marinate the Chicken
1. In a large mixing bowl, combine 2 cups of plain yogurt, 2 tablespoons of ginger-garlic paste, 1 tablespoon of lime juice, 1 teaspoon of garam masala, 1 teaspoon of chili powder, 1 teaspoon of ground coriander, 1 teaspoon of ground cumin, 1/2 teaspoon of turmeric powder, and salt to taste. Mix well to form a smooth marinade.

2. Add 6-8 chicken drumsticks to the marinade, making sure they are well coated. Cover the bowl and refrigerate for at least 4 hours, or preferably overnight, to allow the flavors to penetrate the chicken.

Preheat the Oven or Grill
3. Preheat your oven to 400°F (200°C) or prepare your grill for medium-high heat.

Cook the Kebabs
4. If using an oven, arrange the marinated chicken drumsticks on a baking tray lined with aluminum foil. Bake in the preheated oven for 25-30 minutes, turning halfway through, or until the chicken is cooked through and golden brown.

5. If using a grill, lightly oil the grill grates and arrange the marinated chicken drumsticks on the grill. Cook for 15-20 minutes, turning occasionally, until the chicken is cooked through and has grill marks on all sides.

Serve and Enjoy
6. Once cooked, transfer the Kalmi Kebabs to a serving platter. Garnish with chopped cilantro and serve hot with mint chutney, sliced onions, and lemon wedges on the side.

These tender and flavorful Kalmi Kebabs are perfect for serving as an appetizer or as part of a main course in a traditional Indian meal.";

            backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Kalmi Kebab");

            backForm.SetRecipeImage(selectedImage);
            this.Hide();
            backForm.ShowDialog();
        }

        private void picBoxCeviche_Click(object sender, EventArgs e)
        {
            Image selectedImage = picBoxCeviche.Image;

            string recipeText = @"How to Make Peruvian Ceviche
Ceviche is a popular Peruvian dish made with raw fish cured in citrus juices and seasoned with onions, chili peppers, and cilantro. Here's how to prepare it:

Prepare the Fish
1. Start with fresh, high-quality white fish fillets such as sea bass, sole, or halibut. Cut the fish into bite-sized pieces and place them in a large mixing bowl.

Marinate in Citrus Juice
2. Squeeze enough fresh lime juice to completely cover the fish pieces. Make sure the fish is submerged in the lime juice. Let the fish marinate in the lime juice for about 15-20 minutes. The citric acid in the lime juice will effectively 'cook' the fish by denaturing the proteins.

Add Flavorful Ingredients
3. While the fish is marinating, finely chop 1 red onion, 1-2 jalapeño or serrano peppers (seeded for less heat if desired), and a handful of fresh cilantro leaves. Add these ingredients to the bowl with the marinated fish.

Season to Taste
4. Season the ceviche with salt and pepper to taste. You can also add additional flavorings such as minced garlic or grated ginger for extra depth of flavor.

Chill and Serve
5. Once the fish is 'cooked' and flavored with the citrus juices and seasonings, cover the bowl with plastic wrap and refrigerate for at least 30 minutes to allow the flavors to meld together.

Garnish and Enjoy
6. Before serving, taste the ceviche and adjust the seasoning if necessary. Serve the ceviche cold, garnished with additional cilantro leaves and slices of lime. Enjoy your refreshing and flavorful Peruvian ceviche!

This refreshing and zesty Peruvian ceviche is perfect as an appetizer or light meal, especially on a hot summer day.";

            backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Peruvian Ceviche");
            
            backForm.SetRecipeImage(selectedImage);
            this.Hide();
            backForm.ShowDialog();
        }

       

        private void picBoxKofta_Click_1(object sender, EventArgs e)
        {
            Image selectedImage = picBoxKofta.Image;
            string recipeText = @"How to Make Egyptian Kofta
Kofta is a delicious Egyptian dish made with seasoned ground meat, typically beef or lamb, mixed with onions and spices, then grilled or baked. Here's how to prepare it:

Prepare the Kofta Mixture
1. In a large mixing bowl, combine 1 pound of ground beef or lamb with 1 finely chopped onion, 2 minced garlic cloves, 1/4 cup of chopped fresh parsley, 1/4 cup of chopped fresh cilantro, 1 teaspoon of ground cumin, 1 teaspoon of ground coriander, 1/2 teaspoon of paprika, 1/2 teaspoon of ground cinnamon, 1/4 teaspoon of cayenne pepper, and salt and pepper to taste. Mix well to combine.

Form the Kofta
2. Take small portions of the kofta mixture and shape them into elongated meatballs or sausage shapes, about 2 inches long and 1 inch thick. Thread the shaped kofta onto skewers if grilling.

Grill or Bake the Kofta
3. If grilling, preheat your grill to medium-high heat. Grill the kofta skewers for 10-12 minutes, turning occasionally, until cooked through and lightly charred.
   If baking, preheat your oven to 400°F (200°C). Place the shaped kofta on a baking sheet lined with parchment paper. Bake for 20-25 minutes, or until cooked through and browned.

Serve and Enjoy
4. Once cooked, remove the kofta from the grill or oven. Serve hot with rice, flatbread, or a salad, and your favorite dipping sauce or yogurt tzatziki. Enjoy your delicious Egyptian kofta!

This flavorful and aromatic Egyptian kofta is perfect for a family dinner or gathering with friends.";

            backForm.DisplayRecipe(recipeText);
            backForm.SetRecipeName("Egyptian Kofta");
            backForm.SetRecipeImage(selectedImage);
            this.Hide();
            backForm.ShowDialog();
        }

        private void btnSearchRecipe_Click(object sender, EventArgs e)
        {
            rezeptsuchen_und_filtern form1 = new rezeptsuchen_und_filtern();
            form1.Show();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            Rezepte_hinzufügen rezepte_Hinzufügen = new Rezepte_hinzufügen();
            rezepte_Hinzufügen.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void messagebutton_Click(object sender, EventArgs e)
        {
            communication communication = new communication();
            communication.Show();
        }
    }
}

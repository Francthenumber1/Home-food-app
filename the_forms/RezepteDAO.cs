using MySql.Data.MySqlClient; // This imports MySQL client library, allowing connection to MySQL databases.
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace HomeFood
{
    // Data Access Object (DAO) class for handling database operations related to the "Rezepten" (recipes) table.
    internal class RezeptenDAO
    {
        // Connection string for connecting to the MySQL database.
        string connectionString = "datasource=localhost;port=3306;username=root;password=Aubin1234.;database=food_for_home;";

        // Method to retrieve all recipes from the database.
        public List<Rezepten> getAllRezept()
        {
            List<Rezepten> returnThese = new List<Rezepten>(); // List to hold the recipes.

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open(); // Open connection to database.

                // SQL command to select all records from the 'rezept' table.
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM rezept", connection))
                using (MySqlDataReader reader = command.ExecuteReader()) // Execute query and get result.
                {
                    while (reader.Read()) // Loop through all rows in the result.
                    {
                        // Create a new Rezepten object and fill it with data from the current row.
                        Rezepten rezept = new Rezepten
                        {
                            Rezept_ID = reader.GetInt32("REZEPT_ID"),
                            Image_Description = reader.GetString("IMAGE_DESCRIPTION"),
                            RezeptName = reader.GetString("REZEPT_NAME"),
                            Portionen = reader.GetInt32("Portionen"),
                            Naehrwerte = reader.GetString("Naerwerte"),
                            RezeptType = reader.GetString("REZEPT_TYPE"),
                            Dietarypreferences = reader.GetString("DIETARY_PREFERENCE"),
                            Anweisungen = reader.GetString("ANWEISUNGEN")
                        };

                        try
                        {
                            // Try to load the image from a URL or file path.
                            if (Uri.IsWellFormedUriString(rezept.Image_Description, UriKind.Absolute))
                            {
                                rezept.Image = Image.FromStream(new System.Net.WebClient().OpenRead(rezept.Image_Description));
                            }
                            else if (File.Exists(rezept.Image_Description))
                            {
                                rezept.Image = Image.FromFile(rezept.Image_Description);
                            }
                            else
                            {
                                throw new Exception("Invalid image description path.");
                            }
                        }
                        catch (Exception)
                        {
                            // If loading the image fails, create a placeholder image with a red 'X'.
                            rezept.Image = new Bitmap(100, 100); // Create a blank 100x100 image.
                            using (Graphics g = Graphics.FromImage(rezept.Image))
                            {
                                g.Clear(Color.Blue); // Set background to white.
                                Pen pen = new Pen(Color.Red, 5); // Red pen for the 'X'.
                                g.DrawLine(pen, new Point(0, 0), new Point(100, 100)); // Draw diagonal line.
                                g.DrawLine(pen, new Point(100, 0), new Point(0, 100)); // Draw other diagonal line.
                            }
                        }

                        returnThese.Add(rezept); // Add the recipe to the list.
                    }
                }
            }
            return returnThese; // Return the list of recipes.
        }

        // Method to search for recipes by their name using a search term.
        public List<Rezepten> searchRezept(string searchTerm)
        {
            List<Rezepten> returnThese = new List<Rezepten>();
            string searchWildPhrase = "%" + searchTerm + "%"; // Wildcard search phrase for SQL LIKE.

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM REZEPT WHERE REZEPT_NAME LIKE @search", connection))
                {
                    command.Parameters.AddWithValue("@search", searchWildPhrase); // Add the search term as a parameter.

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) // Loop through search results.
                        {
                            Rezepten rezept = new Rezepten
                            {
                                RezeptName = reader.GetString("REZEPT_NAME"),
                                Portionen = reader.GetInt32("Portionen"),
                                Naehrwerte = reader.GetString("Naerwerte"),
                                RezeptType = reader.GetString("REZEPT_TYPE"),
                                Dietarypreferences = reader.GetString("DIETARY_PREFERENCE"),
                                Anweisungen = reader.GetString("ANWEISUNGEN"),
                                Image_Description = reader.GetString("IMAGE_DESCRIPTION")
                            };
                            returnThese.Add(rezept); // Add each recipe to the result list.
                        }
                    }
                }
            }
            return returnThese; // Return the list of recipes matching the search term.
        }

        // Method to retrieve detailed information about a specific recipe based on its ID.
        public Rezepten getRezeptDetails(int rezeptId)
        {
            Rezepten rezept = null; // Initialize the recipe object to null.

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(@"
                    SELECT 
                        r.REZEPT_ID, r.REZEPT_NAME, r.portionen, r.Naehrwerte, r.REZEPT_TYPE, r.DIETARY_PREFERENCE, r.ANWEISUNGEN, r.IMAGE_DESCRIPTION, 
                        z.ZUTAT_NAME, z.KALORIEN_PRO_100G, z.Kohlenhydrate, z.Proteine, z.Fette
                    FROM 
                        REZEPT r
                    JOIN 
                        REZEPT_ZUTAT rz ON r.REZEPT_ID = rz.REZEPT_ID
                    JOIN 
                        ZUTAT z ON rz.ZUTAT_ID = z.ZUTAT_ID
                    WHERE 
                        r.REZEPT_ID = @rezeptId", connection))
                {
                    command.Parameters.AddWithValue("@rezeptId", rezeptId); // Add recipe ID parameter.

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) // Read through the result set.
                        {
                            if (rezept == null) // Initialize the recipe object if not already done.
                            {
                                rezept = new Rezepten
                                {
                                    RezeptName = reader.GetString("REZEPT_NAME"),
                                    Portionen = reader.GetInt32("Portionen"),
                                    Naehrwerte = reader.GetString("Naehrwerte"),
                                    RezeptType = reader.GetString("REZEPT_TYPE"),
                                    Dietarypreferences = reader.GetString("DIETARY_PREFERENCE"),
                                    Anweisungen = reader.GetString("ANWEISUNGEN"),
                                    Image_Description = reader.GetString("IMAGE_DESCRIPTION")
                                };
                            }
                            // Add ingredient (Zutat) details to the recipe.
                            Zutat zutat = new Zutat
                            {
                                Zutat_Name = reader.GetString("ZUTAT_NAME"),
                                Kalorien_pro_100g = reader.GetInt32("KALORIEN_PRO_100G"),
                                Kohlenhydrate = reader.GetInt32("Kohlenhydrate"),
                                Proteine = reader.GetInt32("Proteine"),
                                Fette = reader.GetInt32("Fette")
                            };
                            rezept.Zutaten.Add(zutat); // Add each ingredient to the recipe's ingredients list.
                        }
                    }
                }
            }
            return rezept; // Return the recipe with all its details.
        }

        // Method to add a new recipe to the database.
        internal int addonerezept(Rezepten rezepten)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO `REZEPT` (`REZEPT_NAME`, `PORTIONEN`, `NAERWERTE`, `REZEPT_TYPE`, `DIETARY_PREFERENCE`, `ANWEISUNGEN`, `IMAGE_DESCRIPTION`) " +
                    "VALUES (@Rezept_name, @Portionen, @Naerwerte, @Rezept_type, @Dietary_Preferences, @Anweisungen, @Image_Description)", connection);

                // Set the parameters for the SQL query.
                command.Parameters.AddWithValue("@Rezept_name", rezepten.RezeptName);
                command.Parameters.AddWithValue("@Portionen", rezepten.Portionen);
                command.Parameters.AddWithValue("@Naerwerte", rezepten.Naehrwerte);
                command.Parameters.AddWithValue("@Rezept_type", rezepten.RezeptType);
                command.Parameters.AddWithValue("@Dietary_Preferences", rezepten.Dietarypreferences);
                command.Parameters.AddWithValue("@Anweisungen", rezepten.Anweisungen);
                command.Parameters.AddWithValue("@Image_Description", rezepten.Image_Description);

                int result = command.ExecuteNonQuery(); // Execute the INSERT query.
                connection.Close();

                return result; // Return the number of rows affected.
            }
        }

        // Method to add a new ingredient (Zutat) to the database.
        internal int AddZutat(Zutat zutat)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO `ZUTAT` (`ZUTAT_NAME`, `KALORIEN_PRO_100G`, `Kohlenhydrate`, `Proteine`, `Fette`) VALUES (@Zutat_name, @Kalorien_pro_100g, @Kohlenhydrate, @Proteine, @Fette)", connection);

                // Set the parameters for the SQL query.
                command.Parameters.AddWithValue("@Zutat_name", zutat.Zutat_Name);
                command.Parameters.AddWithValue("@Kalorien_pro_100g", zutat.Kalorien_pro_100g);
                command.Parameters.AddWithValue("@Kohlenhydrate", zutat.Kohlenhydrate);
                command.Parameters.AddWithValue("@Proteine", zutat.Proteine);
                command.Parameters.AddWithValue("@Fette", zutat.Fette);

                command.ExecuteNonQuery(); // Execute the INSERT query.
                int zutatId = (int)command.LastInsertedId; // Get the ID of the newly inserted ingredient.
                connection.Close();

                return zutatId; // Return the ingredient's ID.
            }
        }

        // Method to get the last inserted recipe ID from the database.
        internal int GetLastInsertedRezeptId()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT LAST_INSERT_ID()", connection);
                int rezeptId = Convert.ToInt32(command.ExecuteScalar()); // Get the last inserted ID.
                connection.Close();

                return rezeptId; // Return the last inserted recipe ID.
            }
        }

        // Method to link a recipe with an ingredient in the REZEPT_ZUTAT table.
        internal void LinkRezeptZutat(int rezeptId, int zutatId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `REZEPT_ZUTAT` (`REZEPT_ID`, `ZUTAT_ID`) VALUES (@RezeptId, @ZutatId)", connection);

                // Set the parameters for the SQL query.
                command.Parameters.AddWithValue("@RezeptId", rezeptId);
                command.Parameters.AddWithValue("@ZutatId", zutatId);

                command.ExecuteNonQuery(); // Execute the INSERT query.
                connection.Close();
            }
        }

        // Method to delete a recipe from the database based on its ID.
        internal int deleteRezept(int rezeptId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM `rezept` WHERE `REZEPT_ID` = @rezeptId", connection))
                    {
                        command.Parameters.AddWithValue("@rezeptId", rezeptId); // Set the recipe ID to delete.
                        int result = command.ExecuteNonQuery(); // Execute the DELETE query.
                        return result; // Return the number of rows affected.
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL-specific exceptions (e.g., logging the error).
                Console.WriteLine($"MySQL Error: {ex.Message}");
                return -1; // Return -1 to indicate failure.
            }
            catch (Exception ex)
            {
                // Handle general exceptions.
                Console.WriteLine($"General Error: {ex.Message}");
                return -1; // Return -1 to indicate failure.
            }
        }

        // Method to update an existing recipe in the database.
        internal int updateRezept(Rezepten rezept)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(
                        "UPDATE `rezept` SET `REZEPT_NAME` = @RezeptName, `PORTIONEN` = @Portionen, `NAERWERTE` = @Naehrwerte, `REZEPT_TYPE` = @RezeptType, " +
                        "`DIETARY_PREFERENCE` = @Dietarypreferences, `ANWEISUNGEN` = @Anweisungen, `IMAGE_DESCRIPTION` = @ImageDescription WHERE `REZEPT_ID` = @RezeptId", connection))
                    {
                        // Set the parameters for the UPDATE query.
                        command.Parameters.AddWithValue("@RezeptName", rezept.RezeptName);
                        command.Parameters.AddWithValue("@Portionen", rezept.Portionen);
                        command.Parameters.AddWithValue("@Naehrwerte", rezept.Naehrwerte);
                        command.Parameters.AddWithValue("@RezeptType", rezept.RezeptType);
                        command.Parameters.AddWithValue("@Dietarypreferences", rezept.Dietarypreferences);
                        command.Parameters.AddWithValue("@Anweisungen", rezept.Anweisungen);
                        command.Parameters.AddWithValue("@ImageDescription", rezept.Image_Description);
                        command.Parameters.AddWithValue("@RezeptId", rezept.Rezept_ID);

                        int result = command.ExecuteNonQuery(); // Execute the UPDATE query.
                        return result; // Return the number of rows affected.
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL-specific exceptions.
                Console.WriteLine($"MySQL Error: {ex.Message}");
                return -1; // Return -1 to indicate failure.
            }
            catch (Exception ex)
            {
                // Handle general exceptions.
                Console.WriteLine($"General Error: {ex.Message}");
                return -1; // Return -1 to indicate failure.
            }
        }
    }
}

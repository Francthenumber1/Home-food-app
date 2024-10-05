using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeFood
{
    internal class RezeptenDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=Aubin1234.;database=food_for_home;";



        public List<Rezepten> getAllRezept()
        {
            List<Rezepten> returnThese = new List<Rezepten>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM rezept", connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
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
                        catch
                        (Exception)
                        {
                            // Create an image with an 'X'
                            rezept.Image = new Bitmap(100, 100); // Assuming a 100x100 image
                            using (Graphics g = Graphics.FromImage(rezept.Image))
                            {
                                g.Clear(Color.White);
                                Pen pen = new Pen(Color.Red, 5);
                                g.DrawLine(pen, new Point(0, 0), new Point(100, 100));
                                g.DrawLine(pen, new Point(100, 0), new Point(0, 100));
                            }
                        }

                        returnThese.Add(rezept);
                    }
                }
            }
            return returnThese;
        }


        public List<Rezepten> searchRezept(string searchTerm)
        {
            List<Rezepten> returnThese = new List<Rezepten>();
            string searchWildPhrase = "%" + searchTerm + "%";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM REZEPT WHERE REZEPT_NAME LIKE @search", connection))
                {
                    command.Parameters.AddWithValue("@search", searchWildPhrase);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rezepten rezept = new Rezepten
                            {
                                //Rezept_ID = reader.GetInt32("REZEPT_ID"),

                                RezeptName = reader.GetString("REZEPT_NAME"),
                                Portionen = reader.GetInt32("Portionen"),
                                Naehrwerte = reader.GetString("Naerwerte"),
                                RezeptType = reader.GetString("REZEPT_TYPE"),
                                Dietarypreferences = reader.GetString("DIETARY_PREFERENCE"),
                                Anweisungen = reader.GetString("ANWEISUNGEN"),
                                Image_Description = reader.GetString("IMAGE_DESCRIPTION")
                            };
                            returnThese.Add(rezept);
                        }
                    }
                }
            }
            return returnThese;
        }

        public Rezepten getRezeptDetails(int rezeptId)
        {
            Rezepten rezept = null;

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
                    command.Parameters.AddWithValue("@rezeptId", rezeptId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (rezept == null)
                            {
                                rezept = new Rezepten
                                {
                                    //Rezept_ID = reader.GetInt32("REZEPT_ID"),

                                    RezeptName = reader.GetString("REZEPT_NAME"),
                                    Portionen = reader.GetInt32("Portionen"),
                                    Naehrwerte = reader.GetString("Naerwerte"),
                                    RezeptType = reader.GetString("REZEPT_TYPE"),
                                    Dietarypreferences = reader.GetString("DIETARY_PREFERENCE"),
                                    Anweisungen = reader.GetString("ANWEISUNGEN"),
                                    Image_Description = reader.GetString("IMAGE_DESCRIPTION")
                                };
                            }
                            Zutat zutat = new Zutat
                            {
                                Zutat_Name = reader.GetString("ZUTAT_NAME"),
                                Kalorien_pro_100g = reader.GetInt32("KALORIEN_PRO_100G"),
                                Kohlenhydrate = reader.GetInt32("Kohlenhydrate"),
                                Proteine = reader.GetInt32("Proteine"),
                                Fette = reader.GetInt32("Fette")
                            };
                            rezept.Zutaten.Add(zutat);
                        }
                    }
                }
            }
            return rezept;
        }
        internal int addonerezept(Rezepten rezepten)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO `REZEPT` (`REZEPT_NAME`, `PORTIONEN`, `NAERWERTE`, `REZEPT_TYPE`, `DIETARY_PREFERENCE`, `ANWEISUNGEN`, `IMAGE_DESCRIPTION`) " +
                    "VALUES (@Rezept_name, @Portionen, @Naerwerte, @Rezept_type, @Dietary_Preferences, @Anweisungen, @Image_Description)", connection);
                command.Parameters.AddWithValue("@Rezept_name", rezepten.RezeptName);
                command.Parameters.AddWithValue("@Portionen", rezepten.Portionen);
                command.Parameters.AddWithValue("@Naerwerte", rezepten.Naehrwerte);
                command.Parameters.AddWithValue("@Rezept_type", rezepten.RezeptType);
                command.Parameters.AddWithValue("@Dietary_Preferences", rezepten.Dietarypreferences);
                command.Parameters.AddWithValue("@Anweisungen", rezepten.Anweisungen);
                command.Parameters.AddWithValue("@Image_Description", rezepten.Image_Description);

                int result = command.ExecuteNonQuery();
                connection.Close();

                return result;
            }
        }

        internal int AddZutat(Zutat zutat)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `ZUTAT` (`ZUTAT_NAME`, `KALORIEN_PRO_100G`, `Kohlenhydrate`, `Proteine`, `Fette`) VALUES (@Zutat_name, @Kalorien_pro_100g, @Kohlenhydrate, @Proteine, @Fette)", connection);
                command.Parameters.AddWithValue("@Zutat_name", zutat.Zutat_Name);
                command.Parameters.AddWithValue("@Kalorien_pro_100g", zutat.Kalorien_pro_100g);
                command.Parameters.AddWithValue("@Kohlenhydrate", zutat.Kohlenhydrate);
                command.Parameters.AddWithValue("@Proteine", zutat.Proteine);
                command.Parameters.AddWithValue("@Fette", zutat.Fette);

                command.ExecuteNonQuery();
                int zutatId = (int)command.LastInsertedId;
                connection.Close();

                return zutatId;
            }
        }

        internal int GetLastInsertedRezeptId()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT LAST_INSERT_ID()", connection);
                int rezeptId = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();

                return rezeptId;
            }
        }

        internal void LinkRezeptZutat(int rezeptId, int zutatId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `REZEPT_ZUTAT` (`REZEPT_ID`, `ZUTAT_ID`) VALUES (@RezeptId, @ZutatId)", connection);
                command.Parameters.AddWithValue("@RezeptId", rezeptId);
                command.Parameters.AddWithValue("@ZutatId", zutatId);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        internal int deleteRezept(int rezeptId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM `rezept` WHERE `REZEPT_ID` = @rezeptId", connection))
                    {
                        command.Parameters.AddWithValue("@rezeptId", rezeptId);
                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle exception (e.g., log it)
                Console.WriteLine($"MySQL Error: {ex.Message}");
                return -1; // or throw; if you want to rethrow the exception
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                Console.WriteLine($"General Error: {ex.Message}");
                return -1; // or throw; if you want to rethrow the exception
            }
        }
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
                        command.Parameters.AddWithValue("@RezeptName", rezept.RezeptName);
                        command.Parameters.AddWithValue("@Portionen", rezept.Portionen);
                        command.Parameters.AddWithValue("@Naehrwerte", rezept.Naehrwerte);
                        command.Parameters.AddWithValue("@RezeptType", rezept.RezeptType);
                        command.Parameters.AddWithValue("@Dietarypreferences", rezept.Dietarypreferences);
                        command.Parameters.AddWithValue("@Anweisungen", rezept.Anweisungen);
                        command.Parameters.AddWithValue("@ImageDescription", rezept.Image_Description);
                        command.Parameters.AddWithValue("@RezeptId", rezept.Rezept_ID);

                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"MySQL Error: {ex.Message}");
                return -1; // or throw; if you want to rethrow the exception
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
                return -1; // or throw; if you want to rethrow the exception
            }
        }



    }
}

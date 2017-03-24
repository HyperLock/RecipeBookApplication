using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace RecipeBookApplication
{
    public partial class RecipeForm : Form
    {
        SqlConnection connection;
        string connectionString;
        
        //Create class to hold shopping list values
        public class ShoppingList
        {
            public string Items { get; set; }
            public string Amount { get; set; }
        }

        public RecipeForm()
        {
            InitializeComponent();

            //Configuration manager to connect to database
            connectionString = ConfigurationManager.ConnectionStrings["RecipeBookApplication.Properties.Settings.RecipeBookApplicationConnectionString"].ConnectionString;
        }

        private void RecipeForm_Load(object sender, EventArgs e)
        {
            //On start up populate the recipies
            PopulateRecipes();
            //On start up populate the directions of selected recipe
            PopulateDirections();
            //On start up populate the shopping List 
            PopulateShoppingList();
        }

        private void PopulateRecipes()
        {
            //Aquire new connection and set adapter
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Title FROM RecipeTable", connection))
            {
                //Create a datatable object and fill it with the results from the query
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                //Display only the title and have the id stored at a value
                recipeListBox.DisplayMember = "Title";
                recipeListBox.ValueMember = "Id";
                recipeListBox.DataSource = recipeTable;
            }
        }

        private void PopulateDirections()
        {
            string query = "SELECT Directions FROM RecipeTable WHERE Id = @recipeId";
            
            //Aquire New connection and set the command object
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                //Add parameters
                command.Parameters.AddWithValue("@recipeId", recipeListBox.SelectedValue);

                //Execute a scalar command to get the recipe Id of selected recipe
                outDirectionsTextBox.Text = (string)command.ExecuteScalar();
            }
        }

        private void PopulateIngreidents()
        {
            string query = "SELECT a.Name FROM IngredientTable a INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId WHERE b.RecipeId = @RecipeId";

            //Aquire New connection, set the command object, and set adapter object
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                //Add parameters
                command.Parameters.AddWithValue("@RecipeId", recipeListBox.SelectedValue);

                //Create a DataTable object and have it filled with the results from the query
                DataTable IngredientTable = new DataTable();
                adapter.Fill(IngredientTable);

                //Only Display the name and have the id as a value
                ingredientsListBox.DisplayMember = "Name";
                ingredientsListBox.ValueMember = "Id";
                ingredientsListBox.DataSource = IngredientTable;
            }
        }

        private void PopulateShoppingList()
        {
            //Create new ShoppingList Object
            ShoppingList[] newList = null;

            string query = "SELECT item, amount FROM ShoppingTable";

            //Aquire New connection and set the command object
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    //Temporary list for the query results
                    var list = new List<ShoppingList>();
                    while (reader.Read())
                    {
                        //Store the results in the temporary list members
                        list.Add(new ShoppingList { Items = reader.GetString(0), Amount = reader.GetInt32(1).ToString() });
                    }

                    //Put list into array
                    newList = list.ToArray();
                }
            }

            //Display newlist object
            shoppingDataGrid.DataSource = newList;
            
        }

        private void recipeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateIngreidents();
            PopulateDirections();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void recipeSubmitButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RecipeTable VALUES (@recipeTitle, @recipeDifficulty, @recipeDirections)";

            //Aquire New connection and set the command object
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                //Add parameters
                command.Parameters.AddWithValue("@recipeTitle", recipeNameTextBox.Text);
                command.Parameters.AddWithValue("@recipeDifficulty", recipeDifficultyTextBox.Text);
                command.Parameters.AddWithValue("@recipeDirections", DirectionsTextBox.Text);

                //Execute Query
                command.ExecuteNonQuery();
            }

            PopulateRecipes();
        }

        //Aquire New connection and set the command object
        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            //Declare a variable to keep track of the id of the inputted ingredient
            int ingredientId = 0;

            string query = "INSERT INTO IngredientTable (Name, Amount) VALUES (@ingredientName, @amount)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                //Add parameters
                command.Parameters.AddWithValue("@ingredientName", addIngredientTextBox.Text);
                command.Parameters.AddWithValue("@amount", amountTextBox.Text);

                command.ExecuteNonQuery();
            }

            query = "SELECT Id FROM IngredientTable WHERE Name = @ingredientName";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                //Add parameters
                command.Parameters.AddWithValue("@IngredientName", addIngredientTextBox.Text);

                //Get Id
                ingredientId = (int)command.ExecuteScalar();

                //MessageBox.Show(ingredientId.ToString());
            }

            query = "INSERT INTO RecipeIngredient (RecipeId, IngredientId) VALUES (@recipeId, @ingredientId)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                
                //Add parameters
                command.Parameters.AddWithValue("@recipeId", recipeListBox.SelectedValue);
                command.Parameters.AddWithValue("@ingredientId", ingredientId);

                command.ExecuteNonQuery();
            }

            PopulateIngreidents();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddShoppingListButton_Click(object sender, EventArgs e)
        {
            ShoppingList[] shopping = null;

            string query = "SELECT a.Name, a.Amount FROM IngredientTable a INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId WHERE b.RecipeId = @RecipeId";

            //Aquire New connection and set the command object
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                
                //Add parameters
                command.Parameters.AddWithValue("@RecipeId", recipeListBox.SelectedValue);
                using (var reader = command.ExecuteReader())
                {
                    //Temporary list for the query results
                    var list = new List<ShoppingList>();
                    while (reader.Read())
                    {
                        //Store the results in the temporary list members
                        list.Add(new ShoppingList { Items = reader.GetString(0), Amount = reader.GetString(1) });
                    }

                    //Put list into array
                    shopping = list.ToArray();
                }
            }

            foreach (ShoppingList item in shopping)
            {
                query = "INSERT INTO ShoppingTable (item, amount) VALUES (@itemName, @amountVal)";

                //Aquire New connection and set the command object
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@itemName", item.Items);
                    command.Parameters.AddWithValue("@amountVal", int.Parse(item.Amount));
                    command.ExecuteNonQuery();
                }
            }

            PopulateShoppingList();
        }
    }
}

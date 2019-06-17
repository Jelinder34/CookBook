using LinqLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook
{
    public partial class CookBookInterface : Form
    {
        private DataTable dataTable;
        private DataView dataView;
        List<Recipe> Rep = ListManager.LoadData();

        public CookBookInterface()
        {
            InitializeComponent();
            allRecipeList.View = View.Details;
            allRecipeList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            allRecipeList.Columns.Add("Name", 200);
            allRecipeList.Columns.Add("Meal Type", 60);
            allRecipeList.Columns.Add("Main Ingredient", 100);
            allRecipeList.Columns.Add("Time", 50);

            dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("MealType");
            dataTable.Columns.Add("MainIngredient");
            dataTable.Columns.Add("Time");
            dataTable.Columns.Add("AllIngredients");
            dataTable.Columns.Add("Directions");
            dataTable.Columns.Add("Nutrition");

            InitializeBindings();
            UpdateBindings();
        }

        /*
         * The InitializeBindings assigns the List with all Recipes to the RecipeList.
         * Once it is intialized, it will populate the recipeList.
         */
        private void InitializeBindings()
        {
            Rep = Rep.OrderBy(x => x.Name).ToList();

            foreach (var recipe in Rep)
            {
                dataTable.Rows.Add(recipe.Name, recipe.MealType, recipe.MainIngredient,
                    recipe.Time, recipe.AllIngredients, recipe.Directions, recipe.Nutrition);
            }

            

            dataView = new DataView(dataTable);

            UpdateallRecipeList(dataView);

        }

        private void UpdateallRecipeList(DataView dv)
        {
            allRecipeList.Items.Clear();
            foreach (DataRow row in dataView.ToTable().Rows)
            {
                allRecipeList.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString() }));
            }
        }


        private void UpdateBindings()
        {

        }


        private void CookBookInterface_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchRecipe_TextChanged(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count != 0)
            {
                dataView.RowFilter = string.Format("Name Like '%{0}%'", SearchRecipe.Text);
                UpdateallRecipeList(dataView);
            }
        }
    }
}

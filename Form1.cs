using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinecraftHelper.src.comp;
using MinecraftHelper.src.support;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MinecraftHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Stream stream = File.Open("Recipes.xml", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                CurrentRecipes = (BindingList<Recipe>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch(FileNotFoundException e)
            {
                System.Console.WriteLine("No save file");
                CurrentRecipes = new BindingList<Recipe>();
            }

            ER_AM_ChoicesList.DataSource = new BindingList<Recipe>(CurrentRecipes);
            ER_CR_LIST.DataSource = CurrentRecipes;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ER_CR_LIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recipe selected = (Recipe)ER_CR_LIST.SelectedItem;
            List<Tuple<Recipe, int>> Comps = selected.Components;
            BindingList<RecipeFacade> Components = new BindingList<RecipeFacade>
                (RecipeFacade.ConvertList(Comps));

            Console.Text = selected.description();
            ER_DataGrid.DataSource = Components;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(CurrentRecipes.Count > 0)
            {
                Stream stream = File.Open("Recipes.xml", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(stream, CurrentRecipes);
                stream.Close();
            }
        }
    }
}

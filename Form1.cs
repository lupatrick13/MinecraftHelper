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
                Stream stream = File.Open("Rec1ipes.xml", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                CurrentRecipes = (BindingList<Recipe>)formatter.Deserialize(stream);
                stream.Close();
            }
            catch(FileNotFoundException e)
            {
                System.Console.WriteLine("No save file");
                CurrentRecipes = new BindingList<Recipe>();
                Recipe NANOPROC = new Recipe("Nanoprocessor", unit.count, 1);

                Recipe RES = new Recipe("SMD Resistor", unit.count, 1);

                Recipe ELEWIRE = new Recipe("Fine Electrum Wire", unit.count, 1);
                Recipe CIRC = new Recipe("Epoxy Circuit Board", unit.count, 1);
                Recipe NANO = new Recipe("Nano CPU", unit.count, 1);
                Recipe MOLTIN = new Recipe("Molten Tin", unit.mB, 1000);

                #region SMDTransistor - TRAN
                Recipe TRAN = new Recipe("SMD Transistor", unit.count, 32);
                Recipe GALPL = new Recipe("Gallium Plate", unit.count, 1);
                #region Copper Wire - COPFINEWIRE
                Recipe COPFINEWIRE = new Recipe("Fine Annealed Copper Wire", unit.count, 4);
                Recipe COPWIRE = new Recipe("Annealed Copper Wire", unit.count, 2);
                Recipe COP = new Recipe("Annealed Copper", unit.count, 1);
                COPWIRE.add(COP, 1);
                COPFINEWIRE.add(COPWIRE, 1);
                
                CurrentRecipes.Add(COP);
                CurrentRecipes.Add(COPWIRE);
                #endregion
                #region Polyethylene - POLELE
                Recipe POLELE = new Recipe("Polyethylene", unit.mB, 1000);
                Recipe PLAEGG = new Recipe("Plastic Egg", unit.count, 1);
                Recipe ETH = new Recipe("Ethanol", unit.mB, 1000);
                POLELE.add(PLAEGG, 32);
                POLELE.add(ETH, 1000);
                CurrentRecipes.Add(PLAEGG);
                CurrentRecipes.Add(ETH);
                #endregion

                TRAN.add(GALPL, 1);
                TRAN.add(COPFINEWIRE, 6);
                TRAN.add(POLELE, 288);
                CurrentRecipes.Add(COPFINEWIRE);
                CurrentRecipes.Add(POLELE);
                #endregion
                #region SMD Capacitor - CAP
                Recipe CAP = new Recipe("SMD Capacitor", unit.count, 16);
                Recipe POLY = new Recipe("Thin Polyvinyl Chloride Sheet", unit.count, 1);
                Recipe ALTH = new Recipe("Thin Aluminum Sheet", unit.count, 1);
                CAP.add(POLY, 4);
                CAP.add(ALTH, 1);
                CAP.add(POLELE, 36);
                #endregion
                NANOPROC.add(TRAN, 2);
                NANOPROC.add(CAP, 2);
                NANOPROC.add(RES, 2);
                NANOPROC.add(ELEWIRE, 2);
                NANOPROC.add(CIRC, 1);
                NANOPROC.add(NANO, 1);
                NANOPROC.add(MOLTIN, 144);
                CurrentRecipes.Add(NANOPROC);
                CurrentRecipes.Add(TRAN);
                CurrentRecipes.Add(CAP);
                CurrentRecipes.Add(RES);
                CurrentRecipes.Add(ELEWIRE);
                CurrentRecipes.Add(CIRC);
                CurrentRecipes.Add(NANO);
                CurrentRecipes.Add(MOLTIN);
                CurrentRecipes.Add(GALPL);
            }

            ER_AM_ChoicesList.DataSource = new BindingList<Recipe>(CurrentRecipes);
            ER_CR_LIST.DataSource = CurrentRecipes;

            ER_SelectedRecipe = (Recipe) ER_CR_LIST.SelectedItem;
            foreach(Recipe node in CurrentRecipes)
            {
                //node.Refresh();
                TestTree.Nodes.Add(node.Node);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ER_CR_LIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            ER_SelectedRecipe = (Recipe)ER_CR_LIST.SelectedItem;
            List<Tuple<Recipe, int>> Comps = ER_SelectedRecipe.Components;
            BindingList<RecipeFacade> Components = new BindingList<RecipeFacade>
                (RecipeFacade.ConvertList(Comps));

            Console.Text = ER_SelectedRecipe.description();
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

        private void ER_AM_SUB_Click(object sender, EventArgs e)
        {
            Recipe addedRecipe = (Recipe)ER_AM_ChoicesList.SelectedItem;
            ER_SelectedRecipe.add(addedRecipe, (int)ER_AM_AMT.Value);
            TestTree.Nodes.Clear();
            foreach (Recipe node in CurrentRecipes)
            {
                node.Refresh();
                TestTree.Nodes.Add(node.Node);
            }
        }

        private void ER_AM_AMT_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ER_DM_SUB_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selected = ER_DataGrid.SelectedRows;
            foreach(DataGridViewRow Node in selected)
            {
                ER_SelectedRecipe.delete((Recipe)Node.DataBoundItem);
            }
            
        }
    }
}

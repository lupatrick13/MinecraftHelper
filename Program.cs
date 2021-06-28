using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using MinecraftHelper.src.comp;
using MinecraftHelper.src.support;
using System.ComponentModel;

namespace MinecraftHelper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void TestRecipe()
        {
            BindingList<Recipe> CurrentRecipes = new BindingList<Recipe>();
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
    }
}

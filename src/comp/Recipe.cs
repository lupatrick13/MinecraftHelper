using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinecraftHelper.src.support;


namespace MinecraftHelper.src.comp
{
    [Serializable]
    class Recipe
    {
        protected string name;
        protected unit type;
        protected int amt_make;
        private List<Tuple<Recipe, int>> children;
        #region SettersGetters
        public List<Tuple<Recipe, int>> Components
        {
            get
            {
                return children;
            }
        }
        public string Name { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public unit Type {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public int Made
        {
            get
            {
                return amt_make;
            }
            set
            {
                amt_make = value;
            }
        }
        #endregion
        public Recipe(string name, unit type, int amt_make)
        {
            this.name = name;
            this.type = type;
            this.amt_make = amt_make;
            children = new List<Tuple<Recipe, int>>();
        }
        public string description(int amt = 1, int level = 0)
        {
            int amt_temp = (amt + amt_make - 1) / amt_make;
            string result = Support.Indent(level) + name + " ";
            result += amt_temp.ToString() + " times, "
                + "Each makes: " + amt_make.ToString() + " " + type
                + " Recipe needs: " + amt.ToString() + Environment.NewLine;

            foreach (Tuple<Recipe, int> node in children)
            {
                result += node.Item1.description(node.Item2 * amt_temp, level + 1);
            }

            return result;
        }
        public void add(Recipe comp, int amt)
        {
            children.Add(Tuple.Create(comp, amt));
        }
        public void delete(Recipe comp)
        {
            children.RemoveAll(item => item.Item1 == comp);
        }
    }
    class RecipeFacade
    {
        protected int amt_need;
        protected string name;
        protected unit type;
        protected int amt_make;

        public int Need{ get { return amt_need; } }
        public string Name { get { return name; } }
        public unit Type { get { return type; } }
        public int Makes { get { return amt_make; } }
        public RecipeFacade(Recipe comp, int amt)
        {
            name = comp.Name;
            type = comp.Type;
            amt_make = comp.Made;
            amt_need = amt;
        }
        static public List<RecipeFacade> ConvertList(List<Tuple<Recipe, int>> inputs)
        {
            List<RecipeFacade> Results = new List<RecipeFacade>();
            foreach(Tuple<Recipe, int> token in inputs)
            {
                Results.Add(new RecipeFacade(token.Item1, token.Item2));
            }
            return Results;
        }
    }
}

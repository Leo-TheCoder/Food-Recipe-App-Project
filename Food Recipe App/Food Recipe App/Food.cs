﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Recipe_App
{
    class Food
    {
        private int _ID;
        private string _foodName;
        private string _description;
        private string _imagePath;
        List<Step> _recipeSteps;

        public int ID { get; set; }
        public string foodName { get; set; }
        public string description { get; set; }
        public string imagePath { get; set; }
        public List<Step> recipeSteps { get; set; }

       /* public override string ToString()
        {
            return $"{_foodName}";
        }*/
    }
}

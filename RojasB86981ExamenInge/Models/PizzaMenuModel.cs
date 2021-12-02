using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RojasB86981ExamenInge.Models
{
    public class PizzaMenuModel
    {
        [Display(Name = "Imagen")]
        public string Image { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Descripción")]
        public string Description { get; set; }


        [Display(Name = "Precio")]
        public int Price { get; set; }

        [Display(Name = "Acompañamientos")]
        public string Accompaniment { get; set; }
        [Display(Name = "Ingredientes")]
        public string Ingredients { get; set; }
    }
}


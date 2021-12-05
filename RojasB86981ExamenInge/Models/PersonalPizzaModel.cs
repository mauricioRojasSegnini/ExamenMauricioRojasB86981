using System.ComponentModel.DataAnnotations;

namespace RojasB86981ExamenInge.Models
{
    public class PersonalPizzaModel
    {
        [Display(Name = "Nombre de la pizza")]
        public string Title { get; set; }
        [Display(Name = "Tamaño de la pizza")]
        public string Size { get; set; }

        [Display(Name = "La salsa de la pizza")]
        public string Sauce { get; set; }

        [Display(Name = "Ingredientes")]
        public string Ingredients { get; set; }

        [Display(Name = "Tipo de masa")]
        public string Mass { get; set; }

        [Display(Name = "Extras")]
        public string Extras { get; set; }

        [Display(Name = "Nota")]
        public string Note { get; set; }
        [Display(Name = "Costo total")]
        public int Price { get; set; }
    }
}
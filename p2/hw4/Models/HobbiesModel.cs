using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hw4.Pages
{
    public class HobbiesModel : PageModel
    {
        //hobby, description
        [BindProperty]
        public Dictionary<string, string> Hobbies { get; set;}

        public HobbiesModel()
        {
            Hobbies = new Dictionary<string, string>
            {
                { "Art", "Art is a diverse range of human activity, and resulting product, that involves creative or imaginative talent expressive of technical proficiency, beauty, emotional power, or conceptual ideas." },
                { "Blogging", "A blog (a truncation of weblog) is an informational website published on the World Wide Web consisting of discrete, often informal diary-style text entries (posts). Posts are typically displayed in reverse chronological order so that the most recent post appears first, at the top of the web page." },
                { "Ceramics", "A ceramic is any of the various hard, brittle, heat-resistant and corrosion-resistant materials made by shaping and then firing an inorganic, nonmetallic material, such as clay, at a high temperature. Common examples are earthenware, porcelain, and brick." },
                { "Diving", "A ceramic is any of the various hard, brittle, heat-resistant and corrosion-resistant materials made by shaping and then firing an inorganic, nonmetallic material, such as clay, at a high temperature. Common examples are earthenware, porcelain, and brick."},
                { "Engraving", "Engraving is the practice of incising a design onto a hard, usually flat surface by cutting grooves into it with a burin. The result may be a decorated object in itself, as when silver, gold, steel, or glass are engraved, or may provide an intaglio printing plate, of copper or another metal, for printing images on paper as prints or illustrations; these images are also called engravings. Engraving is one of the oldest and most important techniques in printmaking." }
            };
        }
    }
}
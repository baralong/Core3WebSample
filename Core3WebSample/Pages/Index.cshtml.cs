using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Core3WebSample.Pages
{
    public class IndexModel : PageModel
    {
        public string SelectedShip { get; set; }
        private readonly string[] ships =
            {
                "USS Adelphi",
                "USS Enterprise",
                "USS Excalibur",
                "USS Exeter",
                "USS Gandhi",
                "USS Horatio",
                "USS Valdemar",
                "USS Yamaguchi",
                "USS Zhukov",
                "USS Loma Prieta",
            };
        public void OnGet()
        {
            var rand = new Random();
            // loop 
            foreach(var ship in ships)
            {
                if (rand.Next(0, 5) == 3)
                {
                    SelectedShip = ship;
                    return;
                }
                SelectedShip = "";
            }
        }
    }
}

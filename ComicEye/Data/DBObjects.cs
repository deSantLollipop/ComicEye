using ComicEye.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace ComicEye.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content) 
        {
           

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value ));

            if (!content.Comics.Any())
                content.AddRange(
                       new ComicBook
                       {
                           name = "Tokyo Ghoul vol.1",
                           available = true,
                           shortDesc = "Dark fantasy manga series written and illustrated by Sui Ishida.",
                           longDesc = "Tokyo Ghoul is set in an alternate reality where ghouls, creatures that look like normal people but can only survive by eating human flesh, live amongst the human population in secrecy, hiding their true nature in order to evade pursuit from the authorities.",
                           price = 12,
                           img = "/img/Tokyo_Ghoul_volume_1_cover.jpg",
                           isFavourite = true,
                           publisher = "Shueisha",
                           Year = 1999,
                           Category = Categories["Manga/Manhwa"]
                       },
                    new ComicBook
                    {
                        name = "Detective Comics #27",
                        available = true,
                        shortDesc = "Features the first appearance of Batman",
                        longDesc = "Featuring three classic adventures of - The Batman! -The Case of the Chemical Sindicate -The Sensational Character - Find of 1940... Robin the Boy Wonder -Batman",
                        price = 150,
                        img = "/img/Detective_Comics_27_(May_1939).png",
                        isFavourite = true,
                        publisher = "DC",
                        Year = 1999,
                        Category = Categories["Comics"]
                    }
                    
                    );

            content.SaveChanges(); 
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get{
                if (category == null) {
                    var list = new Category[] {
                          new Category { categoryName = "Comics", desc = "Good old known comics"},
                            new Category { categoryName = "Manga/Manhwa", desc = "Japanese comics and South Korean comics"}

                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);

                }
                return category;
            }
        }

    }
}

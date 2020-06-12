using ComicEye.Data.interfaces;
using ComicEye.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicEye.Data.mocks
{
    public class MockComics : IAllComics
    {
        private readonly IComicCategory _comicCategory = new MockCategory();
        public IEnumerable<ComicBook> Comics
        {
            get {
                return new List<ComicBook>
                     {
                    new ComicBook{
                        name="Tokyo Ghoul vol.1",
                        available=true,
                        shortDesc="Dark fantasy manga series written and illustrated by Sui Ishida." ,
                        longDesc="Tokyo Ghoul is set in an alternate reality where ghouls, creatures that look like normal people but can only survive by eating human flesh, live amongst the human population in secrecy, hiding their true nature in order to evade pursuit from the authorities.",
                        price=12,
                        img="/img/Tokyo_Ghoul_volume_1_cover.jpg", 
                        isFavourite=true,
                        publisher="Shueisha",
                        Year=1999,
                        Category = _comicCategory.AllCategories.Last()
                        },
                    new ComicBook{
                        name="Detective Comics #27",
                        available=true,
                        shortDesc="Features the first appearance of Batman" ,
                        longDesc="Featuring three classic adventures of - The Batman! -The Case of the Chemical Sindicate -The Sensational Character - Find of 1940... Robin the Boy Wonder -Batman",
                        price=150,
                        img="/img/Detective_Comics_27_(May_1939).png",
                        isFavourite=true,
                        publisher="DC",
                        Year=1999,
                        Category = _comicCategory.AllCategories.First()
                        }
                    };
                }
        }
        public IEnumerable<ComicBook> getFavComics { get; set; }
        public ComicBook getObjectComics(int carId)
        {
            throw new NotImplementedException();
        }
    }
}

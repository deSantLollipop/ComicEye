using ComicEye.Data.interfaces;
using ComicEye.Data.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ComicEye.Data.Repository
{
    public class ComicsRepository : IAllComics
    {
        private readonly AppDBContent appDBContent;
        public ComicsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<ComicBook> Comics => appDBContent.Comics.Include(c => c.Category);

        public IEnumerable<ComicBook> getFavComics => appDBContent.Comics.Where(p => p.isFavourite).Include(c => c.Category);

        public ComicBook getObjectComics(int comiId) => appDBContent.Comics.FirstOrDefault(p => p.id == comiId);
    }
}

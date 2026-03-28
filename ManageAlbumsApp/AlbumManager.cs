using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAlbumsApp
{
    public class AlbumManager
    {
        public void AddAlbum(Album album)
        {
            _albums.Add(album);
        }

        public IEnumerable<Album> GetAllAlbums()
        {

            return _albums.Select(s => s);
        }


        public int NumberOfAlbums
        {
            get
            {
                return _albums.Count;
            }
        }

        public Album? GetAlbumById(int id)
        {

            foreach (Album album in _albums)
            {
                if (album.Id == id)
                {
                    return album;
                }
            }

            return null;
        }


        public List<Album> GetAlbumsByTitle(string title)
        {

            List<Album> matchingAlbums = new List<Album>();

            foreach (Album album in _albums)
            {

                if (album.Title == title)
                {
                  matchingAlbums.Add(album);
                }
            }
 
            return matchingAlbums;
        }

        public List<Album> GetAlbumsWithMinYear(int year)
        {

            List<Album> matchingAlbums = new List<Album>();

            foreach (Album album in _albums)
            {  
                if (album.YearProduced >= year)
                {
                    matchingAlbums.Add(album);
                }
            }

            return matchingAlbums;
        }

        private List<Album> _albums = new List<Album>();

    }
}

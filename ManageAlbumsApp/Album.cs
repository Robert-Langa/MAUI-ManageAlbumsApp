using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAlbumsApp
{
    public class Album
    {
        public Album()
        {
            _id = s_nextAvailableId;

            s_nextAvailableId++;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Title { get; set; }

        public string Band { get; set; }

        public int YearProduced
        {
            get
            {
                return _year;
            }

            set
            {
                if (value < 1930)
                {
                    throw new ArgumentException("Year entered must be above 1930");
                }

                _year = value;
            }
        }

        public string FullAlbum
        {
            get
            {
                return $"{Title}, {Band}";
            }
        }


        public override string ToString()
        {
            return $"\"{Title}, {Band}\" (YearProduced: {YearProduced})";
        }

        private static int s_nextAvailableId = 1;

        private int _id;

        private int _year;
    }
}

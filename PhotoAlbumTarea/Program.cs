using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbumTarea
{
    class PhotoAlbum
    {
       protected int _numberOfPages;
        public PhotoAlbum()
        {
            this._numberOfPages = 16;
        }
        public PhotoAlbum(int num)
        {
            this._numberOfPages = num;
        }
        public int GetNumberOfPages()
        {
            return this._numberOfPages;
        }
    }
    class BigPhotoAlbum : PhotoAlbum
    {
        public BigPhotoAlbum()
        {
            this._numberOfPages = 64;
        }
    }
    class AlbumTest
    {
        class Program
        {
            static void Main(string[] args)
            {
                
            }
        }
    }
}

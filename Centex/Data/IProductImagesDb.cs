using System.Collections.Generic;
using Centex.Models;

namespace Centex.Data
{
    public interface IProductImagesDb
    {
        IEnumerable<Photo> GetPhotosByParentId(int id);
    }
}
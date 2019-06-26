using RealestateApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealestateApplication.Data
{
    public interface IRepository
    {
        Ad GetAd(int id);
        List<Ad> GetAllPost(int id);
        bool AddAd(Ad ad);
        bool UpdateAd(Ad ad);
        bool RemoveAd(int id);
    }
}

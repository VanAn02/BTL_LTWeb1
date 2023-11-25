using DbShop.Model.Models;
using DbShop.Repository.IRepository;
using Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbShop.Repository.Repository
{
    public class NguoiDungRepo:Repo<NguoiDung>,INguoiDungRepo
    {
        public NguoiDungRepo(DbTravelContext context) : base(context) { }

    }
}

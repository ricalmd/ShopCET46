﻿using ShopCET46.Web.Data.Entities;

namespace ShopCET46.Web.Data
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DataContext context): base(context)
        {

        }
    }
}

﻿using System.Web;
using System.Web.Mvc;

namespace OST_Ecomm_B_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

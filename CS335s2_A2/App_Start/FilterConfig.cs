﻿using System.Web;
using System.Web.Mvc;

namespace CS335s2_A2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
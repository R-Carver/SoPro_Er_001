﻿using System.Web;
using System.Web.Mvc;

namespace Er_Diagramm_001
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages // static qoyanda newlememek ucun istifade edirik
    {
        public static string ProductAdded = "Urun eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string MaintenanceTime= "Sistem bakimda";
        public static string ProductsListed="Urunler listelendi";
        public static string UnitPriceInvalid="";
        public static string ProductCountOfCategoryError="Bir kategoriyada max 10 product ola biler";
        public static string ProductNameAlreadyExists="Bu adda basqa bir product var";
    }
}

using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string CategoryLimitExceded="Kategorya limiti doldu deye teze product elave edile bilmir";
        public static string AuthorizationDenied = "Ele bir yetkiniz yoxdur";
        public static string UserAlreadyExists ="Bele bir istifadeci var";
        public static string SuccessfulLogin = "Ugurla sisteme daxil olundu";
        public static string AccessTokenCreated= "JWT yaradildi";
        public static string PasswordError="Parol yanlisdir";
        public static string UserNotFound="Istifadeci tapilmadi";
        public static string UserRegistered="Register olundu";
        internal static string ProductUpdated;
    }
}

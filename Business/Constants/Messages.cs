﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime="Sistem bakımda.";
        public static string ProductsListed="Ürünler listelendi.";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied="Yetliniz yok.";
        public static string UserRegistered="Kayıt oldu.";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string PasswordError="Parola hatası.";
        public static string SuccessfulLogin="Başarılı giriş.";
        public static string UserAlreadyExists="Kullanıcı mevcut.";
        public static string AccessTokenCreated="Token oluşturuldu.";
        public static string ProductUpdated="Ürün güncellendi.";
    }
}

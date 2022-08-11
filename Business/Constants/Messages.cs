using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string UserRegistered="Kayıt oldu.";
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNotAdded = "Ürün Eklenemedi";
        public static string ProductNameInvalid = "Ürün Ismi Geçersiz.";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string ProductDeleted = "Ürünler Listelendi.";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün var";
        public static string CountOfCategoryCorrect = "10 dan fazla ürün ekleyemezsiniz";
        public static string CheckIfCategoryLimitExceded = "Kategori Limiti Aşıldı";
        public static string AuthorizationDenied = "Yetkiniz Yok.";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";

    }
}

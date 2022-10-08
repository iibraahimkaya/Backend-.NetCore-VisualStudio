using Core.Entities.Concrete;
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
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Tek Harften Büyük Olmalıdır";
        public static string MaintenanceTime = "Bakım Zamanı";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string CategoryListed = "Kategori Listelendi";
        public static string UnitPriceInvalid = "Ürün Fiyatı Geçersiz";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreayExists = "Ürün ismi Aynı olamaz";
        public static string CategoryCountOfProductError = "Kategori Sayısı 15'den fazla olamayacağı için ürün eklenemez";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomersUpdated = "Müşteri Güncellendi";
        public static string AuthorizationDenied = "Yetkisiz Giriş";
        public static string UserRegistered = "Kullanıcı Kaydedildi";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Yanlış";
        public static string SuccessfulLogin ="Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı";
        public static string AccessTokenCreated = "Token Oluşturuldu";
        public static string ProductDeleted = "Ürün silindi";
        public static string ProductUpdated = "Ürün güncellendi";
    }
}

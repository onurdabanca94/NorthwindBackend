using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi!";
        public static string ProductUpdated = "Ürün başarıyla güncellendi!";
        public static string ProductDeleted = "Ürün başarıyla silindi!";

        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Şifre yanlış!!";
        public static string LoginSuccess = "Giriş başarılı!";
        public static string UserAlreadyExists = "Kullanıcı mevcutta var.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu.";
    }
}

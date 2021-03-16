using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        //BrandMessages
        public static string BrandAdded = "Marka kayıt işlemi başarılı";
        public static string BrandUpdated = "Marka güncelleme işlemi başarılı";
        public static string BrandDeleted = "Marka silme işlemi başarılı";
        public static string BrandNameAlreadyExists = "Eklemek veya güncellemek istediğiniz marka zaten mevcut.Farklı bir marka giriniz.";

        //ColorMessages
        public static string ColorAdded = "Renk kayıt işlemi başarılı";
        public static string ColorUpdated = "Renk güncelleme işlemi başarılı";
        public static string ColorDeleted = "Renk silme işlemi başarılı";
        public static string ColorAddError = "Eklemek istediğiniz renk zaten mevcut.Farklı bir renk giriniz.";
        public static string ColorNameAlreadyExists = "Eklemek veya güncellemek istediğiniz renk zaten mevcut.Farklı bir renk giriniz.";

        //CarMessages
        public static string CarAdded = "Araç kayıt işlemi başarılı";
        public static string CarDeleted = "Araç silme işlemi başarılı";
        public static string CarUpdated = "Araç güncelleme işlemi başarılı";

        //UserMessages
        public static string UserAdded = "Kullanıcı kayıt işlemi başarılı";
        public static string UserUpdated = "Kullanıcı güncelleme işlemi başarılı";
        public static string UserDeleted = "Kullanıcı silme işlemi başarılı";
        public static string EmailAlreadyExists = "Eklemek veya güncellemek istediğiniz email adresi mevcut zaten.Farklı bir email adresi deneyin.";
        public static string UserNameAlreadyExists = "Eklemek veya güncellemek istediğiniz kullanıcı adı mevcut zaten.Farklı bir kullanıcı adı deneyin.";

        //CustomerMessages
        public static string CustomerAdded = "Müşteri kayıt işlemi başarılı";
        public static string CustomerUpdated = "Müşteri güncelleme işlemi başarılı";
        public static string CustomerDeleted = "Müşteri silme işlemi başarılı";

        //RentalMessages
        public static string RentalAdded = "Kiralama  işlemi başarılı";
        public static string RentalUpdated = "Kiralama güncelleme işlemi başarılı";
        public static string RentalDeleted = "Kiralama silme işlemi başarılı";
        public static string RentalInValid = "Araba teslim edilmemiş ";
        public static string RentalUpdatedReturnDateError = "Araç zaten teslim edilmiş";
        public static string RentalUpdatedReturnDate = "Araç teslim edildi";

        public static string Listed = "Listelendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string FailAddedImageLimit = "Limit Aşıldı";
        public static string AuthorizationDenied = "Yetkin yok";
        public static string GetErrorCarMessage = "Bulunamadı";
        public static string GetSuccessCarMessage = "";
    }
}

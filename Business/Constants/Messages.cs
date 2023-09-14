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
        public static string RequestCreated = "Talep oluşturuldu";
        public static string UsersListed="Kullanıcılar listelendi";
        public static string UserAdded="Kullanıcı eklendi";
        public static string CompaniesListed="Şirketler listelendi";
        public static string CompanyAdded="Şirket eklendi";
        public static string DriversListed="Şoförler listelendi";
        public static string MessagesListed = "Mesajlar listelendi";
        public static string RequestTypesListed = "Talep türleri listelendi";
        public static string ReservationsListed = "Rezervasyonlar listelendi";
        public static string ReviewsListed = "Değerlendirmeler listelendi";
        public static string TransportationTeamsListed = "Taşıma ekipleri listelendi";
        public static string TransportRequestsListed = "Taşıma taleleri listelendi";
        public static string VehiclesListed = "Araçlar listelendi";
        public static string DriverAdded = "Şoför eklendi";
        public static string MessageAdded = "Mesaj eklendi";
        public static string RequestTypeAdded="Talep türü eklendi";
        public static string ReservationAdded = "Rezervasyon eklendi";
        public static string ReviewAdded = "Değerlendirme eklendi";
        public static string TransportationTeamAdded = "Taşıma ekibi eklendi";
        public static string TransportRequestAdded = "Taşıma talebi eklendi";
        public static string VehicleAdded = "Araç eklendi";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered = "Kayıt başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}

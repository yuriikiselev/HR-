using System.Collections.Generic;
using xNet;
using Newtonsoft.Json;

namespace VkAPITutorial
{
    class VkAPI
    {
        public dynamic  Result2;
        public int Chislo = 0;
        public const string __APPID = "7225946";  //ID приложения
        private const string __VKAPIURL = "https://api.vk.com/method/";  //Ссылка для запросов
        private string _Token;  //Токен, использующийся при запросах

        public VkAPI(string AccessToken)
        {
            _Token = AccessToken;
        }

        public dynamic GetInformation(string UserId, string[] Fields)  //Получение заданной информации о пользователе с заданным ID 
        {
            HttpRequest GetInformation = new HttpRequest();
           string Params = "";
            foreach (string i in Fields)
            {
                Params += i + ",";
            }
            Params = Params.Remove(Params.Length - 1);
            string Result = GetInformation.Get(__VKAPIURL + "users.get?user_ids=" + UserId +"&fields="+Params+"&access_token="+ _Token+"&v=5.103").ToString();
            Result = Result.Substring(13, Result.Length - 15);//19
            dynamic Dict = JsonConvert.DeserializeObject(Result);
            return Dict;
        }


        public dynamic GetFriends(string UserId, int t)  //Получение заданной информации о пользователе с заданным ID 
        {
            HttpRequest GetFriends = new HttpRequest();
            //https://api.vk.com/method/users.get?user_ids=190558564&fields=city,country,photo_max&access_token=1a2c2ab50028546c81412d6367b40b0237508089a91d4ccf56ef0609fa41220d666b37c62d03251953448&v=5.103
            //https://api.vk.com/method/users.get?user_ids=210700286&fields=bdate&access_token=533bacf01e11f55b536a565b57531ac114461ae8736d6506a3&v=5.103
            //https://api.vk.com/method/users.get?v=5.103&access_token=1a2c2ab50028546c81412d6367b40b0237508089a91d4ccf56ef0609fa41220d666b37c62d03251953448&
            Result2 = GetFriends.Get(__VKAPIURL + "friends.get?user_id=" + UserId + "&orders=hints&count=100000" + "&fields=first_name,last_name,bdate&name_case=nom&access_token=" + _Token + "&v=5.8").ToString();
           Result2 = Result2.Substring(30+t, Result2.Length - (32+t));
           dynamic Dict2 = JsonConvert.DeserializeObject(Result2);
            return Dict2;
        }
        public dynamic GetNumberFriends(string UserId)  //Получение заданной информации о пользователе с заданным ID 
        {
            HttpRequest GetNumberFriends = new HttpRequest();
           string Result3 = GetNumberFriends.Get(__VKAPIURL + "friends.get?user_id=" + UserId + "&orders=hints&count=100000" + "&fields=first_name,last_name&name_case=nom&access_token=" + _Token + "&v=5.8").ToString();
            Result3 = Result3.Substring(12, Result3.Length - 13);
            dynamic Dict3 = JsonConvert.DeserializeObject(Result3);
           return Dict3;
        }
        //       https://api.vk.com/method/friends.get?user_id=20302&orders=hints&count=300" + "&fields=first_name,last_name&name_case=nom&access_token=" + 1d6472701033023bccda4be93c7ec4e41b55b83a8bda28f7584ab0026288785ee11a10d57f81471ed5515 + "&v=5.8").ToString();


        //public string GetCityById(string CityId)  //Перевод ID города в название
        //{
        //   HttpRequest GetCityById = new HttpRequest();
        //   string Result = GetCityById.Get(__VKAPIURL + "database.getCitiesById?" + "city_ids="+ CityId + "&v=5.103").ToString();
        //    Result = Result.Substring(13, Result.Length - 15);
        //    dynamic Dict = JsonConvert.DeserializeObject(Result);
        //    return Dict["title"];
        //}

        //public string GetCountryById(string CountryId)  //Перевод ID страны в название
        //{
        //    HttpRequest GetCountryById = new HttpRequest();
        //    string Result = GetCountryById.Get(__VKAPIURL + "database.getCountriesById?" + "user_ids=190558564&access_token=1a2c2ab50028546c81412d6367b40b0237508089a91d4ccf56ef0609fa41220d666b37c62d03251953448&v=5.103").ToString();
        //    Result = Result.Substring(13, Result.Length - 15);
        //    dynamic Dict = JsonConvert.DeserializeObject(Result);
        //    return Dict["name"];
        //}
    }
}
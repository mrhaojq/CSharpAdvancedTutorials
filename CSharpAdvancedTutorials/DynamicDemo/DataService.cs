using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DynamicDemo
{
   public class DataService
    {
        /*异步 Task 方法使用
         * async Task<>
         * 
         * 方法中 var result= await xx.xxAsync() 异步方法
        */

        public static async Task<dynamic> GetWeatherDynamic(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);

            dynamic data = null;
            if (response!=null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }
            return data;
        }

        public static async Task<T> GetWeatherGeneric<T>(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);

            if (response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                return (T)JsonConvert.DeserializeObject<T>(json);
            }
            else
            {
                //return null;
                return default(T);//泛型default 如果T是引用类型返回NULL 如何是值类型返回0
            }

            
            //async Task<T> 貌似我想多了
            //return (T)new object();
        }

        public static T GetWeatherGeneric2<T>(string queryString)
        {
            return (T)new object();
        }
    }
}

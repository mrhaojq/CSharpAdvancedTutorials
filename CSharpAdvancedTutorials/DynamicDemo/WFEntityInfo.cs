using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicDemo
{
  public  class WFEntityInfo
    {
        /// <summary>
        /// id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 城市id
        /// </summary>
        public string areaid { get; set; }
        /// <summary>
        /// 白天天气
        /// </summary>
        public string dayWeather { get; set; }
        /// <summary>
        /// 晚上天气
        /// </summary>
        public string nightWeather { get; set; }
        /// <summary>
        /// 白天天气温度(摄氏度)
        /// </summary>
        public string dayTemp { get; set; }
        /// <summary>
        /// 晚上天气温度(摄氏度)
        /// </summary>
        public string nightTemp { get; set; }
        /// <summary>
        /// 白天风向
        /// </summary>
        public string dayWinddir { get; set; }
        /// <summary>
        /// 晚上风向
        /// </summary>
        public string nightWinddir { get; set; }
        /// <summary>
        /// 白天风力
        /// </summary>
        public string dayWindlevel { get; set; }
        /// <summary>
        /// 晚上风力
        /// </summary>
        public string nightWindlevel { get; set; }
        /// <summary>
        /// 日出日落时间(中间用|分割)
        /// </summary>
        public string daynightline { get; set; }
        /// <summary>
        /// 预报发布时间
        /// </summary>
        public string releasetime { get; set; }
        /// <summary>
        /// 预报日期
        /// </summary>
        public string forecastdate { get; set; }
        /// <summary>
        /// 数据录入时间
        /// </summary>
        public string insertdatetime { get; set; }
    }
}

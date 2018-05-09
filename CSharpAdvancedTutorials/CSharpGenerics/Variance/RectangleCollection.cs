using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGenerics.Variance
{
    public class RectangleCollection : IIndex<Rectangle>
    {

        private Rectangle[] data = new Rectangle[]
            {
                new Rectangle{ Height=2,Width=5},
                new Rectangle{Height=3,Width=7},
                new Rectangle{Height=4.5,Width=2.9}
            };

        private static RectangleCollection _coll;

        public static RectangleCollection GetRectangles() => _coll ?? (_coll = new RectangleCollection());
        //public static RectangleCollection GetRectangles()
        //{
        //    if (_coll==null)
        //    {
        //        _coll = new RectangleCollection();
        //    }
        //    return _coll;
        //}


        #region 接口IIndex<T> 中定义的方法

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Rectangle this[int index]
        {
            get
            {
                if (index < 0 || index > data.Length)
                {
                    throw new ArgumentOutOfRangeException("index");
                }
                return data[index];
            }
        }

        public int Count => data.Length;
        #endregion
    }
}

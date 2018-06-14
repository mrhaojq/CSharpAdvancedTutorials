using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGenerics.GenericsMethods
{
   public static class Algorithms
    {
        public static decimal AccumulateSimple(IEnumerable<Account> source)
        {
            decimal sum = 0;
            foreach (var a in source)
            {
                sum += a.Balance;
            }

            return sum;
        }

        /// <summary>
        /// 带约束的泛型方法
        /// </summary>
        /// <typeparam name="TAccount"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static decimal AccumulateSimple1<TAccount>(IEnumerable<TAccount> source)
            where TAccount:IAccount
        {
            decimal sum = 0;
            foreach (var a in source)
            {
                sum += a.Balance;
            }
            return sum;
        }

        /// <summary>
        /// 带委托的泛型方法
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="source"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static T2 AccumulateSimple2<T1, T2>(IEnumerable<T1> source,Func<T1,T2,T2> action)
        {
            T2 sum = default(T2);

            foreach (T1 item in source)
            {
                //泛型委托可以去除集合中的算法
                sum = action(item, sum);
            }

            return sum;
        }
    }
}

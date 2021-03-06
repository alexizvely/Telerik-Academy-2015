﻿namespace _02.IEnumerable.Extentions
{
    using System;
    using System.Collections.Generic;

    public static class SumExtention
    {
        public static T SumExt<T>(this IEnumerable<T> enumeration)
        {
            dynamic result = 0;
            foreach (var item in enumeration)
            {
                result += item;
            }
            return result;
        }
    }
}

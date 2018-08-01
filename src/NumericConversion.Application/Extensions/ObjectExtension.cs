using System;

namespace NumericConversion.Application.Extensions
{
    public static class ObjectExtension
    {
        public static TConvert ChangeTypeTo<TConvert>(this object @object) =>
            (TConvert) Convert.ChangeType(@object, typeof(TConvert));
    }
}
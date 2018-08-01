using System;

namespace NumericConversion.Application.Interfaces.Factories
{
    public interface IConverterFactory
    {
        IConverter GetConverter(Guid converterId);
    }
}
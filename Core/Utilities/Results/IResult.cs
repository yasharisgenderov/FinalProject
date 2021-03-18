using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // sade voidler ucun baslangicdir.Bunun vasitesile voidleri bezeyeceyik
    public interface IResult
    {
        bool Success { get; }

        string Message { get; }
    }
}

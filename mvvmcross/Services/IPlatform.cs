using System;
namespace mvvmcross.Services
{
    public interface IPlatform
    {
        string OSName { get; set;  }
        double ScreenWidth { get; set;  }
        double ScreenHeight { get; set; }
    }
}

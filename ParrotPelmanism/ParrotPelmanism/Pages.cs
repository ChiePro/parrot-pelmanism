using System;
using System.Collections.Generic;

namespace ParrotPelmanism
{
    public static class Pages
    {
        public static readonly Dictionary<string, Uri> PageDic = new Dictionary<string, Uri>() {
            { "Start", new Uri("Page/Start.xaml", UriKind.Relative) },
            { "MainGame", new Uri("Page/MainGame.xaml", UriKind.Relative) },
            { "Result", new Uri("Page/Result.xaml", UriKind.Relative) },
        };

    }
}

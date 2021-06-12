using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace HolisticWare.Ph4ct3x.Utilities.Weather.Providers.Yr.No
{
    public class Data
    {
        public static HttpClient ClientHTTP
        {
            get;
            set;
        }

        public
            List
                <
                    (
                        string url,
                        Type type,
                        Exception exception,
                        string content
                    )
                >
                        DownloadUrls
        {
            get;
            set;
        }

        public Data()
        {
            DownloadUrls = new List
                                    <
                                        (
                                            string url,
                                            Type type,
                                            Exception exception,
                                            string content
                                        )
                                    >()
            {
            };
        }
    }
}

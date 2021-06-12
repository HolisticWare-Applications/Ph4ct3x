using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR
{
    public partial class Data
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
                (
                  url:  "https://vrijeme.hr/hrvatska_n.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Current.Croatia.Regions"
                                + "." +
                                "Hrvatska"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://vrijeme.hr/hrvatska1_n.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Current.Croatia.Alphabetic"
                                + "." +
                                "Hrvatska"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://vrijeme.hr/europa_n.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Current.Europe"
                                + "." +
                                "Europa"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://vrijeme.hr/more_n.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Current.SeaTemperatures.Adria"
                                + "." +
                                "Temperature_mora"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://vrijeme.hr/oborina.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Current.Precipitation"
                                + "." +
                                "dnevna_oborina"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://vrijeme.hr/snijeg_n.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Current.Snow"
                                + "." +
                                "visine_snijega"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://vrijeme.hr/uvi.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Current.UltraVioletIndex"
                                + "." +
                                "UV_indeks"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://vrijeme.hr/agro_temp.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Current.SoilTemperatures"
                                + "." +
                                "tdv"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://klima.hr/agro7.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Current.SoilTemperatures.Weekly"
                                + "." +
                                "AgroMeteoroloskiPodaci"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://vrijeme.hr/indeks.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Current.ForestFiresRiskLevels"
                                + "." +
                                "opasnost"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://meteo.hr/upozorenja/cap_hr_today.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Current.Warnings.CAP.Today"
                                + "." +
                                "alert"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://meteo.hr/upozorenja/cap_hr_tmorrow.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Current.Warnings.CAP.Tomorrow"
                                + "." +
                                "alert"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://prognoza.hr/prognoza_danas.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Forecasts.Croatia.Zagreb.Today"
                                + "." +
                                "param"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://prognoza.hr/prognoza_sutra.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Forecasts.Croatia.Zagreb.Tomorrow"
                                + "." +
                                "param"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://prognoza.hr/regije_danas.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Forecasts.Croatia.Regions.Today"
                                + "." +
                                "regije_danas"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://prognoza.hr/prognoza_izgledi.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Forecasts.Prospects.Days3"
                                + "." +
                                "param"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://prognoza.hr/jadran_h.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Forecasts.Croatia.Nautical"
                                + "." +
                                "Prognoza_jadran"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://prognoza.hr/pomorci.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Forecasts.Croatia.Seamen"
                                + "." +
                                "Prognoza_pomorci"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://klima.hr/agro_regije_prognoza.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Forecasts.AgroMeteorological.Croatia.Regions"
                                + "." +
                                "agro_regije"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://prognoza.hr/bio_novo.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Forecasts.BioMeteorological"
                                + "." +
                                "Bioprognoza"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://prognoza.hr/toplinskival_5.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Forecasts.Waves.Heat"
                                + "." +
                                "TriVis"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://prognoza.hr/hladnival.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Forecasts.Waves.Cold"
                                + "." +
                                "TriVis"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://prognoza.hr/tri/3d_graf_i_simboli.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Forecasts.MeteoGrams.Days3"
                                + "." +
                                "trodnevnatrosatna"
                            ),
                    exception: null,
                    content: null
                ),
                (
                  url:  "https://prognoza.hr/sedam/hrvatska/7d_meteogrami.xml",
                  type: Type.GetType
                            (
                                "HolisticWare.Ph4ct3x.Utilities.Weather.DHMZ_MeteoHR_PrognozaHR"
                                + "." +
                                "WeatherData.Forecasts.MeteoGrams.Days7"
                                + "." +
                                "sedmodnevna_aliec"
                            ),
                    exception: null,
                    content: null
                ),
            };
        }

        public async
                Task
                                GetDataAsync
                                        (
                                            bool reload = false
                                        )
        {
            // Method signature: Parallel.ForEach
            //                              (
            //                                  IEnumerable<TSource> source,
            //                                  Action<TSource> body
            //                              )
            Parallel.ForEach
                (
                    this.DownloadUrls,
                    async (tuple) =>
                    {
                        string result = null;
                        Exception exception = null;

                        if (string.IsNullOrEmpty(tuple.content) || reload)
                        {
                            try
                            {
                                HttpResponseMessage response = await ClientHTTP?.GetAsync(tuple.url);

                                if (response.IsSuccessStatusCode)
                                {
                                    result = await response.Content.ReadAsStringAsync();
                                }
                            }
                            catch (Exception exc)
                            {
                                exception = exc;
                            }
                            finally
                            {
                                tuple.content = result;
                                tuple.exception = exception;
                            }
                        }

                        System.Type t = null;
                        XmlSerializer s = null;

                        switch (tuple.url)
                        {
                            case "https://vrijeme.hr/hrvatska_n.xml":
                                try
                                {
                                    t = typeof(WeatherData.Current.Croatia.Regions.Hrvatska);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.hrvatska_n = (WeatherData.Current.Croatia.Regions.Hrvatska)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://vrijeme.hr/hrvatska1_n.xml":
                                try
                                {
                                    t = typeof(WeatherData.Current.Croatia.Alphabetic.Hrvatska);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.hrvatska1_n = (WeatherData.Current.Croatia.Alphabetic.Hrvatska)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://vrijeme.hr/europa_n.xml":
                                try
                                {
                                    t = typeof(WeatherData.Current.Europe.Europa);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.europa_n = (WeatherData.Current.Europe.Europa)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://vrijeme.hr/more_n.xml":
                                try
                                {
                                    t = typeof(WeatherData.Current.SeaTemperatures.Adria.Temperature_mora);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.more_n = (WeatherData.Current.SeaTemperatures.Adria.Temperature_mora)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://vrijeme.hr/oborina.xml":
                                try
                                {
                                    t = typeof(WeatherData.Current.Precipitation.dnevna_oborina);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.oborina = (WeatherData.Current.Precipitation.dnevna_oborina)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://vrijeme.hr/snijeg_n.xml":
                                try
                                {
                                    t = typeof(WeatherData.Current.Croatia.Snow.visine_snijega);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.snijeg_n = (WeatherData.Current.Croatia.Snow.visine_snijega)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://vrijeme.hr/uvi.xml":
                                try
                                {
                                    t = typeof(WeatherData.Current.UltraVioletIndex.UV_indeks);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.uvi = (WeatherData.Current.UltraVioletIndex.UV_indeks)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://vrijeme.hr/agro_temp.xml":
                                try
                                {
                                    t = typeof(WeatherData.Current.SoilTemperatures.temperature_tla);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.agro_temp = (WeatherData.Current.SoilTemperatures.temperature_tla)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://klima.hr/agro7.xml":
                                try
                                {
                                    t = typeof(WeatherData.Current.SoilTemperatures.Weekly.AgroMeteoroloskiPodaci);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.agro7 = (WeatherData.Current.SoilTemperatures.Weekly.AgroMeteoroloskiPodaci)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://vrijeme.hr/indeks.xml":
                                try
                                {
                                    t = typeof(WeatherData.Current.ForestFiresRiskLevels.opasnost);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.indeks = (WeatherData.Current.ForestFiresRiskLevels.opasnost)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://meteo.hr/upozorenja/cap_hr_today.xml":
                                try
                                {
                                    t = typeof(WeatherData.Current.Warnings.CAP.Today.alert);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.cap_hr_today = (WeatherData.Current.Warnings.CAP.Today.alert)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://meteo.hr/upozorenja/cap_hr_tomorrow.xml":
                                try
                                {
                                    t = typeof(WeatherData.Current.Warnings.CAP.Tomorrow.alert);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.cap_hr_tomorrow = (WeatherData.Current.Warnings.CAP.Tomorrow.alert)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://prognoza.hr/prognoza_danas.xml":
                                try
                                {
                                    t = typeof(Forecasts.Croatia.Today.VW);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.prognoza_danas = (Forecasts.Croatia.Today.VW)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://prognoza.hr/prognoza_sutra.xml":
                                try
                                {
                                    t = typeof(Forecasts.Croatia.Tomorrow.VW);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.prognoza_sutra = (Forecasts.Croatia.Tomorrow.VW)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://prognoza.hr/prognoza_izgledi.xml":
                                try
                                {
                                    t = typeof(Forecasts.Prospects.Days3.VW);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.prognoza_izgledi = (Forecasts.Prospects.Days3.VW)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://prognoza.hr/regije_danas.xml":
                                try
                                {
                                    t = typeof(Forecasts.Croatia.Regions.Today.regije_danas);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.regije_danas = (Forecasts.Croatia.Regions.Today.regije_danas)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://prognoza.hr/jadran_h.xml":
                                try
                                {
                                    t = typeof(Forecasts.Croatia.Nautical.Prognoza_jadran);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.jadran_h = (Forecasts.Croatia.Nautical.Prognoza_jadran)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://prognoza.hr/pomorci.xml":
                                try
                                {
                                    t = typeof(Forecasts.Croatia.Seamen.Prognoza_pomorci);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.pomorci = (Forecasts.Croatia.Seamen.Prognoza_pomorci)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://klima.hr/agro_regije_prognoza.xml":
                                try
                                {
                                    t = typeof(Forecasts.AgroMeteorological.Croatia.Regions.agro_regije);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.agro_regije_prognoza = (Forecasts.AgroMeteorological.Croatia.Regions.agro_regije)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://prognoza.hr/bio_novo.xml":
                                try
                                {
                                    t = typeof(Forecasts.BioMeteorological.Bioprognoza);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.bio_novo = (Forecasts.BioMeteorological.Bioprognoza)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://prognoza.hr/toplinskival_5.xml":
                                try
                                {
                                    t = typeof(Forecasts.Waves.Heat.TriVis);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.toplinskival_5 = (Forecasts.Waves.Heat.TriVis)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://prognoza.hr/hladnival.xml":
                                try
                                {
                                    t = typeof(Forecasts.Waves.Cold.TriVis);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this.hladnival = (Forecasts.Waves.Cold.TriVis)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://prognoza.hr/tri/3d_graf_i_simboli.xml":
                                try
                                {
                                    t = typeof(Forecasts.MeteoGrams.Days3.trodnevnatrosatna);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this._3d_graf_i_simboli = (Forecasts.MeteoGrams.Days3.trodnevnatrosatna)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            case "https://prognoza.hr/sedam/hrvatska/7d_meteogrami.xml":
                                try
                                {
                                    t = typeof(Forecasts.MeteoGrams.Days7.sedmodnevna_aliec);
                                    s = new XmlSerializer(t);
                                    using (System.IO.StringReader r = new System.IO.StringReader(tuple.content))
                                    {
                                        this._7d_meteogrami = (Forecasts.MeteoGrams.Days7.sedmodnevna_aliec)s.Deserialize(r);
                                    }
                                }
                                catch (Exception exc)
                                {
                                    tuple.exception = exc;
                                }

                                break;
                            default:
                                break;
                        }
                    }
                );

            return;
        }

        protected
            WeatherData.Current.Croatia.Regions.Hrvatska
            hrvatska_n
        {
            get;
            set;
        }

        protected
            WeatherData.Current.Croatia.Alphabetic.Hrvatska
            hrvatska1_n
        {
            get;
            set;
        }

        protected
            WeatherData.Current.Europe.Europa
            europa_n
        {
            get;
            set;
        }

        protected
            WeatherData.Current.SeaTemperatures.Adria.Temperature_mora
            more_n
        {
            get;
            set;
        }

        protected
            WeatherData.Current.Precipitation.dnevna_oborina
            oborina
        {
            get;
            set;
        }

        protected
            WeatherData.Current.Croatia.Snow.visine_snijega
            snijeg_n
        {
            get;
            set;
        }

        protected
            WeatherData.Current.UltraVioletIndex.UV_indeks
            uvi
        {
            get;
            set;
        }

        protected
            WeatherData.Current.SoilTemperatures.temperature_tla
            agro_temp
        {
            get;
            set;
        }

        protected
            WeatherData.Current.SoilTemperatures.Weekly.AgroMeteoroloskiPodaci
            agro7
        {
            get;
            set;
        }

        protected
            WeatherData.Current.ForestFiresRiskLevels.opasnost
            indeks
        {
            get;
            set;
        }

        protected
            WeatherData.Current.Warnings.CAP.Today.alert
            cap_hr_today
        {
            get;
            set;
        }

        protected
            WeatherData.Current.Warnings.CAP.Tomorrow.alert
            cap_hr_tomorrow
        {
            get;
            set;
        }

        protected
            Forecasts.Croatia.Today.VW
            prognoza_danas
        {
            get;
            set;
        }

        protected
            Forecasts.Croatia.Tomorrow.VW
            prognoza_sutra
        {
            get;
            set;
        }

        protected
            Forecasts.Prospects.Days3.VW
            prognoza_izgledi
        {
            get;
            set;
        }

        protected
            Forecasts.Croatia.Regions.Today.regije_danas
            regije_danas
        {
            get;
            set;
        }

        protected
            Forecasts.Croatia.Nautical.Prognoza_jadran
            jadran_h
        {
            get;
            set;
        }

        protected
            Forecasts.Croatia.Seamen.Prognoza_pomorci
            pomorci
        {
            get;
            set;
        }

        protected
            Forecasts.AgroMeteorological.Croatia.Regions.agro_regije
            agro_regije_prognoza
        {
            get;
            set;
        }

        protected
            Forecasts.BioMeteorological.Bioprognoza
            bio_novo
        {
            get;
            set;
        }

        protected
            Forecasts.Waves.Heat.TriVis
            toplinskival_5
        {
            get;
            set;
        }

        protected
            Forecasts.Waves.Cold.TriVis
            hladnival
        {
            get;
            set;
        }

        protected
            Forecasts.MeteoGrams.Days3.trodnevnatrosatna
            _3d_graf_i_simboli
        {
            get;
            set;
        }

        protected
            Forecasts.MeteoGrams.Days7.sedmodnevna_aliec
            _7d_meteogrami
        {
            get;
            set;
        }
    }
}

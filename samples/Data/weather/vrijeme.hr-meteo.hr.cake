// #tool "dotnet:?package=dotnet-xscgen"
// #tool "dotnet:?package=ddotnet-xdt"

EnsureDirectoryExists("./vrijeme.hr-meteo.hr/");
EnsureDirectoryExists("./vrijeme.hr-meteo.hr/data/");
EnsureDirectoryExists("./vrijeme.hr-meteo.hr/xsd/");
EnsureDirectoryExists("./vrijeme.hr-meteo.hr/xsd/xsd.exe/");
EnsureDirectoryExists("./vrijeme.hr-meteo.hr/xsd/liquidtechnologies/");
EnsureDirectoryExists("./vrijeme.hr-meteo.hr/csharp/");
EnsureDirectoryExists("./vrijeme.hr-meteo.hr/csharp/xsd.exe/");
EnsureDirectoryExists("./vrijeme.hr-meteo.hr/csharp/liquidtechnologies/");

FilePath output_path = null;

output_path = File("./vrijeme.hr-meteo.hr/data/hrvatska_n.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://vrijeme.hr/hrvatska_n.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/hrvatska1_n.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://vrijeme.hr/hrvatska1_n.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/prognoza_danas.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://prognoza.hr/prognoza_danas.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/prognoza_sutra.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://prognoza.hr/prognoza_sutra.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/regije_danas.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://prognoza.hr/regije_danas.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/prognoza_izgledi.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://prognoza.hr/prognoza_izgledi.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/jadran_h.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://prognoza.hr/jadran_h.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/pomorci.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://prognoza.hr/pomorci.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/3d_graf_i_simboli.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://prognoza.hr/tri/3d_graf_i_simboli.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/7d_meteogrami.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://prognoza.hr/sedam/hrvatska/7d_meteogrami.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/bio_novo.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://prognoza.hr/bio_novo.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/toplinskival_5.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://prognoza.hr/toplinskival_5.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/hladnival.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://prognoza.hr/hladnival.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/more_n.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://vrijeme.hr/more_n.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/uvi.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://vrijeme.hr/uvi.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/cap_hr_today.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://meteo.hr/upozorenja/cap_hr_today.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/cap_hr_tomorrow.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://meteo.hr/upozorenja/cap_hr_tomorrow.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/europa_n.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://vrijeme.hr/europa_n.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/oborina.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://vrijeme.hr/oborina.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/snijeg_n.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://vrijeme.hr/snijeg_n.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/agro_temp.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://vrijeme.hr/agro_temp.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/agro7.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://klima.hr/agro7.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/agro_regije_prognoza.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://klima.hr/agro_regije_prognoza.xml",
                output_path
            );
}
output_path = File("./vrijeme.hr-meteo.hr/data/indeks.xml");
if ( ! FileExists(output_path) )
{
    DownloadFile
            (
                "https://vrijeme.hr/indeks.xml",
                output_path
            );
}


int  exit_code = -1;

EnsureDirectoryExists("./vrijeme.hr-meteo.hr/xsd/");
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/hrvatska_n.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/hrvatska1_n.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/prognoza_danas.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/prognoza_sutra.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/regije_danas.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/prognoza_izgledi.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/jadran_h.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/pomorci.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/3d_graf_i_simboli.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/7d_meteogrami.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/bio_novo.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/toplinskival_5.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/hladnival.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/more_n.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/uvi.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/cap_hr_today.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/cap_hr_tomorrow.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/europa_n.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/oborina.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/snijeg_n.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/agro_temp.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/agro7.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/agro_regije_prognoza.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/indeks.xml"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/xsd/"
                    }
                );







EnsureDirectoryExists("./vrijeme.hr-meteo.hr/csharp/");
string ns_root = "HolisticWare.Ph4ct3x.Utilities.Weather.Providers.DHMZ_MeteoHR_PrognozaHR";
string ns = ns_root;

ns = ns_root 
        + "." +
        "WeatherData.Current.Croatia.Regions"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/hrvatska_n.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );                
ns = ns_root 
        + "." +
        "WeatherData.Current.Croatia.Alphabetic"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/hrvatska1_n.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "Forecasts.Croatia.Today"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/prognoza_danas.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "Forecasts.Croatia.Tomorrow"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/prognoza_sutra.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "Forecasts.Croatia.Regions.Today"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/regije_danas.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "Forecasts.Prospects.Days3"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/prognoza_izgledi.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "Forecasts.Croatia.Nautical"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/jadran_h.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "Forecasts.Croatia.Seamen"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/pomorci.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "Forecasts.MeteoGrams.Days3"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/3d_graf_i_simboli.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "Forecasts.MeteoGrams.Days7"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/7d_meteogrami.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "Forecasts.BioMeteorological"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/bio_novo.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "Forecasts.Waves.Heat"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/toplinskival_5.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "Forecasts.Waves.Cold"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/hladnival.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "WeatherData.Current.SeaTemperatures.Adria"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/more_n.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "WeatherData.Current.UltraVioletIndex"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/uvi.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "WeatherData.Current.Warnings.CAP.Today"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/cap_hr_today.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "WeatherData.Current.Warnings.CAP.Tomorrow"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/cap_hr_tomorrow.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "WeatherData.Current.Europe"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/europa_n.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "WeatherData.Current.Precipitation"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/oborina.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "WeatherData.Current.Croatia.Snow"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/snijeg_n.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "WeatherData.Current.SoilTemperatures"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/agro_temp.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "WeatherData.Current.SoilTemperatures.Weekly"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/agro7.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "Forecasts.AgroMeteorological.Croatia.Regions"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/agro_regije_prognoza.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );
ns = ns_root 
        + "." +
        "WeatherData.Current.ForestFiresRiskLevels"
        ;
exit_code = StartProcess
                (
                    "xsd",
                    new ProcessSettings
                    {
                        Arguments =
                            "./vrijeme.hr-meteo.hr/xsd/indeks.xsd"
                            + " " +
                            "/classes"
                            + " " +
                            $"/namespace:{ns}"
                            + " " +
                            "/language:CS"
                            + " " +
                            "/outputdir:./vrijeme.hr-meteo.hr/csharp/"
                    }
                );


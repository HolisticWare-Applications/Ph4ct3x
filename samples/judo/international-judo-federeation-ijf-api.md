# International Judo Federation IJF API

international-kudo-federeation-ijf-api.md

https://data.ijf.org/api/get_json?access_token=&params%5Bq%5D=cv&params%5Baction%5D=general.search_all

## `ijf.org`

### Rankings

#### Olympic Games

*   https://www.ijf.org/wrl_olympic?category=all_male

*   https://www.ijf.org/wrl_olympic?category=10

```
        var _CONF = {
            base_url: 'https://www.ijf.org',
            api_url: '/internal_api/',
            data_api_url: 'https://data.ijf.org/',
            judoka_url_template: '/judoka/__ID__',
            country_url_template: '/country/__IOC__',
            competition_url_template: '/competition/__ID__',
            news_url_template: '/news/show/__SLUG__',
            tag_url_template: '/news/search?tag%5B0%5D=tag%3A__ID__%3A__TEXT__',
            i18nLanguages: [{"code":"en_US","name":"English"}],
            i18nCurrentLanguage: 'en_US',
            video_library_url: '/video_library',
            search_url_template: '/search'
        };

```

preloads:

*   countries

### Search

https://www.ijf.org/search

https://www.ijf.org/search?q=&p=1

https://www.ijf.org/search?q=cvjetko&p=1


### Everything


## `judobase.ijf.org`

https://judobase.ijf.org/#/dashboard

Search Textbox Autocomplete:

*   url 

    *   `https://data.ijf.org/api/get_json?access_token=&params%5Bq%5D=fe&params%5Baction%5D=general.search_all`

    *   `https://data.ijf.org/api/get_json?access_token=&params[q]={search}}&params[action]=general.search_all`

        *   `https://data.ijf.org/api/get_json?access_token=&params[q]=cvjetko&params[action]=general.search_all`

        *   `https://data.ijf.org/api/get_json?access_token=&params[q]=kristo&params[action]=general.search_all`

*   Zagreb

## Categories

*   url

    *   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.all_categories&params%5B__ust%5D=

    *   https://data.ijf.org/api/get_json?params[action]=competition.all_categories

## Athlete

*   https://data.ijf.org/api/get_json?params[q]=kristo&params[action]=general.search_all

*   https://data.ijf.org/api/get_json?params%5Bq%5D=to&params%5Baction%5D=general.search_all

*   https://judobase.ijf.org/#/competitor/profile/29418

## Country

*   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=country.get_list&params%5B__ust%5D=

*   https://data.ijf.org/api/get_json?params[action]=country.get_list

*   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=country.get_list&params%5B__ust%5D=

*   https://data.ijf.org/api/get_json?params[q]=croatia&params[module]=country&params[action]=general.search_all

*   https://judobase.ijf.org/#/country/profile/44


## Competition

*   url

    *   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.all_categories

    *   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.get_list&params%5Byear%5D=2019&params%5Bmonth%5D=&params%5Brank_group%5D=&params%5Bsort%5D=-1

    *   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.get_list&params%5Byear%5D=2019&params%5Bmonth%5D=&params%5Brank_group%5D=

    *   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.get_list&&params%5Byear%5D=&params%5Bmonth%5D=&params%5Brank_group%5D=cont_champ&params%5Bsort%5D=-1

    *   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.get_list&&params%5Byear%5D=&params%5Bmonth%5D=&params%5Brank_group%5D=cont_champ&params%5Bsort%5D=-1

    *   https://judobase.ijf.org/#/competition/profile/1815

## Ranking

*   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=general.ranks&params%5B__ust%5D=


```
        // ... Target page.
        string page = "http://en.wikipedia.org/";

        // ... Use HttpClient.
        using (HttpClient client = new HttpClient())
        using (HttpResponseMessage response = await client.GetAsync(page))
        using (HttpContent content = response.Content)
        {
            // ... Read the string.
            string result = await content.ReadAsStringAsync();

            // ... Display the result.
            if (result != null && result.Length >= 50)
            {
                Console.WriteLine(result.Substring(0, 50) + "...");
            }
        }
```

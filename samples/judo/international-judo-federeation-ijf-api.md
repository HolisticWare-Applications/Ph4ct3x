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

*   https://www.ijf.org/search

*   https://www.ijf.org/search?q=&p=1

*   https://www.ijf.org/search?q=cvjetko&p=1

*   https://www.ijf.org/search?group=&q=cvjetko

*   Lara Cvjetko

    *   `www.ijf.org`

        https://www.ijf.org/judoka/29418/results?results_rank_group=all

    *   `judobase.ijf.org`

        https://judobase.ijf.org/#/competitor/profile/29418/results

#### Calendar

*   https://www.ijf.org/calendar?year=2019&month=&age=all

*   https://www.ijf.org/calendar?year=2019&month=&age=world_tour

*   https://www.ijf.org/calendar?year=2019&month=&age=sen

*   https://www.ijf.org/calendar?year=2019&month=&age=jun

*   https://www.ijf.org/calendar?year=2019&month=&age=cad

*   https://www.ijf.org/calendar?year=2019&month=&age=othr

*   https://www.ijf.org/calendar?year=2019&month=1&age=othr

#### Members

*   https://www.ijf.org/countries

*   https://www.ijf.org/countries/all/committee#select-dropdown

*   https://www.ijf.org/judoka?name=&nation=CRO&gender=both&category=all

*   https://www.ijf.org/judoka?name=&nation=CRO&gender=both&category=all

*   https://www.ijf.org/judoka?name=&nation=CRO&gender=m&category=all

*   https://www.ijf.org/judoka?name=&nation=CRO&gender=f&category=all

*   https://www.ijf.org/judoka?name=&nation=CRO&gender=f&category=3

```
<select name="category" id="">
<option value="all">All</option>
<option value="sen">All Seniors</option>
<option value="1">-60 kg</option>
<option value="2">-66 kg</option>
<option value="3" selected="">-73 kg</option>
<option value="4">-81 kg</option>
<option value="5">-90 kg</option>
<option value="6">-100 kg</option>
<option value="7">+100 kg</option>
<option value="8">-48 kg</option>
<option value="9">-52 kg</option>
<option value="10">-57 kg</option>
<option value="11">-63 kg</option>
<option value="12">-70 kg</option>
<option value="13">-78 kg</option>
<option value="14">+78 kg</option>
<option value="cad">All Cadets</option>
<option value="60">-50 kg</option>
<option value="61">-55 kg</option>
<option value="62">-60 kg</option>
<option value="63">-66 kg</option>
<option value="64">-73 kg</option>
<option value="65">-81 kg</option>
<option value="66">-90 kg</option>
<option value="67">+90 kg</option>
<option value="68">-40 kg</option>
<option value="69">-44 kg</option>
<option value="70">-48 kg</option>
<option value="71">-52 kg</option>
<option value="72">-57 kg</option>
<option value="73">-63 kg</option>
<option value="74">-70 kg</option>
<option value="75">+70 kg</option>
<option value="jun">All Juniors</option>
<option value="44">-60 kg</option>
<option value="45">-66 kg</option>
<option value="46">-73 kg</option>
<option value="47">-81 kg</option>
<option value="48">-90 kg</option>
<option value="49">-100 kg</option>
<option value="50">+100 kg</option>
<option value="52">-48 kg</option>
<option value="53">-52 kg</option>
<option value="54">-57 kg</option>
<option value="55">-63 kg</option>
<option value="56">-70 kg</option>
<option value="57">-78 kg</option>
<option value="58">+78 kg</option>
</select>
```

### Everything


## `judobase.ijf.org`

https://judobase.ijf.org/#/dashboard

Search Textbox Autocomplete:


## General

### `general.search_all`

*   url

    *   https://data.ijf.org/api/get_json?access_token=&params%5Bq%5D=fe&params%5Baction%5D=general.search_all

        *   https://data.ijf.org/api/get_json?params%5Bq%5D=to&params%5Baction%5D=general.search_all

        *   https://data.ijf.org/api/get_json?params[action]=general.search_all&params[q]={search}}

        *   https://data.ijf.org/api/get_json?params[action]=general.search_all&params[q]=cvjetko

        *   https://data.ijf.org/api/get_json?params[action]=general.search_all&params[q]=kristo


        *   https://data.ijf.org/api/get_json?params[action]=general.search_all&params[q]=kristo

        *   https://data.ijf.org/api/get_json?params[action]=general.search_all&params[q]=cvjetko

        *   https://data.ijf.org/api/get_json?params[action]=general.search_all&params[q]=zagreb

        *   https://data.ijf.org/api/get_json?params[action]=general.search_all&params[q]=bela

        *   https://data.ijf.org/api/get_json?params[action]=general.search_all&params[q]=che

### `general.get_one`

https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=general.get_one&params%5B__ust%5D=&params%5Bmodule%5D=competitor&params%5Bid%5D=1336

https://data.ijf.org/api/get_json?params[action]=general.get_one&params[module]=competitor&params[id]=1336

https://data.ijf.org/api/get_json?params[action]=general.get_one&params[module]=country&params[id]=1336

## Categories

*   url

    *   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.all_categories&params%5B__ust%5D=

    *   https://data.ijf.org/api/get_json?params[action]=competition.all_categories

## Athlete



*   https://judobase.ijf.org/#/competitor/profile/29418

## Country

### `country.get_list`

*   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=country.get_list&params%5B__ust%5D=

*   https://data.ijf.org/api/get_json?params[action]=country.get_list

*   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=country.get_list&params%5B__ust%5D=

*   https://data.ijf.org/api/get_json?params[q]=croatia&params[module]=country&params[action]=general.search_all

*   https://judobase.ijf.org/#/country/profile/44


## Competition

### Categories

*   url

    *   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.all_categories&params%5B__ust%5D=

    *   https://data.ijf.org/api/get_json?params%5Baction%5D=competition.all_categories

    *   https://data.ijf.org/api/get_json?params[action]=competition.all_categories

### Competitions by Year/Month

*   url

    *   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.get_list&params%5B__ust%5D=&params%5Byear%5D=&params%5Bmonth%5D=&params%5Brank_group%5D=&params%5Bsort%5D=-1

    *   https://data.ijf.org/api/get_json?params[action]=competition.get_list&params[year]=&params[month]=&params[rank_group]=

    *   https://data.ijf.org/api/get_json?params[action]=competition.get_list&params[year]=&params[month]=&params[rank_group]=cont_champ

    *   https://data.ijf.org/api/get_json?params[action]=competition.get_list&params[year]=2019&params[month]=6&params[rank_group]=cont_champ

    *   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.get_list&params%5Byear%5D=2019&params%5Bmonth%5D=&params%5Brank_group%5D=&params%5Bsort%5D=-1

    *   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.get_list&params%5Byear%5D=2019&params%5Bmonth%5D=&params%5Brank_group%5D=

    *   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.get_list&&params%5Byear%5D=&params%5Bmonth%5D=&params%5Brank_group%5D=cont_champ&params%5Bsort%5D=-1

    *   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.get_list&&params%5Byear%5D=&params%5Bmonth%5D=&params%5Brank_group%5D=cont_champ&params%5Bsort%5D=-1

    *   https://judobase.ijf.org/#/competition/profile/1815

## Competitor

### `competitior.get_list`

https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competitor.get_list&params%5B__ust%5D=&params%5Bweight%5D=&params%5Bcountry%5D=&params%5Bq%5D=

https://data.ijf.org/api/get_json?params[action]=competitor.get_list&params[weight]=&params[country]=&params[q]=tina

https://data.ijf.org/api/get_json?params[action]=competitor.get_list&params[weight]=&params[country]=Slovenia&params[q]=

### `competitior.get_info`

*   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competitor.info&params%5B__ust%5D=&params%5Bid_person%5D=1336

*   https://data.ijf.org/api/get_json?params[action]=competitor.info&params[id_person]=1336

### `competitor.wrl_current`

https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competitor.wrl_current&params%5Bid_person%5D=1336

https://data.ijf.org/api/get_json?params[action]=competitor.wrl_current&params[id_person]=1336

## Ranking

*   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=general.ranks&params%5B__ust%5D=

*   https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=general.ranks&params%5B__ust%5D=

https://data.ijf.org/api/get_json?access_token=&params%5Bq%5D=ts&params%5Baction%5D=general.search_all
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

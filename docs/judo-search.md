# Data Scraping - Judo

## IJF 

*   https://www.ijf.org/

### Home

*   https://www.ijf.org/

### Calendar

*   https://www.ijf.org/calendar

    https://www.ijf.org/calendar?year=2018

    https://www.ijf.org/calendar?year=${year}}&month=${month}&age=${age}

    age = 
    { 
        "all": "all",
        "world_tour": "IJF world tour", 
        "cad": "cadets",
        "jun": "juniors",
        "sen": "seniors",
        "othr": "other"
    }

    https://www.ijf.org/calendar?year=2017

    https://www.ijf.org/calendar?year=2018&month=12&age=world_tour

    https://data.ijf.org/api/get_json?params%5Baction%5D=competition.get_list&params%5Byear%5D=2018&params%5Bmonth%5D=05&params%5Bid_age%5D=SEN

    https://data.ijf.org/api/get_json?params[action]=competition.get_list&params[year]=2018&params[month]=05&params[id_age]=SEN

    https://www.ijf.org/internal_api/wrl?age=cad&category=72&limit=100&page=0

    72 - cadets + female + 57


```
<table class="table table--stripped table--hover table--responsive table--with-separator">
        <tbody>
                <tr data-event-row-link="/competition/1658" class=" ">
                    <td data-t="Date" class="">
                        <div class="calendar-date--short">
                                                            <div class="calendar-date--short__month">December</div>
                                <div class="calendar-date--short__days">
                                                                            15 - 16
                                                                    </div>
                                                    </div>
                    </td>
                    <td data-t="Icon" class="hide-r">
                        <div class="event_ico" style="background-image: url(https://res.cloudinary.com/duu3v9gfg/image/fetch/t_auto/https://78884ca60822a34fb0e6-082b8fd5551e97bc65e327988b444396.ssl.cf3.rackcdn.com/icons/continental/logo-jua.png);"></div>
                    </td>
                    <td data-t="Name" class="calendar-name">
                        <a href="/competition/1658" class="event-link-title">
                            Guangzhou Masters 2018
                        </a>
                        <br>
                        <span class="numericals">
                            <a class="event-link" href="/competition/1658/judoka_athletes">1 athlete</a>
                             - 
                            <a class="event-link" href="/competition/1658/judoka_nations">1 nation</a>
                        </span>
                    </td>
                    <td data-t="Location" class="calendar-location">
                        <a class="event-link" href="/country/chn">
                            <img class="flag" src="https://res.cloudinary.com/duu3v9gfg/image/fetch/t_flag_w_20/http://99e89a50309ad79ff91d-082b8fd5551e97bc65e327988b444396.r14.cf3.rackcdn.com/flags/320x240/chn.png" alt=""> China, Guangzhou
                        </a>
                    </td>
                    <td data-t="Links" class="hide-r event-subpages">
                                                    
                            <a class="event-link event-link--subpage" href="/competition/1658/judoka_athletes">Judoka</a>
                            <a class="event-link event-link--subpage" href="/competition/1658">Overview</a>
                                            </td>
                </tr>
        </tbody>
    </table>
```

### Judoka 

*    https://www.ijf.org/judoka

*   search 

    Kajzer
    Cvjetko 

    SLO

    https://www.ijf.org/judoka?name=Cvjetko&nation=CRO&gender=both&category=all

    https://www.ijf.org/judoka?name=Kajzer&nation=SLO&gender=both&category=all

    https://www.ijf.org/judoka?name=Cvjetko&nation=CRO&gender=both&category=sen

    https://www.ijf.org/judoka/37145/overview



### Rankings

https://www.ijf.org/wrl?age=cad&category=all

https://www.ijf.org/wrl?age=jun&category=all


### Countries (PRIORITY: LOW)

https://www.ijf.org/countries


## Judobase

*   Home: https://judobase.ijf.org/

*   Calendar

    https://data.ijf.org/api/get_json?access_token=&params%5Baction%5D=competition.get_list&params%5B__ust%5D=&params%5Byear%5D=2018&params%5Bmonth%5D=06&params%5Bid_age%5D=SEN

    https://data.ijf.org/api/get_json?access_token=&params[action]=competition.get_list&params[__ust]=&params[year]=2018&params[month]=06&params[id_age]=SEN

videos

https://judobase.ijf.org/#/media

https://data.ijf.org/api/get_json?access_token=&params[action]=contest.find&params[__ust]=&params[limit]=1&params[media]=1&params[order_by]=rand&params[round]=1&params[part]=info,video_num


https://data.ijf.org/api/get_json?access_token=&params%5Bq%5D=cv&params%5Baction%5D=general.search_all
https://data.ijf.org/api/get_json?access_token=&params[q]=cv&params[action]=general.search_all


https://data.ijf.org/api/get_json?access_token=&params[action]=competitor.place_by_rank&params[__ust]=&params[id_person]=29418


<table class="table js-tbl_latest_uploads">
    <tbody>
        <tr class="pointer" data-competition_code="cont_cup_jun_aut2018"><td>Leibnitz Junior European Cup 2018</td><td>7 days ago</td><td>153</td></tr>
        <tr class="pointer" data-competition_code="cont_cup_jun_aut2018"><td>Leibnitz Junior European Cup 2018</td><td>12 days ago</td><td>186</td></tr>
        <tr class="pointer" data-competition_code="cont_cup_cad_rou2018"><td>Cluj Napoca Cadets European Cup 2018</td><td>13 days ago</td><td>165</td></tr>
        <tr class="pointer" data-competition_code="eju_sen2018"><td>European Senior Championships 2018</td><td>17 days ago</td><td>7</td></tr>
        <tr class="pointer" data-competition_code="cont_cup_cad_cze2018"><td>Teplice Cadet European Cup 2018</td><td>19 days ago</td><td>324</td></tr>
    </tbody>
</table>

## Results

https://www.ijf.org/results?continent=3&year=2018&month=&age=all

https://www.ijf.org/results?continent=3&year=2018&month=&age=cad


## Judoinside

*   Home: https://www.judoinside.com/

### Judoka

https://www.judoinside.com/site/getJudokaSearchSuggestion?keyword=cvj
https://www.judoinside.com/site/getJudokaSearchSuggestion?keyword=cvjetko


https://www.judoinside.com/site/search?q=Lara+CVJETKO

redirect to : https://www.judoinside.com/judoka/97190/Lara_Cvjetko/judo-career


https://www.judoinside.com/site/search?q=Nina+CVJETKO


### Events

https://www.judoinside.com/event/latest

https://www.judoinside.com/event/types

https://www.judoinside.com/event/search?EventSearch%5Btype%5D=1&EventSearch%5Bname%5D=&EventSearch%5Byear%5D=&EventSearch%5Bcity%5D=&EventSearch%5Bcountry%5D=&yt0=Hajime

https://www.judoinside.com/event/search?EventSearch[type]=1&EventSearch[name]=&EventSearch[year]=&EventSearch[city]=&EventSearch[country]=&yt0=Hajime

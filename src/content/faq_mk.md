<h1>Често поставувани прашања</h1>

_Идејата на Трекер е да ги прикаже на едно место постоечките податоци во облик што секој може да го разбере. Без разлика на тоа се потребни одредени објаснувања. Тука ги собравме одговорите на некои најчести прашања. Листата на прашања ја прилагодуваме во зависност од тоа дали има нешто ново или за нешто се потребни подобри објаснувања. Доколку имате било какво прашање (или предлог за подобро објаснување) и тоа не постои во сегашниот FAQ, nратете ни го на info@treker.mk (Се радуваме на секакви критики, пофалби, повратни информации или предлози!)_

## TBD work in progress - содржината што следи сеуште се преведува и прилагодува. Таа му припаѓа на оригиналниот сајт, sledilnik.org 

## Општо за страната

<details>
  <summary id=why-sledilnik>Зошто Трекер?</summary>
Нашата цел е да помогнеме да го разбереме подобро ширењето на вирусот и да ја подигнеме свеста, одговорноста и ефикасноста на мерките за спречување на вирусот. Повеќе за иницијативата може да најдете во [About tab](/mk/about).

</details>

<details>
  <summary id=virus-vs-disease>Koja e разликата помеѓу SARS-CoV-2 и КОВИД-19?</summary>

**SARS-CoV-2** е кратенка од ‘Тежок акутен респираторен (дишен) синдром коронавирус 2’ –  и е интернационално прифатен назив за вирусот кој ја предизвикува болеста **КОВИД-19**. Вториот назив е исто така кратенка, образувана од зборовите КОрона ВИрус и годината кога за прв пат се појавува - 2019.


</details>

<details>
  <summary id=confirmed-cases>Која е разликата помеѓу ‘новоинфицирани’ и ‘потврдени случаи’?
</summary>
Терминологијата која се користи на Treker е објаснета во делот [Што значи](#chart-terminology). Според дефиницијата на Светската Здравствена Организација, за *потврден случај* се смета оној кај кој КОВИД-19 е потврден лабораториски, без оглед на клиничките знаци и симптоми. Други термини како ‘новоинфицирани’ може да се појават во медиумите, но не се користат во нашите графикони. Сите термини кои ги користи Трекер се објаснети во овие ЧПП. 

</details>

<details>
  <summary id=all-infected>Дали може да се добијат статистички податоци за сите сите инфицирани лица, дури и за асимптоматските случаи? </summary>

Засега, овие податоци се недостапни. Постојат и причини за тоа: Досега, тестовите вклучуваа само одреден процент на популација (пациенти со знаци и симптоми на акутна респираторна инфекција кои имаа потреба од клиничко лекување, медицински професионалци... ) Иако сега препораките за тестирање на КОВИД-19 се проширени и ги вклучуваат сите оние кои покажуваат знаци на болеста, многумина може да бидат носители, без или со благи симптоми.
Поради овие причини, нашата статистика може да покрие само одреден дел од популацијата кај која јасно се гледаат знаци на инфекција. Така, младата популација и оние кои не се тестирани  се непропорционално претставени. Податоци за асимптоматски пациенти не се заведени никаде и не можат да бидат обезбедени.


</details>

<details>
  <summary id=other-countries>Каде можам да најдам споредба меѓу Северна Македонија и други држави?</summary>

Можете да го најдете [графиконот за споредба](/mk/stats#countries-chart) во долниот дел на контролната табла. Тој ја преставува споредбата помеѓу Северна Македонија и други држави, т.е *бројот на смртни случаи* како последица на КОВИД-19, *на милион жители*. Групите од држави кои се споредени со Северна Македонија се: 
-   Критични земји (ЕУ)
-   Критични земји на глобално ниво
-   Државите од соседниот регион
-   Нордиските држави
-   Земјите од поранешна Југославија
-   Источно – Азиските земји и Океанија

Графиконот е хронолошки подреден, од 1 Јануари, од првиот смртен случај и од бројот на смртни случаи на милион жители, редоследно. Можете да го смените начинот на хронолошко претставување на споредбите меѓу групи од различни држави, со кликање на соодветното јазиче. 


</details>

<details>
  <summary id=english-translation>Дали веб страната постои и на англиски јазик?</summary>

Моментално, само [За проектот](/mk/about) и овие ЧПП страници се преведени. Другите се во план. Во секој случај и програмската кода и текстот се open source и ако ве интересира да помогнете во преводт тоа моќе да го направите. Сите [податоци](https://github.com/treker-mk) зе означени со ознаки (tag) на аглиски јазик, така да меѓународната употребата на сајтот е исто можна. 
 

</details>

<details>
  <summary id=are-you-paid>Дали сте платени за креирање на овие графикони, табели, мапи?</summary>

Не. Treker претставува непрофитна иницијатива, создадена да ги поддржи тековните случувања и клучните податоци за ширењето на коронавирусот во Северна Македонија. Нашата база на податоци е јавна и достапна, бесплатна и некомерцијална, и како таква ќе остане. проверете [Како можам да пристапам и да ја користам вашата база на податоци?](#data-usage)

</details>

<details>
  <summary id=tech-used>Кои алатки се користени за изработка на веб страницата/ веб апликацијата?</summary>

Веб странаta е изработена во JavaScrıpt со користење на Vue.js, визуелизацијата и графиконите се создадени во F# со користење на Highcharts libraries, a проектот е отворен и достапен на  [GitHub – Treker](https://github.com/treker-mk).

</details>

## Податоци

<details>
  <summary id=data-reliability>TBD Дали вашите податоци и визуелизација се веродостојни?</summary>

TBD Data is collected from verified public sources, which are listed in the [Resources tab](/mk/sources). 

Трекер моментално собира официјални податоци за КОВИД-19 директно од Министерството за Здравство, Институтот за Јавно Здравје и останатите државни здравствени институции. Тимот на Treker не ја гарантира веродостојноста на оригиналните податоци и ги објавува само оние податоци добиени од официјални извори или медиуми, но секако дека правиме повторна проверка доколку податокот е точен и се усогласува со дадениот извор. 
</details>

<details>
  <summary id=data-collection>TBD На кој начин ги добивате и обработувате податоците?</summary>

[Базата на податоци](https://docs.google.com/spreadsheets/d/) TBD iе изградена врз основа на податоците од Институтот за Јавно Здравје (по категории). Податоците по региони и возраст се обработувааат со одложување и се поставуваат на страната само кога резултатите од тековните епидемиолошки истражувања се веќе ажурирани. Застапеноста по општини може да се следи на [TBD Kraji (места) табелата](https://docs.google.com/spreadsheets/d/)TBD.

Обработка на податоците добиени од болниците – [TBD Табела Pacienti (Patients)](https://docs.google.com/spreadsheets/d/):

- Би сакале да добиваме дневни извештаи, а ги следиме објавите на сите КОВИД-19 центри.

- Го следиме бројот на хоспитализации: сите хоспитализирани, бројот на тие кои се на интензивна нега и бројот на пациенти кои се на респиратори. 

- Ги документираме индивидуалните промени во фазите на болеста (тогаш кога е можно да се детектираат)

- Кога информацијата за промената е некомплетна, вредностите се одредуваат со формула.

- Се трудиме сите извори и заклучоци да се документирани и да може да се проверат.  

- Податоците се споредени со оние податоци кои се добиени од пациентите  хоспитализирани на Интензивна нега и се објавени од страна на институциите на Владата на Република Северна Македонија. 
  
  </details>

<details>
  <summary id=data-publish-time>TBD Кога ги објавувате податоците? Зошто датумите на визуелизациите се различни?
</summary>

Повеќето податоци добиени претходниот ден ги обработуваме до 23ч. и 59мин. (тестови, потврдени случаи...). **Нашите податоци најчесто се ажурираат помеѓу ХХХч и ХХХч**
WКога ги објавуваме дневните податоци, тие се достапни на нашите канали за дистрибуција (CSV, REST, веб страниците), а исто така известуваме и на социјалните мрежи ([Facebook](https://www.facebook.com/Covid19TrekerMK) и [Twitter](https://twitter.com/Covid19TrekerMK)).

</details>

<details>
  <summary id=data-differences>Други портали објавуваат број на заразени, различен од вашиот. Зошто е тоа така??</summary>

Treker објавува само потврдени и официјални податоци од Институтот за Јавно Здравје и сите КОВИД-19 центри ширум Северна Македонија. На тој начин нашите податоци доаѓаат од сигурни извори, а располагаме и со проверени податоци од самиот почеток на епидемијата. Разликите најчесто се појавуаат затоа што различни портали објавуваат податоци во различен период од денот или користат поинаква методологија. Погледни  [Дали вашите податоци и мапи се веродостојни? ](#data-reliability) 

</details>

<!--COMENT TEMPORARRTILY

<details>
  <summary id=data-hospital-in> TBD 6.	Како добивате податоци за хоспитализација на пациентите (болни од КОВИД-19)?</summary>

Болниците не секогаш известуваат за точниот број на прием и отпуст за да можеме да добиеме прецизни податоци. Бројот на новохоспитализирани вообичаено се пресметува од бројот на веќе хоспитализираните и од разликата споредена со претходниот ден, на која и го додаваме бројот на отпуштени и бројот на починати од дадениот ден. Ажурираме податоци за прием и отпуст на пациенти на интензивна нега и за приклучување и исклучување на/од механичка  вентилација, кои се пресметуваат на сличен начин.

</details>

<details>
  <summary id=data-hospital-out>How do you obtain data on hospital discharges?</summary>

The information on the discharged from hospitals is calculated from data daily obtained directly from hospitals, i.e. from a verified source. We mostly get the daily number of discharges for all hospitals, from which we can deduce the number of newly admitted. See also [How do you obtain data on hospital admissions?](#data-hospital-in)

</details>

<details>
  <summary id=data-recovered>Зошто бројот на *излечени* се заменува со број на *оздравени*?</summary>

Во врска со бројот на излечени, податоците кои беа презентирани на Treker се засновуваа само на официјални извори (Владини институции на Република Македонија, медиуми). Република Северна Македонија е една од ретките земји во светски рамки каде се тестираат и пациентите со благо изразени симптоми, 14 дена по првиот позитивен тест и се третирани исто како отпуштените пациенти.  


</details>

<details>
  <summary id=data-active-cases>Do you keep an Active Case counter and do you know how many people are currently infected?</summary>

Yes, these indicators have been graphically displayed as **Confirmed Cases (active)** and **Recovered (total)** from the end of April.
 

These visualizations are not data from public sources; both indicators show the calculated value on the basis of official data, so they are indicated by a dashed line for easier distinguishing. 

*Note: In some cases when the government is not reporting such cases within smaller clusters, like municipalities,  ee now consider a patient has recovered in 14 days after their infection was confirmed as per ECDC formulas of calculating recovered cases. 

Value formula:
- Recovered (total) = Confirmed cases (total) 14 days ago – Died (total) by the day of calculation

- Confirmed cases (active) = Confirmed cases (total) - Recovered (total) - Died (total)

</details>

<details>
  <summary id=data-contribute>How can users get actively involved in data gathering? How can I participate?</summary>

You can voluntarily help by collecting and verifying data from the media (as well as from the field), with statistical and other analyzes, etc. Contact us at info@treker.mk if you’d like to participate.

Treker does not collect users’ personal information nor information that individuals would like to share about their condition or hospital status.

</details>

------------ END COMMENT-->


<details>
  <summary id=data-usage>How can I obtain and use your database?</summary>

Our database is public and freely available in the form of  [**CSV**, **REST**, and **Google Sheet**](/mk/datasources). Kindly let us know the purpose for which you will use the information and make sure you include Treker as the source of your data.

Since all the data in the database is already marked with English tags (see also [Is your webpage available in English?](#english-translation)), their international use (export, display) is also possible.

</details>

## About the calculations and graphs


<details>
  <summary id=chart-usage>Can I use your graphs on my website? How?</summary>

Sure! You can embed any graph or display on your site – citing the source, of course. [Click here](/mk/embed) and select the graph you want to embed from the list. Please let us know about your use (info@slednik.org) and we will be happy to add your site to our collection of [recommended links](/mk/links). 

</details>

<details>
  <summary id=chart-infocard-percent>What do the percentages in the infocards at the top of the webpage mean?</summary>

This is a percentage growth rate on a particular date in the number of newly confirmed cases compared to the previous day. If, for example, there were 16 people in the intensive care unit yesterday and today they accepted four more, that is 25% more than yesterday's situation.

</details>

<details>
  <summary id=metrics-comparison-chart>TBD What does the “COVID-19 Situation in North Macedonia” graph mean?
</summary>

The [graph](/mk/stats#metrics-comparison-chart) shows the daily and overall dynamics of the spread of the infection from the beginning to the present. The indicators used (see [Which indicators does the “COVID-19 Situation in North Macedonia” graph include?](#chart-metrics-included)) help us understand whether and how successfully we are controlling the spread of the virus. We can monitor the daily growth rate of newly confirmed cases and indirectly see if the measures work; information on the number of hospitalizations and the proportion of those in ICU shows how many people are seriously at risk from the disease, but at the same time, this data also shows us the real burden on the health system.

The breakpoints are indicated below, on the timeline: from the first confirmed case (TBD date) to the measures (by keyword and date) taken to curb the spread and their relaxation. This helps us monitor the dynamics of the variables relative to the measures.

</details>

<details>
  <summary id=chart-metrics-included>Кои индикатори ги содржи графиконот “Состојба со COVID-19 во Република Северна Македонија”?</summary>

[Графиконот](/mk/stats#metrics-comparison-chart) содржи:
  
* **Тестови (дневно)** = се изведуваат голем број на тестови за SARS-CoV-2 вируот што предизвикува COVID-19. Во првите фази на епидемијата, е ова важен инидкатор што може да покажува на раширеност на вирусот во популацијата. 

* **Тестови (вкупно)** = Се сума на сите тестови изведени до тој датум. Овој број треба да се земе со резерва, бидејќи некои луѓе се тестираат повеќе пати (пр. оздравените, здравствените рабоници, ...)

* **Позитивни случаи (дневно)** = Бројот на потврдени случаи на двена база. Овој показател не ја отсликува актуелната динамика на новозаразените луѓе во целата популацијата, бидејќи добар дел од тестовите се усмерени на одредени популации. Дали заради тоа што тоа им го бара професијата или дали заради тоа што веќе биле во контакт со заразени.  

* **Позитивни случаи (вкупно)** = Вкупен број на потврдени случаи до тој ден.

* **Потврдени случаи (активни)** = Потврдени случаи (вкупно) – Оздравени (вкупно) – Починати вкупно)

* **Оздравени(вкупно)** = Сите оздравени до тој ден. (#data-recovered)

* **Хоспитализирани (активни)** = Моменталниот број на луѓе во болница (заедно со тие што се на интензивна нега).

* **Хоспитализирани (вкупно)** = Сите хоспитализирани до тој ден.
<!--COMMENT OUT
* **ICU (active)** = Current number of people in ICUs (intensive care units).

* **On ventilator (active)** = Current number of persons in need of a ventilator.

* **Discharged from a hospital (daily)** = Number of discharged from hospital on that day.

* **Discharged from hospital (total)** = Sum of all discharged from a hospital up to this day.
----COMMENT OUT END-->
* **Починати (дневно)** = Починати пациенти со COVID-19 на тој датум.

* **Починати (вкупно)** = Сите починати до тој ден од COVID-19.

</details>

<details>
  <summary id=chart-terminology>Што тие значат?
</summary>

Трекер користи терминологија што е конзистентна со директивите на WHO и ECDC (European Center for Disease Prevention and Control). Ги употребуваме следните ознаки при прикажувњето:

* **Потврдени случаи** = Ова е бројот на луѓе кои биле позитивни на тестот за SARS-CoV-2 вирусот. Бројот на потврдени случаи секако е зависен од бројот на тестовите и за тоа може да се случи да е бројот на потврдените случаи значително помал од вистинскиот број на заразени луѓе.

* **Хоспитализирани** = го представува бројот на луѓе со потешка слика или ризик за компликации од COVID-19, за која е потребен прием и  лечење во болница. 

* **На оддел за интензивна нега (анг. ICU)** = го прикажува бројот на пациенти каде што постои уште потешка слика и поголем ризик од смрт од COVID-19. Заради тоа е потребна интензивна нега, меѓу другото, со различни типови на кислородна подршка. Овие пациенти се подмножество на категоријата **Хоспитализирани** 

* **На респиоратор/вентилација** = ова се пациенти од интензивната нега на кои им е потреба механичка (со помош на пумпа) вентилација, бидејќи сами не се способни да дишат иако добиваат обична кислородна подршка. Тие се обично подмножество на пациентите што се на **Инетнзивна нега** и **Хоспитализирани**

* **Оздравени** = го представува бројот на пациенти што не се веќе болни од COVID-19 и нивните последни тестови биле негативни. (#data-recovered)
  
</details>

<details>
  <summary id=cases-chart>Што се Заклучени, а што Активни случаи?</summary>

Сите потврдени случаи се прикажани во [графиконот на потврдени случаи](/mk/stats#cases-chart). За да подобро ја следиме епидемијата, е од голема важност да се знае уште колку луѓе се сеуште заразни за другите. Заради тоа ја воведуваме следната терминологија:

**Заклучени случаи** се збир на сите потврдени случаи што не се веке инфицирани со вирусот, значи сите оздравени и починати. 

**Активни случаи** се сите потврдени случаи што уште не оздравеле. Погледајте уште [Кои индикатори ги содржи графиконот “Состојба со COVID-19 во Република Северна Македонија”?](#chart-metrics-included)

</details>

<!--COMMENTING SOME FAQ FOR THE FIRST VERSION
<details>
  <summary id=chart-phases>What do the different phases (phases 1-N) in the graph mean?</summary>

The vertical lines divide the stages, delimited by the dates, when the authorities changed the way information about the spread of the infection was collected (the test method was changed, self-isolation interventions were introduced, bans on gathering and movement of persons, and mandatory basic protection were required).

The phases are shown because the change in testing methodology has also changed the importance of certain indicators by which the prevalence of infections can be judged.

* **Phase 1 (TBD, 2020)**: The first cases of infection in Noth Macedonia are recorded. All cases are followed, all contacts are tested.

* **Phase 2 TBD date)**: ...

* **...**: ...

</details>

<details>
  <summary id=patients-chart>TBD What does the “Hospitalizations” graph tell us?</summary>

The [graph](/mk/stats#patients-chart) in the default view *All Hospitals* shows us the whole picture of hospitalizations by date arranged by the condition of patients: columns with a positive value (those above the horizontal axis) show the number admitted to hospital, the number hospitalized, shades of red are used to demark individuals in ICUs, specifically depicting how many of these are in critical condition on the ventilators. Columns with a negative value (those below the horizontal axis) show the number of discharges and deaths that day. You can also select specific hospital and see only hospitalizations there. If you select the *By Hospitals* view below, you can see the number of people in hospital care by day for each of the COVID-19 hospitals.  
The graph can offer a good insight into the workload of hospitals and can be the basis for assessing hospital capacity and planning their possible increase.

</details>

<details>
  <summary id=hcenters-chart>What does the “Healthcare Center Treatment” graph mean?</summary>

The [graph](/mk/stats#hcenters-chart) shows the treatment of suspicions of COVID-19 in healthcare centers (primary health care level). You can show data for whole country or select specific region. Healthcare centers are the first entry point for taking swabs to be tested for the presence of the virus, so an increase in the number of suspicions and referrals to self-isolation may be an early indicator that new outbreaks have occurred.

The graph thus shows the number of all emergency medical visits (also for other diseases) in healthcare centers (see notes below), the number of suspected cases of COVID-19 based on the number of examinations at the COVID-19 entry point, and all suspicions of infections based on telephone conversation with suspected infected patients. Some people may be recorded several times, first by telephone and then during the examination. We also show the total number of referrals to self-isolation.


When reporting the number of tests performed, all tests (including repeated tests) are recorded. The number of positive tests therefore includes all positive tests – the same person can be tested several times and counted as positive several times. The number of tests performed may therefore be greater than the number of positive tests reported by laboratories (there, each person is recorded only once). See also [What does the “Testing” graph tell us?](#test-charts) 

</details>

END OF COMMENTS-->

<details>
  <summary id=tests-chart>Што ни прикажува графиконот “Тестирање”?</summary>

[Графиконот](/mk/stats#tests-chart) ни го покажува бројот на сите редовни тестарања (избрано *Редовно*) со тестовите од истражувањата/скрининзите (со избор на *Истражување* приказ). Колоните во хистограмот ги прикажуваат позитивните и негативните тестови во одреден ден, а кривата го прикажува процентот на позитивни тестови. 


</details>

<details>
  <summary id=infections-chart>Што ни покажува графиконот „Структура на  потврдените случаи“?</summary>

[Графиконот](/mk/stats#infections-chart) ни овозможува да го погледаме уделот во потврдените случаи на група на вработени во ризичните струки.  Бидејќи прецизноста на потврдените инфекции не е најдобра, дневните вредности се покажани како просек од 5 дена. Збирот на вредностите за одреден ден, со два дена пред и два дена по тој ден, се делат со 5. Со тоа полесно се следи трендот на одредените групи. Ако избереме *Вкупно* или *Релативно*, ќе добиеме графикон со хистограми, наместо со криви. Тие хистограми ни го покажуваат односот на различните категории на одреден ден. 

Порастот на заразени здравствени работници не значи дека тие биле одкриени токму тој ден; тие може да биле и позитивни на тестовите и пред тоа, бидејќи здравствените работници се тестираат редовно. 

</details>

<details>
  <summary id=spread-chart>Што значи графиконот „Пораст на потврдени случаи“?</summary>

[Графиконот](/mk/stats#spread-chart) ни прикажува колку нови потврдени случаи на заразени лица има во одреден ден, каде следи дефиницијата на СЗО и [ECDC](https://www.ecdc.europa.eu/en/case-definition-and-european-surveillance-human-infection-novel-coronavirus-2019-ncov) според која потврдени случаи се „лица со лабораториска потврда за зараза со КОВИД-19“. Поради тоа што бројот на потврдени случаи сè уште зависи од тестирањето, податоците на потврдени случаи се проценува дека се многу помали од реалниот број на заразени лица.
  
</details>
<!--COMMENTING SOME FAQ FOR THE FIRST VERSION
<details>
  <summary id=regions-chart>Што ни кажува „Потврдени случаи по региони“?</summary>

[Графиконот ](/mk/stats#regions-chart) ни ја прикажува динамиката на раст на потврдени случаи по избраните региони. Поединечните региони можат лесно да се споредат со избирање на оние што сакате да бидат прикажани на графиконот со притискање на одредени региони под графиконот. Од кривата, можеме брзо да видиме кои региони имаат најмногу и кои најмалку потврдени случаи и како овој број се менувал со тек на време.

</details>

<details>
  <summary id=map-chart>TBD Што ни покажува ‘Карта на општини’?</summary>

[Картата](/mk/stats#map-chart) ни ја покажува епидемиолошката слика на одделни општини, бидејќи овозможува прикажување на *Потврдени случаи* (црвени нијанси) или *Смртни случаи* (сиви нијанси). При покажуваме на потврдени случаи, можеме да видиме кои општини се „најздрави“ (бели) и кои во моментот се „најзаразени“ (црвени нијанси) - дали уште се појавуваат нови случаи или не - и во однос на учеството на населението (Пропорцијата/уделот на населението е стандарден приказ). На левата страна, можеме да го користиме филтерот (7, 14 или 21 денови) за да одредиме во кој временски период гледаме податоци за нови потврдени случаи или смртни случаи. За оние општини каде сè уште се потврдуваат нови случаи, можеме да заклучиме дека епидемијата е сè уште активна. (Се разбира, тоа не мора да значи дека вирусот не е присутен во општините без нови потврдени случаи, но тој е индикатор за „здравјето“ во одредена област.) Повеќе детали се достапни во статијата [Kje so “zdrave” občine? (Where Are the ‘Healthy’ Municipalities?)](https://medium.com/sledilnik/kje-so-zdrave-ob%C4%8Dine-613afc42b023) 

Со притискање на *Апсолутно* во горниот десен агол, можеме да го промениме приказот и да го видиме вкупниот број на новопотврдени случаи или смртни случаи во избрана временска рамка (7, 14 или 21 денови) во општините според тоа како се обоени.

</details>
-------END OF COMMENTS-->

<details>
  <summary id=municipalities-chart>TBD Што ни покажува графиконот ‘Случаи по општини’?</summary>

[Графиконот](/mk/stats#municipalities-chart) прикажува во повеќе детали поединечни општини во колони со број на потврдени случаи по денови, со активни случаи, оздравувања (проценка) и смртни случаи во секоја општина. Под општината можете да ги најдете информациите за времето од последниот потврден случај. Општините се класифицираат според тоа кога е регистриран последниот потврден случај, од каде можеме да заклучиме кои општини во моментот се ‘позаразени’ и кои се „поздрави“ од другите.

Приказот може да се смени со избирање на различни прикази над графиконот: ако изберете *Активен* приказ, општините ќе бидат подредени според тековната проценка на активните случаи; или ако изберете *Сите*, тогаш општините ќе бидат уредени според најголемиот вкупен број на потврдени случаи. Ако ги изберете *Сите региони* од паѓачкото мени, тогаш потврдените случаи ќе бидат прикажани во општините кои припаѓаат на тој регион. Можете исто така лесно да пребарувате општина со внесување на името во прелистувачот *Пронајди општина*.

*Забелешка: проценката на оздравените лица и активните случаи се врши 14 дена по потврдување на заразувањето, доколку и кога болеста има лесна форма. Меѓутоа, ако некое лице е хоспитализирано, ова оздравување ќе трае подолго, но во овој случај лицето не е опасно за околината затоа што е во болница. Поради фактот дека во општинската презентација не ги земаме предвид хоспитализираните, можно е збирот на активни случаи по општина да не одговара на проценката на активните случаи за целата држава. Погледнете исто така, [Дали имате бројач на активни случаи и дали знаете колку луѓе се заразени во моментот?](#data-active-cases)*

</details>
<!--COMMENTINT OUT
<details>
  <summary id=age-groups-chart>TBD Што прикажува графиконот ‘Возрасни групи’?</summary>

[Графиконот](/mk/stats#age-groups-chart) ја прикажана старосната структура на сите потврдени случаи со коронавирус и смртни случаи. Графиконот исто така прикажува поделба според пол. Приказот покажува апсолутни вредности и може да се смени во горниот десен агол на *Релативниот* приказ за подобар увид во тоа како е стапката на смртност од КOVID-19 релативна на општата популација во текот на целото времетраење на епидемијата. Кај Релативен приказ, подолу има опции за различни прикази: со избирање на *Сооднос на потврдени случаи*, ќе се прикаже уделот на потврдени случаи во одредена возрасна група. Со избирање на *Стапка на смртност*, ќе го видиме бројот на смртни случаи по големината на населението. Со избирање на *Смртни случаи* по бр. на потврдени случаи, можеме да разбереме каков бил соодносот на смртни случаи во одредена возрасна група во однос на бројот на потврдени случаи.

Демографијата може да ни помогне да разбереме како се ширела пандемијата и зошто непропорционално влијае на одредени возрасни групи. Според досега познати податоци, КОВИД-19 е поопасен за постарите лица и лица со коморбидитет, а според некои податоци машките се поизложени. Меѓутоа, за да ги разбереме сите фактори, треба да добиеме повеќе податоци: какви коморбидитети биле, социо-економската состојба на пациентите, географската област и сл. 

*Забелешка: За разлика од другите податоци што се објавуваат редовно според различни категории, официјалните извори добиваат демографски податоци со задоцнување (возраст, општина...), така што овие обично се знаат со еднодневно одложување. Ова е исто така причина што на приказот според Возрасни групи може да има некои отстапувања од податоците на други прикази, како што се пониски вредности на бројот на потврдени случаи и смртни случаи.*
 
</details>

<details>
  <summary id=countries-chart>Што прикажува графиконот ‘Споредба по држава’?</summary>

[Графиконот](/mk/stats#countries-chart) прикажува споредба меѓу Северна Македонија и различни групи на земји во однос на бројот на починати како резултата на КОВИД-19 за милион жители. Графиконот е хронолошки уреден. Можете да го промените изгледот на различните хронолошки прикази на различните групи на земји со притискање на соодветните картички подолу. 

</details>
-----------------END OF COMMENT-->
<details>
  <summary id=chart-reality>Дали вашите графикони ја прикажуваат реалната слика?</summary>

Да, колку што е тоа возможно, со оглед на ограничувањата на тековните прикази и на самите податоци: графиконите на оваа страница го прикажуваат само она што може да се заклучи од дадената информација. На пример, вкупниот број на тестови го претставува бројот на извршени тестирања до денес, но не го одразува вкупниот број тестирани лица, бидејќи некои лица, како што се здравствените работници и лица за кои постои сомневање дека се заразени, биле тестирани во повеќе наврати.

Како и да е, бројот на потврдени случаи зависи исклучиво од тестирањето. Бидејќи поголемиот број од заразените лица, кои имаат лесни или немаат никакви симптоми, воопшто не биле тестирани за КОВИД-19, бројот на потврдени случаи е значително помал од вистинскиот број заразени лица.


</details>

## За проектот

<details>
  <summary id=what-is-sledilnik>Што е Трекер?</summary>

[Трекер](/mk/about) е проект со отворени податоци и извори кој собира, анализира и прикажува некои од најкорисните податоци, за да полесно се разбере ширењето на пандемијата на коронавирусот и болеста КОВИД-19, заедно со нејзината динамика и обем. Целта ни е да направиме јасни графички и статистички визуелизации/прикази во врска со тоа што ни го кажуваат тековните податоци и анализи за ширењето на вирусот во Северна Македонија и да се осигуриме дека информациите за големината и сериозноста на проблемот КОВИД-19 во Северна Македонија бидат достапни и разбирливи за сите.

</details>

<details>
  <summary id=add-link>Би сакал/а да препорачам корисен линк, кој не е сеуште меѓу вашите ‘Препорачани линкови’, но би требало да биде. Дали ќе го додадете?</summary>

Контактирајте не на info@treker.mk – ние ќе го разгледаме предложениот линк и ако е веродостоен и корисен, ќе ни биде драго да го вклучиме во нашите препорачани  [линкови](/mk/links).

Ако би сакале да одите чекор напред и да придонесете кон нашата заедничка цел, поднесете Pull-Request (PR) на [GitHub](https://github.com/treker-mk/website/blob/master/src/content/links_mk.md).

</details>

<details>
  <summary id=how-to-help>Би сакал/а да помогнам, каде може да започнам?</summary>

Контактирајте не на info@treker.mk и објаснете накратко кои сте и како може да придонесете кон проектот. Помошта е добредојдена.

</details>

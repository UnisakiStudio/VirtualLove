# Virtual Love

VRChat-avatareille tarkoitettu työkalu, jolla voit ottaa kumppanin kanssa pariasentoja kolmen pisteen seurannalla tai työpöytätilassa. Mukana on 22 asentoa miehelle ja 22 naiselle, yhteensä 44. Mukana ovat myös seisova spagaatti ja Jack-O-haaste.

Tämä README koskee kehitteillä olevaa versiota v3.2.0. Virallista julkaisupäivää ei ole päätetty. Asennetun version näet Inspectorin yläosasta.

- [BOOTH-tuotesivu](https://yunisaki.booth.pm/items/3641334)
- [Muutosloki](CHANGELOG.md)

## Näyttökieli ja offline-ohjeet

Valitse näyttökieli Inspectorin yläosasta kohdasta ”Language / 言語”. Sama valinta koskee Inspectoria ja luotavaa VRChat-valikkoa. Lataa avatar uudelleen palveluun, jotta pelissä näkyvä kieli vaihtuu.

Jos kieltä ei ole valittu, käytetään tietokoneen kieltä tai englantia, jos kieltä ei tueta. Windows, macOS ja Linux ovat tuettuja. Viimeksi valittu kieli tallennetaan EditorPrefsiin, ja sitä käytetään myös tämän tietokoneen saman käyttöjärjestelmäkäyttäjän muissa projekteissa. Kaikki poseeraustyökalut ja avatarit käyttävät samaa kieltä. Kielen vaihtaminen minkä tahansa työkalun Inspectorissa päivittää yhteisen asetuksen; avatarikohtaisia kielivalintoja ei käytetä. Valintaa ei synkronoida muihin tietokoneisiin. Lisenssin tallennustapa ei muutu. Kielipainike näkyy vain ensimmäisessä asennusvahvistuksessa, jos kieltä ei ole tallennettu. Myöhemmät kielenvaihdot tehdään Inspectorissa.

Voit valita README:n tai muutoslokin mukana toimitetusta [kieliluettelosta](../index.html). Myös Inspectorin ”Käyttöohje” ja ”Näytä muutokset” noudattavat valittua kieltä. Mukana olevien asentojen nimet ja pelinsisäisen valikon luokkien nimet näytetään niin ikään valitulla kielellä. Käyttöehdot toimitetaan entiseen tapaan japaniksi.

## Asennus

1. Tuo ostamiesi tiedostojen mukana toimitettu ”VirtualLove_Boy.unitypackage” tai ”VirtualLove_Girl.unitypackage” Unityyn.
2. Kun paketin jakelulähde on rekisteröity, voit lisätä Virtual Loven projektiisi VCC:llä tai ALCOMilla. Unisaki Posing System 3.2.0 vaaditaan.
3. Napsauta Hierarchyssa avataria hiiren kakkospainikkeella ja valitse ”Unisaki Studio > Lisää Virtual Love (mies)” tai ”Unisaki Studio > Lisää Virtual Love (nainen)”.
4. Valitse avatarin sisään lisätty ”三点だいしゅき(男)” tai ”三点だいしゅき(女)” ja määritä käytettävät toiminnot ja asennot Inspectorissa.
5. Tarkista asennot esikatselulla ja lataa avatar palveluun tavalliseen tapaan.

Vaatimukset ovat Unity 2022.3, VRChat Avatars SDK 3.10.4 tai uudempi, Modular Avatar 1.x vähintään 1.15.1 ja NDMF 1.x vähintään 1.14.0. Päivitä tarvittavat paketit yhdessä VCC:llä tai ALCOMilla.

## Päivittäminen vanhemmasta versiosta

Päivitä tämä tuote ja Unisaki Posing System yhdessä. Kohtaukseen sijoitettujen työkalujen asetukset säilyvät. Tarkista käytössä olevat toiminnot ja ExpressionParameters-kulutus Inspectorista. Jos käytit esikoontia, paina ”Päivitä esikoonti” ennen uudelleenlatausta.

## Asetusten sijainti

| Välilehti | Tärkeimmät asetukset |
| --- | --- |
| Toiminnot | Pelinsisäisen valikon lisäykset, Kuvatila, hengitys, kuvakkeet ja parametrien käytön tarkistus |
| Asennot | Käytettävät asennot, haku, lisääminen, järjestäminen, esikatselu ja animaatiosäätö |
| Avatarin asetukset | Kehon korjaus, alkuperäisen asennon ja omien liikkeiden tuonti, esiasetukset |

Ota tarvitsemasi toiminnot käyttöön ennen kuin lataat avatarin palveluun. Kohdissa, joissa on ”Avaa asetukset”, voit näyttää tarkemmat asetukset kohdan alla.

## Pelin perusohjaimet

Avaa Expressions-valikko ja valitse Virtual Loven asento. Valitse miehelle ja naiselle toisiaan vastaavat asennot ja sovita sijaintisi ja suuntasi kumppanin kanssa.

Vaihtamalla pään, käsivarsien ja jalkojen lukituksia voit säätää, mitkä kehonosat seuraavat liikkeitäsi. Kun ”Lukitse jalat” on käytössä, voit liikuttaa päätä alavartalon pysyessä asennossaan. Jos haluat peilata asennon tai säätää sen korkeutta, ota vastaavat toiminnot käyttöön Unityssa etukäteen.

### Kuvatila

Voit siirtää oman avatarisi paikkaan, jossa näet sen, säätää sen suuntaa ja ottaa kuvia.

1. Ota Unityssa käyttöön ”Toiminnot > Valikkotoiminnot > Kuvatila”.
2. Avaa VRChatissa ”Kuvatila” ja valitse haluamasi asento kohdasta ”Valitse asento”.
3. Siirrä avataria kohdasta ”Etäisyys” enintään 3m eteenpäin. Kun etäisyys on suurempi kuin 0, avatar kääntyy sinua kohti.
4. Kierrä avataria kohdasta ”Suunta” ja ota tarvittaessa ”Lukitse jalat” käyttöön, kun paikka on kohdallaan. Jalkoja ei lukita automaattisesti alussa, joten voit säätää paikkaa ennen lukitusta.
5. Kun olet valmis, paina ”Lopeta kuvaus”. Etäisyys ja suunta palautuvat ja jalkojen lukitus vapautuu.

Jos olet lisännyt valikkoon kohdan ”Eleet pois”, voit vaihtaa käden asentoa myös Kuvatilassa.

Kun muutat sijaintia ja suuntaa vain omalla näytölläsi, Kuvatilan synkronoituja parametreja ei käytetä. Jos haluat muidenkin näkevän saman sijainnin ja suunnan, ota Unityssa käyttöön ”Toiminnot > Lisätoiminnot > Synkronoi Kuvatila”.

Jos oma pääsi katoaa näkyvistä lähelle tullessaan ja kuvaaminen on vaikeaa, ota käyttöön ”Pidä pää näkyvissä Kuvatilassa”. Asetus vaikuttaa omaan näkymääsi kuvauksen aikana, ja sen jälkeen näkymä palaa tavalliseksi.

### Jalkojen korkeus ja lattian korkeus

Kun otat haluamasi kohdat käyttöön Unityn kohdassa ”Toiminnot > Valikkotoiminnot”, ne lisätään VRChatin ”Asetukset”-valikkoon.

- **Jalkojen kork.**: säätää jalkojen puolen korkeutta pitäen pään paikallaan. Käytä sitä, kun jalat uppoavat lattiaan tai leijuvat sen yläpuolella tai kun haluat sovittaa korkeuden kumppanin kanssa.
- **Lattian kork.**: siirtää koko kehoa pää mukaan lukien ylös ja alas. 50% on alkuperäinen korkeus, 0% on 3m alempana ja 100% on 3m ylempänä. Palauta arvo lähelle 50%, kun haluat palata alkuperäiseen korkeuteen.

Yhdessä Kuvatilan kanssa voit säätää avatarin korkeutta, etäisyyttä ja suuntaa. Kuvatilan siirto ja kierto sekä lattian korkeus korjaavat myös oletusliikkeet ja omat liikkeet, joita käytetään, kun asentoa ei ole valittu. Tarkista näkymä ja toiminta oletusliikkeiden korvaamisen jälkeen itse VRChatissa.

### Peilaa ja Eleet pois

- **Peilaa**: ota käyttöön ”Toiminnot > Valikkotoiminnot > Peilaa” ja vaihda asennon vasen ja oikea puoli VRChatin valikosta.
- **Eleet pois**: ota käyttöön ”Toiminnot > Valikkotoiminnot > Eleet pois”. Kun toiminto on käytössä VRChatissa, asentoon määritetty sormien asento säilyy, vaikka puristaisit ohjaimia.

### Hengitys

1. Ota käyttöön ”Toiminnot > Lisätoiminnot > Animoi hengitys”.
2. Valitse kohdasta ”Avaa asetukset” kullekin asentoluokalle ”Ei mitään”, ”Heikko”, ”Keskivahva”, ”Vahva”, ”Nopea” tai ”Oma”. Säädä voimakkuutta siinä luokassa, johon Virtual Loven asennot kuuluvat. Vaihtoehdolla ”Oma” voit määrittää itse tekemäsi hengitysanimaation.
3. Jos haluat pysäyttää ja jatkaa hengitystä myös pelissä, ota käyttöön myös ”Toiminnot > Valikkotoiminnot > Hengitys”. VRChatissa hengitys kytketään ON/OFF kohdasta ”Hengitys”.

Kun otat käyttöön asetuksen ”Poista VRChatin oletushuojunta”, paikallaan ollessa automaattisesti lisättävä kehon oletushuojunta vaimenee. Asentotyökalussa määritetty hengitys toimii edelleen.

### Pään suunnasta johtuvan asennon vääristymän vähentäminen

Ota käyttöön ”Toiminnot > Lisätoiminnot > Vähennä pään kierrosta aiheutuvaa asennon vääristymää”. Käytä sitä, kun kehon asento vääristyy pään lukituksen vapauttamisen jälkeen, koska pään suunta poikkeaa alkuperäisestä asennosta.

### Käänny

Käänny on toiminto, jonka käyttöä varten valmistellaan sopiva makuuasento ja kylkiasennon animaatiot.

1. Ota käyttöön ”Toiminnot > Valikkotoiminnot > Käänny”.
2. Avaa ”Asennot”-välilehdellä haluamasi asennon ”Lisätiedot” ja valitse ”Ota Käänny käyttöön”.
3. Määritä vastaavat animaatiot kohtaan ”Käänny-toiminnon sivuasento” ja säädä tarvittaessa asetusta ”Kosketuskorjauksen voimakkuus”.
4. Valitse VRChatissa kyseinen asento, vapauta pään lukitus ja ota ”Käänny” käyttöön. Kun kallistat päätä vasemmalle tai oikealle, avatar kääntyy kyljelleen.

Käänny-toimintoa käyttävissä asennoissa tavallista MotionTime-asetusta ei voi käyttää. Virtual Loven mukana tulevissa asennoissa ei ole Käänny-toiminnon sivuasentoanimaatioita, joten valmistele sopivat liikkeet, jos haluat käyttää toimintoa.

## Parametrien käyttö

Kun poistat tarpeettomat toiminnot käytöstä, ExpressionParameters-kulutus pienenee.

| Toiminto | Lisäkulutus |
| --- | --- |
| Peilaa | 1 bit |
| Eleet pois | 1 bit |
| Jalkojen kork. | 8 bit |
| Lattian kork. | 8 bit |
| Hengitysliike | 0 bit |
| Hengityksen ON/OFF pelissä | 1 bit |
| Kuvatila (vain oma näyttö) | 0 bit |
| Kuvatilan synkronointi | 16 bit |
| Pään näkyminen kuvauksen aikana | 0 bit |
| Pään suunnasta johtuvan asennon vääristymän vähentäminen | 1 bit (yhteinen Käänny-toiminnon kanssa) |
| Käänny | 10 bit (josta 1 bit on yhteinen vääristymän vähentämisen kanssa) |

Näiden lisäksi kulutukseen lasketaan muun muassa asennon valinta. Tarkista kokonaismäärä Inspectorista. Jos useat asentotyökalut käyttävät yhteisiä toimintoja, yhteistä osuutta ei lasketa kahdesti. Muiden toimintojen, kuten asujen, kulutus ei sisälly tähän kokonaismäärään.

## Asentojen tarkistaminen ja säätäminen

”Asennot”-välilehdellä kunkin asennon kohdalla oleva ”Esikatselu” näyttää asennon Scenessä. Kun avaat kohdan ”Animaatiosäätö”, voit säätää kehon suuntaa ja niveliä esikatselun aikana ja tallentaa tuloksen.

Mukana olevat asennot on tehty こよりLabin avatarin ”あのん（Anon）” pohjalta. Säädä esimerkiksi kumppaniin koskettavia kohtia vartalon mittasuhteiden ja asun mukaan.

”Avatarin asetukset” -välilehden asetuksella ”Ota avatarikorjaus käyttöön” voit korjata nivelten alkukulmien ja kiertymän erot vertailuavatariin nähden. ”Estä polvien taittuminen taakse” hillitsee polvien taipumista väärään suuntaan. Kun avaat tarkemmat asetukset, voit säätää arvoa ”Polven vähimmäistaivutus (asteina)”. Tarkista esikatselulla myös, miltä asento näyttää korjauksen ollessa käytössä.

Myös asentojen nimien haku, useiden animaatioiden lisääminen ja järjestyksen muuttaminen tehdään ”Asennot”-välilehdellä. Poista tarpeettomat asennot käytöstä tai poista ne kokonaan.

Kevyt esikatselu ei suorita MA:n ja NDMF:n koontikäsittelyä, joten tarkista lopputulos asuineen ja muine toimintoineen myös avatarin koonnin jälkeen.

### Asentojen kuvakkeet

Kun otat ”Toiminnot”-välilehdellä käyttöön asetuksen ”Luo asentokuvakkeet”, pelinsisäiseen valikkoon lisätään asentojen kuvat. Koonti kestää kuvien luomisen verran pidempään. Jos haluat säästää tilaa, ota käyttöön ”Pienennä kuvakkeita”. Androidille asentokuvakkeita ei luoda.

### Esiasetukset

Voit valita esiasetuksen ”Avatarin asetukset” -välilehden alaosasta. ”Käytä tätä esiasetusta” korvaa nykyiset asentoasetukset, joten tallenna tekemäsi säädöt ennen vaihtamista.

Animaatiosäädöllä luotuja säätöanimaatiotiedostoja ja niitä käyttäviä esiasetuksia saa jakaa ja myydä ilman erillistä lupaa Unisaki Studiolta. Voit käyttää tätä esimerkiksi itse tekemiesi avatarien säätötietojen jakamiseen.

## Esikoonti

Kun tallennat valikoiden ja animaatioiden luontitulokset valitsemalla ”Päivitä esikoonti”, niitä voidaan käyttää uudelleen avatarin koonnissa ja käsittely nopeutuu. Ilman esikoontiakin tarvittavat tiedot luodaan tavallisen koonnin aikana.

Kun olet muuttanut asentoja tai toimintoja, katso Inspectorin kohta ”Tarkista asetukset” ja päivitä esikoonti, jos käytät sitä. Varoituksen piilottaminen ei päivitä luotuja tietoja.

## Lahjoittaminen

Jos et käytä sitä itse, voit antaa joko miehen tai naisen version lahjaksi kumppanillesi. Lahjan saanut saa käyttää sitä vain lahjan antajan kanssa.

## Huomioita käytöstä

- Tämä tuote on tehty vitsimielessä. Älä käytä sitä häirintään.
- Noudata käytössä VRChatin käyttöehtoja ja hyviä tapoja.
- Asennon lukitsemista koko kehon seurannan aikana ei tueta.
- Avatarin mittasuhteet, asu ja muokkaukset voivat edellyttää manuaalista säätöä.
- Jos käytät tuotetta yhdessä muiden asentoa muuttavien toimintojen kanssa, tarkista lukitusten ja asennon vaihdon toiminta. Joissakin tapauksissa sitä voi säätää kohdasta ”Avatarin asetukset > Yhdistä seurantalukitukset muihin työkaluihin”.
- Tekijä ei vastaa tämän työkalun käytöstä aiheutuvista haitoista.

## Käyttöehdot

Käytä tätä tuotetta vasta hyväksyttyäsi sen käyttöehdot, jotka on laadittu VN3-lisenssin pohjalta.

[Virtual Loven käyttöehdot](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)

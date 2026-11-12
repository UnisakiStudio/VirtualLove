# Virtual Love

Et verktøy for VRChat-avatarer som lar deg innta parpositurer sammen med en partner, med 3-punktssporing eller i skrivebordsmodus. Det inneholder 22 positurer for mann og 22 for kvinne, 44 totalt. Stående spagat og Jack-O-utfordringen er også med.

Denne README gjelder v3.2.0 under utvikling. Endelig utgivelsesdato er ikke fastsatt. Installert versjon vises øverst i Inspector.

- [Produktside på BOOTH](https://yunisaki.booth.pm/items/3641334)
- [Endringslogg](CHANGELOG.md)

## Visningsspråk og dokumentasjon uten nett

Velg språk med «Language / 言語» øverst i Inspector. Ett valg styrer både Inspector og den genererte VRChat-menyen. Last opp avataren på nytt for å endre språket i spillet.

Uten valg brukes datamaskinens språk, eller engelsk hvis språket ikke støttes. Windows, macOS og Linux støttes. Siste valg lagres i EditorPrefs og brukes i andre prosjekter for samme OS-bruker på denne maskinen. Alle positurverktøy og avatarer bruker samme språk. En endring i Inspector for et hvilket som helst verktøy oppdaterer den felles innstillingen; språkvalg for enkeltavatarer ignoreres. Det synkroniseres ikke til andre maskiner. Lisenslagringen endres ikke. Språkknappen vises bare ved den første installasjonsbekreftelsen hvis ingen språk er lagret. Senere språkendringer gjøres i Inspector.

Velg README eller endringslogg fra den medfølgende [språkoversikten](../index.html). «Brukerveiledning» og «Vis endringer» i Inspector følger også det valgte språket. Navnene på de medfølgende positurene og på kategoriene i spillmenyen vises også på det valgte språket. Bruksvilkårene følger som før med på japansk.

## Installasjon

1. Importer «VirtualLove_Boy.unitypackage» eller «VirtualLove_Girl.unitypackage» fra de kjøpte filene til Unity.
2. Når pakkekilden er registrert, kan du legge til «Virtual Love» i prosjektet ditt fra VCC eller ALCOM. Unisaki Posing System 3.2.0 kreves.
3. Høyreklikk avataren i Hierarchy og velg «Unisaki Studio > Legg til Virtual Love (mann)» eller «Unisaki Studio > Legg til Virtual Love (kvinne)».
4. Velg «三点だいしゅき(男)» eller «三点だいしゅき(女)», som ble lagt til i avataren, og angi funksjoner og positurer i Inspector.
5. Kontroller positurene med forhåndsvisningen, og last opp avataren som vanlig.

Krever Unity 2022.3, VRChat Avatars SDK 3.10.4 eller nyere, Modular Avatar 1.x fra 1.15.1 og NDMF 1.x fra 1.14.0. Oppdater nødvendige pakker sammen i VCC eller ALCOM.

## Oppdatering fra eldre versjoner

Oppdater produktet og Unisaki Posing System sammen. Eksisterende verktøyinnstillinger beholdes. Kontroller funksjoner og ExpressionParameters-forbruk i Inspector, og trykk «Oppdater forhåndsbygget» før ny opplasting hvis det brukes.

## Hvor innstillingene finnes

| Fane | Viktigste innstillinger |
| --- | --- |
| Funksjoner | Tillegg i spillmenyen, Fotomodus, pust, ikonbilder og kontroll av parameterforbruk |
| Positurer | Positurer som brukes, søk, tillegging, sortering, forhåndsvisning og Animasjonsjustering |
| Avataroppsett | Kroppskorrigering, import av opprinnelig positur og egne bevegelser, forhåndsinnstillinger |

Slå på funksjonene du trenger før du laster opp. Elementer med «Åpne innstillinger» kan vise detaljerte innstillinger under seg.

## Grunnleggende spillkontroller

Åpne Expressions-menyen og velg en Virtual Love-positur. Velg positurene som hører sammen for mann og kvinne, og tilpass posisjon og retning etter partneren.

Slå låsene for hode, armer og føtter av og på for å velge hvilke kroppsdeler som skal følge sporingen. Med «Lås føtter» kan du bevege hodet mens underkroppen holder posituren. Hvis du vil speilvende en positur eller justere høyden, aktiverer du de tilsvarende funksjonene i Unity på forhånd.

### Fotomodus

Flytt avataren dit du kan se den, juster retningen og ta bilder.

1. Slå på «Funksjoner > Menyfunksjoner > Fotomodus» i Unity.
2. Åpne «Fotomodus» i VRChat, og velg posituren du vil bruke under «Velg positur».
3. Bruk «Avstand» til å flytte avataren opptil 3m fremover. Når avstanden er større enn 0, vender avataren seg mot deg.
4. Roter den med «Retning», og slå ved behov på «Lås føtter» når posisjonen er riktig. Føttene låses ikke automatisk ved start, så du kan justere posisjonen først.
5. Trykk «Avslutt foto» når du er ferdig. Avstand og retning tilbakestilles, og fotlåsen oppheves.

Hvis du har lagt til «Gester av» i menyen, kan du bytte håndform også i Fotomodus.

Når du bare endrer posisjon og retning på din egen skjerm, brukes ingen synkroniserte parametere for Fotomodus. Hvis andre også skal se samme posisjon og retning, slår du på «Funksjoner > Praktiske funksjoner > Synkroniser Fotomodus» i Unity.

Hvis ditt eget hode skjules når det kommer nær og gjør det vanskelig å ta bilder, slår du på «Behold hodet synlig i Fotomodus». Innstillingen gjelder din egen visning mens du fotograferer, og visningen går tilbake til normalen etterpå.

### Fothøyde og Gulvhøyde

Slå på elementene du vil bruke under «Funksjoner > Menyfunksjoner» i Unity, så legges de til i menyen «Innstillinger» i VRChat.

- **Fothøyde**: justerer høyden på fotsiden mens hodets posisjon beholdes. Bruk den når føttene synker ned i eller svever over gulvet, eller når du vil tilpasse høyden til partneren.
- **Gulvhøyde**: flytter hele kroppen, også hodet, opp og ned. 50% er opprinnelig høyde, 0% er 3m lavere og 100% er 3m høyere. Sett verdien tilbake til rundt 50% for å gå tilbake til utgangspunktet.

Sammen med Fotomodus kan du justere avatarens høyde, avstand og retning. Flytting og rotasjon i Fotomodus og Gulvhøyde korrigerer også standardbevegelser og egne bevegelser som brukes når ingen positur er valgt. Kontroller synsvinkelen og oppførselen etter at standardbevegelser er byttet ut, i selve VRChat.

### Speilvend og Gester av

- **Speilvend**: slå på «Funksjoner > Menyfunksjoner > Speilvend», og bytt venstre og høyre i posituren fra VRChat-menyen.
- **Gester av**: slå på «Funksjoner > Menyfunksjoner > Gester av». Når det er aktivert i VRChat, beholdes fingerformene som er angitt i posituren, også når du griper om kontrollerne.

### Pust

1. Slå på «Funksjoner > Praktiske funksjoner > Animer pusten».
2. Velg «Ingen», «Svak», «Middels», «Sterk», «Rask» eller «Egendefinert» for hver positurkategori via «Åpne innstillinger». Juster styrken i kategorien som svarer til Virtual Love-positurene. Med «Egendefinert» kan du angi din egen pusteanimasjon.
3. Hvis du også vil kunne stoppe og gjenoppta pusten i spillet, slår du i tillegg på «Funksjoner > Menyfunksjoner > Pust». I VRChat slår du den ON/OFF med «Pust».

Slå på «Deaktiver VRChats hvilebevegelse» for å dempe den standard kroppsbevegelsen som automatisk legges til når du står stille. Pusten som er satt opp i positurverktøyet, fungerer som før.

### Redusere positurforvrengning fra hoderotasjon

Slå på «Funksjoner > Praktiske funksjoner > Reduser positurforvrengning fra hoderotasjon». Bruk det når kroppens positur forvrenges fordi hoderetningen avviker fra den opprinnelige posituren etter at hodelåsen er opphevet.

### Snu deg

Snu deg er en funksjon du bruker ved å klargjøre en passende liggende positur og sideliggende animasjoner.

1. Slå på «Funksjoner > Menyfunksjoner > Snu deg».
2. Åpne «Detaljer» for posituren du vil bruke under «Positurer», og slå på «Aktiver Snu deg».
3. Angi de tilhørende animasjonene i «Sidepositur for Snu deg», og juster «Styrke på kontaktkorrigering» ved behov.
4. Velg posituren i VRChat, opphev hodelåsen og slå på «Snu deg». Vipp hodet til venstre eller høyre for å snu deg.

Positurer som bruker Snu deg, kan ikke bruke den vanlige MotionTime-innstillingen. Positurene som følger med Virtual Love, inneholder ingen sideliggende animasjoner for Snu deg, så du må klargjøre passende bevegelser hvis du vil bruke funksjonen.

## Parameterforbruk

Du reduserer forbruket av ExpressionParameters ved å slå av funksjoner du ikke trenger.

| Funksjon | Ekstra forbruk |
| --- | --- |
| Speilvend | 1 bit |
| Gester av | 1 bit |
| Fothøyde | 8 bit |
| Gulvhøyde | 8 bit |
| Pustebevegelse | 0 bit |
| Pust ON/OFF i spillet | 1 bit |
| Fotomodus (bare din egen skjerm) | 0 bit |
| Synkronisering av Fotomodus | 16 bit |
| Visning av hodet under fotografering | 0 bit |
| Reduksjon av positurforvrengning fra hoderotasjon | 1 bit (deles med Snu deg) |
| Snu deg | 10 bit (hvorav 1 bit deles med reduksjonen av positurforvrengning) |

I tillegg kommer forbruk for blant annet positurvalg. Kontroller totalen i Inspector. Når flere positurverktøy bruker fellesfunksjonene, telles den delte delen bare én gang. Forbruket til andre systemer, for eksempel antrekk, er ikke med i denne totalen.

## Kontrollere og justere positurer

Med «Forhåndsvisning» på hver positur under «Positurer» kan du vise posituren i Scene. Åpne «Animasjonsjustering» for å justere kroppsretning og ledd mens du forhåndsviser, og lagre resultatet.

De medfølgende positurene er laget med «あのん（Anon）» fra こよりLab som utgangspunkt. Tilpass for eksempel kontaktpunktene med partneren etter kroppsbygning og antrekk.

Med «Aktiver avatarkorrigering» under «Avataroppsett» kan du korrigere forskjeller i leddenes startvinkler og vridning sammenlignet med referanseavataren. «Hindre bakoverbøyning av knær» demper knær som bøyer seg feil vei. Åpne de detaljerte innstillingene for å justere «Minste knebøyning (grader)». Kontroller også i forhåndsvisningen hvordan det ser ut med korrigeringen aktivert.

Søk etter positurnavn, tillegging av flere animasjoner og endring av rekkefølgen gjøres også under «Positurer». Deaktiver eller slett positurer du ikke trenger.

Hurtigforhåndsvisningen kjører ikke byggeprosessen til MA og NDMF, så kontroller også sluttresultatet, inkludert antrekk og andre systemer, etter at avataren er bygget.

### Ikonbilder for positurer

Slå på «Generer positurikoner» under «Funksjoner» for å legge til bilder av positurene i spillmenyen. Byggingen tar tilsvarende lengre tid fordi bildene må genereres. Slå på «Reduser ikonstørrelsen» hvis du vil spare plass. Positurikoner genereres ikke for Android.

### Forhåndsinnstillinger

Nederst i «Avataroppsett» kan du velge en forhåndsinnstilling. «Bruk denne forhåndsinnstillingen» erstatter de gjeldende positurinnstillingene, så lagre justeringene dine før du bytter.

Justeringsanimasjonsfiler som er laget med Animasjonsjustering, og forhåndsinnstillinger som bruker dem, kan distribueres og selges uten særskilt tillatelse fra Unisaki Studio. Bruk dette for eksempel til å dele justeringsdata for avatarer du har laget selv.

## Forhåndsbygg

Med «Oppdater forhåndsbygget» lagres de genererte menyene og animasjonene, slik at de kan gjenbrukes når avataren bygges, og byggingen går raskere. Uten forhåndsbygg genereres de nødvendige dataene under den vanlige byggingen.

Når du har endret positurer eller funksjoner, bør du se på «Kontroller innstillinger» i Inspector og oppdatere forhåndsbygget hvis du bruker det. Det genererte resultatet oppdateres ikke selv om du skjuler en advarsel.

## Om gaver

Hvis du ikke bruker den selv, kan du gi enten utgaven for mann eller utgaven for kvinne i gave til partneren din. Den som får gaven, kan bare bruke den sammen med den som ga den.

## Merknader om bruk

- Dette produktet er laget som en spøk. Ikke bruk det til trakassering.
- Følg VRChats bruksvilkår og vanlig god oppførsel når du bruker det.
- Låsing av positur under fullkroppssporing støttes ikke.
- Manuell justering kan være nødvendig, avhengig av avatarens kroppsbygning, antrekk og tilpasninger.
- Hvis du bruker det sammen med andre systemer som endrer posituren, må du kontrollere hvordan låsene og positurbyttet oppfører seg. I noen tilfeller kan dette justeres med «Avataroppsett > Samordne sporingslåser med andre verktøy».
- Skaperen påtar seg ikke ansvar for ulemper som oppstår ved bruk av dette verktøyet.

## Bruksvilkår

Bruk dette produktet først etter at du har godtatt bruksvilkårene, som er utarbeidet med VN3-lisensen.

[Bruksvilkår for Virtual Love](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)

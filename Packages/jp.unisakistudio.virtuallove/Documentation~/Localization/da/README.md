# Virtual Love

Et værktøj til VRChat-avatarer, hvor du kan indtage parpositurer sammen med en partner med 3-punktssporing eller i desktoptilstand. Det indeholder 22 positurer til hver af mand og kvinde, 44 i alt. Stående spagat og Jack-O-udfordringen er også med.

Denne README gælder v3.2.0 under udvikling. Endelig udgivelsesdato er ikke fastsat. Installeret version vises øverst i Inspector.

- [Produktside på BOOTH](https://yunisaki.booth.pm/items/3641334)
- [Ændringshistorik](CHANGELOG.md)

## Visningssprog og offlinedokumentation

Vælg visningssprog med ”Language / 言語” øverst i Inspector. Ét valg gælder både Inspector og den genererede VRChat-menu. Upload avataren igen for at ændre sproget i spillet.

Uden et valg bruges computerens sprog, eller engelsk hvis sproget ikke understøttes. Windows, macOS og Linux understøttes. Det seneste valg gemmes i EditorPrefs og bruges i andre projekter for samme OS-bruger på denne computer. Alle positurværktøjer og avatarer bruger samme sprog. En ændring i et hvilket som helst værktøjs Inspector opdaterer den fælles indstilling; sprogvalg for enkelte avatarer ignoreres. Valget synkroniseres ikke til andre computere. Licenslagringen ændres ikke. Sprogknappen vises kun ved den første installationsbekræftelse, hvis der ikke er gemt et sprog. Senere sprogændringer foretages i Inspector.

README og ændringshistorik kan vælges i den medfølgende [sprogoversigt](../index.html). ”Vejledning” og ”Vis ændringer” i Inspector følger også det valgte sprog. Navnene på de medfølgende positurer og på kategorierne i spilmenuen vises ligeledes på det valgte sprog. Brugsbetingelserne medfølger som hidtil på japansk.

## Installation

1. Importér ”VirtualLove_Boy.unitypackage” eller ”VirtualLove_Girl.unitypackage” fra de købte filer til Unity. I den engelske udgave hedder filerne ”VirtualLove_Male_Installer.unitypackage” og ”VirtualLove_Female_Installer.unitypackage”.
2. Når pakkekilden er registreret, kan du føje Virtual Love til dit projekt fra VCC eller ALCOM. Unisaki Posing System 3.2.0 er påkrævet.
3. Højreklik på avataren i Hierarchy, og vælg ”Unisaki Studio > Tilføj Virtual Love (mand)” eller ”Unisaki Studio > Tilføj Virtual Love (kvinde)”.
4. Vælg ”三点だいしゅき(男)” eller ”三点だいしゅき(女)”, som er blevet tilføjet i avataren, og indstil funktioner og positurer i Inspector.
5. Kontrollér positurerne i forhåndsvisningen, og upload derefter avataren som normalt.

Kræver Unity 2022.3, VRChat Avatars SDK 3.10.4 eller nyere, Modular Avatar 1.x fra 1.15.1 og NDMF 1.x fra 1.14.0. Opdatér nødvendige pakker sammen i VCC eller ALCOM.

## Opdatering fra tidligere versioner

Opdatér produktet sammen med Unisaki Posing System. Eksisterende værktøjsindstillinger bevares. Kontrollér funktioner og ExpressionParameters-forbrug i Inspector, og tryk ”Opdatér forberegning” før ny upload, hvis den bruges.

## Hvor indstillingerne findes

| Fane | Vigtigste indstillinger |
| --- | --- |
| Funktioner | Menufunktioner i spillet, Fototilstand, vejrtrækning, ikonbilleder og kontrol af parameterforbrug |
| Positurer | Anvendte positurer, søgning, tilføjelse, omrokering, forhåndsvisning og animationsjustering |
| Avataropsætning | Kropskorrektion, import af den oprindelige holdning og egne bevægelser samt forudindstillinger |

Slå de funktioner til, du har brug for, før du uploader. Punkter med ”Åbn indstillinger” kan vise detaljerede indstillinger nedenunder.

## Grundlæggende spilbetjening

Åbn Expressions-menuen, og vælg en positur fra Virtual Love. Vælg de positurer, der danner par for mand og kvinde, og tilpas position og retning efter din partner.

Med låsene til hoved, arme og fødder vælger du, hvilke dele der følger din sporing. Med ”Lås fødder” kan du bevæge hovedet, mens underkroppen beholder sin positur. Hvis du vil spejlvende en positur eller justere dens højde, skal du aktivere de tilsvarende funktioner i Unity på forhånd.

### Fototilstand

Du kan flytte din avatar til et sted, hvor du kan se den, justere dens retning og tage billeder.

1. Slå ”Funktioner > Menufunktioner > Fototilstand” til i Unity.
2. Åbn ”Fototilstand” i VRChat, og vælg den ønskede positur under ”Vælg positur”.
3. Med ”Afstand” flytter du avataren op til 3m fremad. Når afstanden er større end 0, vender avataren sig mod dig.
4. Drej den med ”Retning”, og slå om nødvendigt ”Lås fødder” til, når positionen er på plads. Fødderne låses ikke automatisk fra start, så du kan justere positionen først.
5. Tryk på ”Afslut foto”, når du er færdig. Afstand og retning nulstilles, og fodlåsen ophæves.

Hvis du har føjet ”Gestus fra” til menuen, kan du også skifte håndform i Fototilstand.

Hvis du kun ændrer position og retning på din egen skærm, bruges der ingen synkroniserede parametre til Fototilstand. Hvis andre også skal se samme position og retning, skal du slå ”Funktioner > Praktiske funktioner > Synkronisér Fototilstand” til i Unity.

Hvis dit eget hoved skjules, når det kommer tæt på, og gør det svært at fotografere, skal du slå ”Hold hovedet synligt i Fototilstand” til. Det gælder din egen visning, mens du fotograferer, og bagefter vender visningen tilbage til det normale.

### Fodhøjde og Gulvhøjde

Slå de ønskede punkter til under ”Funktioner > Menufunktioner” i Unity, så føjes de til menuen ”Indstillinger” i VRChat.

- **Fodhøjde**: justerer højden i fodenden, mens hovedets position bevares. Brug den, når fødderne synker ned i gulvet eller svæver, eller når du vil tilpasse højden efter din partner.
- **Gulvhøjde**: flytter hele kroppen, inklusive hovedet, op og ned. 50% er den oprindelige højde, 0% er 3m lavere, og 100% er 3m højere. Sæt værdien tilbage til omkring 50% for at vende tilbage.

Sammen med Fototilstand kan du justere avatarens højde, afstand og retning. Flytning og rotation i Fototilstand samt Gulvhøjde korrigerer også standardbevægelser og egne bevægelser, når ingen positur er valgt. Kontrollér synsvinklen og opførslen efter udskiftning af standardbevægelser direkte i VRChat.

### Spejlvend og Gestus fra

- **Spejlvend**: slå ”Funktioner > Menufunktioner > Spejlvend” til, og skift mellem positurens venstre- og højreudgave i VRChat-menuen.
- **Gestus fra**: slå ”Funktioner > Menufunktioner > Gestus fra” til. Når det er aktiveret i VRChat, bevares de fingerstillinger, der er indstillet i posituren, også når du griber om controllerne.

### Vejrtrækning

1. Slå ”Funktioner > Praktiske funktioner > Animér vejrtrækning” til.
2. Vælg ”Ingen”, ”Svag”, ”Middel”, ”Stærk”, ”Hurtig” eller ”Egen” for hver positurkategori via ”Åbn indstillinger”. Justér styrken i den kategori, der svarer til positurerne i Virtual Love. Med ”Egen” kan du angive din egen vejrtrækningsanimation.
3. Hvis du også vil kunne stoppe og genoptage vejrtrækningen i spillet, skal du desuden slå ”Funktioner > Menufunktioner > Vejrtrækning” til. I VRChat skifter du ON/OFF med ”Vejrtrækning”.

Med ”Slå VRChats svajen i stilstand fra” dæmper du den standardsvajen i kroppen, som automatisk tilføjes, når du står stille. Den vejrtrækning, der er indstillet i positurværktøjet, virker fortsat.

### Reducér forvrængning fra hovedrotation

Slå ”Funktioner > Praktiske funktioner > Reducér forvrængning fra hovedrotation” til. Brug det, når kropsholdningen forvrænges, efter at hovedlåsen er ophævet, fordi hovedets retning afviger fra den oprindelige positur.

### Vend dig

”Vend dig” er en funktion, du bruger ved at klargøre en passende liggende positur og sideanimationer.

1. Slå ”Funktioner > Menufunktioner > Vend dig” til.
2. Åbn ”Detaljer” for den ønskede positur under ”Positurer”, og slå ”Aktivér Vend dig” til.
3. Angiv de tilsvarende animationer under ”Sidepositur til vending”, og justér om nødvendigt ”Styrke af gulvkorrektion”.
4. Vælg den tilsvarende positur i VRChat, ophæv hovedlåsen, og slå ”Vend dig” til. Læn hovedet til venstre eller højre for at vende dig.

Positurer, der bruger Vend dig, kan ikke bruge den almindelige MotionTime-indstilling. De positurer, der følger med Virtual Love, indeholder ingen sideanimationer til vending, så klargør passende bevægelser, hvis du vil bruge funktionen.

## Parameterforbrug

Når du slår funktioner fra, som du ikke har brug for, falder forbruget af ExpressionParameters.

| Funktion | Ekstra forbrug |
| --- | --- |
| Spejlvend | 1 bit |
| Gestus fra | 1 bit |
| Fodhøjde | 8 bit |
| Gulvhøjde | 8 bit |
| Vejrtrækningsbevægelse | 0 bit |
| Vejrtrækning ON/OFF i spillet | 1 bit |
| Fototilstand (kun din egen skærm) | 0 bit |
| Synkronisering af Fototilstand | 16 bit |
| Visning af hovedet under fotografering | 0 bit |
| Reduktion af forvrængning fra hovedrotation | 1 bit (deles med Vend dig) |
| Vend dig | 10 bit (heraf deles 1 bit med reduktionen af forvrængning) |

Hertil kommer forbruget til valg af positur med mere. Kontrollér det samlede forbrug i Inspector. Når flere positurværktøjer bruger de fælles funktioner, tælles den delte del ikke dobbelt. Forbrug fra andre systemer, for eksempel tøj, er ikke med i denne sum.

## Kontrol og justering af positurer

Med ”Forhåndsvisning” ved hver positur under ”Positurer” vises holdningen i Scene. Åbn ”Animationsjustering” for at justere kroppens retning og led, mens du forhåndsviser, og gem derefter resultatet.

De medfølgende positurer er lavet med ”あのん（Anon）” fra こよりLab som udgangspunkt. Justér for eksempel kontaktpunkterne med din partner efter kropsbygning og tøj.

Med ”Aktivér avatarspecifik korrektion” under ”Avataropsætning” korrigeres forskelle i leddenes udgangsvinkler og vrid i forhold til referenceavataren. ”Forhindr bagudbøjning af knæ” modvirker, at knæene bøjer den forkerte vej. Åbn de detaljerede indstillinger for at justere ”Mindste knæbøjning (grader)”. Kontrollér også udseendet med korrektionen aktiveret i forhåndsvisningen.

Søgning efter positurnavne, tilføjelse af flere animationer og ændring af rækkefølgen foregår også under ”Positurer”. Deaktivér eller slet de positurer, du ikke har brug for.

Den hurtige forhåndsvisning kører ikke byggeprocessen for MA og NDMF, så kontrollér også det endelige resultat, inklusive tøj og andre systemer, efter at avataren er bygget.

### Ikonbilleder til positurer

Slå ”Generér positurikoner” til under ”Funktioner” for at føje billeder af positurerne til spilmenuen. Buildet tager længere tid, fordi billederne skal genereres. Slå ”Reducér ikonstørrelse” til, hvis du vil spare plads. Der genereres ikke positurikoner til Android.

### Forudindstillinger

Nederst i ”Avataropsætning” kan du vælge en forudindstilling. ”Anvend denne forudindstilling” erstatter de aktuelle positurindstillinger, så gem dine justeringer, før du skifter.

Justeringsanimationsfiler, der er lavet med Animationsjustering, og forudindstillinger, der bruger dem, må distribueres og sælges uden særskilt tilladelse fra Unisaki Studio. Brug det for eksempel til at dele justeringsdata til egne avatarer.

## Forberegning

Med ”Opdatér forberegning” gemmes de genererede menuer og animationer, så de kan genbruges, når avataren bygges, og buildet går hurtigere. Også uden forberegning genereres de nødvendige data under det almindelige build.

Når du har ændret positurer eller funktioner, skal du se under ”Kontrollér indstillinger” i Inspector og opdatere forberegningen, hvis du bruger den. At skjule en advarsel opdaterer ikke det genererede resultat.

## Om gaver

Hvis du ikke selv bruger den, må du give enten udgaven til mand eller udgaven til kvinde som gave til din partner. Den, der modtager gaven, må kun bruge den sammen med den, der gav den.

## Bemærkninger om brug

- Produktet er lavet for sjov. Brug det ikke til chikane.
- Overhold VRChats vilkår og god opførsel, når du bruger det.
- Positurlåsning under fuldkropssporing understøttes ikke.
- Afhængigt af avatarens kropsbygning, tøj og ændringer kan manuel justering være nødvendig.
- Hvis du samtidig bruger andre systemer, der ændrer holdningen, bør du kontrollere, hvordan låsene og positurskiftene opfører sig. Det kan muligvis justeres med ”Avataropsætning > Integrér sporingslåsninger med andre værktøjer”.
- Skaberen påtager sig intet ansvar for ulemper, der opstår ved brug af værktøjet.

## Brugsbetingelser

Brug først produktet, når du har accepteret brugsbetingelserne, som er udarbejdet med VN3-licensen.

[Brugsbetingelser for Virtual Love](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)

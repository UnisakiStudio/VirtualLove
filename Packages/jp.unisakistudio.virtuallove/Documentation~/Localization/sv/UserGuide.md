# Virtual Love

Ett verktyg för VRChat-avatarer som låter dig inta parposer tillsammans med en partner med 3-punktsspårning eller i skrivbordsläge. Det innehåller 22 poser vardera för man och kvinna, sammanlagt 44. Stående spagat och Jack-O-utmaningen finns också med.

Denna README gäller v3.2.0 under utveckling. Datum för slutlig utgivning är inte bestämt. Installerad version visas högst upp i Inspector.

- [Produktsida på BOOTH](https://yunisaki.booth.pm/items/3641334)
- [Ändringshistorik](CHANGELOG.md)

## Visningsspråk och offlinedokumentation

Välj språk under Language / 言語 överst i Inspector. Samma val styr Inspector och genererade VRChat-menyer. Ladda upp avataren igen för att ändra språk i spelet.

Utan uttryckligt val används datorns språk, annars engelska om språket saknas. Windows, macOS och Linux stöds. Senaste val sparas i EditorPrefs för andra projekt med samma systemanvändare på denna dator. Alla posverktyg och avatarer använder samma språk. En ändring i något verktygs Inspector uppdaterar den gemensamma inställningen; språkval för enskilda avatarer ignoreras. Ingen synkronisering till andra datorer. Licenslagring ändras inte. Språkknappen visas bara vid den första installationsbekräftelsen om inget språk har sparats. Senare språkändringar görs i Inspector.

README och ändringshistorik kan väljas i den medföljande [språklistan](../index.html). Även ”Handbok” och ”Visa ändringar” i Inspector följer det valda språket. Namnen på de medföljande poserna och på kategorierna i spelmenyn visas också på det valda språket. Användarvillkoren medföljer liksom tidigare på japanska.

## Installation

1. Importera ”VirtualLove_Boy.unitypackage” eller ”VirtualLove_Girl.unitypackage” från de köpta filerna till Unity.
2. När paketkällan har registrerats kan du lägga till Virtual Love i ditt projekt från VCC eller ALCOM. Unisaki Posing System 3.2.0 krävs.
3. Högerklicka på avataren i Hierarchy och välj ”Unisaki Studio > Lägg till Virtual Love (man)” eller ”Unisaki Studio > Lägg till Virtual Love (kvinna)”.
4. Markera ”三点だいしゅき(男)” eller ”三点だいしゅき(女)”, som har lagts till i avataren, och ställ in funktioner och poser i Inspector.
5. Kontrollera poserna i förhandsvisningen och ladda sedan upp avataren som vanligt.

Kräver Unity 2022.3, VRChat Avatars SDK 3.10.4 eller senare, Modular Avatar 1.x från 1.15.1 och NDMF 1.x från 1.14.0. Uppdatera nödvändiga paket tillsammans i VCC eller ALCOM.

## Uppdatering från tidigare versioner

Uppdatera produkten och Unisaki Posing System tillsammans. Inställningar i redan placerade verktyg bevaras. Kontrollera aktiva funktioner och ExpressionParameters-användning i Inspector. Om du använde förberäkning trycker du på ”Uppdatera förberäkning” före ny uppladdning.

## Var inställningarna finns

| Flik | Viktigaste inställningar |
| --- | --- |
| Funktioner | Menyfunktioner i spelet, Fotoläge, andning, ikonbilder och kontroll av parameteranvändning |
| Poser | Poser som används, sökning, tillägg, omordning, förhandsvisning och animationsjustering |
| Avatarinställningar | Kroppskorrigering, import av ursprunglig hållning och egna rörelser samt förinställningar |

Slå på de funktioner du behöver innan du laddar upp. Poster med ”Öppna inställningar” kan visa detaljerade inställningar under sig.

## Grundkontroller i spelet

Öppna Expressions-menyn och välj en pose från Virtual Love. Välj de poser som bildar ett par för man och kvinna och anpassa position och riktning efter din partner.

Med låsen för huvud, armar och fötter väljer du vilka delar som följer din spårning. Med ”Lås fötter” kan du röra huvudet medan underkroppen behåller sin pose. Om du vill spegla en pose eller justera dess höjd aktiverar du motsvarande funktioner i Unity i förväg.

### Fotoläge

Du kan flytta avataren till en plats där du ser den, justera dess riktning och ta bilder.

1. Slå på ”Funktioner > Menyfunktioner > Fotoläge” i Unity.
2. Öppna ”Fotoläge” i VRChat och välj önskad pose under ”Välj pose”.
3. Med ”Avstånd” flyttar du avataren upp till 3m framåt. När avståndet är större än 0 vänder sig avataren mot dig.
4. Rotera den med ”Riktning” och slå vid behov på ”Lås fötter” när positionen är rätt. Fötterna låses inte automatiskt från början, så du kan justera positionen först.
5. Tryck på ”Avsluta foto” när du är klar. Avstånd och riktning återställs och fotlåset släpps.

Om du har lagt till ”Gester av” i menyn kan du byta handform även i Fotoläge.

Om du bara ändrar position och riktning på din egen skärm används inga synkroniserade parametrar för Fotoläge. Om andra ska se samma position och riktning slår du på ”Funktioner > Praktiska funktioner > Synkronisera Fotoläge” i Unity.

Om ditt eget huvud döljs när det kommer nära och gör det svårt att fotografera slår du på ”Håll huvudet synligt i Fotoläge”. Det gäller din egen vy medan du fotograferar, och efteråt återgår visningen till det normala.

### Fothöjd och Golvhöjd

Slå på de poster du vill använda under ”Funktioner > Menyfunktioner” i Unity, så läggs de till i menyn ”Inställningar” i VRChat.

- **Fothöjd**: justerar höjden på fotsidan medan huvudets position behålls. Använd den när fötterna sjunker ner i golvet eller svävar, eller när du vill anpassa höjden efter din partner.
- **Golvhöjd**: flyttar hela kroppen, inklusive huvudet, uppåt och nedåt. 50% är ursprunglig höjd, 0% är 3m lägre och 100% är 3m högre. Ställ tillbaka värdet till omkring 50% för att återgå.

Tillsammans med Fotoläge kan du justera avatarens höjd, avstånd och riktning. Förflyttning och rotation i Fotoläge samt Golvhöjd korrigerar även standardrörelser och egna rörelser när ingen pose är vald. Kontrollera vyn och beteendet efter att standardrörelser har ersatts direkt i VRChat.

### Spegla och Gester av

- **Spegla**: slå på ”Funktioner > Menyfunktioner > Spegla” och växla posens vänster- och högersida i VRChat-menyn.
- **Gester av**: slå på ”Funktioner > Menyfunktioner > Gester av”. När det är aktiverat i VRChat behålls fingerställningarna som är inställda i posen även när du greppar handkontrollerna.

### Andning

1. Slå på ”Funktioner > Praktiska funktioner > Animera andning”.
2. Välj ”Ingen”, ”Svag”, ”Medel”, ”Stark”, ”Snabb” eller ”Egen” för varje posekategori via ”Öppna inställningar”. Justera styrkan i den kategori som motsvarar poserna i Virtual Love. Med ”Egen” kan du ange en egen andningsanimation.
3. Om du även vill kunna stoppa och återuppta andningen i spelet slår du också på ”Funktioner > Menyfunktioner > Andning”. I VRChat växlar du ON/OFF med ”Andning”.

Med ”Stäng av VRChats stillastående svajning” dämpar du den standardsvajning av kroppen som läggs till automatiskt när du står still. Andningen som ställts in i poseverktyget fungerar som vanligt.

### Minska förvrängning från huvudrotation

Slå på ”Funktioner > Praktiska funktioner > Minska förvrängning från huvudrotation”. Använd det när kroppshållningen förvrängs efter att huvudlåset släppts, eftersom huvudets riktning skiljer sig från den ursprungliga posen.

### Vänd dig

”Vänd dig” är en funktion som du använder genom att förbereda en passande liggande pose och sidoanimationer.

1. Slå på ”Funktioner > Menyfunktioner > Vänd dig”.
2. Öppna ”Detaljer” för önskad pose under ”Poser” och slå på ”Aktivera Vänd dig”.
3. Ange motsvarande animationer under ”Sidopose för vändning” och justera ”Markkorrigeringens styrka” vid behov.
4. Välj motsvarande pose i VRChat, släpp huvudlåset och slå på ”Vänd dig”. Luta huvudet åt vänster eller höger för att vända dig.

Poser som använder Vänd dig kan inte använda den vanliga MotionTime-inställningen. Poserna som ingår i Virtual Love innehåller inga sidoanimationer för vändning, så förbered passande rörelser om du vill använda funktionen.

## Parameteranvändning

Genom att stänga av funktioner du inte behöver minskar du användningen av ExpressionParameters.

| Funktion | Ytterligare användning |
| --- | --- |
| Spegla | 1 bit |
| Gester av | 1 bit |
| Fothöjd | 8 bit |
| Golvhöjd | 8 bit |
| Andningsrörelse | 0 bit |
| Andning ON/OFF i spelet | 1 bit |
| Fotoläge (endast din egen skärm) | 0 bit |
| Synkronisering av Fotoläge | 16 bit |
| Visning av huvudet under fotografering | 0 bit |
| Minskad förvrängning från huvudrotation | 1 bit (delas med Vänd dig) |
| Vänd dig | 10 bit (varav 1 bit delas med förvrängningsminskningen) |

Till detta kommer användningen för posval med mera. Kontrollera summan i Inspector. När flera poseverktyg använder de gemensamma funktionerna räknas den delade delen inte dubbelt. Användning av andra system, till exempel kläder, ingår inte i summan.

## Kontrollera och justera poser

Med ”Förhandsvisning” vid varje pose under ”Poser” visas hållningen i Scene. Öppna ”Animationsjustering” för att justera kroppens riktning och leder medan du förhandsvisar och sedan spara resultatet.

De medföljande poserna har skapats med ”あのん（Anon）” från こよりLab som utgångspunkt. Justera till exempel kontaktpunkterna med din partner efter kroppsbyggnad och kläder.

Med ”Aktivera avatarspecifik korrigering” under ”Avatarinställningar” korrigeras skillnader i ledernas utgångsvinklar och vridning jämfört med referensavataren. ”Förhindra bakåtböjda knän” motverkar att knäna böjs åt fel håll. Öppna de detaljerade inställningarna för att justera ”Minsta knäböjning (grader)”. Kontrollera även utseendet med korrigeringen aktiverad i förhandsvisningen.

Sökning på posenamn, tillägg av flera animationer och ändring av ordningen görs också under ”Poser”. Inaktivera eller ta bort poser du inte behöver.

Snabbförhandsvisningen kör inte byggprocessen för MA och NDMF, så kontrollera även slutresultatet, inklusive kläder och andra system, efter att avataren har byggts.

### Ikonbilder för poser

Slå på ”Generera poseikoner” under ”Funktioner” för att lägga till bilder av poserna i spelmenyn. Bygget tar längre tid eftersom bilderna ska genereras. Slå på ”Minska ikonstorlek” om du vill spara utrymme. Poseikoner genereras inte för Android.

### Förinställningar

Längst ned i ”Avatarinställningar” kan du välja en förinställning. ”Tillämpa den här förinställningen” ersätter de aktuella poseinställningarna, så spara dina justeringar innan du byter.

Justeringsanimationsfiler som skapats med Animationsjustering, och förinställningar som använder dem, får distribueras och säljas utan särskilt tillstånd från Unisaki Studio. Använd det till exempel för att dela justeringsdata för egna avatarer.

## Förberäkning

Med ”Uppdatera förberäkning” sparas de genererade menyerna och animationerna så att de kan återanvändas när avataren byggs, vilket går snabbare. Även utan förberäkning genereras nödvändiga data vid det vanliga bygget.

När du har ändrat poser eller funktioner kontrollerar du ”Kontrollera inställningar” i Inspector och uppdaterar förberäkningen om du använder den. Att dölja en varning uppdaterar inte det genererade resultatet.

## Om gåvor

Om du inte använder den själv får du ge antingen utgåvan för man eller den för kvinna i gåva till din partner. Den som får gåvan får bara använda den tillsammans med den som gav den.

## Att tänka på vid användning

- Produkten är gjord på skämt. Använd den inte för trakasserier.
- Följ VRChats användarvillkor och gott uppförande när du använder den.
- Poselåsning vid helkroppsspårning stöds inte.
- Beroende på avatarens kroppsbyggnad, kläder och ändringar kan manuell justering behövas.
- Om du samtidigt använder andra system som ändrar hållningen bör du kontrollera hur låsen och posebytena fungerar. Det kan gå att justera med ”Avatarinställningar > Integrera spårningslås med andra verktyg”.
- Skaparen ansvarar inte för olägenheter som uppstår vid användning av verktyget.

## Användarvillkor

Använd produkten först efter att du har godkänt användarvillkoren, som är upprättade med VN3-licensen.

[Användarvillkor för Virtual Love](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)

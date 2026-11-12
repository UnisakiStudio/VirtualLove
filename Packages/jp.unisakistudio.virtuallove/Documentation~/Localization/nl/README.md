# Virtual Love

Een tool voor VRChat-avatars waarmee je met 3-puntstracking of op desktop samen met een partner bij elkaar horende poses kunt aannemen. Er zijn 22 poses voor de man en 22 voor de vrouw, 44 in totaal. Ook een staande spagaat en de Jack-O-challenge zijn mogelijk.

Deze README is voor v3.2.0 in ontwikkeling; de officiële datum staat niet vast. De geïnstalleerde versie staat boven in de Inspector.

- [BOOTH-productpagina](https://yunisaki.booth.pm/items/3641334)
- [Wijzigingsgeschiedenis](CHANGELOG.md)

## Weergavetaal en offline documentatie

Kies de taal bij Language / 言語 boven in de Inspector. Eén keuze geldt voor de Inspector en de gegenereerde VRChat-menu’s. Upload de avatar opnieuw om de taal in het spel te veranderen.

Zonder expliciete keuze wordt de computertaal gebruikt; niet-ondersteunde talen gebruiken Engels. Windows, macOS en Linux worden ondersteund. De laatste keuze wordt in EditorPrefs bewaard voor andere projecten van dezelfde systeemgebruiker op deze computer. Alle posehulpmiddelen en avatars gebruiken dezelfde taal. Een wijziging in de Inspector van een hulpmiddel werkt de gedeelde voorkeur bij; taalkeuzes per avatar worden genegeerd. Er is geen synchronisatie met andere computers. Licenties blijven op dezelfde manier opgeslagen. De taalknop verschijnt alleen bij de eerste installatiebevestiging als er nog geen taal is opgeslagen. Latere taalwijzigingen gebeuren in de Inspector.

Kies een README of wijzigingsgeschiedenis in het meegeleverde [taaloverzicht](../index.html). Ook Handleiding en Wijzigingen bekijken in de Inspector volgen de gekozen taal. De namen van de meegeleverde poses en van de categorieën in het menu in het spel worden eveneens in de gekozen taal getoond. De gebruiksvoorwaarden worden zoals voorheen in het Japans meegeleverd.

## Installatie

1. Importeer VirtualLove_Boy.unitypackage of VirtualLove_Girl.unitypackage uit je aankoopbestanden in Unity. In de Engelse editie heten de bestanden VirtualLove_Male_Installer.unitypackage en VirtualLove_Female_Installer.unitypackage.
2. Nadat de pakketbron is geregistreerd, kun je Virtual Love met VCC of ALCOM aan je project toevoegen. Unisaki Posing System 3.2.0 is vereist.
3. Klik in de Hierarchy met de rechtermuisknop op de avatar en kies Unisaki Studio > Virtual Love (Man) toevoegen of Unisaki Studio > Virtual Love (Vrouw) toevoegen.
4. Selecteer 三点だいしゅき(男) of 三点だいしゅき(女), dat in de avatar is toegevoegd, en stel in de Inspector de functies en poses in die je wilt gebruiken.
5. Controleer de poses in het voorbeeld en upload de avatar zoals gewoonlijk.

Vereist: Unity 2022.3, VRChat Avatars SDK 3.10.4+, Modular Avatar 1.x vanaf 1.15.1 en NDMF 1.x vanaf 1.14.0. Werk benodigde pakketten samen bij met VCC/ALCOM.

## Bijwerken vanaf oudere versies

Werk product en Unisaki Posing System samen bij. Bestaande opties blijven behouden. Controleer functies/ExpressionParameters en vernieuw gebruikte voorberekening voor opnieuw uploaden.

## Waar instellen

| Tabblad | Belangrijkste instellingen |
| --- | --- |
| Functies | Menufuncties voor in het spel, Fotomodus, ademhaling, pictogramafbeeldingen en controle van het parameterverbruik |
| Poses | Te gebruiken poses, zoeken, toevoegen, volgorde wijzigen, voorbeeld en animatieaanpassing |
| Avatarinstellingen | Lichaamscorrectie, overnemen van de oorspronkelijke houding en eigen bewegingen, voorinstellingen |

Schakel de functies die je nodig hebt in voordat je uploadt. Bij onderdelen met Instellingen openen kun je daaronder gedetailleerde instellingen tonen.

## Basisbediening in het spel

Open het Expressions-menu en kies een pose van Virtual Love. Kies de poses van de man en de vrouw die bij elkaar horen en stem je positie en richting af op je partner.

Schakel de vergrendeling van hoofd, armen en voeten om en bepaal zo welke lichaamsdelen je tracking volgen. Met Voeten vast kun je je hoofd bewegen terwijl de voetkant de pose behoudt. Wil je een pose spiegelen of de hoogte ervan aanpassen, schakel dan vooraf de bijbehorende functies in Unity in.

### Fotomodus

Verplaats je avatar naar een plek waar je hem kunt zien, pas de richting aan en maak foto’s.

1. Zet in Unity Functies > Menufuncties > Fotomodus aan.
2. Open in VRChat Fotomodus en kies bij Pose kiezen de gewenste pose.
3. Verplaats de avatar met Afstand tot maximaal 3m naar voren. Is de afstand groter dan 0, dan kijkt de avatar naar je toe.
4. Draai de avatar met Richting en zet, zodra de positie goed is, indien nodig Voeten vast aan. De voeten worden bij de start niet automatisch vastgezet, zodat je eerst de positie kunt aanpassen.
5. Druk op Foto afsluiten als je klaar bent met fotograferen. Afstand en richting worden hersteld en de voeten worden weer losgelaten.

Als je Gebaren uit aan het menu hebt toegevoegd, kun je ook in Fotomodus van handvorm wisselen.

Als je positie en richting alleen op je eigen scherm wijzigt, worden er geen gesynchroniseerde parameters voor Fotomodus gebruikt. Wil je dat anderen dezelfde positie en richting zien, zet dan in Unity Functies > Gemaksfuncties > Fotomodus synchroniseren aan.

Verdwijnt je eigen hoofd wanneer het dichtbij komt en maakt dat fotograferen lastig, zet dan Hoofd zichtbaar houden in Fotomodus aan. Dit geldt voor je eigen scherm tijdens het fotograferen; daarna keert de normale weergave terug.

### Voethoogte en Vloerhoogte

Zet in Unity onder Functies > Menufuncties de gewenste onderdelen aan om ze aan het menu Instellingen in VRChat toe te voegen.

- **Voethoogte**: past de hoogte van de voetkant aan met behoud van de hoofdpositie. Gebruik dit als de voeten in de vloer zakken of erboven zweven, of om de hoogte op je partner af te stemmen.
- **Vloerhoogte**: verplaatst het hele lichaam, inclusief het hoofd, omhoog en omlaag. 50% is de oorspronkelijke hoogte, 0% is 3m lager en 100% is 3m hoger. Zet de waarde terug rond 50% om de oorspronkelijke hoogte te herstellen.

In combinatie met Fotomodus kun je de hoogte, afstand en richting van de avatar aanpassen. Verplaatsen en draaien in Fotomodus en Vloerhoogte corrigeren ook de standaardbewegingen en eigen bewegingen die worden gebruikt wanneer er geen pose is gekozen. Controleer het gezichtspunt en het gedrag na het vervangen van standaardbewegingen in VRChat zelf.

### Spiegelen en Gebaren uit

- **Spiegelen**: zet Functies > Menufuncties > Spiegelen aan en wissel in het VRChat-menu links en rechts van de pose om.
- **Gebaren uit**: zet Functies > Menufuncties > Gebaren uit aan. Als je dit in VRChat inschakelt, blijven de vingerstanden van de pose behouden, ook wanneer je de controllers vastpakt.

### Ademhaling

1. Zet Functies > Gemaksfuncties > Ademhaling animeren aan.
2. Kies via Instellingen openen per houdingscategorie Geen, Zwak, Gemiddeld, Sterk, Snel of Aangepast. Pas de sterkte aan in de categorie die bij de poses van Virtual Love hoort. Met Aangepast kun je een zelfgemaakte ademhalingsanimatie opgeven.
3. Wil je de ademhaling ook in het spel kunnen stoppen en hervatten, zet dan ook Functies > Menufuncties > Ademhaling aan. In VRChat schakel je met Ademhaling tussen ON/OFF.

Met Standaardwiegen van VRChat uitschakelen onderdruk je de standaardlichaamsbeweging die in rust automatisch wordt toegevoegd. De ademhaling die in de posetool is ingesteld, blijft gewoon werken.

### Vervorming van de pose door hoofdrotatie beperken

Zet Functies > Gemaksfuncties > Vervorming door hoofdrotatie verminderen aan. Gebruik dit wanneer de lichaamshouding bij het uitschakelen van Hoofd vast vervormt doordat de nekrichting afwijkt van de oorspronkelijke pose.

### Omdraaien

Omdraaien is een functie waarvoor je zelf een passende lighouding en zijwaartse animaties voorbereidt.

1. Zet Functies > Menufuncties > Omdraaien aan.
2. Open in Poses de Details van de gewenste pose en zet Omdraaien inschakelen aan.
3. Wijs bij Zijpose voor omdraaien de bijbehorende animaties toe en pas indien nodig Sterkte van grondcorrectie aan.
4. Kies in VRChat de bijbehorende pose, zet Hoofd vast uit en zet Omdraaien aan. Kantel je hoofd naar links of rechts om je om te draaien.

Poses die Omdraaien gebruiken, kunnen de gewone MotionTime-instelling niet gebruiken. De meegeleverde poses van Virtual Love bevatten geen zijwaartse animaties voor Omdraaien; bereid zelf passende bewegingen voor als je de functie wilt gebruiken.

## Parameterverbruik

Door functies die je niet nodig hebt uit te schakelen, beperk je het verbruik van ExpressionParameters.

| Functie | Extra verbruik |
| --- | --- |
| Spiegelen | 1 bit |
| Gebaren uit | 1 bit |
| Voethoogte | 8 bit |
| Vloerhoogte | 8 bit |
| Ademhalingsbeweging | 0 bit |
| Ademhaling ON/OFF in het spel | 1 bit |
| Fotomodus (alleen je eigen scherm) | 0 bit |
| Fotomodus synchroniseren | 16 bit |
| Hoofd zichtbaar tijdens het fotograferen | 0 bit |
| Vervorming door hoofdrotatie verminderen | 1 bit (gedeeld met Omdraaien) |
| Omdraaien | 10 bit (waarvan 1 bit gedeeld met de vervormingscorrectie) |

Hier komt het verbruik van onder meer de posekeuze nog bij. Controleer het totaal in de Inspector. Wanneer meerdere posetools de gedeelde functies gebruiken, telt het gedeelde deel niet dubbel. Het verbruik van andere systemen, zoals kleding, zit niet in dit totaal.

## Poses controleren en aanpassen

Met Voorbeeld bij elke pose in Poses toon je de houding in de Scene. Open Animatieaanpassing om tijdens het voorbeeld de lichaamsrichting en de gewrichten aan te passen en het resultaat op te slaan.

De meegeleverde poses zijn gemaakt met あのん（Anon） van こよりLab als referentie. Pas onder meer de contactpunten met je partner aan op lichaamsbouw en kleding.

Met Avatarspecifieke correctie inschakelen onder Avatarinstellingen corrigeer je verschillen in de beginhoeken en torsie van gewrichten ten opzichte van de referentieavatar. Achterwaartse kniebuiging voorkomen gaat het achterwaarts doorbuigen van de knieën tegen. Open de gedetailleerde instellingen om Minimale kniebuiging (graden) aan te passen. Controleer ook in het voorbeeld hoe de avatar eruitziet met de correcties ingeschakeld.

Zoeken op posenaam, meerdere animaties toevoegen en de volgorde wijzigen doe je ook in Poses. Schakel poses die je niet nodig hebt uit of verwijder ze.

Het snelle voorbeeld voert de build van MA en NDMF niet uit; controleer het eindresultaat, inclusief kleding en andere systemen, daarom ook na de avatarbuild.

### Pictogramafbeeldingen van poses

Zet Posepictogrammen genereren onder Functies aan om afbeeldingen van de poses aan het menu in het spel toe te voegen. De build duurt langer door het genereren van de afbeeldingen. Zet Pictogramgrootte verminderen aan om ruimte te besparen. Voor Android worden geen posepictogrammen gegenereerd.

### Voorinstellingen

Onderaan Avatarinstellingen kun je een voorinstelling kiezen. Deze voorinstelling toepassen vervangt de huidige pose-instellingen; sla je aanpassingen dus op voordat je wisselt.

Aanpassingsanimatiebestanden die je met Animatieaanpassing hebt gemaakt, en voorinstellingen waarin ze zijn ingesteld, mag je zonder afzonderlijke toestemming van Unisaki Studio verspreiden en verkopen. Gebruik dit bijvoorbeeld om aanpassingsgegevens voor zelfgemaakte avatars te delen.

## Voorberekening

Met Voorberekening bijwerken sla je de gegenereerde menu’s en animaties op, zodat de avatarbuild ze kan hergebruiken en sneller klaar is. Ook zonder voorberekening worden de benodigde gegevens tijdens de gewone build gegenereerd.

Bekijk na het wijzigen van poses of functies Instellingen controleren in de Inspector en werk de voorberekening bij als je die gebruikt. Een waarschuwing verbergen werkt het gegenereerde resultaat niet bij.

## Cadeau geven

Als je het niet zelf gebruikt, mag je de versie voor de man of die voor de vrouw aan je partner cadeau geven. Wie het cadeau krijgt, mag het alleen gebruiken met degene die het heeft gegeven.

## Gebruiksnotities

- Dit product is als grap bedoeld. Gebruik het niet voor intimidatie.
- Houd je bij het gebruik aan de gebruiksvoorwaarden en omgangsregels van VRChat.
- Posevergrendeling tijdens volledige lichaamstracking wordt niet ondersteund.
- Afhankelijk van de lichaamsbouw, kleding en aanpassingen van de avatar kan handmatige afstelling nodig zijn.
- Controleer bij gebruik samen met andere systemen die de houding wijzigen hoe de vergrendelingen en het wisselen van pose werken. Soms kun je dit afstellen met Avatarinstellingen > Trackingvergrendelingen met andere gereedschappen integreren.
- De maker is niet aansprakelijk voor nadeel dat voortvloeit uit het gebruik van deze tool.

## Gebruiksvoorwaarden

Gebruik dit product alleen als je akkoord gaat met de gebruiksvoorwaarden, die met de VN3-licentie zijn opgesteld.

[Gebruiksvoorwaarden van Virtual Love](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)

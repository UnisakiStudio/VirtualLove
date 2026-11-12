# Virtual Love

Ein Werkzeug für VRChat-Avatare, mit dem du im 3-Punkt-Tracking oder im Desktop-Modus Paarposen mit deinem Gegenüber einnehmen kannst. Enthalten sind je 22 Posen für Mann und Frau, insgesamt 44. Auch ein Standspagat und die Jack-O-Challenge sind dabei.

Diese README betrifft die in Entwicklung befindliche v3.2.0. Ein Veröffentlichungstermin steht noch nicht fest. Die installierte Version steht oben im Inspector.

- [BOOTH-Produktseite](https://yunisaki.booth.pm/items/3641334)
- [Änderungsverlauf](CHANGELOG.md)

## Anzeigesprache und Offline-Dokumentation

Wähle die Anzeigesprache oben im Inspector unter „Language / 言語“. Die Auswahl gilt zugleich für den Inspector und die erzeugten VRChat-Menüs. Lade den Avatar erneut hoch, um die Sprache im Spiel zu ändern.

Ohne ausdrückliche Auswahl wird die Computersprache verwendet; nicht unterstützte Sprachen verwenden Englisch. Windows, macOS und Linux werden unterstützt. Die letzte Auswahl wird in EditorPrefs gespeichert und für andere Projekte desselben Betriebssystembenutzers auf diesem Computer wiederverwendet. Alle Posenwerkzeuge und Avatare verwenden dieselbe Sprache. Eine Änderung im Inspector eines beliebigen Werkzeugs aktualisiert die gemeinsame Einstellung; avatarbezogene Sprachauswahlen werden ignoriert. Andere Computer werden nicht synchronisiert. Die Lizenzspeicherung bleibt unverändert. Die Sprachschaltfläche erscheint nur bei der ersten Installationsbestätigung, wenn noch keine Sprache gespeichert ist. Spätere Sprachänderungen erfolgen im Inspector.

README und Änderungsverlauf kannst du in der mitgelieferten [Sprachübersicht](../index.html) auswählen. Auch „Anleitung“ und „Änderungen anzeigen“ im Inspector folgen der gewählten Sprache. Die Namen der enthaltenen Posen und der Kategorien im Spielmenü werden ebenfalls in der gewählten Sprache angezeigt. Die Nutzungsbedingungen liegen wie bisher auf Japanisch bei.

## Installation

1. Importiere „VirtualLove_Boy.unitypackage“ oder „VirtualLove_Girl.unitypackage“ aus den gekauften Dateien in Unity.
2. Sobald die Paketquelle registriert ist, kannst du Virtual Love über VCC oder ALCOM zu deinem Projekt hinzufügen. Unisaki Posing System 3.2.0 wird benötigt.
3. Klicke in der Hierarchy mit der rechten Maustaste auf den gewünschten Avatar und wähle „Unisaki Studio > Virtual Love (Mann) hinzufügen“ oder „Unisaki Studio > Virtual Love (Frau) hinzufügen“.
4. Wähle das im Avatar hinzugefügte Objekt „三点だいしゅき(男)“ oder „三点だいしゅき(女)“ aus und lege im Inspector die Funktionen und Posen fest.
5. Prüfe die Posen in der Vorschau und lade den Avatar wie gewohnt hoch.

Benötigt werden Unity 2022.3, VRChat Avatars SDK ab 3.10.4, Modular Avatar 1.x ab 1.15.1 und NDMF 1.x ab 1.14.0. Aktualisiere erforderliche Pakete gemeinsam mit VCC oder ALCOM.

## Aktualisierung älterer Versionen

Aktualisiere Produkt und Unisaki Posing System zusammen. Einstellungen bereits platzierter Werkzeuge bleiben erhalten. Prüfe Funktionen und Parameterverbrauch im Inspector; bei genutzter Vorberechnung klicke vor dem erneuten Upload auf „Vorberechnung aktualisieren“.

## Wo du Einstellungen findest

| Tab | Wichtigste Einstellungen |
| --- | --- |
| Funktionen | Menüfunktionen im Spiel, Fotomodus, Atmung, Icon-Bilder und Prüfung des Parameterverbrauchs |
| Posen | Verwendete Posen, Suche, Hinzufügen, Sortieren, Vorschau und Animationsanpassung |
| Avatareinrichtung | Körperkorrektur, Übernahme der ursprünglichen Haltung und eigener Bewegungen, Voreinstellungen |

Schalte vor dem Upload die benötigten Funktionen ein. Bei Einträgen mit „Einstellungen öffnen“ lassen sich darunter ausführliche Einstellungen anzeigen.

## Grundlegende Bedienung im Spiel

Öffne das Expressions-Menü und wähle eine Pose von Virtual Love. Wähle die Posen, die für Mann und Frau ein Paar bilden, und stimme Position und Ausrichtung mit deinem Gegenüber ab.

Mit den Fixierungen für Kopf, Arme und Füße legst du fest, welche Körperteile deinem Tracking folgen. Mit „Füße fixieren“ kannst du den Kopf bewegen, während der Unterkörper seine Pose behält. Wenn du eine Pose spiegeln oder ihre Höhe anpassen möchtest, aktiviere die entsprechenden Funktionen vorher in Unity.

### Fotomodus

Du kannst deinen Avatar an eine Stelle bewegen, an der du ihn siehst, seine Richtung anpassen und Fotos aufnehmen.

1. Schalte in Unity „Funktionen > Menüfunktionen > Fotomodus“ ein.
2. Öffne in VRChat „Fotomodus“ und wähle unter „Pose wählen“ die gewünschte Pose.
3. Mit „Abstand“ bewegst du den Avatar bis zu 3m nach vorn. Ist der Abstand größer als 0, wendet sich der Avatar dir zu.
4. Drehe ihn mit „Richtung“ und schalte bei Bedarf „Füße fixieren“ ein, sobald die Position stimmt. Zu Beginn werden die Füße nicht automatisch fixiert, sodass du die Position vorher anpassen kannst.
5. Drücke nach dem Fotografieren „Foto beenden“. Abstand und Richtung werden zurückgesetzt und die Fußfixierung wird aufgehoben.

Wenn du „Gesten aus“ zum Menü hinzugefügt hast, kannst du die Handform auch im Fotomodus wechseln.

Wenn du Position und Richtung nur auf deinem eigenen Bildschirm änderst, verbraucht der Fotomodus keine synchronisierten Parameter. Sollen auch andere dieselbe Position und Richtung sehen, schalte in Unity „Funktionen > Komfortfunktionen > Fotomodus synchronisieren“ ein.

Wenn dein eigener Kopf ausgeblendet wird, sobald er nahe kommt, und das Fotografieren erschwert, schalte „Kopf im Fotomodus sichtbar halten“ ein. Das gilt für deine eigene Ansicht während des Fotografierens; danach wird wieder die normale Darstellung verwendet.

### Fußhöhe und Bodenhöhe

Schalte in Unity unter „Funktionen > Menüfunktionen“ die gewünschten Einträge ein; sie werden dann dem Menü „Einstellungen“ in VRChat hinzugefügt.

- **Fußhöhe**: Passt die Höhe der Fußseite an, während die Kopfposition erhalten bleibt. Nützlich, wenn die Füße im Boden versinken oder schweben oder wenn du die Höhe an dein Gegenüber angleichen möchtest.
- **Bodenhöhe**: Verschiebt den ganzen Körper einschließlich des Kopfes nach oben oder unten. 50% ist die ursprüngliche Höhe, 0% liegt 3m tiefer und 100% 3m höher. Stelle zum Zurücksetzen wieder etwa 50% ein.

In Kombination mit dem Fotomodus kannst du Höhe, Abstand und Richtung des Avatars anpassen. Verschieben und Drehen im Fotomodus sowie die Bodenhöhe wirken auch auf die Standard- und eigenen Bewegungen, wenn keine Pose gewählt ist. Prüfe den Blickpunkt und das Verhalten nach dem Ersetzen der Standardbewegungen direkt in VRChat.

### Spiegeln und Gesten aus

- **Spiegeln**: Schalte „Funktionen > Menüfunktionen > Spiegeln“ ein und wechsle im VRChat-Menü zwischen linker und rechter Ausführung der Pose.
- **Gesten aus**: Schalte „Funktionen > Menüfunktionen > Gesten aus“ ein. Ist die Option in VRChat aktiv, bleiben die in der Pose festgelegten Fingerhaltungen auch dann erhalten, wenn du die Controller greifst.

### Atmung

1. Schalte „Funktionen > Komfortfunktionen > Atmung animieren“ ein.
2. Wähle über „Einstellungen öffnen“ für jede Posenkategorie „Keine“, „Schwach“, „Mittel“, „Stark“, „Schnell“ oder „Benutzerdefiniert“. Passe die Stärke in der Kategorie an, die zu den Posen von Virtual Love gehört. Mit „Benutzerdefiniert“ kannst du eine eigene Atemanimation zuweisen.
3. Wenn du die Atmung auch im Spiel anhalten und fortsetzen möchtest, schalte zusätzlich „Funktionen > Menüfunktionen > Atmung“ ein. In VRChat schaltest du sie mit „Atmung“ ON/OFF.

Mit „VRChat-Schwanken im Stand deaktivieren“ unterdrückst du das Standard-Körperschwanken, das im Leerlauf automatisch hinzukommt. Die im Posenwerkzeug eingestellte Atmung funktioniert weiterhin.

### Verformungen durch Kopfdrehung verringern

Schalte „Funktionen > Komfortfunktionen > Verformungen durch Kopfdrehung verringern“ ein. Nützlich, wenn sich beim Lösen der Kopffixierung die Körperhaltung verformt, weil die Kopfrichtung von der ursprünglichen Pose abweicht.

### Umdrehen

„Umdrehen“ ist eine Funktion, für die du eine passende Liegepose und seitliche Animationen bereitstellst.

1. Schalte „Funktionen > Menüfunktionen > Umdrehen“ ein.
2. Öffne unter „Posen“ die „Details“ der gewünschten Pose und schalte „Umdrehen aktivieren“ ein.
3. Weise unter „Seitliche Umdrehpose“ die passenden Animationen zu und passe bei Bedarf „Stärke der Bodenkorrektur“ an.
4. Wähle in VRChat die entsprechende Pose, löse die Kopffixierung und schalte „Umdrehen“ ein. Neige den Kopf nach links oder rechts, um dich umzudrehen.

Posen mit Umdrehen können die normale MotionTime-Einstellung nicht verwenden. Die in Virtual Love enthaltenen Posen bringen keine seitlichen Animationen für das Umdrehen mit; stelle bei Bedarf passende Bewegungen selbst bereit.

## Parameterverbrauch

Wenn du nicht benötigte Funktionen ausschaltest, sinkt der Verbrauch an ExpressionParameters.

| Funktion | Zusätzlicher Verbrauch |
| --- | --- |
| Spiegeln | 1 bit |
| Gesten aus | 1 bit |
| Fußhöhe | 8 bit |
| Bodenhöhe | 8 bit |
| Atembewegung | 0 bit |
| Atmung im Spiel ON/OFF | 1 bit |
| Fotomodus (nur eigener Bildschirm) | 0 bit |
| Synchronisierung des Fotomodus | 16 bit |
| Kopfanzeige beim Fotografieren | 0 bit |
| Verringern von Verformungen durch Kopfdrehung | 1 bit (gemeinsam mit Umdrehen) |
| Umdrehen | 10 bit (davon 1 bit gemeinsam mit der Verformungsverringerung) |

Hinzu kommt der Verbrauch für die Posenauswahl und Ähnliches. Die Summe siehst du im Inspector. Nutzen mehrere Posenwerkzeuge die gemeinsamen Funktionen, wird der gemeinsame Anteil nicht doppelt gezählt. Der Verbrauch anderer Gimmicks, etwa von Outfits, ist in dieser Summe nicht enthalten.

## Posen prüfen und anpassen

Mit „Vorschau“ bei jeder Pose unter „Posen“ zeigst du die Haltung in der Scene an. Über „Animationsanpassung“ kannst du während der Vorschau Körperausrichtung und Gelenke anpassen und das Ergebnis speichern.

Die enthaltenen Posen wurden auf Grundlage von „あのん（Anon）“ von こよりLab erstellt. Passe etwa die Berührungspunkte mit deinem Gegenüber an Körperbau und Outfit an.

Mit „Avatarspezifische Korrektur aktivieren“ unter „Avatareinrichtung“ gleichst du Unterschiede bei den Ausgangsgelenkwinkeln und der Verdrehung gegenüber dem Referenzavatar aus. „Rückwärtsknicken der Knie verhindern“ unterdrückt nach hinten knickende Knie. In den Detaileinstellungen kannst du „Minimale Kniebeugung (Grad)“ anpassen. Prüfe auch das Aussehen mit aktivierter Korrektur in der Vorschau.

Auch die Suche nach Posennamen, das Hinzufügen mehrerer Animationen und das Ändern der Reihenfolge erledigst du unter „Posen“. Deaktiviere oder lösche Posen, die du nicht brauchst.

Die Schnellvorschau führt den Build von MA und NDMF nicht aus. Prüfe den Endzustand einschließlich Outfits und anderer Gimmicks deshalb auch nach dem Avatar-Build.

### Icon-Bilder der Posen

Mit „Posen-Icons erzeugen“ unter „Funktionen“ erhalten die Einträge im Spielmenü Bilder der Posen. Der Build dauert um die Zeit für die Bilderzeugung länger. Wenn du Speicherplatz sparen möchtest, schalte „Icongröße verringern“ ein. Für Android werden keine Posen-Icons erzeugt.

### Voreinstellungen

Ganz unten in „Avatareinrichtung“ kannst du eine Voreinstellung wählen. „Diese Voreinstellung anwenden“ ersetzt die aktuellen Poseneinstellungen; speichere deine Anpassungen daher vor dem Wechsel.

Anpassungsanimationen, die du mit der Animationsanpassung erstellt hast, und Voreinstellungen, die sie verwenden, darfst du ohne gesonderte Genehmigung von Unisaki Studio weitergeben und verkaufen. Nutze das zum Beispiel, um Anpassungsdaten für selbst erstellte Avatare zu teilen.

## Vorberechnung

Mit „Vorberechnung aktualisieren“ speicherst du die erzeugten Menüs und Animationen, damit sie beim Avatar-Build wiederverwendet werden und der Build schneller abläuft. Auch ohne Vorberechnung werden die benötigten Daten beim normalen Build erzeugt.

Sieh nach Änderungen an Posen oder Funktionen unter „Einstellungen prüfen“ im Inspector nach und aktualisiere die Vorberechnung, falls du sie verwendest. Das Ausblenden einer Warnung aktualisiert das erzeugte Ergebnis nicht.

## Verschenken

Wenn du es nicht selbst verwendest, darfst du entweder die Ausgabe für den Mann oder die für die Frau deiner Partnerin oder deinem Partner schenken. Wer es geschenkt bekommt, darf es nur zusammen mit der schenkenden Person verwenden.

## Nutzungshinweise

- Dieses Produkt ist als Scherzartikel gedacht. Bitte verwende es nicht für Belästigungen.
- Halte dich bei der Nutzung an die Nutzungsbedingungen und Umgangsregeln von VRChat.
- Das Fixieren von Posen bei Ganzkörper-Tracking wird nicht unterstützt.
- Je nach Körperbau, Outfit und Modifikationen des Avatars sind manuelle Anpassungen nötig.
- Wenn du andere Gimmicks nutzt, die die Haltung verändern, prüfe das Verhalten der Fixierungen und des Posenwechsels. Unter Umständen hilft „Avatareinrichtung > Tracking-Fixierungen mit anderen Werkzeugen integrieren“.
- Der Ersteller haftet nicht für Nachteile, die durch die Verwendung dieses Werkzeugs entstehen.

## Nutzungsbedingungen

Verwende dieses Produkt erst, nachdem du den mit der VN3-Lizenz erstellten Nutzungsbedingungen zugestimmt hast.

[Nutzungsbedingungen von Virtual Love](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)

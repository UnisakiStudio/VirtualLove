# Virtual Love

Narzędzie do awatarów VRChat, które pozwala przyjmować pozy w parze z drugą osobą przy śledzeniu 3-punktowym lub w trybie desktopowym. Zawiera po 22 pozy dla mężczyzny i dla kobiety, łącznie 44. Są wśród nich także szpagat na stojąco i wyzwanie Jack-O.

Ten README dotyczy tworzonej wersji v3.2.0. Data oficjalnego wydania nie została ustalona. Zainstalowana wersja jest widoczna u góry Inspectora.

- [Strona produktu w BOOTH](https://yunisaki.booth.pm/items/3641334)
- [Historia zmian](CHANGELOG.md)

## Język interfejsu i dokumentacja offline

Wybierz język w polu „Language / 言語” u góry Inspectora. Jeden wybór obejmuje Inspector i generowane menu VRChat. Aby zmienić język w grze, prześlij awatara ponownie.

Jeżeli nie wybrano języka, używany jest język komputera, a dla nieobsługiwanego języka — angielski. Obsługiwane są Windows, macOS i Linux. Ostatni wybór jest zapisywany w EditorPrefs i używany także w innych projektach tego samego użytkownika systemu na tym komputerze. Wszystkie narzędzia do pozowania i awatary używają tego samego języka. Zmiana w Inspectorze dowolnego narzędzia aktualizuje wspólne ustawienie; wybory języka poszczególnych awatarów są ignorowane. Nie jest synchronizowany z innymi komputerami. Sposób przechowywania licencji nie zmienia się. Przycisk języka pojawia się tylko przy pierwszym potwierdzeniu instalacji, gdy nie zapisano języka. Późniejszych zmian dokonuje się w Inspectorze.

README i historię zmian można wybrać z dołączonej [listy języków](../index.html). Przyciski „Instrukcja” i „Pokaż zmiany” w Inspectorze również uwzględniają wybrany język. W wybranym języku wyświetlane są też nazwy dołączonych póz i nazwy kategorii w menu w grze. Warunki użytkowania są, tak jak dotąd, dołączone w wersji japońskiej.

## Instalacja

1. Zaimportuj do Unity plik „VirtualLove_Boy.unitypackage” lub „VirtualLove_Girl.unitypackage” dołączony do zakupionych plików.
2. Po zarejestrowaniu źródła pakietów możesz dodać „Virtual Love” do swojego projektu z VCC lub ALCOM. Wymagany jest Unisaki Posing System 3.2.0.
3. W Hierarchy kliknij prawym przyciskiem myszy awatara, na którym chcesz zainstalować narzędzie, i wybierz „Unisaki Studio > Dodaj Virtual Love (mężczyzna)” lub „Unisaki Studio > Dodaj Virtual Love (kobieta)”.
4. Wybierz dodany do awatara obiekt „三点だいしゅき(男)” lub „三点だいしゅき(女)” i ustaw w Inspectorze używane funkcje i pozy.
5. Sprawdź pozy w podglądzie i prześlij awatara jak zwykle.

Wymagane są Unity 2022.3, VRChat Avatars SDK 3.10.4 lub nowszy, Modular Avatar 1.x w wersji co najmniej 1.15.1 i NDMF 1.x w wersji co najmniej 1.14.0. Zaktualizuj potrzebne pakiety razem w VCC lub ALCOM.

## Aktualizacja ze starszej wersji

Zaktualizuj ten produkt i Unisaki Posing System razem. Ustawienia już umieszczonych narzędzi zostają zachowane. Sprawdź funkcje i zużycie ExpressionParameters w Inspectorze. Jeśli korzystano z budowania wstępnego, naciśnij Aktualizuj budowanie wstępne przed ponownym przesłaniem.

## Gdzie zmieniać ustawienia

| Karta | Główne ustawienia |
| --- | --- |
| Funkcje | Dodawanie pozycji do menu w grze, tryb zdjęć, oddech, obrazy ikon, sprawdzanie zużycia parametrów |
| Pozy | Używane pozy, wyszukiwanie, dodawanie, zmiana kolejności, podgląd, dostosowywanie animacji |
| Konfiguracja awatara | Korekcja ciała, importowanie oryginalnej postawy i własnych ruchów, presety |

Przed przesłaniem awatara włącz potrzebne funkcje. Przy pozycjach z przyciskiem „Otwórz ustawienia” można wyświetlić poniżej szczegółowe ustawienia.

## Podstawowe sterowanie w grze

Otwórz menu Expressions i wybierz pozę Virtual Love. Wybierz pozy, które tworzą parę (mężczyzna i kobieta), a następnie dopasuj swoje położenie i kierunek do drugiej osoby.

Przełączając blokady głowy, ramion i stóp, wybierasz, które części ciała mają podążać za śledzeniem. Po włączeniu „Blokuj stopy” możesz poruszać głową, a dolna część ciała zachowuje pozę. Jeśli chcesz odbijać pozę w poziomie lub zmieniać jej wysokość, włącz wcześniej odpowiednie funkcje w Unity.

### Tryb zdjęć

Możesz przesunąć własnego awatara w miejsce, w którym go widzisz, ustawić jego kierunek i robić zdjęcia.

1. W Unity włącz „Funkcje > Funkcje menu > Tryb zdjęć”.
2. W VRChat otwórz „Tryb zdjęć” i wybierz pozę w „Wybierz pozę”.
3. Suwakiem „Odległość” przesuń awatara do przodu, maksymalnie o 3m. Gdy odległość jest większa od 0, awatar zwraca się w twoją stronę.
4. Obróć go suwakiem „Kierunek”, a po ustaleniu pozycji włącz w razie potrzeby „Blokuj stopy”. Na początku stopy nie są blokowane automatycznie, więc przed zablokowaniem można dopasować pozycję.
5. Po zakończeniu zdjęć naciśnij „Zakończ zdjęcia”. Odległość i kierunek wracają do wartości początkowych, a blokada stóp zostaje zwolniona.

Jeśli do menu dodano „Bez gestów”, kształt dłoni można przełączać także w trybie zdjęć.

Jeśli zmieniasz położenie i kierunek tylko na własnym ekranie, tryb zdjęć nie używa synchronizowanych parametrów. Aby inne osoby widziały to samo położenie i kierunek, włącz w Unity „Funkcje > Udogodnienia > Synchronizuj tryb zdjęć”.

Jeśli głowa własnego awatara znika z bliska i utrudnia robienie zdjęć, włącz „Pokazuj głowę w trybie zdjęć”. Ustawienie działa na twoim ekranie podczas zdjęć, a po ich zakończeniu wraca zwykły sposób wyświetlania.

### Wysokość stóp i wysokość ziemi

Pozycje włączone w Unity w „Funkcje > Funkcje menu” są dodawane do menu „Ustawienia” w VRChat.

- **Wysokość stóp**: zmienia wysokość po stronie stóp, zachowując położenie głowy. Przydaje się, gdy stopy zapadają się w podłogę lub unoszą nad nią albo gdy chcesz dopasować wysokość do drugiej osoby.
- **Wysokość ziemi**: przesuwa całe ciało razem z głową w górę i w dół. 50% to pierwotna wysokość, 0% to 3m niżej, a 100% to 3m wyżej. Aby wrócić do stanu wyjściowego, ustaw wartość w pobliżu 50%.

W połączeniu z trybem zdjęć można regulować wysokość, odległość i kierunek awatara. Przesunięcie i obrót w trybie zdjęć oraz „Wysokość ziemi” korygują także standardowe i własne ruchy używane wtedy, gdy nie wybrano żadnej pozy. Widok w VRChat i zachowanie po zastąpieniu standardowych ruchów sprawdź w samej grze.

### Odbicie i Bez gestów

- **Odbicie**: włącz „Funkcje > Funkcje menu > Odbicie”, a potem przełączaj strony pozy w menu VRChat.
- **Bez gestów**: włącz „Funkcje > Funkcje menu > Bez gestów”. Po włączeniu tej opcji w VRChat ułożenie palców ustawione w pozie jest zachowywane także wtedy, gdy ściskasz kontrolery.

### Oddech

1. Włącz „Funkcje > Udogodnienia > Animuj oddech”.
2. Przez „Otwórz ustawienia” wybierz dla każdej kategorii póz: „Brak”, „Słabe”, „Średnie”, „Silne”, „Szybkie” lub „Własne”. Siłę dopasuj w kategorii odpowiadającej pozom Virtual Love. „Własne” pozwala przypisać przygotowaną przez siebie animację oddechu.
3. Jeśli chcesz zatrzymywać i wznawiać oddech także w grze, włącz również „Funkcje > Funkcje menu > Oddech”. W VRChat pozycja „Oddech” przełącza ON/OFF.

Włączenie „Wyłącz kołysanie w spoczynku VRChat” ogranicza standardowe kołysanie ciała dodawane automatycznie w spoczynku. Oddech ustawiony w narzędziu póz działa nadal.

### Ograniczanie deformacji pozy przy obrocie głowy

Włącz „Funkcje > Udogodnienia > Ogranicz deformację pozy przy obrocie głowy”. Używaj tej opcji, gdy po zwolnieniu blokady głowy postawa ciała się deformuje, ponieważ kierunek głowy różni się od oryginalnej pozy.

### Obróć się

Obracanie się to funkcja, która wymaga przygotowania odpowiedniej pozy leżącej i animacji na boku.

1. Włącz „Funkcje > Funkcje menu > Obróć się”.
2. Na karcie „Pozy” otwórz „Szczegóły” wybranej pozy i włącz „Włącz obracanie”.
3. W polu „Boczna poza obracania” przypisz odpowiednie animacje i w razie potrzeby dopasuj „Siła korekcji podłoża”.
4. W VRChat wybierz tę pozę, zwolnij blokadę głowy i włącz „Obróć się”. Przechylenie głowy w lewo lub w prawo powoduje obrót.

Pozy korzystające z obracania nie mogą używać zwykłego ustawienia MotionTime. Pozy dołączone do Virtual Love nie zawierają bocznych animacji obracania, więc aby korzystać z tej funkcji, przygotuj odpowiednie ruchy.

## Zużycie parametrów

Wyłączenie niepotrzebnych funkcji zmniejsza zużycie ExpressionParameters.

| Funkcja | Dodatkowe zużycie |
| --- | --- |
| Odbicie | 1 bit |
| Bez gestów | 1 bit |
| Wysokość stóp | 8 bit |
| Wysokość ziemi | 8 bit |
| Ruch oddechu | 0 bit |
| ON/OFF oddechu w grze | 1 bit |
| Tryb zdjęć (tylko własny ekran) | 0 bit |
| Synchronizacja trybu zdjęć | 16 bit |
| Widoczność głowy podczas zdjęć | 0 bit |
| Ograniczanie deformacji pozy przy obrocie głowy | 1 bit (wspólny z „Obróć się”) |
| Obróć się | 10 bit (z czego 1 bit jest wspólny z ograniczaniem deformacji) |

Do tego dochodzi zużycie związane między innymi z wyborem pozy. Sumę sprawdź w Inspectorze. Gdy kilka narzędzi póz korzysta ze wspólnych funkcji, część wspólna nie jest liczona podwójnie. Zużycie innych mechanizmów, na przykład strojów, nie jest wliczane do tej sumy.

## Sprawdzanie i dostosowywanie póz

Przycisk „Podgląd” przy każdej pozie na karcie „Pozy” pokazuje postawę w Scene. Po otwarciu „Dostosowywanie animacji” można podczas podglądu dopasować kierunek ciała i stawy, a następnie zapisać wynik.

Dołączone pozy powstały na podstawie awatara „あのん（Anon）” autorstwa こよりLab. Dopasuj między innymi miejsca styku z drugą osobą do budowy ciała i stroju awatara.

Opcja „Włącz korekcję awatara” na karcie „Konfiguracja awatara” koryguje różnice początkowych kątów stawów i skrętu względem awatara wzorcowego. „Zapobiegaj wyginaniu kolan do tyłu” ogranicza zginanie kolan w odwrotną stronę. Po otwarciu szczegółowych ustawień można dopasować „Minimalne zgięcie kolana (stopnie)”. Wygląd z włączoną korekcją również sprawdź w podglądzie.

Na karcie „Pozy” można też wyszukiwać nazwy póz, dodawać wiele animacji naraz i zmieniać kolejność. Niepotrzebne pozy wyłącz lub usuń.

Szybki podgląd nie uruchamia procesu budowania MA i NDMF, dlatego stan końcowy, razem ze strojami i innymi mechanizmami, sprawdź także po zbudowaniu awatara.

### Obrazy ikon póz

Po włączeniu „Generuj ikony poz” na karcie „Funkcje” pozycje menu w grze otrzymują obrazy póz. Budowanie trwa dłużej o czas potrzebny na wygenerowanie obrazów. Aby ograniczyć rozmiar, włącz „Zmniejsz rozmiar ikon”. Na platformie Android ikony póz nie są generowane.

### Presety

Preset można wybrać na samym dole karty „Konfiguracja awatara”. „Zastosuj ten preset” zastępuje bieżące ustawienia póz, dlatego przed przełączeniem zapisz wprowadzone zmiany.

Pliki animacji dostosowujących utworzone funkcją dostosowywania animacji oraz presety, w których je ustawiono, można rozpowszechniać i sprzedawać bez osobnej zgody Unisaki Studio. Możesz w ten sposób na przykład udostępniać dane dostosowujące dla awatarów własnego autorstwa.

## Budowanie wstępne

„Aktualizuj budowanie wstępne” zapisuje wygenerowane menu i animacje, dzięki czemu podczas budowania awatara można je wykorzystać ponownie i przyspieszyć cały proces. Bez budowania wstępnego potrzebne dane są generowane podczas zwykłego budowania.

Po zmianie póz lub funkcji zajrzyj do sekcji „Sprawdź ustawienia” w Inspectorze i, jeśli korzystasz z budowania wstępnego, zaktualizuj je. Ukrycie ostrzeżenia nie aktualizuje wygenerowanych danych.

## Prezenty

Jeśli nie używasz jej samodzielnie, jedną z wersji — dla mężczyzny albo dla kobiety — możesz podarować swojej partnerce lub swojemu partnerowi. Obdarowana osoba może jej używać wyłącznie z osobą, od której ją dostała.

## Uwagi dotyczące używania

- Ten produkt powstał w celach żartobliwych. Prosimy nie używać go do nękania innych.
- Używaj go zgodnie z warunkami korzystania z VRChat i zasadami dobrego wychowania.
- Blokowanie pozy podczas śledzenia całego ciała nie jest obsługiwane.
- W zależności od budowy ciała awatara, stroju i wprowadzonych modyfikacji może być potrzebne ręczne dopasowanie.
- Jeśli używasz jednocześnie innych mechanizmów zmieniających postawę, sprawdź działanie blokad i przełączania póz. Czasem pomaga ustawienie „Konfiguracja awatara > Połącz blokady śledzenia z innymi narzędziami”.
- Twórca nie ponosi odpowiedzialności za szkody wynikłe z używania tego narzędzia.

## Warunki użytkowania

Z produktu można korzystać po zaakceptowaniu warunków użytkowania przygotowanych na podstawie licencji VN3.

[Warunki użytkowania Virtual Love](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)

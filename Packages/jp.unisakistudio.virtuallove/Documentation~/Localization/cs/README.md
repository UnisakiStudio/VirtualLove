# Virtual Love

Nástroj pro avatary VRChat, se kterým si můžete s partnerem užívat párové pózy při tříbodovém sledování nebo v režimu plochy. Obsahuje 22 póz pro muže a 22 pro ženu, celkem 44. Nechybí ani provaz vestoje a výzva Jack-O.

Tento README je určen pro vyvíjenou verzi v3.2.0. Datum oficiálního vydání zatím nebylo stanoveno. Nainstalovaná verze se zobrazuje nahoře v Inspectoru.

- [Stránka produktu na BOOTH](https://yunisaki.booth.pm/items/3641334)
- [Historie změn](CHANGELOG.md)

## Jazyk rozhraní a offline dokumentace

Vyberte jazyk v poli „Language / 言語“ nahoře v Inspectoru. Jedna volba řídí Inspector i vytvářenou nabídku VRChat. Pro změnu jazyka ve hře avatara znovu nahrajte.

Pokud jazyk není vybrán, použije se jazyk počítače; nepodporované jazyky přejdou na angličtinu. Podporovány jsou Windows, macOS a Linux. Poslední volba se ukládá do EditorPrefs a používá se i v dalších projektech stejného uživatele OS na tomto počítači. Všechny nástroje pro pózování a avataři používají stejný jazyk. Změna v Inspectoru kteréhokoli nástroje aktualizuje společné nastavení; volby jazyka jednotlivých avatarů se ignorují. Mezi počítači se nesynchronizuje. Způsob ukládání licencí se nemění. Tlačítko jazyka se zobrazí pouze při prvním potvrzení instalace, pokud ještě není uložen žádný jazyk. Pozdější změny jazyka se provádějí v Inspectoru.

README a historii změn si můžete vybrat v přiloženém [seznamu jazyků](../index.html). Zvolený jazyk používají také položky „Návod“ a „Zobrazit změny“ v Inspectoru. Ve zvoleném jazyce se zobrazují i názvy obsažených póz a názvy kategorií v herní nabídce. Podmínky použití jsou stejně jako dříve přiloženy v japonštině.

## Instalace

1. Importujte do Unity soubor „VirtualLove_Boy.unitypackage“ nebo „VirtualLove_Girl.unitypackage“ přiložený k zakoupeným souborům. V anglické edici se soubory jmenují „VirtualLove_Male_Installer.unitypackage“ a „VirtualLove_Female_Installer.unitypackage“.
2. Po registraci zdroje balíčků můžete „Virtual Love“ přidat do projektu z VCC nebo ALCOM. Vyžaduje se Unisaki Posing System 3.2.0.
3. V Hierarchy klikněte pravým tlačítkem na avatara a zvolte „Unisaki Studio > Přidat Virtual Love (muž)“ nebo „Unisaki Studio > Přidat Virtual Love (žena)“.
4. Vyberte objekt „三点だいしゅき(男)“ nebo „三点だいしゅき(女)“ přidaný do avatara a v Inspectoru nastavte funkce a pózy, které chcete používat.
5. Zkontrolujte pózy v náhledu a avatara nahrajte obvyklým způsobem.

Požadováno je Unity 2022.3, VRChat Avatars SDK 3.10.4 nebo novější, Modular Avatar 1.x od 1.15.1 a NDMF 1.x od 1.14.0. Aktualizujte potřebné balíčky společně přes VCC nebo ALCOM.

## Aktualizace ze starší verze

Aktualizujte tento produkt a Unisaki Posing System společně. Nastavení již umístěných nástrojů se zachová. Zkontrolujte funkce a spotřebu ExpressionParameters v Inspectoru. Pokud jste používali předgenerování, před novým nahráním stiskněte Aktualizovat předgenerování.

## Umístění nastavení

| Karta | Hlavní nastavení |
| --- | --- |
| Funkce | Položky herní nabídky, režim focení, dýchání, obrázky ikon a kontrola spotřeby parametrů |
| Pózy | Používané pózy, hledání, přidávání, řazení, náhled a úprava animace |
| Nastavení avatara | Korekce těla, import původní pózy a vlastních pohybů, předvolby |

Před nahráním zapněte funkce, které potřebujete. U položek s tlačítkem „Otevřít nastavení“ lze pod nimi zobrazit podrobná nastavení.

## Základní ovládání ve hře

Otevřete nabídku Expressions a vyberte pózu Virtual Love. Zvolte pózy, které k sobě u muže a ženy patří, a slaďte s partnerem polohu a směr.

Přepínáním zámků hlavy, paží a nohou určíte, které části těla sledují váš pohyb. Se zapnutou položkou „Zamknout nohy“ můžete hýbat hlavou, zatímco dolní část těla drží pózu. Chcete-li pózu zrcadlit nebo upravit její výšku, zapněte předem příslušné funkce v Unity.

### Režim focení

Svého avatara můžete přesunout tam, kde na něj vidíte, upravit jeho směr a fotit.

1. V Unity zapněte „Funkce > Funkce nabídky > Režim focení“.
2. Ve VRChat otevřete „Režim focení“ a v položce „Vybrat pózu“ zvolte požadovanou pózu.
3. Položkou „Vzdálenost“ posunete avatara až o 3m dopředu. Je-li vzdálenost větší než 0, avatar se otočí k vám.
4. Položkou „Směr“ avatara otočte a po nastavení polohy podle potřeby zapněte „Zamknout nohy“. Na začátku se nohy nezamykají automaticky, takže polohu můžete upravit ještě před zamknutím.
5. Po dokončení stiskněte „Ukončit focení“. Vzdálenost a směr se vrátí zpět a zámek nohou se uvolní.

Pokud jste do nabídky přidali „Gesta vyp.“, můžete tvar rukou přepínat i v režimu focení.

Pokud polohu a směr měníte jen na vlastní obrazovce, synchronizované parametry režimu focení se nepoužívají. Chcete-li stejnou polohu a směr ukázat i ostatním, zapněte v Unity „Funkce > Usnadnění > Synchronizovat režim focení“.

Pokud se vaše vlastní hlava při přiblížení skrývá a ztěžuje focení, zapněte „Ponechat hlavu viditelnou v režimu focení“. Nastavení platí pro váš vlastní pohled během focení a po jeho ukončení se zobrazení vrátí do běžného stavu.

### Výška chodidel a výška podlahy

Položky, které v Unity zapnete v části „Funkce > Funkce nabídky“, se přidají do nabídky „Nastavení“ ve VRChat.

- **Výška chodidel**: upravuje výšku na straně nohou při zachování polohy hlavy. Použijte ji, když se chodidla boří do podlahy nebo se nad ní vznášejí, nebo když chcete výšku sladit s partnerem.
- **Výška podlahy**: posouvá celé tělo včetně hlavy nahoru a dolů. 50% je původní výška, 0% je o 3m níže a 100% o 3m výše. Pro návrat nastavte hodnotu zpět přibližně na 50%.

V kombinaci s režimem focení můžete upravit výšku, vzdálenost a směr avatara. Posun a otočení v režimu focení a výška podlahy korigují také výchozí a vlastní pohyby používané, když není vybrána žádná póza. Výsledný pohled a chování po nahrazení výchozích pohybů ověřte přímo ve VRChat.

### Zrcadlit a Gesta vyp.

- **Zrcadlit**: zapněte „Funkce > Funkce nabídky > Zrcadlit“ a levou a pravou stranu pózy přepínejte v nabídce VRChat.
- **Gesta vyp.**: zapněte „Funkce > Funkce nabídky > Gesta vyp.“. Po zapnutí ve VRChat zůstane zachován tvar prstů nastavený v póze, i když stisknete ovladače.

### Dýchání

1. Zapněte „Funkce > Usnadnění > Animovat dýchání“.
2. Přes „Otevřít nastavení“ zvolte pro každou kategorii póz „Žádné“, „Slabé“, „Střední“, „Silné“, „Rychlé“ nebo „Vlastní“. Sílu upravte v kategorii, která odpovídá pózám Virtual Love. U volby „Vlastní“ můžete přiřadit vlastní animaci dýchání.
3. Chcete-li dýchání zastavovat a obnovovat i ve hře, zapněte také „Funkce > Funkce nabídky > Dýchání“. Ve VRChat se položkou „Dýchání“ přepíná ON/OFF.

Zapnutím položky „Vypnout pohupování VRChat v klidu“ potlačíte výchozí pohupování těla, které se v klidu přidává automaticky. Dýchání nastavené v nástroji pro pózy funguje dál.

### Omezení deformace pózy při otočení hlavy

Zapněte „Funkce > Usnadnění > Omezit deformaci pózy při otočení hlavy“. Použijte tuto funkci, když se po odemknutí hlavy póza těla deformuje, protože se směr hlavy liší od původní pózy.

### Přetočit se

Přetočit se je funkce, pro kterou je třeba připravit odpovídající pózu vleže a animace na boku.

1. Zapněte „Funkce > Funkce nabídky > Přetočit se“.
2. Na kartě „Pózy“ otevřete „Podrobnosti“ požadované pózy a zapněte „Zapnout přetočení“.
3. Do pole „Boční póza přetočení“ přiřaďte odpovídající animace a podle potřeby upravte položku „Síla korekce podlahy“.
4. Ve VRChat vyberte příslušnou pózu, odemkněte hlavu a zapněte „Přetočit se“. Nakloněním hlavy doleva nebo doprava se přetočíte.

U póz, které používají přetočení, nelze použít běžné nastavení MotionTime. Pózy obsažené ve Virtual Love neobsahují boční animace pro přetočení, takže pokud chcete funkci používat, připravte si odpovídající pohyby.

## Spotřeba parametrů

Vypnutím nepotřebných funkcí snížíte spotřebu ExpressionParameters.

| Funkce | Dodatečná spotřeba |
| --- | --- |
| Zrcadlit | 1 bit |
| Gesta vyp. | 1 bit |
| Výška chodidel | 8 bit |
| Výška podlahy | 8 bit |
| Pohyb dýchání | 0 bit |
| ON/OFF dýchání ve hře | 1 bit |
| Režim focení (jen vlastní obrazovka) | 0 bit |
| Synchronizace režimu focení | 16 bit |
| Zobrazení hlavy při focení | 0 bit |
| Omezení deformace pózy při otočení hlavy | 1 bit (sdílený s funkcí Přetočit se) |
| Přetočit se | 10 bit (z toho 1 bit sdílený s omezením deformace pózy) |

K těmto hodnotám se přičítá spotřeba výběru pózy a dalších funkcí. Celkovou hodnotu zkontrolujte v Inspectoru. Pokud společné funkce používá více nástrojů pro pózy, sdílená část se nepočítá dvakrát. Spotřeba jiných systémů, například oblečení, není do tohoto součtu zahrnuta.

## Kontrola a úprava póz

Tlačítkem „Náhled“ u každé pózy na kartě „Pózy“ zobrazíte pózu ve Scene. Po otevření položky „Úprava animace“ můžete během náhledu upravit směr těla a klouby a výsledek uložit.

Obsažené pózy byly vytvořeny podle avatara „あのん（Anon）“ od こよりLab. Místa dotyku s partnerem a podobné detaily upravte podle postavy a oblečení.

Položkou „Zapnout korekci avatara“ na kartě „Nastavení avatara“ lze korigovat rozdíly ve výchozích úhlech kloubů a v jejich zkrutu oproti referenčnímu avatarovi. Položka „Zabránit ohybu kolen dozadu“ omezuje ohýbání kolen opačným směrem. Po otevření podrobného nastavení můžete upravit „Minimální ohyb kolena (stupně)“. Vzhled se zapnutou korekcí zkontrolujte také v náhledu.

Hledání podle názvu pózy, přidání více animací a změnu pořadí provedete rovněž na kartě „Pózy“. Nepotřebné pózy vypněte nebo odstraňte.

Zjednodušený náhled nespouští sestavení MA a NDMF, proto konečný stav včetně oblečení a dalších systémů zkontrolujte také po sestavení avatara.

### Obrázky ikon póz

Zapnutím položky „Generovat ikony póz“ na kartě „Funkce“ přidáte do herní nabídky obrázky póz. Sestavení se prodlouží o dobu potřebnou k vytvoření obrázků. Chcete-li ušetřit místo, zapněte „Zmenšit velikost ikon“. Pro Android se ikony póz negenerují.

### Předvolby

Předvolbu můžete vybrat úplně dole na kartě „Nastavení avatara“. Tlačítko „Použít tuto předvolbu“ nahradí aktuální nastavení póz, proto si před přepnutím uložte provedené úpravy.

Soubory úpravových animací vytvořené funkcí Úprava animace a předvolby, které je používají, smíte šířit a prodávat bez samostatného svolení Unisaki Studio. Využijte to například ke sdílení dat úprav pro avatary, které jste sami vytvořili.

## Předgenerování

Tlačítkem „Aktualizovat předgenerování“ uložíte vygenerované nabídky a animace, aby je bylo možné znovu použít při sestavení avatara a zpracování se zrychlilo. I bez předgenerování se potřebná data vytvoří při běžném sestavení.

Po změně póz nebo funkcí se podívejte v Inspectoru na část „Kontrola nastavení“ a předgenerování aktualizujte, pokud je používáte. Skrytím varování se vygenerovaný výsledek neaktualizuje.

## Darování

Pokud ji sami nepoužijete, můžete verzi pro muže nebo verzi pro ženu darovat svému partnerovi. Obdarovaný ji smí používat pouze s tím, kdo mu ji daroval.

## Poznámky k používání

- Tento produkt vznikl jako žert. Nepoužívejte jej k obtěžování.
- Při používání dodržujte podmínky použití VRChat a pravidla slušného chování.
- Zamknutí pózy při sledování celého těla není podporováno.
- V závislosti na postavě, oblečení a úpravách avatara může být nutná ruční úprava.
- Pokud nástroj používáte společně s jinými systémy měnícími pózu, ověřte chování zámků a přepínání póz. V některých případech pomůže nastavení „Nastavení avatara > Propojit zámky sledování s dalšími nástroji“.
- Autor nenese odpovědnost za žádnou újmu vzniklou používáním tohoto nástroje.

## Podmínky použití

Tento produkt používejte až po odsouhlasení podmínek použití, které byly vytvořeny pomocí licence VN3.

[Podmínky použití Virtual Love](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)

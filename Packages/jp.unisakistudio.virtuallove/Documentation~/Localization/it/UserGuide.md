# Virtual Love

Strumento per avatar VRChat che permette di assumere pose di coppia insieme a un partner, con tracciamento a 3 punti o in desktop. Include 22 pose per l’uomo e 22 per la donna, 44 in totale. Sono possibili anche la spaccata in piedi e la sfida Jack-O.

Questo README riguarda la versione v3.2.0 in sviluppo. La data di uscita ufficiale non è stabilita. La versione installata compare in alto nell’Inspector.

- [Pagina del prodotto su BOOTH](https://yunisaki.booth.pm/items/3641334)
- [Cronologia delle modifiche](CHANGELOG.md)

## Lingua dell’interfaccia e documentazione offline

Scegli la lingua in «Language / 言語», in cima all’Inspector. Una sola scelta si applica sia all’Inspector sia ai menu VRChat generati. Carica nuovamente l’avatar per cambiare la lingua nel gioco.

Senza una scelta esplicita viene usata la lingua del computer; se non è supportata, viene usato l’inglese. Sono supportati Windows, macOS e Linux. L’ultima scelta è salvata in EditorPrefs e riutilizzata negli altri progetti dello stesso utente del sistema su questo computer. Tutti gli strumenti di posa e gli avatar usano la stessa lingua. Cambiarla nell’Inspector di qualsiasi strumento aggiorna la preferenza comune; le scelte di lingua dei singoli avatar vengono ignorate. Non viene sincronizzata con altri computer. Il sistema di archiviazione della licenza rimane invariato. Il pulsante della lingua appare solo nella conferma iniziale di installazione se non è stata salvata una lingua. Le modifiche successive si effettuano nell’Inspector.

Scegli la lingua di README e cronologia delle modifiche dall’[elenco delle lingue](../index.html) incluso. Anche i collegamenti alla guida e alle novità nell’Inspector seguono la lingua scelta. I nomi delle pose incluse e delle categorie del menu nel gioco vengono mostrati a loro volta nella lingua scelta. Le condizioni d’uso restano incluse in giapponese, come in precedenza.

## Installazione

1. Importa in Unity «VirtualLove_Boy.unitypackage» oppure «VirtualLove_Girl.unitypackage», incluso nei file acquistati.
2. Dopo aver registrato il repository dei pacchetti, puoi aggiungere Virtual Love al progetto desiderato da VCC o ALCOM. È richiesto Unisaki Posing System 3.2.0.
3. Nella Hierarchy fai clic destro sull’avatar desiderato e scegli «Unisaki Studio > Aggiungi Virtual Love (Uomo)» oppure «Unisaki Studio > Aggiungi Virtual Love (Donna)».
4. Seleziona «三点だいしゅき(男)» o «三点だいしゅき(女)» aggiunto nell’avatar e imposta funzioni e pose nell’Inspector.
5. Controlla le pose con l’anteprima, poi carica l’avatar normalmente.

Requisiti: Unity 2022.3, VRChat Avatars SDK 3.10.4 o successivo, Modular Avatar 1.x dalla versione 1.15.1 e NDMF 1.x dalla versione 1.14.0. Aggiorna insieme i pacchetti necessari con VCC o ALCOM.

## Aggiornare da una versione precedente

Aggiorna insieme il prodotto e Unisaki Posing System. Le impostazioni degli strumenti già presenti vengono conservate. Controlla funzioni e consumo di ExpressionParameters nell’Inspector; se usavi il precalcolo, premi «Aggiorna precalcolo» prima di ricaricare l’avatar.

## Dove configurare le opzioni

| Scheda | Impostazioni principali |
| --- | --- |
| Funzioni | Menu nel gioco, Modalità foto, respiro, icone e controllo del consumo di parametri |
| Pose | Pose da usare, ricerca, aggiunta, ordine, anteprima e regolazione animazione |
| Configurazione avatar | Correzioni del corpo, importazione di pose originali o movimenti personali e preset |

Attiva le funzioni necessarie prima di caricare l’avatar. Le voci con «Apri impostazioni» possono mostrare subito sotto le impostazioni dettagliate.

## Comandi di base nel gioco

Apri il menu Expressions e scegli una posa di Virtual Love. Scegli le pose che si abbinano tra uomo e donna, poi allinea posizione e direzione a quelle del partner.

Attiva o disattiva i blocchi di testa, braccia e piedi per decidere quali parti seguono i tuoi movimenti. Con «Blocca piedi» puoi muovere la testa mantenendo la posa della parte inferiore del corpo. Per specchiare una posa o regolarne l’altezza, attiva prima in Unity le funzioni corrispondenti.

### Modalità foto

Puoi spostare il tuo avatar dove riesci a vederlo, regolarne la direzione e scattare foto.

1. In Unity attiva «Funzioni > Funzioni del menu > Modalità foto».
2. In VRChat apri «Modalità foto» e scegli la posa desiderata in «Scegli posa».
3. «Distanza» sposta l’avatar fino a 3m in avanti. Con una distanza maggiore di 0, l’avatar si rivolge verso di te.
4. Ruotalo con «Direzione» e, una volta trovata la posizione, attiva «Blocca piedi» se necessario. I piedi non vengono bloccati automaticamente all’avvio, così puoi regolare prima la posizione.
5. Al termine delle foto premi «Esci da foto». Distanza e direzione vengono azzerate e i piedi sbloccati.

Se hai aggiunto «Blocca gesti» al menu, puoi cambiare la forma delle mani anche nella Modalità foto.

Se cambi posizione e direzione soltanto nella tua vista, la Modalità foto non usa parametri sincronizzati. Per mostrare la stessa posizione e direzione anche agli altri, attiva in Unity «Funzioni > Funzioni pratiche > Sincronizzare la Modalità foto».

Se la tua testa scompare quando si avvicina e rende difficile scattare foto, attiva «Tenere visibile la testa in Modalità foto». Si applica alla tua vista durante le foto e ripristina la visualizzazione normale all’uscita.

### Altezza piedi e Altezza suolo

Attiva le voci desiderate in «Funzioni > Funzioni del menu» in Unity: vengono aggiunte al menu «Impostazioni» di VRChat.

- **Altezza piedi**: regola l’altezza dal lato dei piedi mantenendo la testa ferma. Usala quando i piedi affondano nel pavimento o restano sollevati, oppure per allinearti all’altezza del partner.
- **Altezza suolo**: sposta verticalmente tutto il corpo, testa inclusa. 50% è l’altezza originale, 0% corrisponde a 3m sotto e 100% a 3m sopra. Per tornare all’altezza originale, riporta il valore intorno al 50%.

In combinazione con la Modalità foto puoi regolare altezza, distanza e direzione dell’avatar. Spostamento e rotazione della Modalità foto e «Altezza suolo» correggono anche i movimenti standard o personalizzati usati quando non è selezionata alcuna posa. Verifica direttamente in VRChat il punto di vista e il comportamento dopo la sostituzione dei movimenti standard.

### Specchio e Blocca gesti

- **Specchio**: attiva «Funzioni > Funzioni del menu > Specchio», poi inverti destra e sinistra della posa dal menu di VRChat.
- **Blocca gesti**: attiva «Funzioni > Funzioni del menu > Blocca gesti». Quando è attivo in VRChat, la forma delle dita impostata nella posa viene mantenuta anche mentre stringi i controller.

### Respiro

1. Attiva «Funzioni > Funzioni pratiche > Animare il respiro».
2. Da «Apri impostazioni» scegli «Nessuno», «Debole», «Medio», «Forte», «Rapido» o «Personalizzato» per ciascuna categoria di pose. Regola l’intensità nella categoria che corrisponde alle pose di Virtual Love. «Personalizzato» consente di assegnare la tua animazione di respiro.
3. Per fermare e riprendere il respiro anche nel gioco, attiva anche «Funzioni > Funzioni del menu > Respiro». In VRChat, «Respiro» lo commuta ON/OFF.

Attiva «Disattivare l'oscillazione da fermo di VRChat» per attenuare l’oscillazione standard del corpo che viene aggiunta automaticamente da fermo. Il respiro impostato nello strumento per pose continua a funzionare.

### Ridurre le deformazioni dovute alla rotazione della testa

Attiva «Funzioni > Funzioni pratiche > Ridurre le deformazioni dovute alla rotazione della testa». Usala quando, disattivando «Blocca testa», il corpo si deforma perché l’orientamento della testa è diverso da quello della posa originale.

### Girarsi

Girarsi è una funzione che richiede di preparare una posa sdraiata compatibile e animazioni laterali.

1. Attiva «Funzioni > Funzioni del menu > Girarsi».
2. In «Pose», apri i «Dettagli» della posa desiderata e attiva «Abilita Girarsi».
3. Assegna le animazioni corrispondenti a «Posa laterale per girarsi» e, se necessario, regola l’«Intensità della correzione del contatto a terra».
4. In VRChat scegli la posa compatibile, disattiva «Blocca testa» e attiva «Girarsi». Inclina la testa a destra o a sinistra per girarti.

Nelle pose con Girarsi non è disponibile la normale impostazione MotionTime. Le pose incluse in Virtual Love non contengono animazioni laterali per girarsi: se vuoi usare la funzione, prepara movimenti adatti.

## Consumo di parametri

Disattivando le funzioni che non ti servono riduci il consumo di ExpressionParameters.

| Funzione | Consumo aggiuntivo |
| --- | --- |
| Specchio | 1 bit |
| Blocca gesti | 1 bit |
| Altezza piedi | 8 bit |
| Altezza suolo | 8 bit |
| Animazione del respiro | 0 bit |
| Respiro (ON/OFF nel gioco) | 1 bit |
| Modalità foto (solo vista locale) | 0 bit |
| Sincronizzazione della Modalità foto | 16 bit |
| Testa visibile durante le foto | 0 bit |
| Riduzione delle deformazioni dovute alla rotazione della testa | 1 bit (condiviso con Girarsi) |
| Girarsi | 10 bit (di cui 1 bit condiviso con la riduzione delle deformazioni) |

A questi si aggiunge il consumo della selezione delle pose e di altri elementi. Controlla il totale nell’Inspector. Se più strumenti di posa usano le funzioni comuni, la parte condivisa non viene contata due volte. Il consumo di altri sistemi, come gli abiti, non è incluso in questo totale.

## Controllo e regolazione delle pose

«Anteprima» su ogni voce di «Pose» mostra la posa nella Scene. Apri «Regolazione animazione» per regolare l’orientamento del corpo e le articolazioni guardando l’anteprima, quindi salva.

Le pose incluse sono state create prendendo come riferimento «あのん（Anon）» di こよりLab. Regola i punti di contatto con il partner e altri dettagli in base a corporatura e abiti.

In «Configurazione avatar», «Attivare la correzione dell'avatar» corregge le differenze negli angoli iniziali delle articolazioni e nella torsione rispetto all’avatar di riferimento. «Impedire la piegatura inversa delle ginocchia» limita la piegatura al contrario delle ginocchia. Apri le impostazioni dettagliate per regolare «Flessione minima del ginocchio (gradi)». Controlla con l’anteprima anche l’aspetto con le correzioni attive.

Anche la ricerca per nome, l’aggiunta di più animazioni e il cambio dell’ordine si effettuano in «Pose». Disattiva o elimina le pose che non ti servono.

L’anteprima semplice non esegue la build MA o NDMF: controlla lo stato finale, con abiti e altri sistemi, anche dopo la build dell’avatar.

### Icone delle pose

Attiva «Generare le icone delle pose» in «Funzioni» per aggiungere le immagini delle pose al menu nel gioco. La generazione delle immagini allunga la build. Per risparmiare spazio, attiva «Ridurre le dimensioni delle icone». Per Android le icone delle pose non vengono generate.

### Preset

Puoi scegliere un preset in fondo a «Configurazione avatar». «Applica questo preset» sostituisce le impostazioni attuali delle pose: salva le regolazioni prima di cambiarlo.

I file di animazione di regolazione creati con la funzione di regolazione animazione, e i preset che li utilizzano, possono essere distribuiti e venduti senza un’autorizzazione individuale di Unisaki Studio. Usali, per esempio, per condividere dati di regolazione per i tuoi avatar.

## Precalcolo

«Aggiorna precalcolo» salva i menu e le animazioni generati, così la build dell’avatar può riutilizzarli ed essere più veloce. Senza precalcolo, la normale build genera comunque i dati necessari.

Dopo aver modificato pose o funzioni, guarda «Controlla impostazioni» nell’Inspector e, se usi il precalcolo, aggiornalo. Nascondere un avviso non aggiorna i dati generati.

## Regali

Se non lo usi di persona, puoi regalare al tuo partner una delle due edizioni, Uomo o Donna. Chi lo riceve può usarlo soltanto con la persona che glielo ha regalato.

## Note d’uso

- Questo prodotto è stato creato per scherzo. Non usarlo per molestare altre persone.
- Usalo rispettando i termini di servizio e le buone maniere di VRChat.
- Il blocco delle pose durante il tracciamento full body non è supportato.
- A seconda di corporatura, abiti e modifiche dell’avatar può essere necessaria una regolazione manuale.
- Se lo usi insieme ad altri sistemi che cambiano la postura, controlla il funzionamento dei blocchi e del cambio di posa. «Configurazione avatar > Integrare i blocchi del tracciamento con altri strumenti» può aiutare a regolarli.
- L’autore non si assume alcuna responsabilità per eventuali danni derivanti dall’uso di questo strumento.

## Condizioni d’uso

Usa questo prodotto soltanto dopo aver accettato le sue condizioni d’uso, redatte con la licenza VN3.

[Condizioni d’uso di Virtual Love](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)

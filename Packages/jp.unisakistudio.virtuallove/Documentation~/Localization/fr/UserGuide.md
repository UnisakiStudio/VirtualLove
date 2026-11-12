# Virtual Love

Outil pour avatars VRChat permettant de prendre des poses à deux avec un partenaire, avec le suivi à 3 points ou en mode bureau. Il comprend 22 poses pour l’homme et 22 pour la femme, soit 44 poses au total. Le grand écart debout et le défi Jack-O sont également possibles.

Ce README concerne la version v3.2.0 en développement. La date de sortie officielle n’est pas encore fixée. La version installée apparaît en haut de l’Inspector.

- [Page du produit sur BOOTH](https://yunisaki.booth.pm/items/3641334)
- [Historique des modifications](CHANGELOG.md)

## Langue d’affichage et documentation hors ligne

Choisissez la langue d’affichage dans « Language / 言語 », tout en haut de l’Inspector. Ce choix s’applique à la fois à l’Inspector et aux menus VRChat générés. Renvoyez l’avatar pour modifier l’affichage dans le jeu.

Sans choix explicite, la langue de l’ordinateur est utilisée ; une langue non prise en charge est remplacée par l’anglais. Windows, macOS et Linux sont pris en charge. La dernière langue choisie est enregistrée dans EditorPrefs et réutilisée dans les autres projets du même utilisateur du système sur cet ordinateur. Tous les outils de poses et avatars utilisent la même langue. La modifier dans l’Inspector de n’importe quel outil met à jour le réglage commun ; les choix de langue propres aux avatars sont ignorés. Ce réglage n’est pas synchronisé avec d’autres ordinateurs. Le stockage de la licence reste inchangé. Le bouton de langue apparaît uniquement lors de la première confirmation d’installation si aucune langue n’est enregistrée. Les changements ultérieurs se font dans l’Inspector.

Choisissez la langue du README et de l’historique des modifications dans la [liste des langues](../index.html) fournie. Les liens du guide et de l’historique dans l’Inspector suivent également la langue sélectionnée. Les noms des poses fournies et ceux des catégories du menu du jeu s’affichent eux aussi dans la langue sélectionnée. Les conditions d’utilisation restent fournies en japonais, comme auparavant.

## Installation

1. Importez dans Unity le fichier « VirtualLove_Boy.unitypackage » ou « VirtualLove_Girl.unitypackage » fourni avec votre achat.
2. Une fois le dépôt de packages enregistré, vous pouvez ajouter Virtual Love au projet utilisé depuis VCC ou ALCOM. Unisaki Posing System 3.2.0 est requis.
3. Dans la Hierarchy, faites un clic droit sur l’avatar à équiper et choisissez « Unisaki Studio > Ajouter Virtual Love (Homme) » ou « Unisaki Studio > Ajouter Virtual Love (Femme) ».
4. Sélectionnez l’objet « 三点だいしゅき(男) » ou « 三点だいしゅき(女) » ajouté dans l’avatar, puis réglez les fonctions et les poses voulues dans l’Inspector.
5. Vérifiez les poses avec l’aperçu, puis envoyez l’avatar normalement.

Environnement requis : Unity 2022.3, VRChat Avatars SDK 3.10.4 ou ultérieur, Modular Avatar 1.x à partir de 1.15.1 et NDMF 1.x à partir de 1.14.0. Mettez également à jour les dépendances nécessaires dans VCC ou ALCOM.

## Mise à jour depuis une ancienne version

Mettez à jour ensemble ce produit et Unisaki Posing System. Les réglages des outils déjà placés sont conservés. Vérifiez les fonctions et la consommation des ExpressionParameters dans l’Inspector ; si vous utilisiez le précalcul, cliquez sur « Actualiser le précalcul » avant de renvoyer l’avatar.

## Où trouver les réglages

| Onglet | Réglages principaux |
| --- | --- |
| Fonctions | Ajouts au menu du jeu, Mode photo, respiration, icônes et vérification de la consommation de paramètres |
| Poses | Poses utilisées, recherche, ajout, réordonnancement, aperçu et ajustement de l’animation |
| Configuration de l'avatar | Corrections du corps, importation des poses d’origine ou de mouvements personnels et préréglages |

Activez les fonctions nécessaires avant d’envoyer l’avatar. Les éléments dotés de « Ouvrir les réglages » peuvent afficher des réglages détaillés juste en dessous.

## Commandes de base dans le jeu

Ouvrez le menu Expressions et choisissez une pose de Virtual Love. Choisissez les poses qui se correspondent côté homme et côté femme, puis accordez votre position et votre orientation avec celles de votre partenaire.

Activez ou désactivez les verrouillages de la tête, des bras et des pieds pour choisir les parties du corps qui suivent vos mouvements. Avec « Pieds fixes », vous pouvez bouger la tête tout en conservant la pose du bas du corps. Pour inverser une pose ou régler sa hauteur, activez au préalable les fonctions correspondantes dans Unity.

### Mode photo

Vous pouvez déplacer votre avatar à un endroit où vous le voyez, régler sa direction et prendre des photos.

1. Dans Unity, activez « Fonctions > Fonctions du menu > Mode photo ».
2. Dans VRChat, ouvrez « Mode photo », puis choisissez la pose voulue dans « Choisir pose ».
3. « Distance » déplace l’avatar jusqu’à 3m vers l’avant. Lorsque la distance est supérieure à 0, l’avatar vous fait face.
4. Faites-le pivoter avec « Direction » puis, une fois la position trouvée, activez « Pieds fixes » si nécessaire. Les pieds ne sont pas verrouillés automatiquement au démarrage : vous pouvez ajuster la position avant de les fixer.
5. Une fois les photos terminées, appuyez sur « Quitter photo ». La distance et la direction sont réinitialisées et les pieds sont déverrouillés.

Si « Sans gestes » a été ajouté au menu, vous pouvez aussi changer les gestes des mains en Mode photo.

Si vous ne modifiez la position et la direction que dans votre propre vue, le Mode photo n’utilise aucun paramètre synchronisé. Pour montrer la même position et la même direction aux autres personnes, activez « Fonctions > Fonctions pratiques > Synchroniser le Mode photo » dans Unity.

Si votre propre tête disparaît lorsqu’elle s’approche et gêne la prise de photos, activez « Garder la tête visible en Mode photo ». Cette option s’applique à votre propre vue pendant les photos ; l’affichage habituel revient à la sortie du mode.

### Hauteur pieds et Hauteur sol

Activez les éléments voulus dans « Fonctions > Fonctions du menu » dans Unity : ils sont ajoutés au menu « Réglages » de VRChat.

- **Hauteur pieds** : règle la hauteur du côté des pieds tout en conservant la position de la tête. Utilisez cette option lorsque les pieds s’enfoncent dans le sol ou flottent au-dessus, ou pour vous mettre à la hauteur de votre partenaire.
- **Hauteur sol** : déplace tout le corps verticalement, tête comprise. 50% correspond à la hauteur d’origine, 0% à 3m plus bas et 100% à 3m plus haut. Pour revenir à la hauteur d’origine, ramenez la valeur aux alentours de 50%.

Combinées au Mode photo, ces options permettent de régler la hauteur, la distance et la direction de l’avatar. Le déplacement et la rotation du Mode photo ainsi que « Hauteur sol » corrigent aussi les mouvements par défaut ou personnalisés utilisés lorsqu’aucune pose n’est sélectionnée. Vérifiez directement dans VRChat le point de vue obtenu et le comportement après remplacement des mouvements par défaut.

### Miroir et Sans gestes

- **Miroir** : activez « Fonctions > Fonctions du menu > Miroir », puis inversez la gauche et la droite de la pose depuis le menu de VRChat.
- **Sans gestes** : activez « Fonctions > Fonctions du menu > Sans gestes ». Une fois l’option activée dans VRChat, la forme des doigts définie dans la pose est conservée même lorsque vous serrez les manettes.

### Respiration

1. Activez « Fonctions > Fonctions pratiques > Animer la respiration ».
2. Dans « Ouvrir les réglages », choisissez « Aucun », « Faible », « Moyenne », « Forte », « Rapide » ou « Personnalisé » pour chaque catégorie de poses. Réglez l’intensité dans la catégorie correspondant aux poses de Virtual Love. « Personnalisé » permet de définir votre propre animation de respiration.
3. Pour pouvoir aussi arrêter et reprendre la respiration dans le jeu, activez également « Fonctions > Fonctions du menu > Respiration ». Dans VRChat, « Respiration » sert alors de commande ON/OFF.

Activez « Désactiver le balancement au repos de VRChat » pour atténuer le balancement du corps que VRChat ajoute automatiquement au repos. La respiration réglée dans l’outil de poses reste utilisable telle quelle.

### Réduire les déformations liées à la rotation de la tête

Activez « Fonctions > Fonctions pratiques > Réduire les déformations liées à la rotation de la tête ». Utilisez cette option lorsque, une fois « Tête fixe » désactivé, le corps se déforme parce que l’orientation de la tête diffère de celle de la pose d’origine.

### Se retourner

Se retourner est une fonction qui nécessite de préparer une pose allongée compatible et des animations de profil.

1. Activez « Fonctions > Fonctions du menu > Se retourner ».
2. Dans « Poses », ouvrez les « Détails » de la pose voulue et activez « Activer le retournement ».
3. Affectez les animations correspondantes à « Pose latérale de retournement » et ajustez la « Force de correction du contact au sol » si nécessaire.
4. Dans VRChat, choisissez la pose compatible, désactivez « Tête fixe » et activez « Se retourner ». Inclinez la tête vers la gauche ou la droite pour vous retourner.

Les poses utilisant Se retourner ne peuvent pas utiliser le réglage MotionTime ordinaire. Les poses fournies avec Virtual Love ne comprennent pas d’animations de profil pour le retournement : préparez des mouvements adaptés si vous souhaitez l’utiliser.

## Consommation de paramètres

Désactiver les fonctions inutiles réduit la consommation des ExpressionParameters.

| Fonction | Consommation supplémentaire |
| --- | --- |
| Miroir | 1 bit |
| Sans gestes | 1 bit |
| Hauteur pieds | 8 bit |
| Hauteur sol | 8 bit |
| Animation de la respiration | 0 bit |
| Respiration (ON/OFF dans le jeu) | 1 bit |
| Mode photo (vue locale uniquement) | 0 bit |
| Synchronisation du Mode photo | 16 bit |
| Tête visible pendant les photos | 0 bit |
| Réduction des déformations liées à la rotation de la tête | 1 bit (partagé avec Se retourner) |
| Se retourner | 10 bit (dont 1 bit partagé avec la réduction des déformations) |

S’y ajoute la consommation du choix de pose et d’autres éléments. Vérifiez le total dans l’Inspector. Lorsque plusieurs outils de poses utilisent les fonctions communes, la part partagée n’est comptée qu’une fois. La consommation des autres systèmes, tels que les tenues, n’est pas comprise dans ce total.

## Vérification et ajustement des poses

« Aperçu » sur chaque entrée de « Poses » affiche la posture dans la Scene. Ouvrez « Ajustement de l'animation » pour régler l’orientation du corps et les articulations tout en regardant l’aperçu, puis enregistrez le résultat.

Les poses fournies ont été créées en prenant pour référence « あのん（Anon） » de こよりLab. Ajustez notamment les points de contact avec votre partenaire selon la morphologie et la tenue.

Dans « Configuration de l'avatar », « Activer la correction de l'avatar » corrige les différences d’angles initiaux des articulations et de torsion par rapport à l’avatar de référence. « Empêcher les genoux de se plier à l'envers » limite la flexion inversée des genoux. Ouvrez les réglages détaillés pour ajuster « Flexion minimale du genou (degrés) ». Vérifiez aussi avec l’aperçu l’apparence obtenue une fois les corrections activées.

La recherche par nom de pose, l’ajout de plusieurs animations et le changement d’ordre s’effectuent également dans « Poses ». Désactivez ou supprimez les poses inutiles.

L’aperçu simple n’exécute pas le build MA ou NDMF : vérifiez aussi l’état final, tenues et autres systèmes compris, après le build de l’avatar.

### Icônes des poses

Activez « Générer les icônes des poses » dans « Fonctions » pour ajouter des images des poses au menu du jeu. La génération des images allonge d’autant le temps de build. Pour limiter leur taille, activez « Réduire la taille des icônes ». Les icônes de poses ne sont pas générées pour Android.

### Préréglages

Les préréglages se choisissent tout en bas de « Configuration de l'avatar ». « Appliquer ce préréglage » remplace la configuration actuelle des poses : enregistrez vos ajustements avant de changer de préréglage.

Les fichiers d’animation d’ajustement créés avec la fonction d’ajustement de l’animation, ainsi que les préréglages qui les utilisent, peuvent être distribués et vendus sans autorisation individuelle de Unisaki Studio. Servez-vous-en, par exemple, pour partager des données d’ajustement destinées à vos propres avatars.

## Précalcul

« Actualiser le précalcul » enregistre les menus et les animations générés afin de les réutiliser lors du build de l’avatar et de l’accélérer. Sans précalcul, le build ordinaire génère lui-même les données nécessaires.

Après avoir modifié des poses ou des fonctions, consultez « Vérifier les réglages » dans l’Inspector et, si vous utilisez le précalcul, actualisez-le. Masquer un avertissement ne met pas à jour les données générées.

## À propos des cadeaux

Si vous ne l’utilisez pas vous-même, vous pouvez offrir l’une des deux éditions, Homme ou Femme, à votre partenaire. La personne qui la reçoit ne peut l’utiliser qu’avec la personne qui la lui a offerte.

## Précautions d’utilisation

- Ce produit a été créé dans un but humoristique. Veuillez ne pas l’utiliser à des fins de harcèlement.
- Respectez les conditions d’utilisation de VRChat et les règles de bonne conduite.
- Le verrouillage des poses pendant le suivi du corps entier n’est pas pris en charge.
- Des ajustements manuels peuvent être nécessaires selon la morphologie, la tenue et les modifications de l’avatar.
- Si vous l’utilisez avec d’autres systèmes modifiant la posture, vérifiez le fonctionnement des verrouillages et des changements de pose. « Configuration de l'avatar > Intégrer les verrouillages de suivi aux autres outils » permet parfois de les ajuster.
- Le créateur décline toute responsabilité pour tout préjudice résultant de l’utilisation de cet outil.

## Conditions d’utilisation

N’utilisez ce produit qu’après avoir accepté ses conditions d’utilisation, rédigées avec la licence VN3.

[Conditions d’utilisation de Virtual Love](https://drive.google.com/file/d/1Uu8y4z-G-P0btDCdY-ahQsTJInCNbxyD/view?usp=sharing)

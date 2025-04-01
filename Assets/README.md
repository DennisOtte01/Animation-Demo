## Als eerste moet je inloggen op mixamo (zie link hier onder). Als je nog geen account heb moet je er eerst een account aanmaken of inloggen met een google account/adobe account.

https://www.mixamo.com/

## Vind het model dat je wil gebruiken op mixamo (zie link hier onder) en download deze. 

https://www.mixamo.com/#/?page=1&type=Character 

![Maximo characters](../images/Maximo.png "Maximo characters")

## Als je een model download heb je de mogelijkheid om te kiezen wat voor formaat het model moet komen. **HET IS STERK AANGERADEN OM DAAR FBX FOR UNITY TE KIEZEN!!**

![Maximo Format download](../images/Format.png "Maximo Format download")

## Sleep Het gedowloade model in een unity folder en klik er op.

![Character](../images/character.png "Character")

## Ga naar Rig toe en verander de animation type naar "Humanoid" en verander de avatar Definition naar "Create from this model".

![rig character](../images/rig-character.png "rig character")

## Ga nu naar Animation en zet "Bake into Pose" aan op "Root Transform Position (Y)". Dit moet gedaan worden, omdat we de movement doen met rigidbody. **als je character begint met vliegen als je de scene runt dan ben je deze stap vergeten**
(Het kan ook als je character alsnog vliegt dat je dit per animatie moet doen, klik dan op edit op de animatie om op dezelfde plek te komen.)

![bake Y](../images/bakeY.png "bake Y")

## Ga nu naar Materials en zet "Location" op "Use External Materials (Legacy)"

![Material](../images/material.png "Material")

## klik op de animaties in de Animations folder.

![animatie](../images/animation.png "animatie")

## Ga opnieuw naar Rig en verander de animation type naar "Humanoid" en verander de avatar Definition naar "Copy From Other Avatar" **Let op "Copy From Other Avatar" is anders dan "Create from this model" als bij de character**.

![rig animatie](../images/rig-animation.png "rig animatie")

## Voeg bij "Source" de asset van je gedownloade character toe.

![Avatar source](../images/avatarsource.png "Avatar source")

## Maak een player gameobject met Het model van Maximo dat je zojuist gedownload hebt. Voeg een Rigidbody (Constrain de X en Z rotaties zodat het character niet kan omvallen), capsule collider (y offset 1, height 2), bestaande Player Input en de Player Movement script toe. 

![Rigid body en Capsule collider](../images/collider.png "Rigid body en Capsule collider")

## Maak een animation controller en sleep deze op het gameobject van het character.

![Player controller](../images/controller.png "Player controller")

## Vervolgens klik op de character ga naar het component animator en zet "Apply Root Motion" uit.

![Root Motion](../images/rootmotion.png "Root Motion")

## Ga terug naar mixamo (zie link hier onder) en importeer een Jump animatie. **LET OP FBX FOR UNITY EN WITHOUT SKIN**

https://www.mixamo.com/#/?page=1&query=jump&type=Motion%2CMotionPack

![Download Jump](../images/jump.png "Download Jump")

## Zet de jump animatie in de Animations folder en voer stappen 8, 9 en 10 uit met de Jump animatie die je zojuist gedownload hebt. 

## Voeg de idle en jump animaties toe aan de animation controller door deze te selecteren in de mixamo prefab (Selecteer specifiek de animation in de figuur hier onder) en te slepen naar de player instantie/gameobject, deze verschijnen nu in de animation controller.

![animatie](../images/animation.png "animatie")

## Ga nu naar de animation controller en open die. Links bovenin is een tabje "Parameters" te vinden. Ga daar naartoe en voeg een trigger parameter toe met de naam "Jump" **Let op als je hem niet exact "Jump" noemt gaat het fout**

![parameter](../images/parameter.png "parameter")

## Maak een transitie (rechter muisklik) tussen idle en jump met de conditie Jump als trigger (onder conditions klik op het plusje en dan Jump).

![transition](../images/transition.png "transition")

![trigger](../images/trigger.png "trigger")

## Nu gaan we de idle animatie in de controller vervangen met een blend tree. Rechtermuisklik op de idle animatie in de controller en klik op "Create new blendtree in state". 

![makeblendtree](../images/blendtree-makenew.png "makeblendtree")

## Dubbelklik de nieuwe blend tree om deze te openen en aan te passen.

![blendtree](../images/blendtree-example.png "blendtree")
## Zorg ervoor dat de blend type 2D Simple Directional is, maak twee parameters aan float X en float Y en selecteer deze in de blend tree. Nu kan je motion fields aanmaken met het '+' teken voor elke animatie, en deze in positie slepen zodat deze blended worden met de twee parameters die zijn meegegeven. 

Je kan in het plaatje zien dat alle motion fields hetzelfde heten door de import naam van mixamo, maar je kan erachter komen welke animatie waar staat door deze te selecteren in het motion field, Unity highlight dan de geselecteerde asset in de editor.
## Zet Foot IK aan op de blend tree node in de animator component.

![blendtreeIK](../images/blendtree-footik.png "blendtreeIK")
1. Als eerste moet je inloggen op maximo (zie link hier onder). Als je nog geen account heb moet je er eerst een account aanmaken of inloggen met een google account/adobe account.

https://www.mixamo.com/

2. Vind het model dat je wil gebruiken op maximo (zie link hier onder) en download deze. 
https://www.mixamo.com/#/?page=1&type=Character 

![Maximo characters](../images/Maximo.png "Maximo characters")

Als je een model download heb je de mogelijkheid om te kiezen wat voor formaat het model moet komen. **HET IS STERK AANGERADEN OM DAAR FBX FOR UNITY TE KIEZEN!!**
![Maximo Format download](../images/Format.png "Maximo Format download")

3. Sleep Het gedowloade model in een unity folder en klik er op.
![Character](../images/character.png "Character")

Ga naar Rig toe en verander de animation type naar "Humanoid" en verander de avatar Definition naar "Create from this model".
![rig character](../images/rig-character.png "rig character")

Ga nu naar Animation en zet "Bake into Pose" aan op "Root Transform Position (Y)". Dit moet gedaan worden, omdat we de movement doen met rigidbody. **als je character begint met vliegen als je de scene runt dan ben je deze stap vergeten** 
![bake Y](../images/bakeY.png "bake Y")

klik op de animaties in de Animations folder.
![animatie](../images/animation.png "animatie")

Ga opnieuw naar Rig en verander de animation type naar "Humanoid" en verander de avatar Definition naar "Copy From Other Avatar" **Let op Dit is niet exact hetzelfde als bij de character**.
![rig animatie](../images/rig-animation.png "rig animatie")

4. Maak een player gameobject met Het model van Maximo dat je zojuist gedownload hebt. Voeg een Rigidbody (Constrain de X en Z rotaties zodat het character niet kan omvallen), capsule collider (y offset 1, height 2), bestaande Player Input en de Player Movement script toe. 
![Rigid body en Capsule collider](../images/collider.png "Rigid body en Capsule collider")

5. Maak een animation controller en sleep deze op het gameobject van het character.
![Player controller](../images/controller.png "Player controller")

Vervolgens klik op de character ga naar het component animator en zet "Apply Root Motion" uit.
![Root Motion](../images/rootmotion.png "Root Motion")

6. Importeer een jump animatie (without skin). 
Selecteer Copy from Other model in het avatar gedeelte van de animation en selecteer de avatar van het model dat je geïmporteerd hebt. Selecteer Humanoid.

7. Voeg de idle en jump animaties toe door deze te selecteren in de mixamo prefab en te slepen naar de player instantie, deze verschijnen nu in de animation controller.

8. Maak een trigger parameter Jump, en maak een transitie tussen idle en jump met die conditie.

9. Nu gaan we de idle animatie in de controller vervangen met een blend tree. Maak een blend tree aan en voeg de 4 bestaande walk animaties en de idle animatie eraan toe. Voeg voor elke animatie een Motion Field toe en positioneer deze op de goede plek. In het midden voor Idle, en dan een walk animatie in elke richting.

10. Voeg het bestaande script toe aan de player instantie.

11. Zet Foot IK aan op de blend tree node in de animator component.

1. Als eerste moet je inloggen op maximo (zie link hier onder). Als je nog geen account heb moet je er eerst een account aanmaken of inloggen met een google account/adobe account.

https://www.mixamo.com/

2. Vind het model dat je wil gebruiken op maximo (zie link hier onder) en download deze. 

https://www.mixamo.com/#/?page=1&type=Character 

![Maximo characters](../images/Maximo.png "Maximo characters")

1. Als je een model download heb je de mogelijkheid om te kiezen wat voor formaat het model moet komen. **HET IS STERK AANGERADEN OM DAAR FBX FOR UNITY TE KIEZEN!!**

![Maximo Format download](../images/Format.png "Maximo Format download")

4. Sleep Het gedowloade model in een unity folder en klik er op.

![Character](../images/character.png "Character")

5. Ga naar Rig toe en verander de animation type naar "Humanoid" en verander de avatar Definition naar "Create from this model".

![rig character](../images/rig-character.png "rig character")

6. Ga nu naar Animation en zet "Bake into Pose" aan op "Root Transform Position (Y)". Dit moet gedaan worden, omdat we de movement doen met rigidbody. **als je character begint met vliegen als je de scene runt dan ben je deze stap vergeten**

![bake Y](../images/bakeY.png "bake Y")

7. Ga nu naar Materials en zet "Location" op "Use External Materials (Legacy)"

![Material](../images/material.png "Material")

8. klik op de animaties in de Animations folder.

![animatie](../images/animation.png "animatie")

9. Ga opnieuw naar Rig en verander de animation type naar "Humanoid" en verander de avatar Definition naar "Copy From Other Avatar" **Let op "Copy From Other Avatar" is anders dan "Create from this model" als bij de character**.

![rig animatie](../images/rig-animation.png "rig animatie")

10. Voeg bij "Source" de asset van je gedownloade character toe.

![Avatar source](../images/avatarsource.png "Avatar source")

11. Maak een player gameobject met Het model van Maximo dat je zojuist gedownload hebt. Voeg een Rigidbody (Constrain de X en Z rotaties zodat het character niet kan omvallen), capsule collider (y offset 1, height 2), bestaande Player Input en de Player Movement script toe. 

![Rigid body en Capsule collider](../images/collider.png "Rigid body en Capsule collider")

12. Maak een animation controller en sleep deze op het gameobject van het character.

![Player controller](../images/controller.png "Player controller")

13. Vervolgens klik op de character ga naar het component animator en zet "Apply Root Motion" uit.

![Root Motion](../images/rootmotion.png "Root Motion")

14. Ga terug naar maximo (zie link hier onder) en importeer een Jump animatie. **LET OP FBX FOR UNITY EN WITHOUT SKIN**

https://www.mixamo.com/#/?page=1&query=jump&type=Motion%2CMotionPack

![Download Jump](../images/jump.png "Download Jump")

15. Zet de jump animatie in de Animations folder en voer stappen 8, 9 en 10 uit met de Jump animatie die je zojuist gedownload hebt. 

16. Voeg de idle en jump animaties toe aan de animation controller door deze te selecteren in de mixamo prefab (Selecteer specifiek de animation in de figuur hier onder) en te slepen naar de player instantie/gameobject, deze verschijnen nu in de animation controller.

![animatie](../images/animation.png "animatie")

17. Ga nu naar de animation controller en open die. Links bovenin is een tabje "Parameters" te vinden. Ga daar naartoe en voeg een trigger parameter toe met de naam "Jump" **Let op als je hem niet exact "Jump" noemt gaat het fout**

![parameter](../images/parameter.png "parameter")

18. Maak een transitie (rechter muisklik) tussen idle en jump met de conditie Jump als trigger (onder conditions klik op het plusje en dan Jump).

![transition](../images/transition.png "transition")

![trigger](../images/trigger.png "trigger")

19. Nu gaan we de idle animatie in de controller vervangen met een blend tree. Maak een blend tree aan en voeg de 4 bestaande walk animaties en de idle animatie eraan toe. Voeg voor elke animatie een Motion Field toe en positioneer deze op de goede plek. In het midden voor Idle, en dan een walk animatie in elke richting.

20. Voeg het bestaande script toe aan de player instantie.

21. Zet Foot IK aan op de blend tree node in de animator component.

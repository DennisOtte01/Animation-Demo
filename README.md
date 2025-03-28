1. Repo pullen.

2. Mixamo inloggen.

3. Model vinden en downloaden. FBX for unity is de aangeraden format.

4. Kies "Create Avatar from this model" / "Select humanoid avatar type" in rig. "Bake into Pose Y" moet aan omdat we rigidbodies gaan gebruiken.

5. Maak een player gameobject met de karakter prefab. Voeg een Rigidbody, capsule collider (y offset 1, height 2), 
bestaande Player Input en de Player Movement script toe. Constrain de rigidbody zodat deze niet omvalt.

6. Maak een animation controller en zet deze in de root van de player instantie. Zet Apply Root Motion uit.

7. Importeer een jump animatie (without skin). 
Selecteer Copy from Other model in het avatar gedeelte van de animation en selecteer de avatar van het model dat je geïmporteerd hebt. Selecteer Humanoid.

8. Voeg de idle en jump animaties toe door deze te selecteren in de mixamo prefab en te slepen naar de player instantie, deze verschijnen nu in de animation controller.

9. Maak een trigger parameter Jump, en maak een transitie tussen idle en jump met die conditie.

10. Nu gaan we de idle animatie in de controller vervangen met een blend tree. Maak een blend tree aan en voeg de 4 bestaande walk animaties en de idle animatie eraan toe. Voeg voor elke animatie een Motion Field toe en positioneer deze op de goede plek. In het midden voor Idle, en dan een walk animatie in elke richting.

11. Voeg het bestaande script toe aan de player instantie.

12. Zet Foot IK aan op de blend tree node in de animator component.

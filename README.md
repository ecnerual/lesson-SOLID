# lesson-SOLID

Voici ma présentation de la semaine!

Sur les meilleurs principes de programmations disponibles ou le S.O.L.I.D

Commençons par regarder une class qui va nous aider à creer des boardgames!

(explique ce que la classe fait eazypz, montre toute les fonctionnaliteés)

Donc voici le code d'une personne qui ne suit pas les meilleurs principes disponibles! Ces principes à sont juste disponibles!

Sinon, commençons par le S du SOLID!

#Single responsability principle!

En fait, c'est c'est le fait qu'une lib/module ou class devrait avoir le pouvoir (responsabilité) sur une seul feature
On pourrait dire que la classe aurait simplement une raison d'etre modifier!

Donc est-ce que notre class ici, respecte ca?
(demander de pointer une affaire rip)


##Le 2eme principe c'est le open/closed principle 

Vous allez vite voir que les 2 s'aiment bien ! Je penses qu'en general un va avec l'autre!

Mais c'est quoi au juste m8? 

ben c'est qu'une class, function, module, struct .. soit FERMER a la modification et OUVERT a l'extension!!

C'est pas facile, a imaginer comme ca? je vais essayer de l'expliquer 

la facon OG de la chose c'était d'extend les class pour leurs ajouters pleins de features, mais depuis le temps,
les gens ont comprit que c'est les Interface qui sont cool et brancher ! (ca aide vraiment a respecter les 2 principaux principes)

(Loose Coupling vs Tight coupling) faire un exemple avec le logger mal fait pi avec un Interface


Maintenant on va resoudre le class qu'on a regarde!

(faire une analogie avec un jeux monopoly, comment tu ferais pour sauvegarder?(genre prendre une photo avec ton cell)
Pi pour prendre des notes je penses que tu vas prendre des feuilles a part pi un crayon pi toute right?)


 ben c'est un peu ca la prog aussi! Ton monopoly ben y sert juste a jouer!

Par contre, veux-tu avoir VRAIMENT BESOIN D'un iphone 8 + ? ou juste quelque chose qui prend une photo?(implementation vs interface)



##LISKOV SUBSTITUTION PRINCIPLE

The principle defines that objects of a superclass shall be replaceable with objects of its subclasses without breaking the application

En theorie, si ta des papa qui sont heureux dans une app! Ben si tu decide que papa va faire des enfants , ben les enfants ne doivent pas mettre la marde!


##Interface segregation principle

The interface-segregation principle (ISP) states that no client should be forced to depend on methods it does not use.[1] 
ISP splits interfaces that are very large into smaller and more specific ones so that clients will only have to know about the methods that are 
of interest to them

##Dependency inversion principle

High-level modules should not depend on low-level modules. Both should depend on abstractions.


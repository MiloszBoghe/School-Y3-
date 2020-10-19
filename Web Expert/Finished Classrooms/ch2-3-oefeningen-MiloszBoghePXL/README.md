## **Oefeningen: Components**
### Oefening 1
Maak zelf een nieuw project in de root directory van deze repository met als naam “chapter3-oefening1” via de Angular CLI. Voorzie volgende componenten:

1. Maak een logoComponent. Voorzie een div en zorg ervoor dat de width overeenkomt met de schermbreedte en dat de hoogte overeenkomt met 140px. Zorg ervoor dat in deze component een logo naar keuze getoond wordt met een groene achtergrond. **De HTML en CSS staat in de file logo.component.ts**
2. Maak een nieuwsbriefComponent aan. Hierin heb je één input veld met label en een submit knop. Het label krijgt de waarde “Schijf je in voor onze nieuwsbrief...”. Er hoeft geen verwerking te zitten achter de knop / input velden. **De HTML en CSS steek je in aparte bestanden.**
3. Wijzig de HTML code van je **app.component.html **file naar onderstaande. Pas de selectors van de components aan zodat beide components gerendered worden zoals in onderstaand voorbeeld:

```
<app-logo></app-logo>
<app-nieuwsbrief></app-nieuwsbrief>
```

![foto opdracht](https://i.imgur.com/igzrXCC.png "image_tooltip")


4. Extra: Probeer gebruik te maken van one way en two way binding en een event om de ingave bij de nieuwsbrief te koppelen aan een property “email” bij het klikken op de knop. Vervolgens voorzie je een paragraaf waarin de ingave getoond wordt in de nieuwsbriefComponent

Controleer na het maken van deze oefening of je alle wijzigingen naar github hebt gepusht.

### Oefening 2
Ga naar de map CH3-oefening-debug. Vervolgens run je onderstaand commando in deze map op alle dependencies te installeren:

```
npm install
```

In dit project zitten verschillende fouten. Probeer aan de hand van de error messages in je IDE & developer console de fouten weg te werken zodat je een werkende applicatie krijgt.

Controleer na het maken van deze oefening of je alle wijzigingen naar github hebt gepusht.

### Oefening 3
Beantwoord onderstaande vragen door de antwoorden toe te voegen in de readme.md file:

1. Zoek binnen je IDE naar extensies waarbij je automatische code generation kan uitvoeren voor het maken van components. Dit kan je in de loop van de course, oefeningen en examen redelijk wat tijd besparen! Welke extenties heb je gekozen en hoe gebruik je deze?
Emmet voor html tab autofill, bv: "h1.titel>div*2" en dan op tab duwen genereert een h1 element met daarin 2 divs.
2. Zoek uit hoe je via de angularCLI components kan genereren. Hoe doe je dit? Wat zijn de verschillen met het handmatig aanmaken van components?
ng generate component (name), voegt automatisch ook deze component toe aan de module etc.
Controleer na het maken van deze oefening of je alle wijzigingen naar github hebt gepusht.

### Extra

Klaar met de oefeningen? Ga naar [https://angular.io/guide/quickstart](https://angular.io/guide/quickstart) en doorloop de quickstart guide van Angular zelf. Deze guide gaat verder dan de leerstof gezien in deze lesweek.

Voor de studenten die gebruik maken van Angular in het IT-project is dit sowieso aangeraden! De quickstart geeft een globaal beeld van de verschillende hoofdstukken die we doorheen web expert zullen doorlopen.

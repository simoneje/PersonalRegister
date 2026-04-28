--------------------UPPGIFT-------------------------
Ett litet företag i restaurangbranschen kontaktar dig för att utveckla ett litet
personalregister. De har endast två krav:
1.
Registret skall kunna ta emot och lagra anställda med namn och lön. (via inmatning
i konsolen, inget krav på persistent lagring)
1.
Programmet skall kunna skriva ut registret i en konsol.
Uppgift 1
Vilka klasser bör ingå i programmet?
Uppgift 2
Vilka attribut och metoder bör ingå i dessa klasser?

--------------------SVAR-------------------------
Uppgift 1
- Jag försöker tänka med ett framtidssäkert tänk när jag bygger upp klasserna. Det kan leda till att jag lägger till fler tankar här i efterhand när jag börjar göra programmet. 
Jag ska göra en klass för varje individuell personal.
Sen en klass för hela registret. Registret blir en dictionary som håller hela personalen baserat på ID.
	

Uppgift 2
- PersonKlass:
	- Namn
	- Anställningsdatum
	- Lön
- PersonalRegister
	- Dictionary av Personklasser, Key = ID, Value = PersonKlass

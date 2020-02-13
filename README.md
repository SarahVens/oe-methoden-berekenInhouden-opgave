oe-methoden-berekenInhouden-start
# Doelstelling: inhouden berekenen
## Naamgeving
Geef alle controls een naam waar nodig. Respecteer hierbij de afspraken ivm naamgeving.
## Bij het opstarten
Verberg via een methode de twee turqoise grids. 

De linkse dient voor de berekening van de inhoud van een balk (balkgrid), de rechtse voor een cilinder (cilindergrid).
## Klik op btnBalk
Via de methode ToonGrid worden balkgrid en de grid met het tekstvak voor de hoogte (hoogtegrid) getoond.
Via de parameter kun je aangeven welke grid je wil tonen naast de hoogtegrid.
De marges van de te tonen grid worden aangepast, zodat die dezelfde zijn als balkgrid.
Ga hiervoor de beginmarges van deze grid na en pas die toe op de te tonen grid.
Via de methode WisInputEnBerekeningen worden de input en de feedback van een vorige berekening gewist.
## Klik op de button Cilinder
ToonGrid en WisInputEnBerekeningen worden uitgevoerd.
## Klik op de button Bereken voor een balk
De input van de gebruiker wordt opgeslagen in variabelen.
Via de methode GeefInhoudBalk wordt op basis van de doorgegeven parameters een integer geretourneerd met de inhoud van de balk.
De berekening wordt getoond in tbkBerekeningBalk.
## Klik op de button Bereken voor een cilinder
De input van de gebruiker wordt opgeslagen in variabelen.
Via de methode GeefInhoudCilinder wordt op basis van de doorgegeven parameters een float geretourneerd met de inhoud van de cilinder.
De berekening wordt getoond in tbkBerekeningCilinder.

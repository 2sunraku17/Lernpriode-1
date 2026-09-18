# Lern-Periode 1

28.8 bis ?

## Grob-Planung

1. Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?
2. Was wäre ein geeignetes Projekt für diese LP1?
   Ich muss eine random zahl erraten die mir der computer ausspuckt und mir hilft sie zu erraten mit wärmer oder kälter

## 28.8.2026

✍️ Heute habe ich zwei verschiedene Programme geschrieben. Das erste Programm ist ein Zahlen erratungs-Spiel. Das Programm funktioniert indem es eine random Zahl auswählt von 1 bis 101 und nach jedem guess von mir eine Antwort gibt, ob ich höher oder tiefer gehen soll. Das zweite Programm ist ein Noten Rechner der mit meinen angegebenen punkten eine Note ausrechnet indem er die Formel ----> erreichte punkte / maxpunkte * 5 + 1 verwendet.

## 4.9.2026

- [ ] Ich will ein randomizer der von 5 verschiedenen Fragen (die ich ins Programm getan habe) eine Frage auswählt und sie `Console.WriteLine` sichtbarmacht
- [x] Ich will machen das ich diese Frage mit "bool" true und false beantworten kann
- [x] Ich will machen dass wenn ich Enter drücke die nächste Random Frage kommt und sie dann auch beantworten Kann. Am Schluss kommt meine Punkte Bewertung also z.B 5/5

✍️ Heute habe ich ein Fragenprogramm geschrieben der mir 4 Fragen stellt davon eine als Bonusfrage. Mit der Bonusfrage kann man die Note 6+ erreichen. Am Schluss wird eine Punktzahl gezeigt und ein lobender Kommentar wenn man die Note 6+ erreicht.

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## 11.9.2026

- [ ] Ich will ein randomizer der von 5 verschiedenen Fragen (die ich ins Programm getan habe) eine Frage auswählt und sie `Console.WriteLine` sichtbarmacht
- [x] Eingabe wie viele Fragen man gestellt werden will.
- [x] Bonusfrage mit mehreren möglichkeiten
- [x] Note und Punktzahl am schluss angeben

Heute habe ich an meinem Quiz gearbeitet. Die Eingabe der Fragen, die Bonusfrage sowie die Punktzahl und Note funktionieren. Der Randomizer ist mir leider noch nicht gelungen. Insgesamt bin ich mit meinem Fortschritt zufrieden.

# HA auf 18.9.2026
- [x] Eingabeprüfung im Quiz
Ich habe mein Quiz verbessert, indem ich ungültige Eingaben erkenne und den Benutzer erneut nach einer gültigen Zahl frage.

## 18.9.2026

- [ ] Den Randomizer zum Funktionieren bringen.
- [ ] Die Fragen verbessern und erweitern.
- [ ] Das Design und die Texte im Quiz verbessern.

## fertiges Projekt
## Zusammenfassung vom ganzen Guiz-Code


Das Programm ist ein True-or-False-Quiz. Zuerst wird ein Titel angezeigt und die Punktzahl auf 0 gesetzt. Danach kann der Benutzer auswählen, wie viele von den 5 Fragen gestellt werden sollen.

Mit while wird kontrolliert, ob die eingegebene Anzahl zwischen 1 und 5 liegt. Danach werden die Fragen nacheinander gestellt. Der Benutzer gibt true oder false ein. Mit if wird überprüft, ob die Antwort richtig ist. Bei einer richtigen Antwort wird mit punkte++ ein Punkt dazugezählt.

Nachdem die normalen Fragen beantwortet wurden, kommt die Bonusfrage. Dabei kann der Benutzer zwischen vier Antworten wählen. Auch hier wird mit while überprüft, ob eine gültige Zahl von 1 bis 4 eingegeben wurde. Die richtige Antwort ist 2, also Venus. Bei einer richtigen Antwort gibt es einen zusätzlichen Punkt.

Zum Schluss wird die maximale Punktzahl berechnet. Danach berechnet das Programm anhand der erreichten Punkte die Note und zeigt sowohl die Punktzahl als auch die Note an. Am Ende wird Console.Read() verwendet, damit das Konsolenfenster geöffnet bleibt und sich nicht sofort schließt. So kann man die angezeigte Punktzahl und Note noch sehen, bevor das Programm beendet wird.

# egs-Excercises

Dies ist eine Sammlung von Übungen in C# mit WinForms

* Alle Anwendungen sollen als Windows Forms in C# geschrieben werden
* Die Übungen sollen alle innerhalb einer Projektmappe in jeweils eigenen Projekten in Visual 
Studio angelegt und sinnvoll benannt werden
* Fehleingaben sollen abgefangen werden
* Exceptionhandling: Für unbehandelte Fehler soll eine Meldung in einem PopUp an den Nutzer 
ausgegeben werden, dass dieser sich an den Administrator wenden soll. Die jeweilige Exception 
soll darunter angezeigt werden

-----

## Übung 1 : Taschenrechner

* Der Taschenrechner soll drei Eingabefelder und einen Button beinhalten
    * In das erste Eingabefeld soll eine Zahl eingetragen werden können
    * Das zweite Eingabefeld ist ein DropDown, welches die Grundrechenarten (+,-,\*,/) beinhaltet
    * In das dritte Eingabefeld soll die zweite Zahl eingetragen werden können
* Beim Klick auf den Button soll die Berechnung angestoßen und in einem Label angezeigt werden

-> Lösung siehe unter [Calculator](./Calculator/)

## Übung 2 : Primzahlbestimmung

* Es soll eine Anwendung gebaut werden, die Primzahlen bestimmt
* Die Anwendung soll zwei Eingabefelder und einen Button besitzen
    * Das erste Eingabefeld gibt den Start an, ab welcher Zahl auf Primzahlen geprüft werden soll
    * Das zweite Eingabefeld gibt an, bis zu welcher Zahl die Primzahlen geprüft werden sollen
* Die Primzahlen sollen in einem DataGrid sinnvoll aufgelistet werden
* Die Primzahlberechnung soll möglichst performant stattfinden

-> Lösung siehe unter [PrimesInRange](./PrimesInRange/)

## Übung 3 : Primzahldifferenzbestimmung

* Es soll eine Anwendung gebaut werden, die die Differenzen zwischen aufeinander folgenden Primzahlen bestimmt
* Die Differenzen sollen nach Anzahl absteigend sortiert in einem DataGrid angezeigt werden
    * Es soll eine Spalte „Differenz“ und eine Spalte „Anzahl“ enthalten sein
    * Die „Anzahl“ beinhaltet dabei die Anzahl der Vorkommnisse der Differenz
* Die Eingaben erfolgen wie bei Übung 2

-> Lösung siehe unter [PrimeDistances](./PrimeDistances/)

## Übung 4: Schachbrett

* Es soll eine Anwendung gebaut werden, die ein Schachtbrett simuliert und darstellt
* Ein Springer (Pferd) soll nun unten links starten und jedes Feld des Schachbretts bespringen
* Der Springer darf jedes Feld nur einmal betreten (Nicht zweimal, dreimal, …)
    * Die Logik dessen ist in der Anwendung abzubilden
* Tipps: Rekursion ist nötig und ein Algorithmus ist empfehlenswert



1. Aufgetretene Probleme:

Problem bei der Sort()-Methode, da die DataObjekt der Node keine CompareTo() Methode anbieten.
Lösungs: Hinzufügen eines Constraints zur MyList<T> where T : IComparable, damit die DataObjects der Nodes vergleichbar werden.
 
 Problem bei der Sort()-Methode, bei welcher anfangs nicht die Liste selbst, also die Nodes vertauscht wurden, sondern nur die Referenzen der Laufvariabel. Dadurch änderte sich and er eigentlichen Liste nichts.
 Lösung: tmp Variabel dient nurnoch als "Zeiger", werden zwei Nodes gefunden die vertauscht werden sollen, geschieht das nun über ein Remove(index) und ein InsertAt(value, index).
 
 Problem bei den Tests, da nun alle Nodes auf einen Datentypen umgeschrieben werden mussten. Node -> Node<int>
 
 
2. Vorteile von Generics:

Es fallen viele Probleme weg, wei Boxing. Generics sind typsicher. Durch die Constraints kann man gewissen Methoden aufrufen bzw. mit dem Datentyp T so umgehen, wie man es später im Anwenderfall braucht.

3. Vorteile von GitHub:

Ermöglicht einfaches Speicher und Abrufen von Solutions. Kein Bedarf mehr für Speicherung der Daten auf dem lokalen PC. Erleichtert Projekte mit mehreren Personen, da alle stehts mit den selben Daten arbeiten können.

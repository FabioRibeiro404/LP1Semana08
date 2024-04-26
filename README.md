### Flowchart

```mermaid
 classDiagram
Animal <-- Program

Animal <|-- Bat
Animal <|-- Bee
Animal <|-- Cat
Animal <|-- Dog

IMammal <|.. Bat
IMammal <|.. Cat
IMammal <|.. Dog

ICanFly <|.. Bat
ICanFly <|.. Bee

class Animal{
<<abstract>>
}

class IMammal{
<<interface>>
}
class ICanFly{
<<interface>>
}

```
Fábio Ribeiro a22102432

# C# Basics (Junior Backend)

## 1. Podstawy języka C#
- **Składnia i typy**: `int`, `string`, `bool`, `decimal`, `DateTime`, `Guid` to podstawowe typy wykorzystywane w backendzie (np. id, daty, kwoty).
- **Zmienne i stałe**: `const` dla wartości stałych w czasie kompilacji, `readonly` dla wartości ustawianych w konstruktorze.
- **Operatory**: arytmetyczne, logiczne, porównania — kluczowe przy walidacji i logice biznesowej.
- **Instrukcje warunkowe i pętle**: `if`, `switch`, `for`, `foreach`, `while` — podstawy sterowania przepływem.
- **Metody i parametry**: `ref`, `out`, `in` — przekazywanie przez referencję (często w API/algorytmach).
- **Namespace**: porządkuje kod i zapobiega konfliktom nazw.
- **Właściwości**: `get/set/init` — najczęściej mapowanie encji/DTO.
- **Konstruktory**: inicjalizacja obiektów.
- **using/IDisposable**: poprawne zwalnianie zasobów (np. strumienie, połączenia).

## 2. Programowanie obiektowe (OOP)
- **Klasa i obiekt**: podstawowy model danych i zachowania.
- **Enkapsulacja**: ukrywanie szczegółów implementacji.
- **Abstrakcja**: eksponowanie tylko tego, co potrzebne.
- **Dziedziczenie** i **polimorfizm**: rozszerzanie i podmiana zachowań.
- Słowa kluczowe: `virtual`, `override`, `abstract`, `sealed`, `base`, `this`.

## 3. Typy i pamięć
- **Value vs Reference types**: `struct` przechowywany na stosie, `class` na stercie.
- **record / record struct**: modele niemutowalne i wygodne porównania.
- **Nullable**: `int?`, `string?` — poprawne modelowanie danych z bazy/API.
- **Boxing/Unboxing**, **Stack vs Heap**, **GC** (generacje 0/1/2).

## 4. Klasy, interfejsy i struktury
- `class`, `struct`, `interface`, `abstract class`, `static class`, `partial class`, **nested classes**.
- Implementacja wielu interfejsów — częsty wzorzec w DI.

## 5. Modyfikatory dostępu
- `public`, `private`, `protected`, `internal`, `protected internal`, `private protected`.

## 6. Kolekcje i struktury danych
- `Array`, `List<T>`, `Dictionary<TKey, TValue>`, `HashSet<T>`, `Queue<T>`, `Stack<T>`, `LinkedList<T>`.

## 7. Generyki
- `T` i **ograniczenia**: `where T : class, new()`.

## 8. Delegaty i wyrażenia lambda
- `delegate`, `Action`, `Func`, `Predicate`, lambda — często w LINQ i eventach.

# Architecture

Aplikacja korzysta z uproszczonego podejścia inspirowanego Clean Architecture w ramach jednego projektu.

## Warstwy

- **Domain**
  - Encje i modele domenowe (`Vehicle`, `Car`).
- **Application**
  - Logika biznesowa (`CarService`) i usługi wspólne (`AppStateService`, `EducationalSandboxService`).
- **Infrastructure**
  - Dostęp do danych i implementacja repozytorium (`ICarRepository`, `CarRepository`).
- **Data**
  - `AppDbContext` i konfiguracja EF Core.
- **DTOs**
  - Modele transferowe (`CarDto`, `UpsertCarDto`).
- **Features**
  - Moduły edukacyjne Blazor (OOP, GC, LINQ, async/await, DI).
- **UI**
  - Strony i komponenty interfejsu (`Home`, `Cars`, `Learn`, `LogPanel`).

## Przepływ danych

1. UI wywołuje `ICarService`.
2. `CarService` mapuje DTO ↔ encje i deleguje operacje do `ICarRepository`.
3. `CarRepository` używa `AppDbContext` (EF Core) do operacji na SQLite.
4. Wynik wraca do UI jako DTO.

## Dlaczego takie podejście

- czytelny podział odpowiedzialności,
- łatwiejsze testowanie logiki,
- gotowość do rozwoju (np. wydzielenie osobnych projektów warstw w przyszłości).

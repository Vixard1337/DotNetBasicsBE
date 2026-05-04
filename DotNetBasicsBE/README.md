# DotNetBasics

DotNetBasics to edukacyjna aplikacja Blazor Web App (.NET 10), która pokazuje praktyczne zagadnienia C# i .NET backend.

## Cel projektu

Projekt został przygotowany jako portfolio do rozmowy rekrutacyjnej na stanowisko Junior .NET Developer / Stażysta.

## Technologie

- .NET 10
- Blazor Web App (Interactive Server + WebAssembly)
- Minimal API
- Entity Framework Core
- SQLite

## Jak uruchomić

1. Otwórz solution w Visual Studio.
2. Ustaw projekt `DotNetBasicsBE` jako Startup Project.
3. Uruchom aplikację (`F5`).
4. Baza SQLite tworzy się automatycznie przy starcie (`dotnetbasics.db`).

## Główne funkcjonalności

- CRUD dla encji Car (`/cars`)
- Minimal API (`/cars`, `/cars/{id}`)
- Interaktywne moduły edukacyjne (`/learn`):
  - OOP
  - Garbage Collector
  - LINQ
  - async/await
  - Dependency Injection
- Zmiana języka (PL/EN)
- Zmiana motywu (light/dark)
- Panel logów działania aplikacji

## Etapy projektu

1. Struktura projektu (inspirowana Clean Architecture) i encja `Car`.
2. EF Core + SQLite + repozytorium + Minimal API CRUD.
3. UI Blazor dla zarządzania samochodami (`/cars`).
4. Moduły edukacyjne (`/learn`).
5. Funkcje dodatkowe: język, motyw, logi.
6. Testy i refaktoryzacja (planowany kolejny etap).

## Architektura i wzorce

- **Podział warstw (Clean Architecture w jednym projekcie):**
  - `Domain` — encje (`Vehicle`, `Car`).
  - `Application` — logika biznesowa i serwisy.
  - `Infrastructure` — repozytoria i dostęp do danych.
  - `Data` — `AppDbContext` i konfiguracja EF Core.
  - `DTOs` — modele transferowe.
  - `Features` — moduły edukacyjne.
  - `UI` — komponenty Blazor.
- **Repository Pattern** (`ICarRepository`, `CarRepository`).
- **Service Layer** (`ICarService`, `CarService`).
- **Dependency Injection** (rejestracja w `Program.cs`).
- **Minimal API** dla endpointów `/cars`.

Szczegóły warstw i przepływu danych: `ARCHITECTURE.md`.

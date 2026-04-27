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

# Data, SQL i Entity Framework Core

## 9. LINQ
- Operacje: `Where`, `Select`, `OrderBy`, `ThenBy`, `GroupBy`, `Join`, `Any`, `All`, `Count`, `FirstOrDefault`, `SingleOrDefault`, `Distinct`, `Skip`, `Take`.
- `IEnumerable<T>` (in-memory) vs `IQueryable<T>` (zapytania do bazy).

## 10. Obsługa wyjątków
- `try/catch/finally`, `throw`, własne wyjątki — logika błędów w usługach i API.

## 11. Asynchroniczność i wielowątkowość
- `Task`, `Task<T>`, `async/await`, `CancellationToken`.
- Różnica: async ≠ multithreading. `Parallel.ForEach` — podstawy.

## 12. SQL (podstawy)
- `SELECT`, `WHERE`, `ORDER BY`, `JOIN`, `GROUP BY`, `HAVING`.
- `INSERT`, `UPDATE`, `DELETE`.
- Indeksy, transakcje, widoki, procedury składowane (podstawy).

## 13. Modelowanie relacji
- `Primary Key`, `Foreign Key`.
- Relacje: 1:1, 1:N, N:N.
- Normalizacja.

## 14. SQL vs NoSQL
- Różnice między bazami relacyjnymi i dokumentowymi.
- Typowe scenariusze użycia.

## 15. Entity Framework Core
- `DbContext`, `DbSet<T>`, encje.
- Konfiguracja modeli: Fluent API i Data Annotations.
- Migracje, `Include`, `AsNoTracking`.
- `SaveChangesAsync`, `ToListAsync`.

## 16. DTO i mapowanie
- DTO vs encja.
- Podstawy AutoMapper (mapowanie obiektów).

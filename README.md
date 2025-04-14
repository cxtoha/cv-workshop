# CV-Workshop

## Oppsett av Supabase

### 1. Registrering

1. Gå til [supabase.com](https://supabase.com) og klikk på **Start your project**.
2. Hvis du ikke har en bruker, klikk på **Sign up now** og registrer deg med din private e-postadresse.
3. Opprett en ny organisasjon med følgende valg:

   - **Name:** `<ditt navn>`'s Org
   - **Type:** Personal
   - **Plan:** Free

4. Opprett et prosjekt med følgende valg:

   - **Organization:** Velg organisasjonen du nettopp laget
   - **Project name:** `MinCV`
   - **Database Password:** Velg et sterkt passord
     > ⚠️ Merk: Passordet kan være synlig for de du deler koden med
   - **Region:** Central EU (Frankfurt)

5. Klikk **Create new project**.

---

### 2. Opprett tabell i databasen

Når prosjektet er opprettet:

1. Gå til **SQL Editor** i menyen til venstre.
2. Lim inn og kjør følgende SQL-script:

   ```sql
   create extension if not exists "uuid-ossp";

   create table public.cv_entries (
     id uuid primary key default uuid_generate_v4(),
     start_date date not null,
     end_date date,
     title text not null,
     description text
   );

   insert into public.cv_entries (start_date, end_date, title, description) values
     ('2020-01-01', '2021-06-01', 'Software Developer', 'Worked on backend systems using C# and .NET.'),
     ('2018-09-01', '2019-12-01', 'IT Consultant', 'Helped clients automate processes using web apps.'),
     ('2017-06-01', '2018-08-01', 'Intern', 'Assisted in testing and documentation at a tech startup.'),
     ('2021-07-01', '2023-01-01', 'Fullstack Developer', 'Built fullstack apps with React and .NET Core.'),
     ('2023-02-01', null, 'Senior Developer', 'Currently leading a team developing a SaaS product.');
   ```

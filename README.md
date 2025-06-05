# CV-Workshop

## Før du begyner

1. Last ned .net 9.0 SDK fra [hjemmesiden](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)2
2. Last ned npm fra [hjemmesiden](https://nodejs.org/en/download/)

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
   - **Region:** North EU (Stockholm 🇸🇪)

5. Klikk **Create new project**.

---

### 2. Opprett tabell i databasen

Når prosjektet er opprettet:

1. Gå til **SQL Editor** i menyen til venstre.

   <img width="198" alt="image" src="https://github.com/user-attachments/assets/f142de17-f862-4e47-bdad-7229ffbe1804" />

2. Lim inn og kjør følgende SQL-script:

```sql
create extension if not exists "uuid-ossp";

create table public.user (
  id uuid primary key default uuid_generate_v4(),
  name text not null,
  birth_date date not null,
  address text not null,
  phone text not null,
  linkedin_url text,
  description text not null,
  university text not null,
  skills text not null,
  image_url text
);

create table public.experience (
  id uuid primary key default uuid_generate_v4(),
  user_id uuid not null references public.user(id) on delete cascade,
  title text not null,
  role text not null,
  start_date date not null,
  end_date date,
  description text not null,
  image_url text
);

insert into public.user (id, name, birth_date, address, phone, linkedin_url, description, university, skills, image_url) values
('11111111-1111-1111-1111-111111111111', 'Alice Johnson', '1990-06-15', '123 Maple Street, Springfield', '+1-555-123-4567', 'https://linkedin.com/in/alicejohnson', 'Experienced web developer.', 'Stanford University', 'JavaScript;React;CSS;HTML', 'https://example.com/alice.jpg'),
('22222222-2222-2222-2222-222222222222', 'Bob Smith', '1985-09-22', '456 Elm Street, Gotham', '+1-555-987-6543', 'https://linkedin.com/in/bobsmith', 'Data scientist specializing in analytics.', 'MIT', 'Python;TensorFlow;SQL;Pandas', 'https://example.com/bob.jpg');

insert into public.experience (user_id, title, role, start_date, end_date, description, image_url) values
('11111111-1111-1111-1111-111111111111', 'Frontend Developer at XYZ Corp', 'Developer', '2015-01-01', '2018-12-31', 'Developed interactive web applications using React.', 'https://example.com/xyzcorp.jpg'),
('11111111-1111-1111-1111-111111111111', 'Senior Developer at ABC Inc', 'Senior Developer', '2019-01-01', null, 'Leading frontend team and architecting solutions.', 'https://example.com/abcinc.jpg'),
('22222222-2222-2222-2222-222222222222', 'Data Analyst at DataTech', 'Analyst', '2013-05-01', '2016-08-31', 'Analyzed large datasets to drive business decisions.', 'https://example.com/datatech.jpg'),
('22222222-2222-2222-2222-222222222222', 'Machine Learning Engineer at AI Solutions', 'ML Engineer', '2016-09-01', null, 'Built and deployed machine learning models.', 'https://example.com/aisolutions.jpg');
```

Forhåpentligvis fikk du opp følgende "Success. No rows affected". Du kan deretter navigere deg til Table Editor og se at tabellen dukker opp med navnet "cv_entries".

   <img width="209" alt="image" src="https://github.com/user-attachments/assets/0429a191-6ad5-4c86-97b1-e8c84f3bfdb0" />

## Oppsett av Backend

Se [README.md](https://github.com/cxberk/cv-workshop/blob/main/backend/README.md) filen i /backend

## Oppsett av Frontend

Se [README.md](https://github.com/cxberk/cv-workshop/blob/main/frontend/README.md) filen i /frontend

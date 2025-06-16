# Sett opp frontend

1. Lag en kopi av **.env.example**-filen, og gi den navnet `.env`
1. Fyll inn følgende verdier\_
   1. **BACKEND_API_URL:** = http://localhost:5007 (Sjekk at dette er samme som Backenden din kjører på)
   2. **BACKEND_API_KEY:** = <api-nøkkelen du genererte i backenden>
1. Kjør `npm install`
1. Kjør `npm run dev`

# Vise og filtrere erfaringer

## Oppgave 1 - Routing: Legg til "Erfaringer" som en route

Vi skal nå lage en ny side som viser alle erfaringene du har i databasen din. Vi må kunne navigere til denne siden, noe vi gjør med å lage en ny route ved siden av "Om meg" som linker til den nye siden vår.

1. Legg til en ny route i `App.tsx` for Erfaringer med `path="/experiences"`

<details>
<summary>Vis løsning</summary>

Vi bruker Route-komponenten fra react-router-dom for å definere hvilke komponenter som vises på ulike URL-er. Alt pakkes inn i en BrowserRouter, som gjør at React kan håndtere navigasjon uten å laste siden på nytt.

path="/" viser forsiden. path="\*" fanger opp alle ukjente ruter – nyttig for å vise en 404-side.

```tsx
// TODO Oppgave 1.2: Legg til en ny route i App.tsx for Erfaringer
<Route path="/experiences" element={<Experiences />} />
```

</details>

2. Legg til Erfaringer i `MainHeader.tsx` som en ny tab

<details>
<summary>Vis løsning</summary>
Her bruker vi `NavLink`-komponenten fra react-router-dom for å lage en lenke til Erfaringer. NavLink fungerer som en Link-komponent, men legger til en aktive state når gjeldende URL samsvarer med lenken. Dette kan man bruke til å style lenken til siden som er aktiv.

```tsx
// TODO Oppgave 1: Legg til Erfaringer som en tab
<NavLink
  to="/experiences"
  className={({ isActive }) => (isActive ? "cx-tab cx-tab--active" : "cx-tab")}
>
  Erfaring
</NavLink>
```

</details>

## Oppgave 2 - Intro til tanstack query: Hente alle erfaringene fra backend

Litt info om tanstack query: https://tanstack.com/query

Nå brukes hooken fra `useExperiences.ts` for å hente alle erfaringene i `Experiences.tsx`. Tanstack hånterer også mange innebyde states, som loading mens data hentes og error hvis det går feil. Vi skal håndtere disse i vår frontend.

1. Hent `isLoading` fra `useExperiences` hooken og vis en loading-melding når siden loader. Passende styling finnes i experiences.module.css, for eksempel `styles.loading`.

2. Gjør det samme med error. Hvis `error` er true, vis en error-melding. Passende styling finnes i experiences.module.css, for eksempel `styles.error`.

<details>
<summary>Vis løsning</summary>

```tsx
// TODO Oppgave 1.1 of 1.2: Håndter loading og error av erfaringer
const { data: experiences, isLoading, error } = useExperiences();

if (isLoading) {
  return <div className={styles.loading}>Loading experiences...</div>;
}

if (error) {
  return (
    <div className={styles.error}>
      Failed to load experiences. Please try again later.
    </div>
  );
}
```

</details>

## Oppgave 3 - Vis alle erfaringene i erfaring siden

1. Vis alle erfaringene i `Experiences.tsx` ved å mappe gjennom experiences og rendre et ExperienceCard for hver experience.

<details>
<summary>Vis løsning</summary>
I denne oppgaven bruker vi `map()` for å loope gjennom experiences og rendre et `ExperienceCard` per element.

> **Visste du dette?**  
> Vi bruker `map()` i stedet for `forEach()` fordi `map()` returnerer en ny array som vi kan bruke til å rendre JSX-komponenter. `forEach()` utfører en handling for hvert element, men returnerer ingenting.

```tsx
// TODO Oppgave 3.1: Vis alle erfaringene
return (
  <div className={styles.container}>
    {experiences.map((experience) => (
      <ExperienceCard key={experience.id} experience={experience} />
    ))}
  </div>
);
```

</details>

## Oppgave 4 - Sorter erfaringene

1. Sorter erfaringene på dato i `Experiences.tsx` ved å bruke `sort` på experiences.

<details>
<summary>Vis løsning</summary>

```tsx
// TODO Oppgave 4.1: Sorter erfaringene
return (
  <div className={styles.container}>
    {experiences
      .sort(
        (a, b) =>
          new Date(b.startDate).getTime() - new Date(a.startDate).getTime()
      )
      .map((experience) => (
        <ExperienceCard key={experience.id} experience={experience} />
      ))}
  </div>
);
```

</details>

## Oppgave 5 - Filtrer erfaringer etter type

Vi skal nå legge til filtrering av erfaringer etter type. Dette kan gjøres via å lagre en state med valgte type. Vi skal derfor bruke `useState`.

1. Som dere kanskje ser, så funker ikke filtrering akkurat nå. Det er fordi staten aldri blir oppdatert. cxSelect-komponenten har en `handleSelectChange` funksjon som console.loger valgte type. Oppdater funksjonen `handleSelectChange` så staten endres når man velger type i selecten.
2. Endre mappingen av erfaringen slik at den bruker filteredExperiences istedenfor experiences.
<details>
<summary>Vis løsning</summary>

```tsx
// TODO Oppgave 5.1: Filtrer experiences etter type
setSelectedExperience(selectedFilter);
```

</details>

## Oppgave 6 - Conditional rendering

Vi skal nå håndtere situasjoner der enkelte erfaringer mangler noen felt. For eksempel trenger ikke alle erfaringer å være knyttet til en bedrift, slik det kan være ved blant annet hobbyprosjekter.

1. Denne oppgaven løses i `ExperienceCard.tsx`. Sjekk om erfaringen har en `company` property. Hvis ikke, så vis "Selvstendig arbeid" istedenfor.

<details>
<summary>Vis løsning</summary>
Det finnes flere måter å løse dette på:
Det første eksempelet bruker nullish coalescing (??), som viser verdien til venstre hvis den finnes, ellers verdien til høyre.

Det andre eksempelet bruker ternary-operatoren for å sjekke om verdien finnes, og velge mellom to alternativer: betingelse ? verdiHvisTrue : verdiHvisFalse

```tsx
// TODO Oppgave 6.1: Conditional rendering

{
  experience.company ?? "Selvstendig arbeid";
}

{
  experience.company ? experience.company : "Selvstendig arbeid";
}
```

</details>

## Ekstraoppgaver

1. Lag en modal som viser en erfaring i detalj når man klikker på en erfaring.
2. Lag et utkast av om meg siden.

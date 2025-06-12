# Sett opp backend

1. I Terminalen, sørg for at du er i `cv-workshop\backend`
1. Kjør `dotnet user-secrets init`.
1. Finn ConnectionString i Supabase - i punkt 3. skal denne limes inn i en terminalkommando
   1. Klikk på **Connect** i menyen øverst på siden.
   2. Kopier Connection String fra Supabase
      - Velg **Type:** .NET
      - Bla ned til Session Poolers
      - Kopier det som står etter `"DefaultConnection":`
      - Skal ligne på dette `"User Id=postgres.vnaxvalknkajavkdnlskn;Password=[YOUR-PASSWORD];Server=aws-0-eu-north-1.pooler.supabase.com;Port=5432;Database=postgres"`
   3. Kjør `dotnet user-secrets set "ConnectionStrings:DefaultConnection" "<Connection String fra Supabase>"`
      - Bytt ut `[YOUR-PASSWORD]` (inkludert klammeparanteser) med databasepassordet du valgte i oppsettet av Supabase
1. Lag en API-nøkkel
   1. Lag en unik kode ved å kjøre kommandoen i terminalen din:
      - Mac: `uuidgen`
      - Windows: `[guid]::NewGuid()`
   1. Kopier koden og kjør `dotnet user-secrets set "AppSettings:FrontendApiKey" "<din unike kode>"`
1. For å finne disse kodene senere, kjør `dotnet user-secrets list`
1. Kjør `dotnet run`
1. Nå kjører backenden på port 5007.
1. Når frontenden er satt opp og kjører, sørg for at AllowedCorsOrigins i appsettings.json inneholder de url-ene som skal få lov til å hente data fra backenden, samt porten der frontenden kjører lokalt (Dette skal være http://localhost:5173),

# Oppgaver
Her følger oppgavene til backenddelen av innfasingsuka. Dersom du står fast så kan du be en av veilederne om hjelp, evt. så er det opprettet en branch _fasit_ som inneholder fasiten på alle oppgavene. Prøv deg frem først, før du kikker på fasiten ;)

## Oppgave 1
Du har fått utdelt et endepunkt som henter alle brukere i Users-tabellen i databasen vår. Skriv et nytt endepunkt som henter ut _én_ spesifikk bruker, gitt en ID. Bruk GetAllUsers som inspirasjon, i routeren, samt servicen.

Utfør følgende oppgaver: 
1. Legg til et GET-endepunkt i UserEndpoints.cs. Ta inn id-en (GUID) som en Route parameter. 

   _HINT_ 💡: Sjekk [dokumentasjonen](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-9.0#routing) til Minimal API. 
2. Utvid CVService med en ny metode _GetUserByIdAsync_. Husk å oppdatere interfacet også. 

   _HINT_ 💡: metoden FindAsync() kan ta inn en id og finne et 
4. Dersom ingen bruker finnes med gitt id, returner en 404 Not Found med en beskrivende feilmelding. 
5. Test endepunktet i Swagger og sjekk at du får forventet respons - både med en eksisterende id og en ikke-eksisterende. 

## Oppgave 2
Opprett to endepunkt i ExperienceEndpoints; et for å hente alle Experiences, samt et for å hente ut en gitt Experience basert på id. Endepunktene kommer til å ligne en del på de du har skrevet tidligere i oppbyggingen. Men, du skal nå også skrive en mapper for Experiences der du mapper databasemodellen til en DTO. 

1. Opprett en fil, ExperienceMapper i mappen Mappers. Denne skal bestå av en statisk klasse med en statisk metode _ToDto_ som returnerer en ExperienceDto.
2. Fullfør metodene _GetAllExperiencesAsync_ og _GetExperienceByIdAsync_ i CVService. 
3. Fullfør de to TODO-ene i ExperienceEndpoints.
4. Test endepunktene i Swagger og sjekk at metodene returner en ikke-tom liste med Experiences. 

## Oppgave 3
Fullfør endepunktet GetExperienceByType. Her tar vi inn en type erfaring (eks. work, education) og returnerer alle Experiences som er av denne typen. 
1. Skriv ferdig endepunktet i ExperiencesEndpoints.
2. Opprett en ny metode i CVService.cs

_Bonusoppgave for de ivrige_: Klarer du å omskrive _type_ fra å være en streng til en enum? Hvorfor er dette ønskelig? 

## Oppgave 4 (mer vrien)
Som konsulenter er ferdigheter (eng: skills) og hvilke teknologier man har vært borti, ganske relevant. Det er ikke utenkelig at en selger ønsker å sjekke i en CV-database for å finne alle CV-er som matcher en liste med teknologier som en kunde ønsker. Dette skal vi nå modellere. Merk at skills-feltet på en User er én streng som inneholder ulike teknologier skilt med semikolon (;). 

Utfør følgende oppgaver:

1. Opprett et endepunkt kalt GetUsersWithDesiredSkills. Dette er en POST-request som tar inn en SkillRequest (typen er opprettet for deg allerede).
2. Opprett en metode i CVService _GetUsersWithDesiredSkills_ som tar inn en IEnumerable<string> _desiredTechnologies_. Denne metoden skal utføre følgende:
    1. Hente alle brukere
    2. Gå gjennom alle brukere, parsere ferdighetene deres til en liste med Skills, og sjekke om en av ferdighetene finnes i lista som er sendt som argument.
    3. Returnere de filtrerte brukerne som har _minst_ en ønsket ferdighet.
    
    _HINT_: Bruk LINQ-uttrykk for å prosessere lista.
3. _Bonusoppgave som kan og bør gjøres før steg 2_: Hva med testing? Hvordan vet vi at strengen parseres korrekt? Skriv enhetstester for _ParseUserSkills_. Eksempelvis skal input
   ``` "React;Kotlin;CSS;" ``` gi følgende output
   ```c#
   [Skill(Technology: "React"), Skill(Technology: "Kotlin"), Skill(Technology: "CSS")] // type: IEnumerable<Skill>
   ```

   Dette er en fin mulighet for å teste ut TDD også. Spør gjerne en av veilederne for en lynintro, evt. sjekk dette [blogginnlegget](https://martinfowler.com/bliki/TestDrivenDevelopment.html) fra Martin Fowler for en kort introduksjon! TL;DR: test før implementasjon, sørg for at testen feiler, implementer metoden, testen består, refaktorer.



# Sett opp backend

1. I Terminalen, sørg for at du er i `cv-workshop\backend`
1. Kjør `dotnet user-secrets init`.
1. Finn ConnectionString i Supabase
   1. Klikk på **Connect** i menyen øverst på siden.
   2. Legg til Connection String fra Supabase som en lokal variabel
      * **Type:** .NET 
      * Bla ned til Session Pooler
      * Kopier det som står etter `"DefaultConnection":`
      * Skal ligne på dette `"User Id=postgres.vnaxvalknkajavkdnlskn;Password=[YOUR-PASSWORD];Server=aws-0-eu-north-1.pooler.supabase.com;Port=5432;Database=postgres"`
      * Bytt ut `[YOUR-PASSWORD]` med databasepassordet du valgte i oppsettet av Supabase
   1. Kjør `dotnet user-secrets set "ConnectionStrings:DefaultConnection" "<Connection String fra Supabase>"`
      * Denne finner du i Supabase
1. Lag en API-nøkkel
   1. Lag en unik kode:
      * Mac: `uuidgen`
      * Windows: `[guid]::NewGuid()`
   1. Kopier koden og kjør `dotnet user-secrets set "AppSettings:FrontendApiKey" "<din unike kode>"`
1. For å finne igjen disse kodene senere, kjør `dotnet user-secrets list`
1. Kjør `dotnet run`
1. Nå kjører backenden på port 5007.
1. Når frontenden er satt opp og kjører, sørg for at CORS-oppsettet i Program.cs matcher adressen og porten der frontenden kjører lokalt (Dette skal være http://localhost:5173)
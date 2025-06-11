# Infrastructure

## Kom i gang

Last ned:

- WSL
- Git
- Azure CLI

### 1. Fork repoet

Fork dette repoet til din egen GitHub-konto (samme hvilken).

Eventuelt opprett en GitHub-konto hvis du ikke har en fra før.

### 2. Lag en Azure-konto

Registrer deg for en gratis Azure-konto [her](https://azure.microsoft.com/free).

### 3. Autentiser deg med Azure CLI

```bash
az login
```

Følg flyten i nettleseren.

### 4. Lag Terraform-state

```bash
./create-terraform-state.sh
```

### 5. Lag en Azure-konto for Terraform

```bash
./create-azure-service-principal.sh
```

### 5.1. Legg til secrets i GitHub for Terraform

Du vil få ut fire verdier:

```bash
ARM_CLIENT_ID=...
ARM_CLIENT_SECRET=...
ARM_SUBSCRIPTION_ID=...
ARM_TENANT_ID=...
```

Lagre disse inn som secrets i GitHub-repoet ditt.
Gå til "Settings" -> "Secrets and variables" -> "Actions" -> "New repository secret".

### 5.2. Legg til secrets i GitHub for backend

Du har tidligere laget en connection string for Supabase og en API-nøkkel for frontend/backend.
Lagre disse som secrets i GitHub-repoet ditt med navnene `SUPABASE_CONNECTION_STRING` og `API_KEY`.

### 6. Push lokale endringer til GitHub

```bash
git add .
git commit -m "Lage Terraform state og Azure Service Principal"
git push
```

### 7. Følg med på GitHub Actions

Du vil til slutt få ut en URL for frontend og backend.

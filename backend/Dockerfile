FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /app

COPY . .

RUN dotnet restore backend.csproj && \
    dotnet publish \
      backend.csproj \
      --configuration Release \
      --output ./out


FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runner

WORKDIR /app

RUN addgroup application-group --gid 1001 && \
    adduser application-user --uid 1001 \
        --ingroup application-group \
        --disabled-password


COPY --from=build /app/out .

RUN chown --recursive application-user .
USER application-user

EXPOSE 8080

ENTRYPOINT ["dotnet", "backend.dll"]

# TackPad (ASP.NET Core MVC)

A simple notes / to-do web app built with ASP.NET Core MVC and Entity Framework Core.
It's a re-implementation of an earlier PHP MVC version of the same app, rebuilt on
.NET 6.

## Features

- Create, edit and delete notes (each with a title, note text, status and a
  "complete by" date).
- Notes persisted to SQL Server via Entity Framework Core (code-first migrations).
- Server-rendered Razor views with the standard MVC structure.

## Tech

- C# / ASP.NET Core MVC (.NET 6)
- Entity Framework Core 6 with SQL Server (LocalDB by default)
- Razor views, Bootstrap-based layout

## Getting started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- SQL Server — the default connection string uses **SQL Server LocalDB**
- Optional: the EF Core CLI tool (`dotnet tool install --global dotnet-ef`)

### Clone

```sh
git clone https://github.com/olivierluethy/TackPad-with-ASP.NET.git
cd TackPad-with-ASP.NET/TackPadApp
```

### Configure the database

The connection string lives in `appsettings.json` under
`ConnectionStrings:DefaultConnection` and points at a local LocalDB instance by default.
Adjust it if you use a different SQL Server instance.

### Create the database and run

```sh
dotnet ef database update
dotnet run
```

The app is then reachable at the address shown in the console (see
`Properties/launchSettings.json`). Alternatively, open `TackPadApp.sln` in Visual Studio
and press **F5**.

# Blazor.WithPaginationSearch

## Project Creation

This project was created using the Windows Powershell, using the command:

>dotnet new blazorwasm -f net5.0 --hosted true --pwa true -o Blazor.WithGraphics

which sets the .NET 5.0 framework, configuration with HTTPS, Hosted ASP.NET Core and Progressive Web Application and where -o indicates the name of the project folder

## Components

### MudBlazor

Since the project is in .NET 5 version, it was necessary to install a lower MudBlazor Nuget package than the one indicated (as of 04/02/2022 the latest version is 6.0.6).

Version 5.2.4 was installed for this demo project using the following command:

> dotnet add package MudBlazor --version 5.2.4

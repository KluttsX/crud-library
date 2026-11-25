# crud-library

Aplicación web para la gestión de libros de una biblioteca, desarrollada con ASP.NET Core MVC, Entity Framework Core y SQLite.

## Funcionalidades

- Registrar libros.
- Consultar libros.
- Editar libros.
- Eliminar libros.

## Requisitos

- .NET SDK.
- Entity Framework Core CLI (`dotnet-ef`).

## Instalación y ejecución

1. Clonar el repositorio:

   ```bash
   git clone https://github.com/KluttsX/crud-library.git
   ```

2. Acceder al proyecto:

   ```bash
   cd crud-library
   ```

3. Restaurar las dependencias:

   ```bash
   dotnet restore
   ```

4. Aplicar las migraciones:

   ```bash
   dotnet ef database update
   ```

5. Ejecutar la aplicación:

   ```bash
   dotnet run
   ```

6. Abrir en el navegador la URL indicada en la terminal.

# crud-library

Aplicación web para la gestión de libros de una biblioteca, desarrollada con ASP.NET Core MVC y Entity Framework Core.

## Funcionalidades

- Registrar libros.
- Consultar libros.
- Editar libros.
- Eliminar libros.

## Requisitos

- .NET SDK.
- Visual Studio.
- Base de datos configurada en `appsettings.json`.

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

4. Configurar la cadena de conexión en `appsettings.json`.

5. Aplicar las migraciones:

   ```bash
   dotnet ef database update
   ```

6. Ejecutar la aplicación:

   ```bash
   dotnet run
   ```

7. Abrir en el navegador la URL indicada en la terminal.

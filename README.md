
This project its a solution to the test for MAVHA (www.mavha.com) exercise .
Mainly done with [VB]().and [ASP]()[.NET]()

## Excercise statement

Test Técnico

#### Problema
Implementar una solución visual (Web y Winform) con Alta-Listado  de una Entidad Persona con las siguientes características:
- PERSONA
	- Nombre Completo
	- Fecha de nacimiento
	- Edad
	- Sexo

##### Implementar:
Listado de personas en una tabla con todos los campos de la entidad.
Alta de persona con todos los campos de la entidad. 
Edicion de persona con todos los campos de la entidad. 
Baja lógica de persona.

##### Consideraciones:
Construir una Solución .Net con los siguientes proyectos:
Proyecto Web con ASPX en VB.Net para ABML de Personas.
Proyecto VB.Net con la Lógica de negocio del ABML.
Proyecto de WebServices SOAP que reuse el proyecto de Logica.
Proyecto WinForms en VB.Net para ABML de Personas, que consuma los servicios del proyecto SOAP.

Persistencia en DB SQLServer.


### Cloning the App

```
$ git clone https://github.com/franbonafina/reactNativeExample
$ cd reactNativeExample
```

Once this is done, there are some commands you can run in the project directory:

### Set the App
- 1 Execute create table script (user.sql) using SSMS.
	- Replace USE [YourDatabase] with a specific database.
- 2 Update Web.Config appsetting with your SQL Server connection string.
```
	<appSettings>
	    <add key="ConnectionString" value="Server=yourserver;Database=yourdatabase;User id = sa;Password=yourpassword"/>
	</appSettings>
```

#### `dotnet build`
Install the dependencies . 

### First Run WebService *UsuarioWebService*
	`cd SOAP`
 	`dotnet run`

#### `donet run`
Runs the app in debug mode.

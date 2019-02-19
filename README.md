# Sputnik
Angular/Asp.Net Core, a example project.


Instalación

1- Restaurar la base de datos
	Hay un archivo llamado Agence.DB.bacpac, el cual contiene la base de datos migrada a ms sql server.

2- Iniciar el Backend
	abrir una consola o bash y navegar a la ruta del proyecto ../Sputnik/Agence/Agence
    Ejecutar dotnet restore y posteriormente colocar: dotnet run.
	por último borrar el url y colocar el siguiente para poder usar swagger https://localhost:44365/swagger/index.html 
	de esta forma probar el webservice.

3- Iniciar el FrontEnd
	Abrir una consola o bash y navegar a la ruta edl proyecto ../Sputnik/Agence.FrontEnd/Agence
	Ejecutar ng serve --open
	
IMPORTANTE

el front consume el backend, es NECESARIO que antes de levantar el frontend el webservice esté iniciado.



Vergleichen WebAPI mit NET48 vs. ASP.NET Core WebAPI





1.) Wie starten beide WebAPIs: 

WebAPI(NET48):

Programmstart einer WebAPI beginn bei WebAPIConfig:

- Verwendet -> App_Start -> WebApiConfig.cs 


WebAPI(NET7):
- Programm.cs beinhaltet den Initalisierung-Workflow jeder WebAPP (auch bei WebAPI)




-------------------------------------------------------------------------------------------------------------------------------------------------
2.) Konfigurationen: 

WebAPI(NET48):
- Web.config ist eine XML-Datei und beinhaltet WebAPI-Spezifische Konfigurationen, sowie Konfigurationen von Drittanbieter (z.B. Logger)


WebAPI(NET7):
appsetting.json -> Auslese/Update Methoden müssten bei einer Migration komplett neu implementiert werden 


-------------------------------------------------------------------------------------------------------------------------------------------------

3.) Abhängigkeiten (Drittanbieter) - Wie werde diese Implementiert und verwendet


WebAPI(NET48):
    - Per Default verwendet WebAPI keinen IOC Container 
		-> Es ist aber möglich, IOC Container über Drittanbieter (Autofac, Ninject, StructureMap, Castle Windsor.. usw.)

WebAPI(NET7):
- Ist die Library des Drittanbieters soweit gleich geblieben? 
	- Können Implementierung aus NET48 wiederverwendet werden (teils nein). 
	- Der Grund hierfür ist, dass ASP.NET Core WebAPI einen IOC-Container (von Microsoft geschrieben: Microsoft.Extensions.DependencyInjection) verwendet.
		- Für Drittanbieter eines IOC-Container muss man die von Microsoft vorgebenene Microsoft.Extensions.DependencyInjection.Abstractions abgeleitet sein
		- Beispiele (siehe) -> Autofac.Extensions.DependencyInjection (leitet von) Microsoft.Extensions.DependencyInjection.Abstractions ab

-------------------------------------------------------------------------------------------------------------------------------------------------
4.) Controller-Klassen: 

WebAPI(NET48):
- Basisklasse jeder WebAPI-Controller - Klasse ist die -> ApiController 

WebAPI(NET7):
- Basisklasse jeder WebAPI-Controller-Klasse ist die ControllerBase 


5.) 

Weitere Features in ASP.NET Core WebAPI:

- Swagger 


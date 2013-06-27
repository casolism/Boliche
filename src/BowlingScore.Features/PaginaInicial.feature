Feature: PaginaInicial
	Para poder jugar boliche
	como anotador 
	Quiero ingresar a la aplicacion

@mytag
Scenario: Ingresar
	Given Abrio la aplicacion boliche 
	When Presiono el boton "Iniciar Nuevo juego"
	Then Debo ver pagina Score 

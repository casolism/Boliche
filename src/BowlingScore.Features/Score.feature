Feature: Score
	Para llevar el marcador de un juego de boliche
	Como Chavita (anotador)
	Quiero registrar los marcadores de los jugadores

@mytag
Scenario: Ver Tablero inicializado
	Given Se inició un nuevo juego
	When Visito la página Score
	Then Veo el mensaje "Juego Iniciado"
	And Veo la tabla "Score":
	|Jugador	|1	|2	|3	|4	|5	|6	|7	|8	|9	|10	|score	|
	|Jugador 1	| -	| -	| -	| -	| -	| -	| -	| -	| -	| -	|0	|
	|Jugador 2	| -	| -	| -	| -	| -	| -	| -	| -	| -	| -	|0	|
	|Jugador 3	| -	| -	| -	| -	| -	| -	| -	| -	| -	| -	|0	|
	|Jugador 4	| -	| -	| -	| -	| -	| -	| -	| -	| -	| -	|0	|


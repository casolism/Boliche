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

Scenario: Score para el Jugador 1 
	Given Se inició un nuevo juego	
	When Visito la página Score
	Then El jugador 1 realiza su tirada 1 del primer turno
	And Chavita pulsó el botón chuza
	Then Veo la tabla "Score":
	|Jugador	|1	|2	|3	|4	|5	|6	|7	|8	|9	|10	|score	|
	|Jugador 1	|X-	| -	| -	| -	| -	| -	| -	| -	| -	| -	|0	|
	|Jugador 2	| -	| -	| -	| -	| -	| -	| -	| -	| -	| -	|0	|
	|Jugador 3	| -	| -	| -	| -	| -	| -	| -	| -	| -	| -	|0	|
	|Jugador 4	| -	| -	| -	| -	| -	| -	| -	| -	| -	| -	|0	|
	When Chavita Registra 5 pines
	And Chavita pulsó el botón Ok
	Then Veo la tabla "Score":
	|Jugador	|1	|2	|3	|4	|5	|6	|7	|8	|9	|10	|score	|
	|Jugador 1	|X-	|5-	| -	| -	| -	| -	| -	| -	| -	| -	|0	|
	|Jugador 2	| -	| -	| -	| -	| -	| -	| -	| -	| -	| -	|0	|
	|Jugador 3	| -	| -	| -	| -	| -	| -	| -	| -	| -	| -	|0	|
	|Jugador 4	| -	| -	| -	| -	| -	| -	| -	| -	| -	| -	|0	|
	#When Chavita Registra 3 pines
	#And Chavita pulsó el botón Ok
	#Then Veo la tabla "Score":
	#|Jugador	|1	|2	|3	|4	|5	|6	|7	|8	|9	|10	|score	|
	#|Jugador 1	|X-	|5-| -	| -	| -	| -	| -	| -	| -	| -	|0	|
	#|Jugador 2	| -	| -	| -	| -	| -	| -	| -	| -	| -	| -	|0	|
	#|Jugador 3	| -	| -	| -	| -	| -	| -	| -	| -	| -	| -	|0	|
	#|Jugador 4	| -	| -	| -	| -	| -	| -	| -	| -	| -	| -	|0	|

@automated
@WI7
Feature: Desplegar libros en la pantalla
	Como pontencial cliente
	Quiero ver los libros con el mejor precio
	Para ahorra dinero comprando libros con descuentos	

Background:
	Given the following books
		| Title                              | Price |
		| 100 años de soledad                  | 50.20 |
		| Programacion en Java               | 46.34 |
		| La metamorfosis					| 31.49 |
		| La tolla del mojado				| 24.75 |

@WI8
Scenario: Los 3 libros mas baratos se deberian mostrar en l apantalla de inicio
	When Ingreso a la tienda virtual
	Then La pantalla de inicio deberia mostrar el libro 'La tolla del mojado'
	And La pantalla de inicio deberia mostrar el libro 'La metamorfosis AAASDFD'
	And La pantalla de inicio deberia mostrar el libro 'Programacion en Java'

@alternative_syntax
@WI8
Scenario: Los 3 libros mas baratos se deberian mostrar en l apantalla de inicio (list syntax)
	When Ingreso a la tienda virtual
	Then La pantalla de inicio deberia mostrar los libros 'La tolla del mojado', 'La metamorfosis', 'Programacion en Java'

@alternative_syntax
@WI8
Scenario: Los 3 libros mas baratos se deberian mostrar en l apantalla de inicio (table syntax)
	When Ingreso a la tienda virtual
	Then La pantalla de inicio deberia mostrar los libros
		| Title                  |
		| La tolla del mojado    |
		| La metamorfosisFGFGFDFG		 |
		| Programacion en Java   |
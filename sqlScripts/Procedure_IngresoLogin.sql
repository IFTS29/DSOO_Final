/*-------------------------------------------*/
/* ----- Procedimiento  IngresoLogin ------ */
/*-----------------------------------------*/

/* funcion que verifica si el usuario y contraseña existen en la base de datos:
   --> si ambos existen y si el usuario está activo: la consulta arroja 1 FILA ( el nombre del rol )
   --> si los datos de los parámetros no existen o si el usuario está inactivo: arroja 0 FILAS */

delimiter //  
create procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15))
/* 
Se crea el PROCEDIMIENTO, con 2 parametros de entrada (IN):
(cuya longitud es igual a la del atributo de la tabla)
- Usu (nombre de usuario)  y    - Pass (contraseña)
*/
   
begin
  select NomRol  /* proyecto en la consulta el rol que tiene el usuario que ingresa */
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass /* se compara con los parametros */
			and Activo = 1; /* el usuario debe estar activo */
end 
//

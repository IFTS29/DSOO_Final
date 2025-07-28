/*-------------------------------------------*/
/* ----- Procedimiento  NuevoCliente ------ */
/*-----------------------------------------*/


/* funcion que registra al cliente como socio o no socio del club
   (en caso de no estar previamente registrado). 
   1°: inserta datos comunes en la tabla padre cliente
   2°: verifica el tipo de socio para intertar en las clases hijas correspondientes
   y crear el nuevo id */



delimiter //  
create procedure NuevoCliente(
	in Nom varchar(30),
    in Ape varchar(40),
    in TipoDoc varchar(20), 
    in Docu int, 
    in Apt boolean, 
    in Nac date, 
    in Direc varchar(50),
    in Telef varchar(20),
    in Em varchar(50),
    in TipoCliente varchar(10),  -- "Socio" o "NoSocio"
    out rta int
)

 begin
     declare filas int default 0;
	 declare existe int default 0;
     
	-- Se valida si ya existe un cliente registrado, con ese documento
    set existe = (select COUNT(*) from cliente where Doc = Docu);
	
    
   IF existe > 0 THEN
		-- si cliente ya existe: la salida es -1
        set rta = -1; 
    ELSE
        -- si cliente no existe: se insertan datos en cliente
        insert into cliente (Doc, TDoc, Nombre, Apellido, FechaNac, Direccion, Telefono, Email, AptoMedico)
        values (Docu, TipoDoc, Nom, Ape, Nac, Direc, Telef, Em, Apt);
		
        -- se valida el tipo de cliente
        -- 1) SI ES SOCIO: 
        IF TipoCliente = 'Socio' THEN
			-- Se valida si hay socios registrados (se obtiene la cantidad de filas en tabla socio)
            set filas = (select COUNT(*) from socio);
            
            -- Se calcula el nuevo ID del socio
            if filas = 0 then
            /* si no hay socios registrados: se establece el n° del primer id Socio */
                set filas = 1;
            else
            /* si hay registros previos: se busca el ultimo n° de idSocio almacenado 
			(para luego sumarle una unidad y obtener el nuevo id de la tabla socio) */
                set filas = (select MAX(idSocio) + 1 from socio);
            end if;
			
            -- Insertar en Socio
            insert into socio (idSocio, Doc, FechaInscripcion)
            values (filas, Docu, CURDATE());
			
            -- Insertar en Cuota
            insert into CuotaMensual (idSocio, fechaVencimiento)
            values (filas, CURDATE());


		
        -- 2) SI ES NO SOCIO: 
        ELSEIF TipoCliente = 'No Socio' THEN 
			-- Se valida si hay No socios registrados (se obtiene la cantidad de filas en tabla Nosocio)
            set filas = (select COUNT(*) from NoSocio);
            
            -- Se calcula el nuevo ID del no socio.
            if filas = 0 then
            /* si no hay NoSocios registrados: se establece el n° del primer id NoSocio */
                set filas = 1;
            else
            /* Si hay registros previos: se busca el ultimo n° de idNoSocio almacenado 
			(para luego sumarle una unidad y obtener el nuevo id de la tabla NoSocio) */
                set filas = (select MAX(idNoSocio) + 1 from NoSocio);
            end if;
            
			-- Insertar en No Socios
            insert into NoSocio (idNoSocio, Doc, FechaInscripcion)
            values (filas, Docu, CURDATE());
   
        END IF;
        
        -- si cliente no existe (no estaba registrado): la salida es el nuevo ID 
        set rta = filas;
    END IF;
END;
//
delimiter ;

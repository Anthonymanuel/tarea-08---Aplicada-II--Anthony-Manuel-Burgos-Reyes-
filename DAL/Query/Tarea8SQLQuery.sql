Create DataBase Tarea8Db
use Tarea8Db

Create Table Usuarios
(
 UsuarioId Int Identity(1,1) Primary Key,
 NombreUsuario varchar(50),
 Contrasena varchar(20)
)
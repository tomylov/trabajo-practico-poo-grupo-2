Trabajo Práctico P.O.O. | Grupo 2

Sistema de gestión de usuarios,vendedores,artículos y ventas.
Integrantes: Alvaro Pistelli, Tomas Arias Karlé,Benjamin Rivero y Esteban Botegoni

Pantalla bienvenida:
El usuario podrá iniciar sesión con una cuenta existente pulsando el botón Iniciar sesión o bien, crear una cuenta nueva pulsando Crear Usuario.
Si el usuario ya se encuentra registrado en el sistema, éste completará los campos de Usuario(Email) y Contraseña.
Si el usuario no se encuentra registrado, éste completará los campos Nombre, DNI, Email, Teléfono, Contraseña y Confirmar Contraseña y pulsara Crear Usuario para registrarlo en el sistema.

Pantalla cliente:
El usuario podrá agregar artículos al carrito presionando en el botón Agregar al Carrito.
 Se invocará el formulario de Carrito con los campos de “Código”, “Descripción”(que se auto completará dependiendo del Código ingresado anteriormente), “Cantidad”,  “Subtotal”, junto a los botones de “Agregar”, “Artículos”,  “Eliminar Articulo”y “Enviar” exhibiendo en una grilla los Codigos de Articulos, Descripcion, Precio, Cantidad, Importe.
El botón “Agregar”  se encargará de añadir los artículos a la grilla junto con sus respectivas validaciones actualizando el Subtotal a medida que se cargan los artículos.
El botón “Articulos” invocará un formulario que exhibirá todos los artículos que el Cliente podrá añadir al Carrito.
El botón “Eliminar Artículo” se encargará de eliminar de la grilla el artículo seleccionado y devuelve el valor de stock al Artículo.
El botón “Enviar” se encarga de registrar una venta con el estado “Pendiente” hacia el formulario de Gestionar Ventas.

Pantalla admin: 
Puede cargar nuevos Vendedores completando los campos y pulsando “Agregar”.
Puede modificar Vendedores seleccionándolos de la grilla, realizando los cambios y luego pulsando “Modificar”.
Puede eliminar usuarios seleccionándolos de la grilla y pulsando “Eliminar”
Botón [Salir] te envía a la pantalla de Bienvenida.

Tipos de usuario:
Cliente: Acceso a pantalla de carga de facturas.
Super Admin: Acceso a pantalla de gestión de usuarios. Puede consultar, agregar, eliminar y modificar usuarios del sistema.
Vendedor: Acceso a la pantalla de Gestionar Ventas.

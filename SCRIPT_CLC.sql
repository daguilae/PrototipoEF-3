#Base datos final
create database if not exists db_clc;
use db_clc;
#CONSULTAS-INTELIGENTES----------------------------------------------------------------------------
#SEGURIDAD-----------------------------------------------------------------------------------------
create table if not exists LOGIN(
	pk_id_login 						int(10) not null primary key auto_increment,
    usuario_login 						varchar(45),
    contraseña_login 					varchar(45),
    nombreCompleto_login				varchar(100),
    estado_login						int(2)
);
create table if not exists MODULO(
	pk_id_modulo 						int(10)not null auto_increment,
    nombre_modulo 						varchar(30)not null,
    descripcion_modulo 					varchar(50)not null,
    estado_modulo 						int(1)not null,
    primary key(pk_id_modulo),
    key(pk_id_modulo)
);
create table if not exists APLICACION(
	pk_id_aplicacion 					int(10)not null auto_increment,
    fk_id_modulo 						int(10)not null,
    nombre_aplicacion 					varchar(40)not null,
    descripcion_aplicacion 				varchar(45)not null,
    estado_aplicacion 					int(1)not null,
    primary key(pk_id_aplicacion),
    key(pk_id_aplicacion)
);
alter table APLICACION add constraint fk_aplicacion_modulo foreign key(fk_id_modulo) references MODULO(pk_id_modulo);

create table if not exists PERFIL(
	pk_id_perfil						int(10) not null primary key auto_increment,
    nombre_perfil						varchar(50),
    descripcion_perfil					varchar(100),
    estado_perfil						int(2)
);
create table if not exists PERMISO(
	pk_id_permiso						int(10) not null primary key auto_increment,
    insertar_permiso					boolean,
    modificar_permiso					boolean,
    eliminar_permiso					boolean,
    consultar_permiso					boolean,
    imprimir_permiso					boolean
);
create table if not exists APLICACION_PERFIL(
	pk_id_aplicacion_perfil				int(10) not null primary key auto_increment,
    fk_idaplicacion_aplicacion_perfil	int(10),
    fk_idperfil_aplicacion_perfil		int(10),
    fk_idpermiso_aplicacion_perfil		int(10)
);
alter table APLICACION_PERFIL add constraint fk_aplicacionperfil_aplicacion foreign key (fk_idaplicacion_aplicacion_perfil) references APLICACION(pk_id_aplicacion)on delete restrict on update cascade;
alter table APLICACION_PERFIL add constraint fk_aplicacionperfil_perfil foreign key (fk_idperfil_aplicacion_perfil) references PERFIL(pk_id_perfil)on delete restrict on update cascade;
alter table APLICACION_PERFIL add constraint fk_aplicacionperfil_permiso foreign key (fk_idpermiso_aplicacion_perfil) references PERMISO (pk_id_permiso)on delete restrict on update cascade;

create table if not exists PERFIL_USUARIO(
	pk_id_perfil_usuario				int(10) not null primary key auto_increment,
    fk_idusuario_perfil_usuario			int(10),
    fk_idperfil_perfil_usuario			int(10)
);
alter table PERFIL_USUARIO add constraint fk_perfil_usuario_login foreign key(fk_idusuario_perfil_usuario) references LOGIN(pk_id_login) on delete restrict on update cascade;
alter table PERFIL_USUARIO add constraint fk_perfil_usuario_perfil foreign key (fk_idperfil_perfil_usuario) references PERFIL(pk_id_perfil) on delete restrict on update cascade;

create table if not exists APLICACION_USUARIO(
	pk_id_aplicacion_usuario			int(10) not null primary key auto_increment,
    fk_idlogin_aplicacion_usuario		int(10),
    fk_idaplicacion_aplicacion_usuario	int(10),
    fk_idpermiso_aplicacion_usuario		int(10)
);
alter table APLICACION_USUARIO add constraint fk_aplicacionusuario_login foreign key(fk_idlogin_aplicacion_usuario) references LOGIN(pk_id_login) on delete restrict on update cascade;
alter table APLICACION_USUARIO add constraint fk_aplicacionusuario_aplicacion foreign key (fk_idaplicacion_aplicacion_usuario) references APLICACION(pk_id_aplicacion) on delete restrict on update cascade;
alter table APLICACION_USUARIO add constraint fk_aplicacionusuario_permiso foreign key(fk_idpermiso_aplicacion_usuario) references PERMISO (pk_id_permiso)on delete restrict on update cascade;

create table if not exists BITACORA(
	pk_id_bitacora						int(10) not null primary key auto_increment, #pk
    fk_idusuario_bitacora				int(10),
    fk_idaplicacion_bitacora			int(10),
    fechahora_bitacora					varchar(50),
    direccionhost_bitacora				varchar(20),
    nombrehost_bitacora					varchar(20),
    accion_bitacora						varchar(250)
);
CREATE TABLE IF NOT EXISTS DETALLE_BITACORA (
    pk_id_detalle_bitacora 				INT(10) NOT NULL PRIMARY KEY AUTO_INCREMENT,
    fk_idbitacora_detalle_bitacora 		INT(10),
    querryantigua_detalle_bitacora 		VARCHAR(50),
    querrynueva_detalle_bitacora 		VARCHAR(50)
);
alter table BITACORA add constraint fk_login_bitacora foreign key (fk_idusuario_bitacora) references LOGIN (pk_id_login) on delete restrict on update cascade;
alter table BITACORA add constraint fk_aplicacion_bitacora foreign key (fk_idaplicacion_bitacora) references APLICACION(pk_id_aplicacion) on delete restrict on update cascade;
alter table DETALLE_BITACORA add constraint fk_bitacora_detallebitacora foreign key(fk_idbitacora_detalle_bitacora) references BITACORA(pk_id_bitacora) on delete restrict on update cascade;

##MODULOS------------------------------------------------------------------------------------------
###SCM---------------------------------------------------------------------------------------------
create table DEPARTAMENTO(
	pk_id_departamento int(10)not null auto_increment,
    nombre_departamento varchar(30)not null,
    descripcion_departamento varchar(45)not null,
    estado_departamento int(1)not null,
    primary key(pk_id_departamento),
    key(pk_id_departamento)
);
create table MUNICIPIO(
	pk_id_municipio int(10)not null auto_increment,
    fk_id_departamento int(10)not null,
    nombre_municipio varchar(30)not null,
    descripcion_municipio varchar(45)not null,
    estado_municipio int(1)not null,
    primary key(pk_id_municipio),
    key(pk_id_municipio)
);
alter table MUNICIPIO add constraint fk_municipio_departamento foreign key(fk_id_departamento) references DEPARTAMENTO(pk_id_departamento);

create table BODEGA(
	pk_id_bodega int(10)not null auto_increment,
    fk_id_municipio int(10)not null,
    descripcion_bodega varchar(45)not null,
    dimensiones_bodega double(5,2)not null,
    direccion_bodega varchar(45)not null,
    telefono_bodega int(8)not null,
    estado_bodega int(1)not null,
    primary key(pk_id_bodega),
    key(pk_id_bodega)
);
alter table BODEGA add constraint fk_bodega_municipio foreign key(fk_id_municipio) references MUNICIPIO(pk_id_municipio);

create table LINEA_PRODUCTO(
	pk_id_linea_producto int(10)not null auto_increment,
    nombre_linea_producto varchar(25)not null,
    descripcion_linea_producto varchar(50) not null,
    estado_linea_producto int(1) not null,
    primary key(pk_id_linea_producto),
    key(pk_id_linea_producto)
);
create table CATEGORIA_PRODUCTO(
	pk_id_categoria_producto int(10) not null auto_increment,
    nombre_categoria_producto varchar(35)not null,
    descripcion_categoria_producto varchar(60)not null,
    estado_categoria_producto int(1)not null,
    primary key(pk_id_categoria_producto),
    key(pk_id_categoria_producto)
);
create table PRODUCTO(
	pk_id_producto int(10)not null auto_increment,
    fk_id_linea_producto int(10)not null,
    fk_id_categoria_producto int(10)not null,
    nombre_producto varchar(50)not null,
    precio_producto double(12,2)not null,
    medida_producto double(5,2)not null,
    descripcion_producto varchar(45)not null,
    estado_producto int(1)not null,
    primary key(pk_id_producto),
    key(pk_id_producto)
);
alter table PRODUCTO add constraint fk_producto_lineaProducto foreign key(fk_id_linea_producto) references LINEA_PRODUCTO(pk_id_linea_producto);
alter table PRODUCTO add constraint fk_producto_categoriaProducto foreign key(fk_id_categoria_producto) references CATEGORIA_PRODUCTO(pk_id_categoria_producto);

create table EXISTENCIA(
	pk_id_existencia int(10)not null auto_increment,
    fk_id_bodega int(10)not null,
    fk_id_producto int(10)not null,
    cantidad_existencia int(10)not null,
    estado_existencia int(1)not null,
    primary key(pk_id_existencia),
    key(pk_id_existencia)
);
alter table EXISTENCIA add constraint fk_inventario_producto foreign key(fk_id_producto) references PRODUCTO(pk_id_producto);
alter table EXISTENCIA add constraint fk_inventario_bodega foreign key(fk_id_bodega) references BODEGA(pk_id_bodega);

create table INVENTARIO(
	pk_id_inventario int(10)not null auto_increment,
    fk_id_producto int(10)not null,
    cantidad_inventario int(10)not null,
    estado_inventario int(1)not null,
    primary key(pk_id_inventario),
    key(pk_id_inventario)
);
alter table INVENTARIO add constraint fk_total_inventario foreign key(fk_id_producto) references PRODUCTO(pk_id_producto);

create table PAIS(
	pk_id_pais int(10)not null auto_increment,
    nombre_pais varchar(40)not null,
    capital_pais varchar(40)not null,
    estado_pais int(1)not null,
    primary key(pk_id_pais),
    key(pk_id_pais)
);
create table PROVEEDOR(
	pk_id_proveedor int(10)not null auto_increment,
    fk_id_pais int(10)not null,
    razon_social_proveedor varchar(45)not null,
    representante_legal_proveedor varchar(45) not null,
    nit_proveedor varchar(20)not null,
    estado_proveedor int(1)not null,
    primary key(pk_id_proveedor),
    key(pk_id_proveedor)
);
alter table PROVEEDOR add constraint fk_proveedor_pais foreign key(fk_id_pais) references PAIS(pk_id_pais);

create table TELEFONO_PROVEEDOR(
	pk_id_telefono_proveedor int(10)not null auto_increment,
    fk_id_proveedor int(10)not null,
    telefono_telefono_proveedor varchar(20)not null,
    estado_telefono_proveedor int(1)not null,
    primary key(pk_id_telefono_proveedor),
    key(pk_id_telefono_proveedor)
);
alter table TELEFONO_PROVEEDOR add constraint fk_proveedor_telefono foreign key(fk_id_proveedor) references PROVEEDOR(pk_id_proveedor);

create table CORREO_PROVEEDOR(
	pk_id_correo_proveedor int(10)not null auto_increment,
    fk_id_proveedor int(10)not null,
    correo_correo_proveedor varchar(50)not null,
    estado_correo_proveedor int(1)not null,
    primary key(pk_id_correo_proveedor),
    key(pk_id_correo_proveedor)
);
alter table CORREO_PROVEEDOR add constraint fk_proveedor_correo foreign key(fk_id_proveedor) references PROVEEDOR(pk_id_proveedor);

create table ENCARGADO_BODEGA(
	pk_id_encargado_bodega int(10)not null auto_increment,
    fk_id_empleado int(10)not null,
    fk_id_bodega int(10)not null,
    estado_encargado_bodega int(1)not null,
    primary key(pk_id_encargado_bodega),
    key(pk_id_encargado_bodega)
);
alter table ENCARGADO_BODEGA add constraint fk_empleado_bodega foreign key(fk_id_bodega) references BODEGA(pk_id_bodega);

create table COMPRA_ENCABEZADO(
	pk_id_compra_encabezado int(10)not null,
    fk_id_proveedor int(10)not null,
    estado_proceso_encabezado_compra int(1)not null,
    fec_compra_encabezado_compra datetime not null,
    total_compra_encabezado_compra double(12,2) not null,
    estado_encabezado_compra int(1)not null,
    primary key(pk_id_compra_encabezado),
    key(pk_id_compra_encabezado)
);
alter table COMPRA_ENCABEZADO add constraint fk_compra_proveedor foreign key(fk_id_proveedor) references PROVEEDOR(pk_id_proveedor);

create table COMPRA_DETALLE(
	fk_id_compra_encabezado int(10)not null,
	cod_linea_compra_detalle int(10)not null,
    fk_id_producto int(10)not null,
    cantidad_compra_detalle int(10)not null,
    precio_unitario_compra_detalle double(8,2)not null,
    subtotal_compra_detalle double(12,2)not null,
    estado_compra_detalle int(1)not null,
    primary key(fk_id_compra_encabezado,cod_linea_compra_detalle),
    key(fk_id_compra_encabezado,cod_linea_compra_detalle)
);
alter table COMPRA_DETALLE add constraint fk_compra_detalle foreign key(fk_id_compra_encabezado) references COMPRA_ENCABEZADO(pk_id_compra_encabezado);
alter table COMPRA_DETALLE add constraint fk_compra_producto foreign key(fk_id_producto) references PRODUCTO(pk_id_producto);

create table FABRICA(
	pk_id_fabrica int(10)not null auto_increment,
    fk_id_municipio int(10)not null,
    dimensiones_fabrica double(5,2)not null,
    direccion_fabrica varchar(45)not null,
    telefono_fabrica int(8)not null,
    descripcion_fabrica varchar(45)not null,
    estado_fabrica int(1)not null,
    primary key(pk_id_fabrica),
    key(pk_id_fabrica)
);
alter table FABRICA add constraint fk_fabrica_municipio foreign key(fk_id_municipio) references MUNICIPIO(pk_id_municipio);

create table PEDIDO_ENCABEZADO(
	pk_id_pedido_encabezado int(10)not null,
    fk_id_fabrica int(10)not null,
    estado_proceso_pedido_encabezado int(1)not null,
    fec_pedido_pedido_encabezado datetime not null,
    total_pedido_encabezado double(12,2) not null,
    estado_pedido_encabezado int(1)not null,
    primary key(pk_id_pedido_encabezado),
    key(pk_id_pedido_encabezado)
);
alter table PEDIDO_ENCABEZADO add constraint fk_pedido_fabrica foreign key(fk_id_fabrica) references FABRICA(pk_id_fabrica);

create table PEDIDO_DETALLE(
	fk_id_pedido_encabezado int(10)not null,
	cod_linea_pedido_detalle int(10)not null,
    fk_id_producto int(10)not null,
    cantidad_pedido_detalle int(10)not null,
    precio_unitario_pedido_detalle double(8,2)not null, /*Precio dado por fábrica*/
    subtotal_pedido_detalle double(12,2)not null,
    estado_pedido_detalle int(1)not null,
    primary key(fk_id_pedido_encabezado,cod_linea_pedido_detalle),
    key(fk_id_pedido_encabezado,cod_linea_pedido_detalle)
);
alter table PEDIDO_DETALLE add constraint fk_encabezado_pedido foreign key(fk_id_pedido_encabezado) references PEDIDO_ENCABEZADO(pk_id_pedido_encabezado);
alter table PEDIDO_DETALLE add constraint fk_pedido_producto foreign key(fk_id_producto) references PRODUCTO(pk_id_producto);

create table MARCA (
	pk_id_marca int(10)not null auto_increment,
	descripcion_marca varchar(45)not null,
	estado_marca int(1)not null,
	primary key(pk_id_marca),
	key(pk_id_marca)
);
create table VEHICULO (
  pk_id_vehiculo int(10)not null auto_increment,
  fk_id_marca int (10) not null,
  placa_vehiculo varchar(45)not null,
  modelo_vehiculo varchar(45)not null,
  color_vehiculo varchar(45)not null,
  anio_vehiculo  varchar(45)not null,
  tipo_combustible_vehiculo varchar(45)not null,
  estado_vehiculo int(1)not null,
  primary key(pk_id_vehiculo),
  key(pk_id_vehiculo)
);
alter table VEHICULO add constraint fk_vehiculo_marca foreign key(fk_id_marca) references MARCA (pk_id_marca);

create table RUTA(
	pk_id_ruta int(10)not null auto_increment,
    origen_ruta varchar(40) not null,
    destino_ruta varchar(40)not null,
    descripcion_ruta varchar(45)not null,
    estado_ruta int(1)not null,
    primary key(pk_id_ruta),
    key(pk_id_ruta)
);
create table TIPO_MOVIMIENTO(
	pk_id_tipo_movimiento int(10)not null,
    nombre_tipo_movimiento varchar(45)not null,
    signo_tipo_movimiento varchar(1),
    estado_tipo_movimiento int(1)not null,
	primary key(pk_id_tipo_movimiento),
    key(pk_id_tipo_movimiento)
);
create table MOVIMIENTO_INVENTARIO(
	pk_id_movimiento_inventario int(10)not null,
    fecha_movimiento_inventario datetime not null,
    fk_id_tipo_movimiento int(10)not null,
    fk_id_ruta int(10) null,
    fk_id_vehiculo int(10) null,
    documento_asociado_movimiento_inventario int(10) null,
    descripcion_movimiento_inventario varchar(50) not null,
	primary key(pk_id_movimiento_inventario),
    key(pk_id_movimiento_inventario)
);
alter table MOVIMIENTO_INVENTARIO add constraint fk_mov_inventario_tipo foreign key(fk_id_tipo_movimiento) references TIPO_MOVIMIENTO(pk_id_tipo_movimiento);
alter table MOVIMIENTO_INVENTARIO add constraint fk_mov_inventario_ruta foreign key(fk_id_ruta) references RUTA(pk_id_ruta);
alter table MOVIMIENTO_INVENTARIO add constraint fk_mov_inventario_vehiculo foreign key(fk_id_vehiculo) references VEHICULO(pk_id_vehiculo);

create table MOVIMIENTO_INVENTARIO_DETALLE(
	pk_id_movimiento_inventario_detalle int(10)not null,
    fk_id_movimiento_inventario int(10)not null,
    fk_id_producto int(10)not null,
	cantidad_inventario_detalle int(8)not null,
	primary key(pk_id_movimiento_inventario_detalle),
    key(pk_id_movimiento_inventario_detalle)
);
alter table MOVIMIENTO_INVENTARIO_DETALLE add constraint fk_mov_inventario_detalle_mov foreign key(fk_id_movimiento_inventario) references MOVIMIENTO_INVENTARIO(pk_id_movimiento_inventario);
alter table MOVIMIENTO_INVENTARIO_DETALLE add constraint fk_mov_inventario_detalle_producto foreign key(fk_id_producto) references PRODUCTO(pk_id_producto);

###MRP---------------------------------------------------------------------------------------------
create table if not exists MATERIA_PRIMA(
    pk_id_materia_prima						int not null primary key auto_increment,
    fk_id_producto_materia_prima			int null,
    cantidad								int,
    estado_materia_prima					int
);
alter table MATERIA_PRIMA add constraint fk_materia_prima_producto foreign key (fk_id_producto_materia_prima) references PRODUCTO(pk_id_producto) on delete no action on update no action;

create table if not exists CONTROL_CALIDAD(#Falta una relacion 2.0
  pk_id_control_calidad						int(10) not null primary key auto_increment,
  fk_id_pedido_encabezado_control_calidad 	int not null,
  fk_id_empleado_control_calidad 			int(10) not null,-- responsable
  resultado_control_calidad					varchar(45),
  estado_control_calidad					int(2)
);
alter table CONTROL_CALIDAD add constraint fk_CONTROL_CALIDAD_PEDIDO_ENCABEZADO foreign key (fk_id_pedido_encabezado_control_calidad) references PEDIDO_ENCABEZADO (pk_id_pedido_encabezado)on delete no action on update no action;
#alter table CONTROL_CALIDAD add constraint fk_EMPLEADO_CONTROL_CALIDAD foreign key (fk_id_empleado_control_calidad) references EMPLEADO (pk_id_empleado)on delete no action on update no action;

create table if not exists ESTADO_PRODUCCION(
  pk_id_estado_produccion 					int(10) not null primary key auto_increment,
  nombre_estado_produccion 					varchar(45) null,
  duracion_estado_produccion				varchar(45) null,
  estado_estado_produccion					tinyint(1) null
);
create table if not exists CONTROL_PRODUCTO (
  pk_id_control_producto 					int(10) not null primary key auto_increment,
  fk_id_pedido_encabezado_control_producto 	int(10) null,
  fk_id_estado_produccion_control_producto	int(10) null,
  resultado_control_producto				varchar(45),
  estado_control_producto					int(2)
);
alter table CONTROL_PRODUCTO add constraint fk_CONTROL_PRODUCTO_ORDEN_PRODUCCION1 foreign key (fk_id_pedido_encabezado_control_producto) references PEDIDO_ENCABEZADO (pk_id_pedido_encabezado)on delete no action on update no action;
alter table CONTROL_PRODUCTO add constraint fk_CONTROL_PRODUCTO_ESTADO_PRODUCCION foreign key (fk_id_estado_produccion_control_producto) references ESTADO_PRODUCCION (pk_id_estado_produccion) on delete no action on update no action;

create table if not exists HORA_EMPLEADO (#Falta relacion con empleado
  pk_id_hora_empleado						int(10) not null primary key auto_increment,
  fk_id_empleado_hora_empleado				int(10) null,
  fk_id_pedido_encabezado_hora_empleado		int null,#porque se necesita orden de produccion?
  fecha_hora_empleado						date,
  estado_hora_empleado						tinyint(1)
);
alter table HORA_EMPLEADO add constraint fk_HORA_EMPLEADO_ORDEN_PRODUCCION1 foreign key (fk_id_pedido_encabezado_hora_empleado) references PEDIDO_ENCABEZADO (pk_id_pedido_encabezado) on delete no action on update no action;

create table if not exists DETALLE_HORA_EMPLEADO(
	pk_id_detalle_hora_empleado				int(10) not null primary key auto_increment,
    fk_id_hora_empleado_detalle				int(10),
    descripcion_detalle_hora_empleado		varchar(250),
    tiempo_detalle_hora_empleado			double,
    estado_detalle_hora_empleado			tinyint(1)
);
alter table DETALLE_HORA_EMPLEADO add constraint fk_HORA_EMPLEADO_DETALLE_HORA_EMPLEADO foreign key (fk_id_hora_empleado_detalle) references HORA_EMPLEADO(pk_id_hora_empleado) on delete no action on update no action;

create table if not exists ORDEN_COMPRA(
  pk_id_orden_compra 						int(10) not null primary key auto_increment,
  fk_id_producto_orden_compra			 	int null,
  fecha_envio_orden_compra			 		date null,
  cantidad_orden_compra 		 			int null,
  estado_orden_compra						tinyint(1) null
);
alter table ORDEN_COMPRA add constraint fk_ORDEN_COMPRA_PRODUCTO1 foreign key (fk_id_producto_orden_compra) references PRODUCTO (pk_id_producto) on delete no action on update no action;
alter table ORDEN_COMPRA modify fecha_envio_orden_compra varchar(50);

create table if not exists RECETAS_ENCABEZADO(
	pk_id_receta_encabezado			 			int(10) not null primary key auto_increment,
    descripcion_receta_encabezado				varchar(100),
	fk_id_producto_receta_encabezado			int(10),
	estado_encabezado_receta 						tinyint(1) null
);
alter table RECETAS_ENCABEZADO add constraint fk_recetas_encabezado_productos foreign key (fk_id_producto_receta_encabezado) references PRODUCTO (pk_id_producto) on delete no action on update no action;

create table if not exists DETALLE_RECETA(
   pk_id_detalle_detalle_receta 				int(10) not null primary key auto_increment,
   fk_id_receta_encabezado_detalle				int(10),
   fk_id_estado_produccion_detalle_receta		int(10), 
   fk_id_producto_detalle_receta				int(10),					
   cantidad_detalle_receta					    double,
   costo_unitario_detalle_receta  				double,
   estado_detalle_receta						tinyint(10)
);
alter table DETALLE_RECETA add constraint fk_detalle_receta_encabezado foreign key (fk_id_receta_encabezado_detalle) references RECETAS_ENCABEZADO (pk_id_receta_encabezado);
alter table DETALLE_RECETA add constraint fk_estado_produccion_detalle foreign key (fk_id_estado_produccion_detalle_receta) references ESTADO_PRODUCCION (pk_id_estado_produccion);
alter table DETALLE_RECETA add constraint fk_producto_detalle foreign key (fk_id_producto_detalle_receta) references PRODUCTO (pk_id_producto);

create table if not exists PRODUCTO_TERMINADO(
	pk_id_producto_terminado 					int(10) not null primary key auto_increment,
    fk_id_producto_producto_terminado			int(10) null,
    cantidad_producto_terminado					int null,
    estado_producto_terminado					tinyint
);
alter table PRODUCTO_TERMINADO add constraint fk_producto_terminado_producto foreign key (fk_id_producto_producto_terminado) references PRODUCTO(pk_id_producto);

#####RELACIONES-ENTRE-MODULOS----------------------------------------------------------------------
####RELACIONES-HRM---------------------------------------------------------------------------------
####RELACIONES-FRM---------------------------------------------------------------------------------
####RELACIONES-SCM---------------------------------------------------------------------------------
####RELACIONES-MRP---------------------------------------------------------------------------------
#alter table CONTROL_CALIDAD add constraint fk_EMPLEADOS_CONTROLCALIDAD1 foreign key (fk_id_responsable_control_calidad) references EMPLEADO (pk_id_empleado)on delete no action on update no action; 
####RELACIONES-CRM---------------------------------------------------------------------------------
#alter table VENTAS add constraint fk_VENTAS_PRODUCTO_SCM1 foreign key (fk_id_producto) references PRODUCTO(pk_id_producto) on delete no action on update no action;
#alter table DETALLES_VENTA_EMPLEADO add constraint `fk_VENTAS_has_EMPLEADOS HRM_EMPLEADOS HRM1` FOREIGN KEY (`fk_id_empleado`) REFERENCES EMPLEADO (`pk_id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION;
#alter table control_empleado add CONSTRAINT `fk_CONTROL_EMPLEADO_EMPLEADOS HRM1` FOREIGN KEY (`fk_id_empleado`) REFERENCES EMPLEADO (`pk_id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION;
#alter table pedidos_especiales add CONSTRAINT `fk_PEDIDOS_ESPECIALES_EMPLEADOS HRM1` FOREIGN KEY (`fk_id_empleado`) REFERENCES EMPLEADO (`pk_id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

######DATOS------------------------------------------------------------------------
######SEGURIDAD--------------------------------------------------------------------
INSERT INTO login VALUES 
('1', 'sistema', 'bi0PL96rbxVRPKJQsLJJAg==', 'Usuario de prueba', '1'),
('2', 'bjsican', '0FOYy5u5h0djKjzCYqfvkg==', 'Billy Sican', '1'),
('3', 'bmaza', 'xTfsC3/XR/CVyDvNr1Fs+g==', 'Bryan Mazariegos', '1'),
('4', 'jsican', 'jsican', 'Jeshua Sican', '0'),
('5', 'jmorataya', '123', 'Julio Morataya', '0'),
('6', 'admin', 'T+4Ai6O3CR0kJYxCgXy2jA==', 'Administrador', '1');


INSERT INTO `modulo` VALUES (1,'Seguridad','Aplicaciones de seguridad',1),(2,'Consultas','Consultas Inteligentes',1),
(3,'Reporteador','Aplicaciones de Reporteador',1),(4,'HRM','Aplicaciones de Recursos Humanos',1),
(5,'FRM','Aplicaciones de Finanzas',1),(6,'SCM','Aplicaciones Control de Inventario',1),(7,'MRP','Aplicaciones de Produccion',1),
(8,'CRM','Aplicaciones de Ventas',1);

INSERT INTO perfil VALUES 
('1', 'Admin', 'Administracion del programa', '1'),
('2', 'Sistema', 'Administrador del sistema', '1'),
('3', 'Digitador', 'Digitador para Cuentas', '1'),
('4', 'Consultor', 'Unicamente consultas ', '1'),
('5', 'Reportes', 'Ingreso y consultas de reportes', '1'),
('6', 'Pruebas', 'pruebas', '1'),
('7', 'Administrador', 'Administrador del MRP', '1');


INSERT INTO aplicacion VALUES 
('1', '1', 'Login', 'Ventana de Ingreso', '1'),
('2', '1', 'Mantenimiento Usuario', 'Mantenimientos de usuario', '1'),
('3', '1', 'Mantenimiento Aplicacion', 'ABC de las Aplicaciones', '1'),
('4', '1', 'Mantenimiento Perfil', 'ABC de perfiles', '1'),
('5', '1', 'Asignacion de Aplicaciones a Perfil', 'Asignacion Aplicacion y perfil', '1'),
('6', '1', 'Asignacaion de Aplicaciones', 'Asignacion especificas a un usuario', '1'),
('7', '1', 'Consulta Aplicacion', 'Mantenimiento de Aplicaciones', '1'),
('8', '1', 'Agregar Modulo', 'Mantenimientos de Modulos', '1'),
('9', '1', 'Consultar Perfil', 'Consultas de perfiles disponibles', '1'),
('10', '1', 'Permisos', 'Asignar permisos a perfiles y aplicaciones', '1'),
('11', '1', 'Cambio de Contraseña', 'Cambia las contraseñas', '1'),
('2301', '6', 'Linea Producto', 'lINEA', '1'),
('2302', '6', 'Categoria Producto', 'Categoria', '1'),
('2303', '6', 'Producto', 'Producto', '1'),
('2304', '6', 'Departamento', 'Deptos', '1'),
('2305', '6', 'Municipio', 'Muni depto', '1'),
('2306', '6', 'Ruta', 'Rutas', '1'),
('2307', '6', 'Proveedores', 'Nada', '1'),
('2308', '6', 'Telefono Proveedor', 'Telefonos ', '1'),
('2309', '6', 'Correo Proveedor', 'Correos', '1'),
('2310', '6', 'Pais', 'Pais de Proveedor', '1'),
('2311', '6', 'Marca', 'Contiene la Marca de Vehiculos', '1'),
('2312', '6', 'Vehiculo', 'Vehiculos usados para traslados', '1'),
('2313', '6', 'Bodega', 'Localizacion de bodegas', '1'),
('2314', '6', 'Encargado Bodega', 'Empleado dentro del area de bodegas', '1'),
('2315', '6', 'Tipo de Movimiento', 'Movimientos de Inventarios', '1'),
('2316', '6', 'Compras y Pedidos', 'Gestión de Órdenes de Compra y Pedido', '1'),
('2318', '6', 'Fabrica', 'Fabrica', '1'),
('3301', '7', 'MDI MRP', 'Ventana Principal MRP', '1'),
('3302', '7', 'Mantenimiento Producto', 'Mantenimiento de los productos', '1'),
('3303', '7', 'Mantenimiento de Categoria de produccion', 'Mantenimiento de Categoria de productos', '1'),
('3304', '7', 'Mantenimiento de Estado de Produccion', 'Mantenimiento de Estados de  produccion', '1'),
('3305', '7', 'Mantenimiento de Linea de produccion MRP', 'Mantenimiento de MRP para linea de producto', '1'),
('3306', '7', 'Mantenimiento de Encabezado de receta', 'Mantenimiento de MRP de reseta ', '1'),
('3307', '7', 'Mantenimiento de Detalle de Receta', 'Mantenimiento del detalle de la receta', '1'),
('3308', '7', 'Proceso Resepcion de pedidos especiales', 'Proceso para ingreso de pedidos', '1');



INSERT INTO permiso VALUES 
('1', '1', '1', '1', '1', '1'),
('2', '1', '0', '0', '1', '1'),
('3', '1', '1', '1', '0', '0'),
('4', '1', '1', '1', '1', '1'),
('5', '1', '1', '1', '1', '1'),
('6', '1', '1', '1', '1', '1'),
('7', '1', '1', '1', '1', '1'),
('8', '1', '0', '1', '0', '0'),
('9', '1', '1', '0', '0', '0'),
('10', '1', '1', '0', '0', '0'),
('11', '1', '1', '1', '1', '1'),
('12', '0', '0', '0', '1', '0'),
('13', '0', '0', '0', '1', '0'),
('14', '0', '0', '0', '0', '0'),
('15', '1', '0', '0', '1', '0'),
('16', '0', '0', '0', '0', '0'),
('17', '1', '1', '0', '0', '0'),
('18', '1', '1', '1', '1', '1'),
('19', '0', '1', '0', '0', '0'),
('20', '1', '1', '0', '0', '0'),
('21', '1', '1', '1', '0', '0');


INSERT INTO aplicacion_perfil VALUES 
('1', '1', '1', '1'),
('2', '4', '1', '2'),
('3', '5', '1', '3'),
('4', '2', '1', '4'),
('5', '3', '1', '5'),
('6', '6', '1', '6'),
('7', '8', '1', '7'),
('8', '2', '3', '8'),
('9', '3', '3', '9'),
('10', '4', '3', '11'),
('11', '2', '4', '12'),
('12', '8', '4', '13'),
('13', '8', '5', '15'),
('14', '8', '7', '21');

INSERT INTO aplicacion_usuario VALUES 
('1', '1', '4', '1'),
('2', '1', '5', '2'),
('3', '1', '6', '3'),
('4', '3', '8', '10'),
('5', '4', '6', '14'),
('6', '5', '5', '16'),
('7', '5', '2', '17'),
('8', '6', '3302', '18'),
('9', '6', '2', '19'),
('10', '6', '3', '20');

INSERT	INTO perfil_usuario VALUES
(1 , 1, 1),
(2 , 3,	3),
(4 , 4,	1),
(5, 5, 5);

############# Triggers MRP ------------------------------------------------------------------------------------------------------------
DELIMITER $$
CREATE TRIGGER ACONTROLPEDIDO BEFORE UPDATE ON pedido_encabezado
FOR EACH ROW
BEGIN
    IF (NEW.estado_proceso_pedido_encabezado = 4)  THEN BEGIN
   
   INSERT INTO control_producto 
(fk_id_pedido_encabezado_control_producto, fk_id_estado_produccion_control_producto, resultado_control_producto, estado_control_producto) 
VALUES (new.pk_id_pedido_encabezado , new.estado_proceso_pedido_encabezado," ", 1);

    END; END IF;
END$$
DELIMITER ;

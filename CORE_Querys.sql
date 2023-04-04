CREATE TABLE [ENTIDAD] (
  [id_entidad] int,
  [nombre] nvarchar(100),
  [descripcion] nvarchar(200),
  [created_at] datetime,
  [deleted_at] datetime,
  [updated_at] datetime,
  PRIMARY KEY ([id_entidad])
);

CREATE TABLE [ROLES] (
  [id_rol] int,
  [nombre] nvarchar(100),
  [descripcion] nvarchar(200),
  [created_at] datetime,
  [deleted_at] datetime,
  [updated_at] datetime,
  PRIMARY KEY ([id_rol])
);

CREATE TABLE [PERFILES] (
  [id_perfil] int,
  [nombre] nvarchar(200),
  [descripcion] nvarchar(200),
  [created_at] datetime,
  [deleted_at] datetime,
  [updated_at] datetime,
  [estado] bit,
  PRIMARY KEY ([id_perfil])
);

CREATE TABLE [PERFILES_ROLES] (
  [id_perfil] int,
  [id_rol] int,
  [id_entidad] int,
  [created_at] datetime,
  [deleted_at] datetime,
  [updated_at] datetime,
  PRIMARY KEY ([id_perfil], [id_rol], [id_entidad]),
  CONSTRAINT [FK_PERFILES_ROLES.id_entidad]
    FOREIGN KEY ([id_entidad])
      REFERENCES [ENTIDAD]([id_entidad]),
  CONSTRAINT [FK_PERFILES_ROLES.id_rol]
    FOREIGN KEY ([id_rol])
      REFERENCES [ROLES]([id_rol]),
  CONSTRAINT [FK_PERFILES_ROLES.id_perfil]
    FOREIGN KEY ([id_perfil])
      REFERENCES [PERFILES]([id_perfil])
);

CREATE TABLE [DOCTOR] (
  [id_doctor] int,
  [nombres] nvarchar(200),
  [apellidos] nvarchar(200),
  [created_at] datetime,
  [updated_at] datetime,
  [deleted_at] datetime,
  PRIMARY KEY ([id_doctor])
);

CREATE TABLE [CONSULTA] (
  [id_detalle] int,
  [id_doctor] int,
  [descripcion] nvarchar(200),
  [created_at] datetime,
  [updated_at] datetime,
  [deleted_at] datetime,
  PRIMARY KEY ([id_detalle]),
  CONSTRAINT [FK_CONSULTA.id_doctor]
    FOREIGN KEY ([id_doctor])
      REFERENCES [DOCTOR]([id_doctor])
);

CREATE TABLE [TIPO_SERVICIO] (
  [id_tipo] int,
  [nombre] varchar(50) ,
  [created_at] datetime,
  [updated_at] datetime,
  [deleted_at] datetime,
  PRIMARY KEY ([id_tipo])
);

CREATE TABLE [TIPO_SANGRE] (
  [id_tipo_sangre] int,
  [nombre] char(3),
  PRIMARY KEY ([id_tipo_sangre])
);

CREATE TABLE [TIPO_DOCUMENTO] (
  [id_tipo_documento] int,
  [nombre] nvarchar,
  PRIMARY KEY ([id_tipo_documento])
);

CREATE TABLE [NACIONALIDAD] (
  [id_nac] int,
  [nombre] nvarchar(100),
  PRIMARY KEY ([id_nac])
);

CREATE TABLE [PACIENTE] (
  [id_paciente] int,
  [id_tipo_sangre] int,
  [id_tipo_documento] int,
  [usuario] nvarchar(50),
  [clave] nvarchar(50),
  [sexo] char(1),
  [nombre] nvarchar(100),
  [apellido] nvarchar(100),
  [documento] nvarchar(20),
  [telefono] nvarchar(20),
  [id_nac] int,
  [email] nvarchar(150),
  [created_at] datetime,
  [updated_at] datetime,
  [deleted_at] datetime,
  [estado] bit,
  PRIMARY KEY ([id_paciente]),
  CONSTRAINT [FK_PACIENTE.id_tipo_sangre]
    FOREIGN KEY ([id_tipo_sangre])
      REFERENCES [TIPO_SANGRE]([id_tipo_sangre]),
  CONSTRAINT [FK_PACIENTE.id_tipo_documento]
    FOREIGN KEY ([id_tipo_documento])
      REFERENCES [TIPO_DOCUMENTO]([id_tipo_documento]),
  CONSTRAINT [FK_PACIENTE.id_nac]
    FOREIGN KEY ([id_nac])
      REFERENCES [NACIONALIDAD]([id_nac])
);

CREATE TABLE [SERVICIOS] (
  [id_servicio] int,
  [id_tipo] int,
  [descripcion] nvarchar(200),
  [precio] money,
  [impuesto] money,
  [created_at] datetime,
  [updated_at] datetime,
  [deleted_at] datetime,
  [estado] bit,
  PRIMARY KEY ([id_servicio]),
  CONSTRAINT [FK_SERVICIOS.id_tipo]
    FOREIGN KEY ([id_tipo])
      REFERENCES [TIPO_SERVICIO]([id_tipo])
);

CREATE TABLE [HISTORICO_PETICION] (
  [id_historico] int,
  [descripcion_peticion] nvarchar(200),
  [descripcion_respuesta] int,
  [canal] nvarchar(100),
  [fecha] datetime,
  [usuario] int,
  PRIMARY KEY ([id_historico])
);

CREATE TABLE [HABITACION] (
  [id] int,
  [codigo] nvarchar(3),
  [created_at] datetime,
  [updated_at] datetime,
  [deleted_at] datetime,
  [estado] bit,
  PRIMARY KEY ([id])
);

CREATE TABLE [INGRESOS] (
  [id_ingreso] int,
  [id_paciente] int,
  [id_habitacion] int,
  [created_at] datetime,
  [updated_at] datetime,
  [deleted_at] datetime,
  [fecha_inicio] datetime,
  [fecha_fin] datetime,
  [alta] bit,
  [monto_ingreso] money,
  [estado] bit,
  PRIMARY KEY ([id_ingreso]),
  CONSTRAINT [FK_INGRESOS.id_habitacion]
    FOREIGN KEY ([id_habitacion])
      REFERENCES [HABITACION]([id]),
  CONSTRAINT [FK_INGRESOS.id_paciente]
    FOREIGN KEY ([id_paciente])
      REFERENCES [PACIENTE]([id_paciente])
);

CREATE TABLE [METODO_PAGO] (
  [id] int,
  [nombre] nvarchar(200),
  PRIMARY KEY ([id])
);

CREATE TABLE [CUENTAS] (
  [id_cuenta] int,
  [id_paciente] int,
  [id_ingreso] int,
  [created_at] datetime,
  [updated_at] datetime,
  [deleted_at] datetime,
  [balance] money,
  [estado] bit,
  PRIMARY KEY ([id_cuenta]),
  CONSTRAINT [FK_CUENTAS.id_paciente]
    FOREIGN KEY ([id_paciente])
      REFERENCES [PACIENTE]([id_paciente])
);

CREATE TABLE [FACTURA] (
  [id_factura] int,
  [id_cuenta] int,
  [id_paciente] int,
  [id_cajero] int,
  [nombre] nvarchar(100),
  [sucursal] nvarchar(100),
  [id_metodo_pago] int,
  [created_at] datetime,
  [updated_at] datetime,
  [deleted_at] datetime,
  [total_bruto] money,
  [descuento] money,
  [total_autorizado] money,
  [total_final] money,
  [estado] bit,
  PRIMARY KEY ([id_factura]),
  CONSTRAINT [FK_FACTURA.id_metodo_pago]
    FOREIGN KEY ([id_metodo_pago])
      REFERENCES [METODO_PAGO]([id]),
  CONSTRAINT [FK_FACTURA.id_cuenta]
    FOREIGN KEY ([id_cuenta])
      REFERENCES [CUENTAS]([id_cuenta]),
  CONSTRAINT [FK_FACTURA.id_paciente]
    FOREIGN KEY ([id_paciente])
      REFERENCES [PACIENTE]([id_paciente])
);

CREATE TABLE [TRANSACCIONES] (
  [id_transaccion] int,
  [id_cuenta] int,
  [id_metodo_pago] int,
  [monto] money,
  [tipo_transaccion] bit,
  [descripcion] nvarchar(150),
  [fecha] datetime,
  PRIMARY KEY ([id_transaccion]),
  CONSTRAINT [FK_TRANSACCIONES.id_metodo_pago]
    FOREIGN KEY ([id_metodo_pago])
      REFERENCES [METODO_PAGO]([id]),
  CONSTRAINT [FK_TRANSACCIONES.id_cuenta]
    FOREIGN KEY ([id_cuenta])
      REFERENCES [CUENTAS]([id_cuenta])
);

CREATE TABLE [SUCURSAL] (
  [id_sucursal] int,
  [nombre] nvarchar(100),
  [direccion] nvarchar(100),
  PRIMARY KEY ([id_sucursal])
);

CREATE TABLE [USUARIO] (
  [id_usuario] int,
  [id_tipo_documento] int,
  [created_at] datetime,
  [updated_at] datetime,
  [deleted_at] datetime,
  [nombre] nvarchar(100),
  [apellido] nvarchar(100),
  [documento] nvarchar(100),
  [telefono] nvarchar(100),
  [email] nvarchar(100),
  [clave] nvarchar(50),
  [usuario] nvarchar(50),
  [estado] bit,
  [id_perfil] int,
  [id_sucursal] int,
  PRIMARY KEY ([id_usuario]),
  CONSTRAINT [FK_USUARIO.id_perfil]
    FOREIGN KEY ([id_perfil])
      REFERENCES [PERFILES]([id_perfil]),
  CONSTRAINT [FK_USUARIO.id_sucursal]
    FOREIGN KEY ([id_sucursal])
      REFERENCES [SUCURSAL]([id_sucursal]),
  CONSTRAINT [FK_USUARIO.id_tipo_documento]
    FOREIGN KEY ([id_tipo_documento])
      REFERENCES [TIPO_DOCUMENTO]([id_tipo_documento])
);

CREATE TABLE [AUTORIZACIONES] (
  [id_autorizacion] int,
  [monto_autorizado] money,
  [aseguradora] nvarchar(200),
  [created_at] datetime,
  [updated_at] datetime,
  [deleted_at] datetime,
  [estado] bit,
  PRIMARY KEY ([id_autorizacion])
);

CREATE TABLE [FACTURA_SERVICIOS] (
  [id_detalle] int,
  [id_factura] int,
  [id_servicio] int,
  [precio_unidad] money,
  [cantidad] int,
  [impuesto] money,
  [descuento] money,
  [id_autorizacion] int,
  [total_bruto] money,
  [total_impuesto] money,
  [total_autorizado] money,
  [total_final] money,
  [created_at] datetime,
  [updated_at] datetime,
  [deleted_at] datetime,
  [descripcion] nvarchar(200),
  PRIMARY KEY ([id_detalle]),
  CONSTRAINT [FK_FACTURA_SERVICIOS.id_factura]
    FOREIGN KEY ([id_factura])
      REFERENCES [FACTURA]([id_factura]),
  CONSTRAINT [FK_FACTURA_SERVICIOS.id_autorizacion]
    FOREIGN KEY ([id_autorizacion])
      REFERENCES [AUTORIZACIONES]([id_autorizacion]),
  CONSTRAINT [FK_FACTURA_SERVICIOS.id_servicio]
    FOREIGN KEY ([id_servicio])
      REFERENCES [SERVICIOS]([id_servicio])
);

CREATE TABLE [HISTORICO_ACCIONES] (
  [id_historico] int,
  [descripcion] nvarchar(200),
  [id_usuario] int,
  [fecha] datetime,
  PRIMARY KEY ([id_historico]),
  CONSTRAINT [FK_HISTORICO_ACCIONES.id_usuario]
    FOREIGN KEY ([id_usuario])
      REFERENCES [USUARIO]([id_usuario])
);

CREATE TABLE [Log4NetLog] (
  [id] int,
  [date] datetime,
  [thread] varchar(255),
  [level] varchar(50),
  [logger] varchar(255),
  [message] varchar(4000),
  [*exception] varchar(2000),
  PRIMARY KEY ([id])
);
--USAR LA BASE DE DATOS--
USE DB6
GO


--CREACIÓN DE LAS TABLAS--
CREATE TABLE tbl_mrp_proceso_produccion (
                id_proceso_produccion INT IDENTITY NOT NULL,
                ppd_nombre VARCHAR(100) NOT NULL,
                ppd_descripcion VARCHAR(256) NOT NULL,
                ppd_destinatario VARCHAR(256) NOT NULL,
                ppd_fecha_solicitud DATETIME NOT NULL,
                ppd_fecha_inicio DATETIME NOT NULL,
                ppd_fecha_final DATETIME NOT NULL,
                ppd_fecha_entrega DATETIME NOT NULL,
                ppd_total DECIMAL(18,2) NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_ppd PRIMARY KEY (id_proceso_produccion)
)

CREATE TABLE tbl_mrp_gasto_tipo (
                id_gasto_tipo INT IDENTITY NOT NULL,
                gtt_descripcion VARCHAR(100) NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_gtt PRIMARY KEY (id_gasto_tipo)
)

CREATE TABLE tbl_mrp_gasto (
                id_gasto INT IDENTITY NOT NULL,
                id_gasto_tipo INT NOT NULL,
                gst_nombre VARCHAR(100) NOT NULL,
                gst_descripcion VARCHAR(256) NOT NULL,
                gst_factor DECIMAL(18,6) NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_gst PRIMARY KEY (id_gasto)
)

CREATE TABLE tbl_mrp_gasto_periodo (
                id_gasto_periodo INT IDENTITY NOT NULL,
                id_gasto INT NOT NULL,
                gtp_anio INT NOT NULL,
                gtp_mes INT NOT NULL,
                gtp_valor DECIMAL(18,2) NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_gsp PRIMARY KEY (id_gasto_periodo)
)

CREATE TABLE tbl_mrp_nomina_periodo (
                id_nomina_periodo INT IDENTITY NOT NULL,
                nmp_descripcion VARCHAR(100) NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_nmp PRIMARY KEY (id_nomina_periodo)
)

CREATE TABLE tbl_mrp_nomina (
                id_nomina INT IDENTITY NOT NULL,
                id_nomina_periodo INT NOT NULL,
                nmn_descripcion VARCHAR(100) NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_nmn PRIMARY KEY (id_nomina)
)

CREATE TABLE tbl_mrp_departamento (
                id_departamento INT IDENTITY NOT NULL,
                dpt_nombre VARCHAR(100) NOT NULL,
                dpt_descripcion VARCHAR(256) NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_dpt PRIMARY KEY (id_departamento)
)

CREATE TABLE tbl_mrp_puesto (
                id_puesto INT IDENTITY NOT NULL,
                pst_nombre VARCHAR(100) NOT NULL,
                pst_descripcion VARCHAR(256) NOT NULL,
                pst_ocupacion VARCHAR(100) NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_pst PRIMARY KEY (id_puesto)
)

CREATE TABLE tbl_mrp_status (
                id_status INT IDENTITY NOT NULL,
                sts_descripcion VARCHAR(100) NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_sts PRIMARY KEY (id_status)
)

CREATE TABLE tbl_mrp_solicitud (
                id_solicitud INT IDENTITY NOT NULL,
                sol_nombre VARCHAR(100) NOT NULL,
                sol_descripcion VARCHAR(256) NOT NULL,
                sol_fecha_solicitud DATETIME NOT NULL,
                sol_fecha_entrega DATETIME NOT NULL,
                id_status INT NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_sol PRIMARY KEY (id_solicitud)
)

CREATE TABLE tbl_mrp_tarea_tipo (
                id_tarea_tipo INT IDENTITY NOT NULL,
                ttp_descripcion VARCHAR(100) NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_ttp PRIMARY KEY (id_tarea_tipo)
)

CREATE TABLE tbl_mrp_medida (
                id_medida INT IDENTITY NOT NULL,
                mdd_nombre VARCHAR(100) NOT NULL,
                mdd_descripcion VARCHAR(256) NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_mdd PRIMARY KEY (id_medida)
)

CREATE TABLE tbl_mrp_movimiento_tipo (
                id_movimiento_tipo INT IDENTITY NOT NULL,
                mtp_descripcion VARCHAR(100) NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_mtp PRIMARY KEY (id_movimiento_tipo)
)

CREATE TABLE tbl_mrp_inventario_tipo (
                id_inventario_tipo INT IDENTITY NOT NULL,
                ivt_descripcion VARCHAR(100) NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_icl PRIMARY KEY (id_inventario_tipo)
)

CREATE TABLE tbl_mrp_inventario (
                id_inventario INT IDENTITY NOT NULL,
                id_inventario_tipo INT NOT NULL,
                inv_nombre VARCHAR(100) NOT NULL,
                inv_descripcion VARCHAR(256) NOT NULL,
                inv_fecha_creacion DATETIME NOT NULL,
                id_medida INT NOT NULL,
                inv_precio DECIMAL(18,2) NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_inv PRIMARY KEY (id_inventario)
)

CREATE TABLE tbl_mrp_proprod_inventario (
                id_proprod_inventario INT IDENTITY NOT NULL,
                id_proceso_produccion INT NOT NULL,
                id_inventario INT NOT NULL,
                ppi_cantidad DECIMAL(18,6) NOT NULL,
                CONSTRAINT pk_ppi PRIMARY KEY (id_proprod_inventario)
)

CREATE TABLE tbl_mrp_solicitud_inventario (
                id_solicitud_inventario INT NOT NULL,
                id_solicitud INT NOT NULL,
                siv_cantidad_solicitada DECIMAL(18,6) NOT NULL,
                siv_cantidad_entregada DECIMAL(18,6) NOT NULL,
                id_inventario INT NOT NULL,
                CONSTRAINT pk_siv PRIMARY KEY (id_solicitud_inventario)
)

CREATE TABLE tbl_mrp_bodega (
                id_bodega INT IDENTITY NOT NULL,
                bdg_nombre VARCHAR(100) NOT NULL,
                bdg_descripcion VARCHAR(256) NOT NULL,
                bdg_fecha_creacion DATETIME NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_bdg PRIMARY KEY (id_bodega)
)

CREATE TABLE tbl_mrp_movimiento (
                id_movimiento INT IDENTITY NOT NULL,
                id_movimiento_tipo INT NOT NULL,
                id_bodega INT NOT NULL,
                mov_numero INT NOT NULL,
                mov_fecha DATETIME NOT NULL,
                mov_descripcion VARCHAR(256) NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_mov PRIMARY KEY (id_movimiento)
)

CREATE TABLE tbl_mrp_movimiento_inventario (
                id_movimiento_inventario INT IDENTITY NOT NULL,
                id_movimiento INT NOT NULL,
                id_inventario INT NOT NULL,
                mvi_cantidad DECIMAL(18,6) NOT NULL,
                CONSTRAINT pk_mvi PRIMARY KEY (id_movimiento_inventario)
)

CREATE TABLE tbl_mrp_orden_produccion (
                id_orden_produccion INT IDENTITY NOT NULL,
                orp_fecha DATETIME NOT NULL,
                id_proceso_produccion INT NOT NULL,
                id_status INT NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_orp PRIMARY KEY (id_orden_produccion)
)

CREATE TABLE tbl_mrp_tarea (
                id_tarea INT IDENTITY NOT NULL,
                id_tarea_tipo INT NOT NULL,
                tar_nombre VARCHAR(100) NOT NULL,
                tar_descripcion VARCHAR(256) NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_tar PRIMARY KEY (id_tarea)
)

CREATE TABLE tbl_mrp_recetario (
                id_recetario INT IDENTITY NOT NULL,
                id_inventario INT NOT NULL,
                rct_descripcion VARCHAR(256) NOT NULL,
                rct_fecha_creacion DATETIME NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_rct PRIMARY KEY (id_recetario)
)

CREATE TABLE tbl_mrp_ordprod_inventario (
                id_orden_produccion_inventario INT IDENTITY NOT NULL,
                id_orden_produccion INT NOT NULL,
                id_inventario INT NOT NULL,
                id_recetario INT NOT NULL,
                opi_cantidad DECIMAL(18,6) NOT NULL,
                opi_costo_unitario DECIMAL(18,2) NOT NULL,
                opi_costo_total DECIMAL(18,2) NOT NULL,
                CONSTRAINT pk_opi PRIMARY KEY (id_orden_produccion_inventario)
)

CREATE TABLE tbl_mrp_ordprod_gf (
                id_ordprod_gf INT IDENTITY NOT NULL,
                id_orden_produccion_inventario INT NOT NULL,
                id_gasto INT NOT NULL,
                ogf_valor_total DECIMAL(18,2) NOT NULL,
                CONSTRAINT pk_ogf PRIMARY KEY (id_ordprod_gf)
)

CREATE TABLE tbl_mrp_ordprod_mp (
                id_ordprod_mp INT IDENTITY NOT NULL,
                id_orden_produccion_inventario INT NOT NULL,
                id_inventario INT NOT NULL,
                omp_cantidad_necesaria DECIMAL(18,6) NOT NULL,
                omp_costo_unitario DECIMAL(18,2) NOT NULL,
                omp_cantidad DECIMAL(18,6) NOT NULL,
                omp_costo_total DECIMAL(18,2) NOT NULL,
                CONSTRAINT pk_omp PRIMARY KEY (id_ordprod_mp)
)

CREATE TABLE tbl_mrp_recetario_tarea (
                id_recetario_tarea INT IDENTITY NOT NULL,
                id_recetario INT NOT NULL,
                id_tarea INT NOT NULL,
                rta_duracion_horas DECIMAL(18,6) NOT NULL,
                CONSTRAINT pk_rta PRIMARY KEY (id_recetario_tarea)
)

CREATE TABLE tbl_mrp_recetario_inventario (
                id_recetario_inventario INT IDENTITY NOT NULL,
                id_recetario INT NOT NULL,
                id_inventario INT NOT NULL,
                riv_cantidad DECIMAL(18,6) NOT NULL,
                riv_precio_unitario DECIMAL(18,2) NOT NULL,
                riv_precio_total DECIMAL(18,2) NOT NULL,
                CONSTRAINT pk_riv PRIMARY KEY (id_recetario_inventario)
)

CREATE TABLE tbl_mrp_pais (
                id_pais INT IDENTITY NOT NULL,
                pas_descripcion VARCHAR(100) NOT NULL,
                pas_gentilicio VARCHAR(100) NOT NULL,
                pas_identificacion_tributaria VARCHAR(100) NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_pais PRIMARY KEY (id_pais)
)

CREATE TABLE tbl_mrp_empleado (
                id_empleado INT IDENTITY NOT NULL,
                emp_primer_nombre VARCHAR(100) NOT NULL,
                emp_segundo_nombre VARCHAR(100) NOT NULL,
                emp_primer_apellido VARCHAR(100) NOT NULL,
                emp_segundo_apellido VARCHAR(100) NOT NULL,
                emp_identificacion_tipo VARCHAR(32) NOT NULL,
                emp_identificacion VARCHAR(32) NOT NULL,
                id_pais INT NOT NULL,
                emp_fecha_nacimiento DATETIME NOT NULL,
                emp_fecha_ingreso DATETIME NOT NULL,
                emp_direccion VARCHAR(256) NOT NULL,
                emp_telefono VARCHAR(32) NOT NULL,
                emp_email VARCHAR(100) NOT NULL,
                emp_genero VARCHAR(1) NOT NULL,
                emp_profesion VARCHAR(100) NOT NULL,
                emp_identificacion_tributaria VARCHAR(16) NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_emp PRIMARY KEY (id_empleado)
)

CREATE TABLE tbl_mrp_empleado_nomina (
                id_empleado_nomina INT IDENTITY NOT NULL,
                id_empleado INT NOT NULL,
                id_nomina INT NOT NULL,
                id_departamento INT NOT NULL,
                id_puesto INT NOT NULL,
                emn_fecha_ingreso DATETIME NOT NULL,
                emn_salario_ordinario DECIMAL(18,2) NOT NULL,
                emn_valor_hora_ordinaria DECIMAL(18,2) NOT NULL,
                enm_valor_hora_extraordinaria DECIMAL(18,2) NOT NULL,
                id_empresa INT NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_emn PRIMARY KEY (id_empleado_nomina)
)

CREATE TABLE tbl_mrp_ordprod_mo (
                id_ordprod_mo INT IDENTITY NOT NULL,
                id_orden_produccion_inventario INT NOT NULL,
                id_tarea INT NOT NULL,
                id_empleado_nomina INT NOT NULL,
                omo_horas_requeridas DECIMAL(18,6) NOT NULL,
                omo_costo_hora DECIMAL(18,2) NOT NULL,
                omo_cantidad DECIMAL(18,6) NOT NULL,
                omo_costo_total DECIMAL(18,2) NOT NULL,
                CONSTRAINT pk_omo PRIMARY KEY (id_ordprod_mo)
)

CREATE TABLE tbl_mrp_usuario (
                id_usuario INT IDENTITY NOT NULL,
                usr_nombre VARCHAR(100) NOT NULL,
                usr_usuario VARCHAR(32) NOT NULL,
                usr_contrasena VARCHAR(100) NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_usuario PRIMARY KEY (id_usuario)
)

CREATE TABLE tbl_mrp_moneda (
                id_moneda INT IDENTITY NOT NULL,
                mnd_descripcion VARCHAR(100) NOT NULL,
                mnd_simbolo VARCHAR(5) NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_moneda PRIMARY KEY (id_moneda)
)

CREATE TABLE tbl_mrp_empresa (
                id_empresa INT IDENTITY NOT NULL,
                emp_nombre VARCHAR(256) NOT NULL,
                emp_razon_social VARCHAR(256) NOT NULL,
                emp_descripcion VARCHAR(256) NOT NULL,
                id_pais INT NOT NULL,
                id_moneda INT NOT NULL,
                emp_identificacion_tributaria VARCHAR(16) NOT NULL,
                emp_direccion VARCHAR(256) NOT NULL,
                emp_telefono VARCHAR(32) NOT NULL,
                id_estado INT NOT NULL,
                CONSTRAINT pk_empresa PRIMARY KEY (id_empresa)
)

CREATE TABLE tbl_mrp_usuario_empresa (
                id_usuario_empresa INT IDENTITY NOT NULL,
                id_usuario INT NOT NULL,
                id_empresa INT NOT NULL,
                CONSTRAINT pk_usuario_empresa PRIMARY KEY (id_usuario_empresa)
)

CREATE TABLE tbl_mrp_recetario_gasto (
                id_recetario_gasto INT IDENTITY NOT NULL,
                id_recetario INT NOT NULL,
                id_gasto INT NOT NULL,
                CONSTRAINT pk_rgt PRIMARY KEY (id_recetario_gasto)
)


--CREACIÓN DE RELACIONES EN LAS TABLAS--
ALTER TABLE tbl_mrp_recetario_gasto ADD CONSTRAINT tbl_mrp_gasto_tbl_mrp_recetario_gasto_fk
FOREIGN KEY (id_gasto)
REFERENCES tbl_mrp_gasto (id_gasto)

ALTER TABLE tbl_mrp_recetario_gasto ADD CONSTRAINT tbl_mrp_recetario_tbl_mrp_recetario_gasto_fk
FOREIGN KEY (id_recetario)
REFERENCES tbl_mrp_recetario (id_recetario)

ALTER TABLE tbl_mrp_orden_produccion ADD CONSTRAINT tbl_mrp_proceso_produccion_tbl_mrp_orden_produccion_fk
FOREIGN KEY (id_proceso_produccion)
REFERENCES tbl_mrp_proceso_produccion (id_proceso_produccion)

ALTER TABLE tbl_mrp_proprod_inventario ADD CONSTRAINT tbl_mrp_proceso_produccion_tbl_mrp_proprod_inventario_fk
FOREIGN KEY (id_proceso_produccion)
REFERENCES tbl_mrp_proceso_produccion (id_proceso_produccion)

ALTER TABLE tbl_mrp_gasto ADD CONSTRAINT tbl_mrp_gasto_tipo_tbl_mrp_gasto_fk
FOREIGN KEY (id_gasto_tipo)
REFERENCES tbl_mrp_gasto_tipo (id_gasto_tipo)

ALTER TABLE tbl_mrp_gasto_periodo ADD CONSTRAINT tbl_mrp_gasto_tbl_mrp_gasto_periodo_fk
FOREIGN KEY (id_gasto)
REFERENCES tbl_mrp_gasto (id_gasto)

ALTER TABLE tbl_mrp_ordprod_gf ADD CONSTRAINT tbl_mrp_gasto_tbl_mrp_ordprod_gf_fk
FOREIGN KEY (id_gasto)
REFERENCES tbl_mrp_gasto (id_gasto)

ALTER TABLE tbl_mrp_nomina ADD CONSTRAINT tbl_mrp_nomina_periodo_tbl_mrp_nomina_fk
FOREIGN KEY (id_nomina_periodo)
REFERENCES tbl_mrp_nomina_periodo (id_nomina_periodo)

ALTER TABLE tbl_mrp_empleado_nomina ADD CONSTRAINT tbl_mrp_nomina_tbl_mrp_empleado_nomina_fk
FOREIGN KEY (id_nomina)
REFERENCES tbl_mrp_nomina (id_nomina)

ALTER TABLE tbl_mrp_empleado_nomina ADD CONSTRAINT tbl_mrp_departamento_tbl_mrp_empleado_nomina_fk
FOREIGN KEY (id_departamento)
REFERENCES tbl_mrp_departamento (id_departamento)

ALTER TABLE tbl_mrp_empleado_nomina ADD CONSTRAINT tbl_mrp_puesto_tbl_mrp_empleado_nomina_fk
FOREIGN KEY (id_puesto)
REFERENCES tbl_mrp_puesto (id_puesto)

ALTER TABLE tbl_mrp_solicitud ADD CONSTRAINT tbl_mrp_status_tbl_mrp_solicitud_fk
FOREIGN KEY (id_status)
REFERENCES tbl_mrp_status (id_status)

ALTER TABLE tbl_mrp_orden_produccion ADD CONSTRAINT tbl_mrp_status_tbl_mrp_orden_produccion_fk
FOREIGN KEY (id_status)
REFERENCES tbl_mrp_status (id_status)

ALTER TABLE tbl_mrp_solicitud_inventario ADD CONSTRAINT tbl_mrp_solicitud_tbl_mrp_solicitud_inventario_fk
FOREIGN KEY (id_solicitud)
REFERENCES tbl_mrp_solicitud (id_solicitud)

ALTER TABLE tbl_mrp_tarea ADD CONSTRAINT tbl_mrp_tarea_tipo_tbl_mrp_tarea_fk
FOREIGN KEY (id_tarea_tipo)
REFERENCES tbl_mrp_tarea_tipo (id_tarea_tipo)

ALTER TABLE tbl_mrp_inventario ADD CONSTRAINT tbl_mrp_medida_tbl_mrp_inventario_fk
FOREIGN KEY (id_medida)
REFERENCES tbl_mrp_medida (id_medida)

ALTER TABLE tbl_mrp_movimiento ADD CONSTRAINT tbl_mrp_movimiento_tipo_tbl_mrp_movimiento_fk
FOREIGN KEY (id_movimiento_tipo)
REFERENCES tbl_mrp_movimiento_tipo (id_movimiento_tipo)

ALTER TABLE tbl_mrp_inventario ADD CONSTRAINT tbl_mrp_clasificacion_inventario_tbl_mrp_inventario_fk
FOREIGN KEY (id_inventario_tipo)
REFERENCES tbl_mrp_inventario_tipo (id_inventario_tipo)

ALTER TABLE tbl_mrp_recetario_inventario ADD CONSTRAINT tbl_mrp_inventario_tbl_mrp_recetario_matprima_fk
FOREIGN KEY (id_inventario)
REFERENCES tbl_mrp_inventario (id_inventario)

ALTER TABLE tbl_mrp_movimiento_inventario ADD CONSTRAINT tbl_mrp_inventario_tbl_mrp_movimiento_inventario_fk
FOREIGN KEY (id_inventario)
REFERENCES tbl_mrp_inventario (id_inventario)

ALTER TABLE tbl_mrp_recetario ADD CONSTRAINT tbl_mrp_inventario_tbl_mrp_recetario_fk
FOREIGN KEY (id_inventario)
REFERENCES tbl_mrp_inventario (id_inventario)

ALTER TABLE tbl_mrp_solicitud_inventario ADD CONSTRAINT tbl_mrp_inventario_tbl_mrp_solicitud_inventario_fk
FOREIGN KEY (id_inventario)
REFERENCES tbl_mrp_inventario (id_inventario)

ALTER TABLE tbl_mrp_proprod_inventario ADD CONSTRAINT tbl_mrp_inventario_tbl_mrp_proprod_inventario_fk
FOREIGN KEY (id_inventario)
REFERENCES tbl_mrp_inventario (id_inventario)

ALTER TABLE tbl_mrp_ordprod_inventario ADD CONSTRAINT tbl_mrp_inventario_tbl_mrp_ordprod_inventario_fk
FOREIGN KEY (id_inventario)
REFERENCES tbl_mrp_inventario (id_inventario)

ALTER TABLE tbl_mrp_ordprod_mp ADD CONSTRAINT tbl_mrp_inventario_tbl_mrp_ordprod_mp_fk
FOREIGN KEY (id_inventario)
REFERENCES tbl_mrp_inventario (id_inventario)

ALTER TABLE tbl_mrp_movimiento ADD CONSTRAINT tbl_mrp_bodega_tbl_mrp_movimiento_fk
FOREIGN KEY (id_bodega)
REFERENCES tbl_mrp_bodega (id_bodega)

ALTER TABLE tbl_mrp_movimiento_inventario ADD CONSTRAINT tbl_mrp_movimiento_tbl_mrp_movimiento_inventario_fk
FOREIGN KEY (id_movimiento)
REFERENCES tbl_mrp_movimiento (id_movimiento)

ALTER TABLE tbl_mrp_ordprod_inventario ADD CONSTRAINT tbl_mrp_orden_produccion_tbl_mrp_ordprod_inventario_fk
FOREIGN KEY (id_orden_produccion)
REFERENCES tbl_mrp_orden_produccion (id_orden_produccion)

ALTER TABLE tbl_mrp_recetario_tarea ADD CONSTRAINT tbl_mrp_tarea_tbl_mrp_recetario_tarea_fk
FOREIGN KEY (id_tarea)
REFERENCES tbl_mrp_tarea (id_tarea)

ALTER TABLE tbl_mrp_ordprod_mo ADD CONSTRAINT tbl_mrp_tarea_tbl_mrp_ordprod_mo_fk
FOREIGN KEY (id_tarea)
REFERENCES tbl_mrp_tarea (id_tarea)

ALTER TABLE tbl_mrp_recetario_inventario ADD CONSTRAINT tbl_mrp_recetario_mrp_recetario_matprima_fk
FOREIGN KEY (id_recetario)
REFERENCES tbl_mrp_recetario (id_recetario)

ALTER TABLE tbl_mrp_recetario_tarea ADD CONSTRAINT tbl_mrp_recetario_tbl_mrp_recetario_tarea_fk
FOREIGN KEY (id_recetario)
REFERENCES tbl_mrp_recetario (id_recetario)

ALTER TABLE tbl_mrp_ordprod_inventario ADD CONSTRAINT tbl_mrp_recetario_tbl_mrp_ordprod_inventario_fk
FOREIGN KEY (id_recetario)
REFERENCES tbl_mrp_recetario (id_recetario)

ALTER TABLE tbl_mrp_ordprod_mp ADD CONSTRAINT tbl_mrp_ordprod_inventario_tbl_mrp_ordprod_mp_fk
FOREIGN KEY (id_orden_produccion_inventario)
REFERENCES tbl_mrp_ordprod_inventario (id_orden_produccion_inventario)

ALTER TABLE tbl_mrp_ordprod_mo ADD CONSTRAINT tbl_mrp_ordprod_inventario_tbl_mrp_ordprod_mo_fk
FOREIGN KEY (id_orden_produccion_inventario)
REFERENCES tbl_mrp_ordprod_inventario (id_orden_produccion_inventario)

ALTER TABLE tbl_mrp_ordprod_gf ADD CONSTRAINT tbl_mrp_ordprod_inventario_tbl_mrp_ordprod_gf_fk
FOREIGN KEY (id_orden_produccion_inventario)
REFERENCES tbl_mrp_ordprod_inventario (id_orden_produccion_inventario)

ALTER TABLE tbl_mrp_empresa ADD CONSTRAINT FK_emp_pais
FOREIGN KEY (id_pais)
REFERENCES tbl_mrp_pais (id_pais)

ALTER TABLE tbl_mrp_empleado ADD CONSTRAINT tbl_mrp_pais_tbl_mrp_empleado_fk
FOREIGN KEY (id_pais)
REFERENCES tbl_mrp_pais (id_pais)

ALTER TABLE tbl_mrp_empleado_nomina ADD CONSTRAINT tbl_mrp_empleado_tbl_mrp_empleado_detalle_fk
FOREIGN KEY (id_empleado)
REFERENCES tbl_mrp_empleado (id_empleado)

ALTER TABLE tbl_mrp_ordprod_mo ADD CONSTRAINT tbl_mrp_empleado_nomina_tbl_mrp_ordprod_mo_fk
FOREIGN KEY (id_empleado_nomina)
REFERENCES tbl_mrp_empleado_nomina (id_empleado_nomina)

ALTER TABLE tbl_mrp_usuario_empresa ADD CONSTRAINT FK_uem_usuario
FOREIGN KEY (id_usuario)
REFERENCES tbl_mrp_usuario (id_usuario)

ALTER TABLE tbl_mrp_empresa ADD CONSTRAINT FK_emp_moneda
FOREIGN KEY (id_moneda)
REFERENCES tbl_mrp_moneda (id_moneda)

ALTER TABLE tbl_mrp_usuario_empresa ADD CONSTRAINT FK_uem_empresa
FOREIGN KEY (id_empresa)
REFERENCES tbl_mrp_empresa (id_empresa)


--CREACIÓN DEL STORED PROCEDURED PARA GENERAR LAS ÓRDENES DE PRODUCCIÓN--
CREATE PROCEDURE proc_generar_orden_produccion
	@IdProcesoProduccion INT,
	@IdEmpresa INT
AS
BEGIN
	DECLARE @Fecha DATE, @IdOrdenProduccion INT, @IdRecetario INT, @cu_IdInventario INT, @cu_Cantidad DECIMAL(18,6)
	SET @Fecha = (SELECT CONVERT(DATE, GETDATE()))
	
	INSERT INTO tbl_mrp_orden_produccion (orp_fecha,id_proceso_produccion,id_status,id_empresa,id_estado)
	VALUES (@Fecha,@IdProcesoProduccion,1,@IdEmpresa,1)

	SET @IdOrdenProduccion=(SELECT IDENT_CURRENT('tbl_mrp_orden_produccion')) 

	DECLARE cursor_inventario CURSOR FOR
		SELECT id_inventario,ppi_cantidad
		FROM tbl_mrp_proprod_inventario
		WHERE id_proceso_produccion=@IdProcesoProduccion
	OPEN cursor_inventario
	FETCH NEXT FROM cursor_inventario INTO @cu_IdInventario, @cu_Cantidad
	WHILE @@FETCH_STATUS=0
	BEGIN
		SET @IdREcetario = (SELECT TOP 1 id_recetario FROM tbl_mrp_recetario WHERE id_inventario=@cu_IdInventario AND id_empresa=@IdEmpresa AND id_estado=1)

		INSERT INTO tbl_mrp_ordprod_inventario (id_orden_produccion, id_inventario, id_recetario, opi_cantidad,opi_costo_unitario, opi_costo_total)
		VALUES (@IdOrdenProduccion,@cu_IdInventario,@IdRecetario,@cu_Cantidad,0,0)
		FETCH NEXT FROM cursor_inventario
		INTO @cu_IdInventario, @cu_Cantidad
	END
	CLOSE cursor_inventario;
	DEALLOCATE cursor_inventario;
END


--ESTABLECER PERMISOS A LOS STORED PROCEDURED--
GRANT EXEC ON DB6.dbo.proc_generar_orden_produccion TO db6admin


--REINICIO DEL IDENTITY--
--DBCC CHECKIDENT ('tbl_mrp_pais', RESEED, 0)
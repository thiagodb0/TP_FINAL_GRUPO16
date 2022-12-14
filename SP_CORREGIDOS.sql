USE [AUTOMOTRIZ]
GO
/****** Object:  StoredProcedure [dbo].[PromedioMes]    Script Date: 24/10/2022 20:04:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PromedioMes]
@anio1 int,
@anio2 int
as
 select year(fecha) 'Año', month(fecha) 'Mes', sum(cantidad * precio_venta) 'Total', 
 sum(cantidad*precio_venta) / count(distinct f.cod_factura) 'Promedio'
 from factura f join detalle_factura df on df.cod_factura = f.cod_factura
 where YEAR(fecha) between @anio1 and @anio2
 group by year(fecha), month(fecha)
 having (sum(cantidad*precio_venta) / count(distinct f.cod_factura)) <
 (select sum(cantidad*precio_venta) / count(distinct f1.cod_factura) 
 from detalle_factura d join factura f1 on d.cod_factura = f1.cod_factura)
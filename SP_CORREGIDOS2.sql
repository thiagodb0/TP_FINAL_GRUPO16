USE [AUTOMOTRIZ]
GO
/****** Object:  StoredProcedure [dbo].[FacturadoXVendedor]    Script Date: 24/10/2022 20:04:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[FacturadoXVendedor]
as
select year(fecha) 'Año', month(fecha) 'Mes',v.apellido+' '+v.nombre 
'Vendedor',sum(cantidad * precio_venta) 'Total', 
sum(cantidad*precio_venta) / count(distinct f.cod_factura) 'Promedio'
from factura f join detalle_factura df on df.cod_factura = f.cod_factura
join Vendedores v on v.cod_Vendedor=f.cod_vendedor
group by year(fecha), month(fecha),v.cod_vendedor,v.apellido+' '+v.nombre 
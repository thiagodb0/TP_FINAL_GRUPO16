USE [AUTOMOTRIZ]
GO
/****** Object:  StoredProcedure [dbo].[FechaVendedores]    Script Date: 24/10/2022 20:03:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[FechaVendedores]
@cod int
as
select v.nombre + ' ' +v.apellido 'Nombre',min(fecha)'Primera',max(fecha) 'Ultima'
from factura f join detalle_factura df on
f.cod_factura=df.cod_factura
join vendedores v on v.cod_vendedor=f.cod_vendedor
where f.cod_vendedor =  @cod
group by v.nombre,v.apellido 
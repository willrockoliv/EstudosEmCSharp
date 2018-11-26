create procedure spConsultaJogo( @id int )
as
begin
   select * from jogos where id = @id
end

GO

create procedure spIncluiOuAteraJogo(
		@id int, 
		@descricao varchar(max),
		@valor_locacao decimal(18,2),
		@categoriaId int,
		@dataCompra date)
as
begin
   if (exists(select id from jogos where id = @id))
   begin
      update jogos set descricao = @descricao, valor_locacao = @valor_locacao,
	  data_aquisicao = @dataCompra, @categoriaId = @categoriaId
	  where id = @id;
   end
   else
   begin  
     insert into  jogos (id, descricao, valor_locacao, data_aquisicao, categoriaId)       
      values  (@id, @descricao, @valor_locacao, @dataCompra, @categoriaId);   
   end
end
GO


create procedure spApagaJogo(@id int)
as
begin
   delete jogos where id = @id;
end
GO




create procedure spNavegaPrimeiroJogo
as
begin
 select top 1 * from jogos order by id  asc
end

GO


create procedure spNavegaUltimoJogo
as
begin
 select top 1 * from jogos order by id  desc
end

GO

create procedure spNavegaJogoAnterior(@idAtual int)
as
begin
  select top 1 * from jogos where id < @idAtual order by id desc
end

GO


create procedure spNavegaProximoJogo(@idAtual int)
as
begin
  select top 1 * from jogos where id > @idAtual order by id asc
end

GO




create procedure spProximoIdJogo
as
begin
  return (select isnull(max(id)+1,1) from jogos);
end

GO


create procedure spConsultaAvancada(@descricao varchar(max), 
									@preco decimal(18,2), 
									@data date,
                                    @categoria int, 
									@id int)
as
begin
   declare @sql varchar(max)
   set @sql = 'select jogos.*, categorias.descricao as Categoria 
               from jogos 
               inner join categorias on categorias.id = jogos.CategoriaId
               where  jogos.descricao like ''%' + @descricao + '%''';
			   
   if (@data is not null)
       set @sql = @sql +  ' and  convert(varchar, data_aquisicao, 103)  =  ''' + convert(varchar,  @data, 103) + '''';


   if (@preco is not null)
      set @sql = @sql +  ' and valor_locacao = ' + cast( @preco  as varchar(max));

   if (@id is not null)
	   set @sql = @sql +  ' and jogos.id = ' + cast( @id  as varchar(max));

   if (@categoria is not null)
	   set @sql = @sql +  ' and jogos.categoriaId = ' + cast(@categoria as varchar(max));

	   			
	exec(@sql);
end
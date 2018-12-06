
---------------------------------------------------------------------------------------------
							   -- Banco de Dados --
---------------------------------------------------------------------------------------------

use master

drop database AgendaMais
create database AgendaMais

use AgendaMais
go

---------------------------------------------------------------------------------------------
							      -- Tabelas --
---------------------------------------------------------------------------------------------

create table cliente(
	id int primary key not null,
	nome varchar(50) not null,
	cpf varchar(14),
	tel_cel varchar(15) not null,
	email varchar(max),
	recado varchar(max),
	rg varchar(13),
	uf varchar(2),
	cidade varchar(max),
	bairro varchar(max),
	endereco varchar(max),
	numero varchar(max),
	complemento varchar(max),
	imagem varchar(max)
)

create table funcionario(
	id int primary key not null,
	nome varchar(50) not null,
	cpf varchar(14),
	tel_cel varchar(15),
	email varchar(max),
	recado varchar(max),
	rg varchar(13),
	uf varchar(2),
	cidade varchar(max),
	bairro varchar(max),
	endereco varchar(max),
	numero varchar(max),
	complemento varchar(max),
	imagem varchar(max)
)

create table grupo_produto(
	id int primary key not null,
	descricao varchar(max) not null
)

create table produto(
	id int primary key not null,
	descricao varchar(max) not null,
	cod_barras varchar(max),
	vl_custo decimal(18,2) not null,
	vl_venda decimal(18,2) not null,
	qtd_estoque int,
	id_grupo_produto int not null foreign key references grupo_produto(id),
	controla_estoque bit not null
)

create table venda(
	id int primary key not null,
	valor decimal (18,2) not null,
	custo decimal (18,2) not null,
	desconto decimal (18,2),
	data_hora smalldatetime not null
)

create table item_venda(
	id_produto int not null foreign key references produto(id),
	id_venda int not null foreign key references venda(id),
	primary key(id_produto, id_venda),
	quantidade int not null,
	desconto decimal(18,2)
)

create table agenda(
	id int primary key not null,
	id_cliente int not null foreign key references cliente(id),
	id_funcionario int not null foreign key references funcionario(id),
	id_venda int not null foreign key references venda(id),
	data_hora smalldatetime,
	obs varchar(max),
	status char,
)

GO


---------------------------------------------------------------------------------------------
							  -- Auxiliares  --
---------------------------------------------------------------------------------------------

-- Retorna informações de erro
CREATE PROCEDURE sp_GetErrorInfo  
AS BEGIN
	SELECT  
	    ERROR_NUMBER() AS ErrorNumber,
	    ERROR_SEVERITY() AS ErrorSeverity,
	    ERROR_STATE() AS ErrorState,
	    ERROR_PROCEDURE() AS ErrorProcedure,
	    ERROR_LINE() AS ErrorLine,
	    ERROR_MESSAGE() AS ErrorMessage
END
go

-- Type auxiliar para a sp_insert_item_venda
CREATE TYPE [TypeItemVenda] AS TABLE(
	id_produto int NOT NULL,
	id_venda int NOT NULL,
	quantidade int NOT NULL,
	desconto decimal(18,2)
)
go





---------------------------------------------------------------------------------------------
							-- Stored Procedures --
---------------------------------------------------------------------------------------------

-- SPs da tabela venda

create procedure sp_GetTodosRegistros_venda
as begin
	select * from venda order by id
end
go

create procedure sp_GetRegistroPorId_venda (@id int)
as begin
	select * from venda where id=@id
end
go

create procedure sp_insert_venda(
	@valor decimal(18,2),
	@custo decimal(18,2),
	@desconto decimal(18,2),   
	@data_hora smalldatetime  
)
as begin
	declare @ProximoID int
	begin try

		if((select count(*) from venda)=0)
			set @ProximoID = 1
		else
			set @ProximoID = (select top 1 (id + 1) from venda order by id desc)
	
		Insert Into venda(id,valor,custo,desconto,data_hora) Values(@ProximoID,@valor,@custo,@desconto,@data_hora)   
		return @ProximoID
	
	end try   
	begin catch    
		execute sp_GetErrorInfo   
	end catch  
end
go

create procedure sp_update_venda(
	@id int,
	@valor decimal(18,2),
	@custo decimal(18,2),
	@desconto decimal(18,2),   
	@data_hora smalldatetime
)
as begin
	begin try
		update venda set valor=@valor, custo=@custo, desconto=@desconto, data_hora=@data_hora where id=@id
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go

create procedure sp_delete_venda (@id int)
as begin
	begin try
		delete from venda where id=@id
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go









-- SPs da tabela item_venda --

create procedure sp_GetTodosRegistros_item_venda
as begin
	select * from item_venda order by id_produto, id_venda
end
go

create procedure sp_GetTodosRegistrosPorId_item_venda (@id_produto int, @id_venda int)
as begin
	select * from item_venda where id_produto=@id_produto and id_venda=@id_venda
end
go

create procedure sp_GetTodosRegistrosPorId_produto_item_venda (@id_produto int)
as begin
	select * from item_venda where id_produto=@id_produto
end
go

create procedure sp_GetTodosRegistrosPorId_venda_item_venda (@id_venda int)
as begin
	select * from item_venda where id_venda=@id_venda
end
go

create Procedure sp_insert_item_venda (@tabela TypeItemVenda readonly)
AS BEGIN
	begin try
		select * into #TabTemp from @tabela
		insert into item_venda (id_produto, id_venda, quantidade, desconto)
			select * from #TabTemp
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
END
go

create procedure sp_update_item_venda (@tabela TypeItemVenda readonly)
as begin
	begin try
		
		declare @id_produto int
		
		delete from item_venda where id_produto in (select id_produto from @tabela) and id_venda in (select id_venda from @tabela)

		insert into item_venda (id_produto,id_venda,quantidade,desconto)
			select * from @tabela

	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go

create procedure sp_delete_item_venda (@id_produto int, @id_venda int)
as begin
	begin try
		delete from item_venda where id_produto=@id_produto and id_venda=@id_venda
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go

create procedure sp_delete_PorIdProduto_item_venda (@id_produto int)
as begin
	begin try
		delete from item_venda where id_produto=@id_produto
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go

create procedure sp_delete_PorIdVenda_item_venda (@id_venda int)
as begin
	begin try
		delete from item_venda where id_venda=@id_venda
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go








-- Procedures da tabela agenda --

create procedure sp_proximoId_agenda
as begin
	declare @ProximoID int
	if ((select count(*) from agenda) = 0)
		set @ProximoID = 1
	else
		set @ProximoID = (select top 1 (id + 1) as id from agenda order by id desc)
	return @ProximoID
end
go

create procedure sp_GetTodosRegistros_agenda
as begin
	select a.*, c.nome as nome_cliente, c.tel_cel as tel_cel, f.nome as nome_funcionario
		from agenda a
		inner join cliente c on a.id_cliente=c.id
		inner join funcionario f on a.id_funcionario=f.id
		order by a.data_hora
end
go

create procedure sp_GetRegistroPorId_agenda(@id int)
as begin
	select a.*, c.nome as nome_cliente, c.tel_cel as tel_cel, f.nome as nome_funcionario
		from agenda a
		inner join cliente c on a.id_cliente=c.id
		inner join funcionario f on a.id_funcionario=f.id
		where a.id=@id
end
go

create procedure sp_GetRegistrosPorDataEStatus_agenda(
	@data_ini smalldatetime,
	@data_fim smalldatetime, 
	@status1 char,
	@status2 char,
	@status3 char
)
as begin
	select a.*, c.nome as nome_cliente, c.tel_cel as tel_cel, f.nome as nome_funcionario
	from agenda a
	inner join cliente c on a.id_cliente=c.id
	inner join funcionario f on a.id_funcionario=f.id
	where 
		a.data_hora between @data_ini and @data_fim and
		(a.status=@status1 or a.status=@status2 or a.status=@status3)
	order by a.data_hora
end
go

create procedure sp_GetRegistrosPorDataStatusEFuncionario_agenda(
	@data_ini smalldatetime,
	@data_fim smalldatetime, 
	@status1 char,
	@status2 char,
	@status3 char,
	@id_funcionario int
)
as begin
	select a.*, c.nome as nome_cliente, c.tel_cel as tel_cel, f.nome as nome_funcionario
	from agenda a
	inner join cliente c on a.id_cliente=c.id
	inner join funcionario f on a.id_funcionario=f.id
	where
		a.data_hora between @data_ini and @data_fim and
		(a.status=@status1 or a.status=@status2 or a.status=@status3) and
		f.id=@id_funcionario
	order by a.data_hora
end
go

create procedure sp_insert_agenda(
	@id_cliente int,
	@id_funcionario int,
	@data_hora smalldatetime,
	@obs varchar(max),
	@status char,
	@valor decimal(18,2),
	@custo decimal(18,2),
	@desconto decimal(18,2),
	@tabela_item_venda TypeItemVenda readonly
)
as begin
	declare @ProximoID int
	declare @id_venda int
	begin try

		-- insert venda
		exec @id_venda = sp_insert_venda @valor, @custo, @desconto, @data_hora

		-- insert agenda
		if((select count(*) from agenda)=0)
			set @ProximoID = 1
		else
			set @ProximoID = (select top 1 (id + 1) from agenda order by id desc)

		Insert Into agenda(
			id,
			id_venda, 
			id_cliente,
			id_funcionario,
			data_hora,
			obs,
			status)
		Values(
			@ProximoID,
			@id_venda,
			@id_cliente,
			@id_funcionario,
			@data_hora,
			@obs,
			@status
		)

		-- insert itens da venda
		exec sp_insert_item_venda @tabela_item_venda

	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go

create procedure sp_update_agenda(
	@id int,
	@id_venda int,
	@id_cliente int,
	@id_funcionario int,
	@data_hora smalldatetime,
	@obs varchar(max),
	@status char,
	@valor decimal(18,2),
	@custo decimal(18,2),
	@desconto decimal(18,2),
	@tabela_item_venda TypeItemVenda readonly
)
as begin
	begin try
		exec sp_update_venda @id_venda, @valor, @custo, @desconto, @data_hora

		update agenda set id_cliente=@id_cliente, id_funcionario=@id_funcionario, id_venda=@id_venda, data_hora=@data_hora, obs=@obs, status=@status where id=@id

		exec sp_update_item_venda @tabela_item_venda
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go



create procedure sp_delete_agenda(@id int)
as begin
	begin try
		delete from agenda where id=@id
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go

















-- SPs da tabela cliente

create procedure sp_proximoId_cliente
as begin
	declare @ProximoID int
	if ((select count(*) from cliente) = 0)
		set @ProximoID = 1
	else
		set @ProximoID = (select top 1 (id + 1) as id from cliente order by id desc)
	return @ProximoID
end
go

create procedure sp_GetTodosRegistros_cliente
as begin
	select * from cliente order by id
end
go

create procedure sp_GetRegistroPorId_cliente (@id int)
as begin
	select * from cliente where id=@id
end
go

create procedure sp_insert_cliente(
	@nome varchar(50),
	@tel_cel varchar(15),
	@email varchar(max),
	@recado varchar(max),
	@cpf varchar(14),
	@rg varchar(13),
	@uf varchar(2),
	@cidade varchar(max),
	@bairro varchar(max),
	@endereco varchar(max),
	@numero varchar(max),
	@complemento varchar(max),
	@imagem varchar(max)
)
as begin
	declare @ProximoID int
	begin try
		if((select count(*) from cliente)=0)
			set @ProximoID = 1
		else
			set @ProximoID = (select top 1 (id + 1) from cliente order by id desc)

		Insert Into cliente(id,nome,tel_cel,email,recado,cpf,rg,uf,cidade,bairro,endereco,numero,complemento,imagem)
			values(@ProximoID,@nome,@tel_cel,@email,@recado,@cpf,@rg,@uf,@cidade,@bairro,@endereco,@numero,@complemento,@imagem)
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go

create procedure sp_update_cliente(
	@id int,
	@nome varchar(50),
	@tel_cel varchar(15),
	@email varchar(max),
	@recado varchar(max),
	@cpf varchar(14),
	@rg varchar(13),
	@uf varchar(2),
	@cidade varchar(max),
	@bairro varchar(max),
	@endereco varchar(max),
	@numero varchar(max),
	@complemento varchar(max),
	@imagem varchar(max)
)
as begin
	begin try
		update cliente set nome=@nome,
						   tel_cel=@tel_cel,
						   email=@email,
						   recado=@recado,
						   cpf=@cpf,
						   rg=@rg,
						   uf=@uf,
						   cidade=@cidade,
						   bairro=@bairro,
						   endereco=@endereco,
						   numero=@numero,
						   complemento=@complemento,
						   imagem=@imagem
		where id=@id
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go

create procedure sp_delete_cliente (@id int)
as begin
	begin try
		delete from cliente where id=@id
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go





-- SPs da tabela funcionario

create procedure sp_proximoId_funcionario
as begin
	declare @ProximoID int
	if ((select count(*) from funcionario) = 0)
		set @ProximoID = 1
	else
		set @ProximoID = (select top 1 (id + 1) as id from funcionario order by id desc)
	return @ProximoID
end
go

create procedure sp_GetTodosRegistros_funcionario
as begin
	select * from funcionario order by id
end
go

create procedure sp_GetRegistroPorId_funcionario (@id int)
as begin
	select * from funcionario where id=@id
end
go

create procedure sp_insert_funcionario(
	@nome varchar(50),
	@tel_cel varchar(15),
	@email varchar(max),
	@recado varchar(max),
	@cpf varchar(14),
	@rg varchar(13),
	@uf varchar(2),
	@cidade varchar(max),
	@bairro varchar(max),
	@endereco varchar(max),
	@numero varchar(max),
	@complemento varchar(max),
	@imagem varchar(max)
)
as begin
	declare @ProximoID int
	begin try
		if((select count(*) from funcionario)=0)
			set @ProximoID = 1
		else
			set @ProximoID = (select top 1 (id + 1) from funcionario order by id desc)

		Insert Into funcionario(id,nome,tel_cel,email,recado,cpf,rg,uf,cidade,bairro,endereco,numero,complemento,imagem)
			values(@ProximoID,@nome,@tel_cel,@email,@recado,@cpf,@rg,@uf,@cidade,@bairro,@endereco,@numero,@complemento,@imagem)
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go

create procedure sp_update_funcionario(
	@id int,
	@nome varchar(50),
	@tel_cel varchar(15),
	@email varchar(max),
	@recado varchar(max),
	@cpf varchar(14),
	@rg varchar(13),
	@uf varchar(2),
	@cidade varchar(max),
	@bairro varchar(max),
	@endereco varchar(max),
	@numero varchar(max),
	@complemento varchar(max),
	@imagem varchar(max)
)
as begin
	begin try
		update funcionario set nome=@nome,
						   tel_cel=@tel_cel,
						   email=@email,
						   recado=@recado,
						   cpf=@cpf,
						   rg=@rg,
						   uf=@uf,
						   cidade=@cidade,
						   bairro=@bairro,
						   endereco=@endereco,
						   numero=@numero,
						   complemento=@complemento,
						   imagem=@imagem
		where id=@id
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go

create procedure sp_delete_funcionario (@id int)
as begin
	begin try
		delete from funcionario where id=@id
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go




-- SPs da tabela grupo_produto

create procedure sp_GetTodosRegistros_grupo_produto
as begin
	select * from grupo_produto order by id
end
go

create procedure sp_GetRegistroPorId_grupo_produto (@id int)
as begin
	select * from grupo_produto where id=@id
end
go

create procedure sp_insert_grupo_produto (@descricao varchar(max))
as begin
	declare @ProximoID int
	begin try
		if((select count(*) from grupo_produto)=0)
			set @ProximoID = 1
		else
			set @ProximoID = (select top 1 (id + 1) from grupo_produto order by id desc)

		insert into grupo_produto(id,descricao) values (@ProximoID,@descricao)
	end try
	begin catch 
		exec sp_GetErrorInfo
	end catch
end
go

create procedure sp_update_grupo_produto (@id int, @descricao varchar(max))
as begin
	begin try
		update grupo_produto set descricao=@descricao where id=@id
	end try
	begin catch 
		exec sp_GetErrorInfo
	end catch
end
go

create procedure sp_delete_grupo_produto (@id int)
as begin
	begin try
		delete from grupo_produto where id=@id
	end try
	begin catch 
		exec sp_GetErrorInfo
	end catch
end
go




-- SPs da tabela produto

create procedure sp_GetTodosRegistros_produto
as begin
	select * from produto order by id
end
go

create procedure sp_GetRegistroPorId_produto (@id int)
as begin
	select * from produto where id=@id
end
go

create procedure sp_GetRegistrosPorGrupo_produto (@id_grupo_produto int)
as begin
	select * from produto where id_grupo_produto=@id_grupo_produto order by id
end
go

create procedure sp_insert_produto (
	@descricao varchar(max),
	@cod_barras varchar(max),
	@vl_custo decimal(18,2),
	@vl_venda decimal(18,2),
	@qtd_estoque int,
	@id_grupo_produto int,
	@controla_estoque bit
)
as begin
	declare @ProximoID int
	begin try
		if((select count(*) from produto)=0)
			set @ProximoID = 1
		else
			set @ProximoID = (select top 1 (id + 1) from produto order by id desc)

		insert into produto(id,descricao,cod_barras,vl_custo,vl_venda,qtd_estoque,id_grupo_produto,controla_estoque) 
			values (@ProximoID,@descricao,@cod_barras,@vl_custo,@vl_venda,@qtd_estoque,@id_grupo_produto,@controla_estoque)
	end try
	begin catch 
		exec sp_GetErrorInfo
	end catch
end
go

create procedure sp_update_produto (
	@id int,
	@descricao varchar(max),
	@cod_barras varchar(max),
	@vl_custo decimal(18,2),
	@vl_venda decimal(18,2),
	@qtd_estoque int,
	@id_grupo_produto int,
	@controla_estoque bit
)
as begin
	begin try
		update produto 
		set 
			descricao=@descricao,
			cod_barras=@cod_barras,
			vl_custo=@vl_custo,
			vl_venda=@vl_venda,
			qtd_estoque=@qtd_estoque,
			id_grupo_produto=@id_grupo_produto,
			controla_estoque=@controla_estoque 
		where id=@id

	end try
	begin catch 
		exec sp_GetErrorInfo
	end catch
end
go

create procedure sp_delete_produto (@id int)
as begin
	begin try
		delete from produto where id=@id
	end try
	begin catch 
		exec sp_GetErrorInfo
	end catch
end
go







---------------------------------------------------------------------------------------------
							-- Triggers --
---------------------------------------------------------------------------------------------


create trigger tg_deleta_agenda on agenda
for delete
as begin
	declare @id_venda int
	set @id_venda = (select id_venda from deleted)

	begin try
		exec sp_delete_PorIdVenda_item_venda @id_venda
		exec sp_delete_venda @id_venda
	end try
	begin catch
		exec sp_GetErrorInfo
	end catch
end
go






---------------------------------------------------------------------------------------------
							-- Cursores --
---------------------------------------------------------------------------------------------

/*
	Os cursores abaixo retornam o a quantidade de agendamentos de cada cliente,
	quantos agendamentos confirmados, cancelado e pendentes
	além de retornar o intervalo médio entre as datas de agendamentos confirmados
	sendo possível calcular uma possível data de retorno do mesmo
*/

create procedure sp_cursorFrequenciaCliente (@id_cliente int, @nome varchar(50))
as begin

	declare @data smalldatetime
	declare @data_anterior smalldatetime
	declare @possivel_data_retorno smalldatetime
	declare @status char

	declare @confirmados int
	set @confirmados = 0
	
	declare @cancelados int
	set @cancelados = 0
	
	declare @pendentes int
	set @pendentes = 0
	
	declare @qtd_agendamentos int
	set @qtd_agendamentos = 0
	
	declare @frequencia  decimal(18,2)
	set @frequencia = 0

	create table #TempFrequenciaCliente(
		id_cliente int,
		nome varchar(50),
		qtd_agendamentos int,
		confirmados int,
		cancelados int,
		pendentes int,
		frequencia decimal(18,2),
		possivel_data_retorno smalldatetime
	)
	
	-- declaração do cursor
	declare consulta_agenda cursor for
		select data_hora, status from agenda where id_cliente=@id_cliente order by data_hora
	
	-- abertura do cursor
	open consulta_agenda
	
	-- vai para o primeiro registro e preenche as variáveis correspondentes
	FETCH NEXT FROM consulta_agenda
	INTO @data, @status
	
	while @@fetch_Status = 0 -- enquanto houver registros, faça
	Begin
		if(@status = 'C') -- Agenamento confirmado
		begin
			if(@confirmados = 0)
			begin
				set @data_anterior = @data;
				print 'data: ' + cast(@data as varchar(max))
			end
			else
			begin
				print DATEDIFF(day, @data_anterior, @data)
				set @frequencia = @frequencia + cast(DATEDIFF(day, @data_anterior, @data) as int)-- Soma todos os intervalos entre os agenamento do cliente passado por parâmetro
				set @data_anterior = @data
			end

			set @confirmados = @confirmados + 1;
		end
		
		if(@status = 'N') -- agendamentos cancelados
			set @cancelados = @cancelados + 1;
		
		if(@status = 'P') -- agendamentos pendentes
			set @pendentes = @pendentes + 1;
			
		-- vai para o próximo registro e preenche as variáveis correspondentes
		FETCH NEXT FROM consulta_agenda
		INTO @data, @status
	end

	set @qtd_agendamentos = @confirmados+@pendentes+@cancelados;
	if(@confirmados > 1)
	begin
		set @frequencia = @frequencia / (@confirmados - 1)--intervalo médio entre os agendamentos

		set @possivel_data_retorno = DATEADD(day, @frequencia, @data_anterior)
	end
	
	close consulta_agenda -- fecha o cursor
	deallocate consulta_agenda -- desaloca o cursor da memória

	insert into #TempFrequenciaCliente values (@id_cliente,@nome,@qtd_agendamentos,@confirmados,@cancelados,@pendentes,@frequencia,@possivel_data_retorno)
	
	select * from #TempFrequenciaCliente
end
go





create procedure sp_frequencia_agenda
as begin
	create table #TempFrequenciaAgenda(
		id_cliente int,
		nome varchar(50),
		qtd_agendamentos int,
		confirmados int,
		cancelados int,
		pendentes int,
		frequencia decimal(18),
		possivel_data_retorno smalldatetime
	)

	declare @id_cliente int
	declare @nome varchar(50)
	declare @frequencia decimal(18)

	declare consulta_clientes cursor for
		select id, nome from cliente
	
	open consulta_clientes
	
	fetch next from consulta_clientes
		into @id_cliente, @nome
	
	while @@fetch_Status = 0
	begin
		insert into #TempFrequenciaAgenda exec sp_cursorFrequenciaCliente @id_cliente, @nome
		
		fetch next from consulta_clientes
			into @id_cliente, @nome
	end
	
	close consulta_clientes
	deallocate consulta_clientes
	
	select * from #TempFrequenciaAgenda order by confirmados desc
end
go






---------------------------------------------------------------------------------------------
							-- Function --
---------------------------------------------------------------------------------------------

create function func_DRE (@data_ini smalldatetime, @data_fim smalldatetime)
returns @dre table(
	receitaProd decimal(18,2),
	receitaServ decimal(18,2),
	receitaTotal decimal(18,2),
	CustoProd decimal(18,2),
	custoServ decimal(18,2),
	custoTotal decimal(18,2),
	lucroLiquido decimal(18,2)
)
as begin
	declare @receitaProd decimal(18,2)
	declare @receitaServ decimal(18,2)
	declare @receitaTotal decimal(18,2)
	declare @CustoProd decimal(18,2)
	declare @custoServ decimal(18,2)
	declare @custoTotal decimal(18,2)
	declare @lucroLiquido decimal(18,2)
	
	set @receitaProd = (select sum(v.valor) 
						from venda v 
						inner join item_venda iv 
						on v.id=iv.id_venda
						inner join produto p
						on iv.id_produto=p.id
						inner join agenda a
						on a.id=v.id
						where
							p.controla_estoque=1 and
							v.data_hora between @data_ini and @data_fim and
							a.status='C')
	

	if(@receitaProd is null)
		set @receitaProd = 0

	set @receitaServ = (select sum(v.valor) 
						from venda v 
						inner join item_venda iv 
						on v.id=iv.id_venda
						inner join produto p
						on iv.id_produto=p.id
						inner join agenda a
						on a.id=v.id
						where
							p.controla_estoque=0 and
							v.data_hora between @data_ini and @data_fim and
							a.status='C')

	if(@receitaServ is null)
		set @receitaServ = 0

	set @receitaTotal = @receitaProd+@receitaServ

	set @CustoProd = (select sum(v.custo) 
					  from venda v
					  inner join item_venda iv
					  on v.id=iv.id_venda
					  inner join produto p
					  on iv.id_produto=p.id
					  inner join agenda a
					  on a.id=v.id
					  where
						p.controla_estoque=1 and
						v.data_hora between @data_ini and @data_fim and
						a.status='C')

	if(@CustoProd is null)
		set @CustoProd = 0

	set @custoServ = (select sum(v.custo) 
					  from venda v
					  inner join item_venda iv
					  on v.id=iv.id_venda
					  inner join produto p
					  on iv.id_produto=p.id
					  inner join agenda a
					  on a.id=v.id
					  where
						p.controla_estoque=0 and
						v.data_hora between @data_ini and @data_fim and
						a.status='C')

	if(@custoServ is null)
		set @custoServ = 0;

	set @custoTotal = @CustoProd+@custoServ

	set @lucroLiquido = @receitaTotal-@custoTotal

	insert into @dre values(@receitaProd,@receitaServ,@receitaTotal,@CustoProd,@custoServ,@custoTotal,@lucroLiquido)

	return
end
go

create procedure sp_DRE (@data_ini smalldatetime, @data_fim smalldatetime)
as begin
	select * from func_DRE (@data_ini, @data_fim)
end
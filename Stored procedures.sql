--Stored procedure inserts
-- insert buildings
USE Materials
GO

Create procedure InsertBuildings 
@BuildingName nvarchar(50),
@Available bit

as

insert into Buildings
values(@BuildingName, @Available);

--Insert Customers
USE Materials
GO

Create procedure InsertCustomers

@CustomerName nvarchar(50),
@Prefix nvarchar(5),
@FKBuilding int,
@Available bit

as

insert into Customers
values(@CustomerName,@Prefix,@FKBuilding, @Available);

--Insert PartNumber
USE Materials
GO

Create procedure InsertPartNumber

@PartNumber nvarchar(50),
@FKCustomer int,
@Available bit

as

insert into PartNumbers
values(@PartNumber,@FKCustomer,@Available);

--Stored procedures Consulta

use Materials
go

create procedure consultaP

@PartNumber nvarchar(50),
@Customer   nvarchar(50)
as

if (@PartNumber is not null)
    begin
    if(@Customer is null)
	begin 
	 select PN.PartNumber, Cust.Customer, Bldg.Building 
	 from PartNumbers PN, Customers Cust, Buildings Bldg
	 where PN.FKCustomer = Cust.PKCustomers
	 and Cust.FKBuilding = Bldg.PKBuilding
	 and PN.Available = 1
	 and PN.PartNumber like '%'+@PartNumber+'%';
	 end
  end
if (@PartNumber is null)
    begin
    if(@Customer is not null)
	begin 
	 select PN.PartNumber, Cust.Customer, Bldg.Building 
	 from PartNumbers PN, Customers Cust, Buildings Bldg
	 where PN.FKCustomer = Cust.PKCustomers
	 and Cust.FKBuilding = Bldg.PKBuilding
	 and PN.Available = 1
	 and Cust.Customer like '%'+@Customer+'%';
	 end
  end
 if (@PartNumber is null)
    begin
    if(@Customer is null)
	begin 
	 select PN.PartNumber, Cust.Customer, Bldg.Building 
	 from PartNumbers PN, Customers Cust, Buildings Bldg
	 where PN.FKCustomer = Cust.PKCustomers
	 and Cust.FKBuilding = Bldg.PKBuilding
	 and PN.Available = 1;
	 end
  end
 if (@PartNumber is not null)
    begin
    if(@Customer is not null)
	begin 
	 select PN.PartNumber, Cust.Customer, Bldg.Building 
	 from PartNumbers PN, Customers Cust, Buildings Bldg
	 where PN.FKCustomer = Cust.PKCustomers
	 and Cust.FKBuilding = Bldg.PKBuilding
	 and PN.Available = 1
	 and PN.PartNumber like '%'+@PartNumber+'%'
	 and Cust.Customer like '%'+@Customer+'%';
	 end
  end


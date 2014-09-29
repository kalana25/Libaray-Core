create database library
on primary(name='library',filename='D:\DataBase\Library core KGL\Library KGL.mdf')
go
use library
go
create table mstLanguages(
	lId int primary key,
	languages varchar(50) unique
)
go
create table mstAuthors(
	aId int primary key,
	aName varchar(50) unique
)
go
create table mstCategorys(
	cId int primary key,
	cName varchar(50) unique
)
go
create table mstPublisher(
	pId int primary key,
	pName varchar(50) unique
)
go
create table Barrower(
	nic char(10) primary key,
	name varchar(60) unique,
	phone char(10),
	email varchar(50),
	houseNo varchar(50),
	StreetNo varchar(50),
	estate varchar(50),
	city varchar(50),
	blacklist bit
)
go
create table Books(
	Isbn varchar(20) primary key,
	bName varchar(50) not null unique,
	bEdition varchar(20),
	bPicture image,
	bPrice money,
	bpbDate date,
	avalable bit,
	lId int references mstLanguages(lId) not null,
	aId int references mstAuthors(aId) not null
)
go
alter table Books
add packed bit default 'false' not null
go
create table dtlCategorys(
	Isbn varchar(20) references Books(Isbn) not null,
	cId int references mstCategorys(cId) not null
)
go
create table dtlPublisher(
	Isbn varchar(20) references Books(Isbn) not null,
	pId int references mstPublisher(pId) not null
)
go
--create table Barrow(
--	brwDate date not null,
--	expDate date not null,
--	returnDate date,
--	fineRate float,
--	remarks varchar(50),
--	bkCondition varchar(50),
--	nic char(10) references Barrower(nic) not null,
--	Isbn varchar(20) references Books(Isbn) not null
--)
--go
create table BorrowHeader(
	brwDate date not null,
	expDate date not null,
	rtnStatus bit default 0,
	fineRate float,
	remarks varchar(50),
	nic char(10) references Barrower(nic) not null,
	reference int unique,
	totBkFine money default 0	--new column 11/12/2013
	primary key(nic,brwDate)
)
go
create table BorrowDetail(
	reference int references BorrowHeader(reference),
	Isbn varchar(20) references Books(Isbn) not null,
	returnDate date,
	bkCondition varchar(50),
	bkFineAmt money default 0	--new column 11/12/2013
)
go
create table Request(
	Isbn varchar(20) references Books(Isbn) not null,
	reqDate date not null,
	reqStatus varchar(20),
	nic char(10) references Barrower(nic) not null
)
go
create table mstUsers(
	uName varchar(15) primary key,
	pWord varchar(15) not null unique,
	uType varchar(50)
)
go
create table mstProgram(
	pId int primary key,
	pName varchar(70)
)
go
create table trnPrivilege(
	pId int references mstProgram(pId) not null,
	uName varchar(15) references mstUsers(uName) not null,
	new bit,
	edit bit,
	remove bit,
	show bit,
	window bit,
)
go
create table mstGencode(
	genType varchar(20) primary key,
	descrip varchar(50) not null
)
go
create table dtlGencode(
	id int identity(1,1),
	genType varchar(20) references mstGencode(genType) not null,
	gencode varchar(20)not null
	primary key(genType,gencode)
)
go
create table sysParameter(
	allwedDays int default 13,
	fineRate money
)
go
insert into dbo.sysParameter values(13,15)
go
create table rackAllocation(
	Id int primary key identity(1,1),
	rName varchar(50) references mstRackName(rName) not null,
	secName varchar(50) references dtlRackSection(secName) not null,
	bName varchar(50) references Books(bName) not null,
	Isbn varchar(20) references Books(Isbn) not null,
	uName varchar(15) references mstUsers(uName) not null,
	packDate date default getdate(), 
	tookDate date
)
go
--////////////////////////////////////////////////////////////////////////
insert into mstProgram(pId,pName) values(1,'GENARAL CODE')
go
insert into mstProgram(pId,pName) values(2,'LANGUAGES MASTER')
go
insert into mstProgram(pId,pName) values(3,'PUBLISHER MASTER')
go
insert into mstProgram(pId,pName) values(4,'AUTHOR MASTER')
go
insert into mstProgram(pId,pName) values(5,'CATEGORY MASTER')
go
insert into mstProgram(pId,pName) values(6,'BOOK MASTER')
go

create proc selectUAProgram(@uName varchar(15))
as
select pId,pName from dbo.mstProgram where pId not in(select pId from dbo.trnPrivilege where uName=@uName)
--select pre.pId,pro.pName from mstProgram pro inner join trnPrivilege pre on pro.pId=pre.pId where uName=@uName and (pre.new='false' and pre.edit='false' and pre.remove='false' and pre.show='false' and pre.window='false')
go
create proc selectAProgram(@uName varchar(15))
as
select pre.pId,pro.pName,pre.new,pre.edit,pre.remove,pre.show,pre.window from trnPrivilege pre inner join mstProgram pro on pre.pId=pro.pId where pre.uName=@uName 
--select pre.pId,pro.pName,pre.new,pre.edit,pre.remove,pre.show,pre.window from trnPrivilege pre inner join mstProgram pro on pre.pId=pro.pId where pre.uName=@uName and (pre.new='true' or pre.edit='true' or pre.remove='true' or pre.show='true' or pre.window='true')
go
create proc updatePrivileges(@pId int,@uName varchar(15),@new bit,@edit bit,@remove bit,@show bit,@window bit)
as
begin
	if(not exists(select pId from dbo.trnPrivilege where pId=@pId and uName=@uName)and (@window='true'or @new='true' or @edit='true' or @remove='true' or @show='true'))
	begin
		insert into dbo.trnPrivilege(pId,uName,new,edit,remove,show,window) values(@pId,@uName,@new,@edit,@remove,@show,@window)	
	end
	else if(@window='false'and @new='false' and @edit='false' and @remove='false' and @show='false')
	begin
		delete dbo.trnPrivilege where pId=@pId and uName=@uName
	end
	begin
		update dbo.trnPrivilege set new=@new,edit=@edit,remove=@remove,show=@show,window=@window  where pId=@pId and uName=@uName
	end
end
go
--////////////////////////////////////////////////////////////////////////
create proc insertmstGCT(@genType varchar(20),@descrip varchar(50))
as
insert into dbo.mstGencode(genType,descrip) values(@genType,@descrip)
go

create proc insertdtlGC(@genType varchar(20),@gencode varchar(20))
as
insert into dbo.dtlGencode(genType,gencode) values(@genType,@gencode)
go

create proc editmstGencode(@genType varchar(20),@descrip varchar(50))
as
update dbo.mstGencode set descrip=@descrip where genType=@genType
go

create proc selectId(@genType varchar(20),@gencode varchar(20))
as
select id from dbo.dtlGencode where genType=@genType and gencode=@gencode
go

create proc editdtlGencode(@id int,@gencode varchar(20))
as
update dbo.dtlGencode set gencode=@gencode where id=@id
go

create proc deleteGencode(@genType varchar(20),@gencode varchar(20))
as
delete dbo.dtlGencode where genType=@genType and gencode=@gencode
go

create proc deleteGentype(@genType varchar(20))
as
delete dbo.mstGencode where genType=@genType
go

create proc selectGenType
as
select genType as 'General Code Type',descrip as 'Description' from dbo.mstGencode
go

create proc selectGenCode(@genType varchar(20))
as
select gencode as 'General Code' from dbo.dtlGencode where genType=@genType
go

create proc selectEdition
as
select gencode from dbo.dtlGencode where genType='BKEDTION'
go
--////////////////////////////////////////////////////////////////////////
create proc isGenTypeExistPro(@genType varchar(20))
as
begin
	declare @result bit
	if(exists(select genType from dbo.mstGencode where genType=@genType))
	begin
		set @result='true'
		select @result	
	end
	else
	begin
		set @result='false'
		select @result
	end
end
go

create proc isGenCodeExistPro(@genType varchar(20),@gencode varchar(20))
as
begin
	declare @result bit
	if(exists(select gencode from dbo.dtlGencode where genType=@genType and gencode=@gencode))
	begin
		set @result='true'
		select @result
	end
	else
	begin
		set @result='false'
		select @result
	end
end
go

create proc countGCPro(@genType varchar(20))
as
select count(genType) from dbo.dtlGencode where genType=@genType
go

--create proc selectDescription(@gencode varchar(20))
--as
--select descrip from dbo.mstGencode where gencode=@gencode
--go
--////////////////////////////////////////////////////////////////////////
insert into mstUsers(uName,pWord) values('kalana','12345')
insert into mstUsers(uName,pWord,uType) values('','132567','Admin')
go
--/////////////////////////////////////////user table UDF Scaler
create function isuserExist(@uName varchar(15)) returns bit
as
begin
	declare @result bit
	if((select uName from mstUsers where uName=@uName)=@uName)
	set @result='true'
	else
	set @result='false'
	return @result
end
go
create proc isuserExistPro(@uName varchar(15))
as
begin
	declare @result bit
	if(exists(select dbo.isuserExist(@uName) from mstUsers where uName=@uName))
		select dbo.isuserExist(@uName) from mstUsers where uName=@uName
	else
	begin
	set @result='false'
	select @result
	end
end
go   
--/////////////////////////////////////////

--/////////////////////////////////////////user table SP

create proc selectPw(@uName varchar(15))
as
select pWord from mstUsers where uName=@uName
go

create proc viewUser
as
select uName,pWord,uType from mstUsers
go

create proc selectUserType
as
select gencode from dbo.dtlGencode where genType='USRTYPE'
go

create proc insertUser(@uName varchar(15),@pWord varchar(15),@uType varchar(50))
as
insert into mstUsers(uName,pWord,uType) values(@uName,@pWord,@uType)
go

create proc deleteUser(@uName varchar(15))
as
delete mstUsers where uName=@uName
go
--//////////////////////////////////////////////////

create proc insertCategory(@cId int,@cName varchar(50))
as
insert into mstCategorys(cId,cName) values(@cId,@cName)
go

create proc deleteCategory(@cId int)
as
delete mstcategorys where cId=@cId
go
--/////////////////////////////////////////Categorys table UDF,SP
create function isCategoryExist(@cName varchar(50)) returns bit
as
begin
	declare @result bit
	if((select cName from mstCategorys where cName=@cName)=@cName)
	set @result='true'
	else
	set @result='false'
	return @result
end
go

create proc isCategoryExistPro(@cName varchar(50))
as
begin
	declare @result bit
	if(exists(select dbo.isCategoryExist(@cName) from mstCategorys where cName=@cName))
		select dbo.isCategoryExist(@cName) from mstCategorys where cName=@cName
	else
	begin
		set @result='false'
		select @result
	end
end 
go     

create proc selectCategory
as
select cId as 'Category ID',cName as 'Category Name' from mstCategorys
go

create proc editCategory(@cId int,@cName varchar(50))
as
update mstCategorys set cName=@cName where cId=@cId
go

create proc nextIndexCategory
as
Begin
if(select COUNT(cId) from mstCategorys)=0
select COUNT(cId)+1 from mstCategorys
else begin
select max(cId)+1 from mstCategorys
end
end
go

create proc selectcatNo(@cName varchar(50))
as
select cId from mstCategorys where cName=@cName
go

create proc selectCatNameDtl(@Isbn varchar(20))
as
select cm.cName from mstCategorys cm inner join  dtlCategorys cd on cm.cId=cd.cId where cd.Isbn=@Isbn
go

create proc selectCatDetail(@Isbn varchar(20))
as
select cd.Isbn,cd.cId,cm.cName from dtlCategorys cd inner join mstCategorys cm on cm.cId=cd.cId where cd.Isbn=@Isbn
go

create proc insertCatDetail(@Isbn varchar(20),@cName varchar(50))
as
begin
declare @cId int
select @cId=cId from dbo.mstCategorys where cName=@cName
insert into dbo.dtlCategorys(Isbn,cId) values(@Isbn,@cId)
end
go

create proc deleteCatDetail(@Isbn varchar(20))
as
delete dbo.dtlCategorys where Isbn=@Isbn
go
--////////////////////////////////////////////////////////////////////////
create proc insertLanguage(@lId int,@languages varchar(50))
as
insert into dbo.mstLanguages(lId,languages) values(@lId,@languages)
go

create proc editLanguage(@lId int,@languages varchar(50))
as
update dbo.mstLanguages set languages=@languages where lId=@lId
go

create proc deleteLanguage(@lId int)
as
delete dbo.mstLanguages where lId=@lId
go

create proc selectLanguage
as
select lId as 'Language ID',languages as 'Language' from dbo.mstLanguages
go
--////////////////////////////////////////////////////////////////////////

create function isLanguageExist(@languages varchar(50)) returns bit
as
begin
	declare @result bit
	if((select languages from mstLanguages where languages=@languages)=@languages)
	set @result='true'
	else
	set @result='false'
	return @result
end
go
       
create proc isLanguageExistPro(@languages varchar(50))
as
begin
	declare @result bit
	if(exists(select dbo.isLanguageExist(@languages) from mstLanguages where languages=@languages))
		select dbo.isLanguageExist(@languages) from mstLanguages where languages=@languages
	else
	begin
		set @result='false'
		select @result
	end
end
go

create proc nextIndexLanguage
as
Begin
if(select COUNT(lId) from dbo.mstLanguages)=0
select COUNT(lId)+1 from dbo.mstLanguages
else begin
select max(lId)+1 from dbo.mstLanguages
end
end
go

create proc selectlanNo(@languages varchar(50))
as
select lId from dbo.mstLanguages where languages=@languages
go


--////////////////////////////////////////////////////////////////////////
create proc insertAuthor(@aId int,@aName varchar(50))
as
insert into dbo.mstAuthors(aId,aName) values(@aId,@aName)
go

create proc editAuthor(@aId int,@aName varchar(50))
as
update dbo.mstAuthors set aName=@aName  where aId=@aId
go

create proc deleteAuthor(@aId int)
as
delete dbo.mstAuthors where aId=@aId
go

create proc selectAuthor
as
select aId as 'Author ID',aName as 'Author Name' from dbo.mstAuthors
go

--////////////////////////////////////////////////////////////////////////
create function isAuthorExist(@aName varchar(50)) returns bit
as
begin
	declare @result bit
	if((select aName from dbo.mstAuthors where aName=@aName)=@aName)
	set @result='true'
	else
	set @result='false'
	return @result
end
go

create proc isAuthorExistPro(@aName varchar(50))
as
begin
	declare @result bit
	if(exists(select dbo.isAuthorExist(@aName) from dbo.mstAuthors where aName=@aName))
		select dbo.isAuthorExist(@aName) from dbo.mstAuthors where aName=@aName
	else
	begin
		set @result='false'
		select @result
	end
end
go

create proc nextIndexAuthor
as
Begin
if(select COUNT(aId) from dbo.mstAuthors)=0
select COUNT(aId)+1 from dbo.mstAuthors
else begin
select max(aId)+1 from dbo.mstAuthors
end
end
go

create proc selectAuthrNo(@aName varchar(50))
as
select aId from dbo.mstAuthors where aName=@aName
go
--////////////////////////////////////////////////////////////////////////
create proc insertPublisher(@pId int,@pName varchar(50))
as
insert into dbo.mstPublisher(pId,pName) values(@pId,@pName)
go

create proc editPublisher(@pId int,@pName varchar(50))
as
update dbo.mstPublisher set pName=@pName  where pId=@pId
go

create proc deletePublisher(@pId int)
as
delete dbo.mstPublisher where pId=@pId
go

create proc selectPublisher
as
select pId as 'Publisher ID',pName as 'Publisher Name' from dbo.mstPublisher
go

--////////////////////////////////////////////////////////////////////////
create function isPublisherExist(@pName varchar(50)) returns bit
as
begin
	declare @result bit
	if((select pName from dbo.mstPublisher where pName=@pName)=@pName)
	set @result='true'
	else
	set @result='false'
	return @result
end
go

create proc isPublisherExistPro(@pName varchar(50))
as
begin
	declare @result bit
	if(exists(select dbo.isPublisherExist(@pName) from dbo.mstPublisher where pName=@pName))
		select dbo.isPublisherExist(@pName) from dbo.mstPublisher where pName=@pName
	else
	begin
		set @result='false'
		select @result
	end
end
go

create proc nextIndexPublisher
as
Begin
if(select COUNT(pId) from dbo.mstPublisher)=0
select COUNT(pId)+1 from dbo.mstPublisher
else begin
select max(pId)+1 from dbo.mstPublisher
end
end
go

create proc selectPublisherNo(@pName varchar(50))
as
select pId from dbo.mstPublisher where pName=@pName
go

create proc insertPubDetail(@Isbn varchar(20),@pName varchar(50))
as
begin
declare @pId int
select @pId=pId from dbo.mstPublisher where pName=@pName
insert into dbo.dtlPublisher(Isbn,pId) values(@Isbn,@pId)
end
go

create proc selectPubNameDtl(@Isbn varchar(20))
as
select pm.pName from mstPublisher pm inner join dtlPublisher pd on pm.pId=pd.pId where pd.Isbn=@Isbn
go
--////////////////////////////////////////////////////////////////////////
create proc insertBooks(@Isbn varchar(20),@bName varchar(50),@bEdition varchar(20),@bPicture image,@bPrice money,@bpbDate date,@avalable bit,@lId int,@aId int)
as
insert into dbo.Books(Isbn,bName,bEdition,bPicture,bPrice,bpbDate,avalable,lId,aId) values(@Isbn,@bName,@bEdition,@bPicture,@bPrice,@bpbDate,@avalable,@lId,@aId)
go
create proc editBooks(@Isbn varchar(20),@bName varchar(50),@bEdition varchar(20),@bPicture image,@bPrice money,@bpbDate date,@lId int,@aId int)
as
update dbo.Books set bName=@bName,bEdition=@bEdition,bPicture=@bPicture,bPrice=@bPrice,bpbDate=@bpbDate,lId=@lId,aId=@aId where Isbn=@Isbn
go

create proc deleteCatDtl(@Isbn varchar(20))
as
delete dbo.dtlCategorys where Isbn=@Isbn
go

create proc deletePubDtl(@Isbn varchar(20))
as
delete dbo.dtlPublisher where Isbn=@Isbn
go

create proc deleteBook(@Isbn varchar(20))
as
begin
delete dbo.Books where Isbn=@Isbn
end
go

create proc selectBooks(@bName varchar(50))
as
select Isbn,bName,bEdition,bPicture,bPrice,bpbDate,l.languages,a.aName from dbo.Books b inner join dbo.mstAuthors a on b.aId=a.aId inner join dbo.mstLanguages l on l.lId=b.lId where bName=@bName
go

create proc selectBookNames
as
select bName from dbo.Books
go

create proc isBookExistPro(@Isbn varchar(20))
as
begin
	declare @result bit
	if(exists(select Isbn from dbo.Books where Isbn=@Isbn))
	begin
		set @result='true'
		select @result	
	end
	else
	begin
		set @result='false'
		select @result
	end
end
go

create proc isBookNameExistPro(@bName varchar(50))
as
begin
	declare @result bit
	if(exists(select bName from dbo.Books where bName=@bName))
	begin
		set @result='true'
		select @result	
	end
	else
	begin
		set @result='false'
		select @result
	end
end
go
create proc selectAvalbleIsbn
as
	select Isbn,bName from dbo.Books where avalable='true'
go
create proc isBookAvailable(@Isbn varchar(20))
as
begin
	select avalable from dbo.Books where Isbn=@Isbn
end
go
--////////////////////////////////////////////////////////////////////////
create proc insertBorrower(@nic char(10),@name varchar(60),@phone char(10),@email varchar(50),@houseNo varchar(50),@StreetNo varchar(50),@estate varchar(50),@city varchar(50))
as
begin
	insert into dbo.Barrower(nic,name,phone,email,houseNo,StreetNo,estate,city) values(@nic,@name,@phone,@email,@houseNo,@StreetNo,@estate,@city)
end
go
create proc updateBorrower(@nic char(10),@name varchar(60),@phone char(10),@email varchar(50),@houseNo varchar(50),@StreetNo varchar(50),@estate varchar(50),@city varchar(50))
as
begin
	update dbo.Barrower set name=@name,phone=@phone,email=@email,houseNo=@houseNo,StreetNo=@StreetNo,estate=@estate,city=@city where nic=@nic
end
go
create proc deleteBorrower(@nic char(10))
as
begin
	delete dbo.Barrower where nic=@nic
end
go
create proc selectBorrower(@name varchar(60))
as
begin
	select nic,name,phone,email,houseNo,StreetNo,estate,city from dbo.Barrower where name=@name
end
go
create proc selectBorrowerByNic(@nic char(10))
as
begin
	select nic,name,phone,email,houseNo,StreetNo,estate,city from dbo.Barrower where nic=@nic
end
go
create proc selectBorwerNam
as
begin
	select name from dbo.Barrower
end
go
create proc isNicExist(@nic char(10))
as
begin
	declare @result bit
	if(exists(select nic from dbo.Barrower where nic=@nic))
	begin
		set @result='true'
		select @result	
	end
	else
	begin
		set @result='false'
		select @result
	end
end
go
create proc isNameExist(@name varchar(60))
as
begin
	declare @result bit
	if(exists(select name from dbo.Barrower where name=@name))
	begin
		set @result='true'
		select @result	
	end
	else
	begin
		set @result='false'
		select @result
	end
end
go
create proc selectNic
as
select nic from dbo.Barrower
go
--////////////////////////////////////////////////////////////////////////
create proc insertBorrowHdr(@reference int,@nic char(10),@brwDate date,@expDate date)
as
insert into dbo.BorrowHeader (brwDate,expDate,nic,reference) values(@brwDate,@expDate,@nic,@reference)
go

create proc viewBorrowHdr(@reference int)
as
select brwDate,expDate,nic,remarks,totBkFine from dbo.BorrowHeader where reference=@reference
go

create proc deleteBorrowHdr(@reference int)
as
delete dbo.BorrowHeader where reference=@reference
go

create proc insertBorrowDtl(@reference int,@Isbn varchar(20))
as
insert into  dbo.BorrowDetail (reference,Isbn) values(@reference,@Isbn)
update dbo.Books set avalable='false' where Isbn=@Isbn
go

create proc deleteBorrowDtl(@reference int)
as
begin
update dbo.Books set avalable='true' where Isbn in(select Isbn from dbo.BorrowDetail where reference=@reference)
delete dbo.BorrowDetail where reference=@reference
end
go

create proc viewBorrowBooks(@reference int)
as
select bd.Isbn,b.bName,returnDate,bkCondition,bkFineAmt from BorrowDetail bd inner join Books b on bd.Isbn=b.Isbn where bd.reference=@reference
go

create proc viewPendingBooks(@reference int)
as
select bd.Isbn,b.bName,returnDate,bkCondition from BorrowDetail bd inner join Books b on bd.Isbn=b.Isbn where bd.reference=@reference and bd.returnDate is null
go

create proc nextIndexBorrowBook
as
Begin
if(select COUNT(reference) from dbo.BorrowHeader)=0
select COUNT(reference)+1 from dbo.BorrowHeader
else begin
select max(reference)+1 from dbo.BorrowHeader
end
end
go

create proc isReferNoExist(@reference int)
as
begin
	declare @result bit
	if(exists(select reference from dbo.BorrowHeader where reference=@reference))
	begin
		set @result='true'
		select @result	
	end
	else
	begin
		set @result='false'
		select @result
	end
end
go

create proc isIsbnExistForReffrNo(@reference int,@Isbn varchar(20))
as
begin
	declare @result bit
	if(exists(select reference from dbo.BorrowDetail where reference=@reference and Isbn=@Isbn))
	begin
		set @result='true'
		select @result
	end
	else
	begin
		set @result='false'
		select @result
	end
end
go

--created and tested. 07/04/2014
create proc getRtnStatusOfReffNo(@para varchar(20),@type char(3))
as
begin
	if(@type='ref')
	begin
		declare @ref int= cast(@para as int)
		select rtnStatus from dbo.BorrowHeader where reference=@ref
	end
	else if(@type='nic')
	begin
		select rtnStatus from dbo.BorrowHeader where nic=@para
	end
end
go

--this can create scaler data or table data
create proc getReffByNic(@nic char(10),@rtnState bit)
as
begin
	select reference from dbo.BorrowHeader where nic=@nic and rtnStatus=@rtnState
end
go

--no use yet
create proc getReffByDateAndNic(@brwDate date,@nic char(10))
as
select reference from dbo.BorrowHeader where nic=@nic and brwDate=@brwDate
go
--no use yet
create proc isPersonBorrowed(@brwDate date,@nic char(10))
as
begin
	declare @result bit
	if(exists(select reference from dbo.BorrowHeader where nic=@nic and brwDate=@brwDate))
	begin
		set @result='true'
		select @result	
	end
	else
	begin
		set @result='false'
		select @result
	end
end
go

create proc isPersonBorrowedByNic(@nic char(10))
as
begin
declare @result bit
	if(exists(select reference from dbo.BorrowHeader where nic=@nic))
	begin
		set @result='true'
		select @result	
	end
	else
	begin
		set @result='false'
		select @result
	end

end
go

create proc selectAllwDays
as
select allwedDays from dbo.sysParameter
go

create proc selectFineRate
as
select fineRate from dbo.sysParameter
go

create proc selectGenCode(@genType varchar(20))
as
select gencode from dbo.dtlGencode where genType=@genType
go

create proc updateReturnHdr(@fineRate float,@remarks varchar(50),@totBkFine money,@reference int)
as
update dbo.BorrowHeader set fineRate=@fineRate,remarks=@remarks,totBkFine=@totBkFine where reference=@reference
go
create proc updateReturnDtl(@returnDate date,@bkCondition varchar(50),@bkFineAmt money,@reference int,@Isbn varchar(20))
as
update dbo.BorrowDetail set returnDate=@returnDate, bkCondition=@bkCondition,bkFineAmt=@bkFineAmt where reference=@reference and Isbn=@Isbn
go
create trigger updateRtnStatusAvailable
on dbo.BorrowDetail
after update
as
begin
	declare @reference int
	declare @Isbn varchar(20)
	select @Isbn=Isbn from inserted
	select @reference=reference from inserted
	update dbo.Books set avalable='true' where Isbn=@Isbn
	if(not exists(select returnDate from dbo.BorrowDetail where reference=@reference and returnDate is null))
	update dbo.BorrowHeader set rtnStatus='true' where reference=@reference
end
go
create trigger updateTookDate
on dbo.BorrowDetail
after insert
as
begin
	declare @Isbn varchar(20)
	select @Isbn=Isbn from inserted
	if(exists(select Isbn from dbo.rackAllocation where Isbn=@Isbn))
	begin
		update dbo.rackAllocation set tookDate=GETDATE() where Isbn=@Isbn
	end
end
go
--////////////////////////////////////////////////////////////////////////
create table mstRackName(					
	rId int primary key,
	rName varchar(50) unique not null
)
go
create table dtlRackSection(					
	secId int not null,
	secName varchar(50) unique not null,
	rId int references mstRackName(rId) not null,
	primary key(secId,rId)
)
go
--////////////////////////////////////////////////////////////////////////
create proc insertRackName(@rId int,@rName varchar(50))    
as
insert into dbo.mstRackName(rId,rName) values(@rId,@rName)
go

create proc insertRackSection(@rId int,@secId int,@secName varchar(50))			
as
insert into dbo.dtlRackSection(rId,secId,secName) values(@rId,@secId,@secName)
go

create proc deleteRackName(@rId int)
as
delete dbo.mstRackName where rId=@rId
go

create proc deleteRackSection(@rId int,@secId int)
as
delete dbo.dtlRackSection where rId=@rId and secId=@secId
go

create proc deleteAllRackSection(@rId int)
as
delete dbo.dtlRackSection where rId=@rId
go

create proc editRackName(@rId int,@rName varchar(50)) 
as
update dbo.mstRackName set rName=@rName where rId=@rId
go

create proc isRackNameExist(@rName varchar(50))
as
begin
	declare @result bit
	if(exists(select rName from dbo.mstRackName where rName=@rName))
	begin
		set @result='true'
		select @result	
	end
	else
	begin
		set @result='false'
		select @result
	end
end
go

create proc selectRackNames						
as
select rName from dbo.mstRackName
go

create proc nextIndexRackName					
as
Begin
if(select COUNT(rId) from dbo.mstRackName)=0
select COUNT(rId)+1 from dbo.mstRackName
else begin
select max(rId)+1 from dbo.mstRackName
end
end
go

create proc nextIndexRackSection(@rId int)					
as
Begin
if(select COUNT(secId) from dbo.dtlRackSection where rId=@rId)=0
select COUNT(secId)+1 from dbo.dtlRackSection where rId=@rId
else begin
select MAX(secId)+1 from dbo.dtlRackSection where rId=@rId
end
end
go

create proc selectRackId(@rName varchar(50))
as
begin
	select rId from dbo.mstRackName where rName=@rName
end
go

create proc selectSections(@rId int)
as
begin
	select secId,secName from dbo.dtlRackSection where rId=@rId
end
go

create proc selectSectionNames(@rName varchar(50))
as
begin
	select secId,secName from dtlRackSection rs inner join mstRackName rn on rs.rId=rn.rId where rn.rName=@rName
end
go

create proc insertRackAllocation(@rName varchar(50),@secName varchar(50),@bName varchar(50),@Isbn varchar(20),@uName varchar(15))
as
begin
	if(exists(select Isbn from dbo.rackAllocation where Isbn=@Isbn))
	begin
	update dbo.rackAllocation set packDate=GETDATE() where Isbn=@Isbn
	update dbo.Books set packed='true' where Isbn=@Isbn
	end
	else
	begin
	insert into dbo.rackAllocation(rName,secName,bName,Isbn,uName) values(@rName,@secName,@bName,@Isbn,@uName)
	end
end
go
create trigger updateBookPackedStatus
on dbo.rackAllocation
after insert
as
begin
	declare @Isbn varchar(20)
	select @Isbn=Isbn from inserted
	update dbo.Books set packed='true' where Isbn=@Isbn
end
go
create trigger updateBackBookPackedStatus
on dbo.rackAllocation
after delete
as
begin
	declare @Isbn varchar(20)
	select @Isbn=Isbn from deleted
	update dbo.Books set packed='false' where Isbn=@Isbn
end
go


create proc viewRackAlloca(@Isbn varchar(20))
as
begin
	select rName,secName,bName,Isbn from dbo.rackAllocation where Isbn=@Isbn
end
go
create proc deleteRackAlloc(@Isbn varchar(20))
as
begin
	delete dbo.rackAllocation where Isbn=@Isbn
end

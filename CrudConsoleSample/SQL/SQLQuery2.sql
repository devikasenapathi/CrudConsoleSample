Create Table BookShop
(
BookId int not null identity(1,1),
BookName nvarchar(100) not null,
Authour nvarchar(100) not null,
ToatalNoPages bigint not null,
PublishedBy nvarchar(80) not null,
ContactNo bigint not null
)

select * from BookShop
-------Create Procedure-----
Create Procedure BookShopDetails
( 
@BookName nvarchar(100),
@Authour nvarchar(100),
@ToatalNoPages bigint,
@PublishedBy nvarchar(80),
@ContactNo bigint
)
as
begin
Insert into [dbo].[BookShop]
([BookName],[Authour],[ToatalNoPages],[PublishedBy],[ContactNo])
values(
@BookName,
@Authour,
@ToatalNoPages,
@PublishedBy,
@ContactNo
)
select * from BookShop

end 
exec  BookShopDetails 'hello ','James Clear',145,'warmar book',687421456 

Create procedure BookshopUpdate
(
@BookName nvarchar(100),
@ToatalNoPages int
)
as
begin 
update
BookShop
set 
ToatalNoPages=@toatalNoPages
where
BookName=@bookName


select * from @BookName
end
exec BookshopUpdate 'Atomic Habits','509'
-------------------------------------
Create procedure DeleteBookshop
(
@BookName nvarchar(100)
)
as
begin
Delete from BookShop
where
BookName=@BookName
select * from BookShop
end
exec DeleteBookshop ''
---------------------------------------
Create Procedure showall
as
begin
select * from BookShop
end
exec showall
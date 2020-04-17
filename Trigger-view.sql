use Employee



--------------------------------------------

alter  trigger TR_vEmployeeUpdate on dbo.vEmployee
instead of update 
as
begin
set nocount on;

Declare @EmpId int =(select EmployeeId from inserted) 
Declare @Salary bigint = (select Salary from inserted)
Declare @Name varchar(50) = (select EmployeeName from inserted)

		--select EmployeeName=@Name,Salary=@Salary from inserted

		update vEmployee set Salary=@Salary where EmployeeID=@EmpId 
		
		Update vEmployee set  EmployeeName=@Name where EmployeeID=@EmpId 
		
End
------------------------------------
update vEmployee set Salary=15478,EmployeeName='Suraj' where EmployeeId=2

select * from Employees
select * from Salary
select * from vEmployee











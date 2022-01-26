SELECT * FROM `candy bar`.candy;
alter TABLE candy MODIFY dbid VARCHAR(300);
alter TABLE candy MODIFY Name VARCHAR(300);
alter TABLE candy MODIFY Ingredients VARCHAR(5000);
alter TABLE candy MODIFY Manufacturer VARCHAR(5000);

insert into candy(dbid,Name,Manufacturer,Walmart_Price,Ingredients)
values('001','Hersheys Bar','Hershey Company','0.89','Milk Chocolate [Cane Sugar, Milk, Chocolate, Cocoa Butter, Milk Fat, Lecithin (Soy), Natural Flavor].');

select * from candy;

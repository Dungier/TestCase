-- создать базу
create database TestCaseSQL
-- прописать use
use TestCaseSQL
-- дальше выполнить все строки до следующего коммента
create table categorys
(
CatID int identity primary key not null,
CatName varchar(50)
)

create table products
(
ProdName varchar(255) not null,
Category int null default 1,
foreign key (Category) references categorys (CatID)
)


insert into categorys
values
('None category'),
('Seafood'),
('Flour'),
('Dairy'),
('Dairy'),
('Meat'),
('Spices')

insert into products (ProdName)
values
('Bananas'),
('Apples'),
('Oranges'),
('Tangerines')

insert into products
values
('Trout', 2),
('Salmon', 2),
('Cod', 2),
('Perch', 2),
('Catfish', 2),
('Salmon', 2),
('Eel', 2),
('Catfish', 2),
('White Bread', 3),
('Black Bread', 3),
('Lavash', 3),
('Doughnuts', 3),
('Pretzels', 3),
('Doughnuts', 3),
('Bagels', 3),
('Cabbage Pie', 3),
('Cherry Pie', 3),
('Potato Pie', 3),
('Apple Pie', 3),
('Milk', 4),
('Lactose Free Milk', 4),
('Cream 10%', 4),
('Cream 15%', 4),
('Cream 20%', 4),
('Cream 25%', 4),
('Creamy 33%', 4),
('Oygourt with Strawberries', 5),
('Oygourt with apple', 5),
('Oygurt with banana', 5),
('Ryazhenka', 5),
('Bioygurt', 5),
('Kefir', 5),
('Chicken Wings', 6),
('Chicken legs', 6),
('Chicken Breasts', 6),
('Chicken Thigh Meat', 6),
('Pork Tenderloin', 6),
('Beef Tenderloin', 6),
('Pork Neck', 6),
('Pork ham', 6),
('Whole Chicken', 6),
('Whole Turkey', 6),
('Turkey Legs', 6),
('Turkey Necks', 6),
('Pork Neck in Kefir Marinade', 6),
('Pork Neck in Kefir Marinade', 5),
('Chicken wings in kefir-yogurt marinade with paprika', 6),
('Chicken wings in kefir-yogurt marinade with paprika', 5),
('Chicken wings in kefir-yogurt marinade with paprika', 7)

-- Вывод данных в нужном формате
select p.ProdName, c.CatName from products p
join categorys c
on p.Category = c.CatID
order by p.ProdName
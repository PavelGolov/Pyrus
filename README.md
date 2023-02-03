# Pyrus
### Тестовые задания
#### Задача 1 
Реализовать (без использования LINQ) метод, возвращающий массив без дубликатов сохраняющий порядок элементов. 
 <br/>
int[] Distinct(int[] src) <br/>
//[1,2,5,3,3,2] → [1,2,5,3]  

#### Задача 2 
Реализовать функцию FilterLast которая возвращает все элементы исходной последовательности без последних N элементов. Исходную последовательность нельзя перечислять более одного раза и хранить целиком в памяти. Обратите внимание, что длина входящей последовательности заранее не известна (т.е. обращение source.Count() вызывает перечисление элементов последовательности) 
Реализуйте поточный однопроходный алгоритм 
Число n сильно меньше длины последовательности 
Можно использовать дополнительная память для хранения небольшого числа элементов <br/>
IEnumerable<T> FilterLast<T>(IEnumerable<T> source, Int32 n) 

#### Задача 3  
Дана следующая структура базы данных SQL <br/>
--Table Departments <br/>
create table D ( <br/>
       Id int primary key, <br/>
       Name nvarchar(100), <br/>
) <br/>
  
--Table Employees <br/>
create table E ( <br/>
       Id int primary key, <br/>
       DepartmentId int foreign key references Departments(Id), <br/>
       Name nvarchar(100), <br/>
       Salary float, <br/>
) <br/>
  
Необходимо: 
1.    Написать запрос получения имени одного сотрудника, имеющего максимальную зарплату в компании, и название его отдела 
2.   Получить список отделов, средняя зарплата в которых больше 1000$ 

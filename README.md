# AlmirVjezba

# Zadatak 1

- Napravi VisualStudio web projekat, EMPTY!!!
- U njemu dodaj ClassLibrary sa nazivom "AlmirVjezbaContext".
- U tom projektu, koristeci CodeFirst pristup, napravi slijedece tabele:

User:


| Name | Type |
| ------ | ------ |
| Id | long not null auto increment |
| Name | string not null |
| LastName | string not null |
| Gender | int not null |
| Role | int not null |


Role: 


| Name | Type |
| ------ | ------ |
| Id | long not null |
| Name | string not null |


Address: 


| Name | Type |
| ------ | ------ |
| Id | long not null auto increment |
| Street | string not null |
| Number | int |
| Addition | string |
| ZipCode | string not null |


MeterManufacturer: 


| Name | Type |
| ------ | ------ |
| Id | long not null auto increment |
| Name | string not null |
| State | string not null |
| Number | string |
| Address | string |



MeterType: (type of meter e.g. gas, electricity etc.)


| Name | Type |
| ------ | ------ |
| Id | long not null auto increment |
| Name | string not null |


Meter: 


| Name | Type |
| ------ | ------ |
| Id | long not null auto increment |
| Name | string not null |
| DateOfInstallation | Date not null |


### Pojasnjenje

Pravimo aplikaciju za aparate koji mjere potrosnju energije jednog domacinstva (struja, voda, plin itd.). 
Znaci, korisnik se uloguje svaki mjesec i unosi ocitanja sa metra za predhodni mjesec. Nas ne interesuje ako ce slagati i sl. jer vani je ovo regulisano velikim kaznama.

#### Za svaki issue napravi branch i kad zavrsis uradi pull request na moje ime.
### NEMOJ RADITI NISTA VISE OD ONOGA STO SAM TI NAPISAO DA RADIS. NECE ME IMPRESIONIRATI AKO URADIS LOGIN I REGISTRACIJU JER KAD BUDE TO TREBALO NAPRAVIT CU TI ISSUE ZA TO.


# Zadatak 1


- Napravi VisualStudio web projekat, EMPTY!!!
- U njemu dodaj ClassLibrary sa nazivom "AlmirVjezbaContext".
- U tom projektu, koristeci CodeFirst pristup, napravi slijedece tabele (nisam ti definisao Foreign Keys zato sto hocu da ih sam skontas):


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
| DateOfInstallation | datetime not null |




- Napuni podatke u bazi koristeci Procedure ili Insert statemente. Kada budes commitao kod, napravi .txt file negdje u projektu i zalijepi ih tamo.

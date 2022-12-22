--Céation de la base de données Zoo
create database Zoo
go

use Zoo
go

--Création de la table Oiseau
create table Oiseau(
num_animal nchar(6) primary key,
poids int,
espece varchar(50),
couleur_plumes varchar(50),
longueur_bec int
)
go

--Insérer des valeurs dans la table Oiseau
insert into Oiseau(num_animal, poids, espece, couleur_plumes, longueur_bec)
values('123456',2,'Toucan','Noir','23'),
	  ('654321',1,'Ara','Bleu','6')
go

--Afficher la table Oiseau
select * from Oiseau
go

--Création de la table Serpent
create table serpent(
num_animal nchar(6) primary key,
poids int,
espece varchar(50),
couleur_ecailles varchar(50),
venimeux varchar(3)
)
go

--Insérer des valeurs dans la table Serpent
insert into Serpent(num_animal, poids, espece, couleur_ecailles, venimeux)
values('121212',10,'Mamba','Noir','Oui'),
	  ('343434',50,'Anaconda','Vert','Non')
go

--Afficher la table Serpent
select * from Serpent
go

--Création de la table Enclos
create table Enclos(
num_enclos nchar(3) primary key,
taille_enclos varchar(50)
)
go

--Insérer des valeurs dans la table Enclos
insert into Enclos(num_enclos, taille_enclos)
values('123','Petit'),
	  ('456','Grand')
go

--Afficher la table enclos
select * from Enclos
go
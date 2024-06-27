-- create database VeterinaryDb;
use petStoreDB;
create table Pet (
    Pet_Id TINYINT(50) AUTO_INCREMENT NOT NULL,
    Pet_Name varchar (50) not null,
    Pet_Type varchar (50) not null,
    Pet_Colour varchar (50) not null,
    CONSTRAINT `pk_pet_id` PRIMARY KEY (`Pet_Id`)
);
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Buttons', 'Dog', 'White');
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Coda', 'Cat', 'Multicolor');
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Merlin', 'Parrot', 'Green-Yellow');
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Nina', 'Turtle', 'Dark Gray');
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Domino', 'Rabbit', 'White');
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Luna', 'Hamster', 'Orange');
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Lucy', 'Monkey', 'Brown');
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Daysi', 'Horse', 'White');
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Zoe', 'Snake', 'Yellow white');
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Max', 'Budgie', 'Yellow');
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Charlie', 'Mouse', 'White');
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Rocky', 'Squirrel', 'Brown-Orange');
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Leo', 'Dog', 'White-Black');
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Loki', 'Cat', 'Black');
insert into Pet (Pet_Name, Pet_Type, Pet_Colour)
values('Jasper', 'Dog', 'Silver');
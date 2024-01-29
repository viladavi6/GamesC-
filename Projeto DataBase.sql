use master
drop database loja_games
go
 
 
create database loja_games
go
 
 
use loja_games
go
 
 
create schema game authorization dbo
go


create table game.console
(
con_cod				int primary key identity(1,1),	
con_nm			varchar(30)		     not null,
con_emp			varchar(15)			 not null,
con_valor		decimal(10)			 not null,
con_qty			int					 not null
);
go



create table game.jogos
(
jogo_cod				int primary key identity(1,1),
jogo_nm		    varchar(45)			 not null,
jogo_studio		varchar(45)			 not null,
jogo_plat		varchar(15)			 not null,
jogo_vl			decimal(10)			 not null,
jogo_qty		int				     not null
);		
go


create table game.acessos 
(
cod_acesso			int identity primary key,
usuario				varchar(15) unique not null,
senha				varchar(15) not null,
tipo_usuario		varchar(15) not null
);
go


create table game.gift
(
gift_cod				int primary key identity(1,1),
gift_vl			decimal(10)			 not null,
gift_plat		varchar(20)			 not null,
gift_qty		int					 not null
)
go

insert into game.acessos values
	('admin', 'admin', 'administrador'),
	('usuario', 'senha', 'usuario');
go

 
select * from game.acessos
	where usuario = 'admin' 
	and senha = 'admin' 
	and tipo_usuario = 'administrador';
go


select * from game.acessos
	where usuario = 'usuario'
	and senha = 'senha'
	and tipo_usuario = 'usuario';
go


insert into game.jogos values
    ('Resident Evil 1 Remake', 'Capcom', 'Multiplataforma', '350', '15'),
    ('Resident Evil 2 Remake', 'Capcom', 'Multiplataforma', '350', '15'),
    ('Resident Evil 3 Remake', 'Capcom', 'Multiplataforma', '350', '15'),
    ('Resident Evil 4 Remake', 'Capcom', 'Multiplataforma', '350', '15'),
    ('Resident Evil 7', 'Capcom', 'Multiplataforma', '350', '15'),
    ('Resident Evil Village', 'Capcom', 'Multiplataforma', '350', '15'),
    ('Cyberpunk 2077', 'CD Projekt', 'Multiplataforma', '350', '15'),
    ('Final Fantasy 7 Remake', 'Square Enix', 'Playstation', '350', '15'),
    ('Final Fantasy XV', 'Square Enix', 'Multiplataforma', '350', '15'),
    ('Dark Souls 1 Remastered', 'FromSoftware', 'Multiplataforma', '350', '15'),
    ('Dark Souls 3', 'FromSoftware', 'Multiplataforma', '350', '15'),
    ('Kingdom Hearts 3', 'Square Enix', 'Multiplataforma', '350', '15'),
    ('God of War 3', 'Santa Monica Studio', 'Playstation', '350', '15'),
    ('God of War 2018', 'Santa Monica Studio', 'Playstation', '350', '15'),
    ('God of War Ragnarok', 'Santa Monica Studio', 'Playstation', '350', '15'),
    ('Detroit Become Human', 'Quantic Dream', 'Playstation', '350', '15'),
    ('GTA V', 'Rockstar Games', 'Multiplataforma', '350', '15'),
    ('The Evil Within 2', 'Bethesda', 'Multiplataforma', '350', '15'),
    ('Minecraft', 'Mojang', 'Multiplataforma', '350', '15'),
    ('The Legend of Zelda - Tears of the Kingdom', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('The Legend of Zelda - Breath of the Wild', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('Mario Kart 8 Deluxe', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('Mario Odyssey', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('Mario Wonders', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('Luigis Mansion 3', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('Mario RPG', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('Pokemon Scarlet', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('Pokemon Violet', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('Pokemon Sword', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('Pokemon Shield', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('Pokemon Legends Arceus', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('The Legend of Zelda - Links Awakening', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('Splatoon 2', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('Splatoon 3', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('Super Mario Party', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('Super Mario 3D World', 'Nintendo', 'Nintendo Switch', '350', '15'),
    ('The Last Guardian', 'Sony Interactive Entertainment', 'Playstation', '350', '15'),
    ('Shadow of the Colossus', 'Sony Interactive Entertainment', 'Playstation', '350', '15'),
    ('Demon Souls', 'Sony Interactive Entertainment', 'Playstation', '350', '15'),
    ('Bloodborne', 'Sony Interactive Entertainment', 'Playstation', '350', '15'),
    ('Elden Ring', 'FromSoftware', 'Multiplataforma', '350', '15'),
    ('Red Dead Redemption', 'Rockstar Games', 'Multiplataforma', '350', '15'),
    ('Assassins Creed Valhalla', 'Ubisoft', 'Multiplataforma', '350', '15'),
    ('The Witcher 3: Wild Hunt', 'CD Projekt', 'Multiplataforma', '350', '15'),
    ('FIFA 22', 'EA Sports', 'Multiplataforma', '350', '15'),
    ('Call of Duty: Warzone', 'Activision', 'Multiplataforma', '350', '15'),
    ('Overwatch', 'Blizzard Entertainment', 'Multiplataforma', '350', '15'),
    ('Mortal Kombat 11', 'NetherRealm Studios', 'Multiplataforma', '350', '15'),
    ('Spider-Man: Miles Morales', 'Insomniac Games', 'Playstation', '350', '15'),
    ('Horizon Zero Dawn', 'Guerrilla Games', 'Playstation', '350', '15'),
    ('Star Wars Jedi: Fallen Order', 'Electronic Arts', 'Multiplataforma', '350', '15'),
    ('The Elder Scrolls V: Skyrim', 'Bethesda', 'Multiplataforma', '350', '15'),
    ('Destiny 2', 'Bungie', 'Multiplataforma', '350', '15'),
    ('Halo Infinite', '343 Industries', 'Xbox', '350', '15'),
    ('Nier: Automata', 'Square Enix', 'Multiplataforma', '350', '15'),
    ('Persona 5', 'Atlus', 'Playstation', '350', '15'),
    ('Ghost of Tsushima', 'Sucker Punch Productions', 'Playstation', '350', '15'),
    ('Borderlands 3', 'Gearbox Software', 'Multiplataforma', '350', '15'),
    ('Far Cry 6', 'Ubisoft', 'Multiplataforma', '350', '15'),
    ('Battlefield 2042', 'Electronic Arts', 'Multiplataforma', '350', '15'),
    ('Sekiro: Shadows Die Twice', 'FromSoftware', 'Multiplataforma', '350', '15'),
    ('The Outer Worlds', 'Private Division', 'Multiplataforma', '350', '15'),
    ('Assassins Creed Odyssey', 'Ubisoft', 'Multiplataforma', '350', '15'),
	('Final Fantasy XVI', 'Square Enix', 'Playstation', '350', '15'),
	('Hogwarts Legacy', 'Portkey Games', 'Multiplataforma', '350', '15'),
    ('Marvels Spider-Man 2', 'Insomniac Games', 'Playstation', '350', '15'),
	('Marvels Spider-Man Remastered', 'Insomniac Games', 'Playstation', '350', '15'),
	('The Legend of Zelda - Skyward Sword HD', 'Nintendo', 'Nintendo Switch', '350', '15'),
	('Dragon Age 4', 'BioWare', 'Multiplataforma', '350', '15'),
	('Nioh', 'Team Ninja', 'Playstation', '350', '15'),
	('Nioh 2', 'Team Ninja', 'Playstation', '350', '15'),
	('Starfield', 'Bethesda', 'Xbox', '350', '15'),
	('Horizon Forbidden West ', 'Guerrilla Games', 'Playstation', '350', '15'),
	('Gears of War', 'Xbox Game Studios', 'Xbox', '350', '15'),
	('Forza Horizon 5', 'Xbox Game Studios', 'Xbox', '350', '15'),
	('Sunset Overdrive', 'Insomniac Games', 'Xbox', '350', '15'),
	('Hitman 3', 'IO Interactive', 'Multiplataforma', '350', '15'),
	('The Medium', 'Bloober Team' , 'Multiplataforma', '350', '15'),
	('It Takes Two', 'Hazelight Studios', 'Multiplataforma', '350', '15'),
	('Diablo III', 'Blizzard Entertainment', 'Multiplataforma', '350', '15'),
	('Diablo IV', 'Blizzard Entertainment', 'Multiplataforma', '350', '15'),
	('F1 2021', 'EA Sports', 'Multiplataforma', '350', '15'),
	('Dead Space Remake', 'EA Motive', 'Multiplataforma', '350', '15'),
	('Mario + Rabbids: Sparks of Hope', 'Ubisoft Milan', 'Nintendo Switch', '350', '15'),
	('Crash Bandicoot 4: It''s About Time', 'Toys for Bob', 'Multiplataforma', '350', '15'),
    ('Tony Hawk''s Pro Skater 1+2', 'Vicarious Visions', 'Multiplataforma', '350', '15'),
    ('Spyro Reignited Trilogy', 'Toys for Bob', 'Multiplataforma', '350', '15'),
	('Call of Duty: Black Ops Cold War', 'Activision', 'Multiplataforma', '350', '15'),
    ('Call of Duty: Modern Warfare', 'Activision', 'Multiplataforma', '350', '15'),
	('Call of Duty: WWII', 'Activision', 'Multiplataforma', '350', '15'),
	('Crash Bandicoot N. Sane Trilogy', 'Activision', 'Multiplataforma', '350', '15'),
	('Immortals Fenyx Rising', 'Ubisoft', 'Multiplataforma', '350', '15'),
	('Assassins Creed Origins', 'Ubisoft', 'Multiplataforma', '350', '15'),
	('Armored Core V', 'FromSoftware', 'Multiplataforma', '350', '15'),
	('Alan Wake 2', 'Remedy Entertainment', 'Multiplataforma', '350', '15'),
    ('Quantum Break', 'Remedy Entertainment', 'Xbox', '350', '15'),
    ('Control', 'Remedy Entertainment', 'Multiplataforma', '350', '15'),
	('Alan Wake Remastered', 'Remedy Entertainment', 'Multiplataforma', '350', '15'),
	('Tekken 7', 'Bandai Namco', 'Multiplataforma', '350', '15'),
    ('Dragon Ball FighterZ', 'Bandai Namco', 'Multiplataforma', '350', '15'),
    ('Ni no Kuni II: Revenant Kingdom', 'Level-5', 'Multiplataforma', '350', '15'), 
    ('Tales of Berseria', 'Bandai Namco', 'Multiplataforma', '350', '15'),
    ('Pac-Man Championship Edition 2', 'Bandai Namco', 'Multiplataforma', '350', '15'),
    ('Ace Combat 7: Skies Unknown', 'Bandai Namco', 'Multiplataforma', '350', '15'),
    ('One Piece: Pirate Warriors 4', 'Bandai Namco', 'Multiplataforma', '350', '15'),
    ('Soulcalibur VI', 'Bandai Namco', 'Multiplataforma', '350', '15'),
    ('Jump Force', 'Bandai Namco', 'Multiplataforma', '350', '15'),
    ('Code Vein', 'Bandai Namco', 'Multiplataforma', '350', '15'),
    ('Scarlet Nexus', 'Bandai Namco', 'Multiplataforma', '350', '15'),
    ('Little Nightmares', 'Tarsier Studios', 'Multiplataforma', '350', '15'), 
    ('Katamari Damacy Reroll', 'Bandai Namco', 'Multiplataforma', '350', '15'),
    ('My Hero One''s Justice 2', 'Bandai Namco', 'Multiplataforma', '350', '15'),
    ('Digimon Story: Cyber Sleuth - Hacker''s Memory', 'Media.Vision', 'Multiplataforma', '350', '15'), 
    ('Tales of Arise', 'Bandai Namco', 'Multiplataforma', '350', '15'),
    ('Elden Ring', 'FromSoftware', 'Multiplataforma', '350', '15'), 
    ('Project CARS 3', 'Slightly Mad Studios', 'Multiplataforma', '350', '15'),
    ('Dragon Ball Z: Kakarot', 'CyberConnect2', 'Multiplataforma', '350', '15'), 
    ('Naruto Shippuden: Ultimate Ninja Storm 4', 'CyberConnect2', 'Multiplataforma', '350', '15'),
    ('Dragon Ball Xenoverse 2', 'Dimps', 'Multiplataforma', '350', '15'), 
    ('Tales of Vesperia: Definitive Edition', 'Bandai Namco', 'Multiplataforma', '350', '15');

go


insert into game.console values
	('Playstation 4 Slim', 'Sony', '2200', '15'),
	('Playstation 4 Pro', 'Sony', '2800', '15'),
	('Playstation 5', 'Sony', '3600', '15'),
	('Xbox One S', 'Xbox', '2200', '15'),
	('Xbox Series S', 'Xbox', '3500', '15'),
	('Xbox Series X', 'Xbox', '4500', '15'),
	('Nintendo Switch', 'Nintendo', '2099', '15'),
	('Nintendo Switch Oled', 'Nintendo', '2500', '15');
go

insert into game.gift values
	('50', 'Playstation - PSN', '50'),
	('100', 'Playstation - PSN', '50'),
	('250', 'Playstation - PSN', '50'),
	('50', 'Steam', '50'),
	('100', 'Steam', '50'),
	('250', 'Steam', '50'),
	('50', 'Xbox', '50'),
	('100', 'Xbox', '50'),
	('250', 'Xbox', '50'),
	('50', 'Nintedo - Eshop', '50'),
	('100', 'Nintendo - Eshop', '50'),
	('250', 'Nintedo - Eshop', '50');
go


select * from game.console
select *  from game.jogos
select * from game.gift
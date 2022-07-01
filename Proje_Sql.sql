CREATE SCHEMA stok;

use stok;

create table kullanici_bilgi(
k_id int auto_increment primary key,
k_ad varchar(40),
k_sifre varchar(40),
y_id int);

create table kullanici_yetki(
y_id int auto_increment primary key,
y_ad varchar(40));

create table urun(
u_id int auto_increment primary key,
u_kod varchar(45),
u_ad varchar(45),
u_fiyat varchar(45),
u_girisTarih varchar(45),
u_stok varchar(45),
t_id int,
d_id int);

create table urun_turu(
t_id int auto_increment primary key,
u_TurAd varchar(45));

create table depo(
d_id int auto_increment primary key,
d_adi varchar(45),
d_TelNo varchar(20),
a_id int);

create table adres(
a_id int auto_increment primary key,
a_il varchar(45),
a_ilce varchar(45),
a_mahalle varchar(45),
a_cadde varchar(45),
a_sokak varchar(45),
a_no varchar(45));


alter table depo add CONSTRAINT fk_1 FOREIGN key (a_id) REFERENCES adres(a_id);
alter table urun add CONSTRAINT fk_2 FOREIGN key (d_id) REFERENCES depo(d_id);
alter table urun add CONSTRAINT fk_3 FOREIGN key (t_id) REFERENCES urun_turu(t_id);
alter table kullanici_bilgi add CONSTRAINT fk_4 FOREIGN key (y_id) REFERENCES kullanici_yetki(y_id);


INSERT INTO kullanici_yetki (y_ad) VALUES ("admin");
INSERT INTO kullanici_yetki (y_ad) VALUES ("yönetici");
INSERT INTO kullanici_yetki (y_ad) VALUES ("personel2");
INSERT INTO kullanici_yetki (y_ad) VALUES ("personel");


INSERT INTO kullanici_bilgi (k_ad, k_sifre,y_id) VALUES ("admin", "admin",1);
INSERT INTO kullanici_bilgi (k_ad, k_sifre,y_id) VALUES ("Seckin", "d3d3",2);
INSERT INTO kullanici_bilgi (k_ad, k_sifre,y_id) VALUES ("Tuncay", "kantarcii",3);
INSERT INTO kullanici_bilgi (k_ad, k_sifre,y_id) VALUES ("Ridvan", "r1dv4n",4);


INSERT INTO adres (a_il, a_ilce,a_mahalle,a_cadde,a_sokak,a_no) VALUES ("İstanbul", "Ümraniye","Ihlamırkuyu Mah","Alemda Cad","Tepeüstü","11");
INSERT INTO adres (a_il, a_ilce,a_mahalle,a_cadde,a_sokak,a_no) VALUES ("İstanbul", "Pendik","Kaynarca Mah","Deniz Cad","-","13");
INSERT INTO adres (a_il, a_ilce,a_mahalle,a_cadde,a_sokak,a_no) VALUES ("İstanbul", "Kartal","Soğanlık Mah","Mimar Sinan Cad","-","5");


INSERT INTO depo (d_adi,d_TelNo,a_id) VALUES ("gedik","02164043666",1);
INSERT INTO depo (d_adi,d_TelNo,a_id) VALUES ("tetik","02164043999",2);
INSERT INTO depo (d_adi,d_TelNo,a_id) VALUES ("geldik","02163043060",3);


INSERT INTO urun_turu (u_TurAd) VALUES ("su");
INSERT INTO urun_turu (u_TurAd) VALUES ("pirinç");
INSERT INTO urun_turu (u_TurAd) VALUES ("çikolata");


INSERT INTO urun (u_kod,u_ad,t_id,u_fiyat,u_girisTarih,u_stok,d_id) VALUES ("8695188000052","Kardelen",1,"1.75","20.2.2022","200",1);
INSERT INTO urun (u_kod,u_ad,t_id,u_fiyat,u_girisTarih,u_stok,d_id) VALUES ("5662550040045","Hamidiye",1,"2","5.1.2022","180",1);
INSERT INTO urun (u_kod,u_ad,t_id,u_fiyat,u_girisTarih,u_stok,d_id) VALUES ("9082300540004","Erikli",1,"2.5","10.4.2022","210",3);
INSERT INTO urun (u_kod,u_ad,t_id,u_fiyat,u_girisTarih,u_stok,d_id) VALUES ("9778596571200","Ovada",2,"13","11.3.2022","100",2);
INSERT INTO urun (u_kod,u_ad,t_id,u_fiyat,u_girisTarih,u_stok,d_id) VALUES ("7874432100255","Torku",2,"18","18.5.2022","150",1);
INSERT INTO urun (u_kod,u_ad,t_id,u_fiyat,u_girisTarih,u_stok,d_id) VALUES ("9766105330052","Torku",3,"20","11.3.2022","130",3);
INSERT INTO urun (u_kod,u_ad,t_id,u_fiyat,u_girisTarih,u_stok,d_id) VALUES ("8315642300555","Findux",3,"15","20.3.2022","170",3);
INSERT INTO urun (u_kod,u_ad,t_id,u_fiyat,u_girisTarih,u_stok,d_id) VALUES ("6654330085506","Ülker",3,"17","2.3.2022","160",2);
INSERT INTO urun (u_kod,u_ad,t_id,u_fiyat,u_girisTarih,u_stok,d_id) VALUES ("8984600808004","Nutella",3,"22","10.6.2022","100",2);
INSERT INTO urun (u_kod,u_ad,t_id,u_fiyat,u_girisTarih,u_stok,d_id) VALUES ("5640685897607","Eti",3,"19","5.4.2022","180",1);


create view urun_depo_tur as
select concat (urun.u_id) as Ürünİd, concat (urun.u_kod) as UrunKod,concat (urun.u_ad) as UrunAdı,concat (urun.u_fiyat) as Fiyat,concat (urun.u_girisTarih) as UrunGirisTarihi,
concat (urun.u_Stok) as Stok,concat (depo.d_adi)as Depo,concat(depo.d_TelNo)as Telefon,
concat (adres.a_il) as İl,concat (adres.a_ilce) as İlçe from urun inner join depo on
urun.d_id=depo.d_id inner join adres on depo.a_id=adres.a_id;

create view kullanıcı_bilgi_yetki as
select concat (kullanici_bilgi.k_id) as Kullanıcıİd, concat (kullanici_bilgi.k_ad) as KullanıcıAd,
concat (kullanici_bilgi.k_sifre) as KullanıcıŞifre,concat (kullanici_yetki.y_ad) as YetkiAdı
from kullanici_bilgi inner join kullanici_yetki on
kullanici_bilgi.y_id=kullanici_yetki.y_id;


DELIMITER //
create procedure kullanici_ekleme_islemi(IN inp_kullanici_ad varchar(100),
IN inp_kullanici_sifre varchar(100), IN inp_yetki_ad varchar(100))
begin
	insert into kullanici_bilgi(k_ad,k_sifre,y_id)
    values (inp_kullanici_ad,inp_kullanici_sifre,
	(select y_id from kullanici_yetki where y_ad=inp_yetki_ad));
end //
DELIMITER ;
 
 DELIMITER //
create procedure urun_ekleme_islemi(IN inp_urun_kod varchar(100), IN inp_urun_ad varchar(100),IN inp_tur_ad varchar(100),
IN inp_urun_fiyat varchar(100),IN inp_urun_girisTarih varchar(100), IN inp_urun_stok varchar(100),IN inp_depo_ad varchar(100))
begin
	insert into urun(u_kod,u_ad,u_fiyat,u_girisTarih,u_stok,t_id,d_id)
    values (inp_urun_kod,inp_urun_ad,inp_urun_fiyat,inp_urun_girisTarih,inp_urun_stok,
	(select t_id from urun_turu where u_TurAd=inp_tur_ad),
	(select d_id from depo where d_adi=inp_depo_ad));
end //
DELIMITER ;


DELIMITER ;
select * from kullanici_bilgi;
DELIMITER //
create procedure kullanici_guncelleme_islemi(IN kullanici_id int, IN kullanici_ad varchar(100), kullanici_sifre varchar(100), yetki_ad varchar(100))
begin
	declare yetki int;
    select y_id into yetki from kullanici_yetki where y_ad= yetki_ad ;
    update kullanici_bilgi set k_ad=kullanici_ad, k_sifre=kullanici_sifre , y_id=yetki where k_id = kullanici_id;
end //
DELIMITER ;




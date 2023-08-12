Create table Usuario(
Num_Rep int not null primary key,
nom_usu varbinary(100),
clav_usu varbinary(100),
constraint FK_usu_rep_vta foreign Key(Num_Rep) references Rep_ventas,
);

--crear encriptacion
create master key encryption by password ='claveEncriptacion_Xa1467W1'
go
create certificate CertSeg with SUBJECT='Para Encriptar'
go

create symmetric key KeySym with algorithm= AES_256
encryption by certificate CertSeg
goopen symmetric key keySym decryption by certificate CertSeggo--insertamos un usuarioInsert into dbo.usuario(Num_Rep, nom_usu, clav_usu)
values ( 101, ENCRYPTBYKEY(KEY_GUID('KeySym'),'Aaron'),
 ENCRYPTBYKEY(KEY_GUID('KeySym'),'123'));
 close all symmetric keys
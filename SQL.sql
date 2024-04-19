create table EQUIPEMENTS
(
    idEquipement NUMBER(4), CONSTRAINT pk_idEquipement PRIMARY KEY,
    nomEquipement VARCHAR2(50) NOT NULL,
    qualite NUMBER(2) CONSTRAINT ck_qualite CHECK(qualite>=1 AND qualite<=20),
    prixDeBase NUMBER(4,2) CONSTRAINT ck_prixDeBase CHECK(prixDeBase)
)
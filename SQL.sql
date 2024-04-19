SELECT
    *
FROM
    EQUIPEMENTS;

SELECT
    *
FROM
    CLASSES;

CREATE TABLE EQUIPEMENTS (
    IDEQUIPEMENT NUMBER(4),
    CONSTRAINT PK_IDEQUIPEMENT PRIMARY KEY (IDEQUIPEMENT),
    NOMEQUIPEMENT VARCHAR2(50) NOT NULL,
    QUALITE NUMBER(2) CONSTRAINT CK_QUALITE CHECK(QUALITE>=1 AND QUALITE<=20),
    PRIXDEBASE NUMBER(4, 2) DEFAULT 0 CONSTRAINT CK_PRIXDEBASE CHECK(PRIXDEBASE>=0),
    IDCLASSE CHAR(3),
    CONSTRAINT FK_EQUIPEMENTS_CLASSES FOREIGN KEY (IDCLASSE) REFERENCES CLASSES(IDCLASSE)
);

CREATE TABLE CLASSES (
    IDCLASSE CHAR(3) CONSTRAINT PK_IDCLASSE PRIMARY KEY,
    NOMCLASSE VARCHAR2(50) NOT NULL,
    SPECIALISATION VARCHAR2(50)
);

---Insertions Classes
INSERT INTO CLASSES (
    IDCLASSE,
    NOMCLASSE,
    SPECIALISATION
) VALUES (
    'GE1',
    'Guerrier',
    'Epee a deux mains'
);

INSERT INTO CLASSES (
    IDCLASSE,
    NOMCLASSE,
    SPECIALISATION
) VALUES (
    'GE2',
    'Guerrier',
    'Epee et bouclier'
);

INSERT INTO CLASSES (
    IDCLASSE,
    NOMCLASSE,
    SPECIALISATION
) VALUES (
    'MAE',
    'Magicien',
    'Elementaliste'
);

INSERT INTO CLASSES (
    IDCLASSE,
    NOMCLASSE,
    SPECIALISATION
) VALUES (
    'MAN',
    'Magicien',
    'Necromancier'
);

INSERT INTO CLASSES (
    IDCLASSE,
    NOMCLASSE
) VALUES (
    'VOL',
    'VOLEUR'
);

INSERT INTO CLASSES (
    IDCLASSE,
    NOMCLASSE
) VALUES (
    'ARC',
    'ARCHER'
);

---Insertion Equipements
INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    1,
    'Epee longue',
    10,
    20.00,
    'GE1'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    2,
    'Hache double',
    11,
    22.00,
    'GE1'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    3,
    'Hache geante',
    15,
    49.99,
    'GE1'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    4,
    'Hache de Gimli',
    20,
    49.99,
    'GE1'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    5,
    'Epee simple',
    5,
    5.00,
    'GE2'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    6,
    'Masse legere',
    2,
    4.00,
    'GE2'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    7,
    'Petit bouclier',
    5,
    55.00,
    'GE2'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    8,
    'Grand bouclier',
    15,
    22.30,
    'GE2'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    9,
    'Bouclier de Braum',
    20,
    95.50,
    'GE2'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    10,
    'Chapeau de feu',
    7,
    25.00,
    'MAE'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    11,
    'Chapeau de terre',
    15,
    75.00,
    'MAE'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    12,
    'Chapeau de Merlin',
    19,
    99.99,
    'MAE'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    13,
    'Livre de zombie',
    11,
    10,
    'MAN'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    14,
    'Livre de skelette',
    15,
    30,
    'MAN'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    15,
    'Livre de Karthus',
    20,
    70,
    'MAN'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    16,
    'Dague',
    5,
    0.99,
    'VOL'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    17,
    'Scimitar',
    7,
    10.00,
    'VOL'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    18,
    'Dague d''Ezio',
    20,
    80.00,
    'VOL'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    19,
    'Arc',
    5,
    5,
    'ARC'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    20,
    'Arc longue',
    10,
    30,
    'ARC'
);

INSERT INTO EQUIPEMENTS(
    IDEQUIPEMENT,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    IDCLASSE
) VALUES (
    21,
    'Arc de Hawkeye',
    20,
    99.99,
    'ARC'
);

COMMIT;

--Recherches
--a)
--mode de recherche no.1
--nomclasse (modify to your will)

--filtered by price ASC
SELECT
    NOMCLASSE,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    SPECIALISATION
FROM
    EQUIPEMENTS
    JOIN CLASSES
    ON EQUIPEMENTS.IDCLASSE=CLASSES.IDCLASSE
WHERE
    NOMCLASSE='Guerrier'
ORDER BY
    PRIXDEBASE ASC;

--filtered by price DESC
SELECT
    NOMCLASSE      NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    SPECIALISATION
FROM
    EQUIPEMENTS
    JOIN CLASSES
    ON EQUIPEMENTS.IDCLASSE=CLASSES.IDCLASSE
WHERE
    NOMCLASSE='Guerrier'
ORDER BY
    PRIXDEBASE DESC;

--filtered by quality ASC
SELECT
    NOMCLASSE,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    SPECIALISATION
FROM
    EQUIPEMENTS
    JOIN CLASSES
    ON EQUIPEMENTS.IDCLASSE=CLASSES.IDCLASSE
WHERE
    NOMCLASSE='Guerrier'
ORDER BY
    QUALITE ASC;

--filtered by quality DESC
SELECT
    NOMCLASSE,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    SPECIALISATION
FROM
    EQUIPEMENTS
    JOIN CLASSES
    ON EQUIPEMENTS.IDCLASSE=CLASSES.IDCLASSE
WHERE
    NOMCLASSE='Guerrier'
ORDER BY
    QUALITE DESC;

--research mode no.2

--research by quality

--filtered by quality(desc)
SELECT
    NOMCLASSE,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    SPECIALISATION
FROM
    EQUIPEMENTS
    JOIN CLASSES
    ON EQUIPEMENTS.IDCLASSE=CLASSES.IDCLASSE
WHERE
    QUALITE=20
ORDER BY
    QUALITE DESC;

--filtered by quality(asc)
SELECT
    NOMCLASSE,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    SPECIALISATION
FROM
    EQUIPEMENTS
    JOIN CLASSES
    ON EQUIPEMENTS.IDCLASSE=CLASSES.IDCLASSE
WHERE
    QUALITE=20
ORDER BY
    QUALITE ASC;

--filtered by prixdebase(desc)
SELECT
    NOMCLASSE,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    SPECIALISATION
FROM
    EQUIPEMENTS
    JOIN CLASSES
    ON EQUIPEMENTS.IDCLASSE=CLASSES.IDCLASSE
WHERE
    QUALITE=20
ORDER BY
    PRIXDEBASE DESC;

--filtered by prixdebase(asc)
SELECT
    NOMCLASSE,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    SPECIALISATION
FROM
    EQUIPEMENTS
    JOIN CLASSES
    ON EQUIPEMENTS.IDCLASSE=CLASSES.IDCLASSE
WHERE
    QUALITE=20
ORDER BY
    PRIXDEBASE ASC;

--research mode no.3

--research by  the name or the starting of the names of an Equipements

SELECT
    NOMCLASSE,
    NOMEQUIPEMENT,
    QUALITE,
    PRIXDEBASE,
    SPECIALISATION
FROM
    EQUIPEMENTS
    JOIN CLASSES
    ON EQUIPEMENTS.IDCLASSE=CLASSES.IDCLASSE
WHERE
    NOMEQUIPEMENT='Hache de Gimli' OR NOMEQUIPEMENT LIKE'Hache'
ORDER BY
    PRIXDEBASE ASC;

--Prix moyen des Equipements

SELECT nomclasse,ROUND(AVG(prixdebase),2) AS prix_moyen_dune_classe
FROM EQUIPEMENTS
    JOIN CLASSES
    ON EQUIPEMENTS.IDCLASSE=CLASSES.IDCLASSE
    GROUP BY NOMCLASSE;

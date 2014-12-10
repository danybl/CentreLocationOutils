DROP
  TABLE categorie CASCADE CONSTRAINTS;
DROP
  TABLE outil CASCADE CONSTRAINTS;
DROP
  TABLE outil_categorie CASCADE CONSTRAINTS;
DROP
  TABLE client CASCADE CONSTRAINTS;
DROP
  TABLE adresse CASCADE CONSTRAINTS;
DROP
  TABLE client_adresse CASCADE CONSTRAINTS;
DROP
  TABLE employe CASCADE CONSTRAINTS;
DROP
  TABLE employe_adresse CASCADE CONSTRAINTS;
DROP
  TABLE facturation CASCADE CONSTRAINTS;
DROP
  TABLE reservation CASCADE CONSTRAINTS;
DROP
  TABLE LOCATION CASCADE CONSTRAINTS;
CREATE
  TABLE categorie
  (
    idcategorie DECIMAL CHECK (idcategorie > 0),
    nom         VARCHAR2(30) NOT NULL,
    description VARCHAR2(120) NOT NULL,
    CONSTRAINT pk_categorie PRIMARY KEY (idcategorie)
  );
CREATE
  TABLE outil
  (
    idoutil         DECIMAL CHECK (idoutil     > 0),
    idcategorie     DECIMAL CHECK (idcategorie > 0),
    nom             VARCHAR2(100) NOT NULL,
    numserie        NUMBER,
    dateacquisition TIMESTAMP NOT NULL,
    prixlocation    NUMBER (10),
    description     VARCHAR2(120) NOT NULL,
    image           VARCHAR2(100) NOT NULL,
    CONSTRAINT pk_outil PRIMARY KEY (idoutil),
    CONSTRAINT refcategorie FOREIGN KEY (idcategorie) REFERENCES categorie (
    idcategorie) ON
  DELETE CASCADE
  );
CREATE
  TABLE client
  (
    idclient        DECIMAL CHECK (idclient > 0),
    nom             VARCHAR2(50) NOT NULL,
    prenom          VARCHAR2(50) NOT NULL,
    telephone       NUMBER(10) NOT NULL,
    email           VARCHAR2(100) ,
    dateinscription TIMESTAMP NOT NULL,
    nblocations     NUMBER(2) DEFAULT 0 NOT NULL CHECK (nblocations >= 0),
    limitelocations NUMBER(2) CHECK (limitelocations                 > 0
  AND limitelocations                                               <= 10),
    CONSTRAINT pk_client PRIMARY KEY (idclient),
    CONSTRAINT limitenblocations CHECK (nblocations <= limitelocations)
  );
CREATE
  TABLE adresse
  (
    idadresse   DECIMAL CHECK (idadresse > 0),
    numero      DECIMAL NOT NULL,
    rue         VARCHAR2(50) NOT NULL,
    appartement NUMBER(2) NOT NULL,
    codepostal  VARCHAR2(6) NOT NULL,
    ville       VARCHAR2(50) NOT NULL,
    province    VARCHAR2(50) NOT NULL,
    pays        VARCHAR2(20) NOT NULL,
    CONSTRAINT pk_adresse PRIMARY KEY (idadresse)
  );
CREATE
  TABLE client_adresse
  (
    idclient  DECIMAL CHECK (idclient  > 0),
    idadresse DECIMAL CHECK (idadresse > 0),
    CONSTRAINT pk_client_adresse PRIMARY KEY (idclient, idadresse),
    CONSTRAINT fk_refclient_client_adresse FOREIGN KEY (idclient) REFERENCES
    client(idclient),
    CONSTRAINT fk_refadresse_client_adresse FOREIGN KEY (idadresse) REFERENCES
    adresse(idadresse)
  );
CREATE
  TABLE employe
  (
    idemploye       DECIMAL NOT NULL,
    nom             VARCHAR2(50) NOT NULL,
    prenom          VARCHAR2(50) NOT NULL,
    telephone       NUMBER(10) NOT NULL,
    email           VARCHAR2(50) NOT NULL,
    daterecrutement DATE NOT NULL,
    poste           VARCHAR2(20) NOT NULL,
    CONSTRAINT pk_employe PRIMARY KEY (idemploye)
  );
CREATE
  TABLE employe_adresse
  (
    idemploye DECIMAL CHECK (idemploye > 0),
    idadresse DECIMAL CHECK (idadresse > 0),
    CONSTRAINT pk_employe_adresse PRIMARY KEY (idemploye, idadresse),
    CONSTRAINT fk_refemploye_employe_adresse FOREIGN KEY (idemploye) REFERENCES
    employe(idemploye),
    CONSTRAINT fk_refadresse_employe_adresse FOREIGN KEY (idadresse) REFERENCES
    adresse(idadresse)
  );
CREATE
  TABLE reservation
  (
    idreservation   DECIMAL CHECK (idreservation >0),
    idclient        DECIMAL CHECK (idclient      > 0),
    idoutil         DECIMAL CHECK (idoutil       > 0),
    datereservation TIMESTAMP NOT NULL,
    datelimite      TIMESTAMP NOT NULL,
    CONSTRAINT pk_reservation PRIMARY KEY(idreservation),
    CONSTRAINT fk_refclient_reserv FOREIGN KEY (idclient) REFERENCES client(
    idclient) ON
  DELETE
    CASCADE,
    CONSTRAINT fk_refoutil_reserv FOREIGN KEY (idoutil) REFERENCES outil(
    idoutil) ON
  DELETE CASCADE
  );
CREATE
  TABLE LOCATION
  (
    idlocation   DECIMAL CHECK (idlocation > 0),
    idclient     DECIMAL CHECK (idclient   > 0),
    idemploye    DECIMAL CHECK (idemploye  > 0),
    idoutil      DECIMAL CHECK (idoutil    > 0),
    depot        NUMBER(4,2) NOT NULL,
    datelocation TIMESTAMP NOT NULL,
    datelimite   TIMESTAMP NOT NULL,
    dateretour   TIMESTAMP,
    CONSTRAINT pk_location PRIMARY KEY (idlocation),
    CONSTRAINT fk_refclient_location FOREIGN KEY (idclient) REFERENCES client(
    idclient) ON
  DELETE
    CASCADE,
    CONSTRAINT fk_refemploye_location FOREIGN KEY (idemploye) REFERENCES
    employe(idemploye) ON
  DELETE
    CASCADE,
    CONSTRAINT fk_refoutil_location FOREIGN KEY (idoutil) REFERENCES outil (
    idoutil) ON
  DELETE CASCADE
  );
CREATE
  TABLE facturation
  (
    idfacturation DECIMAL CHECK (idfacturation > 0),
    idemploye     DECIMAL CHECK (idemploye     > 0),
    idlocation    DECIMAL CHECK (idlocation    > 0),
    couttotal     NUMBER(10) NOT NULL,
    CONSTRAINT pk_facturation PRIMARY KEY (idfacturation),
    CONSTRAINT fk_refemploye FOREIGN KEY (idemploye) REFERENCES employe(
    idemploye) ON
  DELETE
    CASCADE,
    CONSTRAINT fk_reflocation FOREIGN KEY (idlocation) REFERENCES LOCATION(
    idlocation) ON
  DELETE CASCADE
  );
DROP
  SEQUENCE seq_client_id;
CREATE SEQUENCE seq_client_id START WITH 1 INCREMENT BY 1 NOCYCLE;
  DROP
    SEQUENCE seq_employe_id;
CREATE SEQUENCE seq_employe_id START WITH 1 INCREMENT BY 1 NOCYCLE;
  DROP
    SEQUENCE seq_location_id;
CREATE SEQUENCE seq_location_id START WITH 1 INCREMENT BY 1 NOCYCLE;
  DROP
    SEQUENCE seq_reservation_id;
CREATE SEQUENCE seq_reservation_id START WITH 1 INCREMENT BY 1 NOCYCLE;
  DROP
    SEQUENCE seq_facturation_id;
CREATE SEQUENCE seq_facturation_id START WITH 1 INCREMENT BY 1 NOCYCLE;
  DROP
    SEQUENCE seq_outil_id;
CREATE SEQUENCE seq_outil_id START WITH 1 INCREMENT BY 1 NOCYCLE;
  DROP
    SEQUENCE seq_categorie_id;
CREATE SEQUENCE seq_categorie_id START WITH 1 INCREMENT BY 1 NOCYCLE;
  DROP
    SEQUENCE seq_adresse_id;
CREATE SEQUENCE seq_adresse_id START WITH 1 INCREMENT BY 1 NOCYCLE;


Insert into outil Values (seq_outil_id.NEXTVAL ,2 , 'CHARIOT POUR SCIE',123456789, current_timestamp, 25, 'Ça coupe le souffle','~/Ressources/ImagesOutils/chariot-pour-scie-a-beton.jpg');
Insert into outil Values (seq_outil_id.NEXTVAL, 3, 'BROUETTE',234567891, current_timestamp, 14, 'Capacite 9 Cude', '~/Ressources/ImagesOutils/brouette.jpg');
Insert into outil Values (seq_outil_id.NEXTVAL, 4, 'MARTEAU PIQUEUR 35 LBS ÉLECTRIQUE',345678912, current_timestamp, 45, 'Alimentation : 110 Volts, Poids : 35 lbs', '~/Ressources/ImagesOutils/marteau-piqueur-electrique-35-lbs.jpg');
Insert into outil Values (seq_outil_id.NEXTVAL, 5, 'DIABLE POUR BOÎTES',456789123, current_timestamp, 10, 'Capacite : 500 lb, Hauteur	49", Largeur	20"', '~/Ressources/ImagesOutils/diable-1080-sp.jpg');
Insert into outil Values (seq_outil_id.NEXTVAL, 6, 'TIRE-FORT 3 TONNES',678912345, current_timestamp, 30, 'Capacite : 3 tonnes, Longueur 26", Moteur :	Manuel, Poids	: 62 lbs', '~/Ressources/ImagesOutils/tire-fort.jpg');
Insert into outil Values (seq_outil_id.NEXTVAL, 7, 'CHAUFFERETTE ÉLECTRIQUE 600V',789123456, current_timestamp, 46, 'Thermostat : OUI, Ventilation : OUI, Voltage	600V', '~/Ressources/ImagesOutils/chaufferette-electrique-600-v.jpg');
Insert into outil Values (seq_outil_id.NEXTVAL, 8, 'CAMÉRA RIDGID MICRO',891234567, current_timestamp, 129, 'Déconseiller pour un examen rectal', '~/Ressources/ImagesOutils/Camera-d-inspection-MicroExplorer-Ridgid.jpg');

Insert into categorie Values(seq_categorie_id.NEXTVAL,'Sciage', 'Couper (quelque chose) à l’aide d’un outil munie d’une lame tranchante.');
Insert into categorie Values(seq_categorie_id.NEXTVAL,'Coulage', 'Verser (un liquide) dans un moule.');
Insert into categorie Values(seq_categorie_id.NEXTVAL,'Démolition', 'Défaire (ce qui a été construit). ');
Insert into categorie Values(seq_categorie_id.NEXTVAL,'Chariot', 'Voiture à roues employée pour le transport de matériaux ou de marchandises sur de courtes distances.');
Insert into categorie Values(seq_categorie_id.NEXTVAL,'Palan', 'Appareil de levage muni d’un mécanisme démultiplicateur qui permet de soulever, de déplacer des charges.');
Insert into categorie Values(seq_categorie_id.NEXTVAL,'Chauffage', 'Appareil qui produit la chaleur.');
Insert into categorie Values(seq_categorie_id.NEXTVAL,'Plomberie', 'Ensemble des installations et des canalisations d’eau ou de gaz.');

commit;
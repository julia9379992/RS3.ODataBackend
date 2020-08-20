




CREATE TABLE ОбъектСтроит (

 primaryKey UUID NOT NULL,

 Наименование VARCHAR(255) NULL,

 Адрес VARCHAR(255) NULL,

 Разрешение_m0 UUID NOT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE РазрешНаСтроит (

 primaryKey UUID NOT NULL,

 Наименование VARCHAR(255) NULL,

 ВидРазрешения VARCHAR(13) NULL,

 Архив BOOLEAN NULL,

 ДатаРазрешения TIMESTAMP(3) NULL,

 НомерРазрешения INT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE ЗастройщОрг (

 primaryKey UUID NOT NULL,

 Описание VARCHAR(255) NULL,

 ОрганизЗастр_m0 UUID NOT NULL,

 Разрешение_m0 UUID NOT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE Организация (

 primaryKey UUID NOT NULL,

 Наименование VARCHAR(255) NULL,

 Адрес VARCHAR(255) NULL,

 ИНН VARCHAR(255) NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE STORMNETLOCKDATA (

 LockKey VARCHAR(300) NOT NULL,

 UserName VARCHAR(300) NOT NULL,

 LockDate TIMESTAMP(3) NULL,

 PRIMARY KEY (LockKey));



CREATE TABLE STORMSETTINGS (

 primaryKey UUID NOT NULL,

 Module VARCHAR(1000) NULL,

 Name VARCHAR(255) NULL,

 Value TEXT NULL,

 "User" VARCHAR(255) NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE STORMAdvLimit (

 primaryKey UUID NOT NULL,

 "User" VARCHAR(255) NULL,

 Published BOOLEAN NULL,

 Module VARCHAR(255) NULL,

 Name VARCHAR(255) NULL,

 Value TEXT NULL,

 HotKeyData INT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE STORMFILTERSETTING (

 primaryKey UUID NOT NULL,

 Name VARCHAR(255) NOT NULL,

 DataObjectView VARCHAR(255) NOT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE STORMWEBSEARCH (

 primaryKey UUID NOT NULL,

 Name VARCHAR(255) NOT NULL,

 "Order" INT NOT NULL,

 PresentView VARCHAR(255) NOT NULL,

 DetailedView VARCHAR(255) NOT NULL,

 FilterSetting_m0 UUID NOT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE STORMFILTERDETAIL (

 primaryKey UUID NOT NULL,

 Caption VARCHAR(255) NOT NULL,

 DataObjectView VARCHAR(255) NOT NULL,

 ConnectMasterProp VARCHAR(255) NOT NULL,

 OwnerConnectProp VARCHAR(255) NULL,

 FilterSetting_m0 UUID NOT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE STORMFILTERLOOKUP (

 primaryKey UUID NOT NULL,

 DataObjectType VARCHAR(255) NOT NULL,

 Container VARCHAR(255) NULL,

 ContainerTag VARCHAR(255) NULL,

 FieldsToView VARCHAR(255) NULL,

 FilterSetting_m0 UUID NOT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE UserSetting (

 primaryKey UUID NOT NULL,

 AppName VARCHAR(256) NULL,

 UserName VARCHAR(512) NULL,

 UserGuid UUID NULL,

 ModuleName VARCHAR(1024) NULL,

 ModuleGuid UUID NULL,

 SettName VARCHAR(256) NULL,

 SettGuid UUID NULL,

 SettLastAccessTime TIMESTAMP(3) NULL,

 StrVal VARCHAR(256) NULL,

 TxtVal TEXT NULL,

 IntVal INT NULL,

 BoolVal BOOLEAN NULL,

 GuidVal UUID NULL,

 DecimalVal DECIMAL(20,10) NULL,

 DateTimeVal TIMESTAMP(3) NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE ApplicationLog (

 primaryKey UUID NOT NULL,

 Category VARCHAR(64) NULL,

 EventId INT NULL,

 Priority INT NULL,

 Severity VARCHAR(32) NULL,

 Title VARCHAR(256) NULL,

 Timestamp TIMESTAMP(3) NULL,

 MachineName VARCHAR(32) NULL,

 AppDomainName VARCHAR(512) NULL,

 ProcessId VARCHAR(256) NULL,

 ProcessName VARCHAR(512) NULL,

 ThreadName VARCHAR(512) NULL,

 Win32ThreadId VARCHAR(128) NULL,

 Message VARCHAR(2500) NULL,

 FormattedMessage TEXT NULL,

 PRIMARY KEY (primaryKey));




 ALTER TABLE ОбъектСтроит ADD CONSTRAINT FKa81039b883d844fd9c2b288becc3b444 FOREIGN KEY (Разрешение_m0) REFERENCES РазрешНаСтроит; 
CREATE INDEX Indexe1d2aaa57078d7ce41c9c2d0f8010494b206123c on ОбъектСтроит (Разрешение_m0); 

 ALTER TABLE ЗастройщОрг ADD CONSTRAINT FKe89bed92dbc74a4ca709d71504cabd32 FOREIGN KEY (ОрганизЗастр_m0) REFERENCES Организация; 
CREATE INDEX Indexdd78549f2d2525c74ca09da67b6aa59bdc07b7cf on ЗастройщОрг (ОрганизЗастр_m0); 

 ALTER TABLE ЗастройщОрг ADD CONSTRAINT FKd24e9257f47041c8b9227e722771f02d FOREIGN KEY (Разрешение_m0) REFERENCES РазрешНаСтроит; 
CREATE INDEX Indexc401a0468387f9872118fa86b2fad5a1543bdf4b on ЗастройщОрг (Разрешение_m0); 

 ALTER TABLE STORMWEBSEARCH ADD CONSTRAINT FKb85bff344ea5400a9fca086e981372c3 FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 

 ALTER TABLE STORMFILTERDETAIL ADD CONSTRAINT FKe36760a007764861a0de4e8fc009eb5b FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 

 ALTER TABLE STORMFILTERLOOKUP ADD CONSTRAINT FKa438139803b74ce3ae864d28d1e3c147 FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 


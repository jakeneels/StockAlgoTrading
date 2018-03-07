
CREATE TABLE Ticker
(
	Id int Identity(1,1),
	Symbol VARCHAR(7) NOT NULL,
	CompanyName VARCHAR(75) NOT NULL,
	Exchange VARCHAR(40) NOT NULL,
	Industry VARCHAR(30) NOT NULL,
	Website VARCHAR(75) NOT NULL,
	Description VARCHAR(200) NOT NULL,

	CONSTRAINT pk_ticker PRIMARY KEY (Id)
)

CREATE TABLE Stock
(
	Id int Identity(1,1),
	TickerId int NOT NULL,
	Date Date Default GetDate NOT NULL,
	OpenPrice float NOT NULL,
	ClosePrice float NOT NULL,
	High float NOT NULL,
	Low float NOT NULL,
	Volume Int NOT NULL,

	CONSTRAINT pk_stock PRIMARY KEY (Id),
	CONSTRAINT fk_stock_ticker FOREIGN KEY (TickerId) REFERENCES Ticker (Id),
)

CREATE TABLE KeyStats
(
	Id int Identity(1,1),
	TickerId int NOT NULL,

	CONSTRAINT pk_KeyStat PRIMARY KEY (Id),
	CONSTRAINT fk_KeyStat_ticker FOREIGN KEY (TickerId) REFERENCES Ticker (Id),
)

CREATE TABLE Financials
(
	Id int Identity(1,1),
	TickerId int NOT NULL,

	CONSTRAINT pk_financials PRIMARY KEY (Id),
	CONSTRAINT fk_financials_ticker FOREIGN KEY (TickerId) REFERENCES Ticker (Id),
)

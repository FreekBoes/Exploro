CREATE TABLE users (
	userId int PRIMARY KEY,
    name varchar(50) NOT NULL,
    eMail varchar(50) not null,
    password varchar(50) not null
);

create table scores(
	scoresId int primary key,
    scores int not null,
    tijd time not null,
	userId int NOT NULL,
    gameId int not null,
    CONSTRAINT FK_users_scores
		FOREIGN KEY (userId)
		REFERENCES users(userId)
);
create table leaderboard(
	leaderboardId int not null primary key,
	userId int not null,
    scoresId int not null,
	CONSTRAINT FK_leaderboard_scores
		FOREIGN KEY (scoresId)
		REFERENCES scores(scoresId),
	CONSTRAINT FK_leaderboard_users
		FOREIGN KEY (userId)
		REFERENCES users(userId)
    );

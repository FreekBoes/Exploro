create schema if not exists Exploro;

drop table if exists leaderboard;
drop table if exists scores;
Drop table if exists users;



use exploro;

CREATE TABLE exploro.users (
	userId int PRIMARY KEY auto_increment,
    name varchar(50) NOT NULL,
    eMail varchar(50) not null,
    password varchar(400) not null
);

create table exploro.scores(
	scoresId int primary key auto_increment,
    scores int not null,
    tijd time not null,
	userId int NOT NULL,
    gameId int not null,
    CONSTRAINT FK_users_scores
		FOREIGN KEY (userId)
		REFERENCES exploro.users(userId)
);
create table leaderboard(
	leaderboardId int primary key auto_increment,
	userId int not null,
    scoresId int not null,
	CONSTRAINT FK_leaderboard_scores
		FOREIGN KEY (scoresId)
		REFERENCES exploro.scores(scoresId),
	CONSTRAINT FK_leaderboard_users
		FOREIGN KEY (userId)
		REFERENCES exploro.users(userId)
    );

CREATE TABLE User
(
   user_id              INTEGER     PRIMARY KEY AUTOINCREMENT,
   email_address        TEXT        NOT NULL,
   password             TEXT        NOT NULL,
   source               TEXT        NOT NULL,
   first_name           TEXT,
   last_name            TEXT,
   profile_picture_url  TEXT,
   date_of_birth        DATETIME,
   about_me             TEXT,
   notifications        INTEGER,
   dark_theme           INTEGER,
   created_date         DATE
);
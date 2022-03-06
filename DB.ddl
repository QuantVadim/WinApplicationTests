CREATE TABLE classes (
    cls_id       serial PRIMARY KEY,
    name         VARCHAR(40) NOT NULL,
    description  VARCHAR(300)
);

CREATE TABLE groups (
    gr_id        serial PRIMARY KEY,
    name         VARCHAR(100) NOT NULL,
    description  VARCHAR(300) NOT NULL,
    usr_id       INTEGER NOT NULL,
    cls_id       INTEGER NOT NULL
);

CREATE TABLE results (
    res_id        serial PRIMARY KEY,
    body          VARCHAR(5000) NOT NULL,
    date_created  timestamp  NOT NULL,
    score         INTEGER,
    usr_id        INTEGER NOT NULL,
    wl_id         INTEGER NOT NULL
);

CREATE TABLE tests (
    tst_id        serial PRIMARY KEY,
    name          VARCHAR(100) NOT NULL,
    description   VARCHAR(300),
    date_created  timestamp  NOT NULL,
    body          VARCHAR(5000) NOT NULL,
    score         INTEGER NOT NULL,
    q_count       INTEGER NOT NULL,
    usr_id        INTEGER NOT NULL
);

CREATE TABLE users (
    usr_id     serial PRIMARY KEY,
    name       VARCHAR(30) NOT NULL,
    last_name  VARCHAR(30) NOT NULL,
    usr_type   VARCHAR(10) NOT NULL,
    cls_id     INTEGER NOT NULL,
    login      VARCHAR(100) NOT NULL,
    password   VARCHAR(100) NOT NULL
);

ALTER TABLE users ADD CONSTRAINT users__un UNIQUE ( login );

CREATE TABLE wall (
    wl_id         serial PRIMARY KEY,
    description   VARCHAR(300),
    date_created  timestamp  NOT NULL,
    hidden        CHAR(1),
    tst_id        INTEGER NOT NULL,
    gr_id         INTEGER NOT NULL
);


ALTER TABLE groups
    ADD CONSTRAINT groups_classes_fk FOREIGN KEY ( cls_id )
        REFERENCES classes ( cls_id );

ALTER TABLE groups
    ADD CONSTRAINT groups_classes_fk FOREIGN KEY ( usr_id )
        REFERENCES users ( usr_id );

ALTER TABLE results
    ADD CONSTRAINT results_users_fk FOREIGN KEY ( usr_id )
        REFERENCES users ( usr_id );

ALTER TABLE results
    ADD CONSTRAINT results_wall_fk FOREIGN KEY ( wl_id )
        REFERENCES wall ( wl_id );

ALTER TABLE tests
    ADD CONSTRAINT tests_users_fk FOREIGN KEY ( usr_id )
        REFERENCES users ( usr_id );

ALTER TABLE users
    ADD CONSTRAINT users_classes_fk FOREIGN KEY ( cls_id )
        REFERENCES classes ( cls_id );

ALTER TABLE wall
    ADD CONSTRAINT wall_groups_fk FOREIGN KEY ( gr_id )
        REFERENCES groups ( gr_id );

ALTER TABLE wall
    ADD CONSTRAINT wall_tests_fk FOREIGN KEY ( tst_id )
        REFERENCES tests ( tst_id );

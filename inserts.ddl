insert into classes (name, description) VALUES
	('Администраторы', ''),
	('Преподаватели', ''),
	('5-A', '')
	;

insert into users (login, password, name, last_name, usr_type, cls_id) VALUES 
	('admin', 'admin', 'Админ', 'Главный', 'admin', 1),
	('invan', 'ivan', 'Иван', 'Иванов', 'teacher', 2 ),
	('petya', 'petya', 'Петр', 'Петров', 'student', 3)
	;

insert into groups (name, description, usr_id, cls_id) VALUES
	('Математика', '', 2, 3),
	('Русский язык', '', 2, 3)
	;

insert into tests (name, description, date_created, body, score, q_count, usr_id) VALUES 
	('Тест 1', '', current_timestamp, 'body', 10, 10, 1);

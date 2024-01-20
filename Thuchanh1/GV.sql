--DROP TABLE GiaoVien;

CREATE TABLE GiaoVien (
	ID int IDENTITY(1,1) PRIMARY KEY,
	Ten varchar(100),
	Diachi varchar(255),
	Cmnd varchar(100) unique not null,
	NgSinh DateTime,
	SDT varchar(20)

);

--INSERT INTO HocSinh(Ten, DiaChi, Cmnd, NgSinh) VALUES('dong gia sang', 'dong nai', '123', '25-10-2004');
--INSERT INTO HocSinh(Ten, DiaChi, Cmnd, NgSinh) VALUES('dong gia toan', 'hcmc', '124', '24-10-2004');
--INSERT INTO HocSinh(Ten, DiaChi, Cmnd, NgSinh) VALUES('dong gia kiet', 'kieng giang ', '125', '20-10-2004');
--INSERT INTO HocSinh(Ten, DiaChi, Cmnd, NgSinh) VALUES('dong gia b', 'an giang', '126', '3-10-2004');

select * from GiaoVien;
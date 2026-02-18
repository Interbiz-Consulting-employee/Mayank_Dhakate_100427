-- University
INSERT INTO University VALUES
(1, 'AAAAAA University', 'Private', 'A', 'Mumbai, Maharashtra, India'),
(2, 'BBBBBB University', 'Public', 'B', 'Delhi, India'),
(3, 'CCCCCC University', 'Private', 'A', 'Bangalore, Karnataka, India');

-- College
INSERT INTO College VALUES
(1, 'AAAAAA Engineering College', 'Engineering', 'Mumbai, Maharashtra', 1),
(2, 'AAAAAA Science College', 'Science', 'Mumbai, Maharashtra', 1),
(3, 'BBBBBB Arts College', 'Arts', 'Delhi', 2),
(4, 'BBBBBB Commerce College', 'Commerce', 'Delhi', 2),
(5, 'CCCCCC Technology College', 'Engineering', 'Bangalore, Karnataka', 3);

-- Department
INSERT INTO Department VALUES
(1, 'Computer Science', 10, 'Dr. Ananya Sharma', 1),
(2, 'Mechanical Engineering', 8, 'Dr. Vikram Patel', 1),
(3, 'Physics', 6, 'Dr. Meera Joshi', 2),
(4, 'History', 5, 'Dr. Rahul Desai', 3),
(5, 'Commerce', 7, 'Dr. Sneha Kapoor', 4),
(6, 'Electronics', 8, 'Dr. Rohan Mehta', 5);

-- Professor
INSERT INTO Professor VALUES
(1, 'Dr. Ananya Sharma', 'Mumbai', 50, 77000, 1),
(2, 'Dr. Vikram Patel', 'Mumbai', 45, 62000, 2),
(3, 'Dr. Meera Joshi', 'Delhi', 48, 56000, 3),
(4, 'Dr. Rahul Desai', 'Bangalore', 52, 50000, 4),
(5, 'Dr. Sneha Kapoor', 'Delhi', 49, 67000, 5),
(6, 'Dr. Rohan Mehta', 'Bangalore', 47, 71000, 6);

-- Student
INSERT INTO Student VALUES
(1, 'Aryan Malhotra', 'Mumbai', 21, 90.0, 900, 'First', 1),
(2, 'Ishita Sharma', 'Mumbai', 22, 85.5, 855, 'First', 1),
(3, 'Karan Gupta', 'Mumbai', 23, 76.0, 760, 'Second', 2),
(4, 'Tanya Kapoor', 'Mumbai', 22, 68.0, 680, 'Third', 2),
(5, 'Raghav Jain', 'Delhi', 21, 82.0, 820, 'First', 3),
(6, 'Maya Verma', 'Delhi', 22, 72.0, 720, 'Second', 3),
(7, 'Nikhil Mehta', 'Delhi', 23, 58.0, 580, 'Third', 4),
(8, 'Anika Reddy', 'Bangalore', 22, 96.0, 960, 'First', 6),
(9, 'Aditya Singh', 'Bangalore', 21, 87.0, 870, 'First', 6),
(10, 'Divya Nair', 'Bangalore', 22, 79.0, 790, 'Second', 5);

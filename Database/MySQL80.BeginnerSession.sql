-- CREATE TABLE employee (
--     emp_id INT PRIMARY KEY,
--     first_name VARCHAR(40),
--     last_name VARCHAR(40),
--     birth_day DATE,
--     sex VARCHAR(1),
--     salary INT,
--     super_id INT,
--     branch_id INT
-- );

-- CREATE TABLE branch(
--     branch_id INT PRIMARY KEY,
--     branch_name VARCHAR(40),
--     mgr_id INT,
--     mgr_start_date DATE,
--     FOREIGN KEY(mgr_id) REFERENCES employee(emp_id) ON DELETE SET NULL
-- );

-- ALTER TABLE employee
-- ADD FOREIGN KEY(branch_id)
-- REFERENCES branch(branch_id)
-- ON DELETE SET NULL;

-- ALTER TABLE employee
-- ADD FOREIGN KEY(super_id)
-- REFERENCES employee(emp_id)
-- ON DELETE SET NULL;

-- CREATE TABLE client(
--     client_id INT PRIMARY KEY,
--     client_name VARCHAR(40),
--     branch_id INT,
--     FOREIGN KEY(branch_id) REFERENCES branch(branch_id) ON DELETE SET NULL
-- );

-- CREATE TABLE works_with(
--     emp_id INT,
--     client_id INT,
--     total_sales INT,
--     PRIMARY KEY(emp_id, client_id),
--     FOREIGN KEY(emp_id) REFERENCES employee(emp_id) ON DELETE CASCADE,
--     FOREIGN KEY(client_id) REFERENCES client(client_id) ON DELETE CASCADE
-- );

-- CREATE TABLE branch_supplier(
--     branch_id INT,
--     supplier_name VARCHAR(40),
--     supplier_type VARCHAR(40),
--     PRIMARY KEY(branch_id, supplier_name),
--     FOREIGN KEY(branch_id) REFERENCES employee(emp_id) ON DELETE CASCADE
-- );

-- Insert data into created TABLES
-- INSERT INTO employee VALUES(100, 'David', 'Wallace', '1967-11-17', 'M', 250000, NULL, NULL);
-- INSERT INTO branch VALUES(1, 'Corporate', 100, '2006-02-09');

-- UPDATE employee
-- SET branch_id =1
-- WHERE emp_id = 100;

-- INSERT INTO employee VALUES(101, 'Jan', 'Levinson', '1961-05-11', 'F', 110000, 100, 1);

-- Name the created cloumn defrently, when retriving the DATA
-- SELECT first_name AS forename, last_name AS surename
-- FROM employee;

-- Find out all the different genders
-- SELECT DISTINCT sex
-- FROM employee;

-- Find the number of employes
-- SELECT COUNT(emp_id)
-- FROM employee;

--Find a pattern in a string
-- SELCT * 
-- FROM client
-- WHERE client_name LIKE '%LLC';          -- any number of characters can come bevore LLC, but has to end with LLC

-- Union - combines multiple statements into one -> but you have to have the same amount of columns
-- Find a list of employee and branch names
-- SELECT first_name
-- FROM employee
-- UNION 
-- SELECT branch_name
-- FROM branch;

-- Joins - is basically used to combine rows from two or more tables based on a related column between them
SELECT employee.emp_id, employee.first_name, branch.branch_name
FROM employee
JOIN branch
ON employee.emp_id = branch.mgr_id;
-- we cann also use LEFT JOIN or RIGHT JOIN (there is also a forth one called: FULL OUTER JOIN)

-- Nested Queries
SELECT employee.first_name, employee.last_name
FROM employee
WHERE employee.emp_id IN (
    SELECT works_with.emp_id
    FROM works_with
    WHERE works_with.total_sales > 30000
);

-- Triggers - need to be executed in MySQL Commend Line Client
DELIMITER $$
CREATE
    TRIGGER my_trigger BEFORE INSERT
    ON employee
    FOR EACH ROW BEGIN
        INSERT INTO trigger_test VALUES('added new employee');
    END$$
DELIMITER ;
-- u can also use conditionals with triggers
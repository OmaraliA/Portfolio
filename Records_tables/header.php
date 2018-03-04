<?php 
	include 'connect.php';

$sql = "CREATE TABLE students (
student_id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
first_name VARCHAR(30) NOT NULL,
last_name VARCHAR(30) NOT NULL,
email_address VARCHAR(50)

)";

if ($connection->query($sql) === TRUE) {
    echo "Table students created successfully";
} else {
    echo "Error creating table: " . $connection->error;
}

$sql = "INSERT INTO students (student_id, first_name, last_name, email_address) VALUES (1, 'Peter', 'Parker', 'peterparker@mail.com')";

$sql = "INSERT INTO students (student_id, first_name, last_name, email_address) VALUES (1, 'Aru', 'Omarali', 'a.o@mail.com')";

$sql = "INSERT INTO students (student_id, first_name, last_name, email_address) VALUES (1, 'Indira', 'Baimbetova', 'i.b@mail.com')";

if(mysqli_query($connection, $sql)){
    echo "Records added successfully.";
} else{
    echo "ERROR: Could not able to execute $sql. " . mysqli_error($connection);
}
 
$sql = "SELECT last_name, first_name FROM students";
$result = $connection->query($sql);

if ($result->num_rows > 0) {
    while($row = $result->fetch_assoc()) {
        echo "Surname: " . $row["last_name"]. " - Name: " . $row["first_name"];
    }
} else {
    echo "0 results";
}

$sql = "UPDATE students SET last_name='Doe' WHERE student_id=1";

if ($connection->query($sql) === TRUE) {
    echo "Record updated successfully";
} else {
    echo "Error updating record: " . $connection->error;
}

/*$sql = "DELETE FROM students WHERE student_id=1";

if ($connection->query($sql) === TRUE) {
    echo "Record deleted successfully";
} else {
    echo "Error deleting record: " . $connection->error;
}*/
mysqli_close($connection);

 ?>
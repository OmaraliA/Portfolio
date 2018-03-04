<?php
ini_set('display_errors', 1);
 require('connect.php');
 require('main1.php');


if(isset($_POST['submit'])){
 
$student = $_POST['student_id'];
$query =@mysqli_query($conn, "DELETE FROM students WHERE student_id = '$student'");

}



else if(isset($_POST['submit1'])){
 
$name = $_POST['name'];
$query =@mysqli_query($conn, "DELETE FROM students WHERE first_name = '$name'");

}


else if(isset($_POST['submit2'])){
 
$surname = $_POST['lastname'];
$query =@mysqli_query($conn, "DELETE FROM students WHERE last_name = '$surname'");

}

?>




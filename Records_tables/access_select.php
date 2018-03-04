<?php
ini_set('display_errors', 1);
 require('connect.php');
 require('main.php');


if(isset($_POST['submit'])){
 
$student = $_POST['student_id'];
$query =mysqli_query($conn,"SELECT * FROM students WHERE student_id = '$student'");
$row = mysqli_fetch_array($query);

if($row)
{

echo "<br><br>Имя: ".$row['first_name']."<br>";
echo "Фамилия: ".$row['last_name']."<br><hr>";
}

else {
	echo ("<br>There is no student with that ID <br/><br/>");

}
}

else if(isset($_POST['submit1'])){
 
$name = $_POST['name'];
$query =mysqli_query($conn,"SELECT * FROM students WHERE first_name = '$name'");
$row = mysqli_fetch_array($query);

if($row)
{

echo "<br><br>ID: ".$row['student_id']."<br>";
echo "Surname: ".$row['last_name']."<br><hr>";
}

else {
	echo ("<br>There is no student with that name <br/><br/>");

}

}


else if(isset($_POST['submit2'])){
 
$surname = $_POST['lastname'];
$query =mysqli_query($conn,"SELECT * FROM students WHERE last_name = '$surname'");
$row = mysqli_fetch_array($query);

if($row)
{

echo "<br><br>Имя: ".$row['student_id']."<br>";
echo "Фамилия: ".$row['first_name']."<br><hr>";
}

else {
	echo ("<br><br>There is no student with that surname <br/><br/>");

}


}
?>




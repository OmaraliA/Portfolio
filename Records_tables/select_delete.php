<!DOCTYPE HTML>
<html>
<head>
<link href="https://fonts.googleapis.com/css?family=Nunito" rel="stylesheet">
<link rel="stylesheet" type="text/css" href="table.css">
<title>Update</title>
</head>

<body>
<?php
require 'connect.php';
$id = $_REQUEST['user'];
$select_sql ="SELECT * FROM students WHERE student_id= '$id'";
$result = mysqli_query($conn, $select_sql);
$row = mysqli_fetch_array($result);

printf("<form action='delete.php' method='POST'>
<br><br><p>Change the info</p>
<input type='hidden' name='student_id'  value='%s'><br/>
<label for='first_name'></label><br/>
<input type='text' name='first_name' value='%s'><br/>
<label for='last_name'></label><br/>
<input type='text' name='last_name' value='%s'><br/>
<label for='email'></label><br/>
<input type='text' name='email_address' value='%s'><br/>

<br/>

<input id='submit' type='submit' value='Update the table'><br/>

</form>",$row['student_id'], $row['first_name'], $row['last_name'], $row['email_address']);
?>

<a href="select_change.php">Go to the select page</a><br/><br/>
</body>
</html>
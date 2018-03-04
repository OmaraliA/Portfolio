<html>
<body>

<link href="https://fonts.googleapis.com/css?family=Nunito" rel="stylesheet">
<link rel="stylesheet" type="text/css" href="table.css">
<form action="select_delete.php" method="POST" class="table">

	
<?php
require 'connect.php';
$select_sql = "SELECT student_id, first_name, last_name, email_address FROM students";
$result = mysqli_query($conn, $select_sql);
$row = mysqli_fetch_array($result);
do
{
printf("<input type='radio' name='user' value='%s'>%s %s<br/><br/></div>", $row['student_id'], $row['first_name'],  $row['last_name'],  $row['email_address']);	
}
while($row = mysqli_fetch_array($result))
?>

<input type="submit" value="Select student to change">

</form>

</body>
</html>
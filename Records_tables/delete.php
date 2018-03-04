<body>
<?php
require 'connect.php';
$id=$_REQUEST['student_id'];
$first_name=trim($_REQUEST['first_name']);
$last_name=trim($_REQUEST['last_name']);
$email=trim($_REQUEST['email_address']);


$update_sql = "UPDATE students SET first_name='$first_name', last_name='$last_name', email_address='$email' WHERE student_id='$id'";
mysqli_query($conn, $update_sql) or die("Error!" . mysqli_error());
echo '<p>UPDATE is done!</p>';
?>

</body>
</html>
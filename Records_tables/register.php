<?php 

	require('connect.php');
	require('file.php');
	$error = false;
	if(isset($_POST['name']) && isset($_POST['user']) && isset($_POST['password'])){
		header("Location: register.php");
		$name = $_POST['name'];
		$user = $_POST['user'];
		$password = $_POST['password'];
		$sql = "INSERT INTO users (full_name, user_login, user_password)
		VALUES ('$name', '$user', '$password')";

  if (!preg_match("/^[a-zA-Z ]+$/",$name)) {
        $error = true;
        $name_error = "Name must contain only alphabets and space";
        echo $name_error;
        }


      if (empty($password) && empty($user) && empty($name)){

	   echo "<script> alert ('Email or password is inccorect')</script>";
	  } 


	  else if(strlen($pass) < 6) {
	   $error = true;
	   $passError = "Password must have at least 6 characters.";
	    echo $passError; 
	  }

		if (mysqli_query($conn, $sql)) {
		    
		} else {
		    echo "Error: " . $sql . "<br>" . mysqli_error($conn);
		}
		mysqli_close($conn);
	}
 ?>
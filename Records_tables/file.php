<!DOCTYPE html>
<html>
 <link rel="stylesheet" href="main.css">
<head>
	<title>Registration page</title>
</head>
<body>
	<form action="register.php" method="POST">
	<h2>Register</h2>
		<input type="text" name="name" placeholder="name">
		<input type="text" name="user" placeholder="user">
		<input type="password" name="password" placeholder="password"><br>
		<button type="submit">Register</button>
		<p>Already have an account?</p><a href="login.php">Sign in</a>
	</form>
</body>
</html>
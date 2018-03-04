<!DOCTYPE html>
<html>
<head>
	<title>Main</title>
</head>
<link href="https://fonts.googleapis.com/css?family=Nunito" rel="stylesheet">
<link rel="stylesheet" type="text/css" href="style1.css">
<body>


<div class="all">

<form method="POST" action="access_delete.php" class="first">
<h3>Delete by ID</h3>
 <input type="text" name="student_id" placeholder="ID"><br><br>
<button type="submit" name ="submit">Delete</button>
</form>


<form method="POST" action="access_delete.php" class="second">
<h3>Delete by name</h3>
 <input type="text" name="name" placeholder="name"><br><br>
<button type="submit" name ="submit1">Delete</button>
</form>

<form method="POST" action="access_delete.php" class="third">
<h3>Delete by surname</h3>

<input type="text" name="lastname" placeholder="surname"><br><br>
<button type="submit" name ="submit2">Delete</button>
</body>
</form>
</div>
</html>
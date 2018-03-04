<?php 
ini_set('display_errors', 1);
  require('login_page.php');
  require('connect.php');

  if(isset($_POST['submit'])){
 
  	  $user = $_POST['user'];
      $password = $_POST['password'];

    

     $check_user =mysqli_query( $conn, "SELECT *FROM users  WHERE user_login = '$user' AND user_password = '$password'")
                              or die ("failed to query database ".mysqli_error() );
      
      $result = mysqli_fetch_array($check_user);



      if($result['user_login']==$user && $result['user_password']== $password ){ 

       $_SESSION['user'] = $user;
       header("location: access.php");
       
       
      }

	 
      else {
        echo "<script> alert ('Email or password is inccorect')</script>";
       // header("Location: login.php");
        
      }


mysqli_close($conn); 

 
} 

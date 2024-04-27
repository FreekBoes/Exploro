<?php
  include './dbh.php';

  $response = array();

  $email = $_POST['email'];
  $password = $_POST['password'];

  $email = mysqli_real_escape_string($conn,$email);
  $password = mysqli_real_escape_string($conn,$password);

  $sql = "SELECT * FROM `users` WHERE `eMail` = '$email' LIMIT 1";
  $result = mysqli_query($conn,$sql);
  $row = mysqli_fetch_array($result);
  if ($row) {
    if (password_verify($password,$row['password'])) {
      session_start();
      $_SESSION['eMail'] = $email;
      echo json_encode('success');
      exit();
      }
  }
  echo json_encode('error');
 ?>

<?php
    include "./dbh.php";
    
    $name = $_POST['name'];
    $email = $_POST['email'];
    $password = $_POST['password'];

    $name = mysqli_real_escape_string($conn,$name);
    $email = mysqli_real_escape_string($conn,$email);
    $password = mysqli_real_escape_string($conn,$password);
    $validemail = filter_var($email, FILTER_VALIDATE_EMAIL);
    if ($validemail){
    $sql = "SELECT * FROM `users` WHERE `eMail` = '$email' LIMIT 1";
    $result = mysqli_query($conn,$sql);
    $row = mysqli_fetch_array($result);
    if ($row) {
        echo json_encode('error');
        exit();
        
    }
        
    
    else{
        echo json_encode('success');
        

    $password = password_hash($password, PASSWORD_DEFAULT);
    $sql = "INSERT INTO `users` (`name`, `eMail`, `password`)
    VALUES
    ('$name', '$email', '$password')";
    mysqli_query($conn,$sql);
    
    session_start();
    $_SESSION['eMail'] = $email;

    }
    }

 
?>

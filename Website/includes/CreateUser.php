<?php
    include "./dbh.php";
    
    $name = $_POST['name'];
    $eMail = $_POST['email'];
    $password = $_POST['password'];

    $name = mysqli_real_escape_string($conn,$name);
    $eMail = mysqli_real_escape_string($conn,$eMail);
    $password = mysqli_real_escape_string($conn,$password);
    $validemail = filter_var($eMail, FILTER_VALIDATE_EMAIL);
    if ($validemail){
    $sql = "SELECT * FROM `users` WHERE `eMail` = '$eMail' LIMIT 1";
    $result = mysqli_query($conn,$sql);
    $row = mysqli_fetch_array($result);
    if ($row) {
        echo json_encode('error');
        exit();
    }
            
    echo json_encode('success');
    }
    else{
        exit();
    }
    $password = password_hash($password, PASSWORD_DEFAULT);
    $sql = "INSERT INTO `users` (`name`, `eMail`, `password`)
    VALUES
    ('$name', '$eMail', '$password')";
    mysqli_query($conn,$sql);

?>

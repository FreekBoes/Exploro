function login() {
    const email = $('#form3Example3').val();
    const password = $('#form3Example4').val();
    if (!email || !password) {
        alert('Niet alle velden zijn ingevuld!');
    } else {
        $.ajax({
            url: '../includes/login.php',
            method: 'POST',
            data: {
                email,
                password
            },
            dataType: 'json',
            success: function (data) {
                if (data == 'error') {
                    alert('Email of wachtwoord incorrect.');

                } else {
                    alert('Successvol ingelogd.');
                    window.location.href = '/index.php';
                }

            }
        });
    }
}


function createUser() {
    const name = $('#name').val();
    const email = $('#email').val();
    const password = $('#password').val();
    const passwordcheck = $('#passwordrepeat').val();
    const TOS = $('#tos').is(":checked");

    if (!name || !email || !password || !passwordcheck || !TOS) {
        alert('Niet alle velden zijn ingevuld!');
    } else if (password !== passwordcheck) {
        alert('Wachtwoorden komen niet overeen!');
    } else {
        $.ajax({
            url: '../includes/CreateUser.php',
            method: 'POST',
            data: {
                name,
                email,
                password,
            },
            dataType: 'json',
            success: function (data) {
                if (data == 'error') {
                    alert('Email bestaat al!')
                } else {
                    alert('Account succesvol aangemaakt.');
                    window.location.href = '/login.html';
                }
            }
        });
    }
}

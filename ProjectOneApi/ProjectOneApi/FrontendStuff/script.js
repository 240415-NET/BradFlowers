const { fuchsia } = require("color-name");

document.addEventListener('DOMContentLoaded', () => {

    const loginContainer = document.getElementById('login-container');
    const userContainer = document.getElementById('user-container');


    const loginButton = document.getElementById('login-button');
    const logoutButton = document.getElementById('logout-button');
    const welcomeMessage = document.getElementById('welcome-message');

    loginButton.addEventListener('click', async () => {

        const username = document.getElementById('username').value;

        if (username) {
            try {
                const response = await fetch(`http://localhost:5116/Users/${username}`);

                const user = await response.json();

                localStorage.setItem('user', JSON.stringify(user));
            }
            catch (error) {
                console.error('Error logging in', error);
            }
        }

    });

    function updateUIForLoggedInUser(user) {
        loginContainer.style.display = 'none';
        welcomeMessage.Text = `Welcome ${user.userName}`;
        userContainer.style.display = 'block';
    }



});

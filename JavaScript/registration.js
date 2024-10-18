// Listen for form submission
document.getElementById("registrationForm").addEventListener("submit", function (e) {
    e.preventDefault();  

    let username = document.getElementById("Username").value;
    let email = document.getElementById("Email").value;
    let password = document.getElementById("Password").value;
    
    if (username === "" || email === "" || password === "") {
        displayRegError("All fields are required!");
        return;
    }

    let userDetails = {
        email: email,
        password: password 
    };
    localStorage.setItem(username, JSON.stringify(userDetails));

    alert("Registration successful! You can now log in.");
});

function displayRegError(message) {
    let errorDiv = document.getElementById("ErrorMsg");
    errorDiv.textContent = message;
}

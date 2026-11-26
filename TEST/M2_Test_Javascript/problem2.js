const expectedUsername = 'demo';
const expectedPassword = 'example-password';

function login(username, password) {
    return new Promise((resolve, reject) => {
        if (username === expectedUsername && password === expectedPassword) {
            resolve('Login successful!');
        } else {
            reject('Invalid username or password.');
        }
    });
}
login(expectedUsername, expectedPassword)
    .then(message => console.log(message)) 
    .catch(error => console.error(error));
login('hariom', 'invalid-password')
    .then(message => console.log(message))
    .catch(error => console.error(error));

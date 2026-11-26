export default function Login({ setAuth }) {
  return (
    <div>
      <h2>Login Page</h2>
      <button onClick={() => setAuth(true)}>
        Login
      </button>
    </div>
  );
}
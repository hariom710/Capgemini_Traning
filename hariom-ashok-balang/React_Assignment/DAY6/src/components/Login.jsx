import useAuth from "../hooks/useAuth";

export default function Login() {
  const { setUser } = useAuth();

  return (
    <button onClick={() => setUser("Hariom")}>
      Login
    </button>
  );
}
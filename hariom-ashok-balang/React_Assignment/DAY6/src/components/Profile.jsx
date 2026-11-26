import useAuth from "../hooks/useAuth";

export default function Profile() {
  const { user } = useAuth();

  return <h2>User: {user}</h2>;
}
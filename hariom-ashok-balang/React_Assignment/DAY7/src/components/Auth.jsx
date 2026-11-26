import { useSelector, useDispatch } from "react-redux";

export default function Auth() {
  const auth = useSelector(s => s.auth);
  const d = useDispatch();

  return (
    <div>
      {auth ? (
        <>
          <h3>Welcome User</h3>
          <button onClick={() => d({ type: "LOGOUT" })}>
            Logout
          </button>
        </>
      ) : (
        <button onClick={() => d({ type: "LOGIN" })}>
          Login
        </button>
      )}
    </div>
  );
}
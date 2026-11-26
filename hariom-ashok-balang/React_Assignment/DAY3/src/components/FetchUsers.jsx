import { useState, useEffect } from "react";

export default function FetchUsers() {
  const [usr, setUsr] = useState([]);

  useEffect(() => {
    fetch("https://jsonplaceholder.typicode.com/users")
      .then((r) => r.json())
      .then((d) => setUsr(d));
  }, []);

  return (
    <div>
      <h2>Users</h2>
      {usr.map((u) => (
        <p key={u.id}>
          {u.name} - {u.email}
        </p>
      ))}
    </div>
  );
}
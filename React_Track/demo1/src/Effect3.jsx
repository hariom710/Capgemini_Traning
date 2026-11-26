import { useEffect, useState } from "react";

export default function Effect3() {
    const [users, setUsers] = useState([]);
    useEffect(() => {
        fetch("https://jsonplaceholder.typicode.com/users")
            .then((response) => response.json())
            .then((data) => setUsers(data));
    }, []);

    return (
        <div>
            {users.map((user) => (
                <p key={user.id}>{user.name}</p>
            ))}
        </div>
    )
}
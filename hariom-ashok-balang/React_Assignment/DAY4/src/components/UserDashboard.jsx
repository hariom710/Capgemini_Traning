import UserCard from "./UserCard";

export default function UserDashboard({ users }) {
  return (
    <div>
      <h2>User Dashboard</h2>
      {users.map((u, i) => (
        <UserCard key={i} user={u} />
      ))}
    </div>
  );
}
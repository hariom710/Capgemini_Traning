import StatusBadge from "./StatusBadge";

export default function UserCard({ user }) {
  return (
    <div>
      <p>Name: {user.name}</p>
      <p>Role: {user.role}</p>
      <StatusBadge status={user.status} />
    </div>
  );
}
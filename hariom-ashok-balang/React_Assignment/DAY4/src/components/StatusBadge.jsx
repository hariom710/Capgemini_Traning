export default function StatusBadge({ status }) {
  return (
    <span>
      {status === "Active" ? "🟢 Active" : "🔴 Inactive"}
    </span>
  );
}
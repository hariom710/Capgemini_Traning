export default function NotificationItem({ notif }) {
  return (
    <p>
      {notif.unread ? "🔔 " : "✔️ "}
      {notif.text}
    </p>
  );
}
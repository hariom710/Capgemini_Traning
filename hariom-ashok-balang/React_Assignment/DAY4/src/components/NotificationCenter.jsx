import NotificationItem from "./NotificationItem";

export default function NotificationCenter({ notifications }) {
  return (
    <div>
      <h2>Notifications</h2>
      {notifications.length === 0 ? (
        <p>No Notifications</p>
      ) : (
        notifications.map((n, i) => (
          <NotificationItem key={i} notif={n} />
        ))
      )}
    </div>
  );
}
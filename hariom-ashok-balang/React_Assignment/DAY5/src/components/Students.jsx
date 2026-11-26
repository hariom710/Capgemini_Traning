export default function Students() {
  const students = ["Amit", "Neha", "Rahul"];

  return (
    <div>
      <h2>Students</h2>
      {students.map((s, i) => (
        <p key={i}>{s}</p>
      ))}
    </div>
  );
}
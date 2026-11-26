import StudentCard from "./StudentCard";

export default function StudentList({ students }) {
  return (
    <div>
      <h2>Students</h2>
      {students.map((s, i) => (
        <StudentCard key={i} student={s} />
      ))}
    </div>
  );
}
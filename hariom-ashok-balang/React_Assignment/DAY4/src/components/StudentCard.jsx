import GradeBadge from "./GradeBadge";

export default function StudentCard({ student }) {
  const grade =
    student.marks >= 90
      ? "A"
      : student.marks >= 75
      ? "B"
      : student.marks >= 50
      ? "C"
      : "F";

  return (
    <div>
      <p>{student.name} - {student.marks}</p>
      <GradeBadge grade={grade} />
    </div>
  );
}
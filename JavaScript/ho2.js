const students = [
    { name: "Alice", status: true },
    { name: "Bob",   status: false },
    { name: "Charlie", status: true },
    { name: "David", status: false },
    { name: "Eve",   status: true }
];

const passedStudents = students.filter(stu => stu.status === true);
console.log(passedStudents);

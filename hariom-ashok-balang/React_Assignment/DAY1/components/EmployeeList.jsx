function EmployeeList() {
  const employees = [
    { id: 1, name: "Rahul", dept: "IT", salary: 50000 },
    { id: 2, name: "Amit", dept: "HR", salary: 40000 },
    { id: 3, name: "Sneha", dept: "Finance", salary: 60000 }
  ]

  return (
    <div>

      {employees.map(emp => (
        <div key={emp.id}>
          <p>Name: {emp.name}</p>
          <p>Department: {emp.dept}</p>
          <p>Salary: ₹{emp.salary}</p>
          <hr />
        </div>
      ))}
    </div>
  )
}

export default EmployeeList
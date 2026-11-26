function StudentCard() {
  const style = {
    border: "1px solid black",
    padding: "10px",
    margin: "10px",
    borderRadius: "8px"
  }

  return (
    <div style={style}>
      <h2>Name: Hariom Balang</h2>
      <p>Course: B.Tech Computer Technology</p>
      <p>Age: 21</p>
      <p>Email: hariom@email.com</p>
    </div>
  )
}

export default StudentCard
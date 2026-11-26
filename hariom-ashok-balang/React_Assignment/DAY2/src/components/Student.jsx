import { useState } from 'react'
function Student({ name, subject1, subject2, subject3 }) {
  const [total, setTotal] = useState(0)
  const calculateTotal = () => {
    setTotal(subject1 + subject2 + subject3)
  }
  return (
    <div>
      <h3>Name: {name}</h3>
      <p>Subject1: {subject1}</p>
      <p>Subject2: {subject2}</p>
      <p>Subject3: {subject3}</p>
      <button onClick={calculateTotal}>
        Calculate Total
      </button>

      <h4>Total: {total}</h4>
    </div>
  )
}
export default Student
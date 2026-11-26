import { useState } from 'react'

function Greeting({ username }) {
  const [showGreeting, setShowGreeting] = useState(false)

  return (
    <div>
      <button onClick={() => setShowGreeting(true)}>
        Show Greeting
      </button>

      <button 
        onClick={() => setShowGreeting(false)}
        style={{ marginLeft: "10px" }}
      >
        Hide Greeting
      </button>

      {showGreeting && (
        <h3>Hello, {username}!</h3>
      )}
    </div>
  )
}

export default Greeting
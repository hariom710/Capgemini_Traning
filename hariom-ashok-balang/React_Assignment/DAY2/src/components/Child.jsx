import { useState } from 'react'

function Child({ name, role }) {
  const [likes, setLikes] = useState(0)

  return (
    <div>
      <h3>{name}</h3>
      <p>Role: {role}</p>
      <p>Likes: {likes}</p>

      <button onClick={() => setLikes(likes + 1)}>
        Like
      </button>
    </div>
  )
}

export default Child
import { useState } from 'react'
function Counter({ initialValue }) {
    const [count, setCount] = useState(initialValue)
    return (
        <div>
            <h3>Counter: {count}</h3>
            <button onClick={() => setCount(count + 1)}>
                Increment
            </button>
            <button
                onClick={() => setCount(count > 0 ? count - 1 : 0)}
                style={{ marginLeft: "10px" }}
            >
                Decrement
            </button>
        </div>
    )
}
export default Counter
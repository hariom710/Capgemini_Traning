import { useEffect, useState } from "react";

export default function Effect() {
  const [count, setCount] = useState(0);
  useEffect(() => {
    document.title = `You clicked ${count} times`;
  }, [count]);

  return (
    <div>
      <h1>Effect</h1>
        <p>count: {count}</p>
        <button onClick={() => setCount(count + 1)}>Click me</button>
    </div>
  );
}
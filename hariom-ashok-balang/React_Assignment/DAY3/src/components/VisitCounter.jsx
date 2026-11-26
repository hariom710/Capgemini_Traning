import { useState, useEffect } from "react";

export default function VisitCounter() {
  const [cnt, setCnt] = useState(0);

  useEffect(() => {
    console.log("Visited:", cnt);
  }, [cnt]);

  return (
    <div>
      <h2>Visit Count: {cnt}</h2>
      <button onClick={() => setCnt(cnt + 1)}>
        Visit Page
      </button>
    </div>
  );
}
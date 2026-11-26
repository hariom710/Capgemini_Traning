import { useState, useEffect } from "react";

export default function DigitalClock() {
  const [tm, setTm] = useState(new Date());

  useEffect(() => {
    const t = setInterval(() => {
      setTm(new Date());
    }, 1000);

    return () => clearInterval(t);
  }, []);

  return (
    <h2>{tm.toLocaleTimeString()}</h2>
  );
}
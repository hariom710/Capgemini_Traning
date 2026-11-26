import { useState, useEffect } from "react";

export default function BgColorChanger() {
  const [clr, setClr] = useState(null);

  const rnd = () => {
    return "#" + Math.floor(Math.random() * 16777215)
      .toString(16)
      .padStart(6, "0");
  };

  useEffect(() => {
    if (clr !== null) {
      document.body.style.backgroundColor = clr;
    }
  }, [clr]);

  return (
    <button onClick={() => setClr(rnd())}>
      Change Color
    </button>
  );
}
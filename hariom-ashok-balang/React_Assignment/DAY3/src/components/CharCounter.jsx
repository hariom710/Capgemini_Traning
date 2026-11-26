import { useState, useEffect } from "react";

export default function CharCounter() {
  const [txt, setTxt] = useState("");
  const [cnt, setCnt] = useState(0);

  useEffect(() => {
    setCnt(txt.length);
  }, [txt]);

  return (
    <div>
      <input
        value={txt}
        onChange={(e) => setTxt(e.target.value)}
        placeholder="Type..."
      />
      <p>Characters: {cnt}</p>
    </div>
  );
}
import { useState } from "react";
import { useDispatch } from "react-redux";

export default function TodoInput() {
  const [txt, setTxt] = useState("");
  const d = useDispatch();

  return (
    <div>
      <input onChange={e => setTxt(e.target.value)} />
      <button onClick={() => d({ type: "ADD", payload: txt })}>
        Add
      </button>
    </div>
  );
}
import { useSelector, useDispatch } from "react-redux";

export default function Counter() {
  const count = useSelector(s => s.counter.count);
  const d = useDispatch();

  return (
    <div>
      <h2>{count}</h2>
      <button onClick={() => d({ type: "INC" })}>+</button>
      <button onClick={() => d({ type: "DEC" })}>-</button>
    </div>
  );
}
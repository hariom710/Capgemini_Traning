import { useSelector, useDispatch } from "react-redux";

export default function Theme() {
  const theme = useSelector((s) => s.theme);
  const d = useDispatch();

  return (
    <div>
      <h3>Theme: {theme}</h3>
      <button onClick={() => d({ type: "TOGGLE" })}>
        Toggle
      </button>
    </div>
  );
}
import { useSelector, useDispatch } from "react-redux";

export default function TodoList() {
  const todos = useSelector(s => s.todos);
  const d = useDispatch();

  return (
    <div>
      {todos.map((t, i) => (
        <p key={i}>
          {t}
          <button onClick={() => d({ type: "DEL", payload: i })}>
            X
          </button>
        </p>
      ))}
    </div>
  );
}
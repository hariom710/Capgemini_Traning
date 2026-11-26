import { useSelector } from "react-redux";

import Counter from "./components/Counter";
import TodoInput from "./components/TodoInput";
import TodoList from "./components/TodoList";
import Auth from "./components/Auth";
import Cart from "./components/Cart";
import Theme from "./components/Theme";

export default function App() {
  const theme = useSelector((state) => state.theme);

  return (
    <div
      style={{
        textAlign: "center",
        minHeight: "100vh",
        backgroundColor: theme === "dark" ? "#000" : "#fff",
        color: theme === "dark" ? "#fff" : "#000"
      }}
    >
      <h1>React Day7 Redux</h1>

      <Counter />
      <hr />

      <TodoInput />
      <TodoList />
      <hr />

      <Auth />
      <hr />

      <Cart />
      <hr />

      <Theme />
    </div>
  );
}
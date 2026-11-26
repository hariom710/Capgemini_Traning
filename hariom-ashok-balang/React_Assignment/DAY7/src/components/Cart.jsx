import { useSelector, useDispatch } from "react-redux";

export default function Cart() {
  const cart = useSelector(s => s.cart);
  const d = useDispatch();

  const products = ["Laptop", "Phone"];

  return (
    <div>
      {products.map((p, i) => (
        <button key={i} onClick={() => d({ type: "ADD_CART", payload: p })}>
          Add {p}
        </button>
      ))}
      <h3>Total: {cart.length}</h3>
    </div>
  );
}
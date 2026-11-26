import { useSelector, useDispatch } from "react-redux";
import { removeFromCart, clearCart } from "../store/cartSlice";

export default function Cart() {
  const cart = useSelector(s => s.cart);
  const d = useDispatch();

  const totalPrice = cart.reduce((a, c) => a + c.price * c.qty, 0);

  return (
    <div>
      <h2>Cart</h2>

      {cart.map(item => (
        <p key={item.id}>
          {item.name} x {item.qty} - ₹{item.price * item.qty}
          <button onClick={() => d(removeFromCart(item.id))}>
            Remove
          </button>
        </p>
      ))}

      <h3>Total: ₹{totalPrice}</h3>

      <button onClick={() => d(clearCart())}>
        Clear Cart
      </button>
    </div>
  );
}
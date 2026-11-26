import { useSelector } from "react-redux";

export default function Navbar() {
  const cart = useSelector(s => s.cart);

  return (
    <div>
      <h2>🛒 Cart Items: {cart.reduce((a, c) => a + c.qty, 0)}</h2>
    </div>
  );
}
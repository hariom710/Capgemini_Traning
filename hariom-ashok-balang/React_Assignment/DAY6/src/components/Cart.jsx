import useCart from "../hooks/useCart";

export default function Cart() {
  const { cart } = useCart();

  return <h2>Total Items: {cart.length}</h2>;
}
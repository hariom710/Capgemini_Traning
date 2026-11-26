import { useDispatch } from "react-redux";
import { addToCart } from "../store/cartSlice";

export default function ProductCard({ product }) {
  const d = useDispatch();

  return (
    <div>
      <h4>{product.name}</h4>
      <p>₹{product.price}</p>
      <button onClick={() => d(addToCart(product))}>
        Add to Cart
      </button>
    </div>
  );
}
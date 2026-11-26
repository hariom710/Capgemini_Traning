import useCart from "../hooks/useCart";

export default function ProductList() {
  const { add } = useCart();

  const products = ["Laptop", "Phone"];

  return (
    <div>
      {products.map((p, i) => (
        <button key={i} onClick={() => add(p)}>
          Add {p}
        </button>
      ))}
    </div>
  );
}
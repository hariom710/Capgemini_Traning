import { Link } from "react-router-dom";

export default function ProductList() {
  const products = [
    { id: 1, name: "Laptop", price: 50000 },
    { id: 2, name: "Phone", price: 20000 }
  ];

  return (
    <div>
      <h2>Products</h2>
      {products.map(p => (
        <p key={p.id}>
          <Link to={`/product/${p.id}`}>
            {p.name}
          </Link>
        </p>
      ))}
    </div>
  );
}
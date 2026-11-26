import { useParams } from "react-router-dom";

export default function ProductDetails() {
  const { id } = useParams();

  const products = [
    { id: "1", name: "Laptop", price: 50000 },
    { id: "2", name: "Phone", price: 20000 }
  ];

  const product = products.find(p => p.id === id);

  return (
    <div>
      <h2>{product.name}</h2>
      <p>Price: ₹{product.price}</p>
    </div>
  );
}
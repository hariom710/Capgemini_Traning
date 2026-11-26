import ProductCard from "./ProductCard";

export default function ProductCatalog({ products }) {
  return (
    <div>
      <h2>Products</h2>
      {products.map((p, i) => (
        <ProductCard key={i} product={p} />
      ))}
    </div>
  );
}
import DiscountLabel from "./DiscountLabel";

export default function ProductCard({ product }) {
  return (
    <div>
      <p>{product.name} - ₹{product.price}</p>
      {product.discount > 0 && (
        <DiscountLabel discount={product.discount} />
      )}
    </div>
  );
}
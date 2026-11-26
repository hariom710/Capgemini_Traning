function ProductCard({ name, price, image }) {
  return (
    <div style={{ border: "1px solid gray", padding: "10px", margin: "10px" }}>
      
      <img 
        src={image} 
        alt="product"
        width="150"
        onError={(e) => e.target.style.display = "none"}
      />

      <h3>{name}</h3>
      <p>Price: ₹{price}</p>
      <button>Add to Cart</button>

    </div>
  )
}

export default ProductCard
import { useState } from 'react'

function Product({ productName, price }) {
  const [currentPrice, setCurrentPrice] = useState(price)

  const increasePrice = () => {
    setCurrentPrice(currentPrice * 1.1)
  }

  return (
    <div>
      <h3>{productName}</h3>
      <p>Price: ₹{currentPrice.toFixed(2)}</p>

      <button onClick={increasePrice}>
        Increase Price by 10%
      </button>
    </div>
  )
}

export default Product
import React from "react";

function Product() {
    const id = 1;
    const name = "Laptop";
    const price = 999.99;
    const qty = 10;
    return (
        <div>
            <h2>Product Details</h2>
            <p>ID: {id}</p>
            <p>Name: {name}</p>
            <p>Price: ${price}</p>
            <p>qty: ${qty}</p>
            <p>Total: ${price * qty}</p>
        </div>
    );
}

export default Product;
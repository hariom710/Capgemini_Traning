export default function Mobile(props) {
    return (
        <div>
            <h2>Mobile Details</h2>
            <p>Brand: {props.brand}</p>
            <p>Model: {props.model}</p>
            <p>Price: ${props.price}</p>
        </div>
    );
}
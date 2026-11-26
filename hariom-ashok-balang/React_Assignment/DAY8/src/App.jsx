import Navbar from "./components/Navbar";
import ProductList from "./components/ProductList";
import Cart from "./components/Cart";

export default function App() {
  return (
    <div style={{ textAlign: "center" }}>
      <h1>E-Commerce App</h1>

      <Navbar />
      <hr />

      <ProductList />
      <hr />

      <Cart />
    </div>
  );
}
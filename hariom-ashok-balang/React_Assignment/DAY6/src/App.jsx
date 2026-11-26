import { ThemeProvider } from "./context/ThemeContext";
import { AuthProvider } from "./context/AuthContext";
import { CartProvider } from "./context/CartContext";

import Navbar from "./components/Navbar";
import Content from "./components/Content";
import Login from "./components/Login";
import Profile from "./components/Profile";
import WindowSize from "./components/WindowSize";
import ProductList from "./components/ProductList";
import Cart from "./components/Cart";
import FetchData from "./components/FetchData";

export default function App() {
  return (
    <ThemeProvider>
      <AuthProvider>
        <CartProvider>
          <div style={{ textAlign: "center" }}>
            <h1>React Day6</h1>

            <Navbar />
            <Content />
            <hr />

            <Login />
            <Profile />
            <hr />

            <WindowSize />
            <hr />

            <ProductList />
            <Cart />
            <hr />

            <FetchData />
          </div>
        </CartProvider>
      </AuthProvider>
    </ThemeProvider>
  );
}
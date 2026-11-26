import { BrowserRouter, Routes, Route, Navigate } from "react-router-dom";
import { useState } from "react";

import Navbar from "./components/Navbar";
import Home from "./components/Home";
import About from "./components/About";
import Contact from "./components/Contact";
import Dashboard from "./components/Dashboard";
import Profile from "./components/Profile";
import Settings from "./components/Settings";
import Students from "./components/Students";
import Courses from "./components/Courses";
import ProductList from "./components/ProductList";
import ProductDetails from "./components/ProductDetails";
import Login from "./components/Login";

export default function App() {
  const [auth, setAuth] = useState(false);

  return (
    <BrowserRouter>
      <Navbar />

      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/about" element={<About />} />
        <Route path="/contact" element={<Contact />} />

        <Route
          path="/dashboard/*"
          element={auth ? <Dashboard /> : <Navigate to="/login" />}
        >
          <Route path="profile" element={<Profile />} />
          <Route path="settings" element={<Settings />} />
        </Route>

        <Route path="/students" element={<Students />} />
        <Route path="/courses" element={<Courses />} />

        <Route path="/products" element={<ProductList />} />
        <Route path="/product/:id" element={<ProductDetails />} />

        <Route path="/login" element={<Login setAuth={setAuth} />} />
      </Routes>
    </BrowserRouter>
  );
}
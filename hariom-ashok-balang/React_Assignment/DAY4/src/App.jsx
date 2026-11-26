import UserDashboard from "./components/UserDashboard";
import ProductCatalog from "./components/ProductCatalog";
import StudentList from "./components/StudentList";
import NotificationCenter from "./components/NotificationCenter";
import MovieList from "./components/MovieList";

export default function App() {
  const users = [
    { name: "Hariom", role: "Admin", status: "Active" },
    { name: "Harry", role: "User", status: "Inactive" }
  ];

  const products = [
    { name: "Laptop", price: 50000, discount: 10 },
    { name: "Phone", price: 20000, discount: 0 }
  ];

  const students = [
    { name: "Amit", marks: 92 },
    { name: "Neha", marks: 65 }
  ];

  const notifications = [
    { text: "New message", unread: true },
    { text: "System update", unread: false }
  ];

  const movies = [
    { name: "Inception", year: 2010, rating: 5 },
    { name: "Avatar", year: 2009, rating: 4 }
  ];

  return (
    <div style={{ textAlign: "center" }}>
      <h1>React Day4</h1>

      <UserDashboard users={users} />
      <hr />

      <ProductCatalog products={products} />
      <hr />

      <StudentList students={students} />
      <hr />

      <NotificationCenter notifications={notifications} />
      <hr />

      <MovieList movies={movies} />
    </div>
  );
}
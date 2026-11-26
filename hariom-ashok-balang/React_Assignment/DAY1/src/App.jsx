import StudentCard from '../components/StudentCard'
import ProductCard from '../components/ProductCard'
import EmployeeList from '../components/EmployeeList'
import Counter from '../components/Counter'
import Greeting from '../components/Greeting'

function App() {
  return (
    <div>

      <h2>Problem 1: StudentCard Component </h2>
      <StudentCard />

      <h2>Problem 2: ProductCard Component </h2>
      <ProductCard
        name="Laptop"
        price={50000}
        image="https://images.unsplash.com/photo-1517336714731-489689fd1ca8"
      />

      <ProductCard
        name="Phone"
        price={20000}
        image="https://images.unsplash.com/photo-1511707171634-5f897ff02aa9"
      />

      <ProductCard
        name="Headphones"
        price={2000}
        image="https://images.unsplash.com/photo-1545127398-14699f92334b"
      />

      <h2>Problem 3: EmployeeList Component </h2>
      <EmployeeList />

      <h2>Problem 4: Counter Component </h2>
      <Counter />
      <hr />

      <h2>Problem 5: Greeting Component </h2>
      <Greeting name="Hariom" />
      <Greeting name="Rahul" />
      <Greeting name="Sneha" />

    </div>
  )
}

export default App
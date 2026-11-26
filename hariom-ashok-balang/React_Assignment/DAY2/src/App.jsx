import Counter from './components/Counter'
import Student from './components/Student'
import Product from './components/Product'
import Greeting from './components/Greeting'
import Child from './components/Child'

function App() {
  return (
    <div style={{ padding: "20px", fontFamily: "Arial" }}>

      <h2>Problem 1: Counter with Props and State</h2>
      <Counter initialValue={5} />
      <hr/>

      <h2>Problem 2: Student Marks Calculator </h2>
      <Student 
        name="Hariom"
        subject1={80}
        subject2={75}
        subject3={85}
      />
      <hr/>

      <h2>Problem 3: Product Price Updater </h2>
      <Product productName="Laptop" price={50000} />
      <hr/>

      <h2>Problem 4: User Greeting Toggle </h2>
      <Greeting username="Hariom" />
      <hr/>

      <h2>Problem 5: Parent to Child Data Passing </h2>
      <Child name="Hariom" role="Developer" />
      <Child name="Harry" role="Designer" />
      <hr/>
    </div>
  )
}

export default App
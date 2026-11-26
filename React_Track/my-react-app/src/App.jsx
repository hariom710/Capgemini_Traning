import './App.css'
import MyCar from './Car';
import Product from './Product';
import Sum from './Sum';
import Person from './Person';
import NewApp from './NewApp';
import Mobile from './Mobile';
import Cover from './Cover';
import Counter from './Counter';
import FavColor from './FavColor';
import DataApp from './DataApp';
import DataApp1 from './DataApp1';

function App() {
  return (
    <div style={{ padding: '24px' }}>
      <h1>Hello World!</h1>
      <Product />
      <hr />
      <MyCar />
      <hr />
      <Sum a="5" b="10" />
      <Person name={'John'} city={'New York'} age={30} />
      <hr />
      {/* <Cover />
      <hr />
      
      <Counter />
      <hr />
      <FavColor /> */}
      <hr />
      <NewApp />
      <hr />
      <DataApp />
      <hr />
      <DataApp1 />
      <hr />

    </div>
  );
}
export default App
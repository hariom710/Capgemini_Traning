import Counter from './Counter';
import Cover from './Cover';
import FavColor from './FavColor';


function NewApp() {
    return (
        <div>
            <h1>Welcome to the New App!</h1>
            <p>This is a new component added to the project.</p>
            <Counter />
            <hr />
            <Cover />
            <hr />
            <FavColor />
            <hr />
            
        </div>
    );
}
export default NewApp;
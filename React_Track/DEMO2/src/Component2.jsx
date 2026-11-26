import Component3 from "./Component3";

export default function Component2({ name }) {
    return (
        <div>
            <h1>Component 2</h1>
            <p>Received from Component 1: {name}</p>
            <Component3 name={name} />
        </div>
    );
}
import useToggle from "./useToggle";

export default function ToggleComponent() {
    const [value, toggleIsOn] = useToggle(false);

    return (
        <div>
            <p>{value.toString()}</p>
            <button onClick={toggleIsOn}>Toggle</button>
            <button onClick={() => toggleIsOn(true)}>Set True</button>
            <button onClick={() => toggleIsOn(false)}>Set False</button>
        </div>
    );
}
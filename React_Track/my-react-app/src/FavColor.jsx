import { useState } from 'react';
export default function FavColor() {
    const [color, setColor] = useState('red');
    const changeColor = () => {
        setColor('blue');
    }
    return (
        <div>
            <h2>My favourite color is {color}</h2>
            <button onClick={changeColor}>Change Color</button>
        </div>
    );
}
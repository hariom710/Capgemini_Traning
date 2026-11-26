import { use, useEffect, useState } from "react";

export default function Effect1() {
    const [count, setCount] = useState(0);

    useEffect(() => {
        console.log("useEffect");
        setTimeout(() => {
            setCount((count) => count + 1);
        }, 1000);
    }, [count]);

    return (
        <div>
            <h1>Effect1</h1>
            <p>count: {count}</p>
        </div>
    )
}
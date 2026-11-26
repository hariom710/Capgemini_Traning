import { useState } from "react";
import Component2 from "./Component2"

export default function Component1(){
    const [user, setUser] = useState("Harry Potter");
    return(
        <div>
            <h1>Component 1</h1>
            <p>{user}</p>
            <button onClick={()=>setUser("Hermione Granger")}>Change Name</button>
            <Component2 name={user}/>
        </div>
    )
}
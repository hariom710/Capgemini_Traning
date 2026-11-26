import React from "react";

export default function DoubtBoard ({ updateDoubt }) {

    return (
        <div className="doubt-board" style={{ backgroundColor: "lightblue", padding: "10px", margin: "10px" }}>
            <h1>Doubt Board</h1>
            <textarea name="" id="" cols="30" rows="10" onChange={(event) => updateDoubt(event.target.value)}></textarea>
        </div>
    );
}
import React from "react";

export default function StudentBoard1({ homework }) {
    return (
        <div>
            <h1>Student Board</h1>
            <textarea rows={30} cols={10} value={homework}></textarea>
        </div>
    );
}


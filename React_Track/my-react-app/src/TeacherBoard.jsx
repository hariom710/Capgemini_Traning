import React from "react";
import StudentBoard from "./StudentBoard";

function TeacherBoard({ setHomework}){

    function updateHomework(newHomework) {
        setHomework(newHomework);
    }

    return (
        <div>
            <h1>Teacher Board</h1>
            <textarea rows={10} cols={30} onChange={(event) => updateHomework(event.target.value)}></textarea>
        </div>
    );
}

export default TeacherBoard;
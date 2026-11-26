import React from "react";
import { useState } from "react";
import StudentBoard from "./StudentBoard";
import DoubtBoard from "./DoubtBoard";
import StudentBoard1 from "./StudentBoard1";

export default function TeacherBoard1() {
    const [homework, setHomework] = useState("");
    const [doubts, setDoubts] = useState([]);

    function updateHomework(newHomework) {
        setHomework(newHomework);
    }

    function updateDoubt(newDoubt) {
        setDoubts(newDoubt);
    }
    return(
        <div>
            <h1>Teacher Board</h1>
            <textarea name="" id="" cols="30" rows="10" onChange={(event) => updateHomework(event.target.value)}></textarea>

            <h3>Current Doubt : {doubts}</h3>
            <DoubtBoard updateDoubt={updateDoubt} />
            <div>
                <StudentBoard1 homework={homework} />
            </div>
        </div>
    )
}
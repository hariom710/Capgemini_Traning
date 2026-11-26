import StudentBoard1 from "./StudentBoard1";
import TeacherBoard1 from "./TeacherBoard1";
import { useState } from "react";



function DataApp1() {
    const [homework, setHomework] = useState("");
    const [doubts, setDoubts] = useState([]);

    return (
        <div>
            <TeacherBoard1 setHomework={setHomework} setDoubts={setDoubts} />
            <StudentBoard1 homework={homework} />
        </div>
    );
}
export default DataApp1;
import { useState } from "react";
import TeacherBoard from "./TeacherBoard";
import StudentBoard from "./StudentBoard";

function DataApp() {
    const [homework, setHomework] = useState("");

    return (
        <div>
            <TeacherBoard setHomework={setHomework} />
            <StudentBoard homework={homework} />
        </div>
    );
}
export default DataApp;


function StudentBoard({ homework }) {
    return (
        <div>
            <h1>Student Board</h1>
            <textarea rows={10} cols={30} value={homework} ></textarea>
        </div>
    );
}
export default StudentBoard;
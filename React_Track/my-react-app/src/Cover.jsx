import Mobile from "./Mobile";
function Cover() {
    return (
        <div>
            <h1>Welcome to the Cover Component!</h1>
            <p>This is a simple cover component that can be used in your React application.</p>
            <Mobile brand="Apple"/>
            <Mobile brand="Samsung"/>
            <Mobile brand="Google"/>
        </div>
    );
}
export default Cover;
import { useParams, useSearchParams } from "react-router-dom";

export default function Info() {
    const { id } = useParams();
    const [searchParams] = useSearchParams();
    const firstName = searchParams.get("firstName") || "";
    return (
        <div>
            <h1>Info</h1>
            <p>This is the info page for item with ID: {id}</p>
            <p>First Name: {firstName}</p>

        </div>
    );
}
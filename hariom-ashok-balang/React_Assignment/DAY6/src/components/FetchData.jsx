import useFetch from "../hooks/useFetch";

export default function FetchData() {
  const { data, loading } = useFetch(
    "https://jsonplaceholder.typicode.com/users"
  );

  if (loading) return <p>Loading...</p>;

  return (
    <div>
      {data.map(u => (
        <p key={u.id}>{u.name}</p>
      ))}
    </div>
  );
}
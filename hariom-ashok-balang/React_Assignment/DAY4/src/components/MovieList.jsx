import MovieCard from "./MovieCard";

export default function MovieList({ movies }) {
  return (
    <div>
      <h2>Movies</h2>
      {movies.map((m, i) => (
        <MovieCard key={i} movie={m} />
      ))}
    </div>
  );
}
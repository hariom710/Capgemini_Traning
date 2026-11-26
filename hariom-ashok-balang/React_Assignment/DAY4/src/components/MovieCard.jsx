import RatingStars from "./RatingStars";

export default function MovieCard({ movie }) {
  return (
    <div>
      <p>{movie.name} ({movie.year})</p>
      <RatingStars rating={movie.rating} />
    </div>
  );
}
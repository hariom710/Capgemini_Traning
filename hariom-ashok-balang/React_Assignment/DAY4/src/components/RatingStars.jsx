export default function RatingStars({ rating }) {
  return (
    <span>
      {[...Array(5)].map((_, i) =>
        i < rating ? "⭐" : "☆"
      )}
    </span>
  );
}
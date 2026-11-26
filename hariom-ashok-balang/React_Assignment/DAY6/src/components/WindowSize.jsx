import useWindowSize from "../hooks/useWindowSize";

export default function WindowSize() {
  const { w, h } = useWindowSize();

  return (
    <h2>
      Width: {w} Height: {h}
    </h2>
  );
}
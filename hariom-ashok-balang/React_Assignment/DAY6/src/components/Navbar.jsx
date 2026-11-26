import useTheme from "../hooks/useTheme";

export default function Navbar() {
  const { toggle } = useTheme();

  return (
    <button onClick={toggle}>
      Toggle Theme
    </button>
  );
}
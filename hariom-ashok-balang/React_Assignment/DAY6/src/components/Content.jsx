import useTheme from "../hooks/useTheme";

export default function Content() {
  const { theme } = useTheme();

  return <h2>Current Theme: {theme}</h2>;
}
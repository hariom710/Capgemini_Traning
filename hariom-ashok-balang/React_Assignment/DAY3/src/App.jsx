import VisitCounter from "./components/VisitCounter";
import DigitalClock from "./components/DigitalClock";
import CharCounter from "./components/CharCounter";
import FetchUsers from "./components/FetchUsers";
import BgColorChanger from "./components/BgColorChanger";

export default function App() {
  return (
    <div style={{ textAlign: "center" }}>
      <h1>React Day3</h1>

      <VisitCounter />
      <hr />

      <DigitalClock />
      <hr />

      <CharCounter />
      <hr />

      <FetchUsers />
      <hr />

      <BgColorChanger />
    </div>
  );
}
import React from "react";
import Effect1 from "./Effect1";
import Effect2 from "./Effect2";
import Effect3 from "./Effect3";
import Effect4 from "./Effect4";
// import Nav from "./NavBar";
import ToggleComponent from "./ToggleComponent";



export default function App() {
  return (
    <div className="App">
      <Effect1 />
      <hr />
      <Effect2 />
      <hr/>
      <Effect3 />
      <hr/>
      <Effect4 />
      <hr/>
      <ToggleComponent />
      
    </div>
  );
}
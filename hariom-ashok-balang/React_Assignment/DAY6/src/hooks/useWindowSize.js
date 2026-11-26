import { useState, useEffect } from "react";

export default function useWindowSize() {
  const [size, setSize] = useState({
    w: window.innerWidth,
    h: window.innerHeight
  });

  useEffect(() => {
    const resize = () => {
      setSize({
        w: window.innerWidth,
        h: window.innerHeight
      });
    };

    window.addEventListener("resize", resize);

    return () => window.removeEventListener("resize", resize);
  }, []);

  return size;
}
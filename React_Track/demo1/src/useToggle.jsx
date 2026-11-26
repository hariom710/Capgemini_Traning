import { useState } from "react";

export default function useToggle(defauLtValue) {
    const [value, setValue] = useState(defauLtValue);

    function toggleValue() {
        setValue(currValue => typeof currValue === "boolean" ? !currValue : currValue);

    }
    return [value, toggleValue];
}
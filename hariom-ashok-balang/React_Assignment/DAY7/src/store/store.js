import { createStore, combineReducers } from "redux";

/* Counter */
const counterReducer = (state = { count: 0 }, action) => {
  switch (action.type) {
    case "INC":
      return { count: state.count + 1 };
    case "DEC":
      return { count: state.count - 1 };
    default:
      return state;
  }
};

/* Todo */
const todoReducer = (state = [], action) => {
  switch (action.type) {
    case "ADD":
      return [...state, action.payload];
    case "DEL":
      return state.filter((_, i) => i !== action.payload);
    default:
      return state;
  }
};

/* Auth */
const authReducer = (state = false, action) => {
  switch (action.type) {
    case "LOGIN":
      return true;
    case "LOGOUT":
      return false;
    default:
      return state;
  }
};

/* Cart */
const cartReducer = (state = [], action) => {
  switch (action.type) {
    case "ADD_CART":
      return [...state, action.payload];
    case "REM_CART":
      return state.filter((_, i) => i !== action.payload);
    default:
      return state;
  }
};

/* Theme */
const themeReducer = (state = "light", action) => {
  switch (action.type) {
    case "TOGGLE":
      return state === "light" ? "dark" : "light";
    default:
      return state;
  }
};

const rootReducer = combineReducers({
  counter: counterReducer,
  todos: todoReducer,
  auth: authReducer,
  cart: cartReducer,
  theme: themeReducer
});

export const store = createStore(rootReducer);
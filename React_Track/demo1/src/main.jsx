import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'
import BlogApp from './BlogApp.jsx'
import NavApp from './NavApp.jsx'

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <NavApp />
    
    <hr />
    <BlogApp />
    <hr />
    <App />
  </StrictMode>,
)

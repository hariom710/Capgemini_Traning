import React from 'react';
import { Link } from 'react-router-dom';


export default function NavBar() {
    return (
        <nav>
            <ul>
                <li><Link to="/">Home</Link></li>
                <li><Link to="/about">About</Link></li>
                <li><Link to="/contact">Contact</Link></li>
                <li><Link to="/info/1?firstName=John">Info1</Link></li>
                <li><Link to="/info/2?firstName=Jane">Info2</Link></li>
            </ul>
        </nav>
    );
}
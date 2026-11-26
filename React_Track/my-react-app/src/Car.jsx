function MyCar() {
    const cars = ['BMW', 'Audi', 'Mercedes'];
    return (
        <>
        <h2>Cars</h2>
        <ul>
            {cars.map((car, index) => (
                <li key={index}>{car}</li>
            ))}
        </ul>
        </>
    );
}

export default MyCar;
function Sum(props) {
    const fno= +props.a;
    const sno= +props.b;
    const sum = fno + sno;
    return (
        <div>
            <span>Sum of {fno} and {sno} is: {sum}</span>
            
        </div>
    );
}

export default Sum;
export class Car {
    model: string;
    year: number;
    color: string;

    constructor(model: string, year: number, color: string) {
        this.model = model;
        this.year = year;
        this.color = color;
    }

    // displayInfo(): string {
    //     return `Model: ${this.model}, Year: ${this.year}, Color: ${this.color}`;
    // }
}

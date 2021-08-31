export interface User {
    username: string;
    token: string;
}

/*
    // Defining a variable as both number or string
    let data: number | string = 42;
    data = "10";

    // Parent-child relationship
    // If you want to make some variable optional for childrens, add "?" after variable name
    interface Car {
        color: string;
        model: string;
        topSpeed?: number;
    }

    const car1: Car = {
        color: 'blue',
        model: 'BMW'
    }

    const car2: Car = {
        color: 'red',
        model: 'Mercedes',
        topSpeed: 100
    }

    const multiply1 = (x: number, y: number) => {
        return x * y;
    }

    const multiply2 = (x: number, y: number): void => {
        x * y;
    }

    const multiply3 = (x: number, y: number) => {
        x * y;
    }
*/
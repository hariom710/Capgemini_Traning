class Shape{
    area():number{
        return 0;
    }
}
class Rectangle extends Shape{
    constructor(public w:number,public h:number){
        super();
    }
    area():number{
        return this.w*this.h;
    }
}
class Circle extends Shape{
    constructor(public r:number){
        super();
    }
    area():number{
        return Math.PI*this.r*this.r;
    }
}
let rect=new Rectangle(4,5);
console.log(rect.area());
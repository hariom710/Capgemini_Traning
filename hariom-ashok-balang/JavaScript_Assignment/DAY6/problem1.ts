interface User{
    id:number;
    name:string;
    email:string;
}
function printUser(user:User):void{
    console.log("User:"+user.name+" Email:"+user.email);
}
let u:User={id:1,name:"Hariom",email:"hariom@gmail.com"};
printUser(u);
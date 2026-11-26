type ApiUser={
    id:number;
    name:string;
    email:string;
};
async function fetchUsers():Promise<ApiUser[]>{
    let r=await fetch("https://jsonplaceholder.typicode.com/users");
    let d:ApiUser[]=await r.json();
    return d;
}
fetchUsers().then(function(users){
    console.log(users.length);
});
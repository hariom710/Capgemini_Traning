interface Todo{
    id:number;
    text:string;
    done:boolean;
}
let todos:Todo[]=[];
function add(text:string){
    todos.push({id:Date.now(),text:text,done:false});
}
function toggle(id:number){
    let t=todos.find(x=>x.id===id);
    if(t){
        t.done=!t.done;
    }
}
function remove(id:number){
    todos=todos.filter(x=>x.id!==id);
}
add("Learn TypeScript");
console.log(todos);
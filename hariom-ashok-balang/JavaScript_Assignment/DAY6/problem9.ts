let btn=document.querySelector("button") as HTMLButtonElement;
let div=document.querySelector("#data") as HTMLDivElement;
btn.addEventListener("click",async function(){
    let r=await fetch("https://jsonplaceholder.typicode.com/posts/1");
    let d=await r.json();
    div.textContent=d.title;
});
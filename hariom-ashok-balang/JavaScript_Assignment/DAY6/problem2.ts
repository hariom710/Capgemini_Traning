async function loginUser(username:string,password:string):Promise<{id:number;token:string}>{
    return new Promise(function(res){
        setTimeout(function(){
            res({id:1,token:"example-token"});
        },2000);
    });
}
loginUser("admin","1234").then(function(r){
    console.log(r);
});
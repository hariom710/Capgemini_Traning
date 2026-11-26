type UserData={id:number;name:string};
async function fetchUserDatasData():Promise<UserData[]>{
    return[{id:1,name:"A"},{id:2,name:"B"}];
}
async function cleanUserDatas(UserDatas:UserData[]):Promise<UserData[]>{
    return UserDatas.filter(u=>u.name.length>0);
}
async function summarizeUserDatas(UserDatas:UserData[]):Promise<number>{
    return UserDatas.length;
}
async function run(){
    let u=await fetchUserDatasData();
    let c=await cleanUserDatas(u);
    let s=await summarizeUserDatas(c);
    console.log(s);
}
run();
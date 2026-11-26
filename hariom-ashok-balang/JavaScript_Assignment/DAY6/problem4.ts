class Repository<T>{
    items:T[]=[];
    add(item:T){
        this.items.push(item);
    }
    getAll():T[]{
        return this.items;
    }
    findById(id:number):T|undefined{
        return (this.items as any).find((x:any)=>x.id===id);
    }
}
type Item={id:number,name:string};
let repo=new Repository<Item>();
repo.add({id:1,name:"Item1"});
console.log(repo.getAll());
var todos = [];
function add(text) {
    todos.push({ id: Date.now(), text: text, done: false });
}
function toggle(id) {
    var t = todos.find(function (x) { return x.id === id; });
    if (t) {
        t.done = !t.done;
    }
}
function remove(id) {
    todos = todos.filter(function (x) { return x.id !== id; });
}
add("Learn TypeScript");
console.log(todos);

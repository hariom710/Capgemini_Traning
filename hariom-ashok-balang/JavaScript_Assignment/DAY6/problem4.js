var Repository = /** @class */ (function () {
    function Repository() {
        this.items = [];
    }
    Repository.prototype.add = function (item) {
        this.items.push(item);
    };
    Repository.prototype.getAll = function () {
        return this.items;
    };
    Repository.prototype.findById = function (id) {
        return this.items.find(function (x) { return x.id === id; });
    };
    return Repository;
}());
var repo = new Repository();
repo.add({ id: 1, name: "Item1" });
console.log(repo.getAll());

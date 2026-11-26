var ConsoleLogger = /** @class */ (function () {
    function ConsoleLogger() {
    }
    ConsoleLogger.prototype.log = function (message) {
        console.log(message);
    };
    return ConsoleLogger;
}());
var FileLogger = /** @class */ (function () {
    function FileLogger() {
    }
    FileLogger.prototype.log = function (message) {
        console.log("File:" + message);
    };
    return FileLogger;
}());
var logger = new ConsoleLogger();
logger.log("Test message");

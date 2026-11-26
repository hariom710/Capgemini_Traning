interface Logger{
    log(message:string):void;
}
class ConsoleLogger implements Logger{
    log(message:string):void{
        console.log(message);
    }
}
class FileLogger implements Logger{
    log(message:string):void{
        console.log("File:"+message);
    }
}
let logger:Logger=new ConsoleLogger();
logger.log("Test message");
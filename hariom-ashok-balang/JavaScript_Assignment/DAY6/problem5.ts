type PaymentStatus="pending"|"paid"|"failed";
function handlePayment(status:PaymentStatus){
    if(status==="paid"){
        console.log("Payment successful");
    }else if(status==="pending"){
        console.log("Payment pending");
    }else{
        console.log("Payment failed");
    }
}
handlePayment("paid");
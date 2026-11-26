document.getElementById("submitBtn").addEventListener("click",validateForm);

function validateForm(){
  const name=document.getElementById("name").value;
  const user=document.getElementById("username").value;
  const pass=document.getElementById("password").value;
  const msg=document.getElementById("msg");

  if(!name||!user||!pass) msg.textContent="All fields required";
  else msg.textContent="Form submitted successfully";
}
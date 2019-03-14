
function reloj() {
  var time= new Date();
  var hr= time.getHours();
  var mnt= time.getMinutes();
  var scond= time.getSeconds();
  
  var face= document.getElementById('clock');
  face.innerHTML= hr+":"+mnt+":"+scond;
}

setInterval(reloj, 1000);
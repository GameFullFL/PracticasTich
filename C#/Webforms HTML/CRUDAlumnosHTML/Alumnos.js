function Prueba() {
  var p = document.getElementById("id").value;
  let o = document.getElementById("id");
  if (p.length != 0) {
    o.disabled = true;
    document.getElementById("name").removeAttribute("disabled");
    document.getElementById('name').setAttribute("value", "Francisco");
    document.getElementById("number").removeAttribute("disabled");
    document.getElementById('number').setAttribute("value", "25");
    document.getElementById("dropdown").removeAttribute("disabled");;
    document.getElementById('1').setAttribute("selected", true);
    document.getElementById("estatus").removeAttribute("disabled");
    document.getElementById('estatus').setAttribute("checked", true)
    document.getElementById('submit').style.display = 'none';
    document.getElementById('submit2').style.display = 'block';
  } else {
    alert("Ingrese un id");
  }
}

function Enviar(){
  alert("Actualizacion Exitosa");
}

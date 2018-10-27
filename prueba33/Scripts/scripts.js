window.onload = function() {
    document.getElementById("nombre").value = "";
    document.getElementById("apellido").value = "";
    document.getElementById("dni").value = "";
    document.getElementById("texttel").value = "";
    document.getElementById("prov").selectedIndex = 0;
    document.getElementById("email").value = "";
  }


function validar(){

    var alert = document.getElementById("alert");
    var alertTxt = "Complete todos los campos vacios";
   

    var name = document.getElementById("nombre");
    alert.setAttribute("style","display:none");

        if(!name.value){

            name.style.borderColor = "red";
            alert.innerHTML = alertTxt;
            alert.setAttribute("style","");
            return false ;
            }else{
                 name.style.borderColor = "";
            }
            



     var apellido = document.getElementById("apellido");
     if(!apellido.value){

            apellido.style.borderColor = "red";
            alert.innerHTML = alertTxt;
            alert.setAttribute("style","");
            return false;
       }else{
                 apellido.style.borderColor = "";
            }




    var dni = document.getElementById("dni");
    
         if(!parseInt(dni.value)){

            dni.style.borderColor = "red";
            alert.innerHTML = alertTxt;
            alert.setAttribute("style","");
            return false;
            } else{
                 dni.style.borderColor = "";
            }




       var tel = document.getElementById("texttel");
          if(!tel.value){

            tel.style.borderColor = "red";

            alert.innerHTML = alertTxt;
            alert.setAttribute("style","");
            return false;
            } else{
                 tel.style.borderColor = "";
            }


    var prov = document.getElementById("prov").selectedIndex;
            if(prov == 0){
            alert.innerHTML = "Seleccione una provincia";
            alert.setAttribute("style","");
            return false;

            }

     var barrio = document.getElementById("barrio").selectedIndex;
            if(barrio == 0 && prov != 1){
            alert.innerHTML = "Seleccione un barrio";
            alert.setAttribute("style","");
            return false;

       }



     var email = document.getElementById("email");

     if(!email.value.includes("@") || !email.value.includes(".") ){

            email.style.borderColor = "red";

            alert.innerHTML = alertTxt;
            alert.setAttribute("style","");
            return false;
       }else{
                 email.style.borderColor = "";
            }


    var checkBox = document.getElementById("terms");
        if (!checkBox.checked) {
               checkBox.focus();
               alert.innerHTML = "Debe aceptar los terminos y condiciones";
            alert.setAttribute("style","");

            return false;
        }


        console.log(dni.toString().length);
        console.log("funciona");


        return true;

  }

 function displayBarrio(){

        var prov = document.getElementById("prov").value;
        var barrioForm =  document.getElementById("barrioForm")
        if (prov == "1"){
            barrioForm.style.display = "block";
        }else{
            barrioForm.style.display = "none";
        }

        
 }



 function acepto(){
        var checkBox = document.getElementById("terms");
        checkBox.checked = true;
       
    }

$(document).ready(function(){
 
  $('#texttel').mask('(+00) 0 00 0000-0000');

 });
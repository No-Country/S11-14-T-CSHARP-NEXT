export function validate (target: string, valor: number | string) {

      if (target === "petname" || target === "name" || target === "last") {

          if(valor === ''){
              return '* El campo es obligatorio';
          }

          if(String(valor).length > 25){
              return '* Es muy largo';
          }

          if(String(valor).length < 3){
              return '* Debe tener almenos 3 letras';
          }

      }

      if(
        target === 'speciees' || 
        target === 'gender' || 
        target === 'fur' ||
        target === 'color' ||
        target === 'size' ||
        target === 'eyes' ||
        target === 'age' ||
        target === 'tag'
      ){

        if (typeof valor !== 'number') {
            valor = Number(valor);
        }

        if( valor < 1){
            return '* El campo es requerido.';
        }

      }    

      if(target === "phonenumber"){

          if(valor === ''){
              return '* El campo es requerido.';
          }

          if(String(valor).length > 13){
              return '* Es muy largo';
          }

          if(String(valor).length < 10){
              return '* Debe ser a 10 digitos';
          }

          if(!/^[0-9]{3}-[0-9]{3}-[0-9]{4}/g.test(String(valor))){
              return 'El formato no es valido (Ej: 809-555-5555).';
          }

      }

      if(target === "city" || target === "description"){

          if(String(valor).length < 1){
              return "* Este campo es obligatorio"
          }

      }

      if(target === "email"){

            if(valor === ''){
                return '* El email es obligatorio';
            }
    
            if(String(valor).length > 35){
                return '* El email debe tener menos de 35 caracteres';
            }
    
            if(!/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$/.test(String(valor))){
                return '* Debe ser un correo valido';
            }
      }

      if(target === 'password' || target === 'repassword'){

            if(String(valor).length < 6 || String(valor).length > 10){
                return '* La contraseña debe tener entre 6 y 10 caracteres';
            }
    
            if(!/^(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{6,10}$/.test(String(valor))){
                return '* La contraseña debe tener almenos una letra mayuscula, una letra minuscula y un numero';
            }
      }

      return '';
}
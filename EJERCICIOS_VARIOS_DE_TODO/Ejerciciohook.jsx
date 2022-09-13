import React, {useState,useEffect} from 'react';
//import '../../styles/clock.scss';
const Ejerciciohook = () => {

    const Inicial = {
         fecha: new Date(),
         edad: 41,
         nombre: 'Juan',
         apellidos: 'Garcia',
        
    }

    const [persona, setPersona] = useState(Inicial)

    function actualizarPersona (){
        setPersona(
            {   
                fecha: new Date(),
                edad: persona.edad + 1,
                nombre: 'Pepe',
                apellidos: 'Gonzalez'
            }
        )
    }
    

    
    
    
        useEffect(() => {
            //console.log('Componente actualizado o creado')
            
            const intervalID = setInterval(() => {
                persona.fecha = `${new Date()}`
                console.log('Actualización del componente')
                
            }, []);

            return () => {
                console.log('Comportamiento antes de que el componente desaparezca')
                clearInterval(intervalID)
            };
        }, []);

        return (
                <div>
                <h2>
        
                   Hora Actual:&nbsp;
                   { persona.fecha.toLocaleTimeString() }
        
                </h2>
               
                <h3>{ persona.nombre } { persona.apellidos }</h3>
                <h1>Edad: { persona.edad }</h1>
                <button onClick={ actualizarPersona }>Actualizar Persona</button>
                </div>
                
        );

        
    }
             
    
    
    
    
 
export default Ejerciciohook;   

import React, {useState}from 'react';

let red = 0;
let green = 0;
let blue = 0;


function generarNumero(numero){
	return (Math.random()*numero).toFixed(0);
}


const loggedSyle = {
    backgroundColor: `rgb(${red},${green},${blue})`,
    color: 'white',
    fontWeight: 'bold',
    width: '255px',
    height: '255px'
}   


const LoginButton = ({loginAction, propStyle}) => {
    return(
        <button style={propStyle} onDoubleClick={loginAction} onMouseOver={loginAction} ></button>
    )
}

const LogoutButton = ({ propStyle, logoutAction}) => {
    return(
        <button style={propStyle} onMouseOver={logoutAction}></button> 
    )
}


const Optionalrender =() => {

    const [access, setAccess] = useState(false);

    const loginAction = () => {

        setAccess(true);
    }   

    const logoutAction = () => {

        setAccess(false);
    }
   
    const unloggedStyle = {
        backgroundColor: `rgb(${generarNumero(255)},${generarNumero(255)},${generarNumero(255)})`,
        color: 'white',
        fontWeight: 'bold',
        width: '255px',
        height: '255px'
    }
    
    
    let optionalButton;

    if(access){
        
        optionalButton = <LogoutButton propStyle={ unloggedStyle } logoutAction={logoutAction}></LogoutButton>
    }else{
        optionalButton = <LoginButton propStyle={ loggedSyle } loginAction={loginAction}></LoginButton>
        
    }

    return (
        <div>
          
            { optionalButton }

        </div>
        );
}

export default Optionalrender;

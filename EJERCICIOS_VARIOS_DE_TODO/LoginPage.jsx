import React from 'react';
import LoginFormik from '../../components/pure/forms/loginFormik';
import { useNavigate } from 'react-router-dom';

const LoginPage = () => {

    const navigate = useNavigate();

    const navigates= (path) => {
        navigate(path);
    }

    return (
        <div>
            <h1>Login Page</h1>
            <LoginFormik></LoginFormik>
            <br/>
            <button onClick={() => navigates('/register')}>Registration</button>
            <br/><br/>
            <button onClick={() => navigates('/')}>HOME</button>
        </div>
    );
}

export default LoginPage;

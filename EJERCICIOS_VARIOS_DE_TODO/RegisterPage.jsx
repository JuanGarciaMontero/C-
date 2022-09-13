import React from 'react';
import RegisterFormik from '../../components/pure/forms/registerFormik';
import { useNavigate } from 'react-router-dom';

const RegisterPage = () => {

    const navigate = useNavigate();

    const navigates= (path) => {
        navigate(path);
    }

    return (
        <div>
            <h1>Register Page</h1>
            <RegisterFormik></RegisterFormik>
            <br/>
            <button onClick={() => navigates('/login')}>Go to Login</button>
        </div>
    );
}

export default RegisterPage;

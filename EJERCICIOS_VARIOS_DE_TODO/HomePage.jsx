import React from 'react';
import { useNavigate, useLocation } from 'react-router-dom';

const HomePage = () => {

    const location = useLocation();
    const navigate = useNavigate();

    console.log('We are in Route:', location.pathname);


    const navigates= (path) => {
        navigate(path);
    }

    const navigateProps = (path) =>{

        navigate({
            pathname: path,
            search: '?online=true', // Query Params
            state:true
            
        });

    }

    return (
        <div>
            <h1 align='center'>Home Page</h1>

            <div>
                <button onClick={ () => navigateProps('/online-state') }>
                    Go To Page with State / Query Params
                </button>
                <button onClick={ () => navigates('/profile') }>
                    Go To Profile
                </button>
                <br/><br/>
                <p>(If you have successfully logged in to enter your tasks, <br/>you must refresh the page, press the F5 button on your keyboard)</p>
            </div>
        </div>
    );
}

export default HomePage;

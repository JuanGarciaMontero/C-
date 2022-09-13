import APIRequest from './axios.config';
//import axios from 'axios';

export function getRandomUser() {
    return APIRequest.get('/',
        {
        validateStatus: function (status)
            {
                 return status < 500; // Resuelve solo si el código de estado es menor que 500
            }

        }
    ); // https://randomuser.me/api/
        // APIRequest.post('/login', body);  
}
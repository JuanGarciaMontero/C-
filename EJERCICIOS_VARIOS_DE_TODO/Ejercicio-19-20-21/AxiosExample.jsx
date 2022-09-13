import React, {useState, useEffect} from 'react';
import {getRandomUser} from './axiosService';
import Box from '@mui/material/Box';
import Rating from '@mui/material/Rating';
import Typography from '@mui/material/Typography';

const AxiosExample = () => {

    
    const n=0;
    const [value, setValue] = React.useState(n);

    const [user, setUser] = useState(null);

    /* useEffect(() => {
       obtainUser();
     }, []);*/

    const obtainUser = () => {
        getRandomUser()
            .then((response) => {
                if(response.status ===200){
                    setUser(response.data)
                }
            })
            .catch((error) => {
                alert(`Somethig went wrong: ${error}`);
            })

    }

    


    async function generatePromiseNumber(){
        return Promise.resolve(value)
    }

    function obtainPromiseNumber(){
        generatePromiseNumber()
            .then((response) =>  alert(`The score is: ${response}`))
            .catch((error) => alert(`Something went wrong: ${error}`));
    }

    return (
        <div>
            <h1>Chusk Norris joker</h1>
        { (user !== null ?
                (
                    <div>
                        
                        <p>{user.value}</p>

                        <button onClick={obtainUser}>
                         Other Random Joker
                    </button>
                    <div>
                        <Box
                                    sx={{
                                        '& > legend': { mt: n },
                                    }}
                                    >
                                    <Typography component="legend">Rate the Joke: </Typography>
                                    <Rating
                                        name="simple-controlled"
                                        value={value}
                                        onChange={(event, newValue) => {
                                        setValue(newValue);
                                        }}
                                    />
                                    
                        </Box>
                    </div>
                    <button onClick={obtainPromiseNumber}>Overall score</button>
                    </div>
                )
            :
            (
                <div>
                    <p>Generate a new Joker</p>
                    <button onClick={obtainUser}>
                        Random Joker
                    </button>
                    
                    
                </div>
                
            )
        )}
        </div>
    );
}

export default AxiosExample;

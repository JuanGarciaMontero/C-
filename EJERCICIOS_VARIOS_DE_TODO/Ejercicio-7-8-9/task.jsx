import React, {useEffect} from 'react';
import PropTypes from 'prop-types';
import { Task } from './task.class';

//Importamos la hoja de estilos de task.scss

import './task.scss'
import { LEVELS } from './task.enum';


const TaskComponent = ({ task, complete, remove, add}) => {

    useEffect(() => {
        console.log('Teléfono creado')
        return () => {
            console.log(`El teléfono: ${task.name} se ha creado`);
        };
    }, [task]);

    /**
     * Functio tht returns a Badge
     * depending on the level of the task
     */

    function taskLevelBadge(){
        switch(task.level){
            case LEVELS.NORMAL:
                return(
                <h6 className='mb-0'>
                    <span className= 'badge bg-primary'>
                        {task.level}
                    </span>
                </h6>)
            case LEVELS.URGENT:
                return(
                <h6 className='mb-0'>
                    <span className= 'badge bg-warning'>
                        {task.level}
                    </span>
                </h6>)
            case LEVELS.BLOCKING:
                return(
                <h6 className='mb-0'>
                    <span className= 'badge bg-danger'>
                        {task.level}
                    </span>
                </h6>)
            default:
                break;
        }
    }
    /* Function that returns icon depending on completion of the task */
    function taskCompletedIcon(){
        if(task.completed){
            return (<i onClick={() => complete(task)} className='bi-toggle-on task-action' style={{color: 'green'}}>Conectado</i>)
        }else{
            return (<i onClick={() => complete(task)} className='bi-toggle-off task-action' style={{color: 'grey'}}>Desconectado</i>)
        }

    }

    return (
        <tr className='fw-normal'>
            <td>
               <span className='ms-2'>{task.names}</span> 
            </td>
            <td className='align-middle'>
                <span>{task.description}</span> 
            </td>
            <td className='align-middle'>
                {/* TODO: Sustutuir por un badge */}
                {/*<span>{task.level}</span>*/}
                {/**Execution of function to return badge element */}
                {taskLevelBadge()}
            </td>
            <td className='align-middle'>
                {/* Execution of function to return icon depending on completion */}
                
                   {taskCompletedIcon()}
                
                
                {/*<span>{task.completed ? 'Completed' : 'Pending'}</span>*/}
            </td>
            <td className='align-middle'>
                {/* Execution of function to return icon depending on completion */}
                
                <i className='bi-trash task-action' onClick={ () => remove(task)} style={{color: 'tomato'}}></i>

                {/*<span>{task.completed ? 'Completed' : 'Pending'}</span>*/}
            </td>

        </tr>
       /* <div>
                <h2 className='task-name'>
                    Nombre: { task.name }
                </h2>
                <h3>
                    Descripción: {  task.description}
                </h3>
                <h4>
                    Level: {  task.level}
                </h4>
                <h5>
                    This task is: {task.completed ? 'COMPLETED':'PENDING'}
                </h5>
           
        </div>*/
    );
};


TaskComponent.propTypes = {
    task: PropTypes.instanceOf(Task).isRequired,
    complete: PropTypes.func.isRequired,
    remove: PropTypes.func.isRequired
};


export default TaskComponent;

import React, { useState, useEffect} from 'react';
import { Task } from './task.class';
import { LEVELS } from './task.enum';
import TaskComponent from './task';
//import PropTypes from 'prop-types';

// Importamos la hoja de estilos de task.scss
import './task.scss';
import TaskForm from './taskForm';

const Agenda = ({ task }) => {


    const defaultTask1 = new Task('Pedro', '654895622', true, LEVELS.NORMAL);
    const defaultTask2 = new Task('Julian', '644257936', false, LEVELS.URGENT);
    const defaultTask3 = new Task('Alfonso', '612545225', false, LEVELS.BLOCKING);

    //Estado del componente
    const [tasks, setTasks] = useState ([defaultTask1, defaultTask2, defaultTask3]);
    const [loading, setLoading] = useState(true);

    //Control del ciclo de vida del componente
    useEffect(() => {
        console.log('Modificación de agenda');
        setLoading(false);
        return () => {
            console.log('La agenda a sido modificada')
        };
    }, [tasks]);

    //let conex='false';
    //if (props.nombre ===''|| props.apellido ==='' || props.email ===''){conex='false'} else {conex='true'};
    //const defaultTask = new Task('', '', '', conex);
    function completeTask(task){
        console.log('Actualización de la Agenda:', task); 
        const index = tasks.indexOf(task);
        const tempTasks =[...tasks];
        tempTasks[index].completed = ! tempTasks[index].completed;
        // We update the state of the component winth the new list of tasks and it will update the
        // Iteration of the tasks in order to show the task uptated
        setTasks(tempTasks);    
    }

    function deleteTask(task){
        console.log('Borrado de la Agenda:', task); 
        const index = tasks.indexOf(task);
        const tempTasks =[...tasks];
        tempTasks.splice(index,1);
        setTasks(tempTasks); 
    }

    function addTask(task){
        console.log('Añadido en la Agenda:', task); 
        const index = tasks.indexOf(task);
        const tempTasks =[...tasks];
        tempTasks.push(task);
        setTasks(tempTasks);

    }

    return (
        <div>
            <div className='col-12'>
                <div className='card'>
                    {/* Car Header (tittle) */}
                    <div className='card-header p-3'>
                        <h2>
                            Agenda:
                        </h2>
                    </div>
                    {/* Card Body (content) */}
                    <div className='card-body' data-mdb-perfect-scrollbar= 'true' style={{position: 'relative', height: '300px', width: '700px'}}>
                        <table style={{position: 'relative', height: '50px', width: '600px'}}>
                            <thead>
                                <tr>
                                    <th scope='col'>Nombre</th>
                                    <th scope='col'>Teléfono</th>
                                    <th scope='col'>Uso</th>
                                    <th scope='col'>*** ESTADO ***</th>
                                </tr>
                            </thead>
                            <tbody>
                                {/* Todo: Iterar sobre una lista de tareas */}

                                {tasks.map((task, index) => {
                                    return(
                                        <TaskComponent 
                                            key={index}
                                            task={task}
                                            complete={completeTask}
                                            remove={deleteTask}
                                            >
                                        </TaskComponent>
                                        )
                                    }
                                )}
                                
                               
                                {/*<TaskComponent task={defaultTask1} key={1} complete={completeTask}></TaskComponent>
                                <TaskComponent task={defaultTask2} key={2} complete={completeTask}></TaskComponent>
                                <TaskComponent task={defaultTask3} key={3} complete={completeTask}></TaskComponent>*/}
                            </tbody>
                        </table>
                    </div>
                    
                </div>
                      
            </div>
            {/* TODO: Aplicar un For/Map para renderizar una lista */}
            {/*<TaskComponent task={defaultTask}></TaskComponent>*/}
            <TaskForm add={addTask}></TaskForm>
        </div>
    );
};



export default Agenda;

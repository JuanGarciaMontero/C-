import React, { useReducer, useEffect} from 'react';
import { Task } from '../../models/task.class';
import { LEVELS } from '../../models/task.enum';
import TaskComponent from '../pure/task';
//import PropTypes from 'prop-types';

// Importamos la hoja de estilos de task.scss
import '../../styles/task.scss';
import TaskForm from '../pure/forms/taskForm';

const TaskListComponent = ({ task }) => {


    const defaultTask1 = new Task('Example1', 'Description1', true, LEVELS.NORMAL);
    const defaultTask2 = new Task('Example2', 'Description2', false, LEVELS.URGENT);
    const defaultTask3 = new Task('Example3', 'Description3', false, LEVELS.BLOCKING);

    //Actions
    const TASKS = 'TASKS';
    const LOADING = 'LOADING';

    // INITIAL STATE
    const initialState = {
        tasks: [defaultTask1, defaultTask2, defaultTask3],
        loading: true
    }

    //Reducer
const Reducer = (state, action) => {

    switch (action.type) {
        case TASKS:
            return {
                ...state,
                Loading: true
            }
        case LOADING:
             return {
                ...state,
                 Loading: false
            }

        default:
            break;
        }  
    }

    const [state, dispatch] = useReducer(Reducer, initialState)

    // Obtain all variables from state
    const { tasks , loading } = state;


    //Control del ciclo de vida del componente
    useEffect(() => {
        console.log('Modificación de tareas');
        setTimeout(() => {
            dispatch({type:LOADING});
        }, 2000); 
        return () => {
            console.log('Tarea a sido modificada')
        };
    }, [tasks]);

    //let conex='false';
    //if (props.nombre ===''|| props.apellido ==='' || props.email ===''){conex='false'} else {conex='true'};
    //const defaultTask = new Task('', '', '', conex);
    function completeTask(task){
        console.log('Complete this Task:', task); 
        const index = tasks.indexOf(task);
        const tempTasks =[...tasks];
        tempTasks[index].completed = ! tempTasks[index].completed;
        // We update the state of the component winth the new list of tasks and it will update the
        // Iteration of the tasks in order to show the task uptated
        dispatch({type:TASKS});   
    }

    function deleteTask(task){
        console.log('Delete this Task:', task); 
        const index = tasks.indexOf(task);
        const tempTasks =[...tasks];
        tempTasks.splice(index,1);
        dispatch({type:TASKS}); 
    }

    function addTask(task){
        console.log('Add this Task:', task);
        const tempTasks =[...tasks];
        tempTasks.push(task);
        dispatch({type:TASKS});

    }

    const Table = () => {
        return (

            <table>
                <thead>
                    <tr>
                        <th scope='col'>Tittle</th>
                        <th scope='col'>Description</th>
                        <th scope='col'>Priority</th>
                        <th scope='col'>Actions</th>
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

                </tbody>
            </table>

        )
    }

    let tasksTable;

    if(tasks.length > 0){
        tasksTable = <Table></Table>
    }else{
        tasksTable = (<div>
                        <h5>There are no tasks to show</h5>
                        <h5>Please, create one</h5>
                     </div>)
    }

    const loadingStyle = {
        color: 'grey',
        fontSize: '30px',
        fontWeight: 'bold'
    }

    return (
        <div>
            <div className='col-12'>
                <div className='card'>
                    {/* Car Header (tittle) */}
                    <div className='card-header p-3'>
                        <h2>
                            Your tasks:
                        </h2>
                    </div>
                    {/* Card Body (content) */}
                    <div className='card-body' data-mdb-perfect-scrollbar= 'true' style={{position: 'relative', height: '300px', width: '350px'}}>
                        {/* TODO: Add Loading Spinner */}
                        {loading ? tasksTable : (<p style={loadingStyle}>Loading tasks...</p>)}
                    </div>
                    
                </div>
                      
            </div>
            {/* TODO: Aplicar un For/Map para renderizar una lista */}
            {/*<TaskComponent task={defaultTask}></TaskComponent>*/}
            <TaskForm add={addTask} nlength={tasks.length}></TaskForm>
        </div>
    );
};



export default TaskListComponent;

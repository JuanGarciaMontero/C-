import React, {useRef} from 'react';
import PropTypes from 'prop-types';
import { Formik, Form, Field, ErrorMessage} from 'formik';
import * as Yup from 'yup';
import { Task } from '../../../models/task.class';
import { LEVELS } from '../../../models/task.enum';

const TaskForm = ({add, nlength}) => {

    function addTask(e) {
        e.preventDefault();
        const newTask = new Task(
            nameRef.current.value,
            descriptionRef.current.value,
            false,
            levelRef.current.value

        );
        add(newTask);
    }

    const nameRef = useRef('');
    const descriptionRef = useRef('');
    const levelRef = useRef('LEVELS.NORMAL');

    const initialValues = {
        nameRef: '',
        descriptionRef: '',
        levelRef: LEVELS.NORMAL

    }
    

    const normalStyle = {
        color: 'blue',
        fontWeight: 'bold'
    }

    const urgentStyle = {
        color: 'yellow',
        fontWeight: 'bold'
    }

    const blockingStyle = {
        color: 'tomato',
        fontWeight: 'bold'
    }

    const registerSchema = Yup.object().shape(
        {
            nameRef: Yup.string()
                .min(4, 'Task name too short')
                .max(8,'Task name too long')
                .required('Task name is required'),
            descriptionRef: Yup.string()
                .min(6, 'Task name too short')
                .max(12,'Task description too long')
                .required('Task description is required')
         }
    )


    return (
        <div>
            <Formik
                    initialValues = {initialValues}
                    // *** Yup Validation Schema ***
                    validationSchema = {registerSchema}
                    // **onSubmit Event
                    onSubmit={async (values) => {
                        await new Promise((r) => setTimeout(r, 1000));
                        alert(JSON.stringify(values, null, 2))               
                     }}
                >
                {({ values,
                        touched,
                        errors,
                        isSubmitting,
                        handleChange,
                        handleBlur}) => (
                            <Form onSubmit={addTask} className='d-flex justify-content-center align-items-center mb-4'>
                                <div className='form-outline flex-fill'>
                                    <label htmlFor="nameRef">Task Name: </label>
                                    <Field ref={nameRef} id="inputName" type="text" name="nameRef" className='form-control form-control-lg' required autoFocus placeholder='Task Name' />
                                   
                                    
                                        {/* Task name Errors */}
                                        {
                                            errors.nameRef && touched.nameRef &&
                                            (
                                            
                                                <ErrorMessage name="nameRef" component='div'></ErrorMessage>
                                            
                                            )
                                        }

                                    <label htmlFor="descriptionRef">Task Descriptions: </label>
                                    <Field ref={descriptionRef} id="descriptionRef" type="text" name="descriptionRef" className='form-control form-control-lg' required placeholder='Task Description' />
                                        {/* Task descriptions Errors */}
                                    {
                                        errors.descriptionRef && touched.descriptionRef &&
                                        (
                                            
                                                <ErrorMessage name="descriptionRef" component='div'></ErrorMessage>
                                            
                                        )
                                    }

                                    <select style={normalStyle} className='form-control form-control-lg' ref={levelRef} defaultValue={LEVELS.NORMAL} id='selectLevel'>
                                        <option style={normalStyle} value={LEVELS.NORMAL}>
                                            Normal
                                        </option>
                                        <option style={urgentStyle} value={LEVELS.URGENT}>
                                            Urgent
                                        </option>
                                        <option style={blockingStyle} value={LEVELS.BLOCKING}>
                                            Blocking
                                        </option>
                                    </select>

                                    <button type='submit' className='btn btn-success btn-lg ms-3'>
                                        {nlength > 0 ? 'Add New Task' : 'Create your First Task'}
                                    </button>
                                </div>   
                            </Form>
                        )
                }
            </Formik>
        </div>
    );
}

TaskForm.protoType = {
    add: PropTypes.func.isRequired,
    nlength: PropTypes.number.isRequired
}

export default TaskForm;

//import { LEVELS } from "./task.enum";

export class Task {
    names = '';
    description = '';
    completed = true;
    level = true;
   /* nombre = 'Juan';
    apellido = 'Apellido-Description';
    email = 'Email-Prioridad';
    conectado = true;*/

    constructor(names, description, completed,level){
        this.names= names;
        this.description= description;
        this.completed= completed;
        this.level= level
    }
   /* constructor(nombre, apellido, email, conectado){
        this.nombre= nombre;
        this.apellido= apellido;
        this.email= email;
        this.conectado= conectado
    }*/
}
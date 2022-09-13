import logo from './logo.svg';
import './App.css';
//import Greeting from './components/pure/greeting';
//import GreetingF from './components/pure/greetingF';
import TaskListComponent from './components/container/task_list';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        {/* Componente Propio Greeting.jsx */}
        {/*<Greeting name="Pedro"></Greeting> */}
        {/*<GreetingF name="Fernando"></GreetingF>*/}
        <TaskListComponent nombre="Juan" apellido="García" email="juan@gmail.com"></TaskListComponent>
      </header>
    </div>
  );
}

export default App;

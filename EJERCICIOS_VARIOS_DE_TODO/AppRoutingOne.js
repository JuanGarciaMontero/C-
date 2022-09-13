import { useEffect} from 'react';

import { BrowserRouter as Router, Route, Routes, Link, Navigate} from 'react-router-dom';

import HomePage from './pages/home/HomePage';
import NotFounsPage from './pages/404/NotFounsPage';
import AboutPage from './pages/about-faqs/AboutPage';
import ProfilePage from './pages/profile/ProfilePage';
import TasksPage from './pages/tasks/TasksPage'
import TaskDetailPage from './pages/tasks/TaskDetailPage';
import LoginPage from './pages/auth/LoginPage';
import StatePage from './pages/home/StatePage';
import RegisterPage from './pages/auth/RegisterPage'


function AppRoutingOne() {

  let logged = false;

  let taskList =[
   { id: 1,
    name:'Task 1',
    description: 'My first Task'
   },
   { id: 2,
    name:'Task 2',
    description: 'My second Task'
   }

  ]

  useEffect(() => {
    logged = localStorage.getItem('credentials');
    console.log('User Logged?', logged)
  }, [])

  logged = localStorage.getItem('credentials');

  return (
    <Router>
      <div align='center'>
        <aside>
            <Link to='/'>|| HOME |</Link>
            <Link to='/about' >| ABOUT |</Link>
            <Link to='/faqs' >| FAQS |</Link>
            <Link to='/task/1' >| Task 1 |</Link>
            <Link to='/task/2' >| Task 2 |</Link>
            <Link to='/any404' >| Not Existing Route |</Link>
            <Link to='/login' >| LOGIN ||</Link>
        </aside>

        <main>
        
          <Routes>
            <Route exact path='/' element={ < HomePage /> } />
            <Route path='/online-state' element={ < StatePage/> } />
            <Route path='/login' element=
              { 
                logged ?
                <Navigate to='/' /> 
                :
                <LoginPage />
              } />
            <Route path='/about' element={ < AboutPage /> } />
            <Route path='/faqs' element={ < AboutPage /> } />
            <Route path='/profile' element=
              {
               logged ? 
                <ProfilePage/> 
                :
                <Navigate to="/login" />
              } /> 
            <Route path='/register' element=
              {
               logged ? 
                <ProfilePage/> 
                :
                <RegisterPage />
              } />       
            <Route path='/tasks' element={ < TasksPage /> } />
            <Route
                exact
                path='/task/:id'
                element={
                  <TaskDetailPage task={taskList[0]} />
                }
              >
              </Route>
            {/* 404 - Page No Found */}
            <Route path='*' element={ < NotFounsPage /> } />
            
          </Routes>
      
        </main>

      </div>

    </Router>
    
  );
}

export default AppRoutingOne;

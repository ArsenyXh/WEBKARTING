
import './App.css';
import { BrowserRouter, Route,Routes } from 'react-router-dom';
import AppContent from './AppContent';
import Header from './Header';
import Contact from './Contact';
import Services from './Services';
import Home from './Home';
import Footer from './footer';

function App() {
  return (
    <BrowserRouter>
    <div className="Appp">
    <Header/>
    <Routes>
    <Route path='/s'  element={  <AppContent />}/>
    <Route path='/cont'  element={  <Contact />}/>
    <Route path='/serv'  element={  <Services />}/>
    <Route path='/home'  element={  <Home />}/>
    </Routes>

    </div>
    <Footer/>
    </BrowserRouter>
  );
}

export default App;
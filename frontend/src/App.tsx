import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Experiences from './pages/Experiences';
import MainHeader from './components/main-header/main-header';
import Home from './pages/Home';

export default function App() {
  return (
    <BrowserRouter>
      <div className="app">
        <MainHeader />
        <main>
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/experiences" element={<Experiences />} />
          </Routes>
        </main>
      </div>
    </BrowserRouter>
  );
}

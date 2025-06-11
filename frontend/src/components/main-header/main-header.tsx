import { NavLink } from 'react-router-dom';
import classes from './main-header.module.css';
import MainHeaderBackground from './main-header-background';

export default function MainHeader() {
  return (
    <>
      <MainHeaderBackground />
      <header className={classes.header}>
        <h1 className={classes.title}>Espen Askeladd sin CV</h1>
        <div className={classes.nav}>
          <NavLink 
            to="/" 
            className={({ isActive }) =>
              isActive ? classes.active : undefined
            }
            end
          >
            Om meg
          </NavLink>
          <NavLink 
            to="/experiences" 
            className={({ isActive }) =>
              isActive ? classes.active : undefined
            }
          >
            Erfaring
          </NavLink>
        </div>
      </header>
    </>
  );
}

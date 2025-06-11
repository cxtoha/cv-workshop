import classes from "./main-header-background.module.css";

export default function MainHeaderBackground() {
  return (
    <div className={classes["header-background"]}>
      <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 1440 320" preserveAspectRatio="none" width="100%" height="100%">
        <defs>
          <linearGradient id="gradient" x1="0%" y1="0%" x2="100%" y2="0%">
            <stop
              offset="0%"
              style={{ stopColor: "#0087C3", stopOpacity: "1" }}
            />
            <stop
              offset="100%"
              style={{ stopColor: "#00253E", stopOpacity: "1" }}
            />
          </linearGradient>
        </defs>
        <path
          fill="url(#gradient)"
          d="M0,200L48,190C96,180,192,160,288,150C384,140,480,145,576,150C672,155,768,155,864,150C960,145,1056,135,1152,125C1248,115,1344,105,1392,100L1440,95L1440,0L1392,0C1344,0,1248,0,1152,0C1056,0,960,0,864,0C768,0,672,0,576,0C480,0,384,0,288,0C192,0,96,0,48,0L0,0Z"
        ></path>
      </svg>
    </div>
  );
}

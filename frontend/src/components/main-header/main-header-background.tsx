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
          d="M0,0L48,0C96,0,192,0,288,0C384,0,480,0,576,0C672,0,768,0,864,0C960,0,1056,0,1152,0C1248,0,1344,0,1392,0L1440,0L1440,320L1392,300C1344,280,1248,240,1152,220C1056,200,960,160,864,140C768,120,672,120,576,130C480,140,384,160,288,140C192,120,96,60,48,30L0,0Z"
        ></path>
      </svg>
    </div>
  );
}

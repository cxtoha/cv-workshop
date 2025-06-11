// src/main.tsx
import React from "react";
import ReactDOM from "react-dom/client";
import App from "./App";
// Import Computas design system
import "@computas/designsystem/global-styles.css";
import { addIcons } from "@computas/designsystem/icon";
// Import all icons you need throughout the app
import { bin, download, time, calendar, edit, location } from "@computas/designsystem/icon/iconRegistry";
import "./index.css"; // Optional: Global styles

addIcons(bin, download, time, calendar, edit, location);

ReactDOM.createRoot(document.getElementById("root")!).render(
    <React.StrictMode>
        <App />
    </React.StrictMode>
);

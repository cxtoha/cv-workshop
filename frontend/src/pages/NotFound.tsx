import { Link } from "react-router-dom";
import styles from "./NotFound.module.css";

export default function NotFound() {
  return (
    <div className={styles.notFound}>
      <h1 className={styles.title}>404</h1>
      <p className={styles.message}>Beklager, denne siden finnes ikke</p>
      <Link className="cx-link cx-link--standalone cx-mr-6" to="/">
        Gå til forsiden
      </Link>
    </div>
  );
}

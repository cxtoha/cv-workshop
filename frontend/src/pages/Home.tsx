
import styles from "./Home.module.css";
import { useUsers } from "../hooks/useUsers";

export default function Home() {
  const { data: users } = useUsers();
  console.log('Users: ', users)
  return (
    <div className={styles.container}>
    </div>
  );
}

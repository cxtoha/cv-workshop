import { useEffect, useState } from "react";
import { fetchUsers, fetchExperiences } from "../api";
import { User, Experience } from "../types";
import styles from "./Home.module.css";
import "../App.css";


export default function Home() {
  const [users, setUsers] = useState<User[]>([]);
  const [experiences, setExperiences] = useState<Experience[]>([]);
  const [isLoading, setIsLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  // Group experiences by userId
  const experiencesByUser: Record<string, Experience[]> = {};
  experiences.forEach((exp) => {
    if (!experiencesByUser[exp.userId]) {
      experiencesByUser[exp.userId] = [];
    }
    experiencesByUser[exp.userId].push(exp);
  });

  useEffect(() => {
    setIsLoading(true);
    setError(null);

    Promise.all([fetchUsers(), fetchExperiences()])
      .then(([usersData, expsData]) => {
        setUsers(usersData);
        setExperiences(expsData);
      })
      .catch((err) => {
        console.error("Error loading data:", err);
        setError("Could not load users or experiences.");
      })
      .finally(() => {
        setIsLoading(false);
      });
  }, []);

  if (isLoading) {
    return <p className={styles.loading}>Loading users and experiences…</p>;
  }

  if (error) {
    return <p className={styles.error}>{error}</p>;
  }

  return (
    <div className="container">
      {/* <h1>About me</h1> */}
    </div>
  );
}

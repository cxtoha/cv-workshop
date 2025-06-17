import { useEffect, useState } from "react";
import { fetchUsers, fetchExperiences } from "../api";
import { Experience, User } from "../types/types";
import styles from "./Home.module.css";
import teamworkImage from "../assets/teamwork.png";

export default function Home() {
  const [experiences, setExperiences] = useState<Experience[]>([]);
  const [users, setUsers] = useState<User[]>([]);
  const [isLoading, setIsLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

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
    <div className={styles.container}>
      <img
        src={teamworkImage}
        alt="Team collaboration illustration"
        className={styles.image}
      />
      <div className={styles.usersGrid}>
        {users.map((user) => (
          <div key={user.id} className={styles.userCard}>
            {user.imageUrl && (
              <img
                src={user.imageUrl}
                alt={user.name}
                className={styles.userImage}
              />
            )}
            <h3>{user.name}</h3>
            <p>
              <strong>University:</strong> {user.university}
            </p>
            <p>
              <strong>Description:</strong> {user.description}
            </p>
            <p>
              <strong>Skills:</strong>
              {user.skills.map((skill) => skill.technology).join(", ")}
            </p>
          </div>
        ))}
      </div>
    </div>
  );
}

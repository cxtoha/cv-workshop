import { useState, useEffect } from "react";
import { Experience } from "../types";
import styles from "./Experiences.module.css";
import { fetchExperiences } from "../api";
import { ExperienceCard } from "../components/ExperienceCard";

export default function Experiences() {
  const [experiences, setExperiences] = useState<Experience[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    async function getExperiences() {
      try {
        const data = await fetchExperiences();
        setExperiences(data);
        setError(null);
      } catch (err) {
        console.log(err);
        setError("Failed to load experiences. Please try again later.");
      } finally {
        setLoading(false);
      }
    }

    getExperiences();
  }, []);

  if (loading) {
    return <div className={styles.loading}>Loading experiences...</div>;
  }

  if (error) {
    return <div className={styles.error}>{error}</div>;
  }

  if (experiences.length === 0) {
    return <div className={styles.noExperiences}>No experiences found.</div>;
  }

  console.log(experiences);

  return (
    <div className={styles.experiences}>
      {experiences.map((experience) => (
        <ExperienceCard key={experience.id} experience={experience} />
      ))}
    </div>
  );
}

import { useState, useEffect } from "react";
import { Experience } from "../types/types";
import styles from "./Experiences.module.css";
import { fetchExperiences } from "../api";
import { ExperienceCard } from "../components/experiences/ExperienceCard";
import { CxOption, CxSelect } from "@computas/designsystem/select/react";

import { experienceTypeMap } from '../types/experienceTypes';

export default function Experiences() {
  const [experiences, setExperiences] = useState<Experience[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [selectedExperience, setSelectedExperience] = useState<string | null>(null); // Track selected filter type

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

  const handleSelectChange = (e: Event) => {
    const customEvent = e as CustomEvent;
    setSelectedExperience(customEvent.detail.value || null);
  };

  return (
    <div className={styles.container}>
      <div className={styles.select}>
        <label className="cx-form-field">
          <div className="cx-form-field__input-container">
            <CxSelect onChange={handleSelectChange}>
              <CxOption value="">Ingen filtrering</CxOption>
              {Object.entries(experienceTypeMap).map(([type, data]) => (
                <CxOption key={type} value={type}>
                  {data.text}
                </CxOption>
              ))}
            </CxSelect>
          </div>
        </label>
      </div>
      <div className={styles.experiences}>
        {experiences
          .filter((experience) =>
            selectedExperience ? experience.type === selectedExperience : true
          )
          .map((experience) => (
            <ExperienceCard key={experience.id} experience={experience} />
          ))}
      </div>
      {experiences.filter((experience) =>
        selectedExperience ? experience.type === selectedExperience : true
      ).length === 0 && (
        <div className={styles.noExperiences}>Ingen erfaringer funnet</div>
      )}
    </div>
  );
}

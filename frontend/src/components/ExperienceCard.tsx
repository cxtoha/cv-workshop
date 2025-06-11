import { Experience } from "../types";
import styles from "./ExperienceCard.module.css";
import akersgataImage from "../assets/akersgata.jpg";
import { CxIcon } from "@computas/designsystem/icon/react";
import { ExperienceChip } from "./ExperienceChip";

interface ExperienceCardProps {
    experience: Experience;
}

export function ExperienceCard({ experience }: ExperienceCardProps) {
    return (
      <div className={styles.container}>
        <img
          className={styles.image}
          src={akersgataImage} // replace with correct imageurl
          alt={experience.title}
        />
        <div className={styles.chip}>
          <ExperienceChip type={experience.type}/>
        </div>
        <div className={styles.info}>
          <p className={styles.period}>
            <CxIcon name="calendar" size="5" />{" "}
            {new Date(experience.startDate).toLocaleDateString()} -{" "}
            {new Date(experience.endDate).toLocaleDateString()}
          </p>
          <p className={styles.description}>{experience.description}</p>
          <h4 className={styles.eventTitle}>{experience.title}</h4>
        </div>
      </div>
    );
}

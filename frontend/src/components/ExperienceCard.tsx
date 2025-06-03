import { Experience } from "../types";
import styles from "./ExperienceCard.module.css";

interface ExperienceCardProps {
    experience: Experience;
}

export function ExperienceCard({ experience }: ExperienceCardProps) {
    return (
        <div className={styles.container}>
            <h4 className={styles.title}>{experience.title}</h4>
            <p className={styles.role}>
                <strong>Role:</strong> {experience.role}
            </p>
            <p className={styles.period}>
                <strong>Period:</strong>{" "}
                {new Date(experience.startDate).toLocaleDateString()} –{" "}
                {experience.endDate
                    ? new Date(experience.endDate).toLocaleDateString()
                    : "Present"}
            </p>
            <p className={styles.description}>{experience.description}</p>
        </div>
    );
}

import { User, Experience } from "../types";
import { ExperienceCard } from "./ExperienceCard";
import styles from "./UserCard.module.css";

interface UserCardProps {
    user: User;
    experiences: Experience[];
}

export function UserCard({ user, experiences }: UserCardProps) {
    const skillsList = user.skills.split(";").map((s) => s.trim());

    return (
        <div className={styles.container}>
            <div className={styles.header}>
                <div className={styles.userInfo}>
                    <h2 className={styles.name}>{user.name}</h2>
                    <p className={styles.userDetail}>
                        <strong>Birth Date:</strong>{" "}
                        {new Date(user.birthDate).toLocaleDateString()}
                    </p>
                    <p className={styles.userDetail}>
                        <strong>University:</strong> {user.university}
                    </p>
                    <p className={styles.userDetail}>
                        <strong>Location:</strong> {user.address}
                    </p>
                    <p className={styles.userDetail}>
                        <strong>Phone:</strong> {user.phone}
                    </p>
                    {user.linkedInUrl && (
                        <p className={styles.userDetail}>
                            <strong>LinkedIn:</strong>{" "}
                            <a
                                href={user.linkedInUrl}
                                target="_blank"
                                rel="noopener noreferrer"
                            >
                                {user.linkedInUrl}
                            </a>
                        </p>
                    )}
                </div>
            </div>

            <p className={styles.description}>
                <strong>Description:</strong> {user.description}
            </p>
            <p className={styles.skills}>
                <strong>Skills:</strong> {skillsList.join(", ")}
            </p>

            {experiences.length > 0 ? (
                <div className={styles.experiencesSection}>
                    <h3 className={styles.experiencesTitle}>Experiences:</h3>
                    {experiences.map((exp) => (
                        <ExperienceCard key={exp.id} experience={exp} />
                    ))}
                </div>
            ) : (
                <p className={styles.noExperiences}>No experiences found.</p>
            )}
        </div>
    );
}

// src/components/CvEntry.tsx
import styles from './CvEntry.module.css';
import { CvEntry as CvEntryType } from '../types';

export function CvEntry({ entry }: { entry: CvEntryType }) {
    return (
        <div className={styles.entry}>
            <h2>{entry.title}</h2>
            <p>{entry.description}</p>
            <small>
                {entry.startDate} – {entry.endDate ?? 'nå'}
            </small>
        </div>
    );
}

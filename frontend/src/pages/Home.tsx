// src/pages/Home.tsx
import { useEffect, useState } from "react";
import { fetchCvEntries } from "../api";
import { CvEntry as CvEntryType } from "../types";
import { CvEntry } from "../components/CvEntry";

export default function Home() {
    const [entries, setEntries] = useState<CvEntryType[]>([]);

    useEffect(() => {
        fetchCvEntries()
            .then(setEntries)
            .catch(err => console.error("Error loading CV entries:", err));
    }, []);

    return (
        <div>
            <h1>CV</h1>
            {entries.map(e => (
                <CvEntry key={e.id} entry={e} />
            ))}
        </div>
    );
}

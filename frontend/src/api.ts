// src/api.ts
import { CvEntry } from "./types";

const API_URL = import.meta.env.VITE_API_URL;
const API_KEY = import.meta.env.VITE_API_KEY;

export async function fetchCvEntries(): Promise<CvEntry[]> {

    console.log("API_URL:", import.meta.env.VITE_API_URL);
    console.log("API_KEY:", import.meta.env.VITE_API_KEY);

    const res = await fetch(`${API_URL}/cv-entries`, {
        method: "GET",
        headers: {
            'X-Frontend-Api-Key': API_KEY
        }
    });

    if (!res.ok) throw new Error("Failed to fetch CV entries");

    return res.json();
}
